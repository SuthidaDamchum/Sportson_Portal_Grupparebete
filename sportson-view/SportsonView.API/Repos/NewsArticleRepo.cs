using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Repos
{
    public class NewsArticleRepo : INewsArticleRepo
    {
        private List<NewsArticle> _list = new List<NewsArticle>()


        {
            new NewsArticle

                (Guid.NewGuid(),"Uppdatering av intranätet","Vi har uppgraderat säkerheten i vår inloggning. Från och med måndag kräv " +
                "tvåfaktorsautentisering för alla användare på huvudkontoret.", "Daniel Andersson" , 20260401, "IT"),
            new NewsArticle (Guid.NewGuid(), "Leveransförseningar elcyklar",
                 "På grund av globala logistikproblem är leveransen av årets elcyklar från Crescent försenad med två veckor. " +
                 "Vi ber butikerna att informera kunder som förbeställt" ,"Sara Lindberg" ,20260402, "Inköp"),
                  
            new NewsArticle (Guid.NewGuid(), "Vårkampanjen drar igång!", "Nu är det officiellt – vår stora vårkampanj startar den 15 april " +
                "Marknadsavdelningen har laddat upp nytt material i bildbanken.", "Erik Markström" , 20260403 ,"Marknad"),


            new NewsArticle(Guid.NewGuid(), "Nya krav på certifiering",
            "Från 1 maj inför vi nya krav på certifiering för service av specifika elsystem från Shimano. Anmäl er till utbildningsdagarna senast nästa fredag.", 
            "Mikael Verkstadsson", 20260404 , "Verkstad")

        };


        public Task<List<NewsArticle>> GetNewsAsync()
        {
            return Task.FromResult(_list);
        }
        public  Task<bool> DeleteNewsAsync(Guid id)
        {
            var articleToRemove = _list.FirstOrDefault(a => a.Id == id);

            if (articleToRemove == null)
            {
                return Task.FromResult(false);
            }
            
            _list.Remove(articleToRemove);
            return  Task.FromResult(true);
        }

        public void AddNewsArticleAsync(NewsArticle newsArticle)
        {
             _list.Add(newsArticle);
        }
    }
}
