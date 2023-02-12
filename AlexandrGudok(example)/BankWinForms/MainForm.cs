using System;
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

            SettingsDGV_Debitors();
            dgv_SetVisualStyle(dgv_debitors);
            dgv_SetVisualStyle(dgv_credits);
            //dgv_debitors.CellEnter += dgv_DebitorsClickEvent;


        }

        void SettingsDGV_Debitors()
        {
            foreach (string ClmnName in new ArrayList() { "ID", "PostNumber", "PhoneNumber" })
            {
                dgv_debitors.Columns[ClmnName].Visible = false;
            }




        }

        void dgv_SetVisualStyle(DataGridView dgvVisual)
        {

            dgvVisual.TopLeftHeaderCell.Value = "#";
            dgvVisual.RowHeadersWidth = 25;
            dgvVisual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }


        void dgv_DebitorsClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            txbx_debitorID.Text = dgv_debitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbx_debitorName.Text = dgv_debitors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            txbx_debitorPostNumber.Text = dgv_debitors.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
            string phoneNumber = dgv_debitors.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            phoneNumber = (phoneNumber == String.Empty) ? "Нет данных" : phoneNumber;
            txbx_phoneNumber.Text = phoneNumber;

            dgv_credits.DataSource = dal.GetAllCreditsForDebitor(dgv_debitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_debitors.CellEnter += new DataGridViewCellEventHandler(dgv_DebitorsClickEvent);

        }
    }
}
