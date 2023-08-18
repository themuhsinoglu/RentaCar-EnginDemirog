using System;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
	public class CreateBrandCommand:IRequest<CreatedBrandResponse>
	{
		public string Name { get; set; }


        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
        {
            public Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                CreatedBrandResponse createdBrandResponse = new();
                createdBrandResponse.Name = request.Name;

                return null;
            }
        }
    }
}

