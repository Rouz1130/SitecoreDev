using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace SitecoreDev.Web.Controllers
{
    public class ComponentsController : SitecoreController
    {
        public ViewResult HeroSlider()
        {
            Item contentItem = null;
            var datbase = Context.Database;
            if (datbase !=null)
            {
                if(!String.IsNullOrEmpty(
                    RenderingContext.Current.Rendering.DataSource))
                {
                    contentItem = datbase.GetItem(new Sitecore.Data.ID(
                        RenderingContext.Current.Rendering.DataSource));
                }
            }
            return View(contentItem);
        }







    }
}