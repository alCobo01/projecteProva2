namespace TestProject_prova2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CorrectPassword()
        {
            //Arrange
            string password = "yeti1997hello";
            //Act
            bool result = MyUtils.ValidPassword(password);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IncorrectPassword()
        {
            //Arrange
            string password = "super2024";
            //Act
            bool result = MyUtils.ValidPassword(password);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IncorrectPassword2()
        {
            //Arrange
            string password = "pleaseApruebame21";
            //Act
            bool result = MyUtils.ValidPassword(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
