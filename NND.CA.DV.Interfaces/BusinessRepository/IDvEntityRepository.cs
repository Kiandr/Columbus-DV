using NND.CA.DV.Models;
using NND.CA.DV.Models.ViewModels;

namespace NND.CA.DV.Interfaces.BusinessRepository
{
    public interface IDvEntityRepository<T> where T : DVModelViewModel<DVModel>, new()
    {
        /// <summary>
        ///     Update the content of the T Mode, which is a DVModel
        ///     Update status will be defined from JS side within attributes of the Model
        ///     The operation takes place all the way through the data pipe inside business repo
        ///     return model has been updated and returns a success,fail, or new datamodel to the front end
        /// </summary>
        /// <param name="model"> DVModelViewModel(DVModel)</param>
        /// <returns></returns>
        T UpdateStatus(T model);
    }
}