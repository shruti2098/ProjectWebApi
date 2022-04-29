using SurfaceDevlopment.Interface;
using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Services
{
    public class StateService
    {
        IState _service;
        public StateService(IState service)
        {
            _service = service;
        }
        public List<State> GetStates()
        {
            return _service.GetStates().ToList();
        }
        public State GetStateById(int Id)
        {
            return _service.GetStateById(Id);
        }
        public void AddState(State statevm)
        {
            //Supplier supplier1 = new Supplier();
            //{
            //    SupplierId = SupplierVM.SupplierId,
            //}
            _service.AddState(statevm);
        }
        public void UpdateState(State state)
        {
            _service.UpdateState(state);
        }
        public void DeleteState(int Id)
        {
            _service.DeleteState(Id);
        }
    }
}
