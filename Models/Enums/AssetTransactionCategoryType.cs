using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Transaction Category Type Enumerated derived by Vendor.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetTransactionCategoryType>))]
public sealed record AssetTransactionCategoryType : StringEnum<AssetTransactionCategoryType>
{
    private AssetTransactionCategoryType(string value) : base(value)
    {
    }

    public static readonly AssetTransactionCategoryType AtmFee = new("ATMFee");

    public static readonly AssetTransactionCategoryType Advertising = new("Advertising");

    public static readonly AssetTransactionCategoryType AirTravel = new("AirTravel");

    public static readonly AssetTransactionCategoryType AlcoholBars = new("AlcoholBars");

    public static readonly AssetTransactionCategoryType Allowance = new("Allowance");

    public static readonly AssetTransactionCategoryType Amusement = new("Amusement");

    public static readonly AssetTransactionCategoryType Arts = new("Arts");

    public static readonly AssetTransactionCategoryType AutoTransport = new("AutoTransport");

    public static readonly AssetTransactionCategoryType AutoInsurance = new("AutoInsurance");

    public static readonly AssetTransactionCategoryType AutoPayment = new("AutoPayment");

    public static readonly AssetTransactionCategoryType BabySupplies = new("BabySupplies");

    public static readonly AssetTransactionCategoryType BabysitterDaycare = new("BabysitterDaycare");

    public static readonly AssetTransactionCategoryType BankFee = new("BankFee");

    public static readonly AssetTransactionCategoryType BillsUtilities = new("BillsUtilities");

    public static readonly AssetTransactionCategoryType Bonus = new("Bonus");

    public static readonly AssetTransactionCategoryType BooksSupplies = new("BooksSupplies");

    public static readonly AssetTransactionCategoryType BusinessServices = new("Business Services");

    public static readonly AssetTransactionCategoryType Buy = new("Buy");

    public static readonly AssetTransactionCategoryType CashAtm = new("CashATM");

    public static readonly AssetTransactionCategoryType Charity = new("Charity");

    public static readonly AssetTransactionCategoryType Check = new("Check");

    public static readonly AssetTransactionCategoryType ChildSupport = new("ChildSupport");

    public static readonly AssetTransactionCategoryType Clothing = new("Clothing");

    public static readonly AssetTransactionCategoryType CoffeeShops = new("CoffeeShops");

    public static readonly AssetTransactionCategoryType CreditCardPayment = new("CreditCardPayment");

    public static readonly AssetTransactionCategoryType Dentist = new("Dentist");

    public static readonly AssetTransactionCategoryType Doctor = new("Doctor");

    public static readonly AssetTransactionCategoryType Education = new("Education");

    public static readonly AssetTransactionCategoryType ElectronicsSoftware = new("ElectronicsSoftware");

    public static readonly AssetTransactionCategoryType Entertainment = new("Entertainment");

    public static readonly AssetTransactionCategoryType Eyecare = new("Eyecare");

    public static readonly AssetTransactionCategoryType FastFood = new("FastFood");

    public static readonly AssetTransactionCategoryType FederalTax = new("FederalTax");

    public static readonly AssetTransactionCategoryType FeesCharges = new("FeesCharges");

    public static readonly AssetTransactionCategoryType FinanceCharge = new("FinanceCharge");

    public static readonly AssetTransactionCategoryType Financial = new("Financial");

    public static readonly AssetTransactionCategoryType FinancialAdvisor = new("FinancialAdvisor");

    public static readonly AssetTransactionCategoryType FoodDining = new("FoodDining");

    public static readonly AssetTransactionCategoryType Furnishings = new("Furnishings");

    public static readonly AssetTransactionCategoryType GasFuel = new("GasFuel");

    public static readonly AssetTransactionCategoryType GiftsDonations = new("GiftsDonations");

    public static readonly AssetTransactionCategoryType Groceries = new("Groceries");

    public static readonly AssetTransactionCategoryType Gym = new("Gym");

    public static readonly AssetTransactionCategoryType Hair = new("Hair");

    public static readonly AssetTransactionCategoryType HealthFitness = new("HealthFitness");

    public static readonly AssetTransactionCategoryType HealthInsurance = new("HealthInsurance");

    public static readonly AssetTransactionCategoryType Hobbies = new("Hobbies");

    public static readonly AssetTransactionCategoryType Home = new("Home");

    public static readonly AssetTransactionCategoryType HomeImprovement = new("HomeImprovement");

    public static readonly AssetTransactionCategoryType HomeInsurance = new("HomeInsurance");

    public static readonly AssetTransactionCategoryType HomePhone = new("HomePhone");

    public static readonly AssetTransactionCategoryType HomeServices = new("HomeServices");

    public static readonly AssetTransactionCategoryType HomeSupplies = new("HomeSupplies");

    public static readonly AssetTransactionCategoryType Hotel = new("Hotel");

    public static readonly AssetTransactionCategoryType Income = new("Income");

    public static readonly AssetTransactionCategoryType InterestIncome = new("InterestIncome");

    public static readonly AssetTransactionCategoryType Internet = new("Internet");

    public static readonly AssetTransactionCategoryType Investments = new("Investments");

    public static readonly AssetTransactionCategoryType Kids = new("Kids");

    public static readonly AssetTransactionCategoryType KidsActivities = new("KidsActivities");

    public static readonly AssetTransactionCategoryType LateFee = new("LateFee");

    public static readonly AssetTransactionCategoryType Laundry = new("Laundry");

    public static readonly AssetTransactionCategoryType LawnGarden = new("LawnGarden");

    public static readonly AssetTransactionCategoryType Legal = new("Legal");

    public static readonly AssetTransactionCategoryType LifeInsurance = new("LifeInsurance");

    public static readonly AssetTransactionCategoryType LoanInsurance = new("LoanInsurance");

    public static readonly AssetTransactionCategoryType LoanPayment = new("LoanPayment");

    public static readonly AssetTransactionCategoryType Loans = new("Loans");

    public static readonly AssetTransactionCategoryType MobilePhone = new("MobilePhone");

    public static readonly AssetTransactionCategoryType MortgageRent = new("MortgageRent");

    public static readonly AssetTransactionCategoryType MoviesDvDs = new("MoviesDVDs");

    public static readonly AssetTransactionCategoryType Music = new("Music");

    public static readonly AssetTransactionCategoryType NewspapersMagazines = new("NewspapersMagazines");

    public static readonly AssetTransactionCategoryType OfficeSupplies = new("OfficeSupplies");

    public static readonly AssetTransactionCategoryType Parking = new("Parking");

    public static readonly AssetTransactionCategoryType Paycheck = new("Paycheck");

    public static readonly AssetTransactionCategoryType PersonalCare = new("PersonalCare");

    public static readonly AssetTransactionCategoryType PetFoodSupplies = new("PetFoodSupplies");

    public static readonly AssetTransactionCategoryType PetGrooming = new("PetGrooming");

    public static readonly AssetTransactionCategoryType Pets = new("Pets");

    public static readonly AssetTransactionCategoryType Pharmacy = new("Pharmacy");

    public static readonly AssetTransactionCategoryType Printing = new("Printing");

    public static readonly AssetTransactionCategoryType PropertyTax = new("Property Tax");

    public static readonly AssetTransactionCategoryType PublicTransportation = new("Public Transportation");

    public static readonly AssetTransactionCategoryType Reimbursement = new("Reimbursement");

    public static readonly AssetTransactionCategoryType RentalCarTaxi = new("RentalCarTaxi");

    public static readonly AssetTransactionCategoryType Restaurants = new("Restaurants");

    public static readonly AssetTransactionCategoryType SalesTax = new("SalesTax");

    public static readonly AssetTransactionCategoryType ServiceParts = new("ServiceParts");

    public static readonly AssetTransactionCategoryType ServiceFee = new("ServiceFee");

    public static readonly AssetTransactionCategoryType Shipping = new("Shipping");

    public static readonly AssetTransactionCategoryType Shopping = new("Shopping");

    public static readonly AssetTransactionCategoryType SpaMassage = new("SpaMassage");

    public static readonly AssetTransactionCategoryType SportingGoods = new("SportingGoods");

    public static readonly AssetTransactionCategoryType Sports = new("Sports");

    public static readonly AssetTransactionCategoryType StateTax = new("StateTax");

    public static readonly AssetTransactionCategoryType StudentLoan = new("Student Loan");

    public static readonly AssetTransactionCategoryType Taxes = new("Taxes");

    public static readonly AssetTransactionCategoryType Television = new("Television");

    public static readonly AssetTransactionCategoryType Toys = new("Toys");

    public static readonly AssetTransactionCategoryType Transfer = new("Transfer");

    public static readonly AssetTransactionCategoryType Travel = new("Travel");

    public static readonly AssetTransactionCategoryType Tuition = new("Tuition");

    public static readonly AssetTransactionCategoryType Uncategorized = new("Uncategorized");

    public static readonly AssetTransactionCategoryType Utilities = new("Utilities");

    public static readonly AssetTransactionCategoryType Vacation = new("Vacation");

    public static readonly AssetTransactionCategoryType Veterinary = new("Veterinary");

    public static AssetTransactionCategoryType FromValue(string value) => FromValueCore(value);
}
