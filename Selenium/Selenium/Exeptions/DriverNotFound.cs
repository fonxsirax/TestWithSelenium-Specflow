using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Exeptions
{
    class DriverNotFound : Exception
    {
        public DriverNotFound(string msg) : base(msg)
        {

        }
    }
}
