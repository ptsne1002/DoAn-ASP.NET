using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_CK.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn_CK.Controllers
{
    public class CaTrucController : Controller
    {
        private CaTrucContext cotext;
        
        public void GetConnect()
        {
            if(cotext == null)
            {
                this.cotext = HttpContext.RequestServices.GetService(typeof(CaTrucContext)) as CaTrucContext;
            }    
        }
        public IActionResult Index()
        {
            GetConnect();
            List<CaTruc> ls = new List<CaTruc>();
            ls = cotext.GetListCaTruc();
            
            return View(ls);
        }

        public int DeleteCaTruc(CaTruc ct)
        {
            GetConnect();
            
            return (cotext.DeleteCaTruc(ct));
        }
    }
}
