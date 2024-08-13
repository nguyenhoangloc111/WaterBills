namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Invoice invoiceManager;
        public Form1()
        {
            InitializeComponent();

            invoiceManager = new Invoice();

            addInvoices.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;

            addInvoices.Show();
            manageInvoices.Hide();
        }

        private void addInvoices1_Load(object sender, EventArgs e)
        {

        }

        private void manageInvoices_Load(object sender, EventArgs e)
        {

        }

        private void managesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            manageInvoices.Show();
            addInvoices.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoices.Show();
        }
    }
}
