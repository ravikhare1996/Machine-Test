
using common.OFM;
using CommonServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI;
using XpertStudio.Common.Database;
using XpertStudio.Common.DTOs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Globals;

namespace WinFormUI3Tier
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            //register db providers
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("Microsoft.EntityFrameworkCore.SqlServer", Microsoft.Data.SqlClient.SqlClientFactory.Instance);
            //DbProviderFactories.RegisterFactory("System.Data.SQLite", System.Data.SQLite.SQLiteFactory.Instance);

            //SetConnection();
            var SolutionDirectory = Path.GetFullPath(Path.GetDirectoryName(Application.StartupPath + "\\..\\..\\..\\..\\"));
            XSProjectDto.InitializeCommon(SolutionDirectory);
            //if (arguments != null && arguments.Length > 0)
            //    Application.Run(new MainForm(arguments[0]));
            //else
            //    Application.Run(new MainForm());

            Application.Run(new XpertSampleForm());
        }
        public static void SetConnection()
        {
            // set sql server connection string to common dll
            string line;
            int Line_No = 0;
            System.IO.StreamReader objReader = new System.IO.StreamReader("config.Txp");
            while (objReader.Peek() != -1)
            {
                line = objReader.ReadLine();
                if (Line_No == 0)
                {
                    XSDBFunctionality.SetConnectionEncryptFormat(line);
                    clsDBFuncationality.SetConnectionEncryptFormat(line);
                }

                else if (Line_No == 1)
                {
                    XSDBFunctionality.SetConnectionEncryptFormat2(line);
                    clsDBFuncationality.SetConnectionEncryptFormat2(line);
                }
                else
                    throw new Exception("More than two connections in config file not supported.");
                Line_No = Line_No + 1;
            }
            // set domain connection
            CurrentConnection.DomainConnection = new DBConnection { _ConnectionDBType = ConnectionDBType.SQLServer, _ConnectionString = clsDBFuncationality.connectionString };
            //set metadata connection
            ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings["XpertContext"];
            CurrentConnection.MetadataConnection = new DBConnection { _ConnectionDBType = ConnectionDBType.SQLite, _ConnectionString = settings.ConnectionString };

            // set other parameters
            //objCommonVar.CurrentUserCode = "admin";
            //objCommonVar.CurrentUserName = "admin";
            //objCommonVar.CurrentCompanyCode = "Tecxpert";

        }
    }
}
