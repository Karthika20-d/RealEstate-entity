using OnlineRealEstate.BL;
using OnlineRealEstate.Entity;
using OnlineRealEstate.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineRealEstate.Controllers
{
    public class PropertyController : Controller
    {
        PropertyBL propertyBL = new PropertyBL();
        // GET: Property
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PropertyModel propertyModel)
        {
            Property property = new Property();
            if (ModelState.IsValid)
            {
                property.Area = propertyModel.Area;
                property.Location = propertyModel.Location;
                property.PropertyType = propertyModel.PropertyType;
                if (propertyBL.Create(property) > 0)
                {
                    ViewBag.Message = "Added successfull";
                }
                else
                {
                    ViewBag.Message = "failed";
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Property property=propertyBL.Update(id);
            return View(property);
        }
        [HttpPost]
        public ActionResult UpdateProperty(Property property)
        {
            propertyBL.UpdatePropertyDetails(property);
            return RedirectToAction("DisplayPropertyDetails");

        }
        [HttpGet]
        public ActionResult DisplayPropertyDetails()
        {
            IEnumerable<Property> property = propertyBL.DisplayPropertyDetails();
            TempData["Property"] = property;
            return View();
        }
        public ActionResult Delete(int id)
        {
            propertyBL.Delete(id);
            return RedirectToAction("DisplayPropertyDetails");
        }

    }
}