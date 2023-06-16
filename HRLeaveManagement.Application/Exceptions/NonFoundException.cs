using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Exceptions
{
    public class NonFoundException : Exception
    {
        public NonFoundException(string name, object key) : base($"{name} ({key}) was not found")
        {

        }
    }
}
