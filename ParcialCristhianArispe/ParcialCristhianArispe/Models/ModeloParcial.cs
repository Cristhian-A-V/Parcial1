using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Http.Routing.Constraints;
using System.Web.UI.WebControls;

namespace ParcialCristhianArispe.Models
{
    public class ModeloParcial
    {
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Alpha3Code { get; set; }
        [Required(ErrorMessage ="You must enter the field {0}")]
        public string Region { get; set; }
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter the field {0}")]
        public int Area { get; set; }
        [Required(ErrorMessage = "You must enter the field {0}")]
        public int CallingCodes { get; set; }
        [Required(ErrorMessage = "You must enter the field {0}")]
        public List<string> Languages { get; set; }
        [Required(ErrorMessage = "You must enter the field {0}")]
        public HyperLink Flag { get; set; }
    }
}