using SkyrimAlchemyApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyrimAlchemyApp
{
    public partial class MainForm : Form
    {
        Recipe recipe;
        string SearchStr { get; set; }

        public MainForm()
        {
            InitializeComponent();
            recipe = new Recipe();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IngLB.DataSource = recipe.WholeList;
            IngLB.DisplayMember = "Name";
        }

        private void SearchIngBtn_Click(object sender, EventArgs e)
        {
            SearchStr = SearchIngTB.Text;
            try
            {                
                IngLB.DataSource = null; //Apperently it wont update without it
                IngLB.DataSource = recipe.GetByName(SearchStr);
                IngLB.DisplayMember = "Name";
                InfoLbl.Text = " ";
            }
            catch(Exception ex)
            {
                InfoLbl.Text = ex.Message;
            }

        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            IngLB.DataSource = recipe.WholeList;
            IngLB.DisplayMember = "Name";
        }

        private void IngLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ing = (Ingredient)IngLB.SelectedItem;

            if (ing != null)
            {
                NameLbl.Text = ing.Name;
                Eff1Lbl.Text = ing.Effect1;
                Eff2Lbl.Text = ing.Effect2;
                Eff3Lbl.Text = ing.Effect3;
                Eff4Lbl.Text = ing.Effect4;
                WeightLbl.Text = ing.Weight.ToString();
                ValueLbl.Text = ing.Value.ToString();
            }
        }     

        private void SearchEffBtn_Click(object sender, EventArgs e)
        {
            SearchStr = SearchIngTB.Text;

            try
            {
                IngLB.DataSource = null;
                IngLB.DataSource = recipe.GetByEffect(SearchStr);
                IngLB.DisplayMember = "Name";
                InfoLbl.Text = " ";
            }
            catch(Exception ex)
            {
                InfoLbl.Text = ex.Message;
            }

        }
    }
}
