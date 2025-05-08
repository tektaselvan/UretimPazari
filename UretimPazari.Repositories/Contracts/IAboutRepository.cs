using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IAboutRepository:IRepositoryBase<About>
    {
        IEnumerable<About> GetAllAbouts(bool trackChanges);
        About? GetOneAbout(int id, bool trackChanges);
        void CreateAbout(About about);
        void UpdateAbout(About about);
        void DeleteAbout(About about);
    }
}
