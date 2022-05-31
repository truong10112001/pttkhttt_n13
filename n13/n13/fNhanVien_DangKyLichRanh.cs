using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class fNhanViec_DangKyLichRanh : Form
    {
        public fNhanViec_DangKyLichRanh()
        {
            InitializeComponent();
        }

        private void fNhanViec_DangKyLichRanh_Load(object sender, EventArgs e)
        {
            comboBoxCa.Items.Add("Sáng");
            comboBoxCa.Items.Add("Chiều");
            comboBoxCa.Items.Add("Tối");
            comboBoxCa.SelectedItem = "Sáng";
        }
    }
}
