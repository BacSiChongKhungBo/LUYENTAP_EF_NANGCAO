using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class PhongbanRepository
    {
        DBContext context;
        public PhongbanRepository()
        {
            context = new DBContext();
        }

        public List<PhongBan> GetAll() 
        { 
            return context.PhongBans.ToList();
        }
    }
}
