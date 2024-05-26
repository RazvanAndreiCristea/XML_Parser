namespace FirmaCurierat
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXmlFilePath = new System.Windows.Forms.TextBox();
            this.tbJsonFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseXmlFile = new System.Windows.Forms.Button();
            this.btnBrowseJsonFile = new System.Windows.Forms.Button();
            this.lvFileContent = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipLivrare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeDestinatar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expeditor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataProgramata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stareLivrare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locatieCurenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dimensiuniColet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.greutate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipAmbalaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.continut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnParseXml = new System.Windows.Forms.Button();
            this.btnParseJson = new System.Windows.Forms.Button();
            this.btnShowXsl = new System.Windows.Forms.Button();
            this.cbFilterOptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilterKeyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.webXslStyle = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML file path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "JSON file path";
            // 
            // tbXmlFilePath
            // 
            this.tbXmlFilePath.Location = new System.Drawing.Point(198, 36);
            this.tbXmlFilePath.Name = "tbXmlFilePath";
            this.tbXmlFilePath.ReadOnly = true;
            this.tbXmlFilePath.Size = new System.Drawing.Size(529, 22);
            this.tbXmlFilePath.TabIndex = 2;
            // 
            // tbJsonFilePath
            // 
            this.tbJsonFilePath.Location = new System.Drawing.Point(198, 89);
            this.tbJsonFilePath.Name = "tbJsonFilePath";
            this.tbJsonFilePath.ReadOnly = true;
            this.tbJsonFilePath.Size = new System.Drawing.Size(529, 22);
            this.tbJsonFilePath.TabIndex = 3;
            // 
            // btnBrowseXmlFile
            // 
            this.btnBrowseXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseXmlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseXmlFile.Location = new System.Drawing.Point(771, 32);
            this.btnBrowseXmlFile.Name = "btnBrowseXmlFile";
            this.btnBrowseXmlFile.Size = new System.Drawing.Size(147, 34);
            this.btnBrowseXmlFile.TabIndex = 4;
            this.btnBrowseXmlFile.Text = "Browse XML";
            this.btnBrowseXmlFile.UseVisualStyleBackColor = true;
            this.btnBrowseXmlFile.Click += new System.EventHandler(this.btnBrowseXmlFile_Click);
            // 
            // btnBrowseJsonFile
            // 
            this.btnBrowseJsonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseJsonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseJsonFile.Location = new System.Drawing.Point(771, 83);
            this.btnBrowseJsonFile.Name = "btnBrowseJsonFile";
            this.btnBrowseJsonFile.Size = new System.Drawing.Size(147, 34);
            this.btnBrowseJsonFile.TabIndex = 5;
            this.btnBrowseJsonFile.Text = "Browse JSON";
            this.btnBrowseJsonFile.UseVisualStyleBackColor = true;
            this.btnBrowseJsonFile.Click += new System.EventHandler(this.btnBrowseJsonFile_Click);
            // 
            // lvFileContent
            // 
            this.lvFileContent.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.tipLivrare,
            this.numeDestinatar,
            this.telefon,
            this.email,
            this.adresa,
            this.expeditor,
            this.destinatie,
            this.dataProgramata,
            this.stareLivrare,
            this.locatieCurenta,
            this.dimensiuniColet,
            this.greutate,
            this.valoare,
            this.tipAmbalaj,
            this.continut});
            this.lvFileContent.FullRowSelect = true;
            this.lvFileContent.GridLines = true;
            this.lvFileContent.HideSelection = false;
            this.lvFileContent.Location = new System.Drawing.Point(12, 140);
            this.lvFileContent.Name = "lvFileContent";
            this.lvFileContent.Size = new System.Drawing.Size(1182, 226);
            this.lvFileContent.TabIndex = 6;
            this.lvFileContent.UseCompatibleStateImageBehavior = false;
            this.lvFileContent.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // tipLivrare
            // 
            this.tipLivrare.Text = "Tip livrare";
            this.tipLivrare.Width = 100;
            // 
            // numeDestinatar
            // 
            this.numeDestinatar.Text = "Nume destinatar";
            this.numeDestinatar.Width = 130;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 90;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 160;
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            this.adresa.Width = 180;
            // 
            // expeditor
            // 
            this.expeditor.Text = "Expeditor";
            this.expeditor.Width = 140;
            // 
            // destinatie
            // 
            this.destinatie.Text = "Destinatie";
            this.destinatie.Width = 180;
            // 
            // dataProgramata
            // 
            this.dataProgramata.Text = "Data programata";
            this.dataProgramata.Width = 100;
            // 
            // stareLivrare
            // 
            this.stareLivrare.Text = "Stare livrare";
            this.stareLivrare.Width = 120;
            // 
            // locatieCurenta
            // 
            this.locatieCurenta.Text = "Locatie curenta";
            this.locatieCurenta.Width = 180;
            // 
            // dimensiuniColet
            // 
            this.dimensiuniColet.Text = "Dimensiuni colet";
            this.dimensiuniColet.Width = 100;
            // 
            // greutate
            // 
            this.greutate.Text = "Greutate";
            this.greutate.Width = 80;
            // 
            // valoare
            // 
            this.valoare.Text = "Valoare";
            this.valoare.Width = 80;
            // 
            // tipAmbalaj
            // 
            this.tipAmbalaj.Text = "Tip Ambalaj";
            this.tipAmbalaj.Width = 100;
            // 
            // continut
            // 
            this.continut.Text = "Continut";
            this.continut.Width = 100;
            // 
            // btnParseXml
            // 
            this.btnParseXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParseXml.Enabled = false;
            this.btnParseXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseXml.Location = new System.Drawing.Point(1006, 32);
            this.btnParseXml.Name = "btnParseXml";
            this.btnParseXml.Size = new System.Drawing.Size(147, 34);
            this.btnParseXml.TabIndex = 7;
            this.btnParseXml.Text = "Parse XML";
            this.btnParseXml.UseVisualStyleBackColor = true;
            this.btnParseXml.Click += new System.EventHandler(this.btnParseXml_Click);
            // 
            // btnParseJson
            // 
            this.btnParseJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParseJson.Enabled = false;
            this.btnParseJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseJson.Location = new System.Drawing.Point(1006, 83);
            this.btnParseJson.Name = "btnParseJson";
            this.btnParseJson.Size = new System.Drawing.Size(147, 34);
            this.btnParseJson.TabIndex = 8;
            this.btnParseJson.Text = "Parse JSON";
            this.btnParseJson.UseVisualStyleBackColor = true;
            this.btnParseJson.Click += new System.EventHandler(this.btnParseJson_Click);
            // 
            // btnShowXsl
            // 
            this.btnShowXsl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShowXsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowXsl.Location = new System.Drawing.Point(12, 383);
            this.btnShowXsl.Name = "btnShowXsl";
            this.btnShowXsl.Size = new System.Drawing.Size(166, 34);
            this.btnShowXsl.TabIndex = 10;
            this.btnShowXsl.Text = "Show XSL";
            this.btnShowXsl.UseVisualStyleBackColor = true;
            this.btnShowXsl.Click += new System.EventHandler(this.btnShowXsl_Click);
            // 
            // cbFilterOptions
            // 
            this.cbFilterOptions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterOptions.FormattingEnabled = true;
            this.cbFilterOptions.Items.AddRange(new object[] {
            "None",
            "easybox",
            "domiciliu",
            "internationala"});
            this.cbFilterOptions.Location = new System.Drawing.Point(12, 464);
            this.cbFilterOptions.Name = "cbFilterOptions";
            this.cbFilterOptions.Size = new System.Drawing.Size(166, 24);
            this.cbFilterOptions.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter Criteria";
            // 
            // tbFilterKeyword
            // 
            this.tbFilterKeyword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFilterKeyword.Location = new System.Drawing.Point(12, 541);
            this.tbFilterKeyword.Name = "tbFilterKeyword";
            this.tbFilterKeyword.Size = new System.Drawing.Size(166, 22);
            this.tbFilterKeyword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Keyword Filter";
            // 
            // webXslStyle
            // 
            this.webXslStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webXslStyle.Location = new System.Drawing.Point(198, 383);
            this.webXslStyle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webXslStyle.Name = "webXslStyle";
            this.webXslStyle.Size = new System.Drawing.Size(996, 180);
            this.webXslStyle.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 593);
            this.Controls.Add(this.webXslStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFilterKeyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilterOptions);
            this.Controls.Add(this.btnShowXsl);
            this.Controls.Add(this.btnParseJson);
            this.Controls.Add(this.btnParseXml);
            this.Controls.Add(this.lvFileContent);
            this.Controls.Add(this.btnBrowseJsonFile);
            this.Controls.Add(this.btnBrowseXmlFile);
            this.Controls.Add(this.tbJsonFilePath);
            this.Controls.Add(this.tbXmlFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1225, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXmlFilePath;
        private System.Windows.Forms.TextBox tbJsonFilePath;
        private System.Windows.Forms.Button btnBrowseXmlFile;
        private System.Windows.Forms.Button btnBrowseJsonFile;
        private System.Windows.Forms.ListView lvFileContent;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader tipLivrare;
        private System.Windows.Forms.ColumnHeader numeDestinatar;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader expeditor;
        private System.Windows.Forms.ColumnHeader destinatie;
        private System.Windows.Forms.ColumnHeader dataProgramata;
        private System.Windows.Forms.ColumnHeader stareLivrare;
        private System.Windows.Forms.ColumnHeader locatieCurenta;
        private System.Windows.Forms.ColumnHeader dimensiuniColet;
        private System.Windows.Forms.ColumnHeader greutate;
        private System.Windows.Forms.ColumnHeader valoare;
        private System.Windows.Forms.ColumnHeader tipAmbalaj;
        private System.Windows.Forms.ColumnHeader continut;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Button btnParseXml;
        private System.Windows.Forms.Button btnParseJson;
        private System.Windows.Forms.Button btnShowXsl;
        private System.Windows.Forms.ComboBox cbFilterOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilterKeyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webXslStyle;
    }
}