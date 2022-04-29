using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SurfaceDevlopment.Services;
using SurfaceDevlopment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyInformationController : Controller
    {
        PropertyInformationService _service;
        public PropertyInformationController(PropertyInformationService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetPropertyInformation")]
        public IActionResult GetPropertyInformation()
        {
            var company = _service.GetPropertyInformation();
            return Ok(company);
        }
        [HttpGet]
        [Route("GetPropertyInformationById")]
        public IActionResult GetPropertyInformationById(int PropertyId)
        {
            var company = _service.GetPropertyInformationById(PropertyId);
            return Ok(company);
        }
        [HttpPost]
        [Route("AddPropertyInformation")]
        public IActionResult AddPropertyInformation([FromBody] PropertyInformationVM propertyInformation)
        {
            try
            {
                _service.AddPropertyInformation(propertyInformation);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdatePropertyInformation")]
        public IActionResult UpdatePropertyInformation(PropertyInformationVM propertyInformationVM)
        {
            try
            {
                _service.UpdatePropertyInformation(propertyInformationVM);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeletePropertyInformation/{id}")]
        public IActionResult DeletePropertyInformation(int id)
        {
            try
            {
                _service.DeletePropertyInformation(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
