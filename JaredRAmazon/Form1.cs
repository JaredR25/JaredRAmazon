using JaredRAmazon;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JaredRAmazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            listView.Columns.Add("Product ID", 25);
            listView.Columns.Add("Product Name", 50);
            listView.Columns.Add("Description", 75);
            listView.Columns.Add("Brand", 100);
            listView.Columns.Add("Price", 125);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductID = txtPID.Text,
                ProductName = txtName.Text,
                ProductDescription = txtDescription.Text,
                ProductPrice = txtBrand.Text,
                ProductBrand = txtBrand.Text,
            };
            if (string.IsNullOrEmpty(txtPID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            ListViewItem item = new ListViewItem(txtPID.Text);
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(txtDescription.Text);
            item.SubItems.Add(txtBrand.Text);
            item.SubItems.Add(txtBrand.Text);
            listView.Items.Add(item);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtPID.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Product Count: " + listView.Items.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
