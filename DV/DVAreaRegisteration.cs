/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

using System.Web.Mvc;
using System.Web.Optimization;

namespace NND.CA.DV.Web.Areas.DV
{

    /// <summary>
    /// Area Registeration Visual Process Flow
    /// </summary>
    public class DVAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Area identifier for visual process flow. 
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "DV";
            }
        }

        /// <summary>
        /// Registeratioin of Route config
        /// </summary>
        /// <param name="context">the Context</param>
        public override void RegisterArea(AreaRegistrationContext context)
        {

            RegisterRoutes(context);
            RegisterBundles();

        }
        /// <summary>
        /// URL cunstroction for visual process flow. {tenant}/VPF/{Controller}/{action}/{id}
        /// </summary>
        /// <param name="context">Context object</param>
        private void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute("DV", url: "dv/{Contoller}/{action}/{id}",
            defaults: new { area = "DV", controller = "DV", action = "Index", id = UrlParameter.Optional }, 
                namespaces: new[] { "NND.CA.DV.Web.Controllers" });
            //        context.MapRoute("WebApi", url: "Kian/{Contoller}/{action}/{id}",
            //defaults: new { area = "WebApi", controller = "WebApi", action = "Index", id = UrlParameter.Optional },
            //namespaces: new[] { "NND.CA.WebApi.Controllers" });

        }

        /// <summary>
        /// Register bundles
        /// </summary>
        private void RegisterBundles()
        {
            DVBundleRegisteration.RegisterBundles(BundleTable.Bundles);
        }

    }


}