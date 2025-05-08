using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IHomePageContentRepository:IRepositoryBase<HomePageContent>
    {
        IEnumerable<HomePageContent> GetAllContents(bool trackChanges);
        HomePageContent? GetOneContent(int id, bool trackChanges);
        void CreateContent(HomePageContent content);
        void UpdateContent(HomePageContent content);
        void DeleteContent(HomePageContent content);
    }
}
