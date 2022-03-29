
namespace SimpleMoq
{
    public class MyAccount
    {
        private IPaymentService _paymentService;

        public MyAccount(IPaymentService students)
        {
            _paymentService = students;
        }
        public bool Pay()
        {
            return _paymentService.CanPay();
        }
    }
}
