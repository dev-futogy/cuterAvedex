namespace cuterAvedex
{
    partial class FormCreateProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._labelNameNewProject = new System.Windows.Forms.Label();
            this._textBoxPathFolderNewProject = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._countClassifiers = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._textBoxNameClass = new System.Windows.Forms.TextBox();
            this._textBoxPathFileClass = new System.Windows.Forms.TextBox();
            this._btnAddClass = new System.Windows.Forms.Button();
            this._btnPathClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._numerClassifier = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button6 = new System.Windows.Forms.Button();
            this._pathFolderNewProject = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this._countClassifiers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numerClassifier)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(178, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "newproject";
            // 
            // _labelNameNewProject
            // 
            this._labelNameNewProject.AutoSize = true;
            this._labelNameNewProject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelNameNewProject.Location = new System.Drawing.Point(3, 26);
            this._labelNameNewProject.Name = "_labelNameNewProject";
            this._labelNameNewProject.Size = new System.Drawing.Size(151, 23);
            this._labelNameNewProject.TabIndex = 1;
            this._labelNameNewProject.Text = "Name  new project:";
            // 
            // _textBoxPathFolderNewProject
            // 
            this._textBoxPathFolderNewProject.BackColor = System.Drawing.Color.SeaShell;
            this._textBoxPathFolderNewProject.Enabled = false;
            this._textBoxPathFolderNewProject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxPathFolderNewProject.Location = new System.Drawing.Point(98, 79);
            this._textBoxPathFolderNewProject.Name = "_textBoxPathFolderNewProject";
            this._textBoxPathFolderNewProject.Size = new System.Drawing.Size(325, 30);
            this._textBoxPathFolderNewProject.TabIndex = 2;
            this._textBoxPathFolderNewProject.Text = "PATH";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "PATH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of classifiers:";
            // 
            // _countClassifiers
            // 
            this._countClassifiers.Enabled = false;
            this._countClassifiers.Location = new System.Drawing.Point(184, 143);
            this._countClassifiers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._countClassifiers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._countClassifiers.Name = "_countClassifiers";
            this._countClassifiers.Size = new System.Drawing.Size(42, 20);
            this._countClassifiers.TabIndex = 5;
            this._countClassifiers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._countClassifiers.ValueChanged += new System.EventHandler(this._countClassifiers_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._textBoxPathFolderNewProject);
            this.panel1.Controls.Add(this._countClassifiers);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._labelNameNewProject);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 186);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._textBoxNameClass);
            this.panel2.Controls.Add(this._textBoxPathFileClass);
            this.panel2.Controls.Add(this._btnAddClass);
            this.panel2.Controls.Add(this._btnPathClass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._numerClassifier);
            this.panel2.Location = new System.Drawing.Point(1, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 214);
            this.panel2.TabIndex = 7;
            // 
            // _textBoxNameClass
            // 
            this._textBoxNameClass.BackColor = System.Drawing.Color.SeaShell;
            this._textBoxNameClass.Enabled = false;
            this._textBoxNameClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxNameClass.Location = new System.Drawing.Point(98, 82);
            this._textBoxNameClass.Name = "_textBoxNameClass";
            this._textBoxNameClass.Size = new System.Drawing.Size(245, 26);
            this._textBoxNameClass.TabIndex = 6;
            this._textBoxNameClass.Text = "class1";
            // 
            // _textBoxPathFileClass
            // 
            this._textBoxPathFileClass.BackColor = System.Drawing.Color.SeaShell;
            this._textBoxPathFileClass.Enabled = false;
            this._textBoxPathFileClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxPathFileClass.Location = new System.Drawing.Point(98, 124);
            this._textBoxPathFileClass.Name = "_textBoxPathFileClass";
            this._textBoxPathFileClass.Size = new System.Drawing.Size(325, 26);
            this._textBoxPathFileClass.TabIndex = 6;
            this._textBoxPathFileClass.Text = "PATH";
            // 
            // _btnAddClass
            // 
            this._btnAddClass.Enabled = false;
            this._btnAddClass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddClass.Location = new System.Drawing.Point(265, 171);
            this._btnAddClass.Name = "_btnAddClass";
            this._btnAddClass.Size = new System.Drawing.Size(166, 29);
            this._btnAddClass.TabIndex = 5;
            this._btnAddClass.Text = "Add classifier";
            this._btnAddClass.UseVisualStyleBackColor = true;
            // 
            // _btnPathClass
            // 
            this._btnPathClass.Enabled = false;
            this._btnPathClass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnPathClass.Location = new System.Drawing.Point(11, 118);
            this._btnPathClass.Name = "_btnPathClass";
            this._btnPathClass.Size = new System.Drawing.Size(71, 36);
            this._btnPathClass.TabIndex = 4;
            this._btnPathClass.Text = "PATH";
            this._btnPathClass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Classifier number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classifier settings:";
            // 
            // _numerClassifier
            // 
            this._numerClassifier.Enabled = false;
            this._numerClassifier.Location = new System.Drawing.Point(152, 47);
            this._numerClassifier.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numerClassifier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numerClassifier.Name = "_numerClassifier";
            this._numerClassifier.Size = new System.Drawing.Size(38, 20);
            this._numerClassifier.TabIndex = 0;
            this._numerClassifier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(1, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 214);
            this.panel3.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(72, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 39);
            this.button5.TabIndex = 12;
            this.button5.Text = "What is color?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Color:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 31);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "obj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name class:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 31);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "class1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name classifier:";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(265, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Set color";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class color settings:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(139, 634);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "Create project";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 670);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreateProject";
            this.Text = "New Project";
            ((System.ComponentModel.ISupportInitialize)(this._countClassifiers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numerClassifier)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _labelNameNewProject;
        private System.Windows.Forms.TextBox _textBoxPathFolderNewProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _countClassifiers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _textBoxNameClass;
        private System.Windows.Forms.TextBox _textBoxPathFileClass;
        private System.Windows.Forms.Button _btnAddClass;
        private System.Windows.Forms.Button _btnPathClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numerClassifier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FolderBrowserDialog _pathFolderNewProject;
    }
}