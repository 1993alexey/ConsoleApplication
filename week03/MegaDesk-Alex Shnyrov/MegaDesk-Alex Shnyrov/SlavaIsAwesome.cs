using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Alex_Shnyrov
{
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        List<DeskQuote> quotes;
        private const string QUOTES_PATH = "quotes.txt";

        public MainMenu()
        {
            InitializeComponent();
            DeskQuote.LoadRushPrices();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newQuoteBtn_Click(object sender, EventArgs e)
        {
            var quoteForm = new AddQuote();

            if (quoteForm.ShowDialog() == DialogResult.OK)
            {
                quotes.Add(quoteForm.quote);
            }

        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ViewAllQuotes(quotes).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SearchQuotes(quotes).ShowDialog();
        }

        private void save()
        {
            string json = JsonConvert.SerializeObject(quotes);
            System.IO.File.WriteAllText(QUOTES_PATH, json);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {


            if (File.Exists(QUOTES_PATH))
            {
                string quotesStr = File.ReadAllText(QUOTES_PATH);
                quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesStr);
            }
            else
            {
                quotes = new List<DeskQuote>();
            }
        }
    }

}
