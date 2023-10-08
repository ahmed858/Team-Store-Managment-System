using APP.Context;
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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }



        private void AddtypeButton_Click(object sender, EventArgs e)
        {
            AddProductForm addproductForm = new AddProductForm();





            addproductForm.Show();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            using (var context = new TeamStoreContext())
            {
                dataGridView1.DataSource = context.Products.ToList();

            }
        }
    }
}
