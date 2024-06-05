using Demo_Exceptions.Exceptions;
using Demo_Exceptions.Interfaces;
using Demo_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private Dictionary<string,Utilisateur> _utilisateurs = new Dictionary<string, Utilisateur>();
        public void Create(Utilisateur utilisateur)
        {
            _utilisateurs.Add(utilisateur.Email, utilisateur);
        }

        public void Delete(string Email)
        {
            throw new PasEncoreEnPlace("J'ai pas encore créé cette methode");
        }

        public Dictionary<string,Utilisateur> GetAll()
        {
            return _utilisateurs;
        }

        public Utilisateur GetByEmail(string email)
        {
            return _utilisateurs[email];
        }
    }
}
