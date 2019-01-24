using MyBeerApp.Domain.Shared;

namespace MyBeerApp.Domain.Beers
{
    public class Beer : BaseEntity
    {
        public string Name { get; set; }

        public bool IsFavorite { get; set; }
    }
}