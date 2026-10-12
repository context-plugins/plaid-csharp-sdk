using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Flow types to retrieve payroll income data
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationPayrollFlowType>))]
public sealed record IncomeVerificationPayrollFlowType : OpenStringEnum<IncomeVerificationPayrollFlowType>
{
    private IncomeVerificationPayrollFlowType(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationPayrollFlowType PayrollDigitalIncome = new("payroll_digital_income");

    public static readonly IncomeVerificationPayrollFlowType PayrollDocumentIncome = new("payroll_document_income");

    public TResult Match<TResult>(Func<TResult> onPayrollDigitalIncome,
        Func<TResult> onPayrollDocumentIncome,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PayrollDigitalIncome => onPayrollDigitalIncome(),
            _ when this == PayrollDocumentIncome => onPayrollDocumentIncome(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayrollDigitalIncome, Action onPayrollDocumentIncome, Action<string> otherwise)
    {
        if (this == PayrollDigitalIncome) onPayrollDigitalIncome();
        else if (this == PayrollDocumentIncome) onPayrollDocumentIncome();
        else otherwise(Value);
    }
}
