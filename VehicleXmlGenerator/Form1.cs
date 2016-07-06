using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VehicleXmlGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            Int32.TryParse(tb_num.Text, out num);
            int rtmin, rtmax, dpmin, dpmax;
            rtmin = Convert.ToInt32(tb_rt_min.Text);
            rtmax = Convert.ToInt32(tb_rt_max.Text);
            dpmin = Convert.ToInt32(tb_dp_min.Text);
            dpmax = Convert.ToInt32(tb_dp_max.Text);

            Random r = new Random();
            int rtnum = r.Next(rtmin, rtmax);
            int dpnum = r.Next(dpmin, dpmax);
            int id = 0;

            //<vehicle depart="1" id="veh0" route="route0" type="Car" />
            System.Text.StringBuilder sb = new StringBuilder();
           
            
            for (int i = 0;i< num; i++)
            {
                rtnum = r.Next(rtmin, rtmax);
                dpnum = r.Next(dpmin, dpmax);
                sb.Append("<vehicle depart=\"");
                sb.Append(dpnum.ToString());
                sb.Append("\" id=\"veh");
                sb.Append(id.ToString());
                id++;
                sb.Append("\" route=\"route");
                sb.Append(rtnum.ToString());
                sb.Append("\" type=\"Car\"");
                sb.Append(" />");
                sb.Append(System.Environment.NewLine);
             
            }

            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "TextFile|*.txt";
            savefiledialog.Title = "Save To File";
            if(savefiledialog.ShowDialog()== DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefiledialog.FileName))
                    sw.WriteLine(sb.ToString());
            }
            

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox_enabledgv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_enabledgv.Checked == true)
            {
                dataGridView1.Enabled = true;
            }
            else
                dataGridView1.Enabled = false;
        }
    }
}
