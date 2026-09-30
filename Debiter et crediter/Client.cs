
using System.Collections.Generic;

class Client
{
    public string Nom { get; private set; }

    public List<Compte> Comptes { get; private set; }

    public Client(string nom)
    {
        Nom = nom;
        Comptes = new List<Compte>();
    }

    public void AjouterCompte(Compte compte)
    {
        Comptes.Add(compte);
    }

    public void AfficherComptes()
    {
        Console.WriteLine("Client : " + Nom);

        foreach (Compte compte in Comptes)
        {
            compte.Afficher();
        }
    }
}