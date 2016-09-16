using KeepEye.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeepEye.Controllers
{
    public class ServersController : Controller
    {
        // GET: Servers
        public ActionResult Index()
        {
            var urls = new List<string> { "", "" };
            var toolkit = new RPO();
            var data = toolkit.GetDataFromUrls(urls);
            //var reportData = toolkit.GetReportDataDynamic(data);
            var reportData = toolkit.GetReportData(data).ToList();
            return View(reportData);
        }

        public ActionResult Dynamic()
        {
            var urls = new List<string> { "", "" };
            var toolkit = new RPO();
            var data = toolkit.GetDataFromUrls(urls);
            var reportData = toolkit.GetReportDataDynamic(data);            
            return View(reportData);
        }

        public ActionResult Each()
        {
            var urls = new List<string> { "", "" };
            var toolkit = new RPO();
            var data = toolkit.GetDataFromUrls(urls);
            //var reportData = toolkit.GetReportDataDynamic(data);
            var reportData = toolkit.GetReportData(data).ToList();
            var resourceGroup = reportData.GroupBy(x => x.Response.Result.First().ResourceName);
            var model = new List<ResourceReportModel>();
            foreach (var group in resourceGroup)
            {
                var resource = new ResourceReportModel { ResourceName = group.Key };
                foreach (var raw in group.First().Response.Result.First().RawData)
                {
                    if (raw.Value < 60) resource.LessThanOne++;
                    else if (raw.Value < 300) resource.OneToFive++;
                    else if (raw.Value < 600) resource.FiveToTen++;
                    else resource.GreaterThanTen++;
                }
                model.Add(resource);
            }
            return View(model);
        }
    }
}