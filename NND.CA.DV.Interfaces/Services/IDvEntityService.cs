using NND.CA.DV.Models;


namespace NND.CA.DV.Interfaces.Services
{
    public  interface IDvEntityService<T> where T: DVModel, new()
    {
        /// <summary>
        /// Update the content of the T Mode, which is a DVModel
        /// Update status will be defined from JS side within attributes of the Model
        /// The operation takes place all the way through the data pipe inside business repo
        /// return model has been updated and returns a success,fail, or new datamodel to the front end
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        T UpdateStatus(T model);
    }
}
