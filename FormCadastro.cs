using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhDownloaderV1
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

            //--Centraliza o Form na tela
            this.CenterToScreen();
        }

        //------------------------- BOTÃO FECHAR ---------------------
        private void btnFecharCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------ BOTÃO CADASTRAR ------------------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "Select usuario from dbo.cliente where usuario = " + txtNomeUsuario.Text;
                cm.Connection = cn;
            }
            catch (Exception Erro)
            {

                throw;
            }
        }
    }
}
