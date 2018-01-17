using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BLL
{
    public class ArticleRepository
    {
        private BlogContext db = new BlogContext();
        public Article GetArticleByID(int ID)
        {
            return db.Articles.Find(ID);
        }
        public List<Article> GetAllArticles()
        {
            return db.Articles.ToList();
        }
        public List<Article> GetAllArticlesOrderByDate()
        {
            return db.Articles.OrderByDescending(x => x.InsertDate).ToList();
        }
        public List<Article> SearchArticles(string searchtext)
        {
            return db.Articles.Where(x => x.Title.Contains(searchtext) ||
            x.Description.Contains(searchtext)).ToList();
            
        }
        public void AddArticle(Article newArticle)
        {
            db.Articles.Add(newArticle);
            db.SaveChanges();
        }
        public void DeleteArticle(Article trash)
        {
            db.Articles.Remove(trash);
            db.SaveChanges();
            
        }
        public void DeleteArticleByID(int ID)
        {
            db.Articles.Remove(GetArticleByID(ID));
            db.SaveChanges();
        }
        public void UpdateArticle(Article updatedArticle)
        {
            var original = GetArticleByID(updatedArticle.ArticleID);
            original.Content = updatedArticle.Content;
            original.Title = updatedArticle.Title;
            original.Description = updatedArticle.Description;
            original.TotalRate = updatedArticle.TotalRate;
            db.Entry(original).State = EntityState.Modified;
            db.SaveChanges();
        }
        
    }
    public class EmailSubscriptionRepository
    {
        private BlogContext db = new BlogContext();
        public EmailSubscription GetEmailSubscriptionByID(int ID)
        {
            return db.Emails.Find(ID);
        }
        public List<EmailSubscription> GetAllEmailSubscriptions()
        {
            return db.Emails.ToList();
        }
        
        public void AddEmailSubscription(EmailSubscription Email)
        {
            db.Emails.Add(Email);
            db.SaveChanges();
        }
        public void DeleteEmailSubscription(EmailSubscription trash)
        {
            db.Emails.Remove(trash);
            db.SaveChanges();

        }
        public void DeleteEmailSubscriptionByID(int ID)
        {
            db.Emails.Remove(GetEmailSubscriptionByID(ID));
            db.SaveChanges();
        }
        public void UpdateEmailSubscription(EmailSubscription updatedEmailSubscription)
        {
            var original = GetEmailSubscriptionByID(updatedEmailSubscription.EmailSubscriptionID);
            original.Email = updatedEmailSubscription.Email;
            db.Entry(original).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    
}
