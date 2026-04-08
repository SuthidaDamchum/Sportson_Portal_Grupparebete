using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Repos
{
    public class NewsArticleRepo : INewsArticleRepo
    {
        private List<NewsArticle> _list = new List<NewsArticle>()


        {
            new NewsArticle

                (1,"Uppdatering av intranätet","Vi har uppgraderat säkerheten i vår inloggning. Från och med måndag kräv " +
                "tvåfaktorsautentisering för alla användare på huvudkontoret.", "Daniel Andersson" , 20260401, CategoryEnum.IT),
            new NewsArticle (2, "Leveransförseningar elcyklar",
                 "På grund av globala logistikproblem är leveransen av årets elcyklar från Crescent försenad med två veckor. " +
                 "Vi ber butikerna att informera kunder som förbeställt" ,"Sara Lindberg" ,20260402, CategoryEnum.Inköp),

            new NewsArticle (3, "Vårkampanjen drar igång!", "Nu är det officiellt – vår stora vårkampanj startar den 15 april " +
                "Marknadsavdelningen har laddat upp nytt material i bildbanken.", "Erik Markström" , 20260403 , CategoryEnum.Marknad),


            new NewsArticle(4, "Nya krav på certifiering",
            "Från 1 maj inför vi nya krav på certifiering för service av specifika elsystem från Shimano. Anmäl er till utbildningsdagarna senast nästa fredag.", 
            "Mikael Verkstadsson", 20260404 , CategoryEnum.Verkstad)

        };


        public Task<List<NewsArticle>> GetNewsAsync()
        {
            return Task.FromResult(_list);
        }
        public  Task<bool> DeleteNewsAsync(int id)
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
