using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternIOCImplementation
{
    public class DataAccessLayerFactory
    {
        public static DataAccessLayer GetDataAccessLayer()
        {
            return new DataAccessLayer();
        }
    }
}
