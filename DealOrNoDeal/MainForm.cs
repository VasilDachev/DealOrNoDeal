using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DealOrNoDeal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Глобални променливи,масиви и т.н.,които са ми послужили.

        Random rnd = new Random();
        readonly string filePath = "highscore.txt";
        int[] arrGeneratedNubmers = new int[26];
        int[] arrBoxes = new int[26];
        int tmp; //Задържа случайно генерираните стойности, докато ги напъхам в масив.
        int myBox; // За да запазя стойността на избраната кутия в отедлна променлива.
        int BoxIndicator; //Брояч да завъртя стойностите из масива (не знам защо не направих цикъл, така ми дойде, така ще стои!!!)
        int BankerTimer1 = 6; //Брояч за офертите на банкера.
        int brEndGame = 26; //Брояч за приключване на игра без сделка.
        int Swapping = 3418431;//Сбора от всички суми.
        int Highscore;
        int Counter1 = 6;
        int Counter2 = 5;
        int Counter3 = 4;
        int Counter4 = 3;
        int Counter5 = 2;
        int Counter6 = 2;
        int Counter7 = 1;
        string Player;
        int Sum1 = 1;
        int Sum2 = 5;
        int Sum3 = 10;
        int Sum4 = 15;
        int Sum5 = 25;
        int Sum6 = 50;
        int Sum7 = 75;
        int Sum8 = 100;
        int Sum9 = 200;
        int Sum10 = 300;
        int Sum11 = 400;
        int Sum12 = 500;
        int Sum13 = 750;
        int Sum14 = 1000;
        int Sum15 = 5000;
        int Sum16 = 10000;
        int Sum17 = 25000;
        int Sum18 = 50000;
        int Sum19 = 75000;
        int Sum20 = 100000;
        int Sum21 = 200000;
        int Sum22 = 300000;
        int Sum23 = 400000;
        int Sum24 = 500000;
        int Sum25 = 750000;
        int Sum26 = 1000000;

        // 3..2..1..Старт!
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            btnResetGame.Visible = true;
            lblChoose.Visible = true;
            tbChoseBox.Visible = true;
            btnChoose.Visible = true;
            AddingSums();
            btnChoose.Visible = true;
            tbChoseBox.Visible = true;
            lblChoose.Visible = true;
            lblBoxRange.Visible = true;
            tbChoseBox.Text = "";
            lblBoxesUntilOffer.Visible = true;
            lblCount.Visible = true;
            lblCount.Text = "6";
                

            //Напъхвам в масив всички случано генерирани числа.

            for (int i = 0; i < arrGeneratedNubmers.Length; i++) 
            {
                tmp = rnd.Next(1,27);
                while (IsDup(tmp, arrGeneratedNubmers))
                {
                    tmp = rnd.Next(1,27);
                }
                arrGeneratedNubmers[i] = tmp;    
            }
            DistributingBoxes();
        }

        //Проверка за неповтарящи се случайни числа.

        private bool IsDup(int tmp, int[] arrGeneratedNubmers)
        {
            foreach (var item in arrGeneratedNubmers)
            {
                if(item == tmp)
                {
                    return true;
                }
                
            }
            return false;
        }
        
        //Изчистване на всичко до начален стадий.
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            btnResetGame.Visible = false;
            btnStartGame.Visible = true;
            BoxesInvisible();                               //Reset ...!
            lbLeftSums.Items.Clear();
            lbRightSums.Items.Clear();
            Array.Clear(arrGeneratedNubmers, 0, 26);
            lblWonSum.Visible = false;
            lblYouWon.Visible = false;
            lblYourBox.Visible = false;
            lblMyBox.Visible = false;
            lblMyBox.Text = "";
            BankerTimer1 = 6 ;
            SumRestoring();
            brEndGame = 26;
            lblswappedsum.Visible = false;
            lblSwappedyours.Visible = false;
            btnSubmitScore.Visible = false;
            Swapping = 3418431;
            tbPlayerName.Visible = false;
            tbPlayerName.Text = "";
            Highscore = 0;
            lblBoxesUntilOffer.Visible = false;
            lblCount.Visible = false;
            Counter1 = 6;
            Counter2 = 5;
            Counter3 = 4;
            Counter4 = 3;
            Counter5 = 2;
            Counter6 = 2;
            Counter7 = 1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMeForm aboutme = new AboutMeForm();
            aboutme.ShowDialog();
        }

        private void checkHighscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighscoreForm highscore = new HighscoreForm();
            highscore.ShowDialog();
        }

        private void btnSubmitScore_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text.Trim() != "")
            {
                Player = tbPlayerName.Text;

                // tbPlayerName.Text = "";
                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(Highscore.ToString() + "$" + "  <->  " + Player);
                    }
                }
                tbPlayerName.Visible = false;
                btnSubmitScore.Visible = false;
            }
            else
            {
                MessageBox.Show("Enter your name!");
            }
        }

        //Кликове(Captain obvious)

        private void btnBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[0].ToString() + " $ ");
            btnBox1.Visible = false;
            BoxIndicator = 0;
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[0];
            Banker();
            EndingGame();
            UntilOfferCounter();
        }

        private void btnBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[1].ToString() + " $ ");
            btnBox2.Visible = false;
            BoxIndicator = 1;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[1];
            Banker();
            EndingGame();
        }

        private void btnBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[2].ToString() + " $ ");
            btnBox3.Visible = false;
            BoxIndicator = 2;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[2];
            Banker();
            EndingGame();
        }

        private void btnBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[3].ToString() + " $ ");
            btnBox4.Visible = false;
            BoxIndicator = 3;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[3];
            Banker();
            EndingGame();
        }

        private void btnBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[4].ToString()+ " $ ");
            btnBox5.Visible = false;
            BoxIndicator = 4;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[4];
            Banker();
            EndingGame();
        }

        private void btnBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[5].ToString() + " $ ");
            btnBox6.Visible = false;
            BoxIndicator = 5;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[5];
            Banker();
            EndingGame();
        }

        private void btnBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[6].ToString() + " $ ");
            btnBox7.Visible = false;
            BoxIndicator = 6;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[6];
            Banker();
            EndingGame();
        }

        private void btnBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[7].ToString() + " $ ");
            btnBox8.Visible = false;
            BoxIndicator = 7;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[7];
            Banker();
            EndingGame();
        }

        private void btnBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[8].ToString() + " $ ");
            btnBox9.Visible = false;
            BoxIndicator = 8;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[8];
            Banker();
            EndingGame();
        }

        private void btnBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[9].ToString() + " $ ");
            btnBox10.Visible = false;
            BoxIndicator = 9;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[9];
            Banker();
            EndingGame();
        }

        private void btnBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[10].ToString() + " $ ");
            btnBox11.Visible = false;
            BoxIndicator = 10;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[10];
            Banker();
            EndingGame();
        }

        private void btnBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[11].ToString() + " $ ");
            btnBox12.Visible = false;
            BoxIndicator = 11;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[11];
            Banker();
            EndingGame();
        }

        private void btnBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[12].ToString() + " $ ");
            btnBox13.Visible = false;
            BoxIndicator = 12;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[12];
            Banker();
            EndingGame();
        }

        private void btnBox14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[13].ToString() + " $ ");
            btnBox14.Visible = false;
            BoxIndicator = 13;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[13];
            Banker();
            EndingGame();
        }

        private void btnBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[14].ToString() + " $ ");
            btnBox15.Visible = false;
            BoxIndicator = 14;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[14];
            Banker();
            EndingGame();
        }

        private void btnBox16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[15].ToString() + " $ ");
            btnBox16.Visible = false;
            BoxIndicator = 15;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[15];
            Banker();
            EndingGame();
        }

        private void btnBox17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[16].ToString() + " $ ");
            btnBox17.Visible = false;
            BoxIndicator = 16;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[16];
            Banker();
            EndingGame();
        }

        private void btnBox18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[17].ToString() + " $ ");
            btnBox18.Visible = false;
            BoxIndicator = 17;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[17];
            Banker();
            EndingGame();
        }

        private void btnBox19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[18].ToString() + " $ ");
            btnBox19.Visible = false;
            BoxIndicator = 18;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[18];
            Banker();
            EndingGame();
        }

        private void btnBox20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[19].ToString() + " $ ");
            btnBox20.Visible = false;
            BoxIndicator = 19;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[19];
            Banker();
            EndingGame();
        }

        private void btnBox21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[20].ToString() + " $ ");
            btnBox21.Visible = false;
            BoxIndicator = 20;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[20];
            Banker();
            EndingGame();
        }

        private void btnBox22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[21].ToString() + " $ ");
            btnBox22.Visible = false;
            BoxIndicator = 21;
            UntilOfferCounter();
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[21];
            Banker();
            EndingGame();
        }

        private void btnBox23_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[22].ToString() + " $ ");
            btnBox23.Visible = false;
            BoxIndicator = 22;
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[22];
            Banker();
            EndingGame();
            UntilOfferCounter();
        }

        private void btnBox24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[23].ToString() + " $ ");
            btnBox24.Visible = false;
            BoxIndicator = 23;
            MethodForRemovingSumsFromList();
            UntilOfferCounter();
            Swapping -= arrBoxes[23];
            Banker();
            EndingGame();
        }

        private void btnBox25_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[24].ToString() + " $ ");
            btnBox25.Visible = false;
            BoxIndicator = 24;
            MethodForRemovingSumsFromList();
            UntilOfferCounter();
            Swapping -= arrBoxes[24];
            Banker();
            EndingGame();
        }

        private void btnBox26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrBoxes[25].ToString() + " $ ");
            btnBox26.Visible = false;
            BoxIndicator = 25;
            MethodForRemovingSumsFromList();
            Swapping -= arrBoxes[25];
            UntilOfferCounter();
            Banker();
            
            EndingGame();
        }
        private void UntilOfferCounter()
        {

            
            if (Counter1>1)
            {
                Counter1--;
                lblCount.Text = Counter1.ToString();
                
            }
            else
            {
                if (Counter2>=1)
                {
                    lblCount.Text = Counter2.ToString();
                    Counter2--;
                }
                else
                {
                    if (Counter3>=1)
                    {
                        lblCount.Text = Counter3.ToString();
                        Counter3--;
                    }
                    else
                    {
                        if (Counter4>=1)
                        {
                            lblCount.Text = Counter4.ToString();
                            Counter4--;
                        }
                        else
                        {
                            if (Counter5>=1)
                            {
                                lblCount.Text = Counter5.ToString();
                                Counter5--;
                            }
                            else
                            {
                                if (Counter6>=1)
                                {
                                    lblCount.Text = Counter6.ToString();
                                    Counter6--;
                                }
                                else
                                {
                                    if (Counter7>=1)
                                    {
                                        lblCount.Text = Counter7.ToString();
                                        Counter7--;
                                        lblCount.Visible = false;
                                        lblBoxesUntilOffer.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
               
            }



        }
        private void Banker()
        {
            int Offer;
            int offCalcEarlyGame = Sum1 + Sum2 + Sum3 + Sum4 + Sum5 + Sum6 + Sum7 + Sum8 + Sum9 + Sum10 + Sum11
                + Sum12 + Sum13 + Sum14 + Sum15 + Sum16 + Sum17 + Sum18 + Sum19 + Sum20 + Sum21
                + Sum22 + Sum23;
            int offCalcEndGame = Sum1 + Sum2 + Sum3 + Sum4 + Sum5 + Sum6 + Sum7 + Sum8 + Sum9 + Sum10 + Sum11
                + Sum12 + Sum13 + Sum14 + Sum15 + Sum16 + Sum17 + Sum18 + Sum19 + Sum20 + Sum21
                + Sum22 + Sum23 + Sum24 + Sum25 + Sum26;
            BankerTimer1--;
            if (BankerTimer1 == 0)
            {
                Offer = offCalcEarlyGame / 20;
                pbMan.Visible = true;
                DialogResult res1 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res1 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -5)
            {

                Offer = offCalcEarlyGame / 15;
                pbMan.Visible = true;
                DialogResult res2 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res2 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -9)
            {
                Offer = offCalcEarlyGame / 11;
                pbMan.Visible = true;
                DialogResult res3 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res3 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -12)
            {
                Offer = offCalcEarlyGame / 8;
                pbMan.Visible = true;
                DialogResult res4 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res4 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -14)
            {
                Offer = offCalcEndGame / 6;
                pbMan.Visible = true;
                DialogResult res5 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res5 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -16)
            {
                Offer = offCalcEndGame / 4;
                pbMan.Visible = true;
                DialogResult res6 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res6 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -17)
            {
                Offer = offCalcEndGame / 3;
                pbMan.Visible = true;
                DialogResult res7 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res7 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                else
                {
                    pbMan.Visible = false;
                }
            }
            if (BankerTimer1 == -18)
            {
                Offer = offCalcEndGame / 2;
                pbMan.Visible = true;
                DialogResult res8 = MessageBox.Show("Your offer is: " + Offer.ToString() + "$", "Deal or No deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res8 == DialogResult.Yes)
                {
                    BoxesInvisible();
                    lblWonSum.Text = Offer.ToString().Trim() + "$";
                    lblWonSum.Visible = true;
                    lblYouWon.Visible = true;
                    lblMyBox.Text = myBox.ToString() + '$';
                    btnSubmitScore.Visible = true;
                    tbPlayerName.Visible = true;
                    Highscore = Offer;
                    pbMan.Visible = false;
                }
                if (res8 == DialogResult.No)
                {
                    pbMan.Visible = false;
                    DialogResult res9 = MessageBox.Show("Do you want to swap boxes ? ", "Deal or no deal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res9 == DialogResult.Yes)
                    {
                        int oldBox = myBox;
                        MethodForRemovingSumsFromList();
                        myBox = Swapping - myBox;
                        lblWonSum.Text = myBox.ToString() + "$";
                        lblWonSum.Visible = true;
                        lblYouWon.Visible = true;
                        lbRightSums.Items.Clear();
                        lbLeftSums.Items.Clear();
                        lblswappedsum.Visible = true;
                        lblSwappedyours.Visible = true;
                        lblswappedsum.Text = oldBox.ToString() + "$";
                        BoxesInvisible();
                        btnSubmitScore.Visible = true;
                        tbPlayerName.Visible = true;
                        Highscore = myBox;
                        brEndGame++;
                        

                    }
                }
            }
        }

        private void EndingGame()
        {
            brEndGame--;
            if (brEndGame == 1)
            {
                lblWonSum.Text = myBox.ToString() + "$";
                lblWonSum.Visible = true;
                lblYouWon.Visible = true;
                lblMyBox.Text = myBox.ToString() + '$';
                btnSubmitScore.Visible = true;
                tbPlayerName.Visible = true;
                Highscore = myBox;
            }
        }

        //Невидими.
        private void BoxesInvisible()
        {
            btnBox1.Visible = false;
            btnBox2.Visible = false;
            btnBox3.Visible = false;
            btnBox4.Visible = false;
            btnBox5.Visible = false;
            btnBox6.Visible = false;
            btnBox7.Visible = false;
            btnBox8.Visible = false;
            btnBox9.Visible = false;
            btnBox10.Visible = false;
            btnBox11.Visible = false;
            btnBox12.Visible = false;
            btnBox13.Visible = false;
            btnBox14.Visible = false;
            btnBox15.Visible = false;
            btnBox16.Visible = false;
            btnBox17.Visible = false;
            btnBox18.Visible = false;
            btnBox19.Visible = false;
            btnBox20.Visible = false;
            btnBox21.Visible = false;
            btnBox22.Visible = false;
            btnBox23.Visible = false;
            btnBox24.Visible = false;
            btnBox25.Visible = false;
            btnBox26.Visible = false;
        }
        //Видими.
        private void BoxesVisible()
        {
            btnBox1.Visible = true;
            btnBox2.Visible = true;
            btnBox3.Visible = true;
            btnBox4.Visible = true;
            btnBox5.Visible = true;
            btnBox6.Visible = true;
            btnBox7.Visible = true;
            btnBox8.Visible = true;
            btnBox9.Visible = true;
            btnBox10.Visible = true;
            btnBox11.Visible = true;
            btnBox12.Visible = true;
            btnBox13.Visible = true;
            btnBox14.Visible = true;
            btnBox15.Visible = true;
            btnBox16.Visible = true;
            btnBox17.Visible = true;
            btnBox18.Visible = true;
            btnBox19.Visible = true;
            btnBox20.Visible = true;
            btnBox21.Visible = true;
            btnBox22.Visible = true;
            btnBox23.Visible = true;
            btnBox24.Visible = true;
            btnBox25.Visible = true;
            btnBox26.Visible = true;
        }

        //Пълнене на листовете със суми.

        private void AddingSums()
        {
            lbLeftSums.Items.Add(Sum1 + "  $");
            lbLeftSums.Items.Add(Sum2 + "  $");
            lbLeftSums.Items.Add(Sum3 + "  $");
            lbLeftSums.Items.Add(Sum4 + "  $");
            lbLeftSums.Items.Add(Sum5 + "  $");
            lbLeftSums.Items.Add(Sum6 + "  $");
            lbLeftSums.Items.Add(Sum7 + "  $");
            lbLeftSums.Items.Add(Sum8 + "  $");
            lbLeftSums.Items.Add(Sum9 + "  $");
            lbLeftSums.Items.Add(Sum10 + "  $");
            lbLeftSums.Items.Add(Sum11 + "  $");
            lbLeftSums.Items.Add(Sum12 + "  $");
            lbLeftSums.Items.Add(Sum13 + "  $");

            lbRightSums.Items.Add(Sum14 + "  $");
            lbRightSums.Items.Add(Sum15 + "  $");
            lbRightSums.Items.Add(Sum16 + "  $");
            lbRightSums.Items.Add(Sum17 + "  $");
            lbRightSums.Items.Add(Sum18 + "  $");
            lbRightSums.Items.Add(Sum19 + "  $");
            lbRightSums.Items.Add(Sum20 + "  $");
            lbRightSums.Items.Add(Sum21 + "  $");
            lbRightSums.Items.Add(Sum22 + "  $");
            lbRightSums.Items.Add(Sum23 + "  $");
            lbRightSums.Items.Add(Sum24 + "  $");
            lbRightSums.Items.Add(Sum25 + "  $");
            lbRightSums.Items.Add(Sum26 + "  $");
        }

        private void DistributingBoxes()
        {
            for (int i = 0; i < arrGeneratedNubmers.Length; i++)
            {
                switch (arrGeneratedNubmers[i])
                {
                    case 1:
                        arrBoxes[i] = Sum1;
                        break;
                    case 2:
                        arrBoxes[i] = Sum2;
                        break;
                    case 3:
                        arrBoxes[i] = Sum3;
                        break;
                    case 4:
                        arrBoxes[i] = Sum4;
                        break;
                    case 5:
                        arrBoxes[i] = Sum5;
                        break;
                    case 6:
                        arrBoxes[i] = Sum6;
                        break;
                    case 7:
                        arrBoxes[i] = Sum7;
                        break;
                    case 8:
                        arrBoxes[i] = Sum8;
                        break;
                    case 9:
                        arrBoxes[i] = Sum9;
                        break;
                    case 10:
                        arrBoxes[i] = Sum10;
                        break;
                    case 11:
                        arrBoxes[i] = Sum11;
                        break;
                    case 12:
                        arrBoxes[i] = Sum12;
                        break;
                    case 13:
                        arrBoxes[i] = Sum13;
                        break;
                    case 14:
                        arrBoxes[i] = Sum14;
                        break;
                    case 15:
                        arrBoxes[i] = Sum15;
                        break;
                    case 16:
                        arrBoxes[i] = Sum16;
                        break;
                    case 17:
                        arrBoxes[i] = Sum17;
                        break;
                    case 18:
                        arrBoxes[i] = Sum18;
                        break;
                    case 19:
                        arrBoxes[i] = Sum19;
                        break;
                    case 20:
                        arrBoxes[i] = Sum20;
                        break;
                    case 21:
                        arrBoxes[i] = Sum21;
                        break;
                    case 22:
                        arrBoxes[i] = Sum22;
                        break;
                    case 23:
                        arrBoxes[i] = Sum23;
                        break;
                    case 24:
                        arrBoxes[i] = Sum24;
                        break;
                    case 25:
                        arrBoxes[i] = Sum25;
                        break;
                    case 26:
                        arrBoxes[i] = Sum26;
                        break;
                }
            }


        }
        // Избиране на стартова кутия + много бакалска проверка.
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (tbChoseBox.Text.Trim() != "")
            {
                if (tbChoseBox.Text == "1")
                {
                    myBox = arrBoxes[0];
                    BoxesVisible();
                    btnBox1.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "1";
                    lblBoxRange.Visible = false;
                   

                }
                if (tbChoseBox.Text == "2")
                {
                    myBox = arrBoxes[1];
                    BoxesVisible();
                    btnBox2.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "2";
                    lblBoxRange.Visible = false;
               
                }
                if (tbChoseBox.Text == "3")
                {
                    myBox = arrBoxes[2];
                    BoxesVisible();
                    btnBox3.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "3";
                    lblBoxRange.Visible = false;
                   
                }
                if (tbChoseBox.Text == "4")
                {
                    myBox = arrBoxes[3];
                    BoxesVisible();
                    btnBox4.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "4";
                    lblBoxRange.Visible = false;
                
                }
                if (tbChoseBox.Text == "5")
                {
                    myBox = arrBoxes[4];
                    BoxesVisible();
                    btnBox5.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "5";
                    lblBoxRange.Visible = false;
                

                }
                if (tbChoseBox.Text == "6")
                {
                    myBox = arrBoxes[5];
                    BoxesVisible();
                    btnBox6.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "6";
                    lblBoxRange.Visible = false;
               
                }
                if (tbChoseBox.Text == "7")
                {
                    myBox = arrBoxes[6];
                    BoxesVisible();
                    btnBox7.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "7";
                    lblBoxRange.Visible = false;
                
                }
                if (tbChoseBox.Text == "8")
                {
                    myBox = arrBoxes[7];
                    BoxesVisible();
                    btnBox8.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "8";
                    lblBoxRange.Visible = false;
                  
                }
                if (tbChoseBox.Text == "9")
                {
                    myBox = arrBoxes[8];
                    BoxesVisible();
                    btnBox9.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "9";
                    lblBoxRange.Visible = false;
                  

                }
                if (tbChoseBox.Text == "10")
                {
                    myBox = arrBoxes[9];
                    BoxesVisible();
                    btnBox10.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "10";
                    lblBoxRange.Visible = false;
                  
                }
                if (tbChoseBox.Text == "11")
                {
                    myBox = arrBoxes[10]; 
                    BoxesVisible();
                    btnBox11.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "11";
                    lblBoxRange.Visible = false;
                   
                }
                if (tbChoseBox.Text == "12")
                {
                    myBox = arrBoxes[11];
                    BoxesVisible();
                    btnBox12.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "12";
                 
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "13")
                {
                    myBox = arrBoxes[12];
                    BoxesVisible();
                    btnBox13.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                 
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "13";
                    lblBoxRange.Visible = false;

                }
                if (tbChoseBox.Text == "14")
                {
                    myBox = arrBoxes[13];
                    BoxesVisible();
                    btnBox14.Visible = false;
                    
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "14";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "15")
                {
                    myBox = arrBoxes[14];
                    BoxesVisible();
                    btnBox15.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                 
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "15";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "16")
                {
                    myBox = arrBoxes[15];
                    BoxesVisible();
                    btnBox16.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
               
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "16";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "17")
                {
                    myBox = arrBoxes[16];
                    BoxesVisible();
                    btnBox17.Visible = false;
                    btnChoose.Visible = false;
                
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "17";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "18")
                {
                    myBox = arrBoxes[17];
                    BoxesVisible();
                    btnBox18.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "18";
                  
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "19")
                {
                    myBox = arrBoxes[18];
                    BoxesVisible();
                    btnBox19.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "19";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "20")
                {
                    myBox = arrBoxes[19];
                    BoxesVisible();
                    btnBox20.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                  
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "20";
                    lblBoxRange.Visible = false;

                }
                if (tbChoseBox.Text == "21")
                {
                    myBox = arrBoxes[20];
                    BoxesVisible();
                    btnBox21.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                  
                    lblMyBox.Text = "21";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "22")
                {
                    myBox = arrBoxes[21];
                    BoxesVisible();
                    btnBox22.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "22";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "23")
                {
                    myBox = arrBoxes[22];
                    BoxesVisible();
                    btnBox23.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                   
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "23";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "24")
                {
                    myBox = arrBoxes[23];
                    BoxesVisible();
                    btnBox24.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                   
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "24";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "25")
                {
                    myBox = arrBoxes[24];
                    BoxesVisible();
                    btnBox25.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
                    lblChoose.Visible = false;
                   
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "25";
                    lblBoxRange.Visible = false;
                }
                if (tbChoseBox.Text == "26")
                {
                    myBox = arrBoxes[25];
                    BoxesVisible();
                    btnBox26.Visible = false;
                    btnChoose.Visible = false;
                    tbChoseBox.Visible = false;
               
                    lblChoose.Visible = false;
                    lblYourBox.Visible = true;
                    lblMyBox.Visible = true;
                    lblMyBox.Text = "26";
                    lblBoxRange.Visible = false;
                }
            }
            else
            {
                
                    MessageBox.Show("Choose box first pal.");
                
                
            }
        }

        private void MethodForRemovingSumsFromList()
        {
            switch (arrGeneratedNubmers[BoxIndicator])
            {
                case 1:
                    lbLeftSums.Items.RemoveAt(0);
                    lbLeftSums.Items.Insert(0, " - ");
                    Sum1 = 0;
                    break;
                case 2:
                    lbLeftSums.Items.RemoveAt(1);
                    lbLeftSums.Items.Insert(1, " - ");
                    Sum2 = 0;
                    break;
                case 3:
                    lbLeftSums.Items.RemoveAt(2);
                    lbLeftSums.Items.Insert(2, " - ");
                    Sum3 = 0;
                    break;
                case 4:
                    lbLeftSums.Items.RemoveAt(3);
                    lbLeftSums.Items.Insert(3, " - ");
                    Sum4 = 0;
                    break;
                case 5:
                    lbLeftSums.Items.RemoveAt(4);
                    lbLeftSums.Items.Insert(4, " - ");
                    Sum5 = 0;
                    break;
                case 6:
                    lbLeftSums.Items.RemoveAt(5);
                    lbLeftSums.Items.Insert(5, " - ");
                    Sum6 = 0;
                    break;
                case 7:
                    lbLeftSums.Items.RemoveAt(6);
                    lbLeftSums.Items.Insert(6, " - ");
                    Sum7 = 0;
                    break;
                case 8:
                    lbLeftSums.Items.RemoveAt(7);
                    lbLeftSums.Items.Insert(7, " - ");
                    Sum8 = 0;
                    break;
                case 9:
                    lbLeftSums.Items.RemoveAt(8);
                    lbLeftSums.Items.Insert(8, " - ");
                    Sum9 = 0;
                    break;
                case 10:
                    lbLeftSums.Items.RemoveAt(9);
                    lbLeftSums.Items.Insert(9, " - ");
                    Sum10 = 0;
                    break;
                case 11:
                    lbLeftSums.Items.RemoveAt(10);
                    lbLeftSums.Items.Insert(10, " - ");
                    Sum11 = 0;
                    break;
                case 12:
                    lbLeftSums.Items.RemoveAt(11);
                    lbLeftSums.Items.Insert(11, " - ");
                    Sum12 = 0;
                    break;
                case 13:
                    lbLeftSums.Items.RemoveAt(12);
                    lbLeftSums.Items.Insert(12, " - ");
                    Sum13 = 0;
                    break;
                case 14:
                    lbRightSums.Items.RemoveAt(0);
                    lbRightSums.Items.Insert(0, " - ");
                    Sum14 = 0;
                    break;
                case 15:
                    lbRightSums.Items.RemoveAt(1);
                    lbRightSums.Items.Insert(1, " - ");
                    Sum15 = 0;
                    break;
                case 16:
                    lbRightSums.Items.RemoveAt(2);
                    lbRightSums.Items.Insert(2, " - ");
                    Sum16 = 0;
                    break;
                case 17:
                    lbRightSums.Items.RemoveAt(3);
                    lbRightSums.Items.Insert(3, " - ");
                    Sum17 = 0;
                    break;
                case 18:
                    lbRightSums.Items.RemoveAt(4);
                    lbRightSums.Items.Insert(4, " - ");
                    Sum18 = 0;
                    break;
                case 19:
                    lbRightSums.Items.RemoveAt(5);
                    lbRightSums.Items.Insert(5, " - ");
                    Sum19 = 0;
                    break;
                case 20:
                    lbRightSums.Items.RemoveAt(6);
                    lbRightSums.Items.Insert(6, " - ");
                    Sum20 = 0;
                    break;
                case 21:
                    lbRightSums.Items.RemoveAt(7);
                    lbRightSums.Items.Insert(7, " - ");
                    Sum21 = 0;
                    break;
                case 22:
                    lbRightSums.Items.RemoveAt(8);
                    lbRightSums.Items.Insert(8, " - ");
                    Sum22 = 0;
                    break;
                case 23:
                    lbRightSums.Items.RemoveAt(9);
                    lbRightSums.Items.Insert(9, " - ");
                    Sum23 = 0;
                    break;
                case 24:
                    lbRightSums.Items.RemoveAt(10);
                    lbRightSums.Items.Insert(10, " - ");
                    Sum24 = 0;
                    break;
                case 25:
                    lbRightSums.Items.RemoveAt(11);
                    lbRightSums.Items.Insert(11, " - ");
                    Sum25 = 0;
                    break;
                case 26:
                    lbRightSums.Items.RemoveAt(12);
                    lbRightSums.Items.Insert(12, " - ");
                    Sum26 = 0;
                    break;
            }
        }

       

        private void SumRestoring()
        {
            Sum1 = 1;
            Sum2 = 5;
            Sum3 = 10;
            Sum4 = 15;
            Sum5 = 25;
            Sum6 = 50;
            Sum7 = 75;
            Sum8 = 100;
            Sum9 = 200;
            Sum10 = 300;
            Sum11 = 400;
            Sum12 = 500;
            Sum13 = 750;
            Sum14 = 1000;
            Sum15 = 5000;
            Sum16 = 10000;
            Sum17 = 25000;
            Sum18 = 50000;
            Sum19 = 75000;
            Sum20 = 100000;
            Sum21 = 200000;
            Sum22 = 300000;
            Sum23 = 400000;
            Sum24 = 500000;
            Sum25 = 750000;
            Sum26 = 1000000;
        }

        
    }
}
