using System;
using Xunit;

namespace Simple.OData.Client.Tests
{
    public class FilterAsKeyTests : TestBase
    {
        [Fact]
        public void FindAllByFilterAsKeyEqual()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(x.ProductID == 1);
            string commandText = command.CommandText;
            Assert.Equal("Products(1)", commandText);
        }

        [Fact]
        public void FindAllByFilterAsKeyNotEqual()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(x.ProductID != 1);
            string commandText = command.CommandText;
            Assert.Equal("Products?$filter=ProductID%20ne%201", commandText);
        }

        [Fact]
        public void FindAllByFilterAsNotKeyEqual()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(!(x.ProductID == 1));
            string commandText = command.CommandText;
            Assert.Equal("Products?$filter=not%28ProductID%20eq%201%29", commandText);
        }

        [Fact]
        public void FindAllByFilterAsKeyEqualLong()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(x.ProductID == 1L);
            string commandText = command.CommandText;
            Assert.Equal("Products(1L)", commandText);
        }

        [Fact]
        public void FindAllByFilterAsKeyEqualAndExtraClause()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(x.ProductID == 1 && x.ProductName == "abc");
            string commandText = command.CommandText;
            Assert.Equal("Products?$filter=ProductID%20eq%201%20and%20ProductName%20eq%20%27abc%27", commandText);
        }

        [Fact]
        public void FindAllByFilterAsKeyEqualDuplicateClause()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Products")
                .Filter(x.ProductID == 1 && x.ProductID == 1);
            string commandText = command.CommandText;
            Assert.Equal("Products(1)", commandText);
        }

        [Fact]
        public void FindAllByFilterAsCompleteCompoundKey()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("OrderDetails")
                .Filter(x.OrderID == 1 && x.ProductID == 2);
            string commandText = command.CommandText;
            Assert.Equal("Order_Details(OrderID=1,ProductID=2)", commandText);
        }

        [Fact]
        public void FindAllByFilterAsInCompleteCompoundKey()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("OrderDetails")
                .Filter(x.OrderID == 1);
            string commandText = command.CommandText;
            Assert.Equal("Order_Details?$filter=OrderID%20eq%201", commandText);
        }

        [Fact]
        public void FindAllEmployeeSuperiors()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Employees")
                .Filter(x.EmployeeID == 1)
                .NavigateTo("Superior");
            string commandText = command.CommandText;
            Assert.Equal("Employees(1)/Superior", commandText);
        }

        [Fact]
        public void FindAllCustomerOrders()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Customers")
                .Filter(x.CustomerID == "ALFKI")
                .NavigateTo("Orders");
            string commandText = command.CommandText;
            Assert.Equal("Customers('ALFKI')/Orders", commandText);
        }

        [Fact]
        public void FindAllEmployeeSubordinates()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Employees")
                .Filter(x.EmployeeID == 2)
                .NavigateTo("Subordinates");
            string commandText = command.CommandText;
            Assert.Equal("Employees(2)/Subordinates", commandText);
        }

        [Fact]
        public void FindAllOrderOrderDetails()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Orders")
                .Filter(x.OrderID == 10952)
                .NavigateTo("OrderDetails");
            string commandText = command.CommandText;
            Assert.Equal("Orders(10952)/Order_Details", commandText);
        }

        [Fact]
        public void FindEmployeeSuperior()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Employees")
                .Filter(x.EmployeeID == 1)
                .NavigateTo("Superior");
            string commandText = command.CommandText;
            Assert.Equal("Employees(1)/Superior", commandText);
        }

        [Fact]
        public void FindAllFromBaseTableByFilterAsKeyEqual()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Transport")
                .Filter(x.TransportID == 1);
            string commandText = command.CommandText;
            Assert.Equal("Transport(1)", commandText);
        }

        [Fact]
        public void FindAllFromDerivedTableByFilterAsKeyEqual()
        {
            var x = ODataFilter.Expression;
            var command = _client
                .For("Transport")
                .As("Ship")
                .Filter(x.TransportID == 1);
            string commandText = command.CommandText;
            Assert.Equal("Transport/NorthwindModel.Ship(1)", commandText);
        }
    }
}
