using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class PhongbanService
    {
        PhongbanRepository repos;
        public PhongbanService()
        {
            repos = new PhongbanRepository();
        }

        public List<PhongBan> GetPhongBans()
        {
            return repos.GetAll();
        }
    }
}
