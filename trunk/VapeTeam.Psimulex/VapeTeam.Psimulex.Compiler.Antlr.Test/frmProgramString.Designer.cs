namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    partial class frmProgramString
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
            this.txtProgramString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProgramString
            // 
            this.txtProgramString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProgramString.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProgramString.Location = new System.Drawing.Point(0, 0);
            this.txtProgramString.Multiline = true;
            this.txtProgramString.Name = "txtProgramString";
            this.txtProgramString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProgramString.Size = new System.Drawing.Size(1106, 513);
            this.txtProgramString.TabIndex = 0;
            // 
            // frmProgramString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 513);
            this.Controls.Add(this.txtProgramString);
            this.Name = "frmProgramString";
            this.Text = "frmProgramString";
            this.Load += new System.EventHandler(this.frmProgramString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProgramString;
    }
}