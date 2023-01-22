using System;
using System.Windows.Forms;

namespace MegaDesk_Raleigh
{
    public partial class DisplayQuote : Form
    {
        public DeskQuote deskQuote { set; get; }

        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddQuote addQuote = (AddQuote)Tag;
            addQuote.Show();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            customerFirstNameTextBox.Text = deskQuote.CustomerNameFirst;
            customerLastNameTextBox.Text = deskQuote.CustomerNameLast;
            widthTextBox.Text = deskQuote.DeskOrderd.width.ToString();
            depthTextBox.Text = deskQuote.DeskOrderd.depth.ToString();
            drawersTextBox.Text = deskQuote.DeskOrderd.drawers.ToString();
            surfaceTextBox.Text = deskQuote.DeskOrderd.surfaceMaterial.ToString();
            daysToCompleteTextBox.Text = deskQuote.DaysToComplete.ToString();
            quoteDateTextBox.Text = deskQuote.QuoteDate.ToString();
            priceTextBox.Text = deskQuote.GetPrice().ToString();
        }
    }
}
