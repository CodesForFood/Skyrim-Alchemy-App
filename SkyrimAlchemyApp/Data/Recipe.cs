using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SkyrimAlchemyApp.Data
{
    public class Recipe
    {
        string CntString { get { return ConfigurationManager.ConnectionStrings["IngDB"].ConnectionString; } }

        public List<Ingredient> WholeList;
        public List<Ingredient> SpecIngs;

        public Recipe()
        {
            WholeList = new List<Ingredient>();
            SpecIngs = new List<Ingredient>();

            FillWholeList();
        }

        private void FillWholeList()
        {
            string cmd = "SELECT * FROM Ingredients";
            using (IDbConnection connect = new SqlConnection(CntString))
            {
                var result = connect.Query<Ingredient>(cmd);
                WholeList = result.ToList();
            }
        }

        public Ingredient GetByName(string name)
        {   
            foreach(var ing in WholeList)
            {
                if(ing.Name.ToLower().Contains(name.ToLower())) { return ing; }
            }
            throw new ArgumentNullException();
        }


    }
}
