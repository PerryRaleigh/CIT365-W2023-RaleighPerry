namespace MegaDesk_Raleigh
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerNameFirstLabel;
            System.Windows.Forms.Label customerNameLastLabel;
            System.Windows.Forms.Label quoteDateLabel;
            System.Windows.Forms.Label daysToCompleteLabel;
            this.CloseButton = new System.Windows.Forms.Button();
            this.DisplayQuoteButton = new System.Windows.Forms.Button();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.drawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.customerNameFirstTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLastTextBox = new System.Windows.Forms.TextBox();
            this.daysToCompleteComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quoteDateTextBox = new System.Windows.Forms.TextBox();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            customerNameFirstLabel = new System.Windows.Forms.Label();
            customerNameLastLabel = new System.Windows.Forms.Label();
            quoteDateLabel = new System.Windows.Forms.Label();
            daysToCompleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameFirstLabel
            // 
            customerNameFirstLabel.AutoSize = true;
            customerNameFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameFirstLabel.Location = new System.Drawing.Point(13, 65);
            customerNameFirstLabel.Name = "customerNameFirstLabel";
            customerNameFirstLabel.Size = new System.Drawing.Size(163, 20);
            customerNameFirstLabel.TabIndex = 22;
            customerNameFirstLabel.Text = "Customer Name First:";
            // 
            // customerNameLastLabel
            // 
            customerNameLastLabel.AutoSize = true;
            customerNameLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLastLabel.Location = new System.Drawing.Point(13, 91);
            customerNameLastLabel.Name = "customerNameLastLabel";
            customerNameLastLabel.Size = new System.Drawing.Size(163, 20);
            customerNameLastLabel.TabIndex = 24;
            customerNameLastLabel.Text = "Customer Name Last:";
            // 
            // quoteDateLabel
            // 
            quoteDateLabel.AutoSize = true;
            quoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quoteDateLabel.Location = new System.Drawing.Point(80, 253);
            quoteDateLabel.Name = "quoteDateLabel";
            quoteDateLabel.Size = new System.Drawing.Size(96, 20);
            quoteDateLabel.TabIndex = 28;
            quoteDateLabel.Text = "Quote Date:";
            // 
            // daysToCompleteLabel
            // 
            daysToCompleteLabel.AutoSize = true;
            daysToCompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daysToCompleteLabel.Location = new System.Drawing.Point(33, 227);
            daysToCompleteLabel.Name = "daysToCompleteLabel";
            daysToCompleteLabel.Size = new System.Drawing.Size(143, 20);
            daysToCompleteLabel.TabIndex = 29;
            daysToCompleteLabel.Text = "Days To Complete:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(206, 297);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(97, 32);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DisplayQuoteButton
            // 
            this.DisplayQuoteButton.Location = new System.Drawing.Point(102, 297);
            this.DisplayQuoteButton.Name = "DisplayQuoteButton";
            this.DisplayQuoteButton.Size = new System.Drawing.Size(97, 32);
            this.DisplayQuoteButton.TabIndex = 7;
            this.DisplayQuoteButton.Text = "&Display Quote";
            this.DisplayQuoteButton.UseVisualStyleBackColor = true;
            this.DisplayQuoteButton.Click += new System.EventHandler(this.DisplayQuoteButton_Click);
            // 
            // depthTextBox
            // 
            this.depthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskBindingSource, "depth", true));
            this.depthTextBox.Location = new System.Drawing.Point(181, 143);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(121, 20);
            this.depthTextBox.TabIndex = 3;
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            // 
            // drawersNumericUpDown
            // 
            this.drawersNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deskBindingSource, "drawers", true));
            this.drawersNumericUpDown.Location = new System.Drawing.Point(181, 169);
            this.drawersNumericUpDown.Name = "drawersNumericUpDown";
            this.drawersNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.drawersNumericUpDown.TabIndex = 4;
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskBindingSource, "surfaceMaterial", true));
            this.surfaceMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.ItemHeight = 13;
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(181, 195);
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterialComboBox.TabIndex = 5;
            // 
            // widthTextBox
            // 
            this.widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskBindingSource, "width", true));
            this.widthTextBox.Location = new System.Drawing.Point(181, 117);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(121, 20);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(96, 115);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(79, 23);
            this.widthLabel.TabIndex = 19;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depthLabel
            // 
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(100, 143);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(75, 23);
            this.depthLabel.TabIndex = 20;
            this.depthLabel.Text = "Depth:";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawersLabel
            // 
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(17, 169);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(159, 23);
            this.drawersLabel.TabIndex = 21;
            this.drawersLabel.Text = "Number of Drawers:";
            this.drawersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(36, 195);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(139, 23);
            this.surfaceMaterialLabel.TabIndex = 22;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            this.surfaceMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameFirstTextBox
            // 
            this.customerNameFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskQuoteBindingSource, "CustomerNameFirst", true));
            this.customerNameFirstTextBox.Location = new System.Drawing.Point(181, 65);
            this.customerNameFirstTextBox.Name = "customerNameFirstTextBox";
            this.customerNameFirstTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameFirstTextBox.TabIndex = 0;
            // 
            // customerNameLastTextBox
            // 
            this.customerNameLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskQuoteBindingSource, "CustomerNameLast", true));
            this.customerNameLastTextBox.Location = new System.Drawing.Point(181, 91);
            this.customerNameLastTextBox.Name = "customerNameLastTextBox";
            this.customerNameLastTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameLastTextBox.TabIndex = 1;
            // 
            // daysToCompleteComboBox
            // 
            this.daysToCompleteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskQuoteBindingSource, "DaysToComplete", true));
            this.daysToCompleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daysToCompleteComboBox.FormattingEnabled = true;
            this.daysToCompleteComboBox.ItemHeight = 13;
            this.daysToCompleteComboBox.Location = new System.Drawing.Point(182, 226);
            this.daysToCompleteComboBox.Name = "daysToCompleteComboBox";
            this.daysToCompleteComboBox.Size = new System.Drawing.Size(121, 21);
            this.daysToCompleteComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Desk Quote Entry";
            // 
            // quoteDateTextBox
            // 
            this.quoteDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deskQuoteBindingSource, "QuoteDate", true));
            this.quoteDateTextBox.Location = new System.Drawing.Point(182, 253);
            this.quoteDateTextBox.Name = "quoteDateTextBox";
            this.quoteDateTextBox.ReadOnly = true;
            this.quoteDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.quoteDateTextBox.TabIndex = 6;
            this.quoteDateTextBox.TabStop = false;
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Raleigh.DeskQuote);
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_Raleigh.Desk);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 358);
            this.Controls.Add(this.quoteDateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(daysToCompleteLabel);
            this.Controls.Add(this.daysToCompleteComboBox);
            this.Controls.Add(customerNameFirstLabel);
            this.Controls.Add(this.customerNameFirstTextBox);
            this.Controls.Add(customerNameLastLabel);
            this.Controls.Add(this.customerNameLastTextBox);
            this.Controls.Add(quoteDateLabel);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.drawersNumericUpDown);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.DisplayQuoteButton);
            this.Controls.Add(this.CloseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk - Add Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.Leave += new System.EventHandler(this.CloseButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DisplayQuoteButton;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.NumericUpDown drawersNumericUpDown;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.TextBox customerNameFirstTextBox;
        private System.Windows.Forms.TextBox customerNameLastTextBox;
        private System.Windows.Forms.ComboBox daysToCompleteComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quoteDateTextBox;
    }
}