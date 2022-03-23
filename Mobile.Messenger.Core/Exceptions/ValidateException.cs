using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Exceptions
{
    public class ValidateException : Exception
    {
        private string? msgErrValidate = null;

        public ValidateException(string msgErrValidate)
        {
            this.msgErrValidate = msgErrValidate;
        }

        public override string Message
        {
            get { return msgErrValidate; }
        }
    }
}
