using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWeb.Models
{
    public class Producto
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int stock { get; set; }
        public int precio { get; set; }
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; }
    }
}