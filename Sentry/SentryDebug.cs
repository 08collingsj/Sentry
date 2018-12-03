using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry
{
    public class SentryDebug
    {
        private List<string> _outputList;
        private string _AppName = Sentry.App.ResourceAssembly.GetName().ToString();

        public SentryDebug()
        {
            _outputList = new List<string>();

            Console.WriteLine("Instanciated Sentry.exe");
            Console.WriteLine(_AppName + " " +  DateTime.Now);
        }

        public void FlushToLog()
        {
            //Print _OutputList to log file for this session 
        }
        
        private void Debug(string outputString)
        {
            WriteToConsole(DateTime.Now + ":  " +  outputString);
        }

        /// <summary>
        /// Stores all outputs to then be flushed to a session file once the instance is closed
        /// </summary>
        /// <param name="outputString"></param>
        private void WriteToConsole(string outputString)
        {
            Console.WriteLine(outputString);
            _outputList.Add(outputString);
        }
    }
}
