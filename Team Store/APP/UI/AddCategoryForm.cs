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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string catName = NametextBox.Text;
                bool ok = true;
                if (catName == null || catName.Length == 0)
                {
                    ok = false;
                    label4.Visible = true;
                    return;
                }
                string desc = DesctextBox.Text;

                Category category = new Category() { CategoryDescription = desc, CategoryName = catName };
                using (var context = new TeamStoreContext())
                {

                    context.Categories.Add(category);
                    context.SaveChanges();
                    label4.Visible = true;

                }

            }
            catch (Exception ex)
            {

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
