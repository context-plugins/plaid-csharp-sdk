using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Flow types to retrieve payroll income data
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationPayrollFlowType>))]
public sealed record IncomeVerificationPayrollFlowType : StringEnum<IncomeVerificationPayrollFlowType>
{
    private IncomeVerificationPayrollFlowType(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationPayrollFlowType PayrollDigitalIncome = new("payroll_digital_income");

    public static readonly IncomeVerificationPayrollFlowType PayrollDocumentIncome = new("payroll_document_income");

    public static IncomeVerificationPayrollFlowType FromValue(string value) => FromValueCore(value);
}
