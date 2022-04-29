using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Models
{
    public class PropertyInformation
    {
        //public enum PropertyTypes
        //{
        //    Residental,
        //    NonResidental
        //}
        [Key]
        public int PropertyInformationId { get; set; }
        public int UniqueId { get; set; }
        
        public int MapId { get; set; }
        public string Rural { get; set; }
        public string DomainLandSurvey { get; set; }
        public string NationalTopographicSeries { get; set;  }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CompanyName { get; set; }
        public string OperatingArea { get; set; }
        public string ResidentImage { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedAt { get; set; }
        public Boolean IsActive { get; set; }

  }
}
