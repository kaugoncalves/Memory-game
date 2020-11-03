using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memoria
{
    public partial class Form1 : Form
    {
        Vetor vetImg = new Vetor(-1, 9);
        string foto1 = "moeda.jpg";
        string foto2 = "fantasma.jpg";
        string foto3 = "pokebola.jpg";        
        string foto4 = "controle.jpg";
        string pasta = "";

        string carta1 = "";
        string carta2 = "";
        Button carta1_btn;
        int qntClick = 0;

        int tentativas = 5;
        int acertos = 0;


        //sistema de vitoria ou derrota
        private async void verificaSePerdeu()
        {
            tentativas--;
            lbl_tentativas.Text = "Tentativas: " + tentativas;
            if(tentativas <= 0)
            {
                MessageBox.Show("Você perdeu!");
                await Task.Delay(1000);
                Form1 novoForm = new Form1();
                novoForm.Show();
                this.Dispose(false);               
            }
        }
        private async void verificaSeGanhou()
        {
            acertos++;            
            if (acertos >= 4)
            {
                MessageBox.Show("Você ganhou!");
                await Task.Delay(1000);
                Form1 novoForm = new Form1();
                novoForm.Show();
                this.Dispose(false);
            }
        }
        public Form1()
        {
            InitializeComponent();
            pasta = "./Imagens/";
        }

       
        private async void btn1_Click(object sender, EventArgs e)
        {          
            btn1.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(1));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(1);                
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn1.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }

                else
                {
                    //caso ele acerte, desativa os dois botoes
                    verificaSeGanhou();
                    btn1.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
                qntClick = 0;
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(1);
                
                carta1_btn = btn1;
                qntClick++;
            }

            

           




        }

        private void button10_Click(object sender, EventArgs e)
        {         
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto1);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto1);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto2);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto2);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto3);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto3);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto4);
            vetImg.insereDadoNoVetor(vetImg.sortearNumero(), foto4);

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
        }

        private async void btn2_Click(object sender, EventArgs e)
        {
            
            btn2.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(2));
            
            if (qntClick == 1)
            {
                qntClick = 0;                
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(2);                
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn2.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }

                else 
                {
                    verificaSeGanhou();
                    btn2.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";                    
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(2);                
                carta1_btn = btn2;
                qntClick++;
            }
            
           
        }

        private async void btn7_Click(object sender, EventArgs e)
        {
            btn7.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(7));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(7);               
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn7.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";

                }

                else
                {
                    verificaSeGanhou();
                    btn7.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(7);               
                carta1_btn = btn7;
                qntClick++;
            }
            
            
        }

        private async void btn6_Click(object sender, EventArgs e)
        {
            btn6.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(6));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(6);                
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn6.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }
                else
                {
                    verificaSeGanhou();
                    btn6.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(6);               
                carta1_btn = btn6;
                qntClick++;
            }
            
            
        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            btn3.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(3));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(3);               
                bool verficacao = vetImg.verificar(carta1, carta2);
                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn3.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }      
                
                else
                {
                    verificaSeGanhou();
                    btn3.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(3);
                
                carta1_btn = btn3;
                qntClick++;
            }
            
            
        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            btn4.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(4));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(4);               
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn4.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }

                else
                {
                    verificaSeGanhou();
                    btn4.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(4);                
                carta1_btn = btn4;
                qntClick++;
            }
           
           
        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            btn5.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(5));

            if (qntClick == 1)
            {
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(5);
               
                bool verficacao = vetImg.verificar(carta1, carta2);
                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn5.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }

                else
                {
                    verificaSeGanhou();
                    btn5.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(5);                
                carta1_btn = btn5;
                qntClick++;
            }
           
            
        }

        private async void btn8_Click(object sender, EventArgs e)
        {
            btn8.Image = Image.FromFile(pasta + vetImg.RetornaConteudoDoVetorPosicaoEspecifica(8));

            if (qntClick == 1)
            {               
                qntClick = 0;
                carta2 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(8);                
                bool verficacao = vetImg.verificar(carta1, carta2);

                if (verficacao == false)
                {
                    verificaSePerdeu();
                    await Task.Delay(500);
                    btn8.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn.Image = Image.FromFile(pasta + "fundo.jpg");
                    carta1_btn = null;
                    carta2 = "";
                }

                else
                {
                    verificaSeGanhou();
                    btn8.Enabled = false;
                    carta1_btn.Enabled = false;
                    carta1 = "";
                    carta1_btn = null;
                    carta2 = "";
                }
            }

            else
            {
                carta1 = vetImg.RetornaConteudoDoVetorPosicaoEspecifica(8);          
                carta1_btn = btn8;
                qntClick++;
            }
           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
