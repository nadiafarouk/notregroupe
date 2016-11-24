namespace FormaGroup
{
    partial class FenetreAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreAcceuil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btGestionCandidature = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGestionSession = new System.Windows.Forms.Button();
            this.btTrombinoscope = new System.Windows.Forms.Button();
            this.btGestionFormateur = new System.Windows.Forms.Button();
            this.btGestionFormation = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btGestionFormation);
            this.panel2.Controls.Add(this.btGestionFormateur);
            this.panel2.Controls.Add(this.btTrombinoscope);
            this.panel2.Controls.Add(this.btGestionSession);
            this.panel2.Controls.Add(this.btGestionCandidature);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 627);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 118);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 371);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(201, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(483, 97);
            this.panel5.TabIndex = 2;
            // 
            // btGestionCandidature
            // 
            this.btGestionCandidature.BackColor = System.Drawing.Color.SteelBlue;
            this.btGestionCandidature.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestionCandidature.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGestionCandidature.Location = new System.Drawing.Point(0, 92);
            this.btGestionCandidature.Name = "btGestionCandidature";
            this.btGestionCandidature.Size = new System.Drawing.Size(200, 73);
            this.btGestionCandidature.TabIndex = 2;
            this.btGestionCandidature.Text = "Gestion des candidatures";
            this.btGestionCandidature.UseVisualStyleBackColor = false;
            this.btGestionCandidature.Click += new System.EventHandler(this.btGestionCandidature_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centre de formation FormaGroup";
            // 
            // btGestionSession
            // 
            this.btGestionSession.BackColor = System.Drawing.Color.SteelBlue;
            this.btGestionSession.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestionSession.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGestionSession.Location = new System.Drawing.Point(0, 160);
            this.btGestionSession.Name = "btGestionSession";
            this.btGestionSession.Size = new System.Drawing.Size(200, 73);
            this.btGestionSession.TabIndex = 3;
            this.btGestionSession.Text = "Gestion des sessions";
            this.btGestionSession.UseVisualStyleBackColor = false;
            this.btGestionSession.Click += new System.EventHandler(this.btGestionSession_Click);
            // 
            // btTrombinoscope
            // 
            this.btTrombinoscope.BackColor = System.Drawing.Color.SteelBlue;
            this.btTrombinoscope.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrombinoscope.ForeColor = System.Drawing.Color.DarkBlue;
            this.btTrombinoscope.Location = new System.Drawing.Point(0, 230);
            this.btTrombinoscope.Name = "btTrombinoscope";
            this.btTrombinoscope.Size = new System.Drawing.Size(200, 73);
            this.btTrombinoscope.TabIndex = 4;
            this.btTrombinoscope.Text = "Trombinoscope";
            this.btTrombinoscope.UseVisualStyleBackColor = false;
            this.btTrombinoscope.Click += new System.EventHandler(this.btTrombinoscope_Click);
            // 
            // btGestionFormateur
            // 
            this.btGestionFormateur.BackColor = System.Drawing.Color.SteelBlue;
            this.btGestionFormateur.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestionFormateur.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGestionFormateur.Location = new System.Drawing.Point(-3, 300);
            this.btGestionFormateur.Name = "btGestionFormateur";
            this.btGestionFormateur.Size = new System.Drawing.Size(200, 73);
            this.btGestionFormateur.TabIndex = 5;
            this.btGestionFormateur.Text = "Gestion des formateurs";
            this.btGestionFormateur.UseVisualStyleBackColor = false;
            this.btGestionFormateur.Click += new System.EventHandler(this.btGestionFormateur_Click);
            // 
            // btGestionFormation
            // 
            this.btGestionFormation.BackColor = System.Drawing.Color.SteelBlue;
            this.btGestionFormation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestionFormation.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGestionFormation.Location = new System.Drawing.Point(-3, 368);
            this.btGestionFormation.Name = "btGestionFormation";
            this.btGestionFormation.Size = new System.Drawing.Size(200, 73);
            this.btGestionFormation.TabIndex = 6;
            this.btGestionFormation.Text = "Gestion des formations";
            this.btGestionFormation.UseVisualStyleBackColor = false;
            this.btGestionFormation.Click += new System.EventHandler(this.btGestionFormation_Click);
            // 
            // FenetreAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(685, 624);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "FenetreAcceuil";
            this.Text = "FenetreAcceuil";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btGestionCandidature;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btGestionFormation;
        private System.Windows.Forms.Button btGestionFormateur;
        private System.Windows.Forms.Button btTrombinoscope;
        private System.Windows.Forms.Button btGestionSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}