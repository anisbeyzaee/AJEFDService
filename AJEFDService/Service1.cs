using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using IPathLibrary;


namespace AJEFDService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
public void onDebug()
        {
            OnStart(null);

        }
        
        protected override void OnStart(string[] args)
        {

            ReadConfig rc = new ReadConfig();
            rc.ReadObjType();
            String[] list = rc.ReadObjType();
            IPath obj = ObjectFactoryPath.Create(list);
            Console.WriteLine(obj);
            Console.Read();
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart2.txt");


        }

        protected override void OnStop()
        {
        }
    }
}
