using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha__Gui_
{
    class Tabuleiro
    {
        public int c1 { get; set; }
        public int c2 { get; set; }
        public int c3 { get; set; }
        public int c4 { get; set; }
        public int c5 { get; set; }
        public int c6 { get; set; }
        public int c7 { get; set; }
        public int c8 { get; set; }
        public int c9 { get; set; }

        public Tabuleiro(int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8, int c9)
        {
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.c4 = 0;
            this.c5 = 0;
            this.c6 = 0;
            this.c7 = 0;
            this.c8 = 0;
            this.c9 = 0;
        }

        public void ResetarTabuleiro()
        {
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.c4 = 0;
            this.c5 = 0;
            this.c6 = 0;
            this.c7 = 0;
            this.c8 = 0;
            this.c9 = 0;
        }

        public int MovAvancado() //ainda n tá perfeito. tenho que ver a prioridade das jogadas possiveis.
        {
            int aleat;
            Random rand = new Random();
            aleat = rand.Next(1, 10);


            // ---------------------- //OFENSIVO // --------------------//
            //primeira linha - horizontal 


            if (c1 == 2 && c1 == c2 && c3 == 0) { return 3; }
            if (c2 == 2 && c2 == c3 && c1 == 0) { return 1; }
            if (c1 == 2 && c1 == c3 && c2 == 0) { return 2; }

            //segunda linha - horizontal 

            if (c4 == 2 && c4 == c5 && c6 == 0) { return 6; }
            if (c5 == 2 && c5 == c6 && c4 == 0) { return 4; }
            if (c4 == 2 && c4 == c6 && c5 == 0) { return 5; }

            //terceira linha horizontal

            if (c7 == 2 && c7 == c8 && c9 == 0) { return 9; }
            if (c8 == 2 && c8 == c9 && c7 == 0) { return 7; }
            if (c7 == 2 && c7 == c9 && c8 == 0) { return 8; }

            //primeira linha - vertical

            if (c1 == 2 && c1 == c4 && c7 == 0) { return 7; }
            if (c4 == 2 && c4 == c7 && c1 == 0) { return 1; }
            if (c1 == 2 && c1 == c7 && c4 == 0) { return 4; }

            //segunda linha - vertical 

            if (c2 == 2 && c2 == c5 && c8 == 0) { return 8; }
            if (c5 == 2 && c5 == c8 && c2 == 0) { return 2; }
            if (c2 == 2 && c2 == c8 && c5 == 0) { return 5; }

            //terceira linha vertical

            if (c3 == 2 && c3 == c6 && c9 == 0) { return 9; }
            if (c6 == 2 && c6 == c9 && c3 == 0) { return 3; }
            if (c3 == 2 && c3 == c9 && c6 == 0) { return 6; }

            //primeira linha - diagonal

            if (c1 == 2 && c1 == c5 && c9 == 0) { return 9; }
            if (c5 == 2 && c5 == c9 && c1 == 0) { return 1; }
            if (c1 == 2 && c1 == c9 && c5 == 0) { return 5; }

            //segunda linha - diagonal

            if (c3 == 2 && c3 == c5 && c7 == 0) { return 7; }
            if (c5 == 2 && c5 == c7 && c3 == 0) { return 3; }
            if (c3 == 2 && c3 == c7 && c5 == 0) { return 5; }


            //---------------------- //DEFENSIVO// -----------------//

            //primeira linha - horizontal

            if (c1 == 1 && c1 == c2 && c3 == 0) { return 3; }
            if (c2 == 1 && c2 == c3 && c1 == 0) { return 1; }
            if (c1 == 1 && c1 == c3 && c2 == 0) { return 2; }

            //segunda linha - horizontal 

            if (c4 == 1 && c4 == c5 && c6 == 0) { return 6; }
            if (c5 == 1 && c5 == c6 && c4 == 0) { return 4; }
            if (c4 == 1 && c4 == c6 && c5 == 0) { return 5; }

            //terceira linha horizontal

            if (c7 == 1 && c7 == c8 && c9 == 0) { return 9; }
            if (c8 == 1 && c8 == c9 && c7 == 0) { return 7; }
            if (c7 == 1 && c7 == c9 && c8 == 0) { return 8; }

            //primeira linha - vertical

            if (c1 == 1 && c1 == c4 && c7 == 0) { return 7; }
            if (c4 == 1 && c4 == c7 && c1 == 0) { return 1; }
            if (c1 == 1 && c1 == c7 && c4 == 0) { return 4; }

            //segunda linha - vertical 

            if (c2 == 1 && c2 == c5 && c8 == 0) { return 8; }
            if (c5 == 1 && c5 == c8 && c2 == 0) { return 2; }
            if (c2 == 1 && c2 == c8 && c5 == 0) { return 5; }

            //terceira linha vertical

            if (c3 == 1 && c3 == c6 && c9 == 0) { return 9; }
            if (c6 == 1 && c6 == c9 && c3 == 0) { return 3; }
            if (c3 == 1 && c3 == c9 && c6 == 0) { return 6; }

            //primeira linha - diagonal

            if (c1 == 1 && c1 == c5 && c9 == 0) { return 9; }
            if (c5 == 1 && c5 == c9 && c1 == 0) { return 1; }
            if (c1 == 1 && c1 == c9 && c5 == 0) { return 5; }

            //segunda linha - diagonal

            if (c3 == 1 && c3 == c5 && c7 == 0) { return 7; }
            if (c5 == 1 && c5 == c7 && c3 == 0) { return 3; }
            if (c3 == 1 && c3 == c7 && c5 == 0) { return 5; }

           

            //---------------------- //OFENSIVO 2 Casas livres// -----------------//conferir

            //primeira linha - horizontal 
            if (c1 == 2 && c2 == 0 && c2 == c3) { return 3; }
            if (c2 == 2 && c1 == 0 && c1 == c3) { return 1; }
            if (c3 == 2 && c1 == 0 && c1 == c2) { return 2; }
            //segunda linha - horizontal 
            if (c4 == 2 && c5 == 0 && c5 == c6) { return 5; }
            if (c5 == 2 && c4 == 0 && c4 == c6) { return 6; }
            if (c6 == 2 && c4 == 0 && c4 == c5) { return 4; }
            //terceira linha horizontal
            if (c7 == 2 && c8 == 0 && c8 == c9) { return 8; }
            if (c8 == 2 && c9 == 0 && c7 == c9) { return 9; }
            if (c9 == 2 && c7 == 0 && c8 == c5) { return 7; }
            //primeira linha - vertical
            if (c1 == 2 && c4 == 0 && c7 == c4) { return 4; }
            if (c4 == 2 && c1 == 0 && c7 == c1) { return 7; }
            if (c7 == 2 && c1 == 0 && c4 == c1) { return 1; }
            //segunda linha - vertical             
            if (c2 == 2 && c5 == 0 && c8 == c5) { return 5; }
            if (c5 == 2 && c2 == 0 && c2 == c8) { return 8; }
            if (c8 == 2 && c2 == 0 && c5 == c2) { return 2; }
            //terceira linha vertical
            if (c3 == 2 && c6 == 0 && c9 == c6) { return 6; }
            if (c6 == 2 && c3 == 0 && c3 == c9) { return 9; }
            if (c9 == 2 && c3 == 0 && c6 == c3) { return 3; }
            //primeira linha - diagonal
            if (c1 == 2 && c5 == 0 && c9 == c5) { return 5; }
            if (c5 == 2 && c1 == 0 && c1 == c9) { return 9; }
            if (c9 == 2 && c1 == 0 && c5 == c1) { return 1; }
            //segunda linha - diagonal
            if (c3 == 2 && c5 == 0 && c7 == c5) { return 5; }
            if (c5 == 2 && c7 == 0 && c3 == c7) { return 7; }
            if (c7 == 2 && c3 == 0 && c5 == c3) { return 3; }


            else
            {
                return aleat;
            }
        }

        public int VerResultado() //confere as condições de vitória e retorna quem venceu. (1) jogador (2) pc
        {
            if (c1 != 0 && c1 == c2 && c1 == c3)
            {
                 if (c1 == 1)
                {
                   // MessageBox.Show("c1 == c2 && c1 == c3" );
                    return 1;
                }
                else
                {
                    return 2;
                }
            }


            else if (c4 != 0 && c4 == c5 && c4 == c6)
            {
                if (c4 == 1)
                {
                   // MessageBox.Show( "c4 == c5 && c4 == c6" );
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (c7 != 0 && c7 == c8 && c8 == c9)
            {
                if (c7 == 1)
                {
                    //MessageBox.Show("c7 == c8 && c8 == c9");
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //vertical

            else if (c1 != 0 && c1 == c4 && c1 == c7)
            {
                if (c1 == 1)
                {
                   // MessageBox.Show("c1 == c4 && c1 == c7");
                    return 1;
                }
                else
                {
                   
                    return 2;
                }
            }
            else if (c2 != 0 && c2 == c5 && c2 == c8)
            {
                if (c2 == 1)
                {
                  //  MessageBox.Show( "c2 == c5 && c2 == c8" );
                    return 1;
                }
                else
                {
                    return 2;
                }

            }
            else if (c3 != 0 && c3 == c6 && c3 == c9)
            {
                if (c3 == 1)
                {
                 //   MessageBox.Show("c3 == c6 && c3 == c9");
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //diagonal
            else if (c1 != 0 && c1 == c5 && c1 == c9)
            {
                if (c1 == 1)
                {
                  //  MessageBox.Show("c1 == c5 && c1 == c9");
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (c3 != 0 && c3 == c5 && c3 == c7)
            {
                if (c3 == 1)
                {
                  //  MessageBox.Show("c3 == c5 && c3 == c7");
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }

    }
}
