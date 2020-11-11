namespace peksegSzimulator
{
    partial class FPekseg
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
            this.tCPeksegKezelo = new System.Windows.Forms.TabControl();
            this.tPAdatok = new System.Windows.Forms.TabPage();
            this.gBPekseg = new System.Windows.Forms.GroupBox();
            this.hozzaAd = new System.Windows.Forms.Button();
            this.lBTermekLista = new System.Windows.Forms.ListBox();
            this.lBPeksegLista = new System.Windows.Forms.ListBox();
            this.bPeksegetHozzaad = new System.Windows.Forms.Button();
            this.tBUjPekseg = new System.Windows.Forms.TextBox();
            this.gBpekaru = new System.Windows.Forms.GroupBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bMentes = new System.Windows.Forms.Button();
            this.lBTermekek = new System.Windows.Forms.ListBox();
            this.bTermeketHozzaad = new System.Windows.Forms.Button();
            this.cBLaktozmentes = new System.Windows.Forms.CheckBox();
            this.tBNev = new System.Windows.Forms.TextBox();
            this.tBAr = new System.Windows.Forms.TextBox();
            this.tPStatisztkak = new System.Windows.Forms.TabPage();
            this.lLaktozmentes = new System.Windows.Forms.Label();
            this.lLegragabb = new System.Windows.Forms.Label();
            this.lLegolcsobb = new System.Windows.Forms.Label();
            this.lPekaruk = new System.Windows.Forms.Label();
            this.lAtlagaAr = new System.Windows.Forms.Label();
            this.lAlapitva = new System.Windows.Forms.Label();
            this.lNev = new System.Windows.Forms.Label();
            this.lBPeksegek = new System.Windows.Forms.ListBox();
            this.tCPeksegKezelo.SuspendLayout();
            this.tPAdatok.SuspendLayout();
            this.gBPekseg.SuspendLayout();
            this.gBpekaru.SuspendLayout();
            this.tPStatisztkak.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCPeksegKezelo
            // 
            this.tCPeksegKezelo.Controls.Add(this.tPAdatok);
            this.tCPeksegKezelo.Controls.Add(this.tPStatisztkak);
            this.tCPeksegKezelo.Location = new System.Drawing.Point(2, 0);
            this.tCPeksegKezelo.Name = "tCPeksegKezelo";
            this.tCPeksegKezelo.SelectedIndex = 0;
            this.tCPeksegKezelo.Size = new System.Drawing.Size(718, 451);
            this.tCPeksegKezelo.TabIndex = 0;
            // 
            // tPAdatok
            // 
            this.tPAdatok.Controls.Add(this.gBPekseg);
            this.tPAdatok.Controls.Add(this.gBpekaru);
            this.tPAdatok.Location = new System.Drawing.Point(4, 22);
            this.tPAdatok.Name = "tPAdatok";
            this.tPAdatok.Padding = new System.Windows.Forms.Padding(3);
            this.tPAdatok.Size = new System.Drawing.Size(710, 425);
            this.tPAdatok.TabIndex = 0;
            this.tPAdatok.Text = "Adatok";
            this.tPAdatok.UseVisualStyleBackColor = true;
            // 
            // gBPekseg
            // 
            this.gBPekseg.Controls.Add(this.hozzaAd);
            this.gBPekseg.Controls.Add(this.lBTermekLista);
            this.gBPekseg.Controls.Add(this.lBPeksegLista);
            this.gBPekseg.Controls.Add(this.bPeksegetHozzaad);
            this.gBPekseg.Controls.Add(this.tBUjPekseg);
            this.gBPekseg.Location = new System.Drawing.Point(7, 159);
            this.gBPekseg.Name = "gBPekseg";
            this.gBPekseg.Size = new System.Drawing.Size(695, 257);
            this.gBPekseg.TabIndex = 1;
            this.gBPekseg.TabStop = false;
            this.gBPekseg.Text = "pékségek";
            // 
            // hozzaAd
            // 
            this.hozzaAd.Location = new System.Drawing.Point(516, 192);
            this.hozzaAd.Name = "hozzaAd";
            this.hozzaAd.Size = new System.Drawing.Size(75, 23);
            this.hozzaAd.TabIndex = 4;
            this.hozzaAd.Text = "+";
            this.hozzaAd.UseVisualStyleBackColor = true;
            this.hozzaAd.Click += new System.EventHandler(this.hozzaAd_Click);
            // 
            // lBTermekLista
            // 
            this.lBTermekLista.FormattingEnabled = true;
            this.lBTermekLista.Location = new System.Drawing.Point(412, 20);
            this.lBTermekLista.Name = "lBTermekLista";
            this.lBTermekLista.Size = new System.Drawing.Size(277, 147);
            this.lBTermekLista.TabIndex = 3;
            // 
            // lBPeksegLista
            // 
            this.lBPeksegLista.FormattingEnabled = true;
            this.lBPeksegLista.Location = new System.Drawing.Point(171, 20);
            this.lBPeksegLista.Name = "lBPeksegLista";
            this.lBPeksegLista.Size = new System.Drawing.Size(234, 212);
            this.lBPeksegLista.TabIndex = 2;
            // 
            // bPeksegetHozzaad
            // 
            this.bPeksegetHozzaad.Location = new System.Drawing.Point(7, 47);
            this.bPeksegetHozzaad.Name = "bPeksegetHozzaad";
            this.bPeksegetHozzaad.Size = new System.Drawing.Size(87, 23);
            this.bPeksegetHozzaad.TabIndex = 1;
            this.bPeksegetHozzaad.Text = "Hozzáadás";
            this.bPeksegetHozzaad.UseVisualStyleBackColor = true;
            this.bPeksegetHozzaad.Click += new System.EventHandler(this.bPeksegetHozzaad_Click);
            // 
            // tBUjPekseg
            // 
            this.tBUjPekseg.Location = new System.Drawing.Point(7, 20);
            this.tBUjPekseg.Name = "tBUjPekseg";
            this.tBUjPekseg.Size = new System.Drawing.Size(124, 20);
            this.tBUjPekseg.TabIndex = 0;
            // 
            // gBpekaru
            // 
            this.gBpekaru.Controls.Add(this.bDelete);
            this.gBpekaru.Controls.Add(this.bMentes);
            this.gBpekaru.Controls.Add(this.lBTermekek);
            this.gBpekaru.Controls.Add(this.bTermeketHozzaad);
            this.gBpekaru.Controls.Add(this.cBLaktozmentes);
            this.gBpekaru.Controls.Add(this.tBNev);
            this.gBpekaru.Controls.Add(this.tBAr);
            this.gBpekaru.Location = new System.Drawing.Point(7, 7);
            this.gBpekaru.Name = "gBpekaru";
            this.gBpekaru.Size = new System.Drawing.Size(695, 146);
            this.gBpekaru.TabIndex = 0;
            this.gBpekaru.TabStop = false;
            this.gBpekaru.Text = "Pékáruk";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(101, 104);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 23);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "törlés";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bMentes
            // 
            this.bMentes.Location = new System.Drawing.Point(7, 104);
            this.bMentes.Name = "bMentes";
            this.bMentes.Size = new System.Drawing.Size(87, 23);
            this.bMentes.TabIndex = 5;
            this.bMentes.Text = "mentés";
            this.bMentes.UseVisualStyleBackColor = true;
            this.bMentes.Visible = false;
            this.bMentes.Click += new System.EventHandler(this.bMentes_Click);
            // 
            // lBTermekek
            // 
            this.lBTermekek.FormattingEnabled = true;
            this.lBTermekek.Location = new System.Drawing.Point(171, 19);
            this.lBTermekek.Name = "lBTermekek";
            this.lBTermekek.Size = new System.Drawing.Size(518, 108);
            this.lBTermekek.TabIndex = 4;
            this.lBTermekek.SelectedIndexChanged += new System.EventHandler(this.lBTermekek_SelectedIndexChanged);
            // 
            // bTermeketHozzaad
            // 
            this.bTermeketHozzaad.Location = new System.Drawing.Point(6, 104);
            this.bTermeketHozzaad.Name = "bTermeketHozzaad";
            this.bTermeketHozzaad.Size = new System.Drawing.Size(88, 23);
            this.bTermeketHozzaad.TabIndex = 3;
            this.bTermeketHozzaad.Text = "Hozzáadás";
            this.bTermeketHozzaad.UseVisualStyleBackColor = true;
            this.bTermeketHozzaad.Click += new System.EventHandler(this.bTermeketHozzaad_Click);
            // 
            // cBLaktozmentes
            // 
            this.cBLaktozmentes.AutoSize = true;
            this.cBLaktozmentes.Location = new System.Drawing.Point(6, 71);
            this.cBLaktozmentes.Name = "cBLaktozmentes";
            this.cBLaktozmentes.Size = new System.Drawing.Size(88, 17);
            this.cBLaktozmentes.TabIndex = 2;
            this.cBLaktozmentes.Text = "laktozmentes";
            this.cBLaktozmentes.UseVisualStyleBackColor = true;
            // 
            // tBNev
            // 
            this.tBNev.Location = new System.Drawing.Point(6, 19);
            this.tBNev.Name = "tBNev";
            this.tBNev.Size = new System.Drawing.Size(125, 20);
            this.tBNev.TabIndex = 1;
            // 
            // tBAr
            // 
            this.tBAr.Location = new System.Drawing.Point(6, 45);
            this.tBAr.Name = "tBAr";
            this.tBAr.Size = new System.Drawing.Size(125, 20);
            this.tBAr.TabIndex = 0;
            // 
            // tPStatisztkak
            // 
            this.tPStatisztkak.Controls.Add(this.lLaktozmentes);
            this.tPStatisztkak.Controls.Add(this.lLegragabb);
            this.tPStatisztkak.Controls.Add(this.lLegolcsobb);
            this.tPStatisztkak.Controls.Add(this.lPekaruk);
            this.tPStatisztkak.Controls.Add(this.lAtlagaAr);
            this.tPStatisztkak.Controls.Add(this.lAlapitva);
            this.tPStatisztkak.Controls.Add(this.lNev);
            this.tPStatisztkak.Controls.Add(this.lBPeksegek);
            this.tPStatisztkak.Location = new System.Drawing.Point(4, 22);
            this.tPStatisztkak.Name = "tPStatisztkak";
            this.tPStatisztkak.Padding = new System.Windows.Forms.Padding(3);
            this.tPStatisztkak.Size = new System.Drawing.Size(710, 425);
            this.tPStatisztkak.TabIndex = 1;
            this.tPStatisztkak.Text = "Statisztkák";
            this.tPStatisztkak.UseVisualStyleBackColor = true;
            // 
            // lLaktozmentes
            // 
            this.lLaktozmentes.AutoSize = true;
            this.lLaktozmentes.Location = new System.Drawing.Point(265, 110);
            this.lLaktozmentes.Name = "lLaktozmentes";
            this.lLaktozmentes.Size = new System.Drawing.Size(0, 13);
            this.lLaktozmentes.TabIndex = 7;
            // 
            // lLegragabb
            // 
            this.lLegragabb.AutoSize = true;
            this.lLegragabb.Location = new System.Drawing.Point(265, 97);
            this.lLegragabb.Name = "lLegragabb";
            this.lLegragabb.Size = new System.Drawing.Size(0, 13);
            this.lLegragabb.TabIndex = 6;
            // 
            // lLegolcsobb
            // 
            this.lLegolcsobb.AutoSize = true;
            this.lLegolcsobb.Location = new System.Drawing.Point(265, 84);
            this.lLegolcsobb.Name = "lLegolcsobb";
            this.lLegolcsobb.Size = new System.Drawing.Size(0, 13);
            this.lLegolcsobb.TabIndex = 5;
            // 
            // lPekaruk
            // 
            this.lPekaruk.AutoSize = true;
            this.lPekaruk.Location = new System.Drawing.Point(266, 58);
            this.lPekaruk.Name = "lPekaruk";
            this.lPekaruk.Size = new System.Drawing.Size(0, 13);
            this.lPekaruk.TabIndex = 4;
            // 
            // lAtlagaAr
            // 
            this.lAtlagaAr.AutoSize = true;
            this.lAtlagaAr.Location = new System.Drawing.Point(265, 71);
            this.lAtlagaAr.Name = "lAtlagaAr";
            this.lAtlagaAr.Size = new System.Drawing.Size(0, 13);
            this.lAtlagaAr.TabIndex = 3;
            // 
            // lAlapitva
            // 
            this.lAlapitva.AutoSize = true;
            this.lAlapitva.Location = new System.Drawing.Point(265, 20);
            this.lAlapitva.Name = "lAlapitva";
            this.lAlapitva.Size = new System.Drawing.Size(0, 13);
            this.lAlapitva.TabIndex = 2;
            // 
            // lNev
            // 
            this.lNev.AutoSize = true;
            this.lNev.Location = new System.Drawing.Point(266, 7);
            this.lNev.Name = "lNev";
            this.lNev.Size = new System.Drawing.Size(0, 13);
            this.lNev.TabIndex = 1;
            // 
            // lBPeksegek
            // 
            this.lBPeksegek.FormattingEnabled = true;
            this.lBPeksegek.Location = new System.Drawing.Point(7, 7);
            this.lBPeksegek.Name = "lBPeksegek";
            this.lBPeksegek.Size = new System.Drawing.Size(252, 251);
            this.lBPeksegek.TabIndex = 0;
            // 
            // FPekseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.tCPeksegKezelo);
            this.Name = "FPekseg";
            this.Text = "Pékség";
            this.tCPeksegKezelo.ResumeLayout(false);
            this.tPAdatok.ResumeLayout(false);
            this.gBPekseg.ResumeLayout(false);
            this.gBPekseg.PerformLayout();
            this.gBpekaru.ResumeLayout(false);
            this.gBpekaru.PerformLayout();
            this.tPStatisztkak.ResumeLayout(false);
            this.tPStatisztkak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCPeksegKezelo;
        private System.Windows.Forms.TabPage tPAdatok;
        private System.Windows.Forms.TabPage tPStatisztkak;
        private System.Windows.Forms.GroupBox gBPekseg;
        private System.Windows.Forms.GroupBox gBpekaru;
        private System.Windows.Forms.Button bTermeketHozzaad;
        private System.Windows.Forms.CheckBox cBLaktozmentes;
        private System.Windows.Forms.TextBox tBNev;
        private System.Windows.Forms.TextBox tBAr;
        private System.Windows.Forms.ListBox lBTermekek;
        private System.Windows.Forms.Button hozzaAd;
        private System.Windows.Forms.ListBox lBTermekLista;
        private System.Windows.Forms.ListBox lBPeksegLista;
        private System.Windows.Forms.Button bPeksegetHozzaad;
        private System.Windows.Forms.TextBox tBUjPekseg;
        private System.Windows.Forms.Label lLaktozmentes;
        private System.Windows.Forms.Label lLegragabb;
        private System.Windows.Forms.Label lLegolcsobb;
        private System.Windows.Forms.Label lPekaruk;
        private System.Windows.Forms.Label lAtlagaAr;
        private System.Windows.Forms.Label lAlapitva;
        private System.Windows.Forms.Label lNev;
        private System.Windows.Forms.ListBox lBPeksegek;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bMentes;
    }
}

