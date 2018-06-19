using System.Linq;
using System.Web.Mvc;
using mallform.Models;
using mallform.ViewModel;
using System;

namespace mallform.Controllers
{
    public class LeasingFormController : Controller
    {
        // GET: LeasingForm
        private ApplicationDbContext _context;

        public LeasingFormController()
        {

            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Form()
        {
            var viewModel = new TenantFormViewModel
            {
                Units = _context.Unit.ToList(),
                Tenants=_context.Tenant.ToList()
                
            };
            return View(viewModel);
        }
        
        [HttpPost]
        [Authorize]
        public ActionResult Form(TenantFormViewModel Form )
        {
          

            if (!ModelState.IsValid)
            {
                return View("Form", Form);

            }

            var tenant = new Tenant
            {
                brandName = Form.brandName ,
                Address = Form.Address,
                mobileNo = Form.mobileNo,
                panNo = Form.panNo
            };
          

            var unit = new Unit
            {
                Size =Form.Size,
                Floor = Form.Floor
                
            };
            var shopNo = _context.Unit.Single(s => s.Id == Form.Unit);  //ID FOR DROP DOWN LIST
            var shopName = _context.Tenant.Single(s => s.Id == Form.Tenant); // ID FOR TENANT SHOPNAME
            var rent = new Rent
            {
                Amount = Form.Amount,
                startDate = DateTime.Parse(string.Format("{0}", Form.startDate)),
                endDate = DateTime.Parse(string.Format("{0}", Form.endDate)),

                Unit = shopNo,
                Tenant =shopName

            };


            //TO ADD A DATA TO THE DATABASE
            _context.Tenant.Add(tenant);
            _context.Unit.Add(unit);
            _context.Rent.Add(rent);

            

            _context.SaveChanges();

            
            return RedirectToAction("Index", "Home");
        }



            public ActionResult Update (int id) //TO UPDATE TENANT RECORD
        {

            

            return View(_context.Tenant.Find(id));
        }


        [HttpPost]

        public ActionResult Update (Tenant Model)
        {
         
            Tenant tenant = _context.Tenant.Where(m => m.Id == Model.Id).SingleOrDefault();
            if(tenant!=null)
            {

                _context.Entry(tenant).CurrentValues.SetValues(Model);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");

            }

            return View(Model);
        

        }

        public ActionResult Delete (int id)  //TO DELETE TENANT RECORD
        {

            _context.Tenant.Remove(_context.Tenant.Find(id));
            _context.SaveChanges();

            return RedirectToAction("Index" , "Home");

        }




    }
}



