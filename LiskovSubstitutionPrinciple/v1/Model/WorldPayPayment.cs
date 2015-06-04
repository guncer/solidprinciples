﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple.v1.Services;

namespace LiskovSubstitutionPrinciple.v1.Model
{
    public class WorldPayPayment : PaymentBase
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string ProductId { get; set; }

        public override string Refund(decimal amount, string transactionId)
        {
            WorldPayWebService worldPayWebService = new WorldPayWebService();
            string response = worldPayWebService.MakeRefund(amount, transactionId, AccountName, Password, ProductId);
            return response;
        }
    }
}
