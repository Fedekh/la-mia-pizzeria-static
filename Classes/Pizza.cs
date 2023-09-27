namespace la_mia_pizzeria_static.Classes
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo {  get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, string photo, double price)
        {
            Name = name;
            Description = description;
            Photo = photo;
            Price = price;
        }

        public string GetPrice(double price)
        {
            return this.Price.ToString("0.00");
        }

        public string GetDescription(string description)
        {
            return this.Description;
        }
    }
}
