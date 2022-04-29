using SurfaceDevlopment.Interface;
using SurfaceDevlopment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Services
{
    public class TypeService
    {
        IType _service;
        public TypeService(IType service)
        {
            _service = service;
        }
        public List<Type> GetTypes()
        {
            return _service.GetTypes().ToList();
        }
        public Type GetTypeById(int TypeId)
        {
            return _service.GetTypeById(TypeId);
        }
        public void AddType(Type type)
        {
            // _service.AddSupplier(suppliervm);
            _service.AddType(type);
        }
        //public void UpdateType(TypeVM type)
        //{
        //    _service.UpdateType(type);
          
        //}
        public void DeleteType(int Id)
        {
            _service.DeleteType(Id);
        }
    }
}
