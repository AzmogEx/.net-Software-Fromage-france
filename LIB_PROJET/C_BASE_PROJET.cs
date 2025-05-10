using System.Diagnostics;
using System.Text.Json;

namespace LIB_PROJET;
//------------------------------------------------
public class C_BASE_PROJET {
    List<C_DEPARTEMENT> Les_Departements;
    List<C_FROMAGES> Les_Fromages;

    //---------------------------------------------
    public C_BASE_PROJET() {
        Chargement_Memoire();
    }

    //---------------------------------------------
    void Chargement_Memoire() {
        string Data_Json = File.ReadAllText("Fromages.json");
        Les_Fromages = JsonSerializer.Deserialize<List<C_FROMAGES>>(Data_Json);

        Data_Json = File.ReadAllText("departments.json");
        Les_Departements = JsonSerializer.Deserialize<List<C_DEPARTEMENT>>(Data_Json);
    }
    //-----------------------------------------------
    public void Affiche_Departements() {
        foreach(C_DEPARTEMENT Un_Departement in Les_Departements) {
            Un_Departement.Affiche_Toi();
        }
    }
    //------------------------------------------------
    public void Affiche_Fromages() {
        foreach(C_FROMAGES Un_Fromages in Les_Fromages) {
            Un_Fromages.Affiche_Toi();
        }
    }
    //------------------------------------------------
    public List<C_DEPARTEMENT> Get_All_Departement() {
        return Les_Departements;
    }
    //------------------------------------------------
    public List<C_FROMAGES> Get_All_Fromages(){
        return Les_Fromages;
    }
    //-------------------------------------------------
    public List<C_FROMAGES> Get_Fromages_By_Code_Departement(string P_Departement) {
        List<C_FROMAGES> Fromages_Trouvees = new List<C_FROMAGES>();

        foreach(C_FROMAGES Un_Fromage in Les_Fromages) {
            if(Un_Fromage.Departement == P_Departement) {
                Fromages_Trouvees.Add(Un_Fromage);
            }
        }

        return Fromages_Trouvees;
    }
    //-------------------------------------------------
    public List<C_FROMAGES> Get_Fromages_By_Name(string P_Nom) {
        List<C_FROMAGES> Fromages_Trouvee = new List<C_FROMAGES>();
        string Nom_Recherche = P_Nom.ToLower();
        foreach(C_FROMAGES Un_Fromages in Les_Fromages) {
            if(Un_Fromages.Nom_Fromage.ToLower().StartsWith(Nom_Recherche)) {
                Fromages_Trouvee.Add(Un_Fromages);
            }
        }

        return Fromages_Trouvee;
    }
    //----------------------------------------------------------------------
    public List<C_DEPARTEMENT> Get_Departement_By_Name(string P_Nom) {
        List<C_DEPARTEMENT> Departement_Trouvee = new List<C_DEPARTEMENT>();
        string Nom_Recherche = P_Nom.ToLower();
        foreach(C_DEPARTEMENT Un_Departement in Les_Departements) {
            if(Un_Departement.name.ToLower().StartsWith(Nom_Recherche)) {
                Departement_Trouvee.Add(Un_Departement);
            }
        }

        return Departement_Trouvee;
    }
    //------------------------------------------------------------------------------
    public List<C_DEPARTEMENT> Get_All_Departement_Contient_Fromages() {
        List<C_DEPARTEMENT> Departements_Avec_Fromages = new List<C_DEPARTEMENT>();

        foreach(C_DEPARTEMENT Un_Departement in Les_Departements) {
            if(Departement_avec_Fromages(Un_Departement.name)) {
                Departements_Avec_Fromages.Add(Un_Departement);
            }
        }

        return Departements_Avec_Fromages;
    }
    //-------------------------------------------------------------------------------
    private bool Departement_avec_Fromages(string departementName) {
        foreach(C_FROMAGES Un_Fromage in Les_Fromages) {
            if(Un_Fromage.Departement == departementName) {
                return true;
            }
        }
        return false;
    }
    //-------------------------------------------------------------------------------
}

