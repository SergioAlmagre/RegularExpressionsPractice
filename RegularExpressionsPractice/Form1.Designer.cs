namespace RegularExpressionsPractice
{
    partial class Form1
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
            lblRegularExpresion = new Label();
            lblString = new Label();
            txtRegularExpression = new TextBox();
            txtString = new TextBox();
            btnValidate = new Button();
            cboTest = new ComboBox();
            lblExamples = new Label();
            SuspendLayout();
            // 
            // lblRegularExpresion
            // 
            lblRegularExpresion.AutoSize = true;
            lblRegularExpresion.Location = new Point(36, 47);
            lblRegularExpresion.Margin = new Padding(6, 0, 6, 0);
            lblRegularExpresion.Name = "lblRegularExpresion";
            lblRegularExpresion.Size = new Size(204, 32);
            lblRegularExpresion.TabIndex = 0;
            lblRegularExpresion.Text = "Regular expresion";
            lblRegularExpresion.Click += label1_Click;
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Location = new Point(105, 132);
            lblString.Margin = new Padding(6, 0, 6, 0);
            lblString.Name = "lblString";
            lblString.Size = new Size(76, 32);
            lblString.TabIndex = 1;
            lblString.Text = "String";
            // 
            // txtRegularExpression
            // 
            txtRegularExpression.Location = new Point(349, 47);
            txtRegularExpression.Name = "txtRegularExpression";
            txtRegularExpression.Size = new Size(959, 39);
            txtRegularExpression.TabIndex = 2;
            txtRegularExpression.TextChanged += txtRegularExpresion_TextChanged;
            // 
            // txtString
            // 
            txtString.Location = new Point(349, 132);
            txtString.Name = "txtString";
            txtString.Size = new Size(959, 39);
            txtString.TabIndex = 3;
            txtString.TextChanged += txtString_TextChanged;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.PaleGreen;
            btnValidate.Location = new Point(781, 249);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(527, 53);
            btnValidate.TabIndex = 4;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // cboTest
            // 
            cboTest.FormattingEnabled = true;
            cboTest.Location = new Point(349, 253);
            cboTest.Name = "cboTest";
            cboTest.Size = new Size(378, 40);
            cboTest.TabIndex = 6;
            cboTest.SelectedIndexChanged += cbo_SelectedIndexChanged;
            // 
            // lblExamples
            // 
            lblExamples.AutoSize = true;
            lblExamples.Location = new Point(83, 255);
            lblExamples.Margin = new Padding(6, 0, 6, 0);
            lblExamples.Name = "lblExamples";
            lblExamples.Size = new Size(113, 32);
            lblExamples.TabIndex = 7;
            lblExamples.Text = "Examples";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 370);
            Controls.Add(lblExamples);
            Controls.Add(cboTest);
            Controls.Add(btnValidate);
            Controls.Add(txtString);
            Controls.Add(txtRegularExpression);
            Controls.Add(lblString);
            Controls.Add(lblRegularExpresion);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Types";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegularExpresion;
        private Label lblString;
        private TextBox txtRegularExpression;
        private TextBox txtString;
        private Button btnValidate;
        private ComboBox cboTest;
        private Label lblExamples;
    }
}