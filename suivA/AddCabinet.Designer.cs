namespace suivA
{
    partial class AddCabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCabinet));
            this.titleLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.villeLabel = new System.Windows.Forms.Label();
            this.villeBox = new System.Windows.Forms.TextBox();
            this.cPostalLabel = new System.Windows.Forms.Label();
            this.cPostalBox = new System.Windows.Forms.TextBox();
            this.validerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(232, 41);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Ajouter cabinet";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.BackColor = System.Drawing.Color.Transparent;
            this.adresseLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLabel.Location = new System.Drawing.Point(80, 162);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(102, 33);
            this.adresseLabel.TabIndex = 23;
            this.adresseLabel.Text = "Adresse";
            // 
            // adresseBox
            // 
            this.adresseBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseBox.Location = new System.Drawing.Point(306, 159);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(354, 40);
            this.adresseBox.TabIndex = 24;
            // 
            // villeLabel
            // 
            this.villeLabel.AutoSize = true;
            this.villeLabel.BackColor = System.Drawing.Color.Transparent;
            this.villeLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeLabel.Location = new System.Drawing.Point(80, 276);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(61, 33);
            this.villeLabel.TabIndex = 25;
            this.villeLabel.Text = "Ville";
            // 
            // villeBox
            // 
            this.villeBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeBox.Location = new System.Drawing.Point(306, 273);
            this.villeBox.Name = "villeBox";
            this.villeBox.Size = new System.Drawing.Size(354, 40);
            this.villeBox.TabIndex = 26;
            // 
            // cPostalLabel
            // 
            this.cPostalLabel.AutoSize = true;
            this.cPostalLabel.BackColor = System.Drawing.Color.Transparent;
            this.cPostalLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostalLabel.Location = new System.Drawing.Point(80, 386);
            this.cPostalLabel.Name = "cPostalLabel";
            this.cPostalLabel.Size = new System.Drawing.Size(142, 33);
            this.cPostalLabel.TabIndex = 27;
            this.cPostalLabel.Text = "Code Postal";
            // 
            // cPostalBox
            // 
            this.cPostalBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostalBox.Location = new System.Drawing.Point(306, 383);
            this.cPostalBox.MaxLength = 5;
            this.cPostalBox.Name = "cPostalBox";
            this.cPostalBox.Size = new System.Drawing.Size(113, 40);
            this.cPostalBox.TabIndex = 28;
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.White;
            this.validerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(793, 612);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(128, 46);
            this.validerbutton.TabIndex = 29;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // AddCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.cPostalBox);
            this.Controls.Add(this.cPostalLabel);
            this.Controls.Add(this.villeBox);
            this.Controls.Add(this.villeLabel);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.adresseLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "AddCabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCabinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.Label villeLabel;
        private System.Windows.Forms.TextBox villeBox;
        private System.Windows.Forms.Label cPostalLabel;
        private System.Windows.Forms.TextBox cPostalBox;
        private System.Windows.Forms.Button validerbutton;
    }
}