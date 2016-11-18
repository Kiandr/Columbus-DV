/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved.*/

#region Namespace

using System.ComponentModel.Composition;
using Microsoft.Practices.Unity;
using NND.CA.Common.Web;
using NND.CA.DV.BusinessRepository;
using NND.CA.DV.Interfaces.BusinessRepository;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;

#endregion

namespace NND.CA.DV.Services
{
    /// <summary>
    ///     Administrative Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport(BootstrapModule.DV,
         new[] {BootstrapAppliesTo.Web, BootstrapAppliesTo.Worker, BootstrapAppliesTo.WebApi}, 10)]
    public class DVBootstrapper : IBootstrapperTask
    {
        /// <summary>
        ///     Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            RegisterServices(container);
            RegisterBusinessRepositories(container);
        }

        #region Register Service Project

        private void RegisterServices(IUnityContainer container)
        {
            container
                .RegisterType<IDvEntityService<DVModelViewModel<DVModel>>, DvEntityService<DVModelViewModel<DVModel>>>(
                    "IDvEntityService");
        }

        #endregion

        #region Register Business Repository Project

        /// <summary>
        ///     Registration of services using dependency injection Microsoft Unity framework.
        ///     in this class all of the controller used in the visual process flow will be registered.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterBusinessRepositories(IUnityContainer container)
        {
            // Main Controller, accessible via {tenant}/VPF/Flow/Index/{id}
            //UnityUtil.RegisterType<IController, DVController < DVModel >>(container, "DV");
            container
                .RegisterType
                <IDvEntityRepository<DVModelViewModel<DVModel>>, DvEntityRepository<DVModelViewModel<DVModel>>>(
                    "IDvEntityRepository");
        }

        #endregion
    }
}