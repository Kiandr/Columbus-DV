/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved.*/

#region Namespace

using System.ComponentModel.Composition;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using NND.CA.Common.Web;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;
using NND.CA.DV.Web.Controllers;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;

#endregion

namespace NND.CA.DV.Web
{
    /// <summary>
    ///     Administrative Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport(BootstrapModule.DV,
         new[] {BootstrapAppliesTo.Web, BootstrapAppliesTo.Worker, BootstrapAppliesTo.WebApi}, 11)]
    public class DVWebBootstrapper : IBootstrapperTask
    {
        /// <summary>
        ///     Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            // Definition of the Controller class to avoid confusion, controllers were separated into the particular class "RegisterController". 
            RegisterController(container);
        }

        #region Register Controller Project

        /// <summary>
        ///     Registration of services using dependency injection Microsoft Unity framework.
        ///     in this class all of the controller used in the visual process flow will be registered.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterController(IUnityContainer container)
        {
            // Main Controller, accessible via {tenant}/VPF/Flow/Index/{id}
            container.RegisterType<IController, DvController<DVModelViewModel<DVModel>>>("DV");
            //UnityUtil.RegisterType<IDvEntityService<DVModelViewModel<DVModel>>, DvEntityService<DVModelViewModel<DVModel>>>(container);
        }

        #endregion
    }
}