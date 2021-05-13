namespace VideoStore
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public List<Rental> Rentals {get; }
        private string Name { get; }

        public Customer(string name)
        {
            this.Name = name;
            this.Rentals = new List<Rental>();
        }

        public void AddRental(Rental rental){
            Rentals.Add(rental);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + Name + "\n";
            foreach (Rental each in Rentals)
            {
                double thisAmount = 0;

                //determine amounts for each line
                switch (each.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;
                if ((each.Movie.PriceCode == Movie.NEW_RELEASE) &&
                        each.DaysRented > 1) frequentRenterPoints++;

                result += "\t" + each.Movie.Title + "\t" +
                        thisAmount + "\n";
                totalAmount += thisAmount;

            }
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints +
                    " frequent renter points";
            return result;
        }

    }
}