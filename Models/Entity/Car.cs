namespace CatalogCarDZ.Models.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Discription { get; set; }
        public ICollection<CarCat> carCats { get; set; }



        public Car(string brand, string model, string color, string discription)
        {

            Brand = brand;
            Model = model;
            Color = color;
            Discription = discription;
        }

        public override string ToString()
        {
            return $"{Id} - {Brand} - {Model} - {Color} - {Discription}";
        }
    }
}
