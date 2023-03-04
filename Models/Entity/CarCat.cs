namespace CatalogCarDZ.Models.Entity
{
    public class CarCat
    {

        public int Id { get; set; } 
        public int CarId { get; set; }
        public int CatalogId { get; set; }
        public Car Car { get; set; }
        public Catalog Catalog { get; set; }
        
    }
}
