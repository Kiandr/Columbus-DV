using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using NND.CA.Common.Web;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Web.Controllers.ControllerInternal
{
    public class DVControllerInternal<T> : MultitenantControllerBase<T> where T : DVModelViewModel<DVModel>, new()
    {
        #region Constructor

        /// <summary>
        /// Constructor to initialize the service from the input context
        /// </summary>
        /// <param name="context"></param>
        public DVControllerInternal(NND.CA.Common.Model.Context context)
            //: base(context)
        {
            //_orderEntryPaymentInfoCacheKey = CreateSessionKey<TOrder>(OrderEntry.SessiontOrderPaymentInfo);
        }

        #endregion

        #region Internal Classes
        internal DVModelViewModel<DVModel> load()
        {
            return new DVModelViewModel<DVModel>();
        }
        #endregion
    }
}