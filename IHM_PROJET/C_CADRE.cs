using GMap.NET.MapProviders;
using GMap.NET;
using LIB_PROJET;
using System.Drawing;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;

namespace IHM_PROJET {
    public partial class C_CADRE :Form {
        C_BASE_PROJET La_Base;

        //-----------------------------------------
        private void Charger_Departement_Avec_Fromages() {
            var Departement_Avec_Fromages = La_Base.Get_All_Departement_Contient_Fromages();
            ListBox_Departement.DisplayMember = nameof(C_DEPARTEMENT.name);
            ListBox_Departement.DataSource = Departement_Avec_Fromages;
        }

        //-----------------------------------------
        public C_CADRE() {
            InitializeComponent();

            La_Carte.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            La_Carte.DragButton = MouseButtons.Left;

            La_Carte.MapProvider = GMapProviders.BingHybridMap;

            try {
                La_Base = new C_BASE_PROJET();

                Charger_Departement_Avec_Fromages();
            }
            catch(Exception P_Erreur) {
                MessageBox.Show(P_Erreur.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();
            }
        }

        //-------------------------------------------------------------------------------
        private void ListBox_Fromages_SelectedIndexChanged(object sender,EventArgs e) {
            if(ListBox_Fromages.SelectedItems == null) return;

            C_FROMAGES Fromage_Selectionnee = (C_FROMAGES)ListBox_Fromages.SelectedItem;

            Label_Lait.Text = $"Lait : {Fromage_Selectionnee.Lait}";

            Button_WikiFromage.Tag = Fromage_Selectionnee.Page_Francaise;
        }
        //-------------------------------------------------------------------------------
        private void ListBox_Departement_SelectedIndexChanged(object sender,EventArgs e) {
            C_DEPARTEMENT Departement_Selectionnee = ListBox_Departement.SelectedItem as C_DEPARTEMENT;
            if(Departement_Selectionnee == null) return;

            var liste_Fromages = La_Base.Get_Fromages_By_Code_Departement(Departement_Selectionnee.name);

            ListBox_Fromages.DisplayMember = nameof(C_FROMAGES.Nom_Fromage);
            ListBox_Fromages.DataSource = liste_Fromages;

            La_Carte.Position = new PointLatLng(Departement_Selectionnee.latitude,Departement_Selectionnee.longitude);
            La_Carte.Zoom = 5;
        }
        //-------------------------------------------------------------------------------
        private void Button_WikiFromage_Click_1(object sender,EventArgs e) {
            string url_Wiki_Fromage = Button_WikiFromage.Tag.ToString();
            ProcessStartInfo Ouverture_Page_Web = new ProcessStartInfo {
                FileName = url_Wiki_Fromage,
                UseShellExecute = true
            };

            Process.Start(Ouverture_Page_Web);
        }
        //-------------------------------------------------------------------------------
        private void Edit_Fromage_TextChanged(object sender,EventArgs e) {
            if(Edit_Fromage.Text == string.Empty) {
                var Liste_Fromages = La_Base.Get_All_Fromages();

                ListBox_Fromages.DisplayMember = nameof(C_FROMAGES.Nom_Fromage);
                ListBox_Fromages.DataSource = Liste_Fromages;
            }
            else {
                ListBox_Fromages.DataSource = La_Base.Get_Fromages_By_Name(Edit_Fromage.Text);
            }
            ListBox_Fromages.DisplayMember = nameof(C_FROMAGES.Nom_Fromage);

        }
        //-------------------------------------------------------------------------------
        private void Edit_Departements_TextChanged(object sender,EventArgs e) {
            if(Edit_Departements.Text == string.Empty) {
                var Liste_Departement = La_Base.Get_All_Departement();

                ListBox_Departement.DisplayMember = nameof(C_DEPARTEMENT.name);
                ListBox_Departement.DataSource = Liste_Departement;
            }
            else {
                ListBox_Departement.DataSource = La_Base.Get_Departement_By_Name(Edit_Departements.Text);
            }
            ListBox_Departement.DisplayMember = nameof(C_DEPARTEMENT.name);

        }
        //-------------------------------------------------------------------------------
        private void Button_Gmap_Click(object sender,EventArgs e) {
            C_DEPARTEMENT departementSelectionne = ListBox_Departement.SelectedItem as C_DEPARTEMENT;
            if(departementSelectionne != null) {
                string urlGMap = $"https://www.google.com/maps?q={departementSelectionne.name}";

                Process.Start(new ProcessStartInfo(urlGMap) { UseShellExecute = true });
            }
        }
        //-------------------------------------------------------------------------------
        private void Button_Acheter_Click(object sender,EventArgs e) {
            C_FROMAGES Fromage_Selectionnee = ListBox_Fromages.SelectedItem as C_FROMAGES;
            if(Fromage_Selectionnee != null) {
                string urlGMap = $"https://www.fromages.com/product/search?search={Fromage_Selectionnee.Nom_Fromage}";

                Process.Start(new ProcessStartInfo(urlGMap) { UseShellExecute = true });
            }
        }
    }
}
