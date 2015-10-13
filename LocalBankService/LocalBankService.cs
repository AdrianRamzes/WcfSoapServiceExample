using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocalBankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LocalBankService" in both code and config file together.
    public class LocalBankService : ILocalBankService
    {

        public string GetBankName()
        {
            Log();
            //OperationContext context = OperationContext.Current;
            return "106068 AK-Bank";
        }

        private void Log()
        {
            Console.WriteLine("{0}:\t{1}", DateTime.Now, new StackTrace().GetFrame(1).GetMethod().Name);
        }
    }
}
