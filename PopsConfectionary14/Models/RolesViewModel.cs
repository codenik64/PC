using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PopsConfectionary14.Models
{
    public class RolesViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}