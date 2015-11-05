namespace CreditCardValidation.Common
{
    public interface ICreditCardValidator
    {
        bool IsCCValid(string creditCardNumber, out string errMessage);
    }
    
}
