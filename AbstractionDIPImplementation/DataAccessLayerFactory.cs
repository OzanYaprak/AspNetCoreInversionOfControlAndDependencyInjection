using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDIPImplementation
{
    public class DataAccessLayerFactory
    {
        public static IDataAccessLayer GetDataAccessLayer()
        {
            return new DataAccessLayer();
        }
    }
}
