using Pim3_2025.TelasDeBibliotecario;

namespace Pim3_2025
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            TelaBibliotecarioPrincipal telaPrincipal = new TelaBibliotecarioPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }

        private void lblClickAquiCadastro_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
