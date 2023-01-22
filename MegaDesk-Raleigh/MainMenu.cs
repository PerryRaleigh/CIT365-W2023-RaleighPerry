using System;
using System.Windows.Forms;

namespace MegaDesk_Raleigh
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
			AddQuote addQuote= new AddQuote();
			addQuote.Tag= this;
			addQuote.Show(this);
			Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }
    }
}
