namespace Završni___Vozni_red_vlakova
{
    partial class TicketSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSelling));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oneWayButton = new System.Windows.Forms.RadioButton();
            this.bothWaysButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startLocation = new System.Windows.Forms.TextBox();
            this.destinationLocation = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.returningDate = new System.Windows.Forms.DateTimePicker();
            this.passengerNum = new System.Windows.Forms.ComboBox();
            this.discountBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returningLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.viaLocation = new System.Windows.Forms.TextBox();
            this.confirmationCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ticketFormat = new System.Windows.Forms.ComboBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.placanjePanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.kioskBox = new System.Windows.Forms.ComboBox();
            this.creditCardsBox = new System.Windows.Forms.ComboBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.paymentMethodBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.placanjePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(759, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // oneWayButton
            // 
            this.oneWayButton.AutoSize = true;
            this.oneWayButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneWayButton.Location = new System.Drawing.Point(88, 428);
            this.oneWayButton.Name = "oneWayButton";
            this.oneWayButton.Size = new System.Drawing.Size(113, 23);
            this.oneWayButton.TabIndex = 3;
            this.oneWayButton.TabStop = true;
            this.oneWayButton.Text = "Jedan smjer";
            this.oneWayButton.UseVisualStyleBackColor = true;
            this.oneWayButton.CheckedChanged += new System.EventHandler(this.oneWayButton_CheckedChanged);
            // 
            // bothWaysButton
            // 
            this.bothWaysButton.AutoSize = true;
            this.bothWaysButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bothWaysButton.Location = new System.Drawing.Point(264, 428);
            this.bothWaysButton.Name = "bothWaysButton";
            this.bothWaysButton.Size = new System.Drawing.Size(94, 23);
            this.bothWaysButton.TabIndex = 4;
            this.bothWaysButton.TabStop = true;
            this.bothWaysButton.Text = "Povratna ";
            this.bothWaysButton.UseVisualStyleBackColor = true;
            this.bothWaysButton.CheckedChanged += new System.EventHandler(this.bothWaysButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(84, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Polazišni kolodvor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(260, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odredišni kolodvor :";
            // 
            // startLocation
            // 
            this.startLocation.Location = new System.Drawing.Point(87, 490);
            this.startLocation.Name = "startLocation";
            this.startLocation.Size = new System.Drawing.Size(134, 20);
            this.startLocation.TabIndex = 7;
            this.startLocation.TextChanged += new System.EventHandler(this.startLocation_TextChanged);
            // 
            // destinationLocation
            // 
            this.destinationLocation.Location = new System.Drawing.Point(264, 490);
            this.destinationLocation.Name = "destinationLocation";
            this.destinationLocation.Size = new System.Drawing.Size(140, 20);
            this.destinationLocation.TabIndex = 8;
            this.destinationLocation.TextChanged += new System.EventHandler(this.destinationLocation_TextChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(264, 544);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(97, 20);
            this.startDate.TabIndex = 9;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // returningDate
            // 
            this.returningDate.Location = new System.Drawing.Point(436, 544);
            this.returningDate.Name = "returningDate";
            this.returningDate.Size = new System.Drawing.Size(97, 20);
            this.returningDate.TabIndex = 10;
            // 
            // passengerNum
            // 
            this.passengerNum.FormattingEnabled = true;
            this.passengerNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.passengerNum.Location = new System.Drawing.Point(87, 598);
            this.passengerNum.Name = "passengerNum";
            this.passengerNum.Size = new System.Drawing.Size(121, 21);
            this.passengerNum.TabIndex = 11;
            this.passengerNum.SelectedIndexChanged += new System.EventHandler(this.passengerNum_SelectedIndexChanged);
            // 
            // discountBox
            // 
            this.discountBox.FormattingEnabled = true;
            this.discountBox.Items.AddRange(new object[] {
            "Redovna cijena",
            "Dijete (6 - 12 god)",
            "Student",
            "Umirovljenik ili starija osoba"});
            this.discountBox.Location = new System.Drawing.Point(264, 598);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(121, 21);
            this.discountBox.TabIndex = 12;
            this.discountBox.SelectedIndexChanged += new System.EventHandler(this.discountBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(260, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum polaska :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(432, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datum povratka :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(84, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Broj putnika :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(260, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Popust :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(432, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Povratni kolodvor :";
            // 
            // returningLocation
            // 
            this.returningLocation.Location = new System.Drawing.Point(436, 490);
            this.returningLocation.Name = "returningLocation";
            this.returningLocation.Size = new System.Drawing.Size(140, 20);
            this.returningLocation.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(84, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Putanje preko/kroz :";
            // 
            // viaLocation
            // 
            this.viaLocation.Location = new System.Drawing.Point(87, 544);
            this.viaLocation.Name = "viaLocation";
            this.viaLocation.Size = new System.Drawing.Size(134, 20);
            this.viaLocation.TabIndex = 20;
            // 
            // confirmationCheckBox
            // 
            this.confirmationCheckBox.AutoSize = true;
            this.confirmationCheckBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationCheckBox.Location = new System.Drawing.Point(146, 661);
            this.confirmationCheckBox.Name = "confirmationCheckBox";
            this.confirmationCheckBox.Size = new System.Drawing.Size(372, 22);
            this.confirmationCheckBox.TabIndex = 21;
            this.confirmationCheckBox.Text = "Potvrđujem da sam zadovoljan sa svojim odabirom !";
            this.confirmationCheckBox.UseVisualStyleBackColor = true;
            this.confirmationCheckBox.CheckedChanged += new System.EventHandler(this.confirmationCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 635);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(406, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ako ste zadovoljni s odabirom potvrdite :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(432, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Format karte :";
            // 
            // ticketFormat
            // 
            this.ticketFormat.FormattingEnabled = true;
            this.ticketFormat.Items.AddRange(new object[] {
            "MS Word dokument",
            "PDF dokument",
            "Slika"});
            this.ticketFormat.Location = new System.Drawing.Point(436, 598);
            this.ticketFormat.Name = "ticketFormat";
            this.ticketFormat.Size = new System.Drawing.Size(121, 21);
            this.ticketFormat.TabIndex = 24;
            this.ticketFormat.SelectedIndexChanged += new System.EventHandler(this.ticketFormat_SelectedIndexChanged);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(264, 689);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(121, 50);
            this.continueButton.TabIndex = 25;
            this.continueButton.Text = "Nastavi";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pretraga putničkih linija :";
            // 
            // placanjePanel
            // 
            this.placanjePanel.Controls.Add(this.endButton);
            this.placanjePanel.Controls.Add(this.label14);
            this.placanjePanel.Controls.Add(this.label13);
            this.placanjePanel.Controls.Add(this.kioskBox);
            this.placanjePanel.Controls.Add(this.creditCardsBox);
            this.placanjePanel.Controls.Add(this.paymentLabel);
            this.placanjePanel.Controls.Add(this.paymentMethodBox);
            this.placanjePanel.Controls.Add(this.label12);
            this.placanjePanel.Location = new System.Drawing.Point(709, 428);
            this.placanjePanel.Name = "placanjePanel";
            this.placanjePanel.Size = new System.Drawing.Size(472, 242);
            this.placanjePanel.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Kartice :";
            // 
            // kioskBox
            // 
            this.kioskBox.FormattingEnabled = true;
            this.kioskBox.Items.AddRange(new object[] {
            "Zagreb",
            "Sisak",
            "Varaždin",
            "Vinkovci",
            "Osijek",
            "Rijeka"});
            this.kioskBox.Location = new System.Drawing.Point(169, 107);
            this.kioskBox.Name = "kioskBox";
            this.kioskBox.Size = new System.Drawing.Size(121, 21);
            this.kioskBox.TabIndex = 31;
            // 
            // creditCardsBox
            // 
            this.creditCardsBox.FormattingEnabled = true;
            this.creditCardsBox.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "Diners",
            "Maestro"});
            this.creditCardsBox.Location = new System.Drawing.Point(7, 107);
            this.creditCardsBox.Name = "creditCardsBox";
            this.creditCardsBox.Size = new System.Drawing.Size(121, 21);
            this.creditCardsBox.TabIndex = 30;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(6, 50);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(7, 32);
            this.paymentLabel.TabIndex = 29;
            this.paymentLabel.Text = "\r\n\r\n";
            // 
            // paymentMethodBox
            // 
            this.paymentMethodBox.FormattingEnabled = true;
            this.paymentMethodBox.Items.AddRange(new object[] {
            "Kartica",
            "Gotovina"});
            this.paymentMethodBox.Location = new System.Drawing.Point(7, 26);
            this.paymentMethodBox.Name = "paymentMethodBox";
            this.paymentMethodBox.Size = new System.Drawing.Size(121, 21);
            this.paymentMethodBox.TabIndex = 28;
            this.paymentMethodBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "Način plaćanja :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(165, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Naplatne kućice :";
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Location = new System.Drawing.Point(93, 150);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(121, 50);
            this.endButton.TabIndex = 34;
            this.endButton.Text = "Završi";
            this.endButton.UseVisualStyleBackColor = true;
            // 
            // TicketSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 831);
            this.Controls.Add(this.placanjePanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.ticketFormat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmationCheckBox);
            this.Controls.Add(this.viaLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returningLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.passengerNum);
            this.Controls.Add(this.returningDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.destinationLocation);
            this.Controls.Add(this.startLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bothWaysButton);
            this.Controls.Add(this.oneWayButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vozni red vlakova - kupnja karata";
            this.Load += new System.EventHandler(this.TicketSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.placanjePanel.ResumeLayout(false);
            this.placanjePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton oneWayButton;
        private System.Windows.Forms.RadioButton bothWaysButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startLocation;
        private System.Windows.Forms.TextBox destinationLocation;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker returningDate;
        private System.Windows.Forms.ComboBox passengerNum;
        private System.Windows.Forms.ComboBox discountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox returningLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox viaLocation;
        private System.Windows.Forms.CheckBox confirmationCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ticketFormat;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel placanjePanel;
        private System.Windows.Forms.ComboBox paymentMethodBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox kioskBox;
        private System.Windows.Forms.ComboBox creditCardsBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button endButton;
    }
}