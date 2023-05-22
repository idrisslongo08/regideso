namespace regideso
{
    partial class REGIDESO
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.sms = new MaterialSkin.Controls.MaterialRadioButton();
            this.numero_abonne = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.message_abonne = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.postnom_abonne = new MaterialSkin.Controls.MaterialTextBox2();
            this.nom_abonne = new MaterialSkin.Controls.MaterialTextBox2();
            this.envoyer_facture = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantite_consomme = new MaterialSkin.Controls.MaterialTextBox2();
            this.prix = new MaterialSkin.Controls.MaterialTextBox2();
            this.prix_totale = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numero_fact_text = new MaterialSkin.Controls.MaterialTextBox2();
            this.label9 = new System.Windows.Forms.Label();
            this.numero_fact = new MaterialSkin.Controls.MaterialButton();
            this.telephone_abonne = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mail_abonne = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calculer_fact = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.identifiant = new MaterialSkin.Controls.MaterialTextBox2();
            this.label13 = new System.Windows.Forms.Label();
            this.envoyer_sms = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(13, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 588);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialFloatingActionButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1176, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Facturation";
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = null;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(1022, 3);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(78, 81);
            this.materialFloatingActionButton2.TabIndex = 4;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(13, 694);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(232, 47);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "refresh";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Depth = 0;
            this.sms.Location = new System.Drawing.Point(994, 699);
            this.sms.Margin = new System.Windows.Forms.Padding(0);
            this.sms.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sms.MouseState = MaterialSkin.MouseState.HOVER;
            this.sms.Name = "sms";
            this.sms.Ripple = true;
            this.sms.Size = new System.Drawing.Size(158, 37);
            this.sms.TabIndex = 5;
            this.sms.TabStop = true;
            this.sms.Text = "Signaler par SMS";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // numero_abonne
            // 
            this.numero_abonne.AllowPromptAsInput = true;
            this.numero_abonne.AnimateReadOnly = false;
            this.numero_abonne.AsciiOnly = false;
            this.numero_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numero_abonne.BeepOnError = false;
            this.numero_abonne.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.numero_abonne.Depth = 0;
            this.numero_abonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numero_abonne.HidePromptOnLeave = false;
            this.numero_abonne.HideSelection = true;
            this.numero_abonne.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.numero_abonne.LeadingIcon = null;
            this.numero_abonne.Location = new System.Drawing.Point(994, 392);
            this.numero_abonne.Mask = "";
            this.numero_abonne.MaxLength = 32767;
            this.numero_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.numero_abonne.Name = "numero_abonne";
            this.numero_abonne.PasswordChar = '\0';
            this.numero_abonne.PrefixSuffixText = null;
            this.numero_abonne.PromptChar = '_';
            this.numero_abonne.ReadOnly = false;
            this.numero_abonne.RejectInputOnFirstFailure = false;
            this.numero_abonne.ResetOnPrompt = true;
            this.numero_abonne.ResetOnSpace = true;
            this.numero_abonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numero_abonne.SelectedText = "";
            this.numero_abonne.SelectionLength = 0;
            this.numero_abonne.SelectionStart = 0;
            this.numero_abonne.ShortcutsEnabled = true;
            this.numero_abonne.Size = new System.Drawing.Size(190, 48);
            this.numero_abonne.SkipLiterals = true;
            this.numero_abonne.TabIndex = 7;
            this.numero_abonne.TabStop = false;
            this.numero_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numero_abonne.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.numero_abonne.TrailingIcon = null;
            this.numero_abonne.UseSystemPasswordChar = false;
            this.numero_abonne.ValidatingType = null;
            // 
            // message_abonne
            // 
            this.message_abonne.AnimateReadOnly = false;
            this.message_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.message_abonne.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.message_abonne.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message_abonne.Depth = 0;
            this.message_abonne.HideSelection = true;
            this.message_abonne.Location = new System.Drawing.Point(994, 555);
            this.message_abonne.MaxLength = 32767;
            this.message_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.message_abonne.Name = "message_abonne";
            this.message_abonne.PasswordChar = '\0';
            this.message_abonne.ReadOnly = false;
            this.message_abonne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.message_abonne.SelectedText = "";
            this.message_abonne.SelectionLength = 0;
            this.message_abonne.SelectionStart = 0;
            this.message_abonne.ShortcutsEnabled = true;
            this.message_abonne.Size = new System.Drawing.Size(503, 125);
            this.message_abonne.TabIndex = 8;
            this.message_abonne.TabStop = false;
            this.message_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.message_abonne.UseSystemPasswordChar = false;
            // 
            // postnom_abonne
            // 
            this.postnom_abonne.AnimateReadOnly = false;
            this.postnom_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.postnom_abonne.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.postnom_abonne.Depth = 0;
            this.postnom_abonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.postnom_abonne.HideSelection = true;
            this.postnom_abonne.LeadingIcon = null;
            this.postnom_abonne.Location = new System.Drawing.Point(994, 301);
            this.postnom_abonne.MaxLength = 32767;
            this.postnom_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.postnom_abonne.Name = "postnom_abonne";
            this.postnom_abonne.PasswordChar = '\0';
            this.postnom_abonne.PrefixSuffixText = null;
            this.postnom_abonne.ReadOnly = false;
            this.postnom_abonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postnom_abonne.SelectedText = "";
            this.postnom_abonne.SelectionLength = 0;
            this.postnom_abonne.SelectionStart = 0;
            this.postnom_abonne.ShortcutsEnabled = true;
            this.postnom_abonne.Size = new System.Drawing.Size(190, 48);
            this.postnom_abonne.TabIndex = 10;
            this.postnom_abonne.TabStop = false;
            this.postnom_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.postnom_abonne.TrailingIcon = null;
            this.postnom_abonne.UseSystemPasswordChar = false;
            // 
            // nom_abonne
            // 
            this.nom_abonne.AnimateReadOnly = false;
            this.nom_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nom_abonne.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nom_abonne.Depth = 0;
            this.nom_abonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nom_abonne.HideSelection = true;
            this.nom_abonne.LeadingIcon = null;
            this.nom_abonne.Location = new System.Drawing.Point(994, 207);
            this.nom_abonne.MaxLength = 32767;
            this.nom_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.nom_abonne.Name = "nom_abonne";
            this.nom_abonne.PasswordChar = '\0';
            this.nom_abonne.PrefixSuffixText = null;
            this.nom_abonne.ReadOnly = false;
            this.nom_abonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nom_abonne.SelectedText = "";
            this.nom_abonne.SelectionLength = 0;
            this.nom_abonne.SelectionStart = 0;
            this.nom_abonne.ShortcutsEnabled = true;
            this.nom_abonne.Size = new System.Drawing.Size(190, 48);
            this.nom_abonne.TabIndex = 11;
            this.nom_abonne.TabStop = false;
            this.nom_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nom_abonne.TrailingIcon = null;
            this.nom_abonne.UseSystemPasswordChar = false;
            // 
            // envoyer_facture
            // 
            this.envoyer_facture.AutoSize = false;
            this.envoyer_facture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.envoyer_facture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.envoyer_facture.Depth = 0;
            this.envoyer_facture.HighEmphasis = true;
            this.envoyer_facture.Icon = null;
            this.envoyer_facture.Location = new System.Drawing.Point(1248, 689);
            this.envoyer_facture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.envoyer_facture.MouseState = MaterialSkin.MouseState.HOVER;
            this.envoyer_facture.Name = "envoyer_facture";
            this.envoyer_facture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.envoyer_facture.Size = new System.Drawing.Size(219, 47);
            this.envoyer_facture.TabIndex = 12;
            this.envoyer_facture.Text = "Envoyer facture";
            this.envoyer_facture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.envoyer_facture.UseAccentColor = false;
            this.envoyer_facture.UseVisualStyleBackColor = true;
            this.envoyer_facture.Click += new System.EventHandler(this.envoyer_facture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(991, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "nom abonné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(990, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "post nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(991, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "numero abonné";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(995, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "message à l\'abonné";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1213, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1213, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "prix (/M³)";
            // 
            // quantite_consomme
            // 
            this.quantite_consomme.AnimateReadOnly = false;
            this.quantite_consomme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quantite_consomme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantite_consomme.Depth = 0;
            this.quantite_consomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quantite_consomme.HideSelection = true;
            this.quantite_consomme.LeadingIcon = null;
            this.quantite_consomme.Location = new System.Drawing.Point(1216, 207);
            this.quantite_consomme.MaxLength = 32767;
            this.quantite_consomme.MouseState = MaterialSkin.MouseState.OUT;
            this.quantite_consomme.Name = "quantite_consomme";
            this.quantite_consomme.PasswordChar = '\0';
            this.quantite_consomme.PrefixSuffixText = null;
            this.quantite_consomme.ReadOnly = false;
            this.quantite_consomme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantite_consomme.SelectedText = "";
            this.quantite_consomme.SelectionLength = 0;
            this.quantite_consomme.SelectionStart = 0;
            this.quantite_consomme.ShortcutsEnabled = true;
            this.quantite_consomme.Size = new System.Drawing.Size(161, 48);
            this.quantite_consomme.TabIndex = 20;
            this.quantite_consomme.TabStop = false;
            this.quantite_consomme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantite_consomme.TrailingIcon = null;
            this.quantite_consomme.UseSystemPasswordChar = false;
            // 
            // prix
            // 
            this.prix.AnimateReadOnly = false;
            this.prix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prix.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prix.Depth = 0;
            this.prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prix.HideSelection = true;
            this.prix.LeadingIcon = null;
            this.prix.Location = new System.Drawing.Point(1216, 301);
            this.prix.MaxLength = 32767;
            this.prix.MouseState = MaterialSkin.MouseState.OUT;
            this.prix.Name = "prix";
            this.prix.PasswordChar = '\0';
            this.prix.PrefixSuffixText = null;
            this.prix.ReadOnly = false;
            this.prix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix.SelectedText = "";
            this.prix.SelectionLength = 0;
            this.prix.SelectionStart = 0;
            this.prix.ShortcutsEnabled = true;
            this.prix.Size = new System.Drawing.Size(281, 48);
            this.prix.TabIndex = 19;
            this.prix.TabStop = false;
            this.prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prix.TrailingIcon = null;
            this.prix.UseSystemPasswordChar = false;
            // 
            // prix_totale
            // 
            this.prix_totale.AllowPromptAsInput = true;
            this.prix_totale.AnimateReadOnly = false;
            this.prix_totale.AsciiOnly = false;
            this.prix_totale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prix_totale.BeepOnError = false;
            this.prix_totale.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.prix_totale.Depth = 0;
            this.prix_totale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prix_totale.HidePromptOnLeave = false;
            this.prix_totale.HideSelection = true;
            this.prix_totale.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.prix_totale.LeadingIcon = null;
            this.prix_totale.Location = new System.Drawing.Point(1216, 392);
            this.prix_totale.Mask = "";
            this.prix_totale.MaxLength = 32767;
            this.prix_totale.MouseState = MaterialSkin.MouseState.OUT;
            this.prix_totale.Name = "prix_totale";
            this.prix_totale.PasswordChar = '\0';
            this.prix_totale.PrefixSuffixText = null;
            this.prix_totale.PromptChar = '_';
            this.prix_totale.ReadOnly = false;
            this.prix_totale.RejectInputOnFirstFailure = false;
            this.prix_totale.ResetOnPrompt = true;
            this.prix_totale.ResetOnSpace = true;
            this.prix_totale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix_totale.SelectedText = "";
            this.prix_totale.SelectionLength = 0;
            this.prix_totale.SelectionStart = 0;
            this.prix_totale.ShortcutsEnabled = true;
            this.prix_totale.Size = new System.Drawing.Size(161, 48);
            this.prix_totale.SkipLiterals = true;
            this.prix_totale.TabIndex = 18;
            this.prix_totale.TabStop = false;
            this.prix_totale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prix_totale.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.prix_totale.TrailingIcon = null;
            this.prix_totale.UseSystemPasswordChar = false;
            this.prix_totale.ValidatingType = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1213, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantité consomée(en M³)";
            // 
            // numero_fact_text
            // 
            this.numero_fact_text.AnimateReadOnly = false;
            this.numero_fact_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numero_fact_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.numero_fact_text.Depth = 0;
            this.numero_fact_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numero_fact_text.HideSelection = true;
            this.numero_fact_text.LeadingIcon = null;
            this.numero_fact_text.Location = new System.Drawing.Point(1293, 97);
            this.numero_fact_text.MaxLength = 32767;
            this.numero_fact_text.MouseState = MaterialSkin.MouseState.OUT;
            this.numero_fact_text.Name = "numero_fact_text";
            this.numero_fact_text.PasswordChar = '\0';
            this.numero_fact_text.PrefixSuffixText = null;
            this.numero_fact_text.ReadOnly = false;
            this.numero_fact_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numero_fact_text.SelectedText = "";
            this.numero_fact_text.SelectionLength = 0;
            this.numero_fact_text.SelectionStart = 0;
            this.numero_fact_text.ShortcutsEnabled = true;
            this.numero_fact_text.Size = new System.Drawing.Size(84, 48);
            this.numero_fact_text.TabIndex = 24;
            this.numero_fact_text.TabStop = false;
            this.numero_fact_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numero_fact_text.TrailingIcon = null;
            this.numero_fact_text.UseSystemPasswordChar = false;
            this.numero_fact_text.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1244, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 25;
            // 
            // numero_fact
            // 
            this.numero_fact.AutoSize = false;
            this.numero_fact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.numero_fact.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.numero_fact.Depth = 0;
            this.numero_fact.HighEmphasis = true;
            this.numero_fact.Icon = null;
            this.numero_fact.Location = new System.Drawing.Point(1384, 97);
            this.numero_fact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numero_fact.MouseState = MaterialSkin.MouseState.HOVER;
            this.numero_fact.Name = "numero_fact";
            this.numero_fact.NoAccentTextColor = System.Drawing.Color.Empty;
            this.numero_fact.Size = new System.Drawing.Size(113, 48);
            this.numero_fact.TabIndex = 26;
            this.numero_fact.Text = "Generer";
            this.numero_fact.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.numero_fact.UseAccentColor = false;
            this.numero_fact.UseVisualStyleBackColor = true;
            this.numero_fact.Click += new System.EventHandler(this.numero_fact_Click);
            // 
            // telephone_abonne
            // 
            this.telephone_abonne.AllowPromptAsInput = true;
            this.telephone_abonne.AnimateReadOnly = false;
            this.telephone_abonne.AsciiOnly = false;
            this.telephone_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.telephone_abonne.BeepOnError = false;
            this.telephone_abonne.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.telephone_abonne.Depth = 0;
            this.telephone_abonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.telephone_abonne.HidePromptOnLeave = false;
            this.telephone_abonne.HideSelection = true;
            this.telephone_abonne.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.telephone_abonne.LeadingIcon = null;
            this.telephone_abonne.Location = new System.Drawing.Point(995, 474);
            this.telephone_abonne.Mask = "";
            this.telephone_abonne.MaxLength = 32767;
            this.telephone_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.telephone_abonne.Name = "telephone_abonne";
            this.telephone_abonne.PasswordChar = '\0';
            this.telephone_abonne.PrefixSuffixText = null;
            this.telephone_abonne.PromptChar = '_';
            this.telephone_abonne.ReadOnly = false;
            this.telephone_abonne.RejectInputOnFirstFailure = false;
            this.telephone_abonne.ResetOnPrompt = true;
            this.telephone_abonne.ResetOnSpace = true;
            this.telephone_abonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.telephone_abonne.SelectedText = "";
            this.telephone_abonne.SelectionLength = 0;
            this.telephone_abonne.SelectionStart = 0;
            this.telephone_abonne.ShortcutsEnabled = true;
            this.telephone_abonne.Size = new System.Drawing.Size(190, 48);
            this.telephone_abonne.SkipLiterals = true;
            this.telephone_abonne.TabIndex = 27;
            this.telephone_abonne.TabStop = false;
            this.telephone_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.telephone_abonne.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.telephone_abonne.TrailingIcon = null;
            this.telephone_abonne.UseSystemPasswordChar = false;
            this.telephone_abonne.ValidatingType = null;
            // 
            // mail_abonne
            // 
            this.mail_abonne.AllowPromptAsInput = true;
            this.mail_abonne.AnimateReadOnly = false;
            this.mail_abonne.AsciiOnly = false;
            this.mail_abonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mail_abonne.BeepOnError = false;
            this.mail_abonne.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mail_abonne.Depth = 0;
            this.mail_abonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mail_abonne.HidePromptOnLeave = false;
            this.mail_abonne.HideSelection = true;
            this.mail_abonne.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mail_abonne.LeadingIcon = null;
            this.mail_abonne.Location = new System.Drawing.Point(1217, 474);
            this.mail_abonne.Mask = "";
            this.mail_abonne.MaxLength = 32767;
            this.mail_abonne.MouseState = MaterialSkin.MouseState.OUT;
            this.mail_abonne.Name = "mail_abonne";
            this.mail_abonne.PasswordChar = '\0';
            this.mail_abonne.PrefixSuffixText = null;
            this.mail_abonne.PromptChar = '_';
            this.mail_abonne.ReadOnly = false;
            this.mail_abonne.RejectInputOnFirstFailure = false;
            this.mail_abonne.ResetOnPrompt = true;
            this.mail_abonne.ResetOnSpace = true;
            this.mail_abonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mail_abonne.SelectedText = "";
            this.mail_abonne.SelectionLength = 0;
            this.mail_abonne.SelectionStart = 0;
            this.mail_abonne.ShortcutsEnabled = true;
            this.mail_abonne.Size = new System.Drawing.Size(280, 48);
            this.mail_abonne.SkipLiterals = true;
            this.mail_abonne.TabIndex = 28;
            this.mail_abonne.TabStop = false;
            this.mail_abonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mail_abonne.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mail_abonne.TrailingIcon = null;
            this.mail_abonne.UseSystemPasswordChar = false;
            this.mail_abonne.ValidatingType = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(991, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "telephone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1213, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "adresse mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1218, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "N°";
            // 
            // calculer_fact
            // 
            this.calculer_fact.AutoSize = false;
            this.calculer_fact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculer_fact.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.calculer_fact.Depth = 0;
            this.calculer_fact.HighEmphasis = true;
            this.calculer_fact.Icon = null;
            this.calculer_fact.Location = new System.Drawing.Point(1384, 392);
            this.calculer_fact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calculer_fact.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculer_fact.Name = "calculer_fact";
            this.calculer_fact.NoAccentTextColor = System.Drawing.Color.Empty;
            this.calculer_fact.Size = new System.Drawing.Size(113, 48);
            this.calculer_fact.TabIndex = 32;
            this.calculer_fact.Text = "CALCULEER";
            this.calculer_fact.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.calculer_fact.UseAccentColor = false;
            this.calculer_fact.UseVisualStyleBackColor = true;
            this.calculer_fact.Click += new System.EventHandler(this.calculer_fact_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(1393, 208);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(113, 48);
            this.materialButton2.TabIndex = 33;
            this.materialButton2.Text = "search";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // identifiant
            // 
            this.identifiant.AnimateReadOnly = false;
            this.identifiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.identifiant.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.identifiant.Depth = 0;
            this.identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.identifiant.HideSelection = true;
            this.identifiant.LeadingIcon = null;
            this.identifiant.Location = new System.Drawing.Point(1049, 103);
            this.identifiant.MaxLength = 32767;
            this.identifiant.MouseState = MaterialSkin.MouseState.OUT;
            this.identifiant.Name = "identifiant";
            this.identifiant.PasswordChar = '\0';
            this.identifiant.PrefixSuffixText = null;
            this.identifiant.ReadOnly = false;
            this.identifiant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.identifiant.SelectedText = "";
            this.identifiant.SelectionLength = 0;
            this.identifiant.SelectionStart = 0;
            this.identifiant.ShortcutsEnabled = true;
            this.identifiant.Size = new System.Drawing.Size(135, 48);
            this.identifiant.TabIndex = 34;
            this.identifiant.TabStop = false;
            this.identifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.identifiant.TrailingIcon = null;
            this.identifiant.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(994, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 29);
            this.label13.TabIndex = 35;
            this.label13.Text = "#ID";
            // 
            // envoyer_sms
            // 
            this.envoyer_sms.AutoSize = false;
            this.envoyer_sms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.envoyer_sms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.envoyer_sms.Depth = 0;
            this.envoyer_sms.HighEmphasis = true;
            this.envoyer_sms.Icon = null;
            this.envoyer_sms.Location = new System.Drawing.Point(1248, 748);
            this.envoyer_sms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.envoyer_sms.MouseState = MaterialSkin.MouseState.HOVER;
            this.envoyer_sms.Name = "envoyer_sms";
            this.envoyer_sms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.envoyer_sms.Size = new System.Drawing.Size(219, 47);
            this.envoyer_sms.TabIndex = 36;
            this.envoyer_sms.Text = "Envoyer sms";
            this.envoyer_sms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.envoyer_sms.UseAccentColor = false;
            this.envoyer_sms.UseVisualStyleBackColor = true;
            this.envoyer_sms.Click += new System.EventHandler(this.envoyer_sms_Click);
            // 
            // REGIDESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 803);
            this.Controls.Add(this.envoyer_sms);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.calculer_fact);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mail_abonne);
            this.Controls.Add(this.telephone_abonne);
            this.Controls.Add(this.numero_fact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numero_fact_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantite_consomme);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.prix_totale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.envoyer_facture);
            this.Controls.Add(this.nom_abonne);
            this.Controls.Add(this.postnom_abonne);
            this.Controls.Add(this.message_abonne);
            this.Controls.Add(this.numero_abonne);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "REGIDESO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGIDESO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialRadioButton sms;
        private MaterialSkin.Controls.MaterialMaskedTextBox numero_abonne;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 message_abonne;
        private MaterialSkin.Controls.MaterialTextBox2 postnom_abonne;
        private MaterialSkin.Controls.MaterialTextBox2 nom_abonne;
        private MaterialSkin.Controls.MaterialButton envoyer_facture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 quantite_consomme;
        private MaterialSkin.Controls.MaterialTextBox2 prix;
        private MaterialSkin.Controls.MaterialMaskedTextBox prix_totale;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox2 numero_fact_text;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialButton numero_fact;
        private MaterialSkin.Controls.MaterialMaskedTextBox telephone_abonne;
        private MaterialSkin.Controls.MaterialMaskedTextBox mail_abonne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialButton calculer_fact;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox2 identifiant;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialButton envoyer_sms;
    }
}

