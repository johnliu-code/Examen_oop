using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1_Yongjiang
{
    public class Client
    {
        //2.Créer une classe Client avec les variables membres suivantes :
        private string clientId;
        private string nomCompanie;
        private string nomContact;
        private string titreContact;
        private string adresse;
        private string ville;
        private string province;
        private string codePostal;
        private string pays;
        private string telephone;


        public Client() { }


        public Client(
            string _clientId, 
            string _nomCompanie, 
            string _nomContact, 
            string _titreContact, 
            string _adresse, 
            string _ville,
            string _province,
            string _codePostal, 
            string _pays, 
            string _telephone)
        {
            clientId = _clientId;
            nomCompanie = _nomCompanie;
            nomContact = _nomContact;
            titreContact = _titreContact;
            adresse = _adresse;
            ville = _ville;
            province = _province;
            codePostal = _codePostal;
            pays = _pays;
            telephone = _telephone;
        }

        public string ClientId { get; set; }
        public string NomCompanie { get; set; }  
        public string NomContact { get; set; }
        public string TitreContact { get; set; }    
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
        public string Telephone { get; set; }

        public void SetClientId (string _clientId) { clientId = _clientId; }
        public void SetNomCompanie (string _nomCompanie) { nomCompanie = _nomCompanie; }
        public void SetNomContact (string _nomContact) { nomContact = _nomContact; }
        public void SetTitreContact (string _titreContact) { titreContact = _titreContact; }
        public void SetAdresse (string _adresse) { adresse = _adresse; }
        public void SetVille (string _ville) { ville = _ville;}
        public void SetProvince (string _province) { province = _province; }
        public void SetCodePostal (string _codePostal) { codePostal = _codePostal; }
        public void SetPays (string _pays) { pays = _pays; }
        public void SetTelephone (String _telephone) { telephone = _telephone;}

        public string GetClientId () { return clientId; }
        public string GetNomCompanie () { return nomCompanie; }
        public string GetNomContact () { return nomContact; }
        public string GetTitreContact () { return titreContact; }
        public string GetAdresse () { return adresse; }
        public string GetVille () { return ville; }
        public string GetProvince () { return province; }
        public string GetCodePostal () { return codePostal; }
        public string GetPays () { return pays; }
        public string GetTelephone () { return telephone; }
    }

}
