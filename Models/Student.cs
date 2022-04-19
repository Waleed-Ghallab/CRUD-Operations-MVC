using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Student
    {
        [Required(ErrorMessage ="this field is required")]
        public int id { get; set; }
        [StringLength(10,MinimumLength =4,ErrorMessage ="invalid input"),Required]
        public string name { get; set; }
        [Required,Range(20,30)]
        public int age { get; set; }
        [Required]
        [Remote("chkUserName","student")]
        public string userName { get; set; }

    }
}
