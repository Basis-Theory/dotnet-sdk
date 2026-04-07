using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface ILogsClient
{
    Task<Pager<Log>> ListAsync(
        LogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IEnumerable<LogEntityType>> GetEntityTypesAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
