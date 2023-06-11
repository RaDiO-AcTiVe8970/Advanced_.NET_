using Company_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company_Site.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            ViewBag.Bio = "MediaTek is an IP design and software company. It creates chips that are at the heart of mobile computing around the world. With solutions for smartphones, tablets, PCs, connected TVs, set-top boxes, automotives and M2M (M2M), MediaTek helps billions of consumers around the world connect, communicate and experience more in their daily lives.";
            ViewBag.Mission = "MediaTek’s mission is to provide the best, most cost-effective IC solutions that enable breakthroughs in ubiquitous connectivity and multimedia experiences. MediaTek is a fabless semiconductor company with 8,000+ employees, including 4,000+ R&D engineers and 90+ offices worldwide. The company is headquartered in Taiwan and has offices in mainland China, Singapore, India, U.S., Japan, Korea, Denmark, England, Sweden and Dubai.";
            ViewBag.Services = "MediaTek’s mission is to provide the best, most cost-effective IC solutions that enable breakthroughs in ubiquitous connectivity and multimedia experiences.";
            return View();
        }

        public ActionResult Services()
        {
            var tem1 = new Services
            {
                Name = "Smartphone",
                Description = "MediaTek’s smartphone chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s smartphone chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s smartphone chipsets are designed to deliver the latest features and advanced technology to the mass market."
            };
            var tem2 = new Services
            {
                Name = "Tablet",
                Description = "MediaTek’s tablet chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s tablet chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s tablet chipsets are designed to deliver the latest features and advanced technology to the mass market."
            };
            var tem3 = new Services
            {
                Name = "Smart TV",
                Description = "MediaTek’s smart TV chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s smart TV chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s smart TV chipsets are designed to deliver the latest features and advanced technology to the mass market."
            };
            var tem4 = new Services
            {
                Name = "Automotive",
                Description = "MediaTek’s automotive chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s automotive chipsets are designed to deliver the latest features and advanced technology to the mass market. MediaTek’s automotive chipsets are designed to deliver the latest features and advanced technology to the mass market."
            };
            Services[] services = new Services[] { tem1, tem2, tem3, tem4 };
            return View(services);
        }

        public ActionResult Team()
        {
            var mem1 = new Members {
                Name = "Rick Tsai",
                Department = "Software",
                Position = "System Engineer",
                Bio = "Rick Tsai is a system engineer at MediaTek. He has been working at MediaTek for 5 years. He is a graduate of the University of California, Berkeley."
            };

            var mem2 = new Members
            {
                Name = "John Smith",
                Department = "Software",
                Position = "System Engineer",
                Bio = "John Smith is a system engineer at MediaTek. He has been working at MediaTek for 15 years. He is a graduate of the University of California, Berkeley."
            };
            var mem3 = new Members {
                Name="Jane Doe",
                Department="IC Engineer",
                Position="IC Engineer",
                Bio="Jane Doe is an IC engineer at MediaTek. She has been working at MediaTek for 8 years. She is a graduate of the University of California, Berkeley."
            };
            var mem4 = new Members {
                Name="Kaiser Fahim",
                Department="IC Engineer",
                Position="IC Engineer",
                Bio="Kaiser Fahim is an IC engineer at MediaTek. He has been working at MediaTek for 5 years. He is a graduate of the BRAC University, Dhaka."
            };
            Members[] teams = new Members[] { mem1, mem2, mem3, mem4 };
            return View(teams);
        }

        public ActionResult Contact() 
        {
            return View();
        }
    }
}