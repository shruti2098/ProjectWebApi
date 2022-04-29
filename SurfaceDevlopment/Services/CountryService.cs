using SurfaceDevlopment.Interface;
using SurfaceDevlopment.Models;
using SurfaceDevlopment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Services
{
    public class CountryService
    {
        ICountry _service;
        public CountryService(ICountry service)
        {
            _service = service;
        }
        public List<Country> GetCountries()
        {
            return _service.GetCountries().ToList();
        }
        public Country GetCountryById(int Id)
        {
            return _service.GetCountryById(Id);
        }
    //public CountryPagingList GetCountryPagingList(int currentPage = 1, int pageSize = 10)
    //{
    //  var model = new CountryPagingList();
    //  var countryList = (from c in _service.Country
    //                     select new Country
    //                     { 
    //                       CountryName = c.CountryName,
    //                       Id = c.Id,
    //                       Description = c.Desciption,
    //                     }).OrderBy(async => async.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

    //    model.CountryList = countryList;
    //  int totalRecord = _service      
    //    var page = new Pagination
    //    {
    //      Count = totalRecord,
    //      CurrentPage = currentPage,
    //      PageSize = pageSize,
    //      TotalPages = (int)Math.Ceiling(decimal.Divide(totalRecord, pageSize)),
    //      IndexOne = ((currentPage - 1) * pageSize + 1),
    //      IndexTwo = (((currentPage - 1) * pageSize + pageSize) <= totalRecord ? ((currentPage - 1) * pageSize + pageSize) : totalRecord)
    //    };
    //    model.Pagination = page;
    //    return model;
    //}
        public void AddCountry(Country country)
        {
            Country country1 = new Country()
            {
                Id = country.Id,
                CountryName = country.CountryName,
                Description = country.Description,
            };
            _service.AddCountry(country1);
        }
        public void UpdateCountry(CountryVM countryVM)
        {
            Country country = new Country()
            {
                Id = countryVM.Id,
                CountryName = countryVM.CountryName,
                Description = countryVM.Description,
            };
            _service.UpdateCountry(country);
        }
        public void DeleteCountry(int id)
        {
            _service.DeleteCountry(id);
        }
        public void GetCountryPagingList(Country Pagination)
        {
      Pagination page = new Pagination()
      {

      };
        }
    }
}
