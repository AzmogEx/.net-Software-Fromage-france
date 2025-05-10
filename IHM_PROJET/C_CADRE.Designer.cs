namespace IHM_PROJET {
    partial class C_CADRE {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_CADRE));
            La_Carte = new GMap.NET.WindowsForms.GMapControl();
            ListBox_Fromages = new ListBox();
            Label_Lait = new Label();
            Panel_Info_Fromage = new Panel();
            Button_Acheter = new MaterialSkin.Controls.MaterialButton();
            Button_Gmap = new MaterialSkin.Controls.MaterialButton();
            Button_WikiFromage = new MaterialSkin.Controls.MaterialButton();
            Edit_Fromage = new MaterialSkin.Controls.MaterialTextBox();
            Edit_Departements = new MaterialSkin.Controls.MaterialTextBox();
            ListBox_Departement = new ListBox();
            Label_Titre = new Label();
            Picture_Search = new PictureBox();
            Picture_Search_2 = new PictureBox();
            Label_Departement = new Label();
            Label_Fromages = new Label();
            Picture_Fromage = new PictureBox();
            Panel_Info_Fromage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture_Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Search_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Fromage).BeginInit();
            SuspendLayout();
            // 
            // La_Carte
            // 
            La_Carte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            La_Carte.Bearing = 0F;
            La_Carte.CanDragMap = true;
            La_Carte.EmptyTileColor = Color.Navy;
            La_Carte.GrayScaleMode = false;
            La_Carte.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            La_Carte.LevelsKeepInMemory = 5;
            La_Carte.Location = new Point(112,367);
            La_Carte.MarkersEnabled = true;
            La_Carte.MaxZoom = 20;
            La_Carte.MinZoom = 2;
            La_Carte.MouseWheelZoomEnabled = true;
            La_Carte.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            La_Carte.Name = "La_Carte";
            La_Carte.NegativeMode = false;
            La_Carte.PolygonsEnabled = true;
            La_Carte.RetryLoadTile = 0;
            La_Carte.RoutesEnabled = true;
            La_Carte.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            La_Carte.SelectedAreaFillColor = Color.FromArgb(33,65,105,225);
            La_Carte.ShowTileGridLines = false;
            La_Carte.Size = new Size(916,250);
            La_Carte.TabIndex = 0;
            La_Carte.Zoom = 0D;
            // 
            // ListBox_Fromages
            // 
            ListBox_Fromages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListBox_Fromages.FormattingEnabled = true;
            ListBox_Fromages.ItemHeight = 15;
            ListBox_Fromages.Location = new Point(381,73);
            ListBox_Fromages.Name = "ListBox_Fromages";
            ListBox_Fromages.Size = new Size(221,244);
            ListBox_Fromages.TabIndex = 2;
            ListBox_Fromages.SelectedIndexChanged += ListBox_Fromages_SelectedIndexChanged;
            // 
            // Label_Lait
            // 
            Label_Lait.AutoSize = true;
            Label_Lait.Font = new Font("Microsoft YaHei UI",20.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            Label_Lait.Location = new Point(25,29);
            Label_Lait.Name = "Label_Lait";
            Label_Lait.Size = new Size(73,36);
            Label_Lait.TabIndex = 3;
            Label_Lait.Text = "Lait:";
            // 
            // Panel_Info_Fromage
            // 
            Panel_Info_Fromage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Info_Fromage.BackColor = SystemColors.ButtonShadow;
            Panel_Info_Fromage.BorderStyle = BorderStyle.FixedSingle;
            Panel_Info_Fromage.Controls.Add(Button_Acheter);
            Panel_Info_Fromage.Controls.Add(Button_Gmap);
            Panel_Info_Fromage.Controls.Add(Button_WikiFromage);
            Panel_Info_Fromage.Controls.Add(Label_Lait);
            Panel_Info_Fromage.Location = new Point(773,94);
            Panel_Info_Fromage.Name = "Panel_Info_Fromage";
            Panel_Info_Fromage.Size = new Size(220,235);
            Panel_Info_Fromage.TabIndex = 4;
            // 
            // Button_Acheter
            // 
            Button_Acheter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button_Acheter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button_Acheter.Depth = 0;
            Button_Acheter.HighEmphasis = true;
            Button_Acheter.Icon = null;
            Button_Acheter.Location = new Point(66,179);
            Button_Acheter.Margin = new Padding(4,6,4,6);
            Button_Acheter.MouseState = MaterialSkin.MouseState.HOVER;
            Button_Acheter.Name = "Button_Acheter";
            Button_Acheter.NoAccentTextColor = Color.Empty;
            Button_Acheter.Size = new Size(86,36);
            Button_Acheter.TabIndex = 9;
            Button_Acheter.Text = "Acheter";
            Button_Acheter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button_Acheter.UseAccentColor = false;
            Button_Acheter.UseVisualStyleBackColor = true;
            Button_Acheter.Click += Button_Acheter_Click;
            // 
            // Button_Gmap
            // 
            Button_Gmap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button_Gmap.BackColor = SystemColors.ActiveCaption;
            Button_Gmap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button_Gmap.Depth = 0;
            Button_Gmap.HighEmphasis = true;
            Button_Gmap.Icon = null;
            Button_Gmap.Location = new Point(45,131);
            Button_Gmap.Margin = new Padding(4,6,4,6);
            Button_Gmap.MouseState = MaterialSkin.MouseState.HOVER;
            Button_Gmap.Name = "Button_Gmap";
            Button_Gmap.NoAccentTextColor = Color.Empty;
            Button_Gmap.Size = new Size(123,36);
            Button_Gmap.TabIndex = 8;
            Button_Gmap.Text = "Google Maps";
            Button_Gmap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button_Gmap.UseAccentColor = false;
            Button_Gmap.UseVisualStyleBackColor = false;
            Button_Gmap.Click += Button_Gmap_Click;
            // 
            // Button_WikiFromage
            // 
            Button_WikiFromage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button_WikiFromage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button_WikiFromage.Depth = 0;
            Button_WikiFromage.HighEmphasis = true;
            Button_WikiFromage.Icon = null;
            Button_WikiFromage.Location = new Point(58,83);
            Button_WikiFromage.Margin = new Padding(4,6,4,6);
            Button_WikiFromage.MouseState = MaterialSkin.MouseState.HOVER;
            Button_WikiFromage.Name = "Button_WikiFromage";
            Button_WikiFromage.NoAccentTextColor = Color.Empty;
            Button_WikiFromage.Size = new Size(94,36);
            Button_WikiFromage.TabIndex = 7;
            Button_WikiFromage.Text = "Wikipedia";
            Button_WikiFromage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button_WikiFromage.UseAccentColor = false;
            Button_WikiFromage.UseVisualStyleBackColor = true;
            Button_WikiFromage.Click += Button_WikiFromage_Click_1;
            // 
            // Edit_Fromage
            // 
            Edit_Fromage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit_Fromage.AnimateReadOnly = false;
            Edit_Fromage.BackColor = SystemColors.ActiveBorder;
            Edit_Fromage.BorderStyle = BorderStyle.None;
            Edit_Fromage.Depth = 0;
            Edit_Fromage.Font = new Font("Roboto",16F,FontStyle.Regular,GraphicsUnit.Pixel);
            Edit_Fromage.ForeColor = SystemColors.InactiveCaptionText;
            Edit_Fromage.LeadingIcon = null;
            Edit_Fromage.Location = new Point(381,19);
            Edit_Fromage.MaxLength = 50;
            Edit_Fromage.MouseState = MaterialSkin.MouseState.OUT;
            Edit_Fromage.Multiline = false;
            Edit_Fromage.Name = "Edit_Fromage";
            Edit_Fromage.ScrollBars = RichTextBoxScrollBars.None;
            Edit_Fromage.Size = new Size(221,50);
            Edit_Fromage.TabIndex = 0;
            Edit_Fromage.Text = "";
            Edit_Fromage.TrailingIcon = null;
            Edit_Fromage.TextChanged += Edit_Fromage_TextChanged;
            // 
            // Edit_Departements
            // 
            Edit_Departements.AnimateReadOnly = false;
            Edit_Departements.BackColor = SystemColors.ActiveBorder;
            Edit_Departements.BorderStyle = BorderStyle.None;
            Edit_Departements.Depth = 0;
            Edit_Departements.Font = new Font("Roboto",16F,FontStyle.Regular,GraphicsUnit.Pixel);
            Edit_Departements.ForeColor = SystemColors.InactiveCaptionText;
            Edit_Departements.LeadingIcon = null;
            Edit_Departements.Location = new Point(54,17);
            Edit_Departements.MaxLength = 50;
            Edit_Departements.MouseState = MaterialSkin.MouseState.OUT;
            Edit_Departements.Multiline = false;
            Edit_Departements.Name = "Edit_Departements";
            Edit_Departements.Size = new Size(221,50);
            Edit_Departements.TabIndex = 1;
            Edit_Departements.Text = "";
            Edit_Departements.TrailingIcon = null;
            Edit_Departements.TextChanged += Edit_Departements_TextChanged;
            // 
            // ListBox_Departement
            // 
            ListBox_Departement.FormattingEnabled = true;
            ListBox_Departement.ItemHeight = 15;
            ListBox_Departement.Location = new Point(54,73);
            ListBox_Departement.Name = "ListBox_Departement";
            ListBox_Departement.Size = new Size(221,244);
            ListBox_Departement.TabIndex = 5;
            ListBox_Departement.SelectedIndexChanged += ListBox_Departement_SelectedIndexChanged;
            // 
            // Label_Titre
            // 
            Label_Titre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label_Titre.AutoSize = true;
            Label_Titre.BackColor = Color.Transparent;
            Label_Titre.Font = new Font("Segoe UI",27.75F,FontStyle.Bold,GraphicsUnit.Point,0);
            Label_Titre.ForeColor = SystemColors.ActiveCaptionText;
            Label_Titre.Location = new Point(682,17);
            Label_Titre.Name = "Label_Titre";
            Label_Titre.Size = new Size(369,50);
            Label_Titre.TabIndex = 6;
            Label_Titre.Text = "Fromages de France";
            // 
            // Picture_Search
            // 
            Picture_Search.Image = Properties.Resources.Search;
            Picture_Search.Location = new Point(12,26);
            Picture_Search.Name = "Picture_Search";
            Picture_Search.Size = new Size(36,33);
            Picture_Search.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Search.TabIndex = 7;
            Picture_Search.TabStop = false;
            // 
            // Picture_Search_2
            // 
            Picture_Search_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Picture_Search_2.Image = Properties.Resources.Search;
            Picture_Search_2.Location = new Point(339,26);
            Picture_Search_2.Name = "Picture_Search_2";
            Picture_Search_2.Size = new Size(36,33);
            Picture_Search_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Search_2.TabIndex = 8;
            Picture_Search_2.TabStop = false;
            // 
            // Label_Departement
            // 
            Label_Departement.AutoSize = true;
            Label_Departement.Font = new Font("Segoe UI",13F);
            Label_Departement.Location = new Point(98,320);
            Label_Departement.Name = "Label_Departement";
            Label_Departement.Size = new Size(116,25);
            Label_Departement.TabIndex = 9;
            Label_Departement.Text = "Departement";
            // 
            // Label_Fromages
            // 
            Label_Fromages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label_Fromages.AutoSize = true;
            Label_Fromages.Font = new Font("Segoe UI",13F);
            Label_Fromages.Location = new Point(446,324);
            Label_Fromages.Name = "Label_Fromages";
            Label_Fromages.Size = new Size(91,25);
            Label_Fromages.TabIndex = 10;
            Label_Fromages.Text = "Fromages";
            // 
            // Picture_Fromage
            // 
            Picture_Fromage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Picture_Fromage.Image = Properties.Resources.fromage;
            Picture_Fromage.Location = new Point(403,319);
            Picture_Fromage.Name = "Picture_Fromage";
            Picture_Fromage.Size = new Size(37,35);
            Picture_Fromage.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Fromage.TabIndex = 11;
            Picture_Fromage.TabStop = false;
            // 
            // C_CADRE
            // 
            AutoScaleDimensions = new SizeF(7F,15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1162,629);
            Controls.Add(Picture_Fromage);
            Controls.Add(Label_Fromages);
            Controls.Add(Label_Departement);
            Controls.Add(Picture_Search_2);
            Controls.Add(Picture_Search);
            Controls.Add(Edit_Fromage);
            Controls.Add(Label_Titre);
            Controls.Add(ListBox_Departement);
            Controls.Add(Edit_Departements);
            Controls.Add(ListBox_Fromages);
            Controls.Add(La_Carte);
            Controls.Add(Panel_Info_Fromage);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "C_CADRE";
            Text = "Fromages de France";
            Panel_Info_Fromage.ResumeLayout(false);
            Panel_Info_Fromage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picture_Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Search_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Fromage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl La_Carte;
        private ListBox ListBox_Fromages;
        private Label Label_Lait;
        private Panel Panel_Info_Fromage;
        private TextBox Edit_Departement;
        private TextBox Edit_Fromages;
        private MaterialSkin.Controls.MaterialButton Button_WikiFromage;
        private MaterialSkin.Controls.MaterialTextBox Edit_Fromage;
        private MaterialSkin.Controls.MaterialTextBox Edit_Departements;
        private ListBox ListBox_Department;
        private ListBox ListBox_Departement;
        private MaterialSkin.Controls.MaterialButton Button_Gmap;
        private Label Label_Titre;
        private MaterialSkin.Controls.MaterialButton Button_Acheter;
        private PictureBox Picture_Search;
        private PictureBox Picture_Search_2;
        private Label Label_Departement;
        private Label Label_Fromages;
        private PictureBox Picture_Fromage;
    }
}
