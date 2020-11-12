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
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dTPAlapit = new System.Windows.Forms.DateTimePicker();
            this.tBNot1 = new System.Windows.Forms.TextBox();
            this.tBPeksegNev = new System.Windows.Forms.TextBox();
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
            this.tPStatisztkak.Controls.Add(this.domainUpDown4);
            this.tPStatisztkak.Controls.Add(this.textBox10);
            this.tPStatisztkak.Controls.Add(this.domainUpDown3);
            this.tPStatisztkak.Controls.Add(this.textBox9);
            this.tPStatisztkak.Controls.Add(this.textBox8);
            this.tPStatisztkak.Controls.Add(this.textBox7);
            this.tPStatisztkak.Controls.Add(this.textBox6);
            this.tPStatisztkak.Controls.Add(this.domainUpDown2);
            this.tPStatisztkak.Controls.Add(this.textBox5);
            this.tPStatisztkak.Controls.Add(this.domainUpDown1);
            this.tPStatisztkak.Controls.Add(this.textBox4);
            this.tPStatisztkak.Controls.Add(this.textBox3);
            this.tPStatisztkak.Controls.Add(this.textBox2);
            this.tPStatisztkak.Controls.Add(this.textBox1);
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
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(468, 190);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(47, 20);
            this.domainUpDown4.TabIndex = 17;
            this.domainUpDown4.Text = "100%";
            this.domainUpDown4.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(440, 189);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(22, 20);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "db,";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(395, 189);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(39, 20);
            this.domainUpDown3.TabIndex = 15;
            this.domainUpDown3.Text = "100";
            this.domainUpDown3.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(266, 189);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(123, 20);
            this.textBox9.TabIndex = 14;
            this.textBox9.Text = "Laktózmentes termékek: ";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(378, 163);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 20);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "Legolcsóbb terméke: ";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(376, 137);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Legolcsóbb terméke: ";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(385, 111);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(16, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Ft";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(327, 111);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(52, 20);
            this.domainUpDown2.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(366, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(17, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "db";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(321, 85);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(39, 20);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "100";
            this.domainUpDown1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(266, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Legolcsóbb terméke: ";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(266, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Legdrágább terméke: ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(266, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Átlagos ár: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(266, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "pékáruk: ";
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
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bMentes;
        private System.Windows.Forms.TextBox tBPeksegNev;
        private System.Windows.Forms.TextBox tBNot1;
        private System.Windows.Forms.DateTimePicker dTPAlapit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}

