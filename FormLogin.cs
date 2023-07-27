using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhDownloaderV1
{
    public partial class FormLogin : Form
    {

        //--Variável criada para mover a tela sem bordas
        bool mover = false;
        Point posicaoInicial;

        public FormLogin()
        {
            InitializeComponent();

            //--Centraliza o Form na tela
            this.CenterToScreen();
        }

        //------------------------ CONEXÃO SQL -------------------
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1G4DC21\SQLEXPRESS; integrated security=SSPI; initial catalog=db_serverphdownloader");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        //--------------------------  BOTÃO FECHAR ----------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------- MOVER JANELA ---------------------------

        //--Evento MouseDown (Quando clicar e segurar na janela)
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicaoInicial = new Point(e.X, e.Y);
        }

        //--Evento MouseUp (Quando terminamos o movimento da Janela)
        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //--Evento MouseMove (Mover a Janela)
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicaoInicial.X, novo.Y - this.posicaoInicial.Y);
            }
        }

        //-------------------------- BOTÃO FECHAR --------------------------------
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------- CAMPO SENHA ---------------------------------
        private void textboxSenha_TextChanged(object sender, EventArgs e)
        {
            //--Deixar a senha oculta
            textboxSenha.PasswordChar = '*';
        }

        private void lblInscrevase_Click(object sender, EventArgs e)
        {
            FormCadastro Cadastro = new FormCadastro();
            Cadastro.ShowDialog();
        }

    }
}
