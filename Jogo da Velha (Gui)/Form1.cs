using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha__Gui_
{
    public partial class Form1 : Form

    {
        static int turnos = 0; //variavel pra definir quantos turnos já correram e se houve empate (9 jogadas e ninguem venceu)
        static int vez = 0; //variável pra definir de quem é a vez
        static int movimentoPC; //variavel q define o movimento do PC (casas 1 a 9)
        bool movMelhorado; //tipo de movimento do PC
        Tabuleiro tabuleiro = new Tabuleiro(0, 0, 0, 0, 0, 0, 0, 0, 0);


        private void resetar()
        {
            turnos = 10;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            tabuleiro.ResetarTabuleiro();
            if (radio_dificil.Checked == true) { movMelhorado = true; }
            if (radio_facil.Checked == true) { movMelhorado = false; }
        }

        public Form1()
        {
            InitializeComponent();
            resetar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "O";
            tabuleiro.c1 = 1;
            button1.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "O";
            tabuleiro.c2 = 1;
            button2.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "O";
            tabuleiro.c3 = 1;
            button3.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "O";
            tabuleiro.c4 = 1;
            button4.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "O";
            tabuleiro.c5 = 1;
            button5.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "O";
            tabuleiro.c6 = 1;
            button6.Enabled = false;

            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "O";
            tabuleiro.c7 = 1;
            button7.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "O";
            tabuleiro.c8 = 1;
            button8.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "O";
            tabuleiro.c9 = 1;
            button9.Enabled = false;
            turnos++;
            calcularVencedor();
            if (turnos < 9) { turnodoPC(); }
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            resetar();
            msg_1.Visible = true;
            turnos = 0;
            Random iniciativa = new Random();
            vez = iniciativa.Next(1, 3); //define quem vai começar
            if (vez == 1) { msg_1.Text = "O jogador começa"; }
            else if (vez == 2) { msg_1.Text = "O computador jogou primeiro"; }


            else { msg_1.Text = vez.ToString(); }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            if (vez == 1)//vez do jogador
            {
                msg_1.Text = "Sua vez de jogar";
            }
            if (vez == 2)
            {
                turnodoPC();
                vez = 1;
            }
        }



        private void calcularVencedor()
        {
            //condições pra a vitória

            int result = tabuleiro.VerResultado();
            if (result == 1)
            {
                progress_jogador.Value++;
                if (progress_jogador.Value == 10)
                {
                    msg_1.Text = "Você Venceu 10 partidas, parabens";
                    progress_jogador.Value = 0;
                    progress_pc.Value = 0;
                }
                else
                {
                    msg_1.Text = "Você Venceu";
                }
                resetar();
            }
            if (result == 2)
            {
                progress_pc.Value++;
                if (progress_pc.Value == 10)
                {
                    msg_1.Text = "Você perdeu 10 partidas, melhor sorte na proxima vez";
                    progress_jogador.Value = 0;
                    progress_pc.Value = 0;
                }
                else
                {
                    msg_1.Text = "Você Perdeu";
                }
                resetar();
            }
            else
            {
                if (turnos == 9) { msg_1.Text = "A partida terminou empatada"; resetar(); }
            }
        }

        private void turnodoPC() //movimento aleatorio, pode ser modificada
        {

            //movimento melhorado

            if (movMelhorado == true)
            {
                movimentoPC = tabuleiro.MovAvancado();
            }
            else
            {
                //movimento aleatorio
                Random rand = new Random();
                movimentoPC = rand.Next(1, 10);
            }


            //calculo vitoria
            switch (movimentoPC)
            {
                case 1:
                    if (button1.Enabled == false) { turnodoPC(); }
                    else { button1.Text = "X"; tabuleiro.c1 = 2; button1.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 2:
                    if (button2.Enabled == false) { turnodoPC(); }
                    else { button2.Text = "X"; tabuleiro.c2 = 2; button2.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 3:
                    if (button3.Enabled == false) { turnodoPC(); }
                    else { button3.Text = "X"; tabuleiro.c3 = 2; button3.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 4:
                    if (button4.Enabled == false) { turnodoPC(); }
                    else { button4.Text = "X"; tabuleiro.c4 = 2; button4.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 5:
                    if (button5.Enabled == false) { turnodoPC(); }
                    else { button5.Text = "X"; tabuleiro.c5 = 2; button5.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 6:
                    if (button6.Enabled == false) { turnodoPC(); }
                    else { button6.Text = "X"; tabuleiro.c6 = 2; button6.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 7:
                    if (button7.Enabled == false) { turnodoPC(); }
                    else { button7.Text = "X"; tabuleiro.c7 = 2; button7.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 8:
                    if (button8.Enabled == false) { turnodoPC(); }
                    else { button8.Text = "X"; tabuleiro.c8 = 2; button8.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                case 9:
                    if (button9.Enabled == false) { turnodoPC(); }
                    else { button9.Text = "X"; tabuleiro.c9 = 2; button9.Enabled = false; turnos++; calcularVencedor(); }
                    break;
                default:

                    break;
            }

            return;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progress_jogador.Maximum = 10;
            //progress_jogador.ForeColor = Color.Blue;
            progress_pc.Maximum = 10;
            //progress_pc.ForeColor = Color.Red;
        }

        private void radio_facil_CheckedChanged(object sender, EventArgs e)
        {
            progress_jogador.Value = 0;
            progress_pc.Value = 0;
            resetar();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            msg_1.Text = "";
        }
    }
}
