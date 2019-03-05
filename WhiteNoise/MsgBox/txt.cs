using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteNoise.MsgBox
{
    class txt
    {
        public bool TextCheck(System.Windows.Forms.TextBox txtBox)
        {
            if (txtBox.Text != "") return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("텍스트를 입력을 확인하세요!", "알람",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
                
            }
        }
    }
}
