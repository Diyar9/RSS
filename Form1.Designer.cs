namespace RSS
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
            this.urllbl = new System.Windows.Forms.Label();
            this.urltxt = new System.Windows.Forms.TextBox();
            this.laggtillbtn = new System.Windows.Forms.Button();
            this.urlnamnlbl = new System.Windows.Forms.Label();
            this.urlNamntxt = new System.Windows.Forms.TextBox();
            this.uppdateringfrekbox = new System.Windows.Forms.ComboBox();
            this.kategoribox = new System.Windows.Forms.ComboBox();
            this.sparabtn = new System.Windows.Forms.Button();
            this.tabortbtn = new System.Windows.Forms.Button();
            this.uppdateringsfrekvenslbl = new System.Windows.Forms.Label();
            this.kategorilbl = new System.Windows.Forms.Label();
            this.avsnittlbl = new System.Windows.Forms.Label();
            this.beskrivninglbl = new System.Windows.Forms.Label();
            this.kategorierlistbox = new System.Windows.Forms.ListBox();
            this.kategorierlbl = new System.Windows.Forms.Label();
            this.nyKategoriBtn = new System.Windows.Forms.Button();
            this.sparabtn2 = new System.Windows.Forms.Button();
            this.tabortbtn2 = new System.Windows.Forms.Button();
            this.beskrivningtxt = new System.Windows.Forms.TextBox();
            this.namnKategoritxt = new System.Windows.Forms.TextBox();
            this.avsnittlistbox = new System.Windows.Forms.ListBox();
            this.tabbelListView = new System.Windows.Forms.ListView();
            this.namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.antalAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uppdateringsFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resetbtn = new System.Windows.Forms.Button();
            this.btnVisaInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urllbl
            // 
            this.urllbl.AutoSize = true;
            this.urllbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urllbl.Location = new System.Drawing.Point(27, 362);
            this.urllbl.Name = "urllbl";
            this.urllbl.Size = new System.Drawing.Size(65, 27);
            this.urllbl.TabIndex = 0;
            this.urllbl.Text = "URL:";
            this.urllbl.Click += new System.EventHandler(this.urllbl_Click);
            // 
            // urltxt
            // 
            this.urltxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urltxt.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.urltxt.Location = new System.Drawing.Point(32, 394);
            this.urltxt.Multiline = true;
            this.urltxt.Name = "urltxt";
            this.urltxt.Size = new System.Drawing.Size(350, 29);
            this.urltxt.TabIndex = 1;
            this.urltxt.Text = "http://...";
            this.urltxt.TextChanged += new System.EventHandler(this.urltxt_TextChanged);
            // 
            // laggtillbtn
            // 
            this.laggtillbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.laggtillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.laggtillbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laggtillbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.laggtillbtn.Location = new System.Drawing.Point(330, 457);
            this.laggtillbtn.Name = "laggtillbtn";
            this.laggtillbtn.Size = new System.Drawing.Size(198, 51);
            this.laggtillbtn.TabIndex = 2;
            this.laggtillbtn.Text = "LÄGG TILL";
            this.laggtillbtn.UseVisualStyleBackColor = false;
            this.laggtillbtn.Click += new System.EventHandler(this.prenumererabtn_Click);
            // 
            // urlnamnlbl
            // 
            this.urlnamnlbl.AutoSize = true;
            this.urlnamnlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlnamnlbl.Location = new System.Drawing.Point(28, 437);
            this.urlnamnlbl.Name = "urlnamnlbl";
            this.urlnamnlbl.Size = new System.Drawing.Size(76, 27);
            this.urlnamnlbl.TabIndex = 3;
            this.urlnamnlbl.Text = "Namn:";
            this.urlnamnlbl.Click += new System.EventHandler(this.urlnamnlbl_Click);
            // 
            // urlNamntxt
            // 
            this.urlNamntxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlNamntxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.urlNamntxt.Location = new System.Drawing.Point(33, 468);
            this.urlNamntxt.Name = "urlNamntxt";
            this.urlNamntxt.Size = new System.Drawing.Size(260, 30);
            this.urlNamntxt.TabIndex = 4;
            this.urlNamntxt.TextChanged += new System.EventHandler(this.urlNamntxt_TextChanged);
            // 
            // uppdateringfrekbox
            // 
            this.uppdateringfrekbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppdateringfrekbox.FormattingEnabled = true;
            this.uppdateringfrekbox.Location = new System.Drawing.Point(412, 394);
            this.uppdateringfrekbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uppdateringfrekbox.Name = "uppdateringfrekbox";
            this.uppdateringfrekbox.Size = new System.Drawing.Size(242, 30);
            this.uppdateringfrekbox.TabIndex = 6;
            this.uppdateringfrekbox.SelectedIndexChanged += new System.EventHandler(this.uppdateringfrekbox_SelectedIndexChanged);
            // 
            // kategoribox
            // 
            this.kategoribox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoribox.FormattingEnabled = true;
            this.kategoribox.Location = new System.Drawing.Point(696, 392);
            this.kategoribox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kategoribox.Name = "kategoribox";
            this.kategoribox.Size = new System.Drawing.Size(156, 30);
            this.kategoribox.TabIndex = 7;
            this.kategoribox.SelectedIndexChanged += new System.EventHandler(this.kategoribox_SelectedIndexChanged);
            // 
            // sparabtn
            // 
            this.sparabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sparabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sparabtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparabtn.ForeColor = System.Drawing.SystemColors.Window;
            this.sparabtn.Location = new System.Drawing.Point(564, 457);
            this.sparabtn.Name = "sparabtn";
            this.sparabtn.Size = new System.Drawing.Size(112, 51);
            this.sparabtn.TabIndex = 8;
            this.sparabtn.Text = "SPARA";
            this.sparabtn.UseVisualStyleBackColor = false;
            this.sparabtn.Click += new System.EventHandler(this.sparabtn_Click);
            // 
            // tabortbtn
            // 
            this.tabortbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabortbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabortbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabortbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.tabortbtn.Location = new System.Drawing.Point(717, 457);
            this.tabortbtn.Name = "tabortbtn";
            this.tabortbtn.Size = new System.Drawing.Size(136, 51);
            this.tabortbtn.TabIndex = 9;
            this.tabortbtn.Text = "TA BORT";
            this.tabortbtn.UseVisualStyleBackColor = false;
            this.tabortbtn.Click += new System.EventHandler(this.tabortbtn_Click);
            // 
            // uppdateringsfrekvenslbl
            // 
            this.uppdateringsfrekvenslbl.AutoSize = true;
            this.uppdateringsfrekvenslbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppdateringsfrekvenslbl.Location = new System.Drawing.Point(406, 360);
            this.uppdateringsfrekvenslbl.Name = "uppdateringsfrekvenslbl";
            this.uppdateringsfrekvenslbl.Size = new System.Drawing.Size(228, 27);
            this.uppdateringsfrekvenslbl.TabIndex = 10;
            this.uppdateringsfrekvenslbl.Text = "Uppdateringsfrekvens:";
            // 
            // kategorilbl
            // 
            this.kategorilbl.AutoSize = true;
            this.kategorilbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorilbl.Location = new System.Drawing.Point(690, 362);
            this.kategorilbl.Name = "kategorilbl";
            this.kategorilbl.Size = new System.Drawing.Size(101, 27);
            this.kategorilbl.TabIndex = 11;
            this.kategorilbl.Text = "Kategori:";
            // 
            // avsnittlbl
            // 
            this.avsnittlbl.AutoSize = true;
            this.avsnittlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsnittlbl.Location = new System.Drawing.Point(28, 525);
            this.avsnittlbl.Name = "avsnittlbl";
            this.avsnittlbl.Size = new System.Drawing.Size(86, 27);
            this.avsnittlbl.TabIndex = 13;
            this.avsnittlbl.Text = "Avsnitt:";
            // 
            // beskrivninglbl
            // 
            this.beskrivninglbl.AutoSize = true;
            this.beskrivninglbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beskrivninglbl.Location = new System.Drawing.Point(904, 525);
            this.beskrivninglbl.Name = "beskrivninglbl";
            this.beskrivninglbl.Size = new System.Drawing.Size(133, 27);
            this.beskrivninglbl.TabIndex = 15;
            this.beskrivninglbl.Text = "Beskrivning:";
            // 
            // kategorierlistbox
            // 
            this.kategorierlistbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorierlistbox.FormattingEnabled = true;
            this.kategorierlistbox.ItemHeight = 22;
            this.kategorierlistbox.Location = new System.Drawing.Point(909, 115);
            this.kategorierlistbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kategorierlistbox.Name = "kategorierlistbox";
            this.kategorierlistbox.Size = new System.Drawing.Size(235, 312);
            this.kategorierlistbox.TabIndex = 16;
            this.kategorierlistbox.SelectedIndexChanged += new System.EventHandler(this.kategorierlistbox_SelectedIndexChanged);
            // 
            // kategorierlbl
            // 
            this.kategorierlbl.AutoSize = true;
            this.kategorierlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorierlbl.Location = new System.Drawing.Point(903, 12);
            this.kategorierlbl.Name = "kategorierlbl";
            this.kategorierlbl.Size = new System.Drawing.Size(120, 27);
            this.kategorierlbl.TabIndex = 17;
            this.kategorierlbl.Text = "Kategorier:";
            // 
            // nyKategoriBtn
            // 
            this.nyKategoriBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nyKategoriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nyKategoriBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyKategoriBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.nyKategoriBtn.Location = new System.Drawing.Point(1165, 115);
            this.nyKategoriBtn.Name = "nyKategoriBtn";
            this.nyKategoriBtn.Size = new System.Drawing.Size(200, 51);
            this.nyKategoriBtn.TabIndex = 18;
            this.nyKategoriBtn.Text = "LÄGG TILL";
            this.nyKategoriBtn.UseVisualStyleBackColor = false;
            this.nyKategoriBtn.Click += new System.EventHandler(this.laggtillbtn2_Click);
            // 
            // sparabtn2
            // 
            this.sparabtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sparabtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sparabtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparabtn2.ForeColor = System.Drawing.SystemColors.Window;
            this.sparabtn2.Location = new System.Drawing.Point(1165, 202);
            this.sparabtn2.Name = "sparabtn2";
            this.sparabtn2.Size = new System.Drawing.Size(200, 51);
            this.sparabtn2.TabIndex = 19;
            this.sparabtn2.Text = "SPARA";
            this.sparabtn2.UseVisualStyleBackColor = false;
            this.sparabtn2.Click += new System.EventHandler(this.sparabtn2_Click);
            // 
            // tabortbtn2
            // 
            this.tabortbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabortbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabortbtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabortbtn2.ForeColor = System.Drawing.SystemColors.Window;
            this.tabortbtn2.Location = new System.Drawing.Point(1165, 289);
            this.tabortbtn2.Name = "tabortbtn2";
            this.tabortbtn2.Size = new System.Drawing.Size(200, 51);
            this.tabortbtn2.TabIndex = 20;
            this.tabortbtn2.Text = "TA BORT";
            this.tabortbtn2.UseVisualStyleBackColor = false;
            this.tabortbtn2.Click += new System.EventHandler(this.tabortbtn2_Click);
            // 
            // beskrivningtxt
            // 
            this.beskrivningtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beskrivningtxt.Location = new System.Drawing.Point(909, 557);
            this.beskrivningtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beskrivningtxt.Multiline = true;
            this.beskrivningtxt.Name = "beskrivningtxt";
            this.beskrivningtxt.Size = new System.Drawing.Size(456, 224);
            this.beskrivningtxt.TabIndex = 22;
            // 
            // namnKategoritxt
            // 
            this.namnKategoritxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnKategoritxt.Location = new System.Drawing.Point(909, 48);
            this.namnKategoritxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namnKategoritxt.Multiline = true;
            this.namnKategoritxt.Name = "namnKategoritxt";
            this.namnKategoritxt.Size = new System.Drawing.Size(235, 47);
            this.namnKategoritxt.TabIndex = 23;
            // 
            // avsnittlistbox
            // 
            this.avsnittlistbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsnittlistbox.FormattingEnabled = true;
            this.avsnittlistbox.ItemHeight = 22;
            this.avsnittlistbox.Location = new System.Drawing.Point(32, 557);
            this.avsnittlistbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avsnittlistbox.Name = "avsnittlistbox";
            this.avsnittlistbox.Size = new System.Drawing.Size(820, 224);
            this.avsnittlistbox.TabIndex = 24;
            this.avsnittlistbox.SelectedIndexChanged += new System.EventHandler(this.avsnittlistbox_SelectedIndexChanged);
            // 
            // tabbelListView
            // 
            this.tabbelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namn,
            this.antalAvsnitt,
            this.uppdateringsFrekvens,
            this.kategori});
            this.tabbelListView.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbelListView.HideSelection = false;
            this.tabbelListView.Location = new System.Drawing.Point(33, 48);
            this.tabbelListView.Name = "tabbelListView";
            this.tabbelListView.Size = new System.Drawing.Size(820, 292);
            this.tabbelListView.TabIndex = 25;
            this.tabbelListView.UseCompatibleStateImageBehavior = false;
            this.tabbelListView.View = System.Windows.Forms.View.Details;
            this.tabbelListView.SelectedIndexChanged += new System.EventHandler(this.tabbelListView_SelectedIndexChanged);
            // 
            // namn
            // 
            this.namn.Text = "Namn";
            // 
            // antalAvsnitt
            // 
            this.antalAvsnitt.Text = "Avsnitt";
            this.antalAvsnitt.Width = 81;
            // 
            // uppdateringsFrekvens
            // 
            this.uppdateringsFrekvens.Text = "Frekvens";
            this.uppdateringsFrekvens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uppdateringsFrekvens.Width = 105;
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori";
            this.kategori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kategori.Width = 95;
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.resetbtn.Location = new System.Drawing.Point(1165, 373);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(200, 51);
            this.resetbtn.TabIndex = 26;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // btnVisaInfo
            // 
            this.btnVisaInfo.Location = new System.Drawing.Point(310, 514);
            this.btnVisaInfo.Name = "btnVisaInfo";
            this.btnVisaInfo.Size = new System.Drawing.Size(239, 34);
            this.btnVisaInfo.TabIndex = 27;
            this.btnVisaInfo.Text = "Visa Information om podcast";
            this.btnVisaInfo.UseVisualStyleBackColor = true;
            this.btnVisaInfo.Click += new System.EventHandler(this.btnVisaInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1421, 841);
            this.Controls.Add(this.btnVisaInfo);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.tabbelListView);
            this.Controls.Add(this.avsnittlistbox);
            this.Controls.Add(this.namnKategoritxt);
            this.Controls.Add(this.beskrivningtxt);
            this.Controls.Add(this.tabortbtn2);
            this.Controls.Add(this.sparabtn2);
            this.Controls.Add(this.nyKategoriBtn);
            this.Controls.Add(this.kategorierlbl);
            this.Controls.Add(this.kategorierlistbox);
            this.Controls.Add(this.beskrivninglbl);
            this.Controls.Add(this.avsnittlbl);
            this.Controls.Add(this.kategorilbl);
            this.Controls.Add(this.uppdateringsfrekvenslbl);
            this.Controls.Add(this.tabortbtn);
            this.Controls.Add(this.sparabtn);
            this.Controls.Add(this.kategoribox);
            this.Controls.Add(this.uppdateringfrekbox);
            this.Controls.Add(this.urlNamntxt);
            this.Controls.Add(this.urlnamnlbl);
            this.Controls.Add(this.laggtillbtn);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.urllbl);
            this.Name = "Form1";
            this.Text = "RSS-feed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urllbl;
        private System.Windows.Forms.TextBox urltxt;
        private System.Windows.Forms.Button laggtillbtn;
        private System.Windows.Forms.Label urlnamnlbl;
        private System.Windows.Forms.TextBox urlNamntxt;
        private System.Windows.Forms.ComboBox uppdateringfrekbox;
        private System.Windows.Forms.ComboBox kategoribox;
        private System.Windows.Forms.Button sparabtn;
        private System.Windows.Forms.Button tabortbtn;
        private System.Windows.Forms.Label uppdateringsfrekvenslbl;
        private System.Windows.Forms.Label kategorilbl;
        private System.Windows.Forms.Label avsnittlbl;
        private System.Windows.Forms.Label beskrivninglbl;
        private System.Windows.Forms.ListBox kategorierlistbox;
        private System.Windows.Forms.Label kategorierlbl;
        private System.Windows.Forms.Button nyKategoriBtn;
        private System.Windows.Forms.Button sparabtn2;
        private System.Windows.Forms.Button tabortbtn2;
        private System.Windows.Forms.TextBox beskrivningtxt;
        private System.Windows.Forms.TextBox namnKategoritxt;
        private System.Windows.Forms.ListBox avsnittlistbox;
        private System.Windows.Forms.ListView tabbelListView;
        private System.Windows.Forms.ColumnHeader antalAvsnitt;
        private System.Windows.Forms.ColumnHeader uppdateringsFrekvens;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.ColumnHeader namn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button btnVisaInfo;
    }
}

