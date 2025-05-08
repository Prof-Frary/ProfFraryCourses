namespace ProfFraryCourses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // prepopulating the department combobox
            cboDept.Items.Add("BUS");
            cboDept.Items.Add("CIS");
            cboDept.Items.Add("ENG");
            cboDept.Items.Add("MAT");
            cboDept.Text = "ENG";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // no error checking
            Course c = new Course(cboDept.Text,
                txtCrsNum.Text,
                txtCrsName.Text,
                (int)numUDCredits.Value);
            lstOut.Items.Add(c);
            lstOut.Items.Add(c.DeptID);

        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
