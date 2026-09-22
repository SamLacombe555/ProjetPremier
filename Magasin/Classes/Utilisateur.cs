
namespace Magasin.Classes
{
    // Déclaration d'une classe enfant à "Client".
    public class Utilisateur : Client
    {
        // Déclaration de paramètre.
        public Utilisateur(Compte compte, List<string> inventaire, List<string> panier) :
            base(compte, inventaire, panier) { }

        public int EstGestionnaire
        {
            get => default;
            set
            {
            }
        }

        public int Id
        {
            get => default;
            set
            {
            }
        }

        public int MDP
        {
            get => default;
            set
            {
            }
        }

        public int Nom
        {
            get => default;
            set
            {
            }
        }

        public int a
        {
            get => default;
            set
            {
            }
        }

        public void Authentification()
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }

        public void MethodeUtilisateur()
        {
            throw new System.NotImplementedException();
        }
    }
}