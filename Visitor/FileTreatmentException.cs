using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException() { }

        public FileTreatmentException(string message) : base(message) { }

        public FileTreatmentException(string message, Exception innerException) : base(message, innerException) { }
    }
}
