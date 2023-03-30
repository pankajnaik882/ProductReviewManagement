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

        /// <summary>
        /// UC4- Retrieve count of review present for each productID and use groupBy LINQ Operator.
        /// </summary>
        /// <param name="list"></param>
        public static void FindingEachCountOfProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.Id + " ->  " + "Count: " + item.count);
            }
        }

        /// <summary>
        /// UC5- Retrieve only productId and review from the list for all records.
        /// </summary>
        /// <param name="list"></param>
        public static void DisplayProductIdAndReview(List<ProductReview> list)
        {
            var result = list.Select(p => new { Id = p.ProductId, Review = p.Review }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.Id + " ->  " + "Review: " + item.Review);
            }
        }
    }
}
