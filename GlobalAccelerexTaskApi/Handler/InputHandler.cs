using GlobalAccelerexTaskApi.models;
using MediatR;

namespace GlobalAccelerexTaskApi.Handler
{
    public class InputHandler
    {
        public class Command : IRequest<List<Response>> { public Dictionary<string, List<RequestType>> InputRequest { get; set; } }

        public class Handler : IRequestHandler<Command, List<Response>>
        {
            public Handler()
            {

            }
            public Task<List<Response>> Handle(Command request, CancellationToken cancellationToken)
            {

                var result = new List<Response>();
                foreach (var kvp in request.InputRequest)
                {

                    result.Add(new Response(kvp));

                }
                return Task.FromResult(result);
            }
        }
    }
}
