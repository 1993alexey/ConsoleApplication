using System;
using System.Windows.Forms;

namespace MegaDesk_Alex_Shnyrov
{
    public partial class AddQuote : Form
    {
        Desk desk = new Desk();
        public DeskQuote quote { get; } = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            rushOrder.SelectedIndex = 0;
            materialType.SelectedIndex = 0;
            loadMaterialTypes();
            desk.Width = (double)width.Value;
            desk.Depth = (double)depth.Value;
            desk.Drawers = (int)drawers.Value;

            quote.Desk = desk;
            quote.Rush = Int32.Parse(rushOrder.SelectedItem.ToString());
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
            if (materialType.SelectedIndex < 1)
            {
                recalculatePrice();
                validate();
                return;
            }

            var selected = materialType.SelectedItem.ToString();
            var material = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), selected.ToUpper());
            desk.Material = material;
            recalculatePrice();
            validate();
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            desk.Width = (double)width.Value;
            recalculatePrice();
        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {
            desk.Depth = (double)depth.Value;
            recalculatePrice();
        }

        private void drawers_ValueChanged(object sender, EventArgs e)
        {
            desk.Drawers = (int)drawers.Value;
            recalculatePrice();
        }

        private void recalculatePrice()
        {
            if (materialType.SelectedIndex < 1)
            {
                displayPrice(0);
                return;
            }

            var price = quote.GetPrice();
            displayPrice(price);
        }

        private void displayPrice(double price)
        {
            this.price.Text = "$" + string.Format("{0:n}", Convert.ToDecimal(price.ToString())); ;

        }

        private void rushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            quote.Rush = Int32.Parse(rushOrder.SelectedItem.ToString());
            recalculatePrice();
        }

        private void validate()
        {
            if (name.Text.Trim() != "" && materialType.SelectedIndex > 0)
                newQuoteBtn.Enabled = true;
            else
                newQuoteBtn.Enabled = false;
        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            quote.Name = ((TextBox)sender).Text;
            validate();
        }

        private void newQuoteBtn_Click(object sender, EventArgs e)
        {
            quote.SetTimestamp();
        }
    }
}
