Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.UserSkins.OfficeSkins

Public Class MasterDetails


    Private Sub MasterDetails_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim dataset As New DataSet()

        Dim dt_supplier As DataTable = DataSource(String.Format("SELECT RIS_No,supplier FROM ris_master"))

        Dim supplier As DataTable = dt_supplier.Copy
        supplier.TableName = "SUPPLIER"
        dataset.Tables.Add(supplier)

        Dim dt_po As DataTable = DataSource(String.Format("SELECT RIS_No,date_received,po_no,po_date FROM ris_master"))

        Dim po As DataTable = dt_po.Copy
        po.TableName = "P.O DETAILS"
        dataset.Tables.Add(po)

        Dim dt_item As DataTable = DataSource(String.Format("SELECT RIS_Det_No,RIS_Master_No 'RIS_No',inv_master_Name,qty_received,price,qty_remaining,expiry_date FROM ris_details"))

        Dim item As DataTable = dt_item.Copy
        item.TableName = "ITEM DETAILS"
        dataset.Tables.Add(item)


        dataset.Relations.Add("P.O DETAILS", supplier.Columns("RIS_No"), po.Columns("RIS_No"))
        dataset.Relations("P.O DETAILS").Nested = True

        dataset.Relations.Add("ITEM DETAILS", po.Columns("RIS_No"), item.Columns("RIS_No"))
        dataset.Relations("ITEM DETAILS").Nested = True

        'dataset.Relations.Add("SUPPLIER", supplier.Columns("RIS_No"), po.Columns("RIS_No"))
        'dataset.Relations("SUPPLIER").Nested = True

        'dataset.Relations.Add("P.O DETAILS", po.Columns("RIS_No"), item.Columns("RIS_No"))
        'dataset.Relations("P.O DETAILS").Nested = True

        'dataset.Relations.Add("ITEM DETAILS", item.Columns("RIS_No"), Nothing)
        'dataset.Relations("ITEM DETAILS").Nested = True


        Dim myGridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
        myGridLevelNode1.LevelTemplate = Me.GridView2
        myGridLevelNode1.RelationName = "P.O DETAILS"

        Dim myGridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
        myGridLevelNode2.LevelTemplate = Me.CardView1
        myGridLevelNode2.RelationName = "ITEM DETAILS"

        GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {myGridLevelNode1, myGridLevelNode2})
        GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2, Me.CardView1})

        'Me.GridView1.GridControl = Me.GridControl1
        'Me.GridView1.Name = "GridView1"
        ''     Me.GridView1.OptionsBehavior.Editable = False
        ''        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        ''
        ''GridView2
        ''
        'Me.GridView2.GridControl = Me.GridControl1
        'Me.GridView2.Name = "GridView2"
        ''      Me.GridView2.OptionsDetail.ShowDetailTabs = False
        ''
        ''CardView1
        ''
        'Me.CardView1.GridControl = Me.GridControl1
        'Me.CardView1.Name = "CardView1"


        GridControl1.DataSource = dataset

        Dim view As ColumnView = CType(GridControl1.FocusedView, ColumnView)
        Dim editingValue As String = Nothing
        If view IsNot Nothing And view.IsEditing Then
            editingValue = view.EditingValue.ToString()
        End If


        Dim rowHandle As Integer = 0
        'Create the first detail by expanding a master row
        Dim gView As GridView = CType(GridControl1.MainView, GridView)
        gView.SetMasterRowExpanded(rowHandle, True)




    End Sub
End Class