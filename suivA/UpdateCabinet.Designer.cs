namespace suivA
{
    partial class UpdateCabinet
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
            this.cabinetAdresseBox = new System.Windows.Forms.TextBox();
            this.cabinetCPBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.validerbutton = new System.Windows.Forms.Button();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cabinetVillebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cabinetAdresseBox
            // 
            this.cabinetAdresseBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetAdresseBox.Location = new System.Drawing.Point(348, 206);
            this.cabinetAdresseBox.Name = "cabinetAdresseBox";
            this.cabinetAdresseBox.Size = new System.Drawing.Size(354, 40);
            this.cabinetAdresseBox.TabIndex = 71;
            // 
            // cabinetCPBox
            // 
            this.cabinetCPBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetCPBox.Location = new System.Drawing.Point(348, 279);
            this.cabinetCPBox.Name = "cabinetCPBox";
            this.cabinetCPBox.Size = new System.Drawing.Size(354, 40);
            this.cabinetCPBox.TabIndex = 70;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(13, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(252, 41);
            this.titleLabel.TabIndex = 67;
            this.titleLabel.Text = "Modifier Cabinet";
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.White;
            this.validerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(794, 610);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(128, 46);
            this.validerbutton.TabIndex = 66;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.Location = new System.Drawing.Point(184, 209);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(115, 33);
            this.prenomLabel.TabIndex = 65;
            this.prenomLabel.Text = "Adresse :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(144, 282);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(155, 33);
            this.nomLabel.TabIndex = 64;
            this.nomLabel.Text = "Code Postal :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 72;
            this.label1.Text = "Ville:";
            // 
            // cabinetVillebox
            // 
            this.cabinetVillebox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetVillebox.Location = new System.Drawing.Point(348, 350);
            this.cabinetVillebox.Name = "cabinetVillebox";
            this.cabinetVillebox.Size = new System.Drawing.Size(354, 40);
            this.cabinetVillebox.TabIndex = 73;
            // 
            // UpdateCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.cabinetVillebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cabinetAdresseBox);
            this.Controls.Add(this.cabinetCPBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Name = "UpdateCabinet";
            this.Text = "UpdateCabinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cabinetAdresseBox;
        private System.Windows.Forms.TextBox cabinetCPBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cabinetVillebox;
    }
}