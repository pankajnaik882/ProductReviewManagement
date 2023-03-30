using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        /// <summary>
        /// UC1- Create variable for List of ProductReview class in Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() {ProductId=3, UserId=1, IsLike=true, Review ="Good", Rating=80 },
                new ProductReview() {ProductId=1, UserId=2, IsLike=true, Review="Nice", Rating=20},
                new ProductReview() {ProductId=4, UserId=3, IsLike=true, Review ="Nice", Rating=50 },
                new ProductReview() {ProductId=2, UserId=4, IsLike=false, Review="Good", Rating=90},
                new ProductReview() {ProductId=5, UserId=5, IsLike=true, Review ="Nice", Rating=20 },
                new ProductReview() {ProductId=1, UserId=6, IsLike=false, Review="Bad", Rating=30},
                new ProductReview() {ProductId=5, UserId=7, IsLike=true, Review ="Good", Rating=80 },
                new ProductReview() {ProductId=6, UserId=8, IsLike=false, Review="Bad", Rating=10},
                new ProductReview() {ProductId=7, UserId=9, IsLike=true, Review ="Nice", Rating=25 },
                new ProductReview() {ProductId=3, UserId=10, IsLike=true, Review="Bad", Rating=15},
                new ProductReview() {ProductId=5, UserId=10, IsLike=true, Review="Good", Rating=70},
                new ProductReview() {ProductId=8, UserId=10, IsLike=false, Review="Nice", Rating=40},
                new ProductReview() {ProductId=4, UserId=10, IsLike=true, Review="nice", Rating=35},
                new ProductReview() {ProductId=1, UserId=10, IsLike=true, Review="Good", Rating=60},
                new ProductReview() {ProductId=2, UserId=10, IsLike=true, Review="Bad", Rating=80},
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Select options");
                Console.WriteLine("1.Display all data\n" +
                    "2.RetreiveTop3Records\n" +
                    "3.FetchRecordsBasedOnRatingAndProductId\n" +
                    "15.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("All Records fro the list:-\n-----------------------------------");
                        DisplayProductReviews(list);
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Top three Records are:-\n-----------------------------------");
                        ProductReviewManagement.RetreiveTop3Records(list);
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Feaching Records based on Rating and Product Id are:-\n-------------------------------------------------------");
                        ProductReviewManagement.FetchRecordsBasedOnRatingAndProductId(list);
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 15:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("select only valid options");
                        Console.Write("\nPress any key to continue...... ");
                        break;
                }
                Console.ReadLine();
            }
        }
        public static void DisplayProductReviews(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine(productReview);
            }
        }
    }
}