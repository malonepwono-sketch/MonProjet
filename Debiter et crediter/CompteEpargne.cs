
class CompteEpargne : Compte
{
    public decimal TauxInteret { get; private set; }

    public CompteEpargne(
        string numero,
        string titulaire,
        decimal solde,
        decimal tauxInteret)
        : base(numero, titulaire, solde)
    {
        TauxInteret = tauxInteret;
    }

    public void AjouterInterets()
    {
        decimal interets = Solde * TauxInteret;
        Crediter(interets);
    }
}