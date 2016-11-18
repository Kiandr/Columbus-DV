using System;
using NND.CA.Common.Model;
using NND.CA.DV.Interfaces.BusinessRepository;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.BusinessRepository
{
    public class DvEntityRepository<T> : IDvEntityRepository<T> where T : DVModelViewModel<DVModel>, new()
    {
        public DvEntityRepository(BaseModelContext basemodelContext)
        {
        }

        public T UpdateStatus(T model)
        {
            throw new NotImplementedException();
        }
    }
}