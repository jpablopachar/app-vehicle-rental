namespace Domain.Shared
{
    public record Currency(decimal Amount, CurrencyType CurrencyType)
    {
        public static Currency operator +(Currency first, Currency second)
        {
            if (first.CurrencyType != second.CurrencyType)
            {
                throw new ApplicationException("El tipo de moneda debe ser el mismo");
            }

            return new Currency(first.Amount + second.Amount, first.CurrencyType);
        }

        public static Currency Zero() => new(0, CurrencyType.None);

        public static Currency Zero(CurrencyType currencyType) => new(0, currencyType);

        public bool IsZero() => this == Zero(CurrencyType);
    }
}