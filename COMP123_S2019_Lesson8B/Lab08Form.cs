using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab08Form : Form
    {
        //properties
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the constructor if Lab08
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the Submitbutton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTexBox.Text;

            UserAge = float.Parse(textBox1.Text);

            OutputLabel.Text = NameTexBox.Text + " " + textBox1.Text;

            ClearForm();
        }
        /// <summary>
        /// This method clear the text box on the form
        /// </summary>
        private void ClearForm()
        {
            NameTexBox.Clear();
            textBox1.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox TextCHange Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //simple output validation
                try
                {
                    float.Parse(textBox1.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    SubmitButton.Enabled = false;
                }
                
            
        }
        private void Lab08Form_Load(object sender,EventArgs e)
        {
            ClearForm();
        }
private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the Event handler for the Nametextbox text change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTexBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTexBox.Text.Length < 2) ? false : true;
        }
    }
}
