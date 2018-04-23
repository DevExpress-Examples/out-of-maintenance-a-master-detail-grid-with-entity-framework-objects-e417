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
            Customers c = (Customers)gridView1.GetRow(e.RowHandle);
            e.IsEmpty = c.Orders.Count == 0;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Orders";
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            Customers c = (Customers)gridView1.GetRow(e.RowHandle);
            e.ChildList = new BindingSource(c, "Orders");
        }
    }
}
