namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý.");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý.");
        }
    }
    /*THREADLER TEK ÇEKÝRDEK ÜZERÝNDEN BÝLGÝ AKTARIMI YAPARLAR
     * MULTÝ THREADLER ÝSE 8 ÇEKÝRDEK ÜZERÝNDEN(SAYI DEÐÝÞEBÝLÝR)(ÇEKÝRDEKLERÝ BORU OLARAK HAYAL ET.)BÝLGÝ AKTARIMI YAPARLAR
     SENKRON PROGRAMLAMALARDA ÝÞLEMLER BÝR ÖNCEKÝ ÝÞLEMÝN THREAD Ý BÝTÝRMESÝNÝ BEKLER
    ASENKRON PROGRAMLAMALARDA ÝSE BÝLGÝ BEKLEME YAPMADAN THREADLER ÜZERÝNDEN GEÇER.*/
}