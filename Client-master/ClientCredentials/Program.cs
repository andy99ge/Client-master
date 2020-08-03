using System;

namespace ClientCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
           // IDSHelper.Admin().GetAwaiter().GetResult();

            IDSHelper.Admin3().GetAwaiter().GetResult();
        }
    }
}