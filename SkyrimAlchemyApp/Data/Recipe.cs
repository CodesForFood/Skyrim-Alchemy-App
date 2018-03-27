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

        public List<Ingredient> GetByName(string name)
        {
            SpecIngs.Clear();
            foreach(var ing in WholeList)
            {
                if(ing.Name.ToLower().Contains(name.ToLower())) { SpecIngs.Add(ing); }
            }

            if(SpecIngs.Count > 0) { return SpecIngs; }
            else { throw new ArgumentException(); }
            
        }

        public List<Ingredient> GetByEffect(string name)
        {
            SpecIngs.Clear();
            name = name.ToLower();

            foreach(var ing in WholeList)
            {
                if(ing.Effect1.ToLower().Contains(name)) { SpecIngs.Add(ing); }
                else if(ing.Effect2.ToLower().Contains(name)) { SpecIngs.Add(ing); }
                else if(ing.Effect3.ToLower().Contains(name)) { SpecIngs.Add(ing); }
                else if(ing.Effect4.ToLower().Contains(name)) { SpecIngs.Add(ing); }
            }

            if(SpecIngs.Count > 0) { return SpecIngs; }
            else { throw new ArgumentException(); }
        }



    }
}
