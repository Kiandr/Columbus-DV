/* Copyright (c) 2016 KDR Software, Inc.  All rights reserved. */

#region Namespace
using Sage.CA.SBS.ERP.Sage300.Common.Web;
using NND.CA.DV.Models;
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
        // Retrun Serialized JSON object from index object bind
    
    }
}