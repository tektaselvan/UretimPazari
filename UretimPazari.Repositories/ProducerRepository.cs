using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class ProducerRepository : RepositoryBase<Producer>, IProducerRepository
    {
        public ProducerRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateProducer(Producer producer)=>CreateProducer(producer);

        public void DeleteProducer(Producer producer)=>DeleteProducer(producer);

        public IEnumerable<Producer> GetAllProducers(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Producer? GetOneProducer(int id, bool trackChanges)
        {
            return FindByCondition(p => p.ProducerId==id, trackChanges).SingleOrDefault();
        }

        public void UpdateProducer(Producer producer)=>UpdateProducer(producer);
    }
}
