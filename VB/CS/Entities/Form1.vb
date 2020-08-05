Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports DevExpress.XtraGrid.Views.Grid

Namespace Entities
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Dim northwind As New NorthwindEntities()
			Dim customersQuery As ObjectQuery(Of Customers) = northwind.Customers.Include("Orders")
			gridControl1.DataSource = New BindingSource(customersQuery, "")

			gridView1.OptionsSelection.MultiSelect = True
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			Dim view As GridView = TryCast(sender, GridView)
			Dim c As Customers = CType(view.GetRow(e.RowHandle), Customers)
			e.IsEmpty = c.Orders.Count = 0
		End Sub

		Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gridView1.MasterRowGetRelationCount
			e.RelationCount = 1
		End Sub

		Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles gridView1.MasterRowGetRelationName
			e.RelationName = "Orders"
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim view As GridView = TryCast(sender, GridView)
			Dim c As Customers = CType(view.GetRow(e.RowHandle), Customers)
			e.ChildList = c.Orders.ToList()
		End Sub
	End Class
End Namespace
