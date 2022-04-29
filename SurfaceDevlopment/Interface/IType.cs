using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Interface
{
    public interface IType
    {
        public List<Type> GetTypes();
        public Type GetTypeById(int TypeId);
        public Type AddType(Type type);
        public Type UpdateType(Type type);
        public void DeleteType(int id);
    }
}
