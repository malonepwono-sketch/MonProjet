
class Compte
{
    public string Numero { get; private set; }
    public string Titulaire { get; private set; }
    public decimal Solde { get; private set; }

    public Compte(string numero, string titulaire, decimal solde = 0m)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant > 0)
            Solde += montant;
        else
            Console.WriteLine("Montant invalide");
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
            Console.WriteLine("Montant invalide");
        else if (montant > Solde)
            Console.WriteLine("Solde insuffisant");
        else
            Solde -= montant;
    }

    public void Afficher()
    {
        Console.WriteLine(
            Numero + " - " + Titulaire + " - " + Solde + " €"
        );
    }
}