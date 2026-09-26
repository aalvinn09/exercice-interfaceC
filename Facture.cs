public class Facture : IImprimable, IExportable
{
    public string Numero {get; set; }
    public decimal Montant {get; set;}

     public Facture(string numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }
     public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture {Numero} - {Montant} €");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Facture exportée vers {fichier}");
    }

}

