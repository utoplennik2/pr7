namespace pr7
{
    public class Bicycle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public double wheelSize { get; set; }
        public string frameMaterial { get; set; }
        public double weight { get; set; }
        public double price { get; set; }
        public string color { get; set; }

        public Bicycle()
        {
        }

        public double yearInsuranceCost
        {
            get { return GetYearInsuranceCost(); }
        }

        private double GetYearInsuranceCost()
        {
            return price * 0.05;
        }

        public Bicycle(string brand, string model, string type, double wheelSize,
                        string frameMaterial, double weight, double price, string color)
        {
            this.brand = brand;
            this.model = model;
            this.type = type;
            this.wheelSize = wheelSize;
            this.frameMaterial = frameMaterial;
            this.weight = weight;
            this.price = price;
            this.color = color;
        }
    }
}