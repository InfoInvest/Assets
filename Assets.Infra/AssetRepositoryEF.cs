using Assets.Model;

namespace Assets.Infra
{
    public class AssetRepositoryEF : IAssetRepository
    {
        private readonly AssetsDbContext _context;

        public AssetRepositoryEF(AssetsDbContext context)
        {
            _context = context;
        }

        public void Add(Asset entity)
        {
            _context.Assets.Add(entity);
            _context.SaveChanges();
        }

        public Asset? GetById(Guid id)
        {
            return _context.Assets.Find(id);
        }

        public List<Asset> GetRange(int start, int end)
        {
            return _context.Assets.Skip(start).Take(end).ToList();
        }
    }
}
