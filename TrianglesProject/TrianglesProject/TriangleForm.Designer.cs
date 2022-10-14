using System.Windows.Forms;

namespace TrianglesProject
{
    partial class TriangleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.sidesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.SideAError = new System.Windows.Forms.Label();
            this.SideBError = new System.Windows.Forms.Label();
            this.SideCError = new System.Windows.Forms.Label();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AngleALabel = new System.Windows.Forms.Label();
            this.AngleBLabel = new System.Windows.Forms.Label();
            this.AngleCLabel = new System.Windows.Forms.Label();
            this.AngleAResultLabel = new System.Windows.Forms.Label();
            this.AngleBResultLabel = new System.Windows.Forms.Label();
            this.AngleCResultLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sidesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SideATextBox
            // 
            this.SideATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sidesBindingSource, "sideA", true));
            this.SideATextBox.Location = new System.Drawing.Point(99, 67);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(86, 20);
            this.SideATextBox.TabIndex = 0;
            this.SideATextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SideATextBox_KeyUp);
            this.SideATextBox.Leave += new System.EventHandler(this.SideATextBox_Leave);
            // 
            // sidesBindingSource
            // 
            this.sidesBindingSource.DataSource = typeof(TrianglesProject.Triangle);
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(27, 74);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(72, 13);
            this.SideALabel.TabIndex = 1;
            this.SideALabel.Text = "Side a length:";
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(27, 99);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(72, 13);
            this.SideBLabel.TabIndex = 2;
            this.SideBLabel.Text = "Side b length:";
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sidesBindingSource, "sideB", true));
            this.SideBTextBox.Location = new System.Drawing.Point(99, 92);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(86, 20);
            this.SideBTextBox.TabIndex = 3;
            this.SideBTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SideBTextBox_KeyUp);
            this.SideBTextBox.Leave += new System.EventHandler(this.SideBTextBox_Leave);
            // 
            // SideCLabel
            // 
            this.SideCLabel.AutoSize = true;
            this.SideCLabel.Location = new System.Drawing.Point(27, 124);
            this.SideCLabel.Name = "SideCLabel";
            this.SideCLabel.Size = new System.Drawing.Size(72, 13);
            this.SideCLabel.TabIndex = 4;
            this.SideCLabel.Text = "Side c length:";
            // 
            // SideCTextBox
            // 
            this.SideCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sidesBindingSource, "sideC", true));
            this.SideCTextBox.Location = new System.Drawing.Point(99, 117);
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.Size = new System.Drawing.Size(86, 20);
            this.SideCTextBox.TabIndex = 5;
            this.SideCTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SideCTextBox_KeyUp);
            this.SideCTextBox.Leave += new System.EventHandler(this.SideCTextBox_Leave);
            // 
            // SideAError
            // 
            this.SideAError.AutoSize = true;
            this.SideAError.ForeColor = System.Drawing.Color.Red;
            this.SideAError.Location = new System.Drawing.Point(190, 74);
            this.SideAError.Name = "SideAError";
            this.SideAError.Size = new System.Drawing.Size(0, 13);
            this.SideAError.TabIndex = 6;
            // 
            // SideBError
            // 
            this.SideBError.AutoSize = true;
            this.SideBError.ForeColor = System.Drawing.Color.Red;
            this.SideBError.Location = new System.Drawing.Point(190, 99);
            this.SideBError.Name = "SideBError";
            this.SideBError.Size = new System.Drawing.Size(0, 13);
            this.SideBError.TabIndex = 7;
            // 
            // SideCError
            // 
            this.SideCError.AutoSize = true;
            this.SideCError.ForeColor = System.Drawing.Color.Red;
            this.SideCError.Location = new System.Drawing.Point(190, 124);
            this.SideCError.Name = "SideCError";
            this.SideCError.Size = new System.Drawing.Size(0, 13);
            this.SideCError.TabIndex = 8;
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.AutoSize = true;
            this.ResultTextLabel.Location = new System.Drawing.Point(27, 170);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultTextLabel.TabIndex = 9;
            this.ResultTextLabel.Text = "Result:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(61, 170);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 10;
            // 
            // AngleALabel
            // 
            this.AngleALabel.AutoSize = true;
            this.AngleALabel.Location = new System.Drawing.Point(27, 191);
            this.AngleALabel.Name = "AngleALabel";
            this.AngleALabel.Size = new System.Drawing.Size(47, 13);
            this.AngleALabel.TabIndex = 11;
            this.AngleALabel.Text = "Angle A:";
            // 
            // AngleBLabel
            // 
            this.AngleBLabel.AutoSize = true;
            this.AngleBLabel.Location = new System.Drawing.Point(27, 212);
            this.AngleBLabel.Name = "AngleBLabel";
            this.AngleBLabel.Size = new System.Drawing.Size(47, 13);
            this.AngleBLabel.TabIndex = 12;
            this.AngleBLabel.Text = "Angle B:";
            // 
            // AngleCLabel
            // 
            this.AngleCLabel.AutoSize = true;
            this.AngleCLabel.Location = new System.Drawing.Point(27, 233);
            this.AngleCLabel.Name = "AngleCLabel";
            this.AngleCLabel.Size = new System.Drawing.Size(47, 13);
            this.AngleCLabel.TabIndex = 13;
            this.AngleCLabel.Text = "Angle C:";
            // 
            // AngleAResultLabel
            // 
            this.AngleAResultLabel.AutoSize = true;
            this.AngleAResultLabel.Location = new System.Drawing.Point(76, 191);
            this.AngleAResultLabel.Name = "AngleAResultLabel";
            this.AngleAResultLabel.Size = new System.Drawing.Size(0, 13);
            this.AngleAResultLabel.TabIndex = 14;
            // 
            // AngleBResultLabel
            // 
            this.AngleBResultLabel.AutoSize = true;
            this.AngleBResultLabel.Location = new System.Drawing.Point(76, 212);
            this.AngleBResultLabel.Name = "AngleBResultLabel";
            this.AngleBResultLabel.Size = new System.Drawing.Size(0, 13);
            this.AngleBResultLabel.TabIndex = 15;
            // 
            // AngleCResultLabel
            // 
            this.AngleCResultLabel.AutoSize = true;
            this.AngleCResultLabel.Location = new System.Drawing.Point(76, 233);
            this.AngleCResultLabel.Name = "AngleCResultLabel";
            this.AngleCResultLabel.Size = new System.Drawing.Size(0, 13);
            this.AngleCResultLabel.TabIndex = 16;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Location = new System.Drawing.Point(27, 8);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(265, 43);
            this.InstructionLabel.TabIndex = 17;
            this.InstructionLabel.Text = "Instructions: Input the lengths of the sides of a triangle to see if it is a vali" +
    "d triangle, what type of triangle, and its angles.";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 266);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.AngleCResultLabel);
            this.Controls.Add(this.AngleBResultLabel);
            this.Controls.Add(this.AngleAResultLabel);
            this.Controls.Add(this.AngleCLabel);
            this.Controls.Add(this.AngleBLabel);
            this.Controls.Add(this.AngleALabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextLabel);
            this.Controls.Add(this.SideCError);
            this.Controls.Add(this.SideBError);
            this.Controls.Add(this.SideAError);
            this.Controls.Add(this.SideCTextBox);
            this.Controls.Add(this.SideCLabel);
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideALabel);
            this.Controls.Add(this.SideATextBox);
            this.Name = "TriangleForm";
            this.Text = "Triangles";
            ((System.ComponentModel.ISupportInitialize)(this.sidesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SideATextBox;
        private Label SideALabel;
        private Label SideBLabel;
        private TextBox SideBTextBox;
        private Label SideCLabel;
        private TextBox SideCTextBox;
        private Label SideAError;
        private Label SideBError;
        private Label SideCError;
        private Label ResultTextLabel;
        private Label ResultLabel;
        private Label AngleALabel;
        private Label AngleBLabel;
        private Label AngleCLabel;
        private Label AngleAResultLabel;
        private Label AngleBResultLabel;
        private Label AngleCResultLabel;
        private Label InstructionLabel;
        private BindingSource sidesBindingSource;
    }
}

