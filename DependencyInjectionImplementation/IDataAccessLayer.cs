using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionImplementation
{
    public interface IDataAccessLayer
    {
        List<Product> GetProducts();
    }
}
