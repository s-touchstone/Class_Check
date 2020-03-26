using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace AppFunctions
{
    public class DBFunctions
    {
        private OleDbConnection DB_Conn = new OleDbConnection();
        private Dictionary<string, string> Var_Dict = new Dictionary<string, string>();
        private readonly string[] values = new string[50];
//Initialize DBFunctions.
        public void INIT()
        {
            CreateVars();
            CreateIt();
            CheckDBConn();
        }
//Read the information on the configuration file to set variables for the database information.
        private void CreateVars()
        {
            try
            {
                string Line;
                StreamReader File = new StreamReader(@"configuration.cfg");
                while ((Line = File.ReadLine()) != "")
                {
                    string first_half = Line.Substring(0, 10);
                    string second_half = Line.Substring(11);
                    Var_Dict.Add(first_half, second_half);
                }
            }
            catch (FileNotFoundException)
            {
                string[] lines = { "DB_PthName:", "DB_Table_1:", "DB_Table_2:", "DB_Table_3:", "DB_Table_4:", "DB_Table_5:", "Dev_ID_Col:",
                    "DevMak_Col:", "DevMdl_Col:", "DevTyp_Col:", "DevLoc_Col:", "CmpNam_Col:", "IP_Add_Col:", "Date_Col_1:", "Locatn_Col:",
                    "MsKeyb_Col:", "Monitr_Col:", "Prjctr_Col:", "PBHour_Col:", "ScrnUD_Col:", "DocCam_Col:", "AudioC_Col:", "SlshPr_Col:",
                    "Camera_Col:", "Micphn_Col:", "Remote_Col:", "Notes__Col:", "Date_Col_2:", "Xtra_Col_1:", "Xtra_Col_2:", "Xtra_Col_3:",
                    "Ext_Apps_1:", "Ext_Apps_2:", "Ext_Apps_3:", "Ext_Apps_4:", "Ext_Apps_5:", "Xtra_Col_4:", "Xtra_Col_5:", "",
                    "******************Warning * *******************", "*Modifying this file directly may cause the*",
                    "* application to not function correctly. If*", "* you are not certain about the changes, use *",
                    "*the built -in settings windows to edit this *", "*information instead.                       *",
                    "*********************************************" };
                string File_Name = @"configuration.cfg";
                File.WriteAllLines(File_Name, lines);
                CreateVars();
            }
        }
//Check that database tools are installed and that you have access to  the database. If database tool is unavailiable, install it.
        private void CheckDBConn()
        {
            Var_Dict.TryGetValue("DB_PthName", out string DB);
            Var_Dict.TryGetValue("Ext_Apps_1", out string App);
            DB_Conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + DB + "; Persist Security Info=False;";
            try
            {
                DB_Conn.Open();
            }
            catch (OleDbException)
            {
                MessageBox.Show("The Database file was not found. Please make sure the file and pathname are correct.");
            }
            catch (InvalidOperationException)
            {
                ProcessStartInfo DBE_Install = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    FileName = App,
                    Verb = "runas"
                }; ;
                try
                {
                    using (Process DBE_Run = Process.Start(DBE_Install))
                    {
                        DBE_Run.WaitForExit();
                    }
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("Try running again as an Administrator!");
                }
                DB_Conn.Open();
            }
            DB_Conn.Close();
        }
//Create iterable array to make it easier to retrun values via int input from settings.
        private void CreateIt()
        {
            int i = 0;
            foreach (var item in Var_Dict.Values)
            {
                values[i] = item;
                i += 1;
            }
        }
//Return value at int location to settings. NOT WORKING CORRECTLY!!!
        public string GetValue(int num)
        {
            return values[num];
        }
//Save new settings.
        /*public void SaveConfig(int sel, string change)
        {
            
        }*/
    }
}
