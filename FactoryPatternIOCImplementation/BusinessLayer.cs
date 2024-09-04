using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternIOCImplementation
{
    public class BusinessLayer
    {
        private DataAccessLayer _dataAccessLayer { get; set; }

        public BusinessLayer()
        {
            _dataAccessLayer = DataAccessLayerFactory.GetDataAccessLayer();
        }

        public List<Product> GetProducts()
        {
            return _dataAccessLayer.GetProducts();
        }
    }
}
