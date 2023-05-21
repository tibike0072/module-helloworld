/*
' Copyright (c) 2023 GigaChadsandthePrincess
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using System;
using System.Web.Caching;

//// en irtam ide kezdet
//using System.Data;
//using System.Text;
//using DotNetNuke.Entities.Modules;
//using DotNetNuke.Data;
//using System.Linq;
// en irtam ide vegzet

namespace GigaChads.Dnn.Dnn.GigaChads.HelloWorld.Models
{
    [TableName("HelloWorld_Items")]
    //setup the primary key for table
    [PrimaryKey("ItemId", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Items", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class Item
    {
        ///<summary>
        /// The ID of your object with the name of the ItemName
        ///</summary>
        public int ItemId { get; set; } = -1;
        ///<summary>
        /// A string with the name of the ItemName
        ///</summary>
        public string ItemName { get; set; }

        ///<summary>
        /// A string with the description of the object
        ///</summary>
        public string ItemDescription { get; set; }

        ///<summary>
        /// An integer with the user id of the assigned user for the object
        ///</summary>
        public int AssignedUserId { get; set; }

        ///<summary>
        /// The ModuleId of where the object was created and gets displayed
        ///</summary>
        public int ModuleId { get; set; }

        ///<summary>
        /// An integer for the user id of the user who created the object
        ///</summary>
        public int CreatedByUserId { get; set; } = -1;

        ///<summary>
        /// An integer for the user id of the user who last updated the object
        ///</summary>
        public int LastModifiedByUserId { get; set; } = -1;

        ///<summary>
        /// The date the object was created
        ///</summary>
        public DateTime CreatedOnDate { get; set; } = DateTime.UtcNow;

        ///<summary>
        /// The date the object was updated
        ///</summary>
        public DateTime LastModifiedOnDate { get; set; } = DateTime.UtcNow;
    }

    // En irtaam ide kezdet

    //public partial class HelloWorld : PortalModuleBase
    //{
    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        if (!IsPostBack)
    //        {
    //            // Retrieve the Category ID
    //            int categoryId = 123; // Replace with the actual Category ID

    //            // Retrieve the product data from the Hotcakes database
    //            DataTable products = GetProductsByCategory(categoryId);

    //            // Display only three products
    //            int displayLimit = 3;
    //            DataTable limitedProducts = products.AsEnumerable().Take(displayLimit).CopyToDataTable();

    //            // Generate HTML code to display the products
    //            StringBuilder htmlBuilder = new StringBuilder();
    //            foreach (DataRow row in limitedProducts.Rows)
    //            {
    //                int productId = Convert.ToInt32(row["ProductId"]);
    //                string productName = Convert.ToString(row["ProductName"]);
    //                string productImage = Convert.ToString(row["ProductImage"]);
    //                string productDescription = Convert.ToString(row["ProductDescription"]);

    //                htmlBuilder.AppendLine("<div class='product'>");
    //                htmlBuilder.AppendLine("<h3>" + productName + "</h3>");
    //                htmlBuilder.AppendLine("<img src='" + productImage + "' alt='" + productName + "' />");
    //                htmlBuilder.AppendLine("<p>" + productDescription + "</p>");
    //                htmlBuilder.AppendLine("</div>");
    //            }

    //            // Display the generated HTML code
    //            productContainer.InnerHtml = htmlBuilder.ToString();
    //        }
    //    }

    //    private DataTable GetProductsByCategory(int categoryId)
    //    {
    //        // Replace with your own database query or Hotcakes API calls to retrieve product data based on the category ID
    //        string connectionString = DotNetNuke.Common.Utilities.Config.GetConnectionString();
    //        string query = "SELECT * FROM Hotcakes_Products WHERE CategoryId = @CategoryId";

    //        using (IDataContext ctx = DataContext.Instance())
    //        {
    //            return ctx.ExecuteQuery<DataTable>(CommandType.Text, query, new object[] { categoryId });
    //        }
    //    }
    //}

    // En irtam ide vegzet

}
