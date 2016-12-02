using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NND.CA.Common.Model;
using NND.CA.Common.Web;
using NND.CA.Common.Web.DBAccess;
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




            GetCompanies();
            var stopHere = 10;




            //using (var context = new WorkflowContext())
            //{
            //     context.WorkflowInstanceRepository().GetById(10);
            //}
        }




        public void GetCompanies()
        {





            using (var context = new TestDbContext())
            {
                context.TestDataModels.Add(new TestDataModel() {Id = (DateTime.Now).ToLocalTime().Millisecond, Name = "Keivan"});
           
                context.SaveChanges();
                var test = context.TestDataModels.Find(8);


            }

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