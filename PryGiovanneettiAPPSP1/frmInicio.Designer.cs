namespace PryGiovanneettiAPPSP1
{
    partial class frmInicio
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
            lblBienvenida = new Label();
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(271, 129);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(262, 50);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡ Bienvenido !";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = SystemColors.ActiveCaptionText;
            lblLogo.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.Red;
            lblLogo.Location = new Point(192, 238);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(396, 57);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Sintepart SRL";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogo);
            Controls.Add(lblBienvenida);
            Name = "frmInicio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblLogo;
    }
}
