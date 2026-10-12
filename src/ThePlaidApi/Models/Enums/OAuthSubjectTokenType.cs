using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the subject token.
/// <c>urn:plaid:params:tokens:user</c> allows exchanging a Plaid-issued user token for an OAuth token. When using this token type, <c>audience</c> must be the same as the <c>client_id</c>. <c>subject_token</c> must be a Plaid-issued user token issued from the <c>/user/create</c> endpoint.
/// <c>urn:plaid:params:oauth:user-token</c> allows exchanging a refresh token for an OAuth token to another <c>client_id</c>. The other <c>client_id</c> is provided in <c>audience</c>. <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.
/// <c>urn:plaid:params:credit:multi-user</c> allows exchanging a Plaid-issued user token for an OAuth token. When using this token type, <c>audience</c> may be a client id or a supported CRA partner URN. <c>audience</c> supports a comma-delimited list of clients. When multiple clients are specified in the <c>audience</c> a multi-party token is created which can be used by all parties in the audience in conjunction with their <c>client_id</c> and <c>client_secret</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OAuthSubjectTokenType>))]
public sealed record OAuthSubjectTokenType : OpenStringEnum<OAuthSubjectTokenType>
{
    private OAuthSubjectTokenType(string value) : base(value)
    {
    }

    public static readonly OAuthSubjectTokenType UrnPlaidParamsTokensUser = new("urn:plaid:params:tokens:user");

    public static readonly OAuthSubjectTokenType UrnPlaidParamsOauthUserToken = new(
        "urn:plaid:params:oauth:user-token");

    public static readonly OAuthSubjectTokenType UrnPlaidParamsCreditMultiUser = new(
        "urn:plaid:params:credit:multi-user");

    public TResult Match<TResult>(Func<TResult> onUrnPlaidParamsTokensUser,
        Func<TResult> onUrnPlaidParamsOauthUserToken,
        Func<TResult> onUrnPlaidParamsCreditMultiUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UrnPlaidParamsTokensUser => onUrnPlaidParamsTokensUser(),
            _ when this == UrnPlaidParamsOauthUserToken => onUrnPlaidParamsOauthUserToken(),
            _ when this == UrnPlaidParamsCreditMultiUser => onUrnPlaidParamsCreditMultiUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onUrnPlaidParamsTokensUser,
        Action onUrnPlaidParamsOauthUserToken,
        Action onUrnPlaidParamsCreditMultiUser,
        Action<string> otherwise)
    {
        if (this == UrnPlaidParamsTokensUser) onUrnPlaidParamsTokensUser();
        else if (this == UrnPlaidParamsOauthUserToken) onUrnPlaidParamsOauthUserToken();
        else if (this == UrnPlaidParamsCreditMultiUser) onUrnPlaidParamsCreditMultiUser();
        else otherwise(Value);
    }
}
