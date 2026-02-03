using System;
using System.Collections.Generic;
using System.Data;
using AutoKolcsozesX.model;
using MySqlConnector;

internal class Program
{
    // Kapcsolati string
    public static readonly string connectionString = "Server=localhost;Database=autokolcsonzes;User=root";

    // Adattárolók
    public static DataTable adatok = new DataTable();
    public static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();


    private static void Main(string[] args)
    {
        Dbcheck(connectionString);

        AdatbazisBetoltes(adatok);
        AdatBetoltes(adatok);

        Console.Write("Adj meg egy évszámot: ");

        int ev = int.Parse(Console.ReadLine());

        EvjaratSzerint(kolcsonzesek, ev);

        Console.ReadKey();
    }

    // Adatbázis kapcsolat ellenőrzése
    private static void Dbcheck(string connStr)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            Console.WriteLine("Adatbázis kapcsolat Sikeres\n");
        }
    }

    // Adatok betöltése adatbázisból DataTable-be
    private static void AdatbazisBetoltes(DataTable adatok)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            string sql = "SELECT id, brand, model, color, year, vin FROM kolcsonzes";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            adatok.Clear();
            adapter.Fill(adatok);
        }
    }

    // DataTable → objektumlista
    private static void AdatBetoltes(DataTable adatok)
    {
        kolcsonzesek.Clear();

        foreach (DataRow o in adatok.Rows)
        {
            Kolcsonzes kolcsonzes = new Kolcsonzes
            {
                id = o.Field<int>("id"),
                brand = o.Field<string>("brand"),
                model = o.Field<string>("model"),
                color = o.Field<string>("color"),
                year = o.Field<int>("year"),
                vin = o.Field<string>("vin")
            };

            kolcsonzesek.Add(kolcsonzesek);
        }
    }

    // Évjárat szerinti szűrés
    private static void EvjaratSzerint(List<Kolcsonzes> kolcsonzesek, int ev)
    {
        Console.WriteLine($"\n{ev} utáni autók:");

        bool talalat = false; // jelzi, hogy találtunk-e autót
        foreach (var item in kolcsonzesek)
        {
            if (item.year > ev)
            {
                Console.Write($"{item.brand} {item.model} ({item.year})  "); // egysoros kiírás
                talalat = true;
            }
        }

        if (!talalat)
            Console.WriteLine("Nincs ilyen autó.");

        Console.WriteLine(); // új sor a végére
    }


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// Osztály
