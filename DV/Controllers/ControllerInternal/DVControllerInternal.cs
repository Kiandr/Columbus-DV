using Microsoft.Practices.Unity;
using NND.CA.Common.Web;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Web.Controllers.ControllerInternal
{
    public class DvControllerInternal<T> : InternalControllerBase<T> where T : IDvEntityService<DVModelViewModel<DVModel>>, new()
    {
        //protected IDvEntityService<DVModelViewModel<DVModel>> ServicesInLayer;
      
        #region Constructor

        public DvControllerInternal(IUnityContainer ContainerInsideMultiTenant)
            : base(ContainerInsideMultiTenant)
        {

            ServicesInternalController = ContainerInsideMultiTenant.Resolve<T>("IDvEntityService");
        }

        #endregion

        #region Internal Classes

        public void Test()
        {
            var model = new DVModelViewModel<DVModel>();
            ServicesInternalController.UpdateStatus(model);
           
        }

        //public static implicit operator DvControllerInternal<T>(DvControllerInternal<DVModelViewModel<DVModel>> v)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
    }
}