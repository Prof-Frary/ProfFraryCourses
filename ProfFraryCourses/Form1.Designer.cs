namespace ProfFraryCourses
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboDept = new ComboBox();
            txtCrsNum = new TextBox();
            txtCrsName = new TextBox();
            btnAdd = new Button();
            numUDCredits = new NumericUpDown();
            lstOut = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numUDCredits).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 76);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Department ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 113);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 195);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Number Of Credits";
            // 
            // cboDept
            // 
            cboDept.FormattingEnabled = true;
            cboDept.Location = new Point(189, 68);
            cboDept.Name = "cboDept";
            cboDept.Size = new Size(121, 23);
            cboDept.TabIndex = 4;
            // 
            // txtCrsNum
            // 
            txtCrsNum.Location = new Point(192, 110);
            txtCrsNum.Name = "txtCrsNum";
            txtCrsNum.Size = new Size(100, 23);
            txtCrsNum.TabIndex = 5;
            // 
            // txtCrsName
            // 
            txtCrsName.Location = new Point(192, 151);
            txtCrsName.Name = "txtCrsName";
            txtCrsName.Size = new Size(100, 23);
            txtCrsName.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(156, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Course";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numUDCredits
            // 
            numUDCredits.Location = new Point(192, 187);
            numUDCredits.Name = "numUDCredits";
            numUDCredits.Size = new Size(120, 23);
            numUDCredits.TabIndex = 8;
            numUDCredits.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(12, 277);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(350, 109);
            lstOut.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(lstOut);
            Controls.Add(numUDCredits);
            Controls.Add(btnAdd);
            Controls.Add(txtCrsName);
            Controls.Add(txtCrsNum);
            Controls.Add(cboDept);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary - Course Entry";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numUDCredits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboDept;
        private TextBox txtCrsNum;
        private TextBox txtCrsName;
        private Button btnAdd;
        private NumericUpDown numUDCredits;
        private ListBox lstOut;
    }
}
