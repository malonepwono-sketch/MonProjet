class Produit
{
    public string Reference { get; private set; }
    public string Nom { get; set; }
    public decimal Prix { get; private set; }
    public int Stock { get; private set; }

    public Produit(string reference, string nom, decimal prix, int stock)
    {
        if (string.IsNullOrWhiteSpace(reference))
            throw new ArgumentException("Référence obligatoire");

        if (prix < 0)
            throw new ArgumentException("Prix invalide");

        if (stock < 0)
            throw new ArgumentException("Stock invalide");

        Reference = reference;
        Nom = nom;
        Prix = prix;
        Stock = stock;
    }

    public void ModifierPrix(decimal nouveauPrix)
    {
        if (nouveauPrix >= 0)
            Prix = nouveauPrix;
    }

    public void AjouterStock(int quantite)
    {
        if (quantite > 0)
            Stock += quantite;
    }

    public void RetirerStock(int quantite)
    {
        if (quantite > 0 && quantite <= Stock)
            Stock -= quantite;
    }
}