using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_Alex_Shnyrov
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> _quotes;
        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();
            _quotes = quotes;
            populateGrid();
        }

        private void populateGrid()
        {
            grdQuotes.Columns.Add("name", "Name");
            grdQuotes.Columns.Add("price", "Price");
            grdQuotes.Columns.Add("type", "Wood Type");
            grdQuotes.Columns.Add("width", "Width");
            grdQuotes.Columns.Add("depth", "Depth");
            grdQuotes.Columns.Add("size", "Size");
            grdQuotes.Columns.Add("drawers", "Drawers");
            grdQuotes.Columns.Add("rush", "Rush");
            grdQuotes.Columns.Add("date", "Date");

            foreach(var quote in _quotes)
            {
                grdQuotes.Rows.Add(quote.Name, quote.GetPrice(), quote.Desk.Material, quote.Desk.Width, quote.Desk.Depth, quote.Desk.GetSize(), quote.Desk.Drawers, quote.Rush, quote.Date);
            }

        }
    }
}

