using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace MegaDesk_Raleigh
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            deskBindingSource.DataSource = new Desk();
            deskQuoteBindingSource.DataSource = new DeskQuote();

            List<SurfaceMaterial> surfaceMaterials = new List<SurfaceMaterial>();
            surfaceMaterials.Add(new SurfaceMaterial() { Name = "Laminate", Cost = 100 });
            surfaceMaterials.Add(new SurfaceMaterial() { Name = "Oak", Cost = 200 });
            surfaceMaterials.Add(new SurfaceMaterial() { Name = "Pine", Cost = 50 });
            surfaceMaterials.Add(new SurfaceMaterial() { Name = "Rosewood", Cost = 300 });
            surfaceMaterials.Add(new SurfaceMaterial() { Name = "Veneer", Cost = 125 });

            surfaceMaterialComboBox.DataSource= surfaceMaterials;
            surfaceMaterialComboBox.ValueMember = "Cost";
            surfaceMaterialComboBox.DisplayMember = "Name";

            List<int> rushOrderDays = new List<int>();
            rushOrderDays.Add(3);
            rushOrderDays.Add(5);
            rushOrderDays.Add(7);
            rushOrderDays.Add(14);

            daysToCompleteComboBox.DataSource = rushOrderDays;
            daysToCompleteComboBox.SelectedIndex = 3;
        }

        private void DisplayQuoteButton_Click(object sender, EventArgs e)
        {
            deskBindingSource.EndEdit();
            Desk desk = deskBindingSource.Current as Desk;
            deskQuoteBindingSource.EndEdit();
            DeskQuote deskQuote = deskQuoteBindingSource.Current as DeskQuote;
            deskQuote.DeskOrderd = desk;

            if (desk != null)
            {
                ValidationContext deskValidationContext = new ValidationContext(desk, null, null);
                IList<ValidationResult> deskValidationResults = new List<ValidationResult>();

                if (!Validator.TryValidateObject(desk, deskValidationContext, deskValidationResults, true))
                {
                    foreach (ValidationResult validationResult in deskValidationResults)
                    {
                        MessageBox.Show(
                            validationResult.ErrorMessage,
                            "Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                    }
                    return;
                }
                else
                {
                    if (deskQuote != null)
                    {
                        ValidationContext deskQuoteVaidationContext = new ValidationContext(deskQuote, null, null);
                        IList<ValidationResult> deskQuoteValidationResults = new List<ValidationResult>();

                        if (!Validator.TryValidateObject(deskQuote, deskQuoteVaidationContext, deskQuoteValidationResults, true))
                        {
                            foreach (ValidationResult validationResult in deskQuoteValidationResults)
                            {
                                MessageBox.Show(
                                    validationResult.ErrorMessage,
                                    "Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning 
                                    ); 
                            }
                            return;
                        }
                    }
                }
                
                DisplayQuote displayQuote = new DisplayQuote();
                displayQuote.deskQuote = deskQuote;
                displayQuote.Tag = this;
                displayQuote.Show(this);
                Hide();
            }
        }

        private void widthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int numberValue = 0;

            try
            {
                bool isNumbers = int.TryParse(widthTextBox.Text, out numberValue);

                if (!(isNumbers) || (numberValue < 24) || (numberValue > 96))
                {
                    MessageBox.Show("Only numbers between 24 and 96 are allowed, please correct the value of Width.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Delete))
                e.Handled = true;
        }
    }
}
