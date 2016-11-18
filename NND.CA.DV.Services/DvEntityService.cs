using System;
using NND.CA.Common.Model;
using NND.CA.Common.Web.ServicesCommon;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Services
{
    public class DvEntityService<T> : FlatService<T>, IDvEntityService<T> where T : DVModelViewModel<DVModel>, new()
    {
        public DvEntityService(BaseModelContext basemodelContext) : base(basemodelContext)
        {
        }

        public T UpdateStatus(T model)
        {
            //var ServicesInLayer = ContainerInsideMultiTenant.Resolve<IDvEntityService<DVModelViewModel<DVModel>>>(/*(new ParameterOverride("context", baseModelContext))*/);
            throw new NotImplementedException();
        }
    }
}