using Microsoft.Practices.Unity;
using NND.CA.Common.Model;
using NND.CA.Common.Web;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Web.Controllers.ControllerInternal
{
    public class DvControllerInternal<T> : InternalControllerBase<T> where T : DVModelViewModel<DVModel>, new()
    {
        //protected IDvEntityService<DVModelViewModel<DVModel>> ServicesInLayer;
        protected  new IDvEntityService<DVModelViewModel<DVModel>> ServicesInternalController;
        #region Constructor

        public DvControllerInternal(IUnityContainer ContainerInsideMultiTenant)
            : base(ContainerInsideMultiTenant)
        {
            var testPar = new BaseModelContext() {Container =   ContainerInsideMultiTenant };

            ServicesInternalController =
                ContainerInsideMultiTenant.Resolve<IDvEntityService<DVModelViewModel<DVModel>>>("IDvEntityService", new ParameterOverride("BaseModelContextFromController", "testPar").OnType<BaseModelContext>());
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