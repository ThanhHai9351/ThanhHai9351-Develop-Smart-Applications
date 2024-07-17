using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ThietKeControls
{
    public class DataGridViewOldEven:DataGridView
    {
        public DataGridViewOldEven()
        {
            this.RowPrePaint +=DataGridViewOldEven_RowPrePaint;
        }

        void DataGridViewOldEven_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
 	        if (e.RowIndex % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
    }

}
