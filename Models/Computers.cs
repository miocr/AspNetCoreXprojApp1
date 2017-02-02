using System;
using System.Collections.Generic;

namespace MvcApp.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }

        public string Name { get; set; }

        public string Brand {get;set;}

        public Person Owner { get; set; }
    }

}