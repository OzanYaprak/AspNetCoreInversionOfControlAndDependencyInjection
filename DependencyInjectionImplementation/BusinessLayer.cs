using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionImplementation
{
    public class BusinessLayer
    {
        private IDataAccessLayer _dataAccessLayer { get; set; }

        public BusinessLayer(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public List<Product> GetProducts()
        {
            return _dataAccessLayer.GetProducts();
        }
    }
}
