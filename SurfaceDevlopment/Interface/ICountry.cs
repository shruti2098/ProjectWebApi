using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Interface
{
    public interface ICountry
    {
    //object Country { get; }

    //public CountryPagingList GetCountryPagingList(int currentPage = 1, int pageSize = 10);
    //IEnumerable<Country> GetCountryList();
        public List<Country> GetCountries();
        public Country GetCountryById(int Id);
        public Country AddCountry(Country country);
        public Country UpdateCountry(Country country);
        public void DeleteCountry(int id);
    }
}
