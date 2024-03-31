using System;

namespace LegacyApp;

public class ValidatorFactory : IValidateFactory
{
    public IUserCredit _userCredit { get; set; }

    public ValidatorFactory(IUserCredit userCredit)
    {
        _userCredit = userCredit;
    }

    public IClientValidator CreateClientValidator(Client client)
    {
        try
        {
            string validatorClassName = $"LegacyApp.Core.Validators.Clients.{client.Name}Validator";
            Type validatorType = Type.GetType(validatorClassName);
            
            if (validatorType != null)
            {
                return (IClientValidator)Activator.CreateInstance(validatorType, _userCredit);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ERR");
        }

        return new ObjectClientValidator(_userCredit);
    }
}