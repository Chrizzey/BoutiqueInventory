using System.Collections.ObjectModel;
using BoutiqueInventory.Articles;

namespace BoutiqueInventory
{
    public class Inventory : IInventory
    {
        private readonly Dictionary<int, Article> _articles;

        public Inventory()
        {
            _articles = new Dictionary<int, Article>();
        }

        public void AddArticle(Article article)
        {
            if (_articles.ContainsKey(article.Number))
            {
                throw new InvalidOperationException("An article with the same number already exists");
            }

            _articles.Add(article.Number, article);
        }

        public void RemoveArticle(Article article)
        {
            RemoveArticle(article.Number);
        }

        public void RemoveArticle(int number)
        {
            _articles.Remove(number);
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return new ReadOnlyCollection<Article>(_articles.Values.ToArray());
        }

        public Article GetArticleByNumber(int number)
        {
            return _articles.ContainsKey(number)
                ? _articles[number] 
                : null;
        }

        public IEnumerable<T> GetArticlesByType<T>() where T : Article
        {
            return new ReadOnlyCollection<T>(_articles.Values.OfType<T>().ToArray());
        }
    }
}