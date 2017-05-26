using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using IpVault.Models;
using IpVault.Helpers;
using System.Threading.Tasks;

namespace IpVault.Controllers
{
    public class IpVaultController : Controller
    {
    //    private AppIpManager _appIpManager;

    //    public IpVaultController()
    //    {

    //    }

    //    public IpVaultController(AppIpManager ipManager)
    //    {
    //        IpManager = ipManager;
    //    }

    //    public AppIpManager IpManager
    //    {
    //        get
    //        {
    //            return _ipManager ?? HttpContext.GetC().GetIpManager<IpManager>();
    //        }
    //        private set
    //        {
    //            _ipManager = value;
    //        }
    //    }

        // GET: IpVault
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStoredIp()
        {
            var db = new IpDbContext();

            var result = db.GetStoredIp().Select(x => new IpVaultViewModel
            {
                id = x.id,
                IpProvider = x.IpProvider,
                IpAddress = x.IpAddress,
                AttachedSite = x.AttachedSite
            }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public string IpPost([FromBody] string IpProvider, string IpAddress, string AttachedSite)
        {
            var db = new DataLibrary();

            var result = db.IpPost(IpProvider, IpAddress, AttachedSite);

            return true.ToString();
        }

        // =======================================================================
        // Controls for VaultView 
        // =======================================================================

        public ActionResult VaultView()
        {


            return View();
        }

        public JsonResult GetIpValues()
        {
            var db = new IpDbContext();

            var ipResults = db.GetStoredIp().Select(x => new IpVaultViewModel
            {
                id = x.id,
                IpProvider = x.IpProvider,
                IpAddress = x.IpAddress,
                AttachedSite = x.AttachedSite
            }).ToList();

            return Json(ipResults, JsonRequestBehavior.AllowGet);
        }
    }
}