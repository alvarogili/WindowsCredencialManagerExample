using System;
using CredentialManagement;

namespace WindowsCredencialManagerExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //https://stackoverflow.com/questions/17741424/retrieve-credentials-from-windows-credentials-store-using-c-sharp/17747020#17747020
            CredentialUtil.SetCredentials("FOO", "john", "1234", PersistanceType.LocalComputer);
            var userpass = CredentialUtil.GetCredential("FOO");
            Console.WriteLine($"User: {userpass.Username} Password: {userpass.Password}");
        }
    }
}