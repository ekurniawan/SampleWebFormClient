using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace SampleASPNETClient.Models
{
    public class Mahasiswa
    {
        [Required]
        public string Nim { get; set; }

        [Required]
        public string Nama { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public double IPK { get; set; }
    }
}