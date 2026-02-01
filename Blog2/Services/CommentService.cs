using Blog2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog2.Services;
namespace Blog2.Services;

using Blog2.Data;
using Blog2.Models;



    public class CommentService:Comment
    {
        private readonly List<Comment> _comment = new();
        private int _nextId = 1;

        public Comment Create(int articleId, string author, string content)
        {
            return new Comment
            {
                Id = _nextId++,
                ArticleId = articleId,
                Author = author,
                Content = content,
                CreatedAt = DateTime.Now
            };
        }
    public Comment? GetById(int id) => _comment.FirstOrDefault(a => a.Id == id);
    public bool Delete(int id) => _comment.RemoveAll(a => a.Id == id) > 0;

    private readonly BlogDbContext _context;
    public CommentService(BlogDbContext context) => _context = context;

    public async Task<Comment> AddCommentAsync(Comment comment)
    {
        comment.CreatedAt = DateTime.Now;
        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    public async Task<bool> DeleteCommentAsync(int id)
    {
        var comment = await _context.Comments.FindAsync(id);
        if (comment == null) return false;

        _context.Comments.Remove(comment);
        await _context.SaveChangesAsync();
        return true;
    }
}

