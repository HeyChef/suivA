namespace suivA
{
    partial class visiteurAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visiteurAccueil));
            this.navPanel = new System.Windows.Forms.Panel();
            this.getStat = new System.Windows.Forms.Label();
            this.pipe = new System.Windows.Forms.Label();
            this.addVisite = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navPanel.Controls.Add(this.getStat);
            this.navPanel.Controls.Add(this.pipe);
            this.navPanel.Controls.Add(this.addVisite);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1185, 50);
            this.navPanel.TabIndex = 0;
            // 
            // getStat
            // 
            this.getStat.AutoSize = true;
            this.getStat.BackColor = System.Drawing.Color.Transparent;
            this.getStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getStat.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStat.ForeColor = System.Drawing.Color.White;
            this.getStat.Location = new System.Drawing.Point(210, 9);
            this.getStat.Name = "getStat";
            this.getStat.Size = new System.Drawing.Size(142, 33);
            this.getStat.TabIndex = 1;
            this.getStat.Text = "Statistiques";
            // 
            // pipe
            // 
            this.pipe.AutoSize = true;
            this.pipe.BackColor = System.Drawing.Color.Transparent;
            this.pipe.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipe.ForeColor = System.Drawing.Color.White;
            this.pipe.Location = new System.Drawing.Point(177, 9);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(27, 33);
            this.pipe.TabIndex = 1;
            this.pipe.Text = "|";
            // 
            // addVisite
            // 
            this.addVisite.AutoSize = true;
            this.addVisite.BackColor = System.Drawing.Color.Transparent;
            this.addVisite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVisite.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVisite.ForeColor = System.Drawing.Color.White;
            this.addVisite.Location = new System.Drawing.Point(12, 9);
            this.addVisite.Name = "addVisite";
            this.addVisite.Size = new System.Drawing.Size(159, 33);
            this.addVisite.TabIndex = 0;
            this.addVisite.Text = "Ajouter visite";
            this.addVisite.Click += new System.EventHandler(this.addVisite_Click);
            // 
            // visiteurAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.navPanel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "visiteurAccueil";
            this.Text = "visiteurAccueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.visiteurAccueil_FormClosing);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label addVisite;
        private System.Windows.Forms.Label getStat;
        private System.Windows.Forms.Label pipe;
    }
}