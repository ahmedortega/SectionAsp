using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Customer
        public ActionResult Index()
        {
            var customers = getCustomers().ToList();
            return View(customers);
        }
        public IEnumerable<Customer> getCustomers()
        {
            /*List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Mai" },
                new Customer {Id = 10, Name = "Samy" },
                new Customer {Id = 11, Name = "Mazen" },
            };*/
            var customers = db.Customers.ToList();
            return customers;
        }
        public ActionResult Details(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        [HttpGet]
        public ActionResult New()
        {
            var MemberShipTypes = db.MemberShipTypes.ToList();
            CustomerMemberShipViewModel cmsvm = new CustomerMemberShipViewModel()
            {
                MemberShipTypes = MemberShipTypes,
            };
            return View(cmsvm);
        }

        [HttpPost]
        public ActionResult New(CustomerMemberShipViewModel cmsvm)
        {
            if (!ModelState.IsValid)
            {
                var MemberShipTypes = db.MemberShipTypes.ToList();
                cmsvm.MemberShipTypes = MemberShipTypes;
                return View("New", cmsvm);

            }
            db.Customers.Add(cmsvm.Customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var customer = db.Customers.Single(c => c.Id == id);
            var MemberShipTypes = db.MemberShipTypes.ToList();
            CustomerMemberShipViewModel cmsvm = new CustomerMemberShipViewModel()
            {
                MemberShipTypes = MemberShipTypes,
                Customer = customer,
            };
            return View(cmsvm);
        }
        [HttpPost]
        public ActionResult Edit(CustomerMemberShipViewModel cmsvm)
        {
            if (!ModelState.IsValid)
            {
                var MemberShipTypes = db.MemberShipTypes.ToList();
                cmsvm.MemberShipTypes = MemberShipTypes;
                return View("Edit", cmsvm);

            }
            var customerDB = db.Customers.Single(c => c.Id == cmsvm.Customer.Id);
            customerDB.Age = cmsvm.Customer.Age;
            customerDB.Name = cmsvm.Customer.Name;
            customerDB.MemberShipTypeID = cmsvm.Customer.MemberShipTypeID;
            customerDB.IsMale = cmsvm.Customer.IsMale;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}