using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the statement refresh extraction
/// <para>
/// <c>SUCCESS</c>: The statements were successfully extracted and can be listed via <c>/statements/list</c> and downloaded via <c>/statements/download</c>.
/// </para>
/// <para>
/// <c>FAILURE</c>: The statements failed to be extracted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatementsRefreshCompleteResult>))]
public sealed record StatementsRefreshCompleteResult : StringEnum<StatementsRefreshCompleteResult>
{
    private StatementsRefreshCompleteResult(string value) : base(value)
    {
    }

    public static readonly StatementsRefreshCompleteResult Success = new("SUCCESS");

    public static readonly StatementsRefreshCompleteResult Failure = new("FAILURE");

    public static StatementsRefreshCompleteResult FromValue(string value) => FromValueCore(value);
}
