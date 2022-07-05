namespace dikdörtgenincevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa_kenar, uzun_kenar, alan,cevre;
            kisa_kenar = Convert.ToInt32(kisa.Text);
                uzun_kenar = Convert.ToInt32(uzun.Text);
            alan = kisa_kenar * uzun_kenar;
            cevre = 2 * (kisa_kenar + uzun_kenar);
            if (radioButton1.Checked == true)
                MessageBox.Show("Dikdötgenin Alanı:" + " " + alan.ToString() + " " + "cm2dir."
                    );
            else if (radioButton2.Checked == true)
                MessageBox.Show("Dikdörtgenin çevresi" + " " + cevre.ToString() + " " + "cmdir.");
                
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }
    }
}