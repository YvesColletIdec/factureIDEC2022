using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prjEFCore
{
    class Program
    {

        static void Main(string[] args)
        {
            //    FactureContext context = new FactureContext();
            //    Article art = new Article();
            //    art.Nom = "";
            //    art.Prix = 1;
            //    art.Designation = "";
            //    context.Articles.Add(art);
            //    context.SaveChanges();
        }
        //static void Main2(string[] args)
        //{
        //    //ouverture de la connexion à la base de données
        //    FactureContext context = new FactureContext();
        //    //récupérer les articles SELECT * FROM ARTICLE
        //    List<Article> listArticles = context.Articles.ToList();
        //    //afficher le contenu de la liste
        //    foreach(Article a in listArticles)
        //    {
        //        Console.WriteLine($"nom de l'article : {a.Nom} et nom de la catégorie : " + (a.Categorie == null ? "-" : a.Categorie.Nom));
        //    }
        //    //modification d'un article --> UPDATE ARTICLE SET NOM = "HELLO" WHERE ID = 1
        //    //récupérer article num 1 --> SELECT * FROM ARTICLE A WHERE A.ID == 1
        //    Article art = context.Articles.Where(a => a.Id == 1).FirstOrDefault();
        //    Console.WriteLine("--> " + art.Id + " " + art.Nom);
        //    //modification du nom
        //    art.Nom = "HELLO";
        //    //sauvegarde de toutes les modifications
        //    context.SaveChanges();
        //    //controle des modifications
        //    art = context.Articles.Where(a => a.Id == 1).FirstOrDefault();
        //    Console.WriteLine("--> " + art.Id + " " + art.Nom);
        //    Console.WriteLine("Hello World!");
        //}
    }
}
