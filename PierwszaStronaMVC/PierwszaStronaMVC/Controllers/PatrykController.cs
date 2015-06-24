using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Extensions.StringExtensions;
using PierwszaStronaMVC.Models;

namespace PierwszaStronaMVC.Controllers
{
    public class PatrykController : Controller
    {
        // GET: Patryk
        public ActionResult Index(PatrykModel model)
        {
            string url = Request.RawUrl;
            Dictionary<string,string> queryProperties = url.Substring( url.IndexOf('?')+1 ).ParseUrl();
            var fields = model.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                string fieldName = field.Name.ToLower();
                if (queryProperties.ContainsKey(fieldName))
                    field.SetValue(model, queryProperties[fieldName]);
            }

            return View(model);
        }

        
    }
}