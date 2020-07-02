using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> dsSV = new List<SinhVien>();
            SinhVien a = new SinhVien("a","1",10,"nu");
            SinhVien b = new SinhVien("b", "2", 9, "nam");
            SinhVien c= new SinhVien("c", "1", 8, "nu");
            SinhVien d = new SinhVien("d", "1", 7, "nam");
            SinhVien e = new SinhVien("e", "1", 4, "nam");
            dsSV.Add(a);
            dsSV.Add(b);
            dsSV.Add(c);
            dsSV.Add(d);
            dsSV.Add(e);

            // sử dụng Method LinQ để liệt kê danh ách đã lưu
            var c1 = (from ds in dsSV select ds).ToList();
            Console.WriteLine("Ten\tMssv\tDiemtb\tGt");
            foreach (var x in c1)
            {
                Console.WriteLine($"{x.Ten}\t{x.Mssv}\t{x.Diemtb}\t{x.Gt}");
            }

            // liệt kê các sinh viên có điểm tb >5
            Console.WriteLine("\n############## C2 ################");
            var c2 = dsSV
                .Where(ds => ds.Diemtb > 5)
                .Select(ds => new { info = $"{ds.Diemtb}", ds.Ten ,ds.Mssv , ds.Gt } );
            Console.WriteLine("Ds SV có Điểm TB lớn hơn 5");
            Console.WriteLine("Ten\tMssv\tDiemtb\tGt");
            foreach (var x in c2)
            {
                Console.WriteLine($"{x.Ten}\t{x.Mssv}\t{x.info}\t{x.Gt}");
            }
        }
    }
}
