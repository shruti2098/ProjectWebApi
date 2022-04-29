using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Interface
{
    public interface IPropertyInformation
    {
        public List<PropertyInformation> GetPropertyInformation();
        public PropertyInformation GetPropertyInformationById(int PropertyId);
        public PropertyInformation AddPropertyInformation(PropertyInformation propertyInformation);
        public PropertyInformation UpdatePropertyInformation(PropertyInformation propertyInformation);
        public void DeletePropertyInformation(int id);
    }
}
