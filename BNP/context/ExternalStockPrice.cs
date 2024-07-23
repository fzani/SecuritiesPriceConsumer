using BNP.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.external
{
    /// <summary>
    /// Class to call a external api rest service
    /// </summary>
    public class ExternalStockPrice<T> : IDisposable, IExternalService where T : ISecurity
    {
        public IExternalService ExternalService { get; }

        public ExternalStockPrice()
        {
                
        }

        public ExternalStockPrice(IExternalService service)
        {
            this.ExternalService = service;
        }

        #region Implementations

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<T> GetCurrentPrice<T>()
        {
            return this.ExternalService.GetCurrentPrice<T>();
        }
        #endregion
    }
}
