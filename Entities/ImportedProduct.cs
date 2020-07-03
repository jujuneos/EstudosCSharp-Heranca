namespace ExercicioPoli.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return base.Name
                + " $ "
                + TotalPrice()
                + " (Customs fee: $ "
                + CustomsFee
                + ")";
        }
    }
}