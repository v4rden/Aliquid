namespace Aliquid.Application
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Interfaces;
    using MediatR;

    public class GetChangeRequest : IRequest<IEnumerable<int>>
    {
        public decimal Money { get; set; }
        public decimal ItemPrice { get; set; }
    }

    public class GetChangeRequestHandler : IRequestHandler<GetChangeRequest, IEnumerable<int>>
    {
        private readonly IChangeCalculator _calculator;

        public GetChangeRequestHandler(IChangeCalculator calculator)
        {
            _calculator = calculator;
        }

        public async Task<IEnumerable<int>> Handle(GetChangeRequest request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
                _calculator.GetChange(request.Money, request.ItemPrice));
        }
    }
}