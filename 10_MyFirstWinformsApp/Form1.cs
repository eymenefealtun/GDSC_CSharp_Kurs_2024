namespace _10_MyFirstWinformsApp
{
    public partial class Form1 : Form
    {
        int _number = 0;

        // CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();

            cBoxFruits.Items.Add("Elma");
            cBoxFruits.Items.Add("Armut");
            cBoxFruits.Items.Add("Muz");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("button works");
            _number++; // _number = _number +1;
            labelNumber.Text = _number.ToString();

        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (_number <= 0)
            {
                MessageBox.Show("Number can not be negative!");
            }
            else
            {
                _number--;
                labelNumber.Text = _number.ToString();
            }

        }

        private void cBoxFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cBoxFruits.SelectedItem.ToString();
            MessageBox.Show(selectedValue);
        }
    }
}