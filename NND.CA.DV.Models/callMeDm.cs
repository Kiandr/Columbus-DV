/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

#region Namespace
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NND.CA.Common.Model;
#endregion

namespace NND.CA.DV.Models
{

    /// <summary>
    /// Base model for Visual Process Flow
    /// </summary>
    public partial class callMeDm : BaseModel
    {
        /// <summary>
        /// id entity, which is being used to identify the visual process flow from template, usually it is in the following format:  1010 or 1111, 1112, etc.
        /// </summary>
        [Key]
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        //[StringLength(16, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        public int Id { get; set; }

        /// <summary>
        /// Data string containes the actual svg elements.
        /// </summary>
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        //[StringLength(100000, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        public int EmpoyeeId { get; set; }

        /// <summary>
        /// This item is being used to reserve SageId from the multitenant controller class for client side Ajax calls. Then the Ajax calls in the clinet side, uses this method to evaluate permission of the edit mode
        /// </summary>
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        //[StringLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        public int EventId { get; set; }

        /// <summary>

        /// </summary>
        ////[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        ////[StringLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        //[Key]
        ////[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public NndPatient Patient { get; set; }

        ///// <summary>
        ///// The ParentId is being used to identify the parent of Visual Process Flow in the MenuDetails.xml file. 
        ///// </summary>
        ////[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        ////[StringLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        public NndCareGiver Cg { get; set; }

        ///// <summary>
        /////  The ResourceKey is being consumed in the Sage.CA.SBS.ERP.Sage300.Common.Resources.Portal.NavigationResx file. 
        ///// </summary>
        ////[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        ////[StringLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(AnnotationsResx))]
        public NndEvent nndEvent { get; set; }
    }
}