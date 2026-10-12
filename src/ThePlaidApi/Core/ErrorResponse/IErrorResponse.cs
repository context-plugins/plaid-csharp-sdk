using System.Threading;
using System.Threading.Tasks;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}