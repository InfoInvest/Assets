using MediatR;

namespace Assets.Model
{
    public record GetAssetsRequest(int Start, int End) : IRequest<List<Asset>>;
    public record AddAssetRequest(Asset Asset) : IRequest;
}