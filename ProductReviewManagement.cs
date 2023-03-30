using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
        /// <summary>
        /// UC2- Retrieve top 3 records from the list who’s rating is high using LINQ 
        /// </summary>
        /// <param name="list"></param>
        public static void RetreiveTop3Records(List<ProductReview> list)
        {
            Console.WriteLine("\nUsing method Syntax");
            List<ProductReview> sortedInDesending = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReviews(sortedInDesending);
        }

        /// <summary>
        /// UC3- Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void FetchRecordsBasedOnRatingAndProductId(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Rating > 3 && p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9).ToList();
            Program.DisplayProductReviews(result);
        }
    }
}
