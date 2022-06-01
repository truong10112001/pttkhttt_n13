
namespace n13
{
    partial class fNhanVienDieuHanh
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
            this.buttonXepLich = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXepLich
            // 
            this.buttonXepLich.BackColor = System.Drawing.Color.Green;
            this.buttonXepLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXepLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXepLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXepLich.Location = new System.Drawing.Point(61, 76);
            this.buttonXepLich.Name = "buttonXepLich";
            this.buttonXepLich.Size = new System.Drawing.Size(167, 89);
            this.buttonXepLich.TabIndex = 13;
            this.buttonXepLich.Text = "Sắp Xếp lịch làm việc";
            this.buttonXepLich.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(344, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 89);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xem lịch làm việc của nhân viên";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fNhanVienDieuHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonXepLich);
            this.Name = "fNhanVienDieuHanh";
            this.Text = "fNhanVienDieuHanh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXepLich;
        private System.Windows.Forms.Button button1;
    }
}