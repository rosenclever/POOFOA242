namespace IntroducaoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            MessageBox.Show($"Ol� Mundo! Seja benvindo {nome}");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnClique.Enabled = true;
        }
    }
}
