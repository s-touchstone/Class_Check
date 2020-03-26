using System;
using System.Windows.Forms;
using AppFunctions;

namespace Class_Check
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            DBFunctions Fill = new DBFunctions();
            Fill.INIT();
            /*List of boxes to fill*/
            string[] TextBox = { DB_PFN_txtbx.Text, TAB_1_txtbx.Text, TAB_2_txtbx.Text, TAB_3_txtbx.Text, TAB_4_txtbx.Text, TAB_5_txtbx.Text,
                DEV_ID_COL_txtbx.Text, DEV_MAKE_COL_txtbx.Text, DEV_MOD_COL_txtbx.Text, DEV_TYPE_COL_txtbx.Text, DEV_LOC_COL_txtbx.Text,
                COMP_NAM_COL_txtbx.Text, IP_ADD_COL_txtbx.Text, LAS_DAT_MOD_IN_txtbx.Text, LOC_CLS_CHK_txtbx.Text, MS_KBD_txtbx.Text,
                MON_txtbx.Text, PROJ_txtbx.Text, PROJ_BLB_HR_txtbx.Text, PROJ_SCRN_UD_txtbx.Text, DOC_CAM_txtbx.Text, AUD_txtbx.Text,
                SS_PRES_txtbx.Text, CAM_txtbx.Text, MIC_txtbx.Text, REM_txtbx.Text, NOTE_txtbx.Text, LAS_DAT_MOD_CL_txtbx.Text, XTRA_COL_1_txtbx.Text,
                XTRA_COL_2_txtbx.Text, XTRA_COL_3_txtbx.Text, XTRA_COL_4_txtbx.Text, XTRA_COL_5_txtbx.Text, DBE_EXE_txtbx.Text, FRM_WRK_INST_txtbx.Text,
                WEB_CAM_EXE_txtbx.Text, MIC_EXE_txtbx.Text, EXTRA_EXE_txtbx.Text, APP_THEM_cmbbx.Text};
            
            string[] TextFill = new string[50];
            for (int count = 0; count <= TextFill.Length; count++)
            {
                //MessageBox.Show(TextBox[count]);
                TextBox[count] = Fill.GetValue(count);
                //MessageBox.Show(TextBox[count]);
            }
            /*DB_PFN_txtbx.Text = Fill.GetValue(0);
            TAB_1_txtbx.Text = Fill.GetValue(1);
            TAB_2_txtbx.Text = Fill.GetValue(2);
            TAB_3_txtbx.Text = Fill.GetValue(3);
            TAB_4_txtbx.Text = Fill.GetValue(4);
            TAB_5_txtbx.Text = Fill.GetValue(5);
            DEV_ID_COL_txtbx.Text = Fill.GetValue(6);
            DEV_MAKE_COL_txtbx.Text = Fill.GetValue(7);
            DEV_MOD_COL_txtbx.Text = Fill.GetValue(8);
            DEV_TYPE_COL_txtbx.Text = Fill.GetValue(9);
            DEV_LOC_COL_txtbx.Text = Fill.GetValue(10);
            COMP_NAM_COL_txtbx.Text = Fill.GetValue(11);
            IP_ADD_COL_txtbx.Text = Fill.GetValue(12);
            LAS_DAT_MOD_IN_txtbx.Text = Fill.GetValue(13);
            LOC_CLS_CHK_txtbx.Text = Fill.GetValue(14);
            MS_KBD_txtbx.Text = Fill.GetValue(15);
            MON_txtbx.Text = Fill.GetValue(16);
            PROJ_txtbx.Text = Fill.GetValue(17);
            PROJ_BLB_HR_txtbx.Text = Fill.GetValue(18);
            PROJ_SCRN_UD_txtbx.Text = Fill.GetValue(19);
            DOC_CAM_txtbx.Text = Fill.GetValue(20);
            AUD_txtbx.Text = Fill.GetValue(21);
            SS_PRES_txtbx.Text = Fill.GetValue(22);
            CAM_txtbx.Text = Fill.GetValue(23);
            MIC_txtbx.Text = Fill.GetValue(24);
            REM_txtbx.Text = Fill.GetValue(25);
            NOTE_txtbx.Text = Fill.GetValue(26);
            LAS_DAT_MOD_CL_txtbx.Text = Fill.GetValue(27);
            XTRA_COL_1_txtbx.Text = Fill.GetValue(28);
            XTRA_COL_2_txtbx.Text = Fill.GetValue(29);
            XTRA_COL_3_txtbx.Text = Fill.GetValue(30);
            XTRA_COL_4_txtbx.Text = Fill.GetValue(31);
            XTRA_COL_5_txtbx.Text = Fill.GetValue(32);
            DBE_EXE_txtbx.Text = Fill.GetValue(33);
            FRM_WRK_INST_txtbx.Text = Fill.GetValue(34);
            WEB_CAM_EXE_txtbx.Text = Fill.GetValue(35);
            MIC_EXE_txtbx.Text = Fill.GetValue(36);
            EXTRA_EXE_txtbx.Text = Fill.GetValue(37);
            APP_THEM_cmbbx.Text = Fill.GetValue(38);*/
        }

        private void Hom_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main MN = new Main();
            MN.ShowDialog();
            this.Close();
        } 
    }
}
