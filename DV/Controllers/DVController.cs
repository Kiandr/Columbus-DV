/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */

#region Namespace
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using NND.CA.Common.Model;
using NND.CA.Common.Web;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;
using NND.CA.DV.Web.Constants;
using NND.CA.DV.Web.Controllers.ControllerInternal;

#endregion

namespace NND.CA.DV.Web.Controllers
{
    /// <summary>
    ///     Main Controller for Visual Process Flow
    /// </summary>
    /// <typeparam name="T">Flow Model</typeparam>
    //public class DVController: Controller
    public class DvController<T> : MultitenantControllerBase<T> where T : DVModelViewModel<DVModel>, new()
    {

        public T ControllerInternal { get; set; }
        //private IDvEntityService<T> service;

        #region Constructor

        public DvController(IUnityContainer container)
            : base(container, ScreenName.DV)

        {
            //UnityContainerMultiTenantClass = container;
        }

        #endregion

        #region Initialize MultitenantControllerBase

        #endregion

        #region Public Variables

        //DVControllerInternal<DVModelViewModel<DVModel>> ControllerInternal ;
        // Retrun Serialized JSON object from index object bind

        #endregion

        #region Public Actions

        [HttpGet]
        public ActionResult Index(string id)
        {
            //var model = new T();
            //service.UpdateStatus(model);
            return PartialView(DvConstant.DvIndexPartialViewPath);
        }

        [HttpGet]
        public virtual string Load(string id)
        {
           

            return "rest";

            // var t = controllerInternal.load();
            //var  tt =t.Data;
        }

        #endregion
    }
}