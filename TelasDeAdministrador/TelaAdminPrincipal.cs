namespace Pim3_2025.Telas_De_Administrador
{
    public partial class TelaAdminPrincipal : Form
    {
        public TelaAdminPrincipal()
        {
            InitializeComponent();
        }

        private void lblBiblioteca_Click(object sender, EventArgs e)
        {
            UcBibliotecaAdm ucBibliotecaAdm = new UcBibliotecaAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucBibliotecaAdm);
        }

        private void lblCadastroLivros_TelaAdm_Click(object sender, EventArgs e)
        {
            UcCadastroLivroAdm ucCadastroLivroAdm = new UcCadastroLivroAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucCadastroLivroAdm);
        }

        private void lblCadastroCliente_TelaAdm_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastroCliente_TelaAdm_Click_1(object sender, EventArgs e)
        {
            UcCadastroPessoaAdm ucCadastroPessoaAdm = new UcCadastroPessoaAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucCadastroPessoaAdm);
        }

        private void lblEmprestimo_TelaAdm_Click(object sender, EventArgs e)
        {
            UcEmprestadoAdm ucEmprestadoAdm = new UcEmprestadoAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucEmprestadoAdm);
        }
    }
}
