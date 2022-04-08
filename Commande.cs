using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation1_Yongjiang
{
    public class Commande
    {
        //4. Créer une classe Commande avec les variables membres suivantes :
        
        private Client client;
        private int commandeId;
        private string clientId;
        private int employeId;
        public DateTime dateCommande;
        public DateTime dateRequise;
        public DateTime dateEnvoi;
        public string nomEnvoi;
        public string adresseEnvoi;
        public string villeEnvoi;
        public string codePostalEnvoi;
        public string paysEnvoi;

        public Commande () { }
        public Commande (
            Client client,
            int commandeId,
            string clientId,
            int employeId,
            DateTime dateCommande,
            DateTime dateRequise,
            DateTime dateEnvoi,
            string nomEnvoi,
            string adresseEnvoi,
            string villeEnvoi,
            string codePostalEnvoi,
            string paysEnvoi)
        {
            this.client = client;
            this.commandeId = commandeId;
            this.clientId = clientId;
            this.employeId = employeId;
            this.dateCommande = dateCommande;
            this.dateRequise = dateRequise;
            this.dateEnvoi = dateEnvoi;
            this.nomEnvoi = nomEnvoi;
            this.adresseEnvoi = adresseEnvoi;
            this.villeEnvoi = villeEnvoi;
            this.codePostalEnvoi = codePostalEnvoi;
            this.paysEnvoi = paysEnvoi;
        }
        public int CommandeId { get; set; }
        public string ClientId { get; set; }
        public int EmployeId { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime DateRequise { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string NomEnvoi { get; set; }
        public string AdresseEnvoi { get; set; }
        public string VilleEnvoi { get; set; }
        public string CodePostalEnvoi { get; set; }
        public string PaysEnvoi { get; set; }

        public void SetClient (Client client) { this.client = client; }
        public void SetCommandeId (int commandeId) { this.commandeId = commandeId;}
        public void SetClientId (string clientId) { this.clientId = clientId;}
        public void SetEmployeId (int employeId) { this.employeId = employeId;}
        public void SetDateCommande (DateTime dateCommande) { this.dateCommande = dateCommande;}
        public void SetDateRequise (DateTime dateRequise) { this.dateRequise = dateRequise;}
        public void SetDateEnvoi (DateTime dateEnvoi) { this.dateEnvoi = dateEnvoi;}
        public void SetNomEnvoi (string nomEnvoi) { this.NomEnvoi = nomEnvoi;}
        public void SetAdresseEnvoi (string adresseEnvoi) { this.adresseEnvoi = adresseEnvoi;}
        public void SetVilleEnvoi (string villeEnvoi) { this.villeEnvoi = villeEnvoi; }
        public void SetCodePostalEnvoi (string codePostalEnvoi) { this.codePostalEnvoi = codePostalEnvoi;}
        public void SetPaysEnvoi (string paysEnvoi) { this.paysEnvoi = paysEnvoi;}
     
        public Client GetClient () { return client; }
        public int GetCommandeId () { return commandeId; }
        public string GetClientId () { return clientId; }
        public int GetEmployeId () { return employeId; }
        public DateTime GetDateCommande () { return dateCommande; }
        public DateTime GetDateRequise () { return dateRequise; }   
        public DateTime GetDateEnvoi () { return dateEnvoi; }
        public string GetNomEnvoi () { return nomEnvoi; }
        public string GetAdresseEnvoi () { return adresseEnvoi;}
        public string GetVilleEnvoi () { return villeEnvoi; }
        public string GetCodePostalEnvoi () { return codePostalEnvoi; }
        public string GetPaysEnvoi () { return paysEnvoi; }

        public Commande (Client client)
        {
            if (client != null)
            {
                this.client = client;
            }
            else
            {
                WriteLine("Client is not exist!!");
            }
        }
    }

}
