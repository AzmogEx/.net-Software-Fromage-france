namespace LIB_PROJET;

public class C_DEPARTEMENT {
    public int id { get; set; }
    public string region_code { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    //-----------------------------------------------
    public void Affiche_Toi() {
        Console.WriteLine($"{id,5} {region_code,5} {code,5} {name,-32}");
    }
}