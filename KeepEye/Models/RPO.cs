using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KeepEye.Models
{
    public class RPO
    {
        public IEnumerable<string> GetUrls()
        {
            yield return "";
        }

        public IEnumerable<string> GetDataFromUrls(IEnumerable<string> urls)
        {
            foreach (var url in urls)
            {
                yield return GetDataFromUrl(url);
            }
        }

        public List<dynamic> GetReportDataDynamic(IEnumerable<string> data)
        {
            var list = new List<dynamic>();
            foreach (var item in data)
            {
                list.Add(GetDynamic(item));
            }
            return list;
        }

        private dynamic GetDynamic(string item)
        {
            dynamic x = JsonConvert.DeserializeObject(item);
            return x;
        }

        public string GetDataFromUrl(string url)
        {
            return GetData();
        }

        private string GetData()
        {
            string appdata = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\data.json");
            var json = File.ReadAllText(appdata);
            return json;
        }

        public IEnumerable<JsonData> GetReportData(IEnumerable<string> data)
        {
            foreach (var item in data)
            {
                yield return GetStatic(item);
            }
        }

        private JsonData GetStatic(string item)
        {
            var response = JsonConvert.DeserializeObject<JsonData>(item);
            return response;
        }
    }
}