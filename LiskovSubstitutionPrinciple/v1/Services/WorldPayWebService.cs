using System;

namespace LiskovSubstitutionPrinciple.v1.Services
{
    public class WorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionId, string username,
            string password, string productId)
        {
            return "Success";
        }
    }
}