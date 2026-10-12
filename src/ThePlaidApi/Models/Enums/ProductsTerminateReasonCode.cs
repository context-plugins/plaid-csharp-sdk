using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The reason for terminating products.
/// <para>
/// <c>FRAUD_FIRST_PARTY</c>: The end user who owns the connected bank account committed fraud using their real identity
/// <c>FRAUD_FALSE_IDENTITY</c>: The connection was created using a false or stolen identity
/// <c>FRAUD_ABUSE</c>: The end user is abusing the client's service or platform (for example, automation or excessive retries) through their connected account
/// <c>FRAUD_OTHER</c>: Fraud-related, but not covered by the specific fraud categories above; <c>reason_note</c> should clarify
/// <c>FRAUD_TRANSACTION</c>: Fraud occurred at the transaction level, such as an unauthorized transaction, card testing, chargeback, ACH return, or dispute
/// <c>CONSUMER_LOAN_PAID_OFF</c>: The end user paid off their loan and no longer needs the product
/// <c>CONSUMER_ACCOUNT_CLOSED</c>: The end user closed their account with the client and no longer needs the product
/// <c>CONSUMER_CHARGE_OFF</c>: The end user's account has been charged off
/// <c>CONSUMER_PAYMENT_METHOD_SWITCHED</c>: The end user switched to a different payment method and no longer needs the product
/// <c>USER_OFFBOARDING</c>: The user is offboarding from the client's service or platform
/// <c>DUPLICATE_ITEM</c>: This Item is a duplicate of another active Item for the same user
/// <c>BILLING_TERMINATION</c>: The client's billing or subscription relationship with the end user has ended
/// <c>OTHER</c>: None of the above; <c>reason_note</c> should clarify
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductsTerminateReasonCode>))]
public sealed record ProductsTerminateReasonCode : OpenStringEnum<ProductsTerminateReasonCode>
{
    private ProductsTerminateReasonCode(string value) : base(value)
    {
    }

    public static readonly ProductsTerminateReasonCode FraudFirstParty = new("FRAUD_FIRST_PARTY");

    public static readonly ProductsTerminateReasonCode FraudFalseIdentity = new("FRAUD_FALSE_IDENTITY");

    public static readonly ProductsTerminateReasonCode FraudAbuse = new("FRAUD_ABUSE");

    public static readonly ProductsTerminateReasonCode FraudOther = new("FRAUD_OTHER");

    public static readonly ProductsTerminateReasonCode FraudTransaction = new("FRAUD_TRANSACTION");

    public static readonly ProductsTerminateReasonCode ConsumerLoanPaidOff = new("CONSUMER_LOAN_PAID_OFF");

    public static readonly ProductsTerminateReasonCode ConsumerAccountClosed = new("CONSUMER_ACCOUNT_CLOSED");

    public static readonly ProductsTerminateReasonCode ConsumerChargeOff = new("CONSUMER_CHARGE_OFF");

    public static readonly ProductsTerminateReasonCode ConsumerPaymentMethodSwitched = new(
        "CONSUMER_PAYMENT_METHOD_SWITCHED");

    public static readonly ProductsTerminateReasonCode UserOffboarding = new("USER_OFFBOARDING");

    public static readonly ProductsTerminateReasonCode DuplicateItem = new("DUPLICATE_ITEM");

    public static readonly ProductsTerminateReasonCode BillingTermination = new("BILLING_TERMINATION");

    public static readonly ProductsTerminateReasonCode Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onFraudFirstParty,
        Func<TResult> onFraudFalseIdentity,
        Func<TResult> onFraudAbuse,
        Func<TResult> onFraudOther,
        Func<TResult> onFraudTransaction,
        Func<TResult> onConsumerLoanPaidOff,
        Func<TResult> onConsumerAccountClosed,
        Func<TResult> onConsumerChargeOff,
        Func<TResult> onConsumerPaymentMethodSwitched,
        Func<TResult> onUserOffboarding,
        Func<TResult> onDuplicateItem,
        Func<TResult> onBillingTermination,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FraudFirstParty => onFraudFirstParty(),
            _ when this == FraudFalseIdentity => onFraudFalseIdentity(),
            _ when this == FraudAbuse => onFraudAbuse(),
            _ when this == FraudOther => onFraudOther(),
            _ when this == FraudTransaction => onFraudTransaction(),
            _ when this == ConsumerLoanPaidOff => onConsumerLoanPaidOff(),
            _ when this == ConsumerAccountClosed => onConsumerAccountClosed(),
            _ when this == ConsumerChargeOff => onConsumerChargeOff(),
            _ when this == ConsumerPaymentMethodSwitched => onConsumerPaymentMethodSwitched(),
            _ when this == UserOffboarding => onUserOffboarding(),
            _ when this == DuplicateItem => onDuplicateItem(),
            _ when this == BillingTermination => onBillingTermination(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onFraudFirstParty,
        Action onFraudFalseIdentity,
        Action onFraudAbuse,
        Action onFraudOther,
        Action onFraudTransaction,
        Action onConsumerLoanPaidOff,
        Action onConsumerAccountClosed,
        Action onConsumerChargeOff,
        Action onConsumerPaymentMethodSwitched,
        Action onUserOffboarding,
        Action onDuplicateItem,
        Action onBillingTermination,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == FraudFirstParty) onFraudFirstParty();
        else if (this == FraudFalseIdentity) onFraudFalseIdentity();
        else if (this == FraudAbuse) onFraudAbuse();
        else if (this == FraudOther) onFraudOther();
        else if (this == FraudTransaction) onFraudTransaction();
        else if (this == ConsumerLoanPaidOff) onConsumerLoanPaidOff();
        else if (this == ConsumerAccountClosed) onConsumerAccountClosed();
        else if (this == ConsumerChargeOff) onConsumerChargeOff();
        else if (this == ConsumerPaymentMethodSwitched) onConsumerPaymentMethodSwitched();
        else if (this == UserOffboarding) onUserOffboarding();
        else if (this == DuplicateItem) onDuplicateItem();
        else if (this == BillingTermination) onBillingTermination();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
