
namespace n13
{
    partial class FNhanVienKeToan
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonXemLich = new System.Windows.Forms.Button();
            this.buttonDangKyLich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(110, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 89);
            this.button2.TabIndex = 22;
            this.button2.Text = "Tạo hóa đơn thanh toán";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(460, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 89);
            this.button1.TabIndex = 21;
            this.button1.Text = "Xử lý phiếu đăng ký";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonXemLich
            // 
            this.buttonXemLich.BackColor = System.Drawing.Color.Green;
            this.buttonXemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXemLich.Location = new System.Drawing.Point(449, 90);
            this.buttonXemLich.Name = "buttonXemLich";
            this.buttonXemLich.Size = new System.Drawing.Size(167, 89);
            this.buttonXemLich.TabIndex = 20;
            this.buttonXemLich.Text = "Xem lịch làm việc";
            this.buttonXemLich.UseVisualStyleBackColor = false;
            // 
            // buttonDangKyLich
            // 
            this.buttonDangKyLich.BackColor = System.Drawing.Color.Green;
            this.buttonDangKyLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangKyLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKyLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDangKyLich.Location = new System.Drawing.Point(110, 79);
            this.buttonDangKyLich.Name = "buttonDangKyLich";
            this.buttonDangKyLich.Size = new System.Drawing.Size(167, 89);
            this.buttonDangKyLich.TabIndex = 19;
            this.buttonDangKyLich.Text = "Đăng ký lịch làm việc";
            this.buttonDangKyLich.UseVisualStyleBackColor = false;
            // 
            // FNhanVienKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonXemLich);
            this.Controls.Add(this.buttonDangKyLich);
            this.Name = "FNhanVienKeToan";
            this.Text = "FNhanVienKeToan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonXemLich;
        private System.Windows.Forms.Button buttonDangKyLich;
    }
}