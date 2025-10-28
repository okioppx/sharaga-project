using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public bool IsAvailable { get; set; }
    }
}


