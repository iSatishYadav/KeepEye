using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeepEye.Models
{
    public class ResourceReportModel
    {
        [Display(Name="Server")]
        public string ResourceName { get; set; }
        [Display(Name = "<=1")]
        public int LessThanOne { get; set; }
        [Display(Name = "<=5")]
        public int OneToFive { get; set; }
        [Display(Name = "<=10")]
        public int FiveToTen { get; set; }
        [Display(Name = ">10")]
        public int GreaterThanTen { get; set; }
    }
}