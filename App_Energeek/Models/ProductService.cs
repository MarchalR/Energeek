using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App_Energeek.Models
{
    public class ProductService
    {
        HttpClient _client = new HttpClient();

        public Product Get(int id)
        {
            var resp = _client.GetAsync("https://localhost:5001/api/values/" + id).Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Product>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public List<Product> GetAll()
        {
            var resp = _client.GetAsync("https://localhost:5001/api/values/").Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<Product>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public List<KeyValuePair<string, int>> GetStats(){

            var inElec = 0;
            var outElec = 0;

            var allProduct = GetAll();

            Console.WriteLine(JsonConvert.SerializeObject(allProduct));


            var results = JToken.Parse(JsonConvert.SerializeObject(allProduct));


            Console.WriteLine(results);

            //JToken memberName = results.First["Name"];
            JToken memberName = results.Where["Generating" == "true"];
            Console.WriteLine(memberName);


            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("In", 1));
            list.Add(new KeyValuePair<string, int>("Out", 2));
            list.Add(new KeyValuePair<string, int>("Difference", 4));

            return list;
        }

        public string AddProduct(Product product){
            var toSend = JsonConvert.SerializeObject(product);

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("https://localhost:5001/api/values");
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            // Create POST data and convert it to a byte array.  
            string postData = toSend;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status. 
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content. 
            var reponse = responseFromServer;
            Console.WriteLine(reponse);
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();


            return reponse;
        }
    }
}
