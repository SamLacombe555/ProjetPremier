
namespace Magasin.Classes
{
    public class Compte
    {
        // Déclaration de paramètre
        public float Solde { get; set; }

        // Déclaration du constructeur
        public Compte(float solde)
        {
            Solde = solde;
        }

        // Déclaration de méthodes
        public void Depot(float somme)
        {
            // Ajoute une somme donnée au "solde".
            if (somme > 0)
            {
                Solde += somme;
            }
            else
            {
                Console.WriteLine("La somme ne peut pas être négatif.");
            }
        }

        public void Retrait(float somme)
        {
            // Enlève une somme donnée du "solde".
            if (somme < Solde)
            {
                Solde -= somme;
            }
            else
            {
                Console.WriteLine("La somme doit être plus petit" +
                    "que le solde.");
            }
        }

        public string ToString()
        {
            // Retoune un string spécifique lorsque "Console.Write()."
            return $"Le solde du compte est: {Solde}";
        }

    }
}