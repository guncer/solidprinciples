using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.v1.Services
{
    public class InventoryService
    {
        public void Reserve(string identifier, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }
    public class InsufficientInventoryException : Exception
    {
    }
}
