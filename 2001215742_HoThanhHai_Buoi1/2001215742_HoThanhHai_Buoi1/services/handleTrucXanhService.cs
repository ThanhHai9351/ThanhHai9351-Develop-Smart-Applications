using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _2001215742_HoThanhHai_Buoi1.services
{
    class handleTrucXanhService
    {
        Random r = new Random();

        public void addButton(int n,Control parent, Control processbar)
        {
            ProgressBar pro = (ProgressBar)processbar;
            pro.Maximum = n * 2;
            pro.Minimum = 0;
            pro.Value = 0;
            int top = 20;
            int count = n * 2;
            int left = 30;
            for(int i = 1;i <= count;i++)
            {
                Button btn = new Button();
                btn.Size = new Size(30, 30);
                btn.Left = left;
                btn.Top = top;
                left += 30;
                btn.Text = r.Next(1, n).ToString();
                pro.Value += 1;
                parent.Controls.Add(btn);
                if(i%5==0)
                {
                    left = 30;
                    top += 30;
                }
            }
        }
    }
}
