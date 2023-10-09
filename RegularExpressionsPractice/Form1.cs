using System.Text.RegularExpressions;

namespace RegularExpressionsPractice
{
    public partial class Form1 : Form
    {
        String expression;
        String[] examples = {
            "[0-9]{3}\\.[0-9]{2}",
            "[0-9]{3}[.][0-9]{3}",
            "\\d{1}[,]\\d{1}[,]\\d{1}[,]\\d{1}",
            "\\A(lunes|martes|miercoles|jueves|viernes|sabado|domingo)\\s\\d{1,2}",
            "\\AES\\d{2}[-]\\d{4}[-]\\d{4}[-]\\d{2}[-]\\d{10}\\Z",
            "\\A([0-1]\\d|2[0-3])[:][0-5]\\d([:][0-5]\\d)?\\Z",
            "\\A(0|[+-]?[1-9])\\Z",
            "\\A\\d{8}[-][TRWAGMYGFPDXBNJZSQVHLCKE]\\Z",
            "\\A(([1-9]?\\d|1\\d{2}|2[0-4]\\d|25[0-5])[.]){3}([1-9]?\\d|1\\d{2}|2[0-4]\\d|25[0-5])\\Z",
            "\\A\\d{4}\\s?[A-Z]{3}\\Z",
            "\\\\A(([-]?\\d+[.]?\\d+)|([-]?\\d+[,]?\\d+))\\Z",
            "\\A(\\d|[1-2]\\d|3[0-1])[/](\\d|1[0-2])[/]\\d{4}\\Z",
            "\\A(([a-zA-z]+\\s[a-zA-z]+)|([a-zA-z]+))\\Z",
            "\\A@\\w+\\Z",
            "\\A(978|979)[-]\\d{2}[-]\\d{4}[-]\\d{3}[-]\\d\\Z",
            "\\A(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,12}\\Z"
            };

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegularExpresion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            expression = txtRegularExpression.Text.Trim();
            String str = txtString.Text;
            Regex regExp = new Regex(expression);
            if (regExp.Match(str).Success)
            {
                MessageBox.Show("Correct!","You are a machine!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect!", "You are a shit!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            txtRegularExpression.Text = examples[cboTest.SelectedIndex];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < examples.Length; i++)
            {
                cboTest.Items.Add(i.ToString());
            }
            
        }
    }
}