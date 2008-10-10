namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    partial class TesterForm
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
            this.sourceCodeTextEditorControl = new ICSharpCode.TextEditor.TextEditorControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.viewTreeButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.viewProgramStringButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceCodeTextEditorControl
            // 
            this.sourceCodeTextEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceCodeTextEditorControl.IsReadOnly = false;
            this.sourceCodeTextEditorControl.Location = new System.Drawing.Point(3, 16);
            this.sourceCodeTextEditorControl.Name = "sourceCodeTextEditorControl";
            this.sourceCodeTextEditorControl.Size = new System.Drawing.Size(901, 296);
            this.sourceCodeTextEditorControl.TabIndex = 0;
            this.sourceCodeTextEditorControl.Text = "string s = \"Helló World\";\r\nprint(s);";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sourceCodeTextEditorControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Source Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.resultTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Location = new System.Drawing.Point(3, 16);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(899, 149);
            this.resultTextBox.TabIndex = 0;
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compileButton.Location = new System.Drawing.Point(827, 333);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(80, 31);
            this.compileButton.TabIndex = 4;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtErrors);
            this.groupBox3.Location = new System.Drawing.Point(3, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Errors";
            // 
            // txtErrors
            // 
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrors.Location = new System.Drawing.Point(3, 16);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtErrors.Size = new System.Drawing.Size(899, 66);
            this.txtErrors.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(741, 333);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 31);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // viewTreeButton
            // 
            this.viewTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewTreeButton.Location = new System.Drawing.Point(435, 333);
            this.viewTreeButton.Name = "viewTreeButton";
            this.viewTreeButton.Size = new System.Drawing.Size(80, 31);
            this.viewTreeButton.TabIndex = 9;
            this.viewTreeButton.Text = "ViewTree";
            this.viewTreeButton.UseVisualStyleBackColor = true;
            this.viewTreeButton.Click += new System.EventHandler(this.viewTreeButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepButton.Location = new System.Drawing.Point(521, 333);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(80, 31);
            this.stepButton.TabIndex = 10;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click_1);
            // 
            // viewProgramStringButton
            // 
            this.viewProgramStringButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewProgramStringButton.Location = new System.Drawing.Point(607, 333);
            this.viewProgramStringButton.Name = "viewProgramStringButton";
            this.viewProgramStringButton.Size = new System.Drawing.Size(128, 31);
            this.viewProgramStringButton.TabIndex = 12;
            this.viewProgramStringButton.Text = "View Prgram String";
            this.viewProgramStringButton.UseVisualStyleBackColor = true;
            this.viewProgramStringButton.Click += new System.EventHandler(this.viewProgramStringButton_Click);
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 632);
            this.Controls.Add(this.viewProgramStringButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.viewTreeButton);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TesterForm";
            this.Text = "Visual PSimulex Paralell Algorithm Studio ( Codename Psi# )";
            this.Load += new System.EventHandler(this.TesterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtErrors;
        public ICSharpCode.TextEditor.TextEditorControl sourceCodeTextEditorControl;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button viewTreeButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button viewProgramStringButton;
    }
}

