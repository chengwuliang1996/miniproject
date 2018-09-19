using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleAuth.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Line()
        {
            string t;
            string h;
            int i = 0;
            var lstModel = new List<SimpleReportViewModel>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Chengwuliang\Desktop\w\test\GoogleAuth\GoogleAuth\wwwroot\lib\Temp.txt");
            System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\Users\Chengwuliang\Desktop\w\test\GoogleAuth\GoogleAuth\wwwroot\lib\Humidity.txt");

            while (((t = file.ReadLine()) != null) && ((h = file2.ReadLine()) != null))
            {
                lstModel.Add(new SimpleReportViewModel
                {
                    Day = i,
                    Temp = Convert.ToInt32(t),
                    Humidity = Convert.ToInt32(h)
                });
                i++;
            }
            return View( lstModel );
        }
    }
}