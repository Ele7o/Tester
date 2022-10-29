namespace Calculator
{
    public partial class Form1 : Form
    {
        double a, b, c;

        

        public Form1()
        {
            InitializeComponent();


        }

        private void btnCong_Click(object sender, EventArgs e)
        {
   
                a = double.Parse(soThuNhat.Text);
                b = double.Parse(soThuHai.Text);
                c = a + b;

                ketQua.Text = c.ToString();
                soThuNhat.Text = c.ToString();
                soThuHai.Clear();
                lastCal.Text = a.ToString() + " + " + b.ToString();

        }



        private void btnTru_Click(object sender, EventArgs e)
        {
        
                a = double.Parse(soThuNhat.Text);
                b = double.Parse(soThuHai.Text);
                c = a - b;

           
                ketQua.Text = c.ToString();
                soThuNhat.Text = c.ToString();
                soThuHai.Clear();
                lastCal.Text = a.ToString() + " - " + b.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
           
            a = double.Parse(soThuNhat.Text);
            b = double.Parse(soThuHai.Text);
            c = a * b;

            
            ketQua.Text = c.ToString();
            soThuNhat.Text = c.ToString();
            soThuHai.Clear();
            lastCal.Text = a.ToString() + " * " + b.ToString();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            a = double.Parse(soThuNhat.Text);
            b = double.Parse(soThuHai.Text);
            if (b != 0)
            {
                c = a / b;
            }
            ketQua.Text = c.ToString();
            soThuNhat.Text = c.ToString();
            soThuHai.Clear();
            lastCal.Text = a.ToString() + " ÷ " + b.ToString();
        }
    }
}