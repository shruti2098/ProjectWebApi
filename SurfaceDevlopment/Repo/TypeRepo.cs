using SurfaceDevlopment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Repo
{
    public class TypeRepo
    {
        ApplicationDbContext _context;
        public TypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        //public List<Type> GetTypes()
        //{
        //    return _context.Types.ToList();
        //}
        //public Type GetTypeById(int id)
        //{
        //    return _context.Types.FirstOrDefault(e => e.TypeId == id);
        //}
        public Type AddType(Type type)
        {
            _context.Add(type);
            _context.SaveChanges();
            return type;
        }
        public Type UpdateType(Type type)
        {
            _context.Update(type);
            _context.SaveChanges();
            return type;
        }
        //public void DeleteType(int Typeid)
        //{
        //    var deletetype = _context.Types.Where(s => s.TypeId == Typeid).FirstOrDefault();
        //    if (deletetype != null)
        //    {
        //        _context.Remove(deletetype);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
