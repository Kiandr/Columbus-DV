/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */

#region Namespace

using System.Web.Mvc;
using NND.CA.Common.Web;
using NND.CA.DV.Models;
// ReSharper disable Mvc.PartialViewNotResolved line 25. The partial View has been hardcoded and all of them are being deployed to "NND.CA.Web" via a RoboCop post build srcipt located in the Utility Framework. 
#endregion

namespace NND.CA.DV.Web.Controllers
{
    /// <summary>
    /// Main Controller for Visual Process Flow
    /// </summary>
    /// <typeparam name="T">Flow Model</typeparam>
    //public class DVController: Controller
    public class DvController<T> : BaseController<DVModel> where T : DVModel, new()
    {
        // Retrun Serialized JSON object from index object bind
        [HttpGet]
        public ActionResult Index(string id)
        {
            return PartialView(Constants.DvConstant.DvIndexPartialViewPath);
        }

        //[HttpPost]
        //public ActionResult Load(string id)
        //{
        //    retrun JsonResault
        //    (id);
        //}
    }
}