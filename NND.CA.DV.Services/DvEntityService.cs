using System;
using Microsoft.Practices.Unity;
using NND.CA.Common.Model;
using NND.CA.Common.Web.ServicesCommon;
using NND.CA.DV.Interfaces.BusinessRepository;
using NND.CA.DV.Interfaces.Services;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Services
{
    public class DvEntityService<T> : FlatService<T>, IDvEntityService<T> where T : DVModelViewModel<DVModel>, new()
    {
        public DvEntityService(IUnityContainer basemodelContext) : base(basemodelContext)
        {
        }

        public T UpdateStatus(T model)
        {
            var dvEntityRepositoryLocal = BaseModelContextInBaseClassAtFlasService.Resolve<IDvEntityRepository<DVModelViewModel<DVModel>>>("IDvEntityRepository");
            //var modelRepo = new DVModelViewModel<DVModel>();
         
           var results =  dvEntityRepositoryLocal.UpdateStatus(model);
            return (T) results;
            //return (T) BaseModelContextInBaseClassAtFlasService.Container.Resolve<IDvEntityRepository<DVModelViewModel<DVModel>>>("IDvEntityRepository").UpdateStatus(model);


            //throw new NotImplementedException();
        }
    }
}