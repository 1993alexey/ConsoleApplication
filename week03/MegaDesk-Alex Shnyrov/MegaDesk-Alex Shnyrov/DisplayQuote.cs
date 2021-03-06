﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alex_Shnyrov
{
    public partial class DisplayQuote : Form
    {
        private List<DeskQuote> _quotes;
        public DisplayQuote(List<DeskQuote> quotes)
        {
            InitializeComponent();
            _quotes = quotes;
        }

        private void populateGrid()
        {
            grdQuotes.Columns.Add(new DataGridViewColumn());
            grdQuotes.Columns.Add(new DataGridViewColumn());
            grdQuotes.Columns.Add(new DataGridViewColumn());
        }
    }
}
