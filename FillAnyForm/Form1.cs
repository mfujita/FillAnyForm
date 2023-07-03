namespace FillAnyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection styles = tableLayoutPanel1.ColumnStyles;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;


            this.Location = new System.Drawing.Point(0, 0);
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Height = Height;
            tableLayoutPanel1.Height = Height;
        }

        private void btnGerarCampos_Click(object sender, EventArgs e)
        {
            List<string> listData = new List<string>();

            //foreach (var item in tableLayoutPanel1.Controls.OfType<TextBox>())
            //    listData.Add(item.Text);
            listData.Add(txtNome.Text);
            listData.Add(txtCpf.Text);
            listData.Add(txtDtNascimento.Text);
            listData.Add(txtNomeMae.Text);
            listData.Add(txtNomePai.Text);
            listData.Add(txtNaturalidade.Text);
            listData.Add(txtIdentidade.Text);
            listData.Add(txtOrgaoEmissor.Text);
            listData.Add(txtDtExpedicao.Text);
            listData.Add(txtLogradouro.Text);
            listData.Add(txtNumero.Text);
            listData.Add(txtComplemento.Text);
            listData.Add(txtBairro.Text);
            listData.Add(txtCep.Text);
            listData.Add(txtCidade.Text);
            listData.Add(txtEmail.Text);
            listData.Add(txtTelefoneCelular.Text);
            listData.Add(txtTelefoneResidencial.Text);

            OrganizadorCampos oc = new OrganizadorCampos(listData);
            oc.Show();
        }
    }
}