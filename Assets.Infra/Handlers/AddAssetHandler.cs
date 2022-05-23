using Assets.Model;
using Assets.Model.Requests;
using MediatR;

namespace Assets.Infra.Handlers
{
    public class AddAssetHandler : IRequestHandler<AddAssetRequest, Guid>
    {
        private readonly IAssetRepository _repository;

        public AddAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddAssetRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();

            var asset = new Asset(id, request.Asset.Name, request.Asset.Group); //poderia usar um Automapper aqui

            await Task.Run(() => _repository.Add(asset), ct);

            return id;
        }
    }
}
