using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestVS2015.Tests
{
    [TestClass()]
    public class UserTests
    {
        User sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new User();
        }

        [TestCleanup]
        public void Clenup()
        {
            sut = null;
        }

        [TestMethod()]
        public void GetFullName_WhenFirstAndLastNameAreNullOrEmpty_ShouldReturnEmptyString()
        {
            sut.FirstName = null;
            sut.LastName = null;

            var result = sut.GetFullName();

            StringAssert.Equals("", result);

        }
    }
}