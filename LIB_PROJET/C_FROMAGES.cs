namespace LIB_PROJET;

public class C_FROMAGES {
    public string RecordId { get; set; }
    public string Nom_Fromage { get; set; }
    public string Lait { get; set; }
    public string Departement { get; set; }
    public string Page_Francaise { get; set; }
    //-----------------------------------------------

    public void Affiche_Toi() {
        Console.WriteLine($"{RecordId,5} {Nom_Fromage,5} {Lait,5} {Departement,-32} {Page_Francaise,5}");
    }
}

