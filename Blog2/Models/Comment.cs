using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Blog2.Models
     
{
    
    
        public class Comment
        {

       

[Table("comments")] // On force EF à chercher "comments" avec un S
    public class Comments
    {
        public int Id { get; set; }
    // ... le reste de tes propriétés
}
            public int Id { get; set; }
            public int ArticleId { get; set; }
            public string Author { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }

            public override string ToString() =>
                $"[Com {Id}] De {Author} le {CreatedAt:dd/MM/yyyy HH:mm} : {Content}";
        }
    
}
