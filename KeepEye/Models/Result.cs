using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepEye.Models
{
    public class Result
    {
        public string StartTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ResourceName { get; set; }
        public string Second { get; set; }
        public string EndTime { get; set; }
        public string BusinessPeriod { get; set; }
        public string ReportType { get; set; }
        public IEnumerable<ThresholdDetail> ThresholdDetails { get; set; }
        public string ResourceId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeID { get; set; }
        public string AttributeImage { get; set; }
        public string Success { get; set; }
        public IEnumerable<RawData> RawData { get; set; }
        public string ResourceType { get; set; }
        public DateTime StartDateTime { get; set; }
        public string Period { get; set; }
    }
}
