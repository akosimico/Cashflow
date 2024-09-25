
namespace All_Caps
{
    public partial class Form1 : Form


    {
        ProductForm prodfrm = new ProductForm();
        Sales salesfrm = new Sales();

        public Form1()
        {
            InitializeComponent();


        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            salesfrm.TopLevel = false;
            salesfrm.AutoScroll = true;
            panel1.Controls.Add(salesfrm);
            prodfrm.Hide();
            salesfrm.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            prodfrm.TopLevel = false;
            prodfrm.AutoScroll = true;
            panel1.Controls.Add(prodfrm);
            prodfrm.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            prodfrm.TopLevel = false;
            prodfrm.AutoScroll = true;
            panel1.Controls.Add(prodfrm);
            salesfrm.Hide();
            prodfrm.Show();
        }
    }
}
    
