/*
 * Victor Perdue
 * Activity 1
 * 1/17/2025
 */
namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!!!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
