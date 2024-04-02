using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanvienService
    {
        NhanvienRepository repos;
        public NhanvienService()
        {
            repos = new NhanvienRepository();
        }
        public List<Nhanvien> GetNhanviens()
        {
            return repos.GetNhanviens();
        }
        public IQueryable<NVWithPB> GetNVWithPBs()
        {
            return repos.GetData();
        }
        public string ThemNV(Nhanvien nv)
        {
            if(repos.AddNV(nv))
            {
                return "Thêm thành công";
            }
            return "Thêm Thất bại";
        }
        public string XoaNV(Nhanvien nv)
        {
            if (repos.RemoveNV(nv))
            {
                return "Xóa thành công";
            }
            return "Xóa Thất bại";
        }
    }
}
