using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using DevExpress.XtraGrid.Views.Grid;

namespace Entities {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            NorthwindEntities northwind = new NorthwindEntities();
            ObjectQuery<Customers> customersQuery = northwind.Customers.Include("Orders");
            gridControl1.DataSource = new BindingSource(customersQuery, "");

            gridView1.OptionsSelection.MultiSelect = true;
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            GridView view = sender as GridView;
            Customers c = (Customers)view.GetRow(e.RowHandle);
            e.IsEmpty = c.Orders.Count == 0;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Orders";
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            GridView view = sender as GridView;
            Customers c = (Customers)view.GetRow(e.RowHandle);
            e.ChildList = c.Orders.ToList();
        }
    }
}
