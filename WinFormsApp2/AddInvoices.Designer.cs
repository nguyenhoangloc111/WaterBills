namespace WinFormsApp2
{
    partial class AddInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            customerCodeInput = new TextBox();
            customerNameInput = new TextBox();
            numberOfPeopleInput = new TextBox();
            lastMonthNumberInput = new TextBox();
            thisMonthNumberInput = new TextBox();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            consumptionLabel = new Label();
            priceLabel = new Label();
            subtotalLabel = new Label();
            envFeeLable = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            calculateButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 62);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 9);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 115);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 3;
            label4.Text = "Number Of People";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 62);
            label5.Name = "label5";
            label5.Size = new Size(242, 20);
            label5.TabIndex = 4;
            label5.Text = "Last Month's Water Meter Readings";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 62);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 5;
            label6.Text = "This Month's Water Meter Readings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 9);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "Current Month";
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(30, 32);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(238, 27);
            customerCodeInput.TabIndex = 7;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(30, 85);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(240, 27);
            customerNameInput.TabIndex = 8;
            customerNameInput.TextChanged += customerNameInput_TextChanged;
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(30, 138);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(240, 27);
            numberOfPeopleInput.TabIndex = 9;
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(291, 86);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(242, 27);
            lastMonthNumberInput.TabIndex = 10;
            lastMonthNumberInput.TextChanged += textBox4_TextChanged;
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(546, 85);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(242, 27);
            thisMonthNumberInput.TabIndex = 11;
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(291, 32);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(242, 28);
            customerTypeCombobox.TabIndex = 12;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(546, 32);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(242, 28);
            currentMonthCombobox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 182);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 14;
            label8.Text = "Amount of consumption:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 215);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 15;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 246);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 16;
            label10.Text = "Subtotal:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 278);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 17;
            label11.Text = "Enviroment Fees:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 312);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 18;
            label12.Text = "VAT (10%):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.Location = new Point(30, 350);
            label13.Name = "label13";
            label13.Size = new Size(81, 38);
            label13.TabIndex = 19;
            label13.Text = "Total";
            // 
            // consumptionLabel
            // 
            consumptionLabel.Anchor = AnchorStyles.Right;
            consumptionLabel.AutoSize = true;
            consumptionLabel.Location = new Point(253, 185);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(17, 20);
            consumptionLabel.TabIndex = 20;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Right;
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(253, 218);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(17, 20);
            priceLabel.TabIndex = 21;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Anchor = AnchorStyles.Right;
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new Point(253, 249);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(17, 20);
            subtotalLabel.TabIndex = 22;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLable
            // 
            envFeeLable.Anchor = AnchorStyles.Right;
            envFeeLable.AutoSize = true;
            envFeeLable.Location = new Point(253, 281);
            envFeeLable.Name = "envFeeLable";
            envFeeLable.Size = new Size(17, 20);
            envFeeLable.TabIndex = 23;
            envFeeLable.Text = "0";
            envFeeLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.Right;
            VATLabel.AutoSize = true;
            VATLabel.Location = new Point(253, 315);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(17, 20);
            VATLabel.TabIndex = 24;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            totalLabel.Location = new Point(244, 352);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(33, 38);
            totalLabel.TabIndex = 25;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.ControlDark;
            calculateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            calculateButton.ForeColor = SystemColors.InactiveCaptionText;
            calculateButton.Location = new Point(394, 161);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(242, 105);
            calculateButton.TabIndex = 26;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.HotTrack;
            saveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            saveButton.Location = new Point(394, 284);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(242, 106);
            saveButton.TabIndex = 27;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button2_Click;
            // 
            // AddInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveButton);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(VATLabel);
            Controls.Add(envFeeLable);
            Controls.Add(subtotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(customerNameInput);
            Controls.Add(customerCodeInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoices";
            Size = new Size(811, 479);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox customerCodeInput;
        private TextBox customerNameInput;
        private TextBox numberOfPeopleInput;
        private TextBox lastMonthNumberInput;
        private TextBox thisMonthNumberInput;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label subtotalLabel;
        private Label envFeeLable;
        private Label VATLabel;
        private Label totalLabel;
        private Button calculateButton;
        private Button saveButton;
    }
}
