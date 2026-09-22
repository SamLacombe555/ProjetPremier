
namespace Magasin.Classes
{
    // Déclaration d'une classe parent abstrait.
    public abstract class Client
    {
        // Déclaration de paramètres.
        public Compte Compte { get; set; }
        public List<string> Inventaire { get; set; }
        public List<string> Panier { get; set; }

        // Déclaration du constructeur.
        public Client(Compte compte, List<string> inventaire, List<string> panier)
        {
            Compte = compte;
            Inventaire = inventaire;
            Panier = panier;
        }

        // Déclaration de méthodes.
        public void AchatItem(string itemAcheter)
        {
            /// Fonction qui enlève une item de la liste "panier" pour le mettre
            /// dans la liste "inventaire".
            foreach (var item in Panier)
            {
                if (item == itemAcheter)
                    Inventaire.Add(itemAcheter);
                    Panier.Remove(itemAcheter);
                    Console.WriteLine("Items acheter");
            }
        }

        public void AcheterPanier()
        {
            /// Fonction qui verse tous la liste "panier" dans la liste "inventaire".
            foreach (var item in Panier)
            {
                Inventaire.Add(item);
            }
            foreach (var item in Inventaire)
            {
                Panier.Remove(item);
            }
        }

        public void AfficherPanier()
        {
            /// Fonction qui montre le contenu du "panier".
            foreach (var item in Panier)
            {
                Console.WriteLine(item);
            }
        }

        public void AjouterAuPanier(string ItemAjouter)
        {
            /// Fonction qui ajoute un item au "panier".
            Panier.Add(ItemAjouter);
        }

        public void ViderPanier()
        {
            /// Fonction qui vide le "panier".
            Panier.Clear();
        }

        public void VoirInventaire()
        {
            /// Fonction qui montre le contenu dd "inventaire".
            foreach (var item in Inventaire)
            {
                Console.WriteLine(item);
            }
        }

    }
}