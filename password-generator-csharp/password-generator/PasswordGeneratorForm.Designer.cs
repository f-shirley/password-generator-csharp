
namespace password_generator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_CustomPassword = new System.Windows.Forms.Button();
            this.btn_RandomPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.BlueViolet;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_title.Location = new System.Drawing.Point(-103, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.lbl_title.Size = new System.Drawing.Size(1004, 59);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Password Generator";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // btn_CustomPassword
            // 
            this.btn_CustomPassword.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_CustomPassword.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CustomPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CustomPassword.Location = new System.Drawing.Point(86, 117);
            this.btn_CustomPassword.Name = "btn_CustomPassword";
            this.btn_CustomPassword.Size = new System.Drawing.Size(257, 161);
            this.btn_CustomPassword.TabIndex = 1;
            this.btn_CustomPassword.Text = "Custom Password";
            this.btn_CustomPassword.UseVisualStyleBackColor = false;
            this.btn_CustomPassword.Click += new System.EventHandler(this.btn_CustomPassword_Click);
            // 
            // btn_RandomPassword
            // 
            this.btn_RandomPassword.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_RandomPassword.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RandomPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RandomPassword.Location = new System.Drawing.Point(448, 117);
            this.btn_RandomPassword.Name = "btn_RandomPassword";
            this.btn_RandomPassword.Size = new System.Drawing.Size(257, 161);
            this.btn_RandomPassword.TabIndex = 2;
            this.btn_RandomPassword.Text = "Random Password";
            this.btn_RandomPassword.UseVisualStyleBackColor = false;
            this.btn_RandomPassword.Click += new System.EventHandler(this.btn_RandomPassword_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.btn_RandomPassword);
            this.Controls.Add(this.btn_CustomPassword);
            this.Controls.Add(this.lbl_title);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Password Generator v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_CustomPassword;
        private System.Windows.Forms.Button btn_RandomPassword;
    }
}

