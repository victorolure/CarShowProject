using System;
using System.Collections.Generic;

namespace CarShowProject.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public bool? IsActive { get; set; }= null!; 
      
    
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
