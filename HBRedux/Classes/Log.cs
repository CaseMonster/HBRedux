using System;
using System.IO;
using System.Windows.Forms;

namespace HBRedux
{
    class Log
    {
        public static string LOGFILE = "HBRedux.Log";
        static StreamWriter log;

        //init
        public Log()
        {
            //timestamp log
            info("HBRedux Started");
        }

        public static void info(Device a, string s)
        {
            write(linePrep(a, s));
        }

        public static void info(string s)
        {
            write(linePrep(s));
        }

        public static void error(Device a, string s)
        {
            write(linePrep(a, s));
            MessageBox.Show(linePrep(a, s));
        }

        public static void error(string s)
        {
            write(linePrep(s));
            MessageBox.Show(linePrep(s));
        }

        static string linePrep(Device a, string s)
        {
            return (Environment.NewLine + "[" + DateTime.Now.ToString("yyyyMMMdd HHmm") + "]  "
                + Environment.NewLine + "   " + s
                + Environment.NewLine + "   NAME: " + a.name
                + Environment.NewLine + "   IP:   " + a.ip
                + Environment.NewLine + "   DESC: " + a.description
                );
        }
        static string linePrep(string s)
        {
            return (Environment.NewLine + "[" + DateTime.Now.ToString("yyyyMMMdd HHmm") + "]  "
                + Environment.NewLine + "   " + s
                );
        }

        static void write(string s)
        {
            log = new StreamWriter(LOGFILE, true);
            log.WriteLine(s);
            log.Close();
        }
    }
}
