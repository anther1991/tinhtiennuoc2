using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tinh_Tien_Nuoc
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Shown(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "History.txt"));
            for (int x =lines.Length-1; x>=0 ; x--)
            {
                if (lines[x].Length > 0)
                {
                    string[] line = lines[x].Split('|');
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgvHistory);
                    for (int i = 0; i < line.Length; i++)
                    {
                        dr.Cells[i].Value = line[i];
                    }
                    dgvHistory.Rows.Add(dr);
                }
            }
        }
    }
}
