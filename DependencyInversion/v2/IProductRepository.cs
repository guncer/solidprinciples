using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.v2
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
    }
}
