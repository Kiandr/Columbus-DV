/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */

#region Namespace
using System;
using System.IO;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Routing;
//using Sage.CA.SBS.ERP.Sage300.VPF.Resources.Services;
//using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.Services;
//using Sage.CA.SBS.ERP.Sage300.VPF.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Web;
//using Sage.CA.SBS.ERP.Sage300.Common.Resources;
//using Sage.CA.SBS.ERP.Sage300.Common.Exceptions;
using NND.CA.DV.Models;
using NND.CA.DV.Web.Constants;
#endregion
namespace NND.CA.DV.Web.Controllers
{
    /// <summary>
    /// Main Controller for Visual Process Flow
    /// </summary>
    /// <typeparam name="T">Flow Model</typeparam>
    //public class DVController: Controller
    public class DVController<T> : BaseController<DVModel> where T : DVModel, new()
    {
        //    MultitenantControllerBase<Flow> where T : Flow, new()
        //{

        //    #region Private Varibles
        //    /// <summary>
        //    /// IFlow Interface, containing the Get implementation  for Visual Process Flow object acquistion
        //    /// </summary>
        //    private IFlowEntityService<T> Service;
        //#endregion
        #region Constructor
        /// <summary>
        /// Constructor of the main controller, using Unity Dependency Injection to inject the parametrized controller 
        /// to main project. Also added the unity container in the base controller as well as the screen name for initializtion proposes
        /// </summary>
        /// <param name="container"> Unity Container</param>
        public DVController(IUnityContainer container)
        //: base(container, Common.Models.Enums.ScreenName.VisualProcessFlow)
        {

        }
        #endregion
        #region Initialization
        /// <summary>
        /// Override Initialize method the main controller requesting the context 
        /// </summary>
        ///// <param name="requestContext">Request Context</param>
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            //Service = Context.Container.Resolve<IFlowEntityService<T>>((new ParameterOverride("context", Context)));

        }
        #endregion
        #region Public Actions
        /// <summary>
        /// Get visual Process Flow Per MenuId
        /// </summary>  
        /// <param name = "id" > The object identifier</param>
        /// <returns>DV object containing DV model</returns>

        [System.Web.Mvc.HttpGet]
        public ActionResult Index(string id)
        {
            return Json(new { success = true, Data = System.DateTime.Today }, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}