using Class8_CRUD.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Class8_CRUD.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<User> users = new List<User>();

            string connectionString = "Data Source=DESKTOP-VQDPLPC;Initial Catalog=crud;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM users";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        id = (int)reader["id"],
                        username = reader["username"].ToString(),
                        email = reader["email"].ToString()
                    });
                }
            }

            return View(users); // 🔥 IMPORTANT
        }

        // ✅ GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // ✅ POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                string connectionString = "Data Source=DESKTOP-VQDPLPC;Initial Catalog=crud;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO users (username, email) VALUES (@username, @email)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@email", user.email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}