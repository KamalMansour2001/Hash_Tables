namespace Hash_table_test
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        private const string Expected1 = "Hittat Inget!";
        private const string Expected2 = "Went good!";
        private const string Expected3 = string;
        private const string Expected1 = "Hittat Inget!";
        private const string Expected1 = "Hittat Inget!";
        [TestMethod]

        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Hash_Tables.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
            Assert.
        }
    }
}

