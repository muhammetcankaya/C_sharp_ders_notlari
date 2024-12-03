using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface ILoggerservice
    {
        // burada şablonu oluşturduk ilgili classları bu şablondan alacak şekilde yaptık
        // loglamak yapılan adımları bir yere kayıt eder
        void Log();
    }
}
