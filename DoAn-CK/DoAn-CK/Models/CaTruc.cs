using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CK.Models
{
    public class CaTruc
    {
        private string maNV;
        private string tenNV;
        private string tenCV;
        private string nhiemVu;
        private string khuVuc;
        private string caLam;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string NhiemVu { get => nhiemVu; set => nhiemVu = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string CaLam { get => caLam; set => caLam = value; }
    }
}
