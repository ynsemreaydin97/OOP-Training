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
            MessageBox.Show("��lem 1 �al��t�.");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�.");
        }
    }
    /*THREADLER TEK �EK�RDEK �ZER�NDEN B�LG� AKTARIMI YAPARLAR
     * MULT� THREADLER �SE 8 �EK�RDEK �ZER�NDEN(SAYI DE���EB�L�R)(�EK�RDEKLER� BORU OLARAK HAYAL ET.)B�LG� AKTARIMI YAPARLAR
     SENKRON PROGRAMLAMALARDA ��LEMLER B�R �NCEK� ��LEM�N THREAD � B�T�RMES�N� BEKLER
    ASENKRON PROGRAMLAMALARDA �SE B�LG� BEKLEME YAPMADAN THREADLER �ZER�NDEN GE�ER.*/
}