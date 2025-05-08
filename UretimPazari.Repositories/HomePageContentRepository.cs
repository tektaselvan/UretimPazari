using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class HomePageContentRepository : RepositoryBase<HomePageContent>, IHomePageContentRepository
    {
        public HomePageContentRepository(RepositoryContext context) : base(context) { }

        public IEnumerable<HomePageContent> GetAllContents(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public HomePageContent? GetOneContent(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id == id, trackChanges).SingleOrDefault();
        }

        public void CreateContent(HomePageContent content)
        {
            Create(content);
        }

        public void UpdateContent(HomePageContent content)
        {
            Update(content);
        }

        public void DeleteContent(HomePageContent content)
        {
            Delete(content);
        }
    }
}
