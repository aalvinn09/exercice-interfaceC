var facture = new Facture("Facture septembre", 450m);

Console.WriteLine($"Titre : {facture.Titre}");
Console.WriteLine($"Montant : {facture.Montant} €");

facture.Imprimer();