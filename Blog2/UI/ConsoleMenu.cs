using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Blog2.UI
{
    using Blog2.Models;
    using Blog2.Services;
    using Blog2.Services.Developpement_Blog.Services;




    internal class ConsoleMenu
    {
        //        private readonly ArticleService _articleService = new();
        //        private readonly CommentService _commentService = new();
        //        private Comment Comment=new Comment();


        //        public void Show()
        //        {
        //            while (true)
        //            {
        //            Console.Clear();
        //            Console.WriteLine("=== BLOG CONSOLE ===");
        //            Console.WriteLine("1. Lister les articles\n2. Créer un article\n3. Voir un article\n4. Modifier un article\n5. Supprimer un article\n6. Ajouter un commentaire\n7. Supprimer un commentaire\n0. Quitter");
        //                Console.Write("Votre choix : ");

        //                switch (Console.ReadLine())
        //                {
        //                    case "1": ListArticles(); break;
        //                    case "2": CreateArticle(); break;
        //                    case "3": ViewArticle(); break;
        //                    case "4": UpdateArticle(); break;
        //                    case "5": DeleteArticle(); break;
        //                    case "6": AddComment(); break;
        //                    case "7": DeleteCommentaire(); break;
        //                case "0": return;
        //                }
        //                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
        //                Console.ReadKey();
        //            }
        //        }

        //        private void ListArticles()
        //        {
        //            var articles = _articleService.GetAll();
        //            if (!articles.Any()) Console.WriteLine("Aucun article.");
        //            else articles.ForEach(a => Console.WriteLine($"[{a.Id}] {a.Title}"));
        //        }

        //        private void CreateArticle()
        //        {
        //            Console.Write("Titre : "); string t = Console.ReadLine() ?? "";
        //            Console.Write("Contenu : "); string c = Console.ReadLine() ?? "";
        //            _articleService.Create(t, c);
        //            Console.WriteLine("Article créé !");
        //        }

        //        private void ViewArticle()
        //        {
        //            Console.Write("ID de l'article : ");
        //            if (int.TryParse(Console.ReadLine(), out int id))
        //            {
        //                var art = _articleService.GetById(id);
        //                Console.WriteLine(art?.ToString() ?? "Article introuvable.");
        //            }
        //        }

        //        private void AddComment()
        //        {
        //            Console.Write("ID de l'article : ");
        //            if (int.TryParse(Console.ReadLine(), out int id))
        //            {
        //                var art = _articleService.GetById(id);
        //                if (art == null) { Console.WriteLine("Introuvable."); return; }

        //                Console.Write("Auteur : "); string a = Console.ReadLine() ?? "Anonyme";
        //                Console.Write("Contenu : "); string c = Console.ReadLine() ?? "";

        //                var com = _commentService.Create(id, a, c);
        //                art.Comments.Add(com);
        //                Console.WriteLine("Commentaire ajouté !");
        //            }
        //        }

        //        private void UpdateArticle()
        //        {
        //            Console.Write("ID à modifier : ");
        //            if (int.TryParse(Console.ReadLine(), out int id))
        //            {
        //                Console.Write("Nouveau titre : "); string t = Console.ReadLine() ?? "";
        //                Console.Write("Nouveau contenu : "); string c = Console.ReadLine() ?? "";
        //                if (_articleService.Update(id, t, c)) Console.WriteLine("Mis à jour !");
        //                else Console.WriteLine("Échec.");
        //            }
        //        }

        //        private void DeleteArticle()
        //        {
        //            Console.Write("ID à supprimer : ");
        //            if (int.TryParse(Console.ReadLine(), out int id))
        //            {
        //                if (_articleService.Delete(id)) Console.WriteLine("Supprimé.");
        //                else Console.WriteLine("Échec.");
        //            }
        //        }
        //        private void DeleteCommentaire()
        //    {
        //        Console.Write("ID Commentaire a supprimer");
        //        if(int.TryParse(Console.ReadLine(),out int id))
        //        {
        //            if(_commentService.Delete(id)) Console.WriteLine("Supprimé.");
        //            else Console.WriteLine("Échec.");
        //        }
        //    }

        //}



    }
}
