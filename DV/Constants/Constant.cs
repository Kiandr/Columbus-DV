/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */
namespace NND.CA.DV.Web.Constants
{
    /// <summary>
    /// Cosntant container of the Visual Process Flow Web project. This container will serve all internal varibles used in the controller. 
    /// </summary>
    public class DvConstant
    {
        /// <summary>
        /// Physical path to the xml container of visual process flow on the server
        /// </summary>
        public const string VirtualPath = "/App_Data/VisualProcessFlow.xml";
        /// <summary>
        /// html div identifier for locating visual process flow object
        /// </summary>
        public const string VpfContent = "vpf-content";
        /// <summary>
        /// Location of the partial view in the main web project
        /// </summary>
        public const string DvIndexPartialViewPath = "~/Areas/DV/Views/DataVisualization/Index.cshtml";
        /// <summary>
        /// Location of Index cshtml in the main web project
        /// </summary>
        public const string VpfView = "~/Areas/VPF/Views/Flow/Index.cshtml";
        /// <summary>
        /// context string
        /// </summary>
        public static string Parameter = "context";
        /// <summary>
        /// Title of the Html Page Representing the Visual Process Flow
        /// </summary>
        public static string Title = "title";
    }
}