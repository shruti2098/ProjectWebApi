using SurfaceDevlopment.Data;
using SurfaceDevlopment.Interface;
using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Repo
{
    public class PropertyInformationRepo : IPropertyInformation
    {
        ApplicationDbContext _context;
        public PropertyInformationRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PropertyInformation> GetPropertyInformation()
        {
            return _context.propertyInformation.ToList();
        }
        public PropertyInformation GetPropertyInformationById(int id)
        {
            return _context.propertyInformation.FirstOrDefault(e => e.PropertyInformationId == id);
        }
        public PropertyInformation AddPropertyInformation(PropertyInformation propertyInformation)
        {
            _context.Add(propertyInformation);
            _context.SaveChanges();
            return propertyInformation;
        }
        public PropertyInformation UpdatePropertyInformation(PropertyInformation propertyInformation)
        {
            _context.Update(propertyInformation);
            _context.SaveChanges();
            return propertyInformation;
        }
        public void DeletePropertyInformation(int id)
        {
            var deleteproperty = _context.propertyInformation.Where(s => s.PropertyInformationId == id).FirstOrDefault();
            if (deleteproperty != null)
            {
                _context.Remove(deleteproperty);
                _context.SaveChanges();
            }
        }
    }
}
