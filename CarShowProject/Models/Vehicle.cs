using System;
using System.Collections.Generic;

namespace CarShowProject.Models
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int BrandId { get; set; }
        public int? MSRP { get; set; } = null!;
        
    
        public virtual Brand Brand { get; set; } = null!;
    }
}
