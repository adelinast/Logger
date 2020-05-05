using NUnit.Framework;

namespace nsLogger
{
    class LoggerTest
    {
        [SetUp]
        public void Init()
        {
            Logger logger = new ConsoleLogger (LogLevel.Debug);
        }

        [TearDown]
        public void Dispose()
        {
        }

        #region Sample_TestCode

        [Test]
        public void First()
        {
            //ACT

            //ASSERT
            Assert.IsTrue(1==1);
        }

        
        #endregion
    }
}
