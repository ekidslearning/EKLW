//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        public int U_Id { get; set; }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]

        public string Password { get; set; }
        public string Role { get; set; }
        public string UImage { get; set; }
    }
}
