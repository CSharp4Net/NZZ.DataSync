using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZZ.DataSync.Logic
{
    public class ExceptionHandler
    {
        public ExceptionHandler(string logRootFolder)
        {
            MyLogger = new Logger(logRootFolder);
        }

        public Logger MyLogger { get; private set; }

        public void Handle(string message, params object[] parameters)
        {
            MyLogger.Log(message, parameters);
        }

        public void Handle(MethodBase sender, string message, bool showMsgBox = false)
        {
            MyLogger.Log(sender, message);

            if (showMsgBox)
                MessageBox.Show(message, "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Handle(MethodBase sender, Exception ex, bool showMsgBox = true)
        {
            MyLogger.Log(sender, ex);

            if (showMsgBox)
                MessageBox.Show(ex.ToString(), "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}