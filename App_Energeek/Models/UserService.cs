using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace App_Energeek.Models
{
    public class UserService
    {
        public HttpClient _client = new HttpClient();

        public User Get(int id)
        {
            var resp = _client.GetAsync("https://localhost:5001/api/users/" + id).Result;
            if (resp.IsSuccessStatusCode)

                return JsonConvert.DeserializeObject<User>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public string RegisterApi(User user)
        {
           var toSend = JsonConvert.SerializeObject(user);

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("https://localhost:5001/api/users/add");
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
