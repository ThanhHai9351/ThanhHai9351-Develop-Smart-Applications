using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215742_HoThanhHai_Buoi1.services
{
    class handleEventButtonB1
    {
        bool x;
       public void addButton(int x,int y, Control parent)
        {
            int topPosition = 10;
            int leftPosition = 10;
            for (int i = 1; i < y; i++)
            {
                for (int j = 0; j <= x; j++)
                {
                    Button b = new Button();
                    b.Width = 30;
                    b.Height = 30;
                    b.Left = leftPosition;
                    b.Top = topPosition;
                    b.Click += b_Click;
                    parent.Controls.Add(b);
                    leftPosition += 30;
                }
                leftPosition = 10;
                topPosition += 30;
            }
        }

       void b_Click(object sender, EventArgs e)
       {
           Button item = (Button)sender;
           if (item.Text == "")
           {
               if (x)
               {
                   item.Text = "X";
                   x = false;
               }
               else
               {
                   item.Text = "0";
                   x = true;
               }
           }
       }

      
    }
   
}
