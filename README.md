📝 Blog2 Project - ASP.NET Core API

Système de gestion de blog avec articles et commentaires, utilisant Entity Framework Core et MySQL.

## 🚀 Technologies
* **Framework:** .NET 9.0
* **Base de données:** MySQL (via Pomelo EF Core)
* **Documentation:** Swagger (Swashbuckle)

## 🛠️ Installation
1. Cloner le dépôt.
2. Configurer la chaîne de connexion dans `appsettings.json`.
3. Appliquer les migrations :
   ```bash
   dotnet ef database update

   ## 🗄️ Schéma de Données
- **Articles** : `Id`, `Title`, `Content`, `CreatedAt`.
- **Comments** : `Id`, `Author`, `Text`, `CreatedAt`, `ArticleId` (FK).

🚀 Fonctionnalités de l'API
L'API est structurée autour de deux ressources principales : les Articles et les Commentaires.

1. Gestion des Articles (/api/articles)
Cette section gère tout le contenu principal du blog.

Lister les articles (GET) : Récupère tous les articles de la base de données.

Fonctionnalité avancée : Pagination incluse. Utilise les paramètres ?page=1&pageSize=10 pour naviguer dans les résultats.

Afficher un article (GET {id}) : Récupère les détails d'un article spécifique grâce à son identifiant unique.

Créer un article (POST) : Ajoute un nouvel article.

Logique métier : La date de création (CreatedAt) est générée automatiquement par le serveur au Runtime.

Modifier un article (PUT {id}) : Met à jour le titre ou le contenu d'un article existant.

Supprimer un article (DELETE {id}) : Supprime définitivement un article de la base MySQL.

2. Gestion des Commentaires (/api/comments)
Permet l'interaction des lecteurs avec les articles.

Ajouter un commentaire (POST) : Envoie un commentaire lié à un article spécifique via une clé étrangère (ArticleId).

Lister les commentaires (GET) : Récupère l'ensemble des commentaires (souvent filtrés par ArticleId).

Supprimer un commentaire (DELETE {id}) : Permet la modération en supprimant un message précis.
