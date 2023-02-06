using System.Collections;
using System.Windows.Forms;

namespace BankWinForms
{
    public partial class MainForm : Form
    {
        private DAL dal = new DAL();

        public MainForm()
        {
            InitializeComponent();

            ArrayList allDebitors = dal.GetAllDebitors();

            dgv_debitors.DataSource = allDebitors;
        }
    }
}
