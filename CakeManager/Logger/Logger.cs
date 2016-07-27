using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CakeManager.Logger
{
    public class Logger
    {
        public LogMode LogMode { get; set; }
        public AlertMode AlertMode { get; set; }

        public Logger()
        {

        }

        public Logger(LogMode logMode, AlertMode alertMode)
        {
            this.LogMode = logMode;
            this.AlertMode = alertMode;
        }

        public void Log(String toLog, String msg = null, String userDirectory = null)
        {
            if (msg == null)
            {
                msg = toLog;
            }

            if (userDirectory == null)
            {
                userDirectory = Path.GetTempPath() + "\\" +
                        Application.Current.ToString().Split('.')[0];
            }

            switch (this.LogMode)
            {
                case LogMode.NONE:
                    break;
                case LogMode.CONSOLE:
                    Console.WriteLine(msg);
                    break;
                case LogMode.EXTERNAL:
                    SaveToFile(toLog, userDirectory);
                    break;
                case LogMode.CURRENT_FOLDER:
                    SaveToFile(toLog, AppDomain.CurrentDomain.BaseDirectory);
                    break;
                case LogMode.TEMP_FOLDER:
                    String directory = Path.GetTempPath() + "\\" +
                        Application.Current.ToString().Split('.')[0];
                    SaveToFile(toLog, directory);
                    break;
                default:
                    break;
            }

            switch (this.AlertMode)
            {
                case AlertMode.NONE:
                    break;
                case AlertMode.CONSOLE:
                    break;
                case AlertMode.MESSAGE_BOX:
                    //MessageBox.Show(msg);
                    MessageBoxResult result = MessageBox.Show(msg, "Attention", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.Yes)
                    {
                        this.AlertMode = AlertMode.NONE;
                        LogMode temp = this.LogMode;
                        this.LogMode = LogMode.CURRENT_FOLDER;
                        this.Log(toLog);
                        this.AlertMode = AlertMode.MESSAGE_BOX;
                        this.LogMode = temp;
                    }
                    break;
                default:
                    break;
            }
        }

        private void SaveToFile(string toLog, string userDirectory)
        {
            Directory.CreateDirectory(userDirectory);
            TextWriter file2 = new StreamWriter(
                userDirectory + "\\current_logs",
                true, UTF8Encoding.UTF8);
            file2.WriteLine(toLog);
            file2.Close();
        }

        public void Log(Exception toLog, String msg = null)
        {
            if (msg == null)
            {
                msg = toLog.Message;
            }
            Log(msg);
        }
    }
}
