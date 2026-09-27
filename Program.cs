AfficherFrais(new FraisStandard(), 1000m);
AfficherFrais(new FraisPremium(), 1000m);
AfficherFrais(new SansFrais(), 1000m);


static void AfficherFrais(
    ICalculFrais calcul,
    decimal montant)
{
    decimal frais = calcul.Calculer(montant);

    Console.WriteLine($"Frais : {frais} €");
}