namespace ProgrammerenHuiswerk_Rente
{
    partial class Form1
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
            this.lblBedrag = new System.Windows.Forms.Label();
            this.txtBedrag = new System.Windows.Forms.TextBox();
            this.txtRente = new System.Windows.Forms.TextBox();
            this.lblRente = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.txtJaar = new System.Windows.Forms.TextBox();
            this.lblJaar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedrag.Location = new System.Drawing.Point(12, 9);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(65, 20);
            this.lblBedrag.TabIndex = 0;
            this.lblBedrag.Text = "Bedrag:";
            // 
            // txtBedrag
            // 
            this.txtBedrag.Location = new System.Drawing.Point(16, 32);
            this.txtBedrag.Name = "txtBedrag";
            this.txtBedrag.Size = new System.Drawing.Size(229, 20);
            this.txtBedrag.TabIndex = 1;
            // 
            // txtRente
            // 
            this.txtRente.Location = new System.Drawing.Point(16, 78);
            this.txtRente.Name = "txtRente";
            this.txtRente.Size = new System.Drawing.Size(229, 20);
            this.txtRente.TabIndex = 3;
            // 
            // lblRente
            // 
            this.lblRente.AutoSize = true;
            this.lblRente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRente.Location = new System.Drawing.Point(12, 55);
            this.lblRente.Name = "lblRente";
            this.lblRente.Size = new System.Drawing.Size(138, 20);
            this.lblRente.TabIndex = 2;
            this.lblRente.Text = "Rente percentage";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(16, 150);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(148, 23);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(16, 179);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(229, 225);
            this.lbResult.TabIndex = 7;
            // 
            // txtJaar
            // 
            this.txtJaar.Location = new System.Drawing.Point(16, 124);
            this.txtJaar.Name = "txtJaar";
            this.txtJaar.Size = new System.Drawing.Size(229, 20);
            this.txtJaar.TabIndex = 9;
            // 
            // lblJaar
            // 
            this.lblJaar.AutoSize = true;
            this.lblJaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJaar.Location = new System.Drawing.Point(12, 101);
            this.lblJaar.Name = "lblJaar";
            this.lblJaar.Size = new System.Drawing.Size(85, 20);
            this.lblJaar.TabIndex = 8;
            this.lblJaar.Text = "Aantal jaar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 421);
            this.Controls.Add(this.txtJaar);
            this.Controls.Add(this.lblJaar);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtRente);
            this.Controls.Add(this.lblRente);
            this.Controls.Add(this.txtBedrag);
            this.Controls.Add(this.lblBedrag);
            this.Name = "Form1";
            this.Text = "Rente berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.TextBox txtBedrag;
        private System.Windows.Forms.TextBox txtRente;
        private System.Windows.Forms.Label lblRente;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.TextBox txtJaar;
        private System.Windows.Forms.Label lblJaar;
    }
}

