using APP.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP.UI
{
    public partial class AddStockForm : Form
    {
        public AddStockForm()
        {
            InitializeComponent();
            context = new TeamStoreContext();

        }
        TeamStoreContext context;

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;


                string stockName = stockNametextBox.Text;
                if (stockName == null || stockName.Length == 0)
                {
                    Nameerrorlabel.Text = "حقل مطلوب";
                    Nameerrorlabel.Visible = true;
                    ok = false;
                }
                string location = LocationtextBox.Text;
                string desc = DesctextBox.Text;




                if (!ok)
                {
                    Nameerrorlabel.Visible = false;
                    return;
                }

                Stock s = new Stock()
                {
                    StockName = stockName,
                    Location = location,
                    StockDescription = desc

                };

                context.Add(s);

                context.SaveChanges();
                HappyLabel.Visible = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
