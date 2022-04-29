using SurfaceDevlopment.Data;
using SurfaceDevlopment.Interface;
using SurfaceDevlopment.Models;
using SurfaceDevlopment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Repo
{
    public class CountryRepo : ICountry
    {
        ApplicationDbContext _context;
        public CountryRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
            
        }
        public Country GetCountryById(int id)
        {
            return _context.Countries.FirstOrDefault(e => e.Id == id);
        }
        public Country AddCountry(Country country)
        {
            _context.Add(country);
            _context.SaveChanges();
            return country;
        }
        public Country UpdateCountry(Country country)
        {
            _context.Update(country);
            _context.SaveChanges();
            return country;
        }
        public void DeleteCountry(int id)
        {
            var deletecountry = _context.Countries.Where(s => s.Id == id).FirstOrDefault();
            if (deletecountry != null)
            {
                _context.Remove(deletecountry);
                _context.SaveChanges();
            }
        }
    //public Country GetCountryPagingList(Country id)
    //{
    //  //_context.Update(country);
    //  //_context.SaveChanges();
    //  return id;
    //  //_context.propertyInformation(id);
       
    //}
  }
}
