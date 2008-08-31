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
            this.closeButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceCodeTextEditorControl
            // 
            this.sourceCodeTextEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceCodeTextEditorControl.IsReadOnly = false;
            this.sourceCodeTextEditorControl.Location = new System.Drawing.Point(3, 16);
            this.sourceCodeTextEditorControl.Name = "sourceCodeTextEditorControl";
            this.sourceCodeTextEditorControl.Size = new System.Drawing.Size(714, 244);
            this.sourceCodeTextEditorControl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sourceCodeTextEditorControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 263);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(649, 487);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(645, 281);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 4;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Location = new System.Drawing.Point(3, 16);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(715, 152);
            this.resultTextBox.TabIndex = 0;
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 512);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TesterForm";
            this.Text = "Tester Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl sourceCodeTextEditorControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

