﻿using BusinessLayerr.Concrete;
using BusinessLayerr.ValidationRules;
using DataAccesssLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv= new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id) 
        {
            var contactvalues=cm.GetByID(id);
            return View(contactvalues); 
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}