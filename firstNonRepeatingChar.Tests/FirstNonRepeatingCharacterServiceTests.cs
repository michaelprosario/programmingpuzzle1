using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firstNonRepeatingChar.Tests
{
    [TestClass]
    public class FirstNonRepeatingCharacterServiceTests
    {
        FirstNonRepeatingCharacterService service;

        [TestInitialize]
        public void Setup()
        {
            service = new FirstNonRepeatingCharacterService();
        }

        [TestMethod]
        public void Execute_Should_Return_Null_If_String_Null()
        {
            // arrange
            string input = null;

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == null, "output should be null");
        }

        [TestMethod]
        public void Execute_Should_Return_Null_If_String_Empty()
        {
            // arrange
            string input = "";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == null, "output should be null");
        }

        [TestMethod]
        public void Execute_Should_Return_Null_When_Input_Is_AAA()
        {
            // arrange
            string input = "AAA";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == null, "output should be null");
        }

        [TestMethod]
        public void Execute_Should_Return_A_When_Input_Is_A()
        {
            // arrange
            string input = "A";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == "A", "Should return A");
        }

        [TestMethod]
        public void Execute_Should_Return_Null_When_Input_Is_Has_No_Singles()
        {
            // arrange
            string input = "AAABBBCCC";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == null, "Should return null");
        }

        [TestMethod]
        public void Execute_Should_Return_B_When_Input_Is_AABCCCDDE()
        {
            // arrange
            string input = "AABCCCDDE";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == "B", "Should return B");
        }

        [TestMethod]
        public void Execute_Should_Return_Z_Null_When_Input_Is_AAAAAAAZ()
        {
            // arrange
            string input = "AAAAAAAZ";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == "Z", "Should return B");
        }

        [TestMethod]
        public void Execute_Should_Return_Z_When_Input_Is_AAAZAAA()
        {
            // arrange
            string input = "AAAAAAAZ";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == "Z", "Should return Z");
        }

        [TestMethod]
        public void Execute_Should_Return_Z_When_Input_Is_ZAAAAAAA()
        {
            // arrange
            string input = "ZAAAAAAA";

            // act
            var output = service.Execute(input);

            // assert
            Assert.IsTrue(output == "Z", "Should return Z");
        }
    }
}
