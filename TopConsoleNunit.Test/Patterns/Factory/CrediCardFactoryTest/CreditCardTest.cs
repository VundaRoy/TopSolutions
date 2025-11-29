using TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards;

namespace TopConsoleNunit.Test;

[TestFixture]
public class CreditCardTest
{
    

    [Test]
    public void AmexCreditCardTest_GivenAmex()
    {
        //Arrange
                var cardType = "Amex";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsTrue(creditCard.GetCardType().Equals("AMEX Credit Card"));
    }
    [Test]
    public void AmexCreditCardTest_GivenAMEX()
    {
        //Arrange
        var cardType = "AMEX";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsTrue(creditCard.GetCardType().Equals("AMEX Credit Card"));
    }
    [Test]
    public void AmexCreditCardTest_GivenAMEX1()
    {
        //Arrange
        var cardType = "AMEX1";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsFalse(creditCard.GetCardType().Equals("AMEX Credit Card"));
    }
    [Test]
    public void VisaCreditCardTest_GivenVisa()
    {
                //Arrange
        var cardType = "Visa";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsTrue(creditCard.GetCardType().Equals("VISA Credit Card"));
    }
    [Test]
    public void MasterCreditCardTest_GivenMaster()
    {
        //Arrange
        var cardType = "Master";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsTrue(creditCard.GetCardType().Equals("MASTER Credit Card"));
    }
    [Test]
    public void InvalidCreditCardTest_GivenInvalid()
    {
        //Arrange
        var cardType = "Invalid";
        //Act
        var creditCard = CreditCardFactory.GetCreditCard(cardType);
        //Assert
        Assert.IsTrue(creditCard.GetCardType().Equals("Default Credit Card"));
    }
}
