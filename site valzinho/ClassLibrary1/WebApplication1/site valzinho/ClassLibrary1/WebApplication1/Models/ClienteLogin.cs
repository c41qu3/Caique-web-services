using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class ClienteLogin
    {
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Senha { get; set; }
    }
}