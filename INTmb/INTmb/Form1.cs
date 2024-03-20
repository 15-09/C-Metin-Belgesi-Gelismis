using System.Drawing.Printing;
using System.Windows.Forms;

namespace INTmb
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string flpth = openFileDialog1.FileName;
                string txtfl = File.ReadAllText(flpth);
                rtbTxt.Text = txtfl;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";
            sd.Title = "Dosyayý Kaydet";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                string flpth = sd.FileName;
                File.WriteAllText(flpth, rtbTxt.Text);
                MessageBox.Show("Dosya baþarýyla kaydedildi.");
            }
        }

        private void pctrPr_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument1;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbTxt.Text, new System.Drawing.Font("Arial", 12), System.Drawing.Brushes.Black, 50, 50);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
