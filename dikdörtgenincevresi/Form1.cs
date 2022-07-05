namespace dikdörtgenincevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Değişkenleri tanımla
            int kisa_kenar, uzun_kenar, alan,cevre;
            //Textbox olduğu için integere dönüştür.
            kisa_kenar = Convert.ToInt32(kisa.Text);
                uzun_kenar = Convert.ToInt32(uzun.Text);
            // alan ve çevreyi matematiksel formüle dönüştür.
            alan = kisa_kenar * uzun_kenar;
            cevre = 2 * (kisa_kenar + uzun_kenar);
            //radiobuttonlara göre koşul yarat
            if (radioButton1.Checked == true)
                MessageBox.Show("Dikdötgenin Alanı:" + " " + alan.ToString() + " " + "cm2dir."
                    );
            else if (radioButton2.Checked == true)
                MessageBox.Show("Dikdörtgenin çevresi" + " " + cevre.ToString() + " " + "cmdir.");
                
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi_gir;
            sayi_gir = Convert.ToInt32(sayi.Text);
            if ( sayi_gir %2 == 0 )
            { MessageBox.Show("Girdiğiniz sayı çifttir."); }
            else
            {
                MessageBox.Show("Girdiğiniz sayı tektir.");
            }
        }
    }
}