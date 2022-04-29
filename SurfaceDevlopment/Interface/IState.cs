using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Interface
{
    public interface IState
    {
        public List<State> GetStates();
        public State GetStateById(int Id);
        public State AddState(State country);
        public State UpdateState(State state);
        public void DeleteState(int id);
        
    }
}
