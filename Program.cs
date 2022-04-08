using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation1_Yongjiang
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Client instance and print list
            Client client1 = new Client(
                "GROSR",
                "GROSELLA-Restaurante",
                "Manuel Pereira",
                "Owner",
                "5ª Ave. Los Palos Grandes",
                "Caracas",
                "DF",
                "1081",
                "Venezuela",
                "(2) 283-2951");

            Client client2 = new Client(
                "HANAR",
                "Hanari Carnes",
                "Mario Pontes",
                "Accounting Manager",
                "Rua do Paço, 67",
                "Rio de Janeiro",
                "RJ",
                "05454-876",
                "Brazil",
                "(21) 555-0091"
                );
            
            Client client3 = new Client(
                "HILAA",
                "HILARION-Abastos",
                "Carlos Hernández",
                "Sales Representative",
                "Ville Center Plaza 516 Main St.",
                "San Cristóbal",
                "Táchira",
                "5022",
                "Venezuela",
                "(5) 555-1340"
                );
            
            WriteLine("Clients: \n--------------------------------------------");
            WriteLine($"{client1.GetClientId(), -10}   "
                + $"{client1.GetNomCompanie(), -10}    "
                + $"{client1.GetNomContact(), -10}     "
                + $"{client1.GetTitreContact(), -10}   "
                + $"{client1.GetAdresse(), -10}    "
                + $"{client1.GetVille(), -10}   "
                + $"{client1.GetProvince(),-10}   "
                + $"{client1.GetCodePostal(), -10}   "
                + $"{client1.GetPays(), -10}   "  
                + $"{client1.GetTelephone(), -10}");

            WriteLine($"{client2.GetClientId(),-10}    "
                + $"{client2.GetNomCompanie(),-10}    "
                + $"{client2.GetNomContact(),-10}    "
                + $"{client2.GetTitreContact(), -10}    "
                + $"{client2.GetAdresse(),-10}    "   
                + $"{client2.GetVille(), -10}    "
                + $"{client2.GetProvince(),-10}    "
                + $"{client2.GetCodePostal(),-10}    "
                + $"{client2.GetPays(),-10}    "
                + $"{client2.GetTelephone(),-10}");

            WriteLine($"{client3.GetClientId(),-10}    "
                + $"{client3.GetNomCompanie(),-10}    "
                + $"{client3.GetNomContact(),-10}    "
                + $"{client3.GetTitreContact(),-10}    "
                + $"{client3.GetAdresse(),-10}    "
                + $"{client3.GetVille(), -10}    "
                + $"{client3.GetProvince(),-10}    "
                + $"{client3.GetCodePostal(),-10}    "
                + $"{client3.GetPays(),-10}    "
                + $"{client3.GetTelephone(),-10}");

            ReadLine();

            //Fournisseur instance and print list
            Fournisseur fournisseur1 = new Fournisseur();
            fournisseur1.FournisseurId = 1;
            fournisseur1.NomCompanie = "Pavlova, Ltd.";
            fournisseur1.NomContact = "Ian Devling";
            fournisseur1.TitreContact = "Marketing Manager";
            fournisseur1.Adresse = "74 Rose St. Moonie Ponds";
            fournisseur1.Ville = "Melbourne";
            fournisseur1.Province = "Victoria";
            fournisseur1.CodePostal = "3058";
            fournisseur1.Pays = "Australia";
            fournisseur1.Telephone = "(03) 444-2343";

            Fournisseur fournisseur2 = new Fournisseur();
            fournisseur2.FournisseurId = 2;
            fournisseur2.NomCompanie = "Refrescos Americanas LTDA";
            fournisseur2.NomContact = "Carlos Diaz";
            fournisseur2.TitreContact = "Marketing Manager";
            fournisseur2.Adresse = "Av. das Americanas 12.890";
            fournisseur2.Ville = "Sao Paulo";
            fournisseur2.Province = "Null";
            fournisseur2.CodePostal = "5442";
            fournisseur2.Pays = "Brazil";
            fournisseur2.Telephone = "(11) 555 4640";

            Fournisseur fournisseur3 = new Fournisseur();
            fournisseur3.FournisseurId = 3;
            fournisseur3.NomCompanie = "Heli Süßwaren GmbH & Co. KG";
            fournisseur3.NomContact = "Petra Winkler";
            fournisseur3.TitreContact = "Sales Manager";
            fournisseur3.Adresse = "Tiergartenstraße 5";
            fournisseur3.Ville = "Berlin";
            fournisseur3.Province = "Baltimore";
            fournisseur3.CodePostal = "10785";
            fournisseur3.Pays = "Germany";
            fournisseur3.Telephone = "(010) 9984510";

            WriteLine("Fournisseurs: \n----------------------------------------");
            WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}", 
                fournisseur1.FournisseurId, 
                fournisseur1.NomCompanie,
                fournisseur1.NomContact,
                fournisseur1.TitreContact,
                fournisseur1.Adresse,
                fournisseur1.Ville,
                fournisseur1.Province,
                fournisseur1.CodePostal,
                fournisseur1.Pays,
                fournisseur1.Telephone);

           WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}", 
                fournisseur2.FournisseurId, 
                fournisseur2.NomCompanie,
                fournisseur2.NomContact,
                fournisseur2.TitreContact,
                fournisseur2.Adresse,
                fournisseur2.Ville,
                fournisseur2.Province,
                fournisseur2.CodePostal,
                fournisseur2.Pays,
                fournisseur2.Telephone);

           WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}", 
                fournisseur3.FournisseurId, 
                fournisseur3.NomCompanie,
                fournisseur3.NomContact,
                fournisseur3.TitreContact,
                fournisseur3.Adresse,
                fournisseur3.Ville,
                fournisseur3.Province,
                fournisseur3.CodePostal,
                fournisseur3.Pays,
                fournisseur3.Telephone);

            ReadLine();

            //Commandes instance and print list
            Commande commande1 = new Commande(client1);
            commande1.CommandeId = 10256;
            commande1.CientId = client1.GetClientId();
            commande1.EmployeId = 3;
            commande1.DateCommande = new DateTime(1996-07-15);
            commande1.DateRequise = new DateTime(1996-08-12);
            commande1.DateEnvoi = new DateTime(1996-07-17);
            commande1.NomEnvoi = "Wellington Importadora";
            commande1.AdresseEnvoi = "Rua do Mercado, 12";
            commande1.VilleEnvoi = "Resende";
            commande1.CodePostalEnvoi = "08737-363";
            commande1.PaysEnvoi = "Brazil";

            Commande commande2 = new Commande(client2);
            commande2.CommandeId = 10261;
            commande2.CientId = client2.GetClientId();
            commande2.EmployeId = 4;
            commande2.DateCommande = new DateTime(1996-07-19);
            commande2.DateRequise = new DateTime(1996-08-16);
            commande2.DateEnvoi = new DateTime(1996-07-30);
            commande2.NomEnvoi = "Que Delícia";
            commande2.AdresseEnvoi = "Rua da Panificadora, 12";
            commande2.VilleEnvoi = "Rio de Janeiro";
            commande2.CodePostalEnvoi = "02389-673";
            commande2.PaysEnvoi = "Brazil";

            Commande commande3 = new Commande(client3);
            commande3.CommandeId = 10264;
            commande3.CientId = client3.GetClientId();
            commande3.EmployeId = 6;
            commande3.DateCommande = new DateTime(1996-07-24);
            commande3.DateRequise = new DateTime(1996-08-21);
            commande3.DateEnvoi = new DateTime(1996-08-23);
            commande3.NomEnvoi = "Folk och fä HB";
            commande3.AdresseEnvoi = "Åkergatan 24";
            commande3.VilleEnvoi = "Bräcke";
            commande3.CodePostalEnvoi = "S-844 67";
            commande3.PaysEnvoi = "Sweden";

            WriteLine("Commandes: \n----------------------------------------");
            WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}    {10}", 
                 commande1.CommandeId, 
                 commande1.CientId,
                 commande1.EmployeId,
                 commande1.DateCommande,
                 commande1.DateRequise,
                 commande1.DateEnvoi,
                 commande1.NomEnvoi,
                 commande1.AdresseEnvoi,
                 commande1.VilleEnvoi,
                 commande1.CodePostalEnvoi,
                 commande1.PaysEnvoi);

            WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}    {10}", 
                 commande2.CommandeId, 
                 commande2.CientId,
                 commande2.EmployeId,
                 commande2.DateCommande,
                 commande2.DateRequise,
                 commande2.DateEnvoi,
                 commande2.NomEnvoi,
                 commande2.AdresseEnvoi,
                 commande2.VilleEnvoi,
                 commande2.CodePostalEnvoi,
                 commande2.PaysEnvoi);

            WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}    {10}", 
                 commande3.CommandeId, 
                 commande3.CientId,
                 commande3.EmployeId,
                 commande3.DateCommande,
                 commande3.DateRequise,
                 commande3.DateEnvoi,
                 commande3.NomEnvoi,
                 commande3.AdresseEnvoi,
                 commande3.VilleEnvoi,
                 commande3.CodePostalEnvoi,
                 commande3.PaysEnvoi);
            
            ReadLine();

        }
    }
}
