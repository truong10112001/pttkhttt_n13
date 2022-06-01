
namespace n13
{
    partial class fNhanVienDieuHanh_SapXepLich
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
            this.dataGridViewLichRanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDuyet = new System.Windows.Forms.Button();
            this.buttonKhongDuyet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichRanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLichRanh
            // 
            this.dataGridViewLichRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichRanh.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewLichRanh.Name = "dataGridViewLichRanh";
            this.dataGridViewLichRanh.RowHeadersWidth = 51;
            this.dataGridViewLichRanh.RowTemplate.Height = 24;
            this.dataGridViewLichRanh.Size = new System.Drawing.Size(367, 414);
            this.dataGridViewLichRanh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch rảnh";
            // 
            // buttonDuyet
            // 
            this.buttonDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDuyet.Location = new System.Drawing.Point(420, 121);
            this.buttonDuyet.Name = "buttonDuyet";
            this.buttonDuyet.Size = new System.Drawing.Size(167, 89);
            this.buttonDuyet.TabIndex = 12;
            this.buttonDuyet.Text = "Duyệt";
            this.buttonDuyet.UseVisualStyleBackColor = false;
            // 
            // buttonKhongDuyet
            // 
            this.buttonKhongDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonKhongDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKhongDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhongDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKhongDuyet.Location = new System.Drawing.Point(420, 335);
            this.buttonKhongDuyet.Name = "buttonKhongDuyet";
            this.buttonKhongDuyet.Size = new System.Drawing.Size(167, 89);
            this.buttonKhongDuyet.TabIndex = 13;
            this.buttonKhongDuyet.Text = "Không duyệt";
            this.buttonKhongDuyet.UseVisualStyleBackColor = false;
            // 
            // fNhanVienDieuHanh_SapXepLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(625, 518);
            this.Controls.Add(this.buttonKhongDuyet);
            this.Controls.Add(this.buttonDuyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLichRanh);
            this.Name = "fNhanVienDieuHanh_SapXepLich";
            this.Text = "fNhanVienDieuHanh_SapXepLich";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichRanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLichRanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDuyet;
        private System.Windows.Forms.Button buttonKhongDuyet;
    }
}