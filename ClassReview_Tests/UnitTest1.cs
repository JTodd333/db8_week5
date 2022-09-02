using ClassReview;


namespace ClassReview_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPerim()
        {
            Rectangle r1 = new Rectangle(10m, 20m);
            decimal actual = r1.Perim();
            Assert.Equal(60m, actual);
        }

        [Fact]
        public void TestArea()
        {
            Rectangle r1 = new Rectangle(10m, 20m);
            decimal actual = r1.Area();
            Assert.Equal(200m, actual);
        }

        [Fact]
        public void TestCheckRange9()
        {
            //Rule: one test per test function
            //dont need to make a instance for this one
            bool actual = Misc.CheckRange(9);
            Assert.Equal(false, actual);
        }

        [Fact]
        public void TestCheckRange10()
        {
            //Rule: one test per test function
            bool actual = Misc.CheckRange(10);
            Assert.Equal(true, actual);
        }

        [Fact]
        public void TestCheckRange15()
        {
            //Rule: one test per test function
            bool actual = Misc.CheckRange(15);
            Assert.Equal(true, actual);
        }

        [Fact]
        public void TestCheckRange20()
        {
            //Rule: one test per test function
            bool actual = Misc.CheckRange(20);
            Assert.Equal(true, actual);
        }

        [Fact]
        public void TestCheckRange21()
        {
            //Rule: one test per test function
            bool actual = Misc.CheckRange(21);
            Assert.Equal(false, actual);
        }

        //Next Tests

        [Fact]
        public void TestPosNegMinus2()
        {
            int actual = Misc.PosNeg(-2);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestPosNegMinus1()
        {
            int actual = Misc.PosNeg(-1);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestPosNegZero()
        {
            int actual = Misc.PosNeg(0);
            Assert.Equal(0, actual);
        }

        [Fact]
        public void TestPosNegPos1()
        {
            int actual = Misc.PosNeg(1);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TestPosNegPos2()
        {
            int actual = Misc.PosNeg(2);
            Assert.Equal(1, actual);
        }
    }
}