using Register;


namespace Register_Tests
{
    public class UnitTest1
    {
        // Don't try to use [Theory]
        // Just make individual tests with [Fact]
        // Inside each test, create a list of
        // products, and call the function
        // and compare actual to expected

        [Fact]
        public void TestGrandTotal()
        {
            Product p1 = new Product("milk", 3.50m);
            Product p2 = new Product("eggs", 1.00m);
            Product p3 = new Product("bread", 3.00m);
            List<Product> products = new List<Product>();
            products.Add(p1); products.Add(p2); products.Add(p3);

            decimal actual = CashRegister.GrandTotal(products);
            Assert.Equal(7.50m, actual);
        }

        [Fact]
        public void TestCalculateTax()
        {
            Product p1 = new Product("milk", 3.50m);
            Product p2 = new Product("eggs", 1.00m);
            Product p3 = new Product("bread", 3.00m);
            List<Product> products = new List<Product>();
            products.Add(p1); products.Add(p2); products.Add(p3);

            decimal actual = CashRegister.CalulateTax(products);
            Assert.Equal(0.45m, actual);
        }

        [Fact]
        public void TestFinalTotal()
        {
            Product p1 = new Product("milk", 3.50m);
            Product p2 = new Product("eggs", 1.00m);
            Product p3 = new Product("bread", 3.00m);
            List<Product> products = new List<Product>();
            products.Add(p1); products.Add(p2); products.Add(p3);

            string actual = CashRegister.FinalTotal(products);
            Assert.Equal("7.95", actual);
        }
    }
}