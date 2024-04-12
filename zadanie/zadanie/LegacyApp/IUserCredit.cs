using System;

namespace LegacyApp;

public interface IUserCredit
{
    public int GetCreditLimit(string lastName, DateTime dateOfBirth);
}