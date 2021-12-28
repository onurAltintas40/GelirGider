using System.Windows.Forms;

namespace GelirGider
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsCikis_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
