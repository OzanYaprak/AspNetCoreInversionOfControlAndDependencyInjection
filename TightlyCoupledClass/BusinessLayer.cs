using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightlyCoupledClass
{
    public class BusinessLayer
    {
        private DataAccessLayer _dataAccessLayer { get; set; }

        public BusinessLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public List<Product> GetProducts()
        {
            return _dataAccessLayer.GetProducts();
        }
    }
}
