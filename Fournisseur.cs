using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1_Yongjiang
{
    public class Fournisseur
    {
        //3.	Créer une classe Fournisseur avec les variables membres suivantes :
        private int fournisseurId;
        private string nomCompanie;
        private string nomContact;
        private string titreContact;
        private string adresse;
        private string ville;
        private string province;
        private string codePostal;
        private string pays;
        private string telephone;
        private string pageWeb;

        public Fournisseur () { }
        public Fournisseur (
            int fournisseurId,
            string nomCompanie,
            string nomContact,
            string titreContact,
            string adresse,
            string ville,
            string province,
            string codePostal,
            string pays,
            string telephone
            )
        {
            this.fournisseurId = fournisseurId;
            this.nomCompanie = nomCompanie;
            this.nomContact = nomContact;
            this.titreContact = titreContact;
            this.adresse = adresse;
            this.ville = ville;
            this.province = province;
            this.codePostal = codePostal;
            this.pays = pays;
            this.telephone = telephone;
        }

        public int FournisseurId { get; set; }
        public string NomCompanie { get; set; }
        public string NomContact { get; set; }

        public string TitreContact { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }  
        
        public  string Province { get; set; }

        public string CodePostal { get; set; }

        public string Pays { get; set; }
        public string Telephone { get; set; }
    }
}
