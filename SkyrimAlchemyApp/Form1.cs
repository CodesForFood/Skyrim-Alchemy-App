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
                IngLB.SelectedItem = recipe.GetByName(SearchStr);
            }
            catch(Exception ex)
            {
                InfoLbl.Text = ex.Message;
            }

        }
    }
}
