﻿
namespace ISLab
{
	partial class FindHouseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComunicationCheckBox = new System.Windows.Forms.CheckBox();
            this.ComfortCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountOfFloorsComboBox = new System.Windows.Forms.ComboBox();
            this.InfastuctureLabel = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.YearsLabel = new System.Windows.Forms.Label();
            this.TypeOfHouseComboBox = new System.Windows.Forms.ComboBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.TransportComboBox = new System.Windows.Forms.ComboBox();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComunicationCheckBox);
            this.panel1.Controls.Add(this.ComfortCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PositionComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CountOfFloorsComboBox);
            this.panel1.Controls.Add(this.InfastuctureLabel);
            this.panel1.Controls.Add(this.SizeComboBox);
            this.panel1.Controls.Add(this.YearsLabel);
            this.panel1.Controls.Add(this.TypeOfHouseComboBox);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.TransportComboBox);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 266);
            this.panel1.TabIndex = 7;
            // 
            // ComunicationCheckBox
            // 
            this.ComunicationCheckBox.AutoSize = true;
            this.ComunicationCheckBox.Location = new System.Drawing.Point(60, 228);
            this.ComunicationCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComunicationCheckBox.Name = "ComunicationCheckBox";
            this.ComunicationCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ComunicationCheckBox.TabIndex = 19;
            this.ComunicationCheckBox.Text = "Комуникация";
            this.ComunicationCheckBox.UseVisualStyleBackColor = true;
            this.ComunicationCheckBox.CheckedChanged += new System.EventHandler(this.ComunicationCheckBox_CheckedChanged);
            // 
            // ComfortCheckBox
            // 
            this.ComfortCheckBox.AutoSize = true;
            this.ComfortCheckBox.Location = new System.Drawing.Point(219, 228);
            this.ComfortCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComfortCheckBox.Name = "ComfortCheckBox";
            this.ComfortCheckBox.Size = new System.Drawing.Size(112, 17);
            this.ComfortCheckBox.TabIndex = 18;
            this.ComfortCheckBox.Text = "Наличие удобств";
            this.ComfortCheckBox.UseVisualStyleBackColor = true;
            this.ComfortCheckBox.CheckedChanged += new System.EventHandler(this.ComfortCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(219, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Расположение";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "В городе",
            "За городом"});
            this.PositionComboBox.Location = new System.Drawing.Point(219, 102);
            this.PositionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(168, 21);
            this.PositionComboBox.TabIndex = 15;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(219, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество этажей";
            // 
            // CountOfFloorsComboBox
            // 
            this.CountOfFloorsComboBox.FormattingEnabled = true;
            this.CountOfFloorsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            ">4"});
            this.CountOfFloorsComboBox.Location = new System.Drawing.Point(219, 44);
            this.CountOfFloorsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountOfFloorsComboBox.Name = "CountOfFloorsComboBox";
            this.CountOfFloorsComboBox.Size = new System.Drawing.Size(165, 21);
            this.CountOfFloorsComboBox.TabIndex = 13;
            this.CountOfFloorsComboBox.SelectedIndexChanged += new System.EventHandler(this.CountOfFloorsComboBox_SelectedIndexChanged);
            // 
            // InfastuctureLabel
            // 
            this.InfastuctureLabel.AutoSize = true;
            this.InfastuctureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfastuctureLabel.Location = new System.Drawing.Point(23, 27);
            this.InfastuctureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfastuctureLabel.Name = "InfastuctureLabel";
            this.InfastuctureLabel.Size = new System.Drawing.Size(85, 15);
            this.InfastuctureLabel.TabIndex = 7;
            this.InfastuctureLabel.Text = "Размеры дома";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Items.AddRange(new object[] {
            "< 80",
            "80 - 150",
            ">150"});
            this.SizeComboBox.Location = new System.Drawing.Point(23, 44);
            this.SizeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(165, 21);
            this.SizeComboBox.TabIndex = 6;
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YearsLabel.Location = new System.Drawing.Point(26, 141);
            this.YearsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(57, 15);
            this.YearsLabel.TabIndex = 5;
            this.YearsLabel.Text = "Тип дома";
            // 
            // TypeOfHouseComboBox
            // 
            this.TypeOfHouseComboBox.FormattingEnabled = true;
            this.TypeOfHouseComboBox.Items.AddRange(new object[] {
            "Деревянный",
            "Кирпичный",
            "Бревенчатый"});
            this.TypeOfHouseComboBox.Location = new System.Drawing.Point(26, 158);
            this.TypeOfHouseComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeOfHouseComboBox.Name = "TypeOfHouseComboBox";
            this.TypeOfHouseComboBox.Size = new System.Drawing.Size(165, 21);
            this.TypeOfHouseComboBox.TabIndex = 4;
            this.TypeOfHouseComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfHouseComboBox_SelectedIndexChanged);
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SquareLabel.Location = new System.Drawing.Point(219, 142);
            this.SquareLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(147, 15);
            this.SquareLabel.TabIndex = 3;
            this.SquareLabel.Text = "Транспортная доступность";
            // 
            // TransportComboBox
            // 
            this.TransportComboBox.FormattingEnabled = true;
            this.TransportComboBox.Items.AddRange(new object[] {
            "Развитая",
            "Неразвитая"});
            this.TransportComboBox.Location = new System.Drawing.Point(219, 158);
            this.TransportComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransportComboBox.Name = "TransportComboBox";
            this.TransportComboBox.Size = new System.Drawing.Size(168, 21);
            this.TransportComboBox.TabIndex = 2;
            this.TransportComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportComboBox_SelectedIndexChanged);
            // 
            // ChoosePriceLabel
            // 
            this.ChoosePriceLabel.AutoSize = true;
            this.ChoosePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChoosePriceLabel.Location = new System.Drawing.Point(26, 85);
            this.ChoosePriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChoosePriceLabel.Name = "ChoosePriceLabel";
            this.ChoosePriceLabel.Size = new System.Drawing.Size(49, 15);
            this.ChoosePriceLabel.TabIndex = 1;
            this.ChoosePriceLabel.Text = "Бюджет";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "< 1000000",
            "1000000 - 3000000",
            "3000000 - 6000000",
            "> 6000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(26, 102);
            this.PriceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(170, 21);
            this.PriceComboBox.TabIndex = 0;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(373, 320);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 35);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBackButton.Location = new System.Drawing.Point(11, 23);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(65, 23);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(42, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дополнительно";
            // 
            // FindHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FindHouseForm";
            this.Text = "Подбор дома";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CountOfFloorsComboBox;
		private System.Windows.Forms.Label InfastuctureLabel;
		private System.Windows.Forms.ComboBox SizeComboBox;
		private System.Windows.Forms.Label YearsLabel;
		private System.Windows.Forms.ComboBox TypeOfHouseComboBox;
		private System.Windows.Forms.Label SquareLabel;
		private System.Windows.Forms.ComboBox TransportComboBox;
		private System.Windows.Forms.Label ChoosePriceLabel;
		private System.Windows.Forms.ComboBox PriceComboBox;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button GoBackButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox PositionComboBox;
		private System.Windows.Forms.CheckBox ComunicationCheckBox;
		private System.Windows.Forms.CheckBox ComfortCheckBox;
        private System.Windows.Forms.Label label1;
    }
}