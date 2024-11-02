namespace Demo
{
    partial class ClientInfo
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
            this.Exit = new System.Windows.Forms.Button();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.NameClients = new System.Windows.Forms.TextBox();
            this.NameFirm = new System.Windows.Forms.Label();
            this.Editinformation = new System.Windows.Forms.Button();
            this.NameClient = new System.Windows.Forms.Label();
            this.ToReturn = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(222, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameTextBox.Location = new System.Drawing.Point(148, 12);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.CompanyNameTextBox.TabIndex = 0;
            // 
            // NameClients
            // 
            this.NameClients.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameClients.Location = new System.Drawing.Point(148, 49);
            this.NameClients.Name = "NameClients";
            this.NameClients.Size = new System.Drawing.Size(100, 22);
            this.NameClients.TabIndex = 0;
            // 
            // NameFirm
            // 
            this.NameFirm.AutoSize = true;
            this.NameFirm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFirm.Location = new System.Drawing.Point(12, 12);
            this.NameFirm.Name = "NameFirm";
            this.NameFirm.Size = new System.Drawing.Size(130, 13);
            this.NameFirm.TabIndex = 1;
            this.NameFirm.Text = "Наименование фирмы";
            // 
            // Editinformation
            // 
            this.Editinformation.BackColor = System.Drawing.SystemColors.Window;
            this.Editinformation.Location = new System.Drawing.Point(196, 234);
            this.Editinformation.Name = "Editinformation";
            this.Editinformation.Size = new System.Drawing.Size(101, 23);
            this.Editinformation.TabIndex = 2;
            this.Editinformation.Text = "Редактирование";
            this.Editinformation.UseVisualStyleBackColor = false;
            this.Editinformation.Click += new System.EventHandler(this.OpenEditForm_Click_1);
            // 
            // NameClient
            // 
            this.NameClient.AutoSize = true;
            this.NameClient.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NameClient.Location = new System.Drawing.Point(12, 49);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(118, 13);
            this.NameClient.TabIndex = 3;
            this.NameClient.Text = "Директор компании";
            // 
            // ToReturn
            // 
            this.ToReturn.Location = new System.Drawing.Point(15, 415);
            this.ToReturn.Name = "ToReturn";
            this.ToReturn.Size = new System.Drawing.Size(75, 23);
            this.ToReturn.TabIndex = 4;
            this.ToReturn.Text = "Вернуться";
            this.ToReturn.UseVisualStyleBackColor = true;
            this.ToReturn.Click += new System.EventHandler(this.ToReturn_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PhoneNumber.Location = new System.Drawing.Point(12, 84);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(98, 13);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Рейтинг компании";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(148, 84);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberTextBox.TabIndex = 0;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingTextBox.Location = new System.Drawing.Point(148, 122);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 22);
            this.RatingTextBox.TabIndex = 0;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountTextBox.Location = new System.Drawing.Point(148, 160);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 22);
            this.DiscountTextBox.TabIndex = 0;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Discount.Location = new System.Drawing.Point(12, 160);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(45, 13);
            this.Discount.TabIndex = 8;
            this.Discount.Text = "Скидка";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(309, 234);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ToReturn);
            this.Controls.Add(this.NameClient);
            this.Controls.Add(this.Editinformation);
            this.Controls.Add(this.NameFirm);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.NameClients);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Name = "ClientInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.TextBox NameClients;
        private System.Windows.Forms.Label NameFirm;
        private System.Windows.Forms.Button Editinformation;
        private System.Windows.Forms.Label NameClient;
        private System.Windows.Forms.Button ToReturn;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Button Save;
    }
}