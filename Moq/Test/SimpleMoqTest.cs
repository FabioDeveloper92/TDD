using Moq;
using SimpleMoq;
using Xunit;

namespace Test
{
    public class SimpleMoqTest
    {
        [Fact]
        public void get_total_avg_mark_test()
        {
            // ARRANGE
            var mock = new Mock<IPaymentService>();
            mock.Setup(p => p.CanPay()).Returns(true);

            // ACT
            var myAccount = new MyAccount(mock.Object);
            var havePay = myAccount.Pay();

            // ASSERT
            Assert.True(havePay);
            mock.Verify(x => x.CanPay(), Moq.Times.Once);
            
        }
    }
}
