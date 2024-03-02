namespace Tp02AppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            MediaAritimetica media = new MediaAritimetica()
            {
                p1 = txtP1.Text,
                p2 = txtP2.Text,
                p3 = txtP3.Text,
                p4 = txtP4.Text,
            };

            txtResultado.Text = media.getMedia().ToString();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
        }
    }
}