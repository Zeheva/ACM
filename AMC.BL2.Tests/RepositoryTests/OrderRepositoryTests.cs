using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using ACM.BL.Repositories;
using Xunit;

namespace AMC.BL2.Tests.RepositoryTests
{
    public class OrderRepositoryTests
    {
        [Fact]
        public void OrderRepoValidateRetrieve()
        {
            var orderRepository = new OrderRepository();

            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            var actual = orderRepository.Retrieve(1);

            Assert.Equal(expected.OrderDate,actual.OrderDate);


        }

    }
}
