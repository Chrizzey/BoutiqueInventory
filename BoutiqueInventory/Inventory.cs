using BoutiqueInventory.Articles;

namespace BoutiqueInventory
{
    public class Inventory
    {
        private List<Article> _articles;

        public void AddArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveArticle(int number)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            throw new System.NotImplementedException();
        }

        public Article GetArticleByNumber(int number)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetArticlesByType<T>() where T : Article
        {
            throw new System.NotImplementedException();
        }
    }
}