using NND.CA.Common.Model;
using NND.CA.Common.Web;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Web.Controllers.ControllerInternal
{
    public class DvControllerInternal<T> : InternalControllerBase<T> where T : DVModelViewModel<DVModel>, new()
    {
        #region Constructor

        public DvControllerInternal(BaseModelContext baseModelContext)
            : base(baseModelContext)
        {
        }

        #endregion

        #region Internal Classes

        internal T Load()
        {
            // return serviceLyer.LoadGrid<DVModel>(id);
            // 
            return ServicesInLayer;
        }

        #endregion
    }
}