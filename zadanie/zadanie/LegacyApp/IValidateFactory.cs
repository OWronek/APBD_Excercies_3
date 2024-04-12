namespace LegacyApp;

public interface IValidateFactory
{
    IClientValidator CreateClientValidator(Client client);
}