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
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1G4DC21\SQLEXPRESS; integrated security=SSPI; initial catalog=db_serverphdownloader");
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

        //---------------------- VARIÁVEIS PARA LIMPAR/DESABILITAR OS CAMPOS ----------------
        public void limparCampos()
        {
            txtNomeUsuario.Text = "";
        }


        //------------------------ BOTÃO CADASTRAR ------------------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //---- Validação se os campos estão vazios ou em branco
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }
            else if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }
            else if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }


            //----- Select do SQL no Banco de Dados
            try
            {
                //---- Abrir a conexão com o banco
                cn.Open();

                string strSQL = "Select * from dbo.clientes where usuario = '" + txtNomeUsuario.Text + "'";
                //---- Use um comando SQL na conexão cn
                cm.Connection = cn;
                //---- O comando SQL será um comando de texto da variável strSQL
                cm.CommandText = strSQL;
                //---- Executando o comando no Banco de Dados na variável dt que receberá toda a tabela "usuário"
                dt = cm.ExecuteReader();
                //---- Se houver linhas com o mesmo usuário digitado, será retornada a mensagem
                if (dt.HasRows) //---HasRows = Verdade que existe linhas iguais?
                {
                    MessageBox.Show("Usuário já cadastrado!", "Calma ai amigão", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //---- Limpar os campos
                    limparCampos();

                    //---- Mudar a cor do texto caso o Usuário já exista
                    lblUsuario.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    if (!dt.IsClosed) { dt.Close(); }
                    //----Informando os campos da tabela clientes e declarando variáveis
                    strSQL = "insert into dbo.clientes(nome_cliente,email,usuario,senha,confirmar_senha)values(@nome,@email,@usuario,@senha1,@senha2)" ;
                    
                    //-------------------------- NOME COMPLETO -------------------------
                    //----Recebendo o texto do campo nome e inserindo na variável
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCompleto.Text;

                    //-------------------------- EMAIL -------------------------
                    //----Recebendo o texto do campo nome e inserindo na variável
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;

                    //-------------------------- USUARIO -------------------------
                    //----Recebendo o texto do campo nome e inserindo na variável
                    cm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtNomeUsuario.Text;

                    //-------------------------- SENHA -------------------------
                    //----Recebendo o texto do campo nome e inserindo na variável
                    cm.Parameters.Add("@senha1", SqlDbType.VarChar).Value = txtSenha.Text;

                    //-------------------------- CONFIRMAR SENHA -------------------------
                    //----Recebendo o texto do campo nome e inserindo na variável
                    cm.Parameters.Add("@senha2", SqlDbType.VarChar).Value = txtConfirmarSenha.Text;



                    //---- Use um comando SQL na conexão cn
                    cm.Connection = cn;
                    //---- O comando SQL será um comando de texto da variável strSQL
                    cm.CommandText = strSQL;
                    //---- Executar o comando
                    cm.ExecuteNonQuery();

                    //---- Mensagem confirmando o cadastro
                    MessageBox.Show("Login criado com sucesso!", "Dados cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //---- Fechando a consulta no banco
                    cm.Parameters.Clear();   
                    
                    //---- Fechar o form quando o login for cadastrado
                    this.Close();
                   
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);              
            }
            finally
            {
                cn.Close();
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
