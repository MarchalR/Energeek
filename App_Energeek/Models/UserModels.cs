using System;
using System.ComponentModel.DataAnnotations;

namespace App_Energeek.Models
{
    public partial class Login

    {

        [Required(ErrorMessage = "User Name is Required")]

        public string UserName { get; set; }



        [Required(ErrorMessage = "Password is Required")]

        public string Password { get; set; }

    }

    public partial class User

    {

        //public int Id { get; set; }



        [Display(Name = "User Name")]

        [Required(ErrorMessage = "User Name Is Required")]

        public string userName { get; set; }



        [Display(Name = "First Name")]

        [Required(ErrorMessage = "First Name Is Required")]

        public string firstName { get; set; }


        [Display(Name = "Last Name")]

        [Required(ErrorMessage = "Last Name Is Required")]

        public string lastName { get; set; }



        [Display(Name = "Email")]

        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]

        [Required(ErrorMessage = "Email Is Required")]

        public string email { get; set; }



        [Display(Name = "Password")]

        [Required(ErrorMessage = "Password is required")]

        public string password { get; set; }

    }

    public partial class Register

    {

        //public int Id { get; set; }



        [Display(Name = "User Name")]

        [Required(ErrorMessage = "User Name Is Required")]

        public string userName { get; set; }



        [Display(Name = "First Name")]

        [Required(ErrorMessage = "First Name Is Required")]

        public string firstName { get; set; }


        [Display(Name = "Last Name")]

        [Required(ErrorMessage = "Last Name Is Required")]

        public string lastName { get; set; }



        [Display(Name = "Email")]

        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]

        [Required(ErrorMessage = "Email Is Required")]

        public string email { get; set; }



        [Display(Name = "Password")]

        [Required(ErrorMessage = "Password is required")]

        public string password { get; set; }

    }
}
