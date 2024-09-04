using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionImplementation
{
    public class DataAccessLayerFactory
    {
        public static IDataAccessLayer GetDataAccessLayer()
        {
            return new DataAccessLayer();
        }
    }
}
