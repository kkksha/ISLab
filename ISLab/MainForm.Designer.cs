
namespace ISLab
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.officeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SteadButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.ApartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // officeButton
            // 
            this.officeButton.Location = new System.Drawing.Point(97, 72);
            this.officeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.officeButton.Name = "officeButton";
            this.officeButton.Size = new System.Drawing.Size(120, 39);
            this.officeButton.TabIndex = 0;
            this.officeButton.Text = "Офис";
            this.officeButton.UseVisualStyleBackColor = true;
            this.officeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(173, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подбор Недвижимости";
            // 
            // SteadButton
            // 
            this.SteadButton.Location = new System.Drawing.Point(97, 139);
            this.SteadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SteadButton.Name = "SteadButton";
            this.SteadButton.Size = new System.Drawing.Size(116, 47);
            this.SteadButton.TabIndex = 2;
            this.SteadButton.Text = "Земельный участок";
            this.SteadButton.UseVisualStyleBackColor = true;
            this.SteadButton.Click += new System.EventHandler(this.SteadButton_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(308, 139);
            this.HouseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(124, 47);
            this.HouseButton.TabIndex = 4;
            this.HouseButton.Text = "Дом";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // ApartmentButton
            // 
            this.ApartmentButton.Location = new System.Drawing.Point(308, 72);
            this.ApartmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApartmentButton.Name = "ApartmentButton";
            this.ApartmentButton.Size = new System.Drawing.Size(124, 46);
            this.ApartmentButton.TabIndex = 3;
            this.ApartmentButton.Text = "Квартира";
            this.ApartmentButton.UseVisualStyleBackColor = true;
            this.ApartmentButton.Click += new System.EventHandler(this.ApartmentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(543, 229);
            this.Controls.Add(this.HouseButton);
            this.Controls.Add(this.ApartmentButton);
            this.Controls.Add(this.SteadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.officeButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Подбор недвижимости";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button officeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SteadButton;
		private System.Windows.Forms.Button HouseButton;
		private System.Windows.Forms.Button ApartmentButton;
	}
}

