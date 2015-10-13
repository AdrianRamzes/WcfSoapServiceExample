using LocalBankClient.LocalBankServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalBankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LocalBankServiceClient client = 
                new LocalBankServiceClient("LocalBankServiceEndpoint"))
            {
                while (true)
                {
                    if (Console.ReadLine().Equals("exit"))
                        break;

                    var name = client.GetBankName();
                    Console.WriteLine(name);
                }
            }
        }
    }
}
