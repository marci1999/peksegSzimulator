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
            this.bTorol = new System.Windows.Forms.Button();
            this.bAtnevezPekseg = new System.Windows.Forms.Button();
            this.hozzaAd = new System.Windows.Forms.Button();
            this.lBTermekLista = new System.Windows.Forms.ListBox();
            this.lBPeksegLista = new System.Windows.Forms.ListBox();
            this.bPeksegetHozzaad = new System.Windows.Forms.Button();
            this.tBUjPekseg = new System.Windows.Forms.TextBox();
            this.gBpekaru = new System.Windows.Forms.GroupBox();
            this.bDeleteAru = new System.Windows.Forms.Button();
            this.bAtnevezAru = new System.Windows.Forms.Button();
            this.lBTermekek = new System.Windows.Forms.ListBox();
            this.bTermeketHozzaad = new System.Windows.Forms.Button();
            this.cBLaktozmentes = new System.Windows.Forms.CheckBox();
            this.tBNev = new System.Windows.Forms.TextBox();
            this.tBAr = new System.Windows.Forms.TextBox();
            this.tPStatisztkak = new System.Windows.Forms.TabPage();
            this.dUDMenyiseg = new System.Windows.Forms.DomainUpDown();
            this.dUDDarabSam = new System.Windows.Forms.DomainUpDown();
            this.dUDSzazalek = new System.Windows.Forms.DomainUpDown();
            this.tBNot11 = new System.Windows.Forms.TextBox();
            this.tBNot10 = new System.Windows.Forms.TextBox();
            this.tBNot9 = new System.Windows.Forms.TextBox();
            this.tBNot7 = new System.Windows.Forms.TextBox();
            this.tBNot5 = new System.Windows.Forms.TextBox();
            this.dUDAtlagar = new System.Windows.Forms.DomainUpDown();
            this.tBNot4 = new System.Windows.Forms.TextBox();
            this.tBNot6 = new System.Windows.Forms.TextBox();
            this.tBNot8 = new System.Windows.Forms.TextBox();
            this.tBNot3 = new System.Windows.Forms.TextBox();
            this.tBNot2 = new System.Windows.Forms.TextBox();
            this.dTPAlapit = new System.Windows.Forms.DateTimePicker();
            this.tBNot1 = new System.Windows.Forms.TextBox();
            this.tBPeksegNev = new System.Windows.Forms.TextBox();
            this.lBPeksegek = new System.Windows.Forms.ListBox();
            this.tBlegolcsobb = new System.Windows.Forms.TextBox();
            this.tBlegdragabb = new System.Windows.Forms.TextBox();
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
            this.tCPeksegKezelo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tCPeksegKezelo_Selected);
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
            this.gBPekseg.Controls.Add(this.bTorol);
            this.gBPekseg.Controls.Add(this.bAtnevezPekseg);
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
            // bTorol
            // 
            this.bTorol.Location = new System.Drawing.Point(7, 107);
            this.bTorol.Name = "bTorol";
            this.bTorol.Size = new System.Drawing.Size(75, 23);
            this.bTorol.TabIndex = 6;
            this.bTorol.Text = "Töröl";
            this.bTorol.UseVisualStyleBackColor = true;
            this.bTorol.Visible = false;
            this.bTorol.Click += new System.EventHandler(this.bTorol_Click);
            // 
            // bAtnevezPekseg
            // 
            this.bAtnevezPekseg.Location = new System.Drawing.Point(7, 76);
            this.bAtnevezPekseg.Name = "bAtnevezPekseg";
            this.bAtnevezPekseg.Size = new System.Drawing.Size(75, 23);
            this.bAtnevezPekseg.TabIndex = 5;
            this.bAtnevezPekseg.Text = "Atnevez";
            this.bAtnevezPekseg.UseVisualStyleBackColor = true;
            this.bAtnevezPekseg.Visible = false;
            this.bAtnevezPekseg.Click += new System.EventHandler(this.bAtnavez_Click);
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
            this.lBPeksegLista.SelectedIndexChanged += new System.EventHandler(this.lBPeksegLista_SelectedIndexChanged);
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
            this.gBpekaru.Controls.Add(this.bDeleteAru);
            this.gBpekaru.Controls.Add(this.bAtnevezAru);
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
            // bDeleteAru
            // 
            this.bDeleteAru.Location = new System.Drawing.Point(101, 104);
            this.bDeleteAru.Name = "bDeleteAru";
            this.bDeleteAru.Size = new System.Drawing.Size(64, 23);
            this.bDeleteAru.TabIndex = 6;
            this.bDeleteAru.Text = "törlés";
            this.bDeleteAru.UseVisualStyleBackColor = true;
            this.bDeleteAru.Visible = false;
            this.bDeleteAru.Click += new System.EventHandler(this.bDeleteAru_Click);
            // 
            // bAtnevezAru
            // 
            this.bAtnevezAru.Location = new System.Drawing.Point(7, 104);
            this.bAtnevezAru.Name = "bAtnevezAru";
            this.bAtnevezAru.Size = new System.Drawing.Size(87, 23);
            this.bAtnevezAru.TabIndex = 5;
            this.bAtnevezAru.Text = "Atnevez";
            this.bAtnevezAru.UseVisualStyleBackColor = true;
            this.bAtnevezAru.Visible = false;
            this.bAtnevezAru.Click += new System.EventHandler(this.bAtnevezAru_Click);
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
            this.tPStatisztkak.Controls.Add(this.tBlegdragabb);
            this.tPStatisztkak.Controls.Add(this.tBlegolcsobb);
            this.tPStatisztkak.Controls.Add(this.dUDMenyiseg);
            this.tPStatisztkak.Controls.Add(this.dUDDarabSam);
            this.tPStatisztkak.Controls.Add(this.dUDSzazalek);
            this.tPStatisztkak.Controls.Add(this.tBNot11);
            this.tPStatisztkak.Controls.Add(this.tBNot10);
            this.tPStatisztkak.Controls.Add(this.tBNot9);
            this.tPStatisztkak.Controls.Add(this.tBNot7);
            this.tPStatisztkak.Controls.Add(this.tBNot5);
            this.tPStatisztkak.Controls.Add(this.dUDAtlagar);
            this.tPStatisztkak.Controls.Add(this.tBNot4);
            this.tPStatisztkak.Controls.Add(this.tBNot6);
            this.tPStatisztkak.Controls.Add(this.tBNot8);
            this.tPStatisztkak.Controls.Add(this.tBNot3);
            this.tPStatisztkak.Controls.Add(this.tBNot2);
            this.tPStatisztkak.Controls.Add(this.dTPAlapit);
            this.tPStatisztkak.Controls.Add(this.tBNot1);
            this.tPStatisztkak.Controls.Add(this.tBPeksegNev);
            this.tPStatisztkak.Controls.Add(this.lBPeksegek);
            this.tPStatisztkak.Location = new System.Drawing.Point(4, 22);
            this.tPStatisztkak.Name = "tPStatisztkak";
            this.tPStatisztkak.Padding = new System.Windows.Forms.Padding(3);
            this.tPStatisztkak.Size = new System.Drawing.Size(710, 425);
            this.tPStatisztkak.TabIndex = 1;
            this.tPStatisztkak.Text = "Statisztkák";
            this.tPStatisztkak.UseVisualStyleBackColor = true;
            // 
            // dUDMenyiseg
            // 
            this.dUDMenyiseg.InterceptArrowKeys = false;
            this.dUDMenyiseg.Location = new System.Drawing.Point(395, 190);
            this.dUDMenyiseg.Name = "dUDMenyiseg";
            this.dUDMenyiseg.Size = new System.Drawing.Size(39, 20);
            this.dUDMenyiseg.TabIndex = 19;
            // 
            // dUDDarabSam
            // 
            this.dUDDarabSam.InterceptArrowKeys = false;
            this.dUDDarabSam.Location = new System.Drawing.Point(321, 85);
            this.dUDDarabSam.Name = "dUDDarabSam";
            this.dUDDarabSam.Size = new System.Drawing.Size(39, 20);
            this.dUDDarabSam.TabIndex = 18;
            // 
            // dUDSzazalek
            // 
            this.dUDSzazalek.Location = new System.Drawing.Point(468, 190);
            this.dUDSzazalek.Name = "dUDSzazalek";
            this.dUDSzazalek.Size = new System.Drawing.Size(47, 20);
            this.dUDSzazalek.TabIndex = 17;
            this.dUDSzazalek.Text = "100%";
            this.dUDSzazalek.Visible = false;
            // 
            // tBNot11
            // 
            this.tBNot11.Enabled = false;
            this.tBNot11.Location = new System.Drawing.Point(440, 189);
            this.tBNot11.Name = "tBNot11";
            this.tBNot11.Size = new System.Drawing.Size(22, 20);
            this.tBNot11.TabIndex = 16;
            this.tBNot11.Text = "db,";
            // 
            // tBNot10
            // 
            this.tBNot10.Enabled = false;
            this.tBNot10.Location = new System.Drawing.Point(266, 189);
            this.tBNot10.Name = "tBNot10";
            this.tBNot10.Size = new System.Drawing.Size(123, 20);
            this.tBNot10.TabIndex = 14;
            this.tBNot10.Text = "Laktózmentes termékek: ";
            // 
            // tBNot9
            // 
            this.tBNot9.Enabled = false;
            this.tBNot9.Location = new System.Drawing.Point(378, 163);
            this.tBNot9.Name = "tBNot9";
            this.tBNot9.Size = new System.Drawing.Size(105, 20);
            this.tBNot9.TabIndex = 13;
            this.tBNot9.Text = "Legolcsóbb terméke: ";
            // 
            // tBNot7
            // 
            this.tBNot7.Enabled = false;
            this.tBNot7.Location = new System.Drawing.Point(376, 137);
            this.tBNot7.Name = "tBNot7";
            this.tBNot7.Size = new System.Drawing.Size(107, 20);
            this.tBNot7.TabIndex = 12;
            this.tBNot7.Text = "Legolcsóbb terméke: ";
            // 
            // tBNot5
            // 
            this.tBNot5.Enabled = false;
            this.tBNot5.Location = new System.Drawing.Point(385, 111);
            this.tBNot5.Name = "tBNot5";
            this.tBNot5.Size = new System.Drawing.Size(16, 20);
            this.tBNot5.TabIndex = 11;
            this.tBNot5.Text = "Ft";
            // 
            // dUDAtlagar
            // 
            this.dUDAtlagar.InterceptArrowKeys = false;
            this.dUDAtlagar.Location = new System.Drawing.Point(327, 111);
            this.dUDAtlagar.Name = "dUDAtlagar";
            this.dUDAtlagar.Size = new System.Drawing.Size(52, 20);
            this.dUDAtlagar.TabIndex = 10;
            // 
            // tBNot4
            // 
            this.tBNot4.Enabled = false;
            this.tBNot4.Location = new System.Drawing.Point(366, 85);
            this.tBNot4.Name = "tBNot4";
            this.tBNot4.Size = new System.Drawing.Size(17, 20);
            this.tBNot4.TabIndex = 9;
            this.tBNot4.Text = "db";
            // 
            // tBNot6
            // 
            this.tBNot6.Enabled = false;
            this.tBNot6.Location = new System.Drawing.Point(266, 137);
            this.tBNot6.Name = "tBNot6";
            this.tBNot6.Size = new System.Drawing.Size(104, 20);
            this.tBNot6.TabIndex = 7;
            this.tBNot6.Text = "Legolcsóbb terméke: ";
            // 
            // tBNot8
            // 
            this.tBNot8.Enabled = false;
            this.tBNot8.Location = new System.Drawing.Point(266, 163);
            this.tBNot8.Name = "tBNot8";
            this.tBNot8.Size = new System.Drawing.Size(106, 20);
            this.tBNot8.TabIndex = 6;
            this.tBNot8.Text = "Legdrágább terméke: ";
            // 
            // tBNot3
            // 
            this.tBNot3.Enabled = false;
            this.tBNot3.Location = new System.Drawing.Point(266, 111);
            this.tBNot3.Name = "tBNot3";
            this.tBNot3.Size = new System.Drawing.Size(55, 20);
            this.tBNot3.TabIndex = 5;
            this.tBNot3.Text = "Átlagos ár: ";
            // 
            // tBNot2
            // 
            this.tBNot2.Enabled = false;
            this.tBNot2.Location = new System.Drawing.Point(266, 85);
            this.tBNot2.Name = "tBNot2";
            this.tBNot2.Size = new System.Drawing.Size(49, 20);
            this.tBNot2.TabIndex = 4;
            this.tBNot2.Text = "pékáruk: ";
            // 
            // dTPAlapit
            // 
            this.dTPAlapit.Location = new System.Drawing.Point(319, 33);
            this.dTPAlapit.Name = "dTPAlapit";
            this.dTPAlapit.Size = new System.Drawing.Size(200, 20);
            this.dTPAlapit.TabIndex = 3;
            this.dTPAlapit.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // tBNot1
            // 
            this.tBNot1.Enabled = false;
            this.tBNot1.Location = new System.Drawing.Point(266, 33);
            this.tBNot1.Name = "tBNot1";
            this.tBNot1.Size = new System.Drawing.Size(46, 20);
            this.tBNot1.TabIndex = 2;
            this.tBNot1.Text = "Alapitva: ";
            // 
            // tBPeksegNev
            // 
            this.tBPeksegNev.Enabled = false;
            this.tBPeksegNev.Location = new System.Drawing.Point(266, 7);
            this.tBPeksegNev.Name = "tBPeksegNev";
            this.tBPeksegNev.Size = new System.Drawing.Size(100, 20);
            this.tBPeksegNev.TabIndex = 1;
            // 
            // lBPeksegek
            // 
            this.lBPeksegek.FormattingEnabled = true;
            this.lBPeksegek.Location = new System.Drawing.Point(7, 7);
            this.lBPeksegek.Name = "lBPeksegek";
            this.lBPeksegek.Size = new System.Drawing.Size(252, 251);
            this.lBPeksegek.TabIndex = 0;
            this.lBPeksegek.SelectedIndexChanged += new System.EventHandler(this.lBPeksegek_SelectedIndexChanged);
            // 
            // tBlegolcsobb
            // 
            this.tBlegolcsobb.Location = new System.Drawing.Point(489, 137);
            this.tBlegolcsobb.Name = "tBlegolcsobb";
            this.tBlegolcsobb.Size = new System.Drawing.Size(100, 20);
            this.tBlegolcsobb.TabIndex = 20;
            // 
            // tBlegdragabb
            // 
            this.tBlegdragabb.Location = new System.Drawing.Point(489, 164);
            this.tBlegdragabb.Name = "tBlegdragabb";
            this.tBlegdragabb.Size = new System.Drawing.Size(100, 20);
            this.tBlegdragabb.TabIndex = 21;
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
        private System.Windows.Forms.ListBox lBPeksegek;
        private System.Windows.Forms.Button bDeleteAru;
        private System.Windows.Forms.Button bAtnevezAru;
        private System.Windows.Forms.TextBox tBPeksegNev;
        private System.Windows.Forms.TextBox tBNot1;
        private System.Windows.Forms.DateTimePicker dTPAlapit;
        private System.Windows.Forms.TextBox tBNot3;
        private System.Windows.Forms.TextBox tBNot2;
        private System.Windows.Forms.TextBox tBNot6;
        private System.Windows.Forms.TextBox tBNot8;
        private System.Windows.Forms.DomainUpDown dUDSzazalek;
        private System.Windows.Forms.TextBox tBNot11;
        private System.Windows.Forms.TextBox tBNot10;
        private System.Windows.Forms.TextBox tBNot9;
        private System.Windows.Forms.TextBox tBNot7;
        private System.Windows.Forms.TextBox tBNot5;
        private System.Windows.Forms.DomainUpDown dUDAtlagar;
        private System.Windows.Forms.TextBox tBNot4;
        private System.Windows.Forms.DomainUpDown dUDMenyiseg;
        private System.Windows.Forms.DomainUpDown dUDDarabSam;
        private System.Windows.Forms.Button bTorol;
        private System.Windows.Forms.Button bAtnevezPekseg;
        private System.Windows.Forms.TextBox tBlegdragabb;
        private System.Windows.Forms.TextBox tBlegolcsobb;
    }
}

