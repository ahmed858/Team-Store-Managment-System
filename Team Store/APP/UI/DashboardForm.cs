using APP.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Store

{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {

            headlineLabel.Text = "المنتجات/الأصناف";

            ProductsForm productForm = new ProductsForm();

            productForm.TopLevel = false;

            FillPanel.Controls.Clear();
            FillPanel.Controls.Add(productForm);
            //MessageBox.Show($"{FillPanel.Size}");
            productForm.Size = FillPanel.Size;

            productForm.Location = new Point(0, 0);
            productForm.Show();

        }

        private void LogoutPictureBox_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.OpenForms[0].Close();
        }

        private void BillOfSalePanel_Click(object sender, EventArgs e)
        {


            headlineLabel.Text = "فاتورة بيع ";

            NewBillOfSaleForm Billform = new NewBillOfSaleForm();

            Billform.TopLevel = false;
            FillPanel.Controls.Clear();
            FillPanel.Controls.Add(Billform);
            //MessageBox.Show($"{FillPanel.Size}");
            Billform.Size = FillPanel.Size;

            Billform.Location = new Point(0, 0);
            Billform.Show();
        }

        private void PruchBillpanel_Click(object sender, EventArgs e)
        {
            headlineLabel.Text = "فاتورة مشتريات جديدة ";

            NewPurchases_billForm form = new NewPurchases_billForm();

            form.TopLevel = false;
            FillPanel.Controls.Clear();
            FillPanel.Controls.Add(form);
            //MessageBox.Show($"{FillPanel.Size}");
            form.Size = FillPanel.Size;

            form.Location = new Point(0, 0);
            form.Show();
        }
    }
}
