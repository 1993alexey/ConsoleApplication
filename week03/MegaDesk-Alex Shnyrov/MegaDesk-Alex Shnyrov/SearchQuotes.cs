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

namespace MegaDesk_Alex_Shnyrov
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Material", typeof(string));
            table.Columns.Add("Width", typeof(int));
            table.Columns.Add("Depth", typeof(int));
            table.Columns.Add("Drawers", typeof(int));
            table.Columns.Add("Rush Order", typeof(int));
            table.Columns.Add("Quote", typeof(int));

            dataGridView1.DataSource = table;


        }



    }
}
