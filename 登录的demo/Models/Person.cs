using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Person
    {
        [Required(ErrorMessage ="名字必填")]
        [Display(Name ="名字")]
        public string Name { get; set; }
        [Required(ErrorMessage = "昵称必填")]
        [Display(Name = "昵称")]
        public string Nick { get; set; }
        [Required(ErrorMessage = "年龄必填")]
        [Display(Name = "年龄")]
        public int Age { get; set; }

    }
}