/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */

#region Namespace

using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.WindowsAzure.Storage.Core;
using NND.CA.Common.Web;
using NND.CA.DV.Models;
using NND.CA.Common.Model;
using NND.CA.DV.Models.ViewModels;
using NND.CA.DV.Web.Controllers.ControllerInternal;
using JsonNetResult = NND.CA.Common.Model.JsonNetResult;


// ReSharper disable Mvc.PartialViewNotResolved line 25. The partial View has been hardcoded and all of them are being deployed to "NND.CA.Web" via a RoboCop post build srcipt located in the Utility Framework. 
#endregion

namespace NND.CA.DV.Web.Controllers
{
    /// <summary>
    /// Main Controller for Visual Process Flow
    /// </summary>
    /// <typeparam name="T">Flow Model</typeparam>
    //public class DVController: Controller
    public class DvController<T> : MultitenantControllerBase<T> where T : DVModelViewModel<DVModel>, new()
    {
        #region Public Variables
        //DVControllerInternal<DVModelViewModel<DVModel>> ControllerInternal ;
        // Retrun Serialized JSON object from index object bind
        #endregion

        #region Constructor

        //public DvController(IUnityContainer container)
        //    : base(container, ScreenName.DV)
      
        //{
        //}



        #endregion

        #region Initialize MultitenantControllerBase

        /// <summary>
        /// Initializes the specified request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            //ControllerInternal = new DVControllerInternal<DVModelViewModel<DVModel>>(requestContext);
        }
        #endregion







        #region Public Actions
        [HttpGet]
        public ActionResult Index(string id)
        {
            return PartialView(Constants.DvConstant.DvIndexPartialViewPath);
        }

        [HttpGet]
        public virtual string Load(string id)
        {
            return ("rest");

            // var t = controllerInternal.load();
            //var  tt =t.Data;


        }
    #endregion
    }
}