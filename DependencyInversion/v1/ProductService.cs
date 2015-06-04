using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.v1
{
    public class ProductService
    {
        private ProductDiscount _productDiscount;
        private ProductRepository _productRepository;

        public ProductService()
        {
            _productDiscount = new ProductDiscount();
            _productRepository = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> productsFromDataStore = _productRepository.FindAll();
            foreach (Product p in productsFromDataStore)
            {
                p.AdjustPrice(_productDiscount);
            }
            return productsFromDataStore;
        }
    }
}
