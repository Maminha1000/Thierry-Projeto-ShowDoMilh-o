using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FrmP1 : Form
    {

        //Variavel para atribuir o ponto
        int Cont = 0;

        //Recebe a informação com o Nick do usuario
        public FrmP1(string Nick)
        {
            InitializeComponent();
            label2.Text = Nick;

        }

       

        //Button é chamado, atribui 1 ponto caso a reposta esteja correta e mostra a alternativa exata
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                radioButton5.Visible = true;
               
                
            }
            if (radioButton2.Checked)
            {
                radioButton5.Visible = true;
                

            }
            if (radioButton3.Checked)
            {
                radioButton5.Visible = true;
                Cont++;

            }
            if (radioButton4.Checked)
            {

                radioButton5.Visible = true;
               



            }

            label5.Text = Convert.ToString(Cont);

                button1.Visible = false;
                button2.Visible = true;
            


        }

        //Guarda Nick e Ponto do usuario e manda para proxima tela
        private void Button2_Click(object sender, EventArgs e)
        {

                var form = new FrmP2(label2.Text, label5.Text);
                form.Show();
                this.Visible = false;


            

        }

       
    }
}

