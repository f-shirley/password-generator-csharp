
namespace password_generator
{
    partial class CustomPasswordForm
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
            this.lbl_CustomTitle = new System.Windows.Forms.Label();
            this.lbl_CustomPassword_Instructions = new System.Windows.Forms.Label();
            this.txtbox_CustomPasswordEntry = new System.Windows.Forms.TextBox();
            this.txtbox_CustomPassword = new System.Windows.Forms.TextBox();
            this.btn_CustomCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CustomTitle
            // 
            this.lbl_CustomTitle.AutoSize = true;
            this.lbl_CustomTitle.BackColor = System.Drawing.Color.BlueViolet;
            this.lbl_CustomTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CustomTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CustomTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CustomTitle.Location = new System.Drawing.Point(-79, 9);
            this.lbl_CustomTitle.Name = "lbl_CustomTitle";
            this.lbl_CustomTitle.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.lbl_CustomTitle.Size = new System.Drawing.Size(960, 59);
            this.lbl_CustomTitle.TabIndex = 2;
            this.lbl_CustomTitle.Text = "Custom Password";
            // 
            // lbl_CustomPassword_Instructions
            // 
            this.lbl_CustomPassword_Instructions.AutoSize = true;
            this.lbl_CustomPassword_Instructions.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CustomPassword_Instructions.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CustomPassword_Instructions.Location = new System.Drawing.Point(111, 88);
            this.lbl_CustomPassword_Instructions.Name = "lbl_CustomPassword_Instructions";
            this.lbl_CustomPassword_Instructions.Size = new System.Drawing.Size(579, 135);
            this.lbl_CustomPassword_Instructions.TabIndex = 3;
            this.lbl_CustomPassword_Instructions.Text = "Type a word or symbols in the first box,\r\nadding hashes(#) to signify\r\nrandom cha" +
    "racters. Then press \'Create\'";
            this.lbl_CustomPassword_Instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_CustomPasswordEntry
            // 
            this.txtbox_CustomPasswordEntry.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_CustomPasswordEntry.Location = new System.Drawing.Point(269, 260);
            this.txtbox_CustomPasswordEntry.Name = "txtbox_CustomPasswordEntry";
            this.txtbox_CustomPasswordEntry.Size = new System.Drawing.Size(268, 34);
            this.txtbox_CustomPasswordEntry.TabIndex = 4;
            // 
            // txtbox_CustomPassword
            // 
            this.txtbox_CustomPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_CustomPassword.Location = new System.Drawing.Point(269, 300);
            this.txtbox_CustomPassword.Name = "txtbox_CustomPassword";
            this.txtbox_CustomPassword.Size = new System.Drawing.Size(268, 34);
            this.txtbox_CustomPassword.TabIndex = 5;
            // 
            // btn_CustomCreate
            // 
            this.btn_CustomCreate.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_CustomCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CustomCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CustomCreate.Location = new System.Drawing.Point(328, 351);
            this.btn_CustomCreate.Name = "btn_CustomCreate";
            this.btn_CustomCreate.Size = new System.Drawing.Size(147, 70);
            this.btn_CustomCreate.TabIndex = 7;
            this.btn_CustomCreate.Text = "Create";
            this.btn_CustomCreate.UseVisualStyleBackColor = false;
            this.btn_CustomCreate.Click += new System.EventHandler(this.btn_CustomCreate_Click);
            // 
            // CustomPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CustomCreate);
            this.Controls.Add(this.txtbox_CustomPassword);
            this.Controls.Add(this.txtbox_CustomPasswordEntry);
            this.Controls.Add(this.lbl_CustomPassword_Instructions);
            this.Controls.Add(this.lbl_CustomTitle);
            this.Name = "CustomPasswordForm";
            this.Text = "Custom Password";
            this.Load += new System.EventHandler(this.CustomPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CustomTitle;
        private System.Windows.Forms.Label lbl_CustomPassword_Instructions;
        private System.Windows.Forms.TextBox txtbox_CustomPasswordEntry;
        private System.Windows.Forms.TextBox txtbox_CustomPassword;
        private System.Windows.Forms.Button btn_CustomCreate;
    }
}