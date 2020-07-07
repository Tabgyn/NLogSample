using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSample
{
    public interface ILoggerManager
    {
        void LogError(string message, Exception exception);
    }
}
