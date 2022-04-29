using SurfaceDevlopment.Interface;
using SurfaceDevlopment.Models;
using SurfaceDevlopment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Services
{
    public class PropertyInformationService
    {
        IPropertyInformation _service;
        public PropertyInformationService(IPropertyInformation service)
        {
            _service = service;
        }
        public List<PropertyInformation> GetPropertyInformation()
        {
            return _service.GetPropertyInformation().ToList();
        }
        public PropertyInformation GetPropertyInformationById(int PropertyId)
        {
            return _service.GetPropertyInformationById(PropertyId);
        }
        public void AddPropertyInformation(PropertyInformationVM propertyInformationVM)
        {
            PropertyInformation propertyInformation = new PropertyInformation()
            {
                PropertyInformationId=propertyInformationVM.PropertyInformationId,
                UniqueId=propertyInformationVM.UniqueId,
                MapId=propertyInformationVM.MapId,
                Rural=propertyInformationVM.Rural,
                DomainLandSurvey=propertyInformationVM.DomainLandSurvey,
                NationalTopographicSeries=propertyInformationVM.NationalTopographicSeries,
                Address=propertyInformationVM.Address,
                City=propertyInformationVM.City,
                Zipcode=propertyInformationVM.Zipcode,
                CompanyName=propertyInformationVM.CompanyName,
                CountryName=propertyInformationVM.CountryName,
                StateName=propertyInformationVM.StateName,
                OperatingArea=propertyInformationVM.OperatingArea,
                ResidentImage=propertyInformationVM.ResidentImage,
                //TypeEnum=propertyInformationVM.TypeEnum,
                Type=propertyInformationVM.Type,
                SubType=propertyInformationVM.SubType,
                Comment=propertyInformationVM.Comment,
                Status=propertyInformationVM.Status
            };
            _service.AddPropertyInformation(propertyInformation);
        }
        public void UpdatePropertyInformation(PropertyInformationVM propertyInformationVM)
        {
            PropertyInformation propertyInformation = new PropertyInformation()
            {
                PropertyInformationId=propertyInformationVM.PropertyInformationId,
                UniqueId = propertyInformationVM.UniqueId,
                MapId = propertyInformationVM.MapId,
                Rural = propertyInformationVM.Rural,
                DomainLandSurvey = propertyInformationVM.DomainLandSurvey,
                NationalTopographicSeries = propertyInformationVM.NationalTopographicSeries,
                Address = propertyInformationVM.Address,
                City = propertyInformationVM.City,
                Zipcode = propertyInformationVM.Zipcode,
                CompanyName = propertyInformationVM.CompanyName,
                CountryName = propertyInformationVM.CountryName,
                StateName = propertyInformationVM.StateName,
                OperatingArea = propertyInformationVM.OperatingArea,
                ResidentImage = propertyInformationVM.ResidentImage,
                //TypeId = propertyInformationVM.TypeId,
                SubType = propertyInformationVM.SubType,
                Comment = propertyInformationVM.Comment,
                Status = propertyInformationVM.Status
            };
            _service.UpdatePropertyInformation(propertyInformation);
        }
        public void DeletePropertyInformation(int Id)
        {
            _service.DeletePropertyInformation(Id);
        }
    }
}
