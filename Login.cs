using Pim3_2025.Telas_De_Administrador;
using Pim3_2025.TelasDeBibliotecario;
using Pim3_2025.TelasDeUsuario;

namespace Pim3_2025
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string codigo = txbCodigoFuncionarioLogin.Text.Trim();
            string usuario = txbUsuarioLogin.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                TelaUsuarioPrincipal telaUsuarioPrincipal = new TelaUsuarioPrincipal();
                telaUsuarioPrincipal.Show();
                this.Hide();
            }
            else if (codigo == "admin")
            {
                TelaAdminPrincipal telaAdminPrincipal = new TelaAdminPrincipal();
                telaAdminPrincipal.Show();
                this.Hide();
            }
            else if (codigo == "#123")
            {
                TelaBibliotecarioPrincipal telaBibliotecarioPrincipal = new TelaBibliotecarioPrincipal();
                telaBibliotecarioPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Entrada Invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void lblClickaAquiLogin_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
    }
}
