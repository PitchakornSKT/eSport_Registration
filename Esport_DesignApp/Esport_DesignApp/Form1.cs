namespace Esport_DesignApp
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "กรอกข้อมูลผู้เล่น";
            this.formInputPlayer1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "ผู้เล่น";
            this.formInputPlayer1.Visible = false;
        }
    }
}