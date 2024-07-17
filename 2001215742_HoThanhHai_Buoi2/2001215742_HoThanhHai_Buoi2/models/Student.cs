using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215742_HoThanhHai_Buoi2.models
{
    public class Student
    {
        string mssv;

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        string malop;

        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        bool gioitinh;

        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

       
    }
}
