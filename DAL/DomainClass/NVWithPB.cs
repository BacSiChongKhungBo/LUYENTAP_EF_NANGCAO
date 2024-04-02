using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainClass
{
    public class NVWithPB //class phải public mới đi sang repos được
    {
        public int Stt { get; set; }
        public string Manv { get; set; } = null!;
        public string Tennv { get; set; } = null!;
        public string Tenpb { get; set; } = null!;
    }
}
