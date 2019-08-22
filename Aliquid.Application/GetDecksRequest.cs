namespace Aliquid.Application
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Interfaces;
    using MediatR;

    public class GetDecksRequest : IRequest<int>
    {
        public ICollection<string> Pile { get; set; }
    }

    public class GetDecksRequestHandler : IRequestHandler<GetDecksRequest, int>
    {
        private readonly IDeckAnalyzer _analyzer;

        public GetDecksRequestHandler(IDeckAnalyzer analyzer)
        {
            _analyzer = analyzer;
        }

        public async Task<int> Handle(GetDecksRequest request, CancellationToken cancellationToken)
        {
            return await Task.Run(() => (_analyzer.GetFullDecksAmount(request.Pile)));
        }
    }
}