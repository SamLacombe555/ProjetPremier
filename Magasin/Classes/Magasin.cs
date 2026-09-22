using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magasin.Classes
{
    public class Magasin
    {
        public Compte Compte
        {
            get => default;
            set
            {
            }
        }

        public int Inventaire
        {
            get => default;
            set
            {
            }
        }

        public string Utilisateurs
        {
            get => default;
            set
            {
            }
        }

        public Magasin(Compte compte, int inventaire, string utilisateurs)
        {
            Compte = compte;
            Inventaire = inventaire;
            Utilisateurs = utilisateurs;
        }

        public void AjoutUtilisateur()
        {
            throw new System.NotImplementedException();
        }

        public void Authentification()
        {
            throw new System.NotImplementedException();
        }

        public void GetUtilisateur()
        {
            throw new System.NotImplementedException();
        }

        public void VendreItem()
        {
            throw new System.NotImplementedException();
        }
    }
}