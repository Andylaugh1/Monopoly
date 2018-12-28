using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class Street : Space
    {
        public string Name { get; set; }
        public StreetColour Colour { get; set; }
        public int Price { get; set; }
        public int HousePrice { get; set; }
        public int HotelPrice { get; set; }
        public int ReMortgageValue { get; set; }
        public int RentIfAlone { get; set; }
        public int RentIfSet { get; set; }
        public List<Property> Properties { get; set; }
        
        public Street() { }

        public Street(List<Player> PlayersCurrentlyOnSpace, string Name, StreetColour Colour, int Price, int HousePrice, int HotelPrice, int ReMortgageValue, int RentIfAlone, int RentIfSet, List<Property> Properties)
        {
            this.PlayersCurrentlyOnSpace = PlayersCurrentlyOnSpace;
            this.Name = Name;
            this.Colour = Colour;
            this.Price = Price;
            this.HousePrice = HousePrice;
            this.HotelPrice = HotelPrice;
            this.ReMortgageValue = ReMortgageValue;
            this.RentIfAlone = RentIfAlone;
            this.RentIfSet = RentIfSet;
            this.Properties = Properties;
        }

        public int CountHouses()
        {
            var NumberOfHouses = 0;

            foreach (Property property in this.Properties)
            {
                if (property.Type == PropertyType.House)
                {
                    NumberOfHouses += 1;
                }
            }
            return NumberOfHouses;
        }

        public int CountHotels()
        {
            var NumberOfHotels = 0;

            foreach (Property property in this.Properties)
            {
                if (property.Type == PropertyType.Hotel && this.Properties.Count == 1)
                {
                    NumberOfHotels += 1;
                }
                else if(property.Type == PropertyType.Hotel && this.Properties.Count != 1)
                {
                    throw new Exception();
                }
            }
            return NumberOfHotels;
        }
    }

    
}
