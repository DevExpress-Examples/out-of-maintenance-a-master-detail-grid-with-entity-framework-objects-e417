namespace Entities {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Orders";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(878, 499);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddress,
            this.colCity,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colCountry,
            this.colCustomerID,
            this.colFax,
            this.colPhone,
            this.colPostalCode,
            this.colRegion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.gridView1.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridView1.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridView1.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 0;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 1;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "CompanyName";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            // 
            // colContactName
            // 
            this.colContactName.Caption = "ContactName";
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 3;
            // 
            // colContactTitle
            // 
            this.colContactTitle.Caption = "ContactTitle";
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.Visible = true;
            this.colContactTitle.VisibleIndex = 4;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 8;
            // 
            // colPostalCode
            // 
            this.colPostalCode.Caption = "PostalCode";
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 9;
            // 
            // colRegion
            // 
            this.colRegion.Caption = "Region";
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 499);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}

