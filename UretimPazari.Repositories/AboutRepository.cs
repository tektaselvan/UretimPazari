using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class AboutRepository : RepositoryBase<About>, IAboutRepository
    {
        public AboutRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateAbout(About about)
        {
            CreateAbout(about);
        }

        public void DeleteAbout(About about)
        {
            DeleteAbout(about);
        }

        public IEnumerable<About> GetAllAbouts(bool trackChanges)
        {
           return FindAll(trackChanges).ToList();
        }

        public About? GetOneAbout(int id, bool trackChanges)
        {
            return FindByCondition(a=>a.AboutId==id,trackChanges).SingleOrDefault();
        }

        public void UpdateAbout(About about)
        {
            UpdateAbout(about);
        }
    }
}
