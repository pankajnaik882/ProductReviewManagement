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
            Console.WriteLine("\n\nUsing Query Syntax");
            List<ProductReview> result = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            Program.DisplayProductReviews(result);
        }
    }
}
