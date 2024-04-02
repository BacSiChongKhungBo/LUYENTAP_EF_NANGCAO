using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class NhanvienRepository
    {
        DBContext context;
        public NhanvienRepository()
        {
            context = new DBContext();
        }
        public List<Nhanvien> GetNhanviens()
        {
            return context.Nhanviens.ToList();
        }

        public IQueryable<NVWithPB> GetData()
        {
            var result = context.Nhanviens.Join(context.PhongBans, // Nhanvien join PhongBan
                                                nv => nv.Mapb, // ON nv.MaPB
                                                pb => pb.Mapb, // = pb.MaPB
                                                (nv, pb) => new NVWithPB() // Select
                                                {
                                                    Stt = nv.Stt,
                                                    Manv = nv.Manv,
                                                    Tennv = nv.Tennv,
                                                    Tenpb = pb.Tenpb
                                                });
            return result;
        }

        public bool AddNV(Nhanvien nv)
        {
            if(nv == null)
            {
                return false;
            }
            context.Nhanviens.Add(nv);
            context.SaveChanges();
            return true;
        }
        public bool RemoveNV(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.Nhanviens.Remove(nv);
            context.SaveChanges();
            return true;
        }
    }
}
