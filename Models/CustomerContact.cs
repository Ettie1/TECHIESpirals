using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
//using Microsoft.AspNetCore.Mvc.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinuxTECHIESpirals.Models
{
    public class CustomerContact
    {
        public int Id { get; set;}
        [Required]
        public string Fullname {get; set;} = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        public string ServiceRequired {get; set;} = string.Empty;
        public string ServiceMessage {get; set;} = string.Empty;
    }
}