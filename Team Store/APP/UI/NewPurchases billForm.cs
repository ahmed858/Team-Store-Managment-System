using APP.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.UI
{
    public partial class NewPurchases_billForm : Form
    {
        public NewPurchases_billForm()
        {
            InitializeComponent();
        }

        private void NewPurchases_billForm_Load(object sender, EventArgs e)
        {
            CurDatetextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            using (var context = new TeamStoreContext())
            {
                var Stocks = context.Stocks.ToList();

                StockscomboBox.DisplayMember = "StockName";
                StockscomboBox.ValueMember = "StockId";
                StockscomboBox.DataSource = Stocks;

                var supliers = context.Suppliers.ToList();

                SuplierscomboBox.DisplayMember = "SupplierName";
                SuplierscomboBox.ValueMember = "SupplierId";
                SuplierscomboBox.DataSource = supliers;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Additembutton_Click(object sender, EventArgs e)
        {

        }
    }
}
