using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODanhSachKhamBenh
    {
        public string MaDanhSach
        {
            get
            {
                return MaDanhSach;
            }
            set
            {
                MaDanhSach = value;
            }
        }

        public DateTime NgayKham
        {
            get
            {
                return NgayKham;
            }
            set
            {
                NgayKham = value;
            }
        }
    }
}
