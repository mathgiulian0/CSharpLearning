using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        int Xplayer = 0, Oplayer = 0, empatesPontos = 0, rounds = 0;
        bool turno = true, jogoFinal = false;
        string[] texto = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            rounds = 0;
            jogoFinal = false;
            for(int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start para todos os botões
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogoFinal == false)  //preenche quando um botão está vazio 
            {

                if (turno)
                {
                    btn.Text = "X";                    //preenche com X
                    texto[buttonIndex] = btn.Text;     //declara a posição no array
                    rounds++;                          //passa para o próximo round
                    turno = !turno;                    //altera o turno de true pra false
                    Check(1);
                }
                else
                {
                    btn.Text = "O";                    //preenche com O
                    texto[buttonIndex] = btn.Text;
                    rounds++;
                    turno = !turno;
                    Check(2);
                }
            }
        } //final método botão

        //define ganhador:
        void Winner(int WinningPlayer)
        {
            jogoFinal = true;

            if(WinningPlayer == 1)
            {
                Xplayer++;
                Xpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador X ganhou!");
                turno = true;
            }
            else
            {
                Oplayer++;
                Opontos.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador O ganhou!");
                turno = false;
            }
        }

        void Check(int CheckPlayer)
        {
            string support;

            if (CheckPlayer == 1)
            {
                support = "X";
            }
            else
            {
                support = "O";
            } //final do support

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (support == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Winner(CheckPlayer);
                        return;
                    }// final do check na horizontal 
                }
            }// final do loop horizontal

            //chech vertical

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (support == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Winner(CheckPlayer);
                        return;
                    }// final do check na vertical 
                }
            }// final do loop vertical

            //check das diagonais:

            if (texto[0] == support)
            {

                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Winner(CheckPlayer);
                    return;
                } //primeira diagonal
            }

            if (texto[2] == support)
            {

                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Winner(CheckPlayer);
                    return;
                } //segunda diagonal 
            }

            //Define empate:
            if(rounds == 9 && jogoFinal == false)
            {
                empatesPontos++;
                empate.Text = Convert.ToString(empatesPontos);
                MessageBox.Show("Empate!");
                jogoFinal = true;
                return;
            }
        }
        private void Xpontos_Click(object sender, EventArgs e)
        {

        }
    }
}
