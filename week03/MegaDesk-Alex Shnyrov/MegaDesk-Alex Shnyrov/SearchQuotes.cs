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

        private List<DeskQuote> _quotes;

        Desk desk = new Desk();
        DataTable table = new DataTable();
        List<DeskQuote> _displayQuotes;

        public SearchQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();
            _quotes = quotes;
            _displayQuotes = _quotes;
            populateGrid();
            loadMaterialTypes();
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

            //foreach (var quote in _displayQuotes)
            //{
            //    grdQuotes.Rows.Add(quote.Name, quote.GetPrice(), quote.Desk.Material, quote.Desk.Width, quote.Desk.Depth, quote.Desk.GetSize(), quote.Desk.Drawers, quote.Rush, quote.Date.ToString("dd MMM yyyy"));
            //}
            populateRows();

        }

        private void loadMaterialTypes()
        {
            var types = Desk.GetMaterialTypes();
            foreach (var type in types)
            {
                materialType.Items.Add(type);
            }
        }

        private void materialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = materialType.SelectedItem.ToString().ToUpper();
            //var enumStatusList = StatusList.Select(x => Enum.Parse(typeof(ItemStatus), x)).Cast().ToList();

            _displayQuotes = _quotes.Where(quote => quote.Desk.Material.ToString().Equals(selectedType)).ToList();
            if (_displayQuotes.Count == 0)
                _displayQuotes = _quotes;

            grdQuotes.Rows.Clear();
            populateRows();


            //if (materialType.SelectedIndex < 1)
            //{
            //    grdQuotes.Rows.Clear();
            //    populateGrid();
            //    return;
            //} else
            //    Console.WriteLine("the material type is " + materialType);
            //{

               
            //}
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            materialType.SelectedIndex = 0;
        }

        private void populateRows()
        {
            //foreach (var quote in _quotes)
            //{
            //    grdQuotes.Rows.Clear();
            //    grdQuotes.Rows.Add(quote.Name,
            //                       quote.GetPrice(),
            //                       quote.Desk.Material,
            //                       quote.Desk.Width,
            //                       quote.Desk.Depth,
            //                       quote.Desk.GetSize(),
            //                       quote.Desk.Drawers,
            //                       quote.Rush,
            //                       quote.Date.ToString("dd MMM yyyy"));
            //}



            foreach (var quote in _displayQuotes)
            {
                grdQuotes.Rows.Add(quote.Name, quote.GetPrice(), quote.Desk.Material, quote.Desk.Width, quote.Desk.Depth, quote.Desk.GetSize(), quote.Desk.Drawers, quote.Rush, quote.Date);
            }
        }
    }
}
