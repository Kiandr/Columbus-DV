/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved.*/

#region Namespace
using Microsoft.Practices.Unity;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;
using NND.CA.DV.Models;
using NND.CA.DV.Web.Controllers;
using System.ComponentModel.Composition;
#endregion

namespace NND.CA.DV.Web
{
    /// <summary>
    /// Administrative Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport("DV",
        new[] { BootstrapAppliesTo.Web, BootstrapAppliesTo.Worker, BootstrapAppliesTo.WebApi }, 10)]
    public class DVBootstrapper : IBootstrapperTask
    {

        /// <summary>
        /// Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            // Definition of the Controller class to avoid confusion, controllers were separated into the particular class "RegisterController". 
            RegisterServices(container);
            RegisterBusinessRepositories(container);
        }

        #region Register Service Project

        /// <summary>
        /// Registration of services using dependency injection Microsoft Unity framework. 
        /// in this class all of the controller used in the visual process flow will be registered.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterServices(IUnityContainer container)
        {
            // Main Controller, accessible via {tenant}/VPF/Flow/Index/{id}
            //UnityUtil.RegisterType<IController, DVController < DVModel >>(container, "DV");
        }
        #endregion
        #region Register Business Repository Project

        /// <summary>
        /// Registration of services using dependency injection Microsoft Unity framework. 
        /// in this class all of the controller used in the visual process flow will be registered.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterBusinessRepositories(IUnityContainer container)
        {
            // Main Controller, accessible via {tenant}/VPF/Flow/Index/{id}
            //UnityUtil.RegisterType<IController, DVController < DVModel >>(container, "DV");
        }
        #endregion
    }
}