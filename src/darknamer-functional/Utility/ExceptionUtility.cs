using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class ExceptionUtility
    {
        /// <summary>
        /// Functional for get inner of exception and return inner exception.
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static Exception GetInnerException(Exception exception)
        {
            while (true)
            {
                if (exception.InnerException != null)
                {
                    exception = exception.InnerException;
                    continue;
                }
                break;
            }
            return exception;
        }
    }
}
