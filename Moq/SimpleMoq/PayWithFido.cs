namespace SimpleMoq
{
    public class PayWithFido : IPaymentService
    {
        private int _accountId;
        private decimal _amount;

        public PayWithFido(int accountId, decimal amount)
        {
            _accountId = accountId;
            _amount = amount;
        }

        public bool CanPay()
        {
            return _amount > 0;
        }
    }
}
