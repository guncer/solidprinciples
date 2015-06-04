

using SingleResponsibility.v2.Model;

namespace SingleResponsibility.v2.Services
{
    public interface IPaymentService
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount);
    }
}
