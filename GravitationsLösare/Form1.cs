using System.Net;

namespace GravitationsLösare
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "G-Drivs";
            tabPage2.Text = "Ractor";
            tabPage3.Text = "Minemal dogd"; 
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }


        private void Solv_Click(object sender, EventArgs e)
        {

            double PCU = 1;
            double massa = 1;

            if(textBox1.Text != "")
                PCU = double.Parse(textBox1.Text);
            if(textBox2.Text != "")
                massa = double.Parse(textBox2.Text);


            double GBlock = PCU / 370;
            double MassaB = GBlock * 7.4;
            double Kraft = 495000 * GBlock * MassaB;
            AntalMassa.Text = Math.Round(MassaB,2).ToString();
            AntalG.Text = Math.Round(GBlock,2).ToString();
            AntalF.Text = Math.Round(Kraft,2).ToString();
            massa += GBlock * 8532 + MassaB * 9544;
            double Speed = 100/(Kraft/massa);
            Antal100.Text = Math.Round(Speed,2).ToString();
            iMassa.Text = MassaB.ToString();
            iGrav.Text = GBlock.ToString();
            iAxeleration.Text = (Kraft / massa).ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Massa = double.Parse(bMassa.Text);
            double TidH = double.Parse(bAx.Text);
            double GMengd = double.Parse(bG.Text);
            double antall = Massa / (1964 * GMengd * TidH - 7144);
            AntalBalls.Text = Math.Round(antall,2).ToString();
            tabPage1.Text = "hej";

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            double Massa = double.Parse(iMassa.Text);
            double Gravitation = double.Parse(iGrav.Text);
            double Rail = double.Parse(iRail.Text);
            double Gyro = double.Parse(iGyro.Text);
            Massa *= 567.13;
            Gravitation *= 600;
            Rail *= 38000;
            Gyro *= 10;
            uMassaR.Text = Math.Round(Massa,1).ToString()+ " kw";
            uGravR.Text = Math.Round(Gravitation,1).ToString() + " kw"; 
            uRailR.Text = Math.Round(Rail, 1).ToString() + " kw";
            uGyraR.Text = Math.Round(Gyro, 1).ToString() + " kw";
            double Resultat = Massa +Gravitation +Rail + Gyro;
            ukW.Text = Resultat.ToString();
            rStora.Text = Math.Round((Resultat/300000),2).ToString();
            rSmo.Text = Math.Round((Resultat/15000),2).ToString();





        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double axelaration = double.Parse(iAxeleration.Text);
            double diametor = double.Parse(iDimeter.Text);
            double proVelos = double.Parse(iProjekil.Text);
            diametor *= 2.5;
            uMinemalDodg.Text = ((Math.Sqrt(diametor / axelaration)) * proVelos).ToString();
        }
    }
}