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
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
            this.ClientSize = new Size(300, 140);

            DrawLabels();
            DrawTextFields();
            DrawCommands();
        }

        public void DrawLabels()
        {
            Label ltype = new Label();
            ltype.Text = "Loại khoản";
            ltype.ClientSize = new Size(50, 20);
            ltype.Location = new Point(50, 50);

            this.Controls.Add(ltype);
        }

        TextBox type = new TextBox();
        
        public void DrawTextFields()
        {
            type.ClientSize = new Size(150, 25);
            type.Location = new Point(100, 50);

            this.Controls.Add(type);
        }

        public void DrawCommands()
        {
            Button btnAdd = new Button();
            btnAdd.Text = "Thêm";
            btnAdd.ClientSize = new Size(100, 25);
            btnAdd.Location = new Point(50, 100);
            btnAdd.Click += (sender, args) =>
            {
                if (type.Text.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập loại!");
                    return;
                }

                MessageBox.Show("Thêm loại thành công!");
                Form1.types.Add(type.Text.ToString());
                type.Text = "";
            };

            Button btnCancel = new Button();
            btnCancel.Text = "Hủy bỏ";
            btnCancel.ClientSize = new Size(100, 25);
            btnCancel.Location = new Point(150, 100);
            btnCancel.Click += (sender, args) =>
            {
                this.Close();
            };

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnCancel);
        }
    }
}
