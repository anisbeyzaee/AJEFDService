﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFDService
{
    class ExternalComcs
    {
        public ExternalComcs(String path)
        {
            connect(path);

        }

        private void connect(String path)
        {
            ProcessStartInfo s = new ProcessStartInfo();
            s.FileName = @"C:\Program Files\Java\jdk-11.0.2\bin\java.exe";

            s.WorkingDirectory = @"C:\Temp\JClassifier";
            //s.Arguments = path;
            s.Arguments = @"ReadImage " + path;
            s.UseShellExecute = false;

            s.RedirectStandardOutput = true;

            s.RedirectStandardError = true;

            s.CreateNoWindow = true;
            Process process = new Process();

            process.StartInfo = s;

            process.Start();

            while (!process.StandardOutput.EndOfStream)

            {

                string isFire = process.StandardOutput.ReadLine();

                System.Windows.MessageBox.Show("Joe says :  " + isFire);

                break;

            }
        }
    }
}
