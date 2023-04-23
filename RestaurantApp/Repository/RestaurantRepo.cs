using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantApp.Repository
{
    public class RestaurantRepo
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);
        }

        public List<RestaurantInfo> GetAllRestaurants()
        {
            connection();
            List<RestaurantInfo> RestaurantList = new List<RestaurantInfo>();


            SqlCommand com = new SqlCommand("Select * from RestaurantInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind RestaurantInfo generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {

                RestaurantList.Add(

                    new RestaurantInfo
                    {

                        id = Convert.ToInt32(dr["Id"]),
                        name = Convert.ToString(dr["Name"]),
                        address = Convert.ToString(dr["address"]),
                        zipcode = Convert.ToString(dr["zipcode"]),
                        website = Convert.ToString(dr["website"]),
                        CuisineId = Convert.ToInt32(dr["cuisineid"]),
                        rating = Convert.ToString(dr["rating"]),
                        pricerange = Convert.ToString(dr["pricerange"])

                    }
                    );
            }

            return RestaurantList;
        }

        public bool AddRestaurantInfo(RestaurantInfo restaurant)
        {

            connection();

            var command = new SqlCommand(
                "INSERT INTO RestaurantInfo (id,name, address, zipcode, phone, website, CuisineId, rating, priceRange) " +
                "VALUES (@Id, @Name, @Address, @Zipcode, @Phone, @Website, @CuisineId, @Rating, @PriceRange)", con);

            command.Parameters.AddWithValue("@Id", restaurant.id);
            command.Parameters.AddWithValue("@Name", restaurant.name);
            command.Parameters.AddWithValue("@Address", restaurant.address);
            command.Parameters.AddWithValue("@Zipcode", restaurant.zipcode);
            command.Parameters.AddWithValue("@Phone", restaurant.phone);
            command.Parameters.AddWithValue("@Website", restaurant.website);
            command.Parameters.AddWithValue("@CuisineId", restaurant.CuisineId);
            command.Parameters.AddWithValue("@Rating", restaurant.rating);
            command.Parameters.AddWithValue("@PriceRange", restaurant.pricerange);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }

        }

        public bool AddRestaurantMenu(RestaurantMenu restaurantMenu)
        {
            connection();

            var command = new SqlCommand(
                "INSERT INTO RestaurantMenu (Id,MenuItem,Description,Price) " +
                "VALUES (@ID,@MenuItem,@Description,@Price)", con);

            command.Parameters.AddWithValue("@ID", restaurantMenu.Id);
            command.Parameters.AddWithValue("@MenuItem", restaurantMenu.MenuItem);
            command.Parameters.AddWithValue("@Description", restaurantMenu.Description);
            command.Parameters.AddWithValue("@Price", restaurantMenu.Price);

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        public bool AddMenuItemType(MenuItemType menuItemType)
        {
            connection();

            var command = new SqlCommand(
                "INSERT INTO MenuItemType (Id,Type,RestaurantId,Description,Price) " +
                "VALUES (@ID,@Type,@RestaurantId,@Description,@Price)", con);

            command.Parameters.AddWithValue("@ID", menuItemType.Id);
            command.Parameters.AddWithValue("@Type", menuItemType.Type);
            command.Parameters.AddWithValue("@RestaurantId", menuItemType.RestaurantId);
            command.Parameters.AddWithValue("@Description", menuItemType.Description);
            command.Parameters.AddWithValue("@Price", menuItemType.Price);

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }



        public bool AddCuisine(Cuisine cuisine)
        {
            connection();

            var command = new SqlCommand(
                "INSERT INTO Cuisine (id,name,nutritionInfo,texture) " +
                "VALUES (@ID,@Name,@NutritionInfo,@Texture)", con);

            command.Parameters.AddWithValue("@Id", cuisine.id);
            command.Parameters.AddWithValue("@Name", cuisine.name);
            command.Parameters.AddWithValue("@NutritionInfo", cuisine.nutritionInfo);
            command.Parameters.AddWithValue("@Texture", cuisine.texture);

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        public bool UpdateRestaurantInfo(RestaurantInfo restaurant)
        {

            connection();
            SqlCommand command = new SqlCommand("Update RestaurantInfo SET id = @Id ,name = @Name, address = @Address, zipcode = @Zipcode, phone = @Phone, website = @Website, CuisineId = @CuisineId, rating = @Rating, priceRange = @PriceRange where id = @Id", con);

            command.Parameters.AddWithValue("@Id", restaurant.id);
            command.Parameters.AddWithValue("@Name", restaurant.name);
            command.Parameters.AddWithValue("@Address", restaurant.address);
            command.Parameters.AddWithValue("@Zipcode", restaurant.zipcode);
            command.Parameters.AddWithValue("@Phone", restaurant.phone);
            command.Parameters.AddWithValue("@Website", restaurant.website);
            command.Parameters.AddWithValue("@CuisineId", restaurant.CuisineId);
            command.Parameters.AddWithValue("@Rating", restaurant.rating);
            command.Parameters.AddWithValue("@PriceRange", restaurant.pricerange);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRestaurantInfo(RestaurantInfo restaurant)
        {

            connection();
            SqlCommand com = new SqlCommand(" Delete from RestaurantInfo where id = @Id ", con);
            com.Parameters.AddWithValue("@Id", restaurant.id);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }
        }






    }
}