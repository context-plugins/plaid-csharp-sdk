using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Transaction Category Type Enumerated derived by Vendor.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetTransactionCategoryType>))]
public sealed record AssetTransactionCategoryType : OpenStringEnum<AssetTransactionCategoryType>
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

    public TResult Match<TResult>(Func<TResult> onAtmFee,
        Func<TResult> onAdvertising,
        Func<TResult> onAirTravel,
        Func<TResult> onAlcoholBars,
        Func<TResult> onAllowance,
        Func<TResult> onAmusement,
        Func<TResult> onArts,
        Func<TResult> onAutoTransport,
        Func<TResult> onAutoInsurance,
        Func<TResult> onAutoPayment,
        Func<TResult> onBabySupplies,
        Func<TResult> onBabysitterDaycare,
        Func<TResult> onBankFee,
        Func<TResult> onBillsUtilities,
        Func<TResult> onBonus,
        Func<TResult> onBooksSupplies,
        Func<TResult> onBusinessServices,
        Func<TResult> onBuy,
        Func<TResult> onCashAtm,
        Func<TResult> onCharity,
        Func<TResult> onCheck,
        Func<TResult> onChildSupport,
        Func<TResult> onClothing,
        Func<TResult> onCoffeeShops,
        Func<TResult> onCreditCardPayment,
        Func<TResult> onDentist,
        Func<TResult> onDoctor,
        Func<TResult> onEducation,
        Func<TResult> onElectronicsSoftware,
        Func<TResult> onEntertainment,
        Func<TResult> onEyecare,
        Func<TResult> onFastFood,
        Func<TResult> onFederalTax,
        Func<TResult> onFeesCharges,
        Func<TResult> onFinanceCharge,
        Func<TResult> onFinancial,
        Func<TResult> onFinancialAdvisor,
        Func<TResult> onFoodDining,
        Func<TResult> onFurnishings,
        Func<TResult> onGasFuel,
        Func<TResult> onGiftsDonations,
        Func<TResult> onGroceries,
        Func<TResult> onGym,
        Func<TResult> onHair,
        Func<TResult> onHealthFitness,
        Func<TResult> onHealthInsurance,
        Func<TResult> onHobbies,
        Func<TResult> onHome,
        Func<TResult> onHomeImprovement,
        Func<TResult> onHomeInsurance,
        Func<TResult> onHomePhone,
        Func<TResult> onHomeServices,
        Func<TResult> onHomeSupplies,
        Func<TResult> onHotel,
        Func<TResult> onIncome,
        Func<TResult> onInterestIncome,
        Func<TResult> onInternet,
        Func<TResult> onInvestments,
        Func<TResult> onKids,
        Func<TResult> onKidsActivities,
        Func<TResult> onLateFee,
        Func<TResult> onLaundry,
        Func<TResult> onLawnGarden,
        Func<TResult> onLegal,
        Func<TResult> onLifeInsurance,
        Func<TResult> onLoanInsurance,
        Func<TResult> onLoanPayment,
        Func<TResult> onLoans,
        Func<TResult> onMobilePhone,
        Func<TResult> onMortgageRent,
        Func<TResult> onMoviesDvDs,
        Func<TResult> onMusic,
        Func<TResult> onNewspapersMagazines,
        Func<TResult> onOfficeSupplies,
        Func<TResult> onParking,
        Func<TResult> onPaycheck,
        Func<TResult> onPersonalCare,
        Func<TResult> onPetFoodSupplies,
        Func<TResult> onPetGrooming,
        Func<TResult> onPets,
        Func<TResult> onPharmacy,
        Func<TResult> onPrinting,
        Func<TResult> onPropertyTax,
        Func<TResult> onPublicTransportation,
        Func<TResult> onReimbursement,
        Func<TResult> onRentalCarTaxi,
        Func<TResult> onRestaurants,
        Func<TResult> onSalesTax,
        Func<TResult> onServiceParts,
        Func<TResult> onServiceFee,
        Func<TResult> onShipping,
        Func<TResult> onShopping,
        Func<TResult> onSpaMassage,
        Func<TResult> onSportingGoods,
        Func<TResult> onSports,
        Func<TResult> onStateTax,
        Func<TResult> onStudentLoan,
        Func<TResult> onTaxes,
        Func<TResult> onTelevision,
        Func<TResult> onToys,
        Func<TResult> onTransfer,
        Func<TResult> onTravel,
        Func<TResult> onTuition,
        Func<TResult> onUncategorized,
        Func<TResult> onUtilities,
        Func<TResult> onVacation,
        Func<TResult> onVeterinary,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AtmFee => onAtmFee(),
            _ when this == Advertising => onAdvertising(),
            _ when this == AirTravel => onAirTravel(),
            _ when this == AlcoholBars => onAlcoholBars(),
            _ when this == Allowance => onAllowance(),
            _ when this == Amusement => onAmusement(),
            _ when this == Arts => onArts(),
            _ when this == AutoTransport => onAutoTransport(),
            _ when this == AutoInsurance => onAutoInsurance(),
            _ when this == AutoPayment => onAutoPayment(),
            _ when this == BabySupplies => onBabySupplies(),
            _ when this == BabysitterDaycare => onBabysitterDaycare(),
            _ when this == BankFee => onBankFee(),
            _ when this == BillsUtilities => onBillsUtilities(),
            _ when this == Bonus => onBonus(),
            _ when this == BooksSupplies => onBooksSupplies(),
            _ when this == BusinessServices => onBusinessServices(),
            _ when this == Buy => onBuy(),
            _ when this == CashAtm => onCashAtm(),
            _ when this == Charity => onCharity(),
            _ when this == Check => onCheck(),
            _ when this == ChildSupport => onChildSupport(),
            _ when this == Clothing => onClothing(),
            _ when this == CoffeeShops => onCoffeeShops(),
            _ when this == CreditCardPayment => onCreditCardPayment(),
            _ when this == Dentist => onDentist(),
            _ when this == Doctor => onDoctor(),
            _ when this == Education => onEducation(),
            _ when this == ElectronicsSoftware => onElectronicsSoftware(),
            _ when this == Entertainment => onEntertainment(),
            _ when this == Eyecare => onEyecare(),
            _ when this == FastFood => onFastFood(),
            _ when this == FederalTax => onFederalTax(),
            _ when this == FeesCharges => onFeesCharges(),
            _ when this == FinanceCharge => onFinanceCharge(),
            _ when this == Financial => onFinancial(),
            _ when this == FinancialAdvisor => onFinancialAdvisor(),
            _ when this == FoodDining => onFoodDining(),
            _ when this == Furnishings => onFurnishings(),
            _ when this == GasFuel => onGasFuel(),
            _ when this == GiftsDonations => onGiftsDonations(),
            _ when this == Groceries => onGroceries(),
            _ when this == Gym => onGym(),
            _ when this == Hair => onHair(),
            _ when this == HealthFitness => onHealthFitness(),
            _ when this == HealthInsurance => onHealthInsurance(),
            _ when this == Hobbies => onHobbies(),
            _ when this == Home => onHome(),
            _ when this == HomeImprovement => onHomeImprovement(),
            _ when this == HomeInsurance => onHomeInsurance(),
            _ when this == HomePhone => onHomePhone(),
            _ when this == HomeServices => onHomeServices(),
            _ when this == HomeSupplies => onHomeSupplies(),
            _ when this == Hotel => onHotel(),
            _ when this == Income => onIncome(),
            _ when this == InterestIncome => onInterestIncome(),
            _ when this == Internet => onInternet(),
            _ when this == Investments => onInvestments(),
            _ when this == Kids => onKids(),
            _ when this == KidsActivities => onKidsActivities(),
            _ when this == LateFee => onLateFee(),
            _ when this == Laundry => onLaundry(),
            _ when this == LawnGarden => onLawnGarden(),
            _ when this == Legal => onLegal(),
            _ when this == LifeInsurance => onLifeInsurance(),
            _ when this == LoanInsurance => onLoanInsurance(),
            _ when this == LoanPayment => onLoanPayment(),
            _ when this == Loans => onLoans(),
            _ when this == MobilePhone => onMobilePhone(),
            _ when this == MortgageRent => onMortgageRent(),
            _ when this == MoviesDvDs => onMoviesDvDs(),
            _ when this == Music => onMusic(),
            _ when this == NewspapersMagazines => onNewspapersMagazines(),
            _ when this == OfficeSupplies => onOfficeSupplies(),
            _ when this == Parking => onParking(),
            _ when this == Paycheck => onPaycheck(),
            _ when this == PersonalCare => onPersonalCare(),
            _ when this == PetFoodSupplies => onPetFoodSupplies(),
            _ when this == PetGrooming => onPetGrooming(),
            _ when this == Pets => onPets(),
            _ when this == Pharmacy => onPharmacy(),
            _ when this == Printing => onPrinting(),
            _ when this == PropertyTax => onPropertyTax(),
            _ when this == PublicTransportation => onPublicTransportation(),
            _ when this == Reimbursement => onReimbursement(),
            _ when this == RentalCarTaxi => onRentalCarTaxi(),
            _ when this == Restaurants => onRestaurants(),
            _ when this == SalesTax => onSalesTax(),
            _ when this == ServiceParts => onServiceParts(),
            _ when this == ServiceFee => onServiceFee(),
            _ when this == Shipping => onShipping(),
            _ when this == Shopping => onShopping(),
            _ when this == SpaMassage => onSpaMassage(),
            _ when this == SportingGoods => onSportingGoods(),
            _ when this == Sports => onSports(),
            _ when this == StateTax => onStateTax(),
            _ when this == StudentLoan => onStudentLoan(),
            _ when this == Taxes => onTaxes(),
            _ when this == Television => onTelevision(),
            _ when this == Toys => onToys(),
            _ when this == Transfer => onTransfer(),
            _ when this == Travel => onTravel(),
            _ when this == Tuition => onTuition(),
            _ when this == Uncategorized => onUncategorized(),
            _ when this == Utilities => onUtilities(),
            _ when this == Vacation => onVacation(),
            _ when this == Veterinary => onVeterinary(),
            _ => otherwise(Value)
        };

    public void Match(Action onAtmFee,
        Action onAdvertising,
        Action onAirTravel,
        Action onAlcoholBars,
        Action onAllowance,
        Action onAmusement,
        Action onArts,
        Action onAutoTransport,
        Action onAutoInsurance,
        Action onAutoPayment,
        Action onBabySupplies,
        Action onBabysitterDaycare,
        Action onBankFee,
        Action onBillsUtilities,
        Action onBonus,
        Action onBooksSupplies,
        Action onBusinessServices,
        Action onBuy,
        Action onCashAtm,
        Action onCharity,
        Action onCheck,
        Action onChildSupport,
        Action onClothing,
        Action onCoffeeShops,
        Action onCreditCardPayment,
        Action onDentist,
        Action onDoctor,
        Action onEducation,
        Action onElectronicsSoftware,
        Action onEntertainment,
        Action onEyecare,
        Action onFastFood,
        Action onFederalTax,
        Action onFeesCharges,
        Action onFinanceCharge,
        Action onFinancial,
        Action onFinancialAdvisor,
        Action onFoodDining,
        Action onFurnishings,
        Action onGasFuel,
        Action onGiftsDonations,
        Action onGroceries,
        Action onGym,
        Action onHair,
        Action onHealthFitness,
        Action onHealthInsurance,
        Action onHobbies,
        Action onHome,
        Action onHomeImprovement,
        Action onHomeInsurance,
        Action onHomePhone,
        Action onHomeServices,
        Action onHomeSupplies,
        Action onHotel,
        Action onIncome,
        Action onInterestIncome,
        Action onInternet,
        Action onInvestments,
        Action onKids,
        Action onKidsActivities,
        Action onLateFee,
        Action onLaundry,
        Action onLawnGarden,
        Action onLegal,
        Action onLifeInsurance,
        Action onLoanInsurance,
        Action onLoanPayment,
        Action onLoans,
        Action onMobilePhone,
        Action onMortgageRent,
        Action onMoviesDvDs,
        Action onMusic,
        Action onNewspapersMagazines,
        Action onOfficeSupplies,
        Action onParking,
        Action onPaycheck,
        Action onPersonalCare,
        Action onPetFoodSupplies,
        Action onPetGrooming,
        Action onPets,
        Action onPharmacy,
        Action onPrinting,
        Action onPropertyTax,
        Action onPublicTransportation,
        Action onReimbursement,
        Action onRentalCarTaxi,
        Action onRestaurants,
        Action onSalesTax,
        Action onServiceParts,
        Action onServiceFee,
        Action onShipping,
        Action onShopping,
        Action onSpaMassage,
        Action onSportingGoods,
        Action onSports,
        Action onStateTax,
        Action onStudentLoan,
        Action onTaxes,
        Action onTelevision,
        Action onToys,
        Action onTransfer,
        Action onTravel,
        Action onTuition,
        Action onUncategorized,
        Action onUtilities,
        Action onVacation,
        Action onVeterinary,
        Action<string> otherwise)
    {
        if (this == AtmFee) onAtmFee();
        else if (this == Advertising) onAdvertising();
        else if (this == AirTravel) onAirTravel();
        else if (this == AlcoholBars) onAlcoholBars();
        else if (this == Allowance) onAllowance();
        else if (this == Amusement) onAmusement();
        else if (this == Arts) onArts();
        else if (this == AutoTransport) onAutoTransport();
        else if (this == AutoInsurance) onAutoInsurance();
        else if (this == AutoPayment) onAutoPayment();
        else if (this == BabySupplies) onBabySupplies();
        else if (this == BabysitterDaycare) onBabysitterDaycare();
        else if (this == BankFee) onBankFee();
        else if (this == BillsUtilities) onBillsUtilities();
        else if (this == Bonus) onBonus();
        else if (this == BooksSupplies) onBooksSupplies();
        else if (this == BusinessServices) onBusinessServices();
        else if (this == Buy) onBuy();
        else if (this == CashAtm) onCashAtm();
        else if (this == Charity) onCharity();
        else if (this == Check) onCheck();
        else if (this == ChildSupport) onChildSupport();
        else if (this == Clothing) onClothing();
        else if (this == CoffeeShops) onCoffeeShops();
        else if (this == CreditCardPayment) onCreditCardPayment();
        else if (this == Dentist) onDentist();
        else if (this == Doctor) onDoctor();
        else if (this == Education) onEducation();
        else if (this == ElectronicsSoftware) onElectronicsSoftware();
        else if (this == Entertainment) onEntertainment();
        else if (this == Eyecare) onEyecare();
        else if (this == FastFood) onFastFood();
        else if (this == FederalTax) onFederalTax();
        else if (this == FeesCharges) onFeesCharges();
        else if (this == FinanceCharge) onFinanceCharge();
        else if (this == Financial) onFinancial();
        else if (this == FinancialAdvisor) onFinancialAdvisor();
        else if (this == FoodDining) onFoodDining();
        else if (this == Furnishings) onFurnishings();
        else if (this == GasFuel) onGasFuel();
        else if (this == GiftsDonations) onGiftsDonations();
        else if (this == Groceries) onGroceries();
        else if (this == Gym) onGym();
        else if (this == Hair) onHair();
        else if (this == HealthFitness) onHealthFitness();
        else if (this == HealthInsurance) onHealthInsurance();
        else if (this == Hobbies) onHobbies();
        else if (this == Home) onHome();
        else if (this == HomeImprovement) onHomeImprovement();
        else if (this == HomeInsurance) onHomeInsurance();
        else if (this == HomePhone) onHomePhone();
        else if (this == HomeServices) onHomeServices();
        else if (this == HomeSupplies) onHomeSupplies();
        else if (this == Hotel) onHotel();
        else if (this == Income) onIncome();
        else if (this == InterestIncome) onInterestIncome();
        else if (this == Internet) onInternet();
        else if (this == Investments) onInvestments();
        else if (this == Kids) onKids();
        else if (this == KidsActivities) onKidsActivities();
        else if (this == LateFee) onLateFee();
        else if (this == Laundry) onLaundry();
        else if (this == LawnGarden) onLawnGarden();
        else if (this == Legal) onLegal();
        else if (this == LifeInsurance) onLifeInsurance();
        else if (this == LoanInsurance) onLoanInsurance();
        else if (this == LoanPayment) onLoanPayment();
        else if (this == Loans) onLoans();
        else if (this == MobilePhone) onMobilePhone();
        else if (this == MortgageRent) onMortgageRent();
        else if (this == MoviesDvDs) onMoviesDvDs();
        else if (this == Music) onMusic();
        else if (this == NewspapersMagazines) onNewspapersMagazines();
        else if (this == OfficeSupplies) onOfficeSupplies();
        else if (this == Parking) onParking();
        else if (this == Paycheck) onPaycheck();
        else if (this == PersonalCare) onPersonalCare();
        else if (this == PetFoodSupplies) onPetFoodSupplies();
        else if (this == PetGrooming) onPetGrooming();
        else if (this == Pets) onPets();
        else if (this == Pharmacy) onPharmacy();
        else if (this == Printing) onPrinting();
        else if (this == PropertyTax) onPropertyTax();
        else if (this == PublicTransportation) onPublicTransportation();
        else if (this == Reimbursement) onReimbursement();
        else if (this == RentalCarTaxi) onRentalCarTaxi();
        else if (this == Restaurants) onRestaurants();
        else if (this == SalesTax) onSalesTax();
        else if (this == ServiceParts) onServiceParts();
        else if (this == ServiceFee) onServiceFee();
        else if (this == Shipping) onShipping();
        else if (this == Shopping) onShopping();
        else if (this == SpaMassage) onSpaMassage();
        else if (this == SportingGoods) onSportingGoods();
        else if (this == Sports) onSports();
        else if (this == StateTax) onStateTax();
        else if (this == StudentLoan) onStudentLoan();
        else if (this == Taxes) onTaxes();
        else if (this == Television) onTelevision();
        else if (this == Toys) onToys();
        else if (this == Transfer) onTransfer();
        else if (this == Travel) onTravel();
        else if (this == Tuition) onTuition();
        else if (this == Uncategorized) onUncategorized();
        else if (this == Utilities) onUtilities();
        else if (this == Vacation) onVacation();
        else if (this == Veterinary) onVeterinary();
        else otherwise(Value);
    }
}
