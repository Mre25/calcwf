namespace calcwf
{
    public partial class frmClac : Form


    {
        int FN, SN;
        string OP;

        public frmClac()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnNoX_Click(object sender, EventArgs e)
        {
            txtResult.Text += ((Button)sender).Text;
            


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            OP = ((Button)sender).Text;
            FN = int.Parse(txtResult.Text);
            txtResult.Clear();



        }

        private void btnequl_Click(object sender, EventArgs e)
        {
            SN = int.Parse(txtResult.Text);
            if (OP == "+")

                txtResult.Text = (FN + SN).ToString();

            if (OP == "-")

                txtResult.Text = (FN - SN).ToString();

            if (OP == "*")

                txtResult.Text = (FN * SN).ToString();

            if (OP == "/")

                txtResult.Text = (FN / SN).ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
