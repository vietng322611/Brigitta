using System.Text;
using Microsoft.AspNetCore.DataProtection;

namespace BrigittaBlazor.Utils;

public static class PasswordUtils
{
    public static string Encrypt(string password)
    {
        var provider = DataProtectionProvider.Create(
            new DirectoryInfo("keys")
        );
        var protector = provider.CreateProtector("AutoLogin.Password.v1");
        
        return Convert.ToBase64String(
            protector.Protect(Encoding.UTF8.GetBytes(password))
        );
    }

    public static string Decrypt(string protectedPassword)
    {
        var provider = DataProtectionProvider.Create(
            new DirectoryInfo("keys")
        );
        var protector = provider.CreateProtector("AutoLogin.Password.v1");
        
        return Encoding.UTF8.GetString(
            protector.Unprotect(Convert.FromBase64String(protectedPassword))
        );
    }
}