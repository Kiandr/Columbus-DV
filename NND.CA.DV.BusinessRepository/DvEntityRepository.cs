using System;
using NND.CA.Common.Model;
using NND.CA.DV.Interfaces.BusinessRepository;
using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.BusinessRepository
{
    public class DvEntityRepository<T> : IDvEntityRepository<T> where T : DVModelViewModel<DVModel>, new()
    {

        // Init constructor with data pool? 


        public DvEntityRepository(BaseModelContext basemodelContext)
        {



            throw new NotImplementedException();
        }




        public void GetCompanies()
        {




            throw new NotImplementedException();
        }



        public T UpdateStatus(T model)
        {
            
            throw new NotImplementedException();
        }

        public T GetCallProcura(T model, string sqlQUery)
        {



            throw new NotImplementedException();
        }

        public T UpdateCallProcura(T model, string sqlQUery)
        {
            throw new NotImplementedException();
        }
    }
}