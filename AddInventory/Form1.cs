using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddInventory.Product;

namespace AddInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            product p = new product
            {
                Number = int.Parse(txt_number.Text),
                Date = txt_date.Value,
                Inventory_Number = int.Parse(txt_inventoryNumber.Text),
                Object_Name = (txt_object_Number.Text),
                count = int.Parse(txt_count.Text),
                price = int.Parse(txt_price.Text),
                isAvaliable = isAvaliable.Checked,
            };
            p.Save();
            MessageBox.Show($"user {txt_number.Text} is registerd");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
