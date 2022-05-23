using Assets.Model;
using MediatR;

namespace Assets.Infra.Handlers
{
    public class AddAssetHandler : IRequestHandler<AddAssetRequest>
    {
        private readonly IAssetRepository _repository;

        public AddAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(AddAssetRequest request, CancellationToken ct)
        {
            await Task.Run(() => _repository.Add(request.Asset), ct);
            return Unit.Value;
        }
    }
}
