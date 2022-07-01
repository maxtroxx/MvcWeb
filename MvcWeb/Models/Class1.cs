using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWeb.Models
{
    public class Class1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombreComprador { get; set; }
        public int idComprador { get; set; }

    }
}