using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string CountryName { get; set; }
        public virtual Country Country { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedAt { get; set; }
        public Boolean IsActive { get; set; }
  }
}
