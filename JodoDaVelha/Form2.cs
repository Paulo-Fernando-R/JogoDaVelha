using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JodoDaVelha
{
    public partial class Form2 : Form
    {
        int cont;
        int xp, op, em = 0;
        int[] num = new int[9] {-1,-1,-1,-1,-1,-1,-1,-1,-1};
        bool fim = false;
        public Form2()
        {
            InitializeComponent();
            cont = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            int bi = btn.TabIndex;
            if (fim == false)
            {


                if (cont % 2 == 0 )
                {
                    btn.BackgroundImage = Image.FromFile(@"C:\Users\ferna\Desktop\E lá vamos nós de novo\LP2\JodoDaVelha\JodoDaVelha\Resources\bola.png");
                    num[bi] = 0;
                    check(0);
                }
                else
                {
                    btn.BackgroundImage = Image.FromFile(@"C:\Users\ferna\Desktop\E lá vamos nós de novo\LP2\JodoDaVelha\JodoDaVelha\Resources\x.png");
                    num[bi] = 1;
                    check(1);
                }
                btn.Enabled = false;
                cont++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 0;
            num = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            fim = false;

            button1.BackgroundImage = null;
            button1.Enabled = true;
            button10.BackgroundImage = null;
            button10.Enabled = true;
            button11.BackgroundImage = null;
            button11.Enabled = true;
            button12.BackgroundImage = null;
            button12.Enabled = true;
            button13.BackgroundImage = null;
            button13.Enabled = true;
            button14.BackgroundImage = null;
            button14.Enabled = true;
            button15.BackgroundImage = null;
            button15.Enabled = true;
            button16.BackgroundImage = null;
            button16.Enabled = true;
            button17.BackgroundImage = null;
            button17.Enabled = true;


        }

        private void check(int player)
        {
            for(int i = 0; i<8; i+=3)
            {
                
                if(player == num[i])
                {
                    if((num[i] == num[i + 1]) && (num[i] == num[i+2]))
                    {
                        winner(player);
                        fim = true;
                        return;
                    }
                }
            }


            for (int i = 0; i <= 2; i ++)
            {

                if (player == num[i])
                {
                    if ((num[i] == num[i + 3]) && (num[i] == num[i + 6]))
                    {
                        winner(player);
                        fim = true;
                        return;
                    }
                }
            }



            if (player == num[0])
            {
                if ((num[0] == num[4]) && (num[0] == num[8]))
                {
                    winner(player);
                    fim = true;
                    return;
                }
            }


            if (player == num[0])
            {
                if ((num[0] == num[4]) && (num[0] == num[8]))
                {
                    winner(player);
                    fim = true;
                    return;
                }
            }


            if (player == num[2])
            {
                if ((num[2] == num[4]) && (num[2] == num[6]))
                {
                    winner(player);
                    fim = true;
                    return;
                }
            }

            if (cont == 8  && fim == false)
            {
                em++;
                emp.Text = Convert.ToString(em);
                MessageBox.Show("EMPATE");
                fim = true;
                return;
            }


            // MessageBox.Show("a " + player);
            //   MessageBox.Show("a" + num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] + num[7] + num[8]);

        }

        private void winner(int win)
        {
            
            

            if(win == 0)
            {
                MessageBox.Show("JOGADOR 1 GANHOU");
                op++;
                j1P.Text = Convert.ToString(op);

            }
            else
            {
                MessageBox.Show("JOGADOR 2 GANHOU");
                xp++;
                j2P.Text = Convert.ToString(xp);
            }
        }

    }
}
