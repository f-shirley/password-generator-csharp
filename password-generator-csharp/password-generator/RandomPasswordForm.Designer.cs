
namespace password_generator
{
    partial class RandomPasswordForm
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
            this.lbl_RandomTitle = new System.Windows.Forms.Label();
            this.lbl_howmanychar = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtbox_RandomPassword = new System.Windows.Forms.TextBox();
            this.lbl_recommendediseight = new System.Windows.Forms.Label();
            this.btn_RandomCreate = new System.Windows.Forms.Button();
            this.lbl_SliderValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RandomTitle
            // 
            this.lbl_RandomTitle.AutoSize = true;
            this.lbl_RandomTitle.BackColor = System.Drawing.Color.BlueViolet;
            this.lbl_RandomTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RandomTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_RandomTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_RandomTitle.Location = new System.Drawing.Point(-96, 9);
            this.lbl_RandomTitle.Name = "lbl_RandomTitle";
            this.lbl_RandomTitle.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.lbl_RandomTitle.Size = new System.Drawing.Size(973, 59);
            this.lbl_RandomTitle.TabIndex = 1;
            this.lbl_RandomTitle.Text = "Random Password";
            // 
            // lbl_howmanychar
            // 
            this.lbl_howmanychar.AutoSize = true;
            this.lbl_howmanychar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_howmanychar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_howmanychar.Location = new System.Drawing.Point(215, 82);
            this.lbl_howmanychar.Name = "lbl_howmanychar";
            this.lbl_howmanychar.Size = new System.Drawing.Size(338, 45);
            this.lbl_howmanychar.TabIndex = 2;
            this.lbl_howmanychar.Text = "How many characters?";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBar1.Location = new System.Drawing.Point(238, 146);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(269, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackbar1_scroll);
            // 
            // txtbox_RandomPassword
            // 
            this.txtbox_RandomPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_RandomPassword.Location = new System.Drawing.Point(255, 250);
            this.txtbox_RandomPassword.Name = "txtbox_RandomPassword";
            this.txtbox_RandomPassword.Size = new System.Drawing.Size(268, 34);
            this.txtbox_RandomPassword.TabIndex = 4;
            // 
            // lbl_recommendediseight
            // 
            this.lbl_recommendediseight.AutoSize = true;
            this.lbl_recommendediseight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_recommendediseight.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_recommendediseight.Location = new System.Drawing.Point(270, 180);
            this.lbl_recommendediseight.Name = "lbl_recommendediseight";
            this.lbl_recommendediseight.Size = new System.Drawing.Size(225, 25);
            this.lbl_recommendediseight.TabIndex = 5;
            this.lbl_recommendediseight.Text = "Recommended is 8(eight)";
            // 
            // btn_RandomCreate
            // 
            this.btn_RandomCreate.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_RandomCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RandomCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RandomCreate.Location = new System.Drawing.Point(311, 325);
            this.btn_RandomCreate.Name = "btn_RandomCreate";
            this.btn_RandomCreate.Size = new System.Drawing.Size(147, 70);
            this.btn_RandomCreate.TabIndex = 6;
            this.btn_RandomCreate.Text = "Create";
            this.btn_RandomCreate.UseVisualStyleBackColor = false;
            this.btn_RandomCreate.Click += new System.EventHandler(this.btn_RandomCreate_Click);
            // 
            // lbl_SliderValue
            // 
            this.lbl_SliderValue.AutoSize = true;
            this.lbl_SliderValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SliderValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_SliderValue.Location = new System.Drawing.Point(501, 137);
            this.lbl_SliderValue.Name = "lbl_SliderValue";
            this.lbl_SliderValue.Size = new System.Drawing.Size(37, 45);
            this.lbl_SliderValue.TabIndex = 7;
            this.lbl_SliderValue.Text = "8";
            this.lbl_SliderValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // RandomPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_SliderValue);
            this.Controls.Add(this.btn_RandomCreate);
            this.Controls.Add(this.lbl_recommendediseight);
            this.Controls.Add(this.txtbox_RandomPassword);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_howmanychar);
            this.Controls.Add(this.lbl_RandomTitle);
            this.Name = "RandomPasswordForm";
            this.Text = "Random Password";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RandomTitle;
        private System.Windows.Forms.Label lbl_howmanychar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtbox_RandomPassword;
        private System.Windows.Forms.Label lbl_recommendediseight;
        private System.Windows.Forms.Button btn_RandomCreate;
        private System.Windows.Forms.Label lbl_SliderValue;
    }
}