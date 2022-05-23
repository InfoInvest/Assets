using Assets.Model;
using MediatR;

namespace Assets.Infra.Handlers
{
    public class GetAssetsHandler : IRequestHandler<GetAssetsRequest, List<Asset>>
    {
        public GetAssetsHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        private readonly IAssetRepository _repository;

        public async Task<List<Asset>> Handle(GetAssetsRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_repository.GetRange(request.Start, request.End));
        }
    }
}