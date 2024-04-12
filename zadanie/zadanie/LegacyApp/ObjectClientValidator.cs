namespace LegacyApp;

public class ObjectClientValidator : IClientValidator
{
    private IUserCredit _userCredit;

    public ObjectClientValidator(IUserCredit userCredit)
    {
        _userCredit = userCredit;
    }

    public bool Validate(Client client)
    {
        return true;
    }
}