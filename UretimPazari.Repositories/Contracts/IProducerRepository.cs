using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IProducerRepository:IRepositoryBase<Producer>
    {
        IEnumerable<Producer> GetAllProducers(bool trackChanges);
        Producer? GetOneProducer(int id, bool trackChanges);
        void CreateProducer(Producer producer);
        void UpdateProducer(Producer producer);
        void DeleteProducer(Producer producer);
    }
}
