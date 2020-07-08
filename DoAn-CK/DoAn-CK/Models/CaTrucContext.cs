using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CK.Models
{
    public class CaTrucContext
    {
        private string ConnectionString;

        
        public string ConnectionString1 { get => ConnectionString; set => ConnectionString = value; }

        public CaTrucContext(string c)
        {
            this.ConnectionString = c;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<CaTruc> GetListCaTruc()
        {
            List<CaTruc> dsct = new List<CaTruc>();
            MySqlConnection con = GetConnection();
            con.Open();
            string sql = "SELECT nv.manv , nv.ten , ct.tencv,ct.nhiemvu , ct.khuvuc , ct.catruc FROM nhanvien nv, catruc ct where ct.manv = nv.manv";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                CaTruc a = new CaTruc();
                a.MaNV = rd["manv"].ToString();
                a.TenNV = rd["ten"].ToString();
                a.TenCV = rd["tencv"].ToString();
                a.NhiemVu = rd["nhiemvu"].ToString();
                a.KhuVuc = rd["khuvuc"].ToString();
                a.CaLam = rd["catruc"].ToString();
                dsct.Add(a);
            }    
            return dsct;
        }

        public int DeleteCaTruc(CaTruc ct)
        {
            MySqlConnection con = GetConnection();
            con.Open();
            string sql = "delete from catruc where manv ='" + ct.MaNV + "'";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            return(cmd.ExecuteNonQuery());
        }

        public CaTruc GetDataCaTruc(string manv)
        {
            MySqlConnection con = GetConnection();
            con.Open();
            string sql = "SELECT nv.manv , nv.ten , ct.tencv,ct.nhiemvu , ct.khuvuc , ct.catruc FROM nhanvien nv, catruc ct where ct.manv = '" + manv + "' and ct.manv = nv.manv";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            var rd = cmd.ExecuteReader();
            CaTruc a = new CaTruc();
            while(rd.Read())
            {
                a.MaNV = rd["manv"].ToString();
                a.TenNV = rd["ten"].ToString();
                a.TenCV = rd["tencv"].ToString();
                a.NhiemVu = rd["nhiemvu"].ToString();
                a.KhuVuc = rd["khuvuc"].ToString();
                a.CaLam = rd["catruc"].ToString();
            }
            return a;
        }

        public int ChangeDataCaTruc(CaTruc a)
        {
            MySqlConnection con = GetConnection();
            con.Open();
            string sql = "update catruc set tencv = '"+a.TenCV+"',nhiemvu = '"+a.NhiemVu+"',khuvuc = '"+a.KhuVuc+"',catruc = '"+a.CaLam+"' where manv = '"+a.MaNV+"'"; 
            MySqlCommand cmd = new MySqlCommand(sql, con);
            return (cmd.ExecuteNonQuery());

        }

    }
}
