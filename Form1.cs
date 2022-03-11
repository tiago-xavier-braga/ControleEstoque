using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Name = txtName.Text;
            produto.Cody = Convert.ToInt16(txtCody.Text);
            produto.Inventory = Convert.ToInt16(txtInventory.Text);

;       }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
