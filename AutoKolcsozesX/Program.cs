using AutoKolcsozesX.DataBAseService;
using AutoKolcsozesX.model;
using System.Data;


internal class Program
{
    //connection adatok
    public static readonly string connectionString = "Server=localhost;Database=autokolcsonzesx;User=root";
    
    //adattároló
    public static DataTable adatok= new DataTable();
    //lista
    public static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();

    private static void Main(string[] args)
    {
        Dbcheck(connectionString);
        AdatBetoltes(adatok);
    }

    private static void AdatBetoltes(DataTable adatok)
    {
        foreach (DataRow o in adatok.Rows )
        {
            Kolcsonzes kolcsonzes  = new Kolcsonzes();
            kolcsonzes.id = o.Field<int>(0);
            kolcsonzes.brand = o.Field<string>(1);
            kolcsonzes.model = o.Field<string>(2);
            kolcsonzes.color = o.Field<string>(3);
            kolcsonzes.year = o.Field<double>(4);
            kolcsonzes.vin = o.Field<string>(5);
            
            kolcsonzesek.Add(kolcsonzes);
        }
    }

    private static void Dbcheck(string connectionString)
    {
        DataBAseService.DbConnectionCheck(connectionString);
    }
}
