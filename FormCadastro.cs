using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhDownloaderV1
{
    public partial class FormCadastro : Form
    {
        //--Variável criada para mover a tela sem bordas
        bool mover = false;
        Point posicaoInicial;

        public FormCadastro()
        {
            InitializeComponent();

            //--Centraliza o Form na tela
            this.CenterToScreen();
        }


        //------------------------ CONEXÃO SQL -------------------
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-0K1VNAB\SQLEXPRESS; integrated security=SSPI; initial catalog=db_servidor");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        //------------------------- BOTÃO FECHAR ---------------------
        private void btnFecharCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------- MOVER JANELA ---------------------------

        //--Evento MouseDown (Quando clicar e segurar na janela)
        private void FormCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicaoInicial = new Point(e.X, e.Y);
        }

        //--Evento MouseUp (Quando terminamos o movimento da Janela)
        private void FormCadastro_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //--Evento MouseMove (Mover a Janela)
        private void FormCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicaoInicial.X, novo.Y - this.posicaoInicial.Y);
            }
        }

        //------------------------ BOTÃO CADASTRAR ------------------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "Select usuario from dbo.cliente where usuario = " + txtNomeUsuario.Text;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                cn.Open();
            }
            catch (Exception Erro)
            {

            }
            finally 
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        //---------------------------- LOAD ----------------------------
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            lblSenhaNaoConfere.Visible = false;
        }


        //---------------------------- CAMPO SENHA ----------------------------
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            //--Deixar a senha oculta
            txtSenha.PasswordChar = '*';
        }

        //--------------------------- CAMPO CONFIRMAR SENHA -------------------
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            //--Deixar a senha oculta
            txtConfirmarSenha.PasswordChar = '*';

            //--Apresentar a mensagem caso as senhas estejam diferentes
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblSenhaNaoConfere.Visible = true;
            }
            else
            {
                lblSenhaNaoConfere.Visible = false;
            }
        }
    }
}
