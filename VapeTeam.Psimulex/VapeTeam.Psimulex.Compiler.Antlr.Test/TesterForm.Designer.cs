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
            this.closeButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.btnViewTree = new System.Windows.Forms.Button();
            this.btnViewProgramString = new System.Windows.Forms.Button();
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
            this.sourceCodeTextEditorControl.Size = new System.Drawing.Size(901, 244);
            this.sourceCodeTextEditorControl.TabIndex = 0;
            this.sourceCodeTextEditorControl.Text = "(10)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sourceCodeTextEditorControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 263);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 115);
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
            this.resultTextBox.Size = new System.Drawing.Size(899, 96);
            this.resultTextBox.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(807, 594);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 33);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close And Save";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compileButton.Location = new System.Drawing.Point(830, 282);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 149);
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
            this.txtErrors.Size = new System.Drawing.Size(899, 130);
            this.txtErrors.TabIndex = 0;
            // 
            // btnViewTree
            // 
            this.btnViewTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewTree.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnViewTree.Location = new System.Drawing.Point(9, 594);
            this.btnViewTree.Name = "btnViewTree";
            this.btnViewTree.Size = new System.Drawing.Size(103, 33);
            this.btnViewTree.TabIndex = 5;
            this.btnViewTree.Text = "View Tree";
            this.btnViewTree.UseVisualStyleBackColor = true;
            this.btnViewTree.Click += new System.EventHandler(this.btnViewTree_Click);
            // 
            // btnViewProgramString
            // 
            this.btnViewProgramString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProgramString.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnViewProgramString.Location = new System.Drawing.Point(684, 594);
            this.btnViewProgramString.Name = "btnViewProgramString";
            this.btnViewProgramString.Size = new System.Drawing.Size(117, 33);
            this.btnViewProgramString.TabIndex = 6;
            this.btnViewProgramString.Text = "View Program String";
            this.btnViewProgramString.UseVisualStyleBackColor = true;
            this.btnViewProgramString.Click += new System.EventHandler(this.btnViewProgramString_Click);
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 632);
            this.Controls.Add(this.btnViewProgramString);
            this.Controls.Add(this.btnViewTree);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TesterForm";
            this.Text = "Tester Form";
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
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.Button btnViewTree;
        public ICSharpCode.TextEditor.TextEditorControl sourceCodeTextEditorControl;
        private System.Windows.Forms.Button btnViewProgramString;
    }
}

