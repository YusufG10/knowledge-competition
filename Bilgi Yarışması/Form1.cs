namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruNo++;
            labelSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                buttonA.Text = "1920"; buttonB.Text = "1921"; buttonC.Text = "1922"; buttonD.Text = "1923";
                label4.Text = "1923";
                buttonSonraki.Text = "Sonraki";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgesi'nde bulunmaz ?";
                buttonA.Text = "İzmir"; buttonB.Text = "Balıkesir"; buttonC.Text = "Aydın"; buttonD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar eseri hangi yazara aittir?";
                buttonA.Text = "Sait Faik"; buttonB.Text = "Cemal Süreya"; buttonC.Text = "Attila İlhan"; buttonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                buttonSonraki.Text = "Yarışma Bitti";
                buttonSonraki.Enabled = false;
                
            }
            if(soruNo == 4)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonSonraki.Enabled = false;
                labelSoruNo.Text = "3";
                MessageBox.Show("Doğru: "+dogru + "\n" + "Yanlış: "+yanlis);
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = false;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;


            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;


            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;


            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}