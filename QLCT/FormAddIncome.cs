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
    public partial class FormAddIncome : Form
    {
        public FormAddIncome()
        {
            InitializeComponent();
            this.ClientSize = new Size(400, 240);

            DrawLabels();
            DrawTextFields();
            DrawCommands();
        }

        public void DrawLabels()
        {
            Label ldate = new Label();
            ldate.Text = "Thời gian";
            ldate.ClientSize = new Size(150, 20);
            ldate.Location = new Point(50, 50);

            Label lname = new Label();
            lname.Text = "Tên khoản nhận";
            lname.ClientSize = new Size(150, 20);
            lname.Location = new Point(50, 75);

            Label ltype = new Label();
            ltype.Text = "Loại khoản nhận";
            ltype.ClientSize = new Size(150, 20);
            ltype.Location = new Point(50, 100);

            Label lcost = new Label();
            lcost.Text = "Số tiền";
            lcost.ClientSize = new Size(150, 20);
            lcost.Location = new Point(50, 125);

            this.Controls.Add(ldate);
            this.Controls.Add(lname);
            this.Controls.Add(ltype);
            this.Controls.Add(lcost);
        }

        DateTimePicker date = new DateTimePicker();
        TextBox name = new TextBox();
        ComboBox type = new ComboBox();
        TextBox cost = new TextBox();

        public void DrawTextFields()
        {
            date.ClientSize = new Size(150, 25);
            date.Location = new Point(200, 50);

            name.ClientSize = new Size(150, 25);
            name.Location = new Point(200, 75);

            type.ClientSize = new Size(150, 25);
            type.Location = new Point(200, 100);
            foreach (string item in Form1.types)
            {
                type.Items.Add(item);
            }
            type.Items.Add("Thêm loại mới...");
            type.SelectionChangeCommitted += (sender, args) =>
            {
                if (type.SelectedIndex == type.Items.Count - 1)
                {
                    FormAddType fat = new FormAddType();
                    fat.ShowDialog();
                    type.Items.Clear();
                    foreach (string item in Form1.types)
                    {
                        type.Items.Add(item);
                    }
                    type.Items.Add("Thêm loại mới...");
                    type.SelectedItem = null;
                }
            };

            cost.ClientSize = new Size(150, 25);
            cost.Location = new Point(200, 125);
            cost.Text = "0";

            this.Controls.Add(date);
            this.Controls.Add(name);
            this.Controls.Add(type);
            this.Controls.Add(cost);
        }

        public void DrawCommands()
        {
            Button btnAdd = new Button();
            btnAdd.Text = "Thêm";
            btnAdd.ClientSize = new Size(100, 25);
            btnAdd.Location = new Point(100, 175);
            btnAdd.Click += (sender, args) =>
            {
                if (name.Text.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên!");
                    return;
                }
                if (type.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn loại!");
                    return;
                }
                if (cost.Text.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập số tiền!");
                    return;
                }
                foreach (char num in cost.Text.ToString())
                {
                    if (num < '0' || num > '9')
                    {
                        MessageBox.Show("Số tiền không hợp lệ!");
                        return;
                    }
                }
                KhoanNhan income = new KhoanNhan();
                income.TenKhoanNhan = name.Text.ToString();
                income.LoaiKhoanNhan = type.SelectedItem.ToString();
                income.ThoiGian = DateTime.Parse(date.Text.ToString());
                income.SoTien = Int64.Parse(cost.Text.ToString());
                Form1.balance += income.SoTien;

                QLCTDataContext db = new QLCTDataContext();
                db.KhoanNhans.InsertOnSubmit(income);
                db.SubmitChanges();

                MessageBox.Show("Thêm khoản nhận thành công!");
                name.Text = "";
                type.SelectedItem = null;
                cost.Text = "";
                date.Value = DateTime.Today;
            };

            Button btnCancel = new Button();
            btnCancel.Text = "Hủy bỏ";
            btnCancel.ClientSize = new Size(100, 25);
            btnCancel.Location = new Point(250, 175);
            btnCancel.Click += (sender, args) =>
            {
                this.Close();
            };

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnCancel);
        }
    }
}
