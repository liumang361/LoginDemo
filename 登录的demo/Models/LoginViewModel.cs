using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="用户名必填")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "密码必填")]
        public string  Password { get; set; }
    }
}