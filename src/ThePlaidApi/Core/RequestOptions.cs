using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using ThePlaidApi.Core.Hooks;

namespace ThePlaidApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
