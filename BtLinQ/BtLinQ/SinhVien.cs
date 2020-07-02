using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLinQ
{
    class SinhVien
    {
        private String ten;
        private String mssv;
        private float diemtb;
        private string gt;

        public String Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }

        public String Mssv
        {
            get { return this.mssv; }
            set { this.mssv = value; }
        }
        public float Diemtb
        {
            get { return this.diemtb; }
            set { this.diemtb = value; }
        }

        public String Gt
        {
            get { return this.gt; }
            set { this.gt = value; }
        }

        SinhVien()
        {

        }

        public SinhVien(String t, String ma,float diem,String gt)
        {
            this.ten = t;
            this.mssv = ma;
            this.diemtb = diem;
            this.gt = gt;
        }

       
    }

    
}
