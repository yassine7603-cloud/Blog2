
using Blog2.Data;
using Blog2.Models;
using Blog2.Services;
using Blog2.Services.Developpement_Blog.Services;
using Blog2.UI;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
var builder = WebApplication.CreateBuilder(args);

// 1. Récupérer la chaîne de connexion
var connectionString = "server=localhost;database=blog_db;user=root;password=root";

// 2. Enregistrer le DbContext pour que l'API puisse l'utiliser partout
builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();
// Indique à l'API comment utiliser tes services
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<CommentService>();
builder.Services.AddScoped<ArticleService>();

// configuration dans  Program.cs pour dire à l'API d'ignorer les cycles.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });


// Configure Swagger (l'erreur AddSwaggerGen va disparaître après l'install)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ArticleService>();
//builder.Services.AddScoped<CommentService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ... le reste de ton code (Swagger, etc.)

var app = builder.Build();

// 3. Activer l'interface visuelle Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapControllers();
app.Run();
//var menu = new ConsoleMenu();
//menu.Show();