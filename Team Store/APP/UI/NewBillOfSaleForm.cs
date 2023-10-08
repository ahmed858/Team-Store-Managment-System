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
    public partial class NewBillOfSaleForm : Form
    {
        public NewBillOfSaleForm()
        {
            InitializeComponent();
        }

       
        private void NewBillOfSaleForm_Load(object sender, EventArgs e)
        {
            using (var context = new TeamStoreContext())
            {
                var Stocks = context.Stocks.ToList();
                StockscomboBox.DisplayMember = "StockName";
                StockscomboBox.ValueMember = "StockId";
                StockscomboBox.DataSource = Stocks;
            }

        }

        private void AddStockpictureBox_Click_1(object sender, EventArgs e)
        {
            AddStockForm addStockForm = new AddStockForm();
            addStockForm.ShowDialog();
        }
    }
}
