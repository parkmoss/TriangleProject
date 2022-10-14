using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianglesProject
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
            sidesBindingSource.DataSource = new Triangle();
        }

        // Decided to check validation on key up instead of binding source current changed to allow us to start with a null input box without getting an error
        // also allows us to check which error belongs to which textbox a bit easier
        private void SideATextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Prevented checking for tab because key up will be hit in the next textbox giving an error before anything was typed
            if (e.KeyCode == Keys.Tab) return;
            ValidationCheck(SideATextBox, SideAError, "sideA");
        }

        // Added a leave focus check as well to check for when user presses tab or clicks into different textbox
        private void SideATextBox_Leave(object sender, EventArgs e)
        {
            ValidationCheck(SideATextBox, SideAError, "sideA");
        }

        private void SideBTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) return;
            ValidationCheck(SideBTextBox, SideBError, "sideB");
        }

        private void SideBTextBox_Leave(object sender, EventArgs e)
        {
            ValidationCheck(SideBTextBox, SideBError, "sideB");
        }

        private void SideCTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) return;
            ValidationCheck(SideCTextBox, SideCError, "sideC");
        }

        private void SideCTextBox_Leave(object sender, EventArgs e)
        {
            ValidationCheck(SideCTextBox, SideCError, "sideC");
        }

        // Checks if input is valid and provides error message if not
        private void ValidationCheck(TextBox sideTextBox, Label errorLabel, string sideName)
        {
            // Resets the labels everytime we validate
            errorLabel.Text = null;
            ResultLabel.Text = null;
            ResultLabel.ForeColor = Color.Black;
            AngleAResultLabel.Text = null;
            AngleBResultLabel.Text = null;
            AngleCResultLabel.Text = null;

            sidesBindingSource.EndEdit();
            Triangle triangle = sidesBindingSource.Current as Triangle;
            ValidationContext context = new ValidationContext(triangle, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            
            if (!Validator.TryValidateObject(triangle, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    // Checks if the error belongs the the side we are validating
                    foreach (string member in result.MemberNames)
                    {
                        if (sideName == member) errorLabel.Text = result.ErrorMessage;
                    }
                }
            }
            else
            {
                if (triangle.ValidTriangle()) 
                { 
                    ResultLabel.Text = $"The given sides make a {triangle.triangleType} triangle.";

                    AngleAResultLabel.Text = $"{triangle.angleA} degrees";
                    AngleBResultLabel.Text = $"{triangle.angleB} degrees";
                    AngleCResultLabel.Text = $"{triangle.angleC} degrees";
                }
                else
                {
                    ResultLabel.ForeColor = Color.Red;
                    ResultLabel.Text = "The given sides do not make a valid triangle.";
                }
            }
        }
    }
}
