using BoutiqueInventory.Articles;

namespace BoutiqueInventory;

public interface IInventory
{
    /// <summary>
    /// Adds a given article to the inventory
    /// </summary>
    /// <param name="article"></param>
    void AddArticle(Article article);
    void RemoveArticle(Article article);
    void RemoveArticle(int number);
    IEnumerable<Article> GetAllArticles();
    Article GetArticleByNumber(int number);
    IEnumerable<T> GetArticlesByType<T>() where T : Article;
}