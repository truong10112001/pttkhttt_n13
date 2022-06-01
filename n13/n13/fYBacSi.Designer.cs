
namespace n13
{
    partial class fYBacSi
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
            this.buttonDangKyLich = new System.Windows.Forms.Button();
            this.buttonXemLich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDangKyLich
            // 
            this.buttonDangKyLich.BackColor = System.Drawing.Color.Green;
            this.buttonDangKyLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangKyLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKyLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDangKyLich.Location = new System.Drawing.Point(88, 76);
            this.buttonDangKyLich.Name = "buttonDangKyLich";
            this.buttonDangKyLich.Size = new System.Drawing.Size(167, 89);
            this.buttonDangKyLich.TabIndex = 14;
            this.buttonDangKyLich.Text = "Đăng ký lịch làm việc";
            this.buttonDangKyLich.UseVisualStyleBackColor = false;
            // 
            // buttonXemLich
            // 
            this.buttonXemLich.BackColor = System.Drawing.Color.Green;
            this.buttonXemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXemLich.Location = new System.Drawing.Point(349, 76);
            this.buttonXemLich.Name = "buttonXemLich";
            this.buttonXemLich.Size = new System.Drawing.Size(167, 89);
            this.buttonXemLich.TabIndex = 15;
            this.buttonXemLich.Text = "Xem lịch làm việc";
            this.buttonXemLich.UseVisualStyleBackColor = false;
            // 
            // fYBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(589, 271);
            this.Controls.Add(this.buttonXemLich);
            this.Controls.Add(this.buttonDangKyLich);
            this.Name = "fYBacSi";
            this.Text = "fYBacSi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDangKyLich;
        private System.Windows.Forms.Button buttonXemLich;
    }
}