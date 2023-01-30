using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class FormExpenseHistory : Form
    {
        public FormExpenseHistory()
        {
            InitializeComponent();
        }

        private void cmdTim_Click(object sender, EventArgs e)
        {
            QLCTDataContext db = new QLCTDataContext();
            DateTime tn = cldTuNgay.Value;
            DateTime dn = cldDenNgay.Value;

            var query = from x in db.KhoanChis.Where(p => p.ThoiGian >= tn.Date && p.ThoiGian <= dn.Date && p.TenKhoanChi.Contains(txtTuKhoa.Text))
                        select new
                        {
                            x.ThoiGian,
                            x.TenKhoanChi,
                            x.SoTien
                        };

            query = query.OrderBy(p => p.ThoiGian);

            dtgData.DataSource = query;

        }
    }
}