using APP.BL;
using APP.Context;
using APP.Entities;
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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;

                int id = -1;
                bool can = int.TryParse(IDtextBox.Text, out id);
                if (!can)
                {
                    iderrorlabel.Text = "ادخل رقم صحيح";
                    iderrorlabel.Visible = true;
                    ok = false;
                }

                string productName = NametextBox.Text;
                if (productName == null || productName.Length == 0)
                {
                    Nameerrorlabel.Text = "ادخل اسم صحيح";
                    ok = false;
                }

                decimal purchprice = 0;
                can = decimal.TryParse(PurchPricetextBox.Text, out purchprice);
                if (!can)
                {
                    PurchingPriceerrorlabel.Text = "ادخل سعر صحيح";
                    PurchingPriceerrorlabel.Visible = true;
                    ok = false;
                }
                decimal sellingprice = 0;
                can = decimal.TryParse(SellPricetextBox.Text, out sellingprice);
                if (!can)
                {
                    SellPriceerrorlabel.Text = "ادخل سعر صحيح";
                    SellPriceerrorlabel.Visible = true;
                    ok = false;
                }
                string Category = CategorylistBox.Text;
                int? cateID = null;
                if (Category == null || Category.Length == 0)
                {
                    Nameerrorlabel.Text = "ادخل اسم فئة صحيح";
                    ok = false;
                }
                else
                {
                    cateID = CategorylistBox.SelectedIndex + 1;
                    //MessageBox.Show(CategorylistBox.SelectedIndex.ToString(), "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!ok)
                {
                    return;
                }

                Product p = new Product()
                {
                    ProductId = id,
                    CategoryId = (int)cateID,
                    Name = productName,
                    SellPrice = sellingprice,
                    PurchasePrice = purchprice,
                    Description = DesctextBox.Text

                };

                try
                {
                    using (var context = new TeamStoreContext())
                    {
                        context.Add(p);

                        context.SaveChanges();
                    }
                    HappyLabel.Visible = true;
                }
                catch
                {
                    MessageBox.Show("الكود موجود بالفعل ادخل كود اخر", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            using (var context = new TeamStoreContext())
                CategorylistBox.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
        }


    }
}
