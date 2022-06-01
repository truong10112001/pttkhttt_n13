
namespace n13
{
    partial class fNhanVienDieuHanh_XemLich
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
            this.dataGridViewLichLamViec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLichLamViec
            // 
            this.dataGridViewLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichLamViec.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewLichLamViec.Name = "dataGridViewLichLamViec";
            this.dataGridViewLichLamViec.RowHeadersWidth = 51;
            this.dataGridViewLichLamViec.RowTemplate.Height = 24;
            this.dataGridViewLichLamViec.Size = new System.Drawing.Size(586, 416);
            this.dataGridViewLichLamViec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lịch làm viêc";
            // 
            // fNhanVienDieuHanh_XemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(615, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLichLamViec);
            this.Name = "fNhanVienDieuHanh_XemLich";
            this.Text = "Xem lịch làm việc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLichLamViec;
        private System.Windows.Forms.Label label1;
    }
}