﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.v1.Services
{
    public class PaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }
        public void Charge()
        {
            throw new AccountBalanceMismatchException();
        }
    }

    public class AccountBalanceMismatchException : Exception
    {
    }
}
