namespace IntroducaoPOO
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
            btnClique = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnClique
            // 
            btnClique.Enabled = false;
            btnClique.Location = new Point(329, 182);
            btnClique.Name = "btnClique";
            btnClique.Size = new Size(75, 23);
            btnClique.TabIndex = 0;
            btnClique.Text = "Clique-me!";
            btnClique.UseVisualStyleBackColor = true;
            btnClique.Click += btnClique_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(237, 95);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(107, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Informe seu nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(350, 92);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 18);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnClique);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClique;
        private Label lblNome;
        private TextBox txtNome;
    }
}
