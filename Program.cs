
class Program
{
    static void Main()
    {
        // Création du client
        Client alice = new Client("Alice");

        // Création des comptes
        CompteCourant courant =
            new CompteCourant("FR001", "Alice", 1000m);

        CompteEpargne epargne =
            new CompteEpargne("FR002", "Alice", 2000m, 0.03m);

        // Ajout des comptes au client
        alice.AjouterCompte(courant);
        alice.AjouterCompte(epargne);

        // Opérations bancaires
        courant.Crediter(500m);
        courant.Debiter(200m);

        epargne.Crediter(100m);
        epargne.AjouterInterets();

        // Affichage final
        alice.AfficherComptes();
    }
}