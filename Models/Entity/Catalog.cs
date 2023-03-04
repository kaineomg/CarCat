namespace CatalogCarDZ.Models.Entity
{
    public class Catalog
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CarCat> carCats { get; set; }





        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
