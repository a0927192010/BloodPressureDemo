using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5血壓
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn檢測_Click(object sender, EventArgs e)
        {
            int SBP = 0, DBP = 0; //宣告血壓變數
            string strMsg = "";

            if ((tb收縮.Text.Length > 0 ) && (tb舒張.Text.Length > 0 ))
            {
                try
                {
                    SBP = Convert.ToInt32(tb收縮.Text);
                    DBP = Convert.ToInt32(tb舒張.Text);
                }
                catch(Exception error)
                {
                    MessageBox.Show("請輸入正確血壓值");
                    return;
                }
                if (SBP >= 180 || DBP >= 110)
                {
                    strMsg = "Ⅲ度高血圧の可能性がある";
                }
                else if (SBP >= 160 || DBP >= 100 )
                {
                    strMsg = "Ⅱ度高血圧の可能性がある";
                }
                else if (SBP >= 140 || DBP >= 90 )
                {
                    strMsg = "Ⅰ度高血圧の可能性がある";
                }
                else if (SBP >= 130 || DBP >= 85)
                {
                    strMsg = "正常血圧、ちょっと高い";
                }
                else if (SBP >= 120 || DBP >= 80)
                {
                    strMsg = "正常血圧";
                }
                else if (SBP >= 100 || DBP >= 70)
                {
                    strMsg = "理想血壓";
                }
                strMsg = $"您的檢查結果如下 \n收縮壓:{tb收縮.Text}\n 和舒張壓:{tb舒張.Text}" + strMsg;
                tb結果.Text = $"{strMsg}";
            }
            else
            {
                tb結果.Text = "請輸入正確血壓!!";
                tb收縮.Text = "";
                tb舒張.Text = "";
                tb收縮.Focus();
            }
         
        
            {
            }
        }
        
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
