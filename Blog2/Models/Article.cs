using System;
using System.Collections.Generic;
using System.Text;

namespace Blog2.Models
{
    using System.Text;

    namespace Developpement_Blog.Models
    {
        public class Article
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public List<Comment> Comments { get; set; } = new();

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"--- ARTICLE {Id} : {Title} ---");
                sb.AppendLine($"Créé le : {CreatedAt:dd/MM/yyyy HH:mm}");
                if (UpdatedAt.HasValue) sb.AppendLine($"Modifié le : {UpdatedAt:dd/MM/yyyy HH:mm}");
                sb.AppendLine($"Contenu : {Content}");
                sb.AppendLine($"Commentaires ({Comments.Count}) :");
                foreach (var c in Comments) sb.AppendLine($"  {c}");
                return sb.ToString();
            }
        }
    }
}
