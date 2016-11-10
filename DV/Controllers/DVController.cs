/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */
#region Protocols to be implemented in this class
/*
 To do list: 
 1- Base models for Service API and Business Repo API. Standard operations 
 */
#endregion
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
using NND.CA.Common.Web;
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


        /// <summary>
        /// Load Account set screen
        /// </summary>
        /// <returns>Account set View</returns>
        public virtual ActionResult Index(string id)
        {
            AccountSetViewModel<T> model;
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    model = ControllerInternal.Get(id);
                    model.UserAccess = ControllerInternal.GetAccessRights();
                }
                else
                {
                    model = new AccountSetViewModel<T> { UserAccess = ControllerInternal.GetAccessRights() };
                    model = ControllerInternal.LoadCompanyDetails(model);

                }
            }
            catch (BusinessException businessException)
            {
                return
                    JsonNet(BuildErrorModelBase(CommonResx.GetFailedMessage, businessException,
                AccountSetsResx.AccountSetCode));
            }

            return View(model);
        }

        /// <summary>
        /// Get Account set
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Json object for Account set</returns>
        [HttpPost]
        public virtual JsonNetResult Get(string id)
        {
            ViewModelBase<AccountSetViewModel<T>> viewModel;

            if (!ValidateModelState(ModelState, out viewModel))
            {
                return JsonNet(viewModel);
            }
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    return JsonNet(ControllerInternal.Get(id));
                }
                var accountSetcodes = new AccountSetViewModel<T>();
                return JsonNet(accountSetcodes);
            }
            catch (BusinessException businessException)
            {
                return
                    JsonNet(BuildErrorModelBase(CommonResx.GetFailedMessage, businessException,
              AccountSetsResx.AccountSetCode));
            }
        }

        /// <summary>
        /// Add new Account set
        /// </summary>
        /// <returns>Json object for Account set</returns>
        /// <summary>
        /// Create Account set
        /// </summary>
        /// <returns>AccountSetViewModel</returns>
        [HttpPost]
        public virtual JsonNetResult Create()
        {
            return JsonNet(ControllerInternal.Create());
        }


        /// <summary>
        /// Update Account set
        /// </summary>
        /// <param name="model">Account set Model</param>
        /// <returns>Json object for Account set</returns>
        [HttpPost]
        public virtual JsonNetResult Save(T model)
        {
            try
            {
                ViewModelBase<ModelBase> viewModel;
                return ValidateModelState(ModelState, out viewModel)
                    ? JsonNet(ControllerInternal.Save(model))
                    : JsonNet(viewModel);
            }
            catch (BusinessException businessException)
            {
                return JsonNet(BuildErrorModelBase(CommonResx.SaveFailedMessage, businessException));
            }
        }

        /// <summary>
        /// Update the status of the Account set
        /// </summary>
        /// <param name="model">model</param>
        /// <returns>Json object for Account set</returns>
        [HttpPost]
        public virtual JsonNetResult UpdateStatus(T model)
        {
            try
            {
                ViewModelBase<ModelBase> viewModel;
                return ValidateModelState(ModelState, out viewModel)
                    ? JsonNet(ControllerInternal.UpdateStatus(model))
                    : JsonNet(viewModel);
            }
            catch (BusinessException businessException)
            {
                return JsonNet(BuildErrorModelBase(CommonResx.SaveFailedMessage, businessException));
            }
        }

        /// <summary>
        /// Delete Account Set
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Json object for Account set</returns>
        [HttpPost]
        public virtual JsonNetResult Delete(string id)
        {
            try
            {
                return JsonNet(ControllerInternal.Delete(id));
            }
            catch (BusinessException businessException)
            {
                return
                    JsonNet(BuildErrorModelBase(CommonResx.DeleteFailedMessage, businessException,
                         AccountSetsResx.AccountSetCode));
            }
        }
        #endregion
    }
}