Imports MySql.Data.MySqlClient

Public Class fmaInventoryMasterSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txta_code
        clsGroup.AttachControl = Me.txta_code

        clsGroup.AttachControl = Me.txtconsignee
        clsGroup.AttachControl = Me.txta_name
        clsGroup.AttachControl = Me.txtmanufacturer
        clsGroup.AttachControl = Me.txtgeneric_name
        clsGroup.AttachControl = Me.txtbrand_name
        clsGroup.AttachControl = Me.txtindication
        clsGroup.AttachControl = Me.txtdrug_interaction
        clsGroup.AttachControl = Me.txtmethod
        clsGroup.AttachControl = Me.txtmethod_id
        clsGroup.AttachControl = Me.txtuom
        clsGroup.AttachControl = Me.txtitem_reordercount
        clsGroup.AttachControl = Me.txtselling_price


        clsGroup.AttachControl = Me.txtstorage_requirement
        clsGroup.AttachControl = Me.txtis_deleted




        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......

        Dim MeData As New DataTable
        Dim SQL As String = ""

        'SQL = "SELECT SysPK_Item,Item_Code, Item_Display FROM product_item "
        'SQL += " Where SysPK_Item<>0 "
        'SQL += " AND Item_Code NOT IN (SELECT a_code FROM inventory_master)"
        'SQL += " ORDER BY Item_Display ASC "

        'MeData = clsDBConn.ExecQuery(SQL)
        'Me.txta_name.DataSource = MeData
        'Me.txta_name.DisplayMember = "Item_Display"
        'Me.txta_name.ValueMember = "SysPK_Item"
        'Me.txta_name.SelectedIndex = -1
        'Me.txta_name.Text = ""

        MeData = Nothing
        SQL = "SELECT a_name FROM units Where SysPK<>0 ORDER BY a_name ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtuom.DataSource = MeData
        Me.txtuom.DisplayMember = "a_name"
        Me.txtuom.ValueMember = "a_name"
        Me.txtuom.Text = ""
        Me.txtuom.SelectedIndex = -1


        SQL = "SELECT SysPK_Item,Item_Display FROM medtype Where SysPK_Item<>0 ORDER BY Item_Display ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtmethod.DataSource = MeData
        Me.txtmethod.DisplayMember = "Item_Display"
        Me.txtmethod.ValueMember = "SysPK_Item"
        Me.txtmethod.Text = ""
        Me.txtmethod.SelectedIndex = -1


        SQL = "SELECT SysPK, a_name FROM supplier ORDER BY a_name "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtSupplier.DataSource = MeData
        Me.txtSupplier.DisplayMember = "a_name"
        Me.txtSupplier.ValueMember = "SysPK"
        Me.txtSupplier.Text = ""
        Me.txtSupplier.SelectedIndex = -1


        'SQL = "SELECT SysPK, a_name FROM pharmaceuticals ORDER BY a_name "
        'MeData = clsDBConn.ExecQuery(SQL)
        'Me.txtconsignee.DataSource = MeData
        'Me.txtconsignee.DisplayMember = "a_name"
        'Me.txtconsignee.ValueMember = "SysPK"
        'Me.txtconsignee.Text = ""
        'Me.txtconsignee.SelectedIndex = -1

        If Me.Tag = 1 Then
            Me.btnAdd.Visible = True
        End If

    End Sub

    Private Sub DetachClasses()
        clsGroup = Nothing
    End Sub
#End Region

    Private Sub fmaEmployeeSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DetachClasses()
        RaiseEvent SETUP_CLOSED()
    End Sub

    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If
        ''
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AfterDelete() Handles clsGroup.AfterDelete
        RaiseEvent DB_MODIFIED()

    End Sub

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        RaiseEvent DB_MODIFIED()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.Close()
        End If


        If Me.btnAdd.Visible = False Then
            Me.btnAdd.Visible = True
        End If
    End Sub

    Private Sub txtinv_qty_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Application.DoEvents()

    End Sub



    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        If Me.txta_code.Text = "" Then
            MsgBox("Please Add Product in Product Setup.", MsgBoxStyle.Critical)
            Me.AttachClasses()

            If Me.OPERATION = "ADD" Then
                Me.btnAdd.PerformClick()
            ElseIf Me.OPERATION = "EDIT" Then
                Me.btnModify.PerformClick()
            End If
        End If

        If txtmanufacturer.Text = "" Then
            MsgBox("Manufacturer Cannot be blank.", MsgBoxStyle.Critical)
            Me.DetachClasses()
            Me.AttachClasses()

            If Me.OPERATION = "ADD" Then
                Me.btnAdd.PerformClick()
            ElseIf Me.OPERATION = "EDIT" Then
                Me.btnModify.PerformClick()
            End If
        End If

        If txtis_deleted.SelectedIndex = 0 Then
            txtis_deleted.Text = 0
        ElseIf txtis_deleted.SelectedIndex = 1 Then
            txtis_deleted.Text = 1
        Else
            txtis_deleted.Text = 0
        End If


    End Sub

    Private Sub txtmedtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmethod.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtmethod.SelectedItem, DataRowView)
            Me.txtmethod_id.Text = drv.Item("SysPK_Item").ToString
        Catch ex As Exception
            Me.txtmethod_id.Text = ""
        End Try
    End Sub

    Private Sub btnSuppPriceSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppPriceSave.Click
        If txtdiSuppPrice.Value <= 0 Then
            MsgBox("Item Price must not be zero or negative.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim SQLIN As String = "INSERT INTO invsupplier_pricing(Item_SysPk,Supplier_SysPk,Item_Description,price)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}', '{1}','{2}',", Me.txtSysPK.Text, Me.txtSupplierCode.Text, Me.txta_name.Text)
        SQLIN += String.Format("'{0}')", txtdiSuppPrice.Value)

        If clsDBConn.Execute(SQLIN) Then
            MsgBox("SUPPLIER'S ITEM PRICING HAS BEEN ADDED.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub txtSupplierCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierCode.TextChanged
        If txtSupplierCode.Text.Length > 0 And txtSysPK.Text.Length > 0 Then
            btnSuppPriceSave.Enabled = True
        Else
            btnSuppPriceSave.Enabled = False
        End If
    End Sub

    Private Sub txtSysPK_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK.TextChanged
        If txtSysPK.Text.Length > 0 Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub txtSupplier_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplier.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplier.SelectedItem, DataRowView)
            Me.txtSupplierCode.Text = drv.Item("SysPK").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
    End Sub

    Private Sub displayItemStatus()
        Dim SQLEX As String = "SELECT  ris_details.location"
        SQLEX += " , SUM(ris_details.qty_received) 'Quantity'"
        SQLEX += " FROM inventory_master"
        SQLEX += " INNER JOIN ris_details "
        SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQLEX += " INNER JOIN ris_master "
        SQLEX += " ON (ris_details.RIS_Master_No = ris_master.RIS_No)"
        SQLEX += " WHERE a_code='" & txta_code.Text & "'"
        SQLEX += " GROUP BY location"
        SQLEX += " ORDER BY location"


        tdbViewerStatus.DataSource = Nothing
        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewerStatus.DataSource = MeData
        Me.tdbViewerStatus.Rebind(True)

        Try
            With tdbViewerStatus.Splits(0)


                .DisplayColumns("location").DataColumn.Caption = "LOCATION"
                .DisplayColumns("location").Width = 300
                .DisplayColumns("location").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("location").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("Quantity").DataColumn.Caption = "QUANTITY"
                .DisplayColumns("Quantity").Width = 150
                .DisplayColumns("Quantity").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Quantity").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            End With
        Catch ex As Exception

        End Try
    End Sub



    Private ReadOnly borderColor As Color = Color.Black
    Private Sub paintGrpBox(sender As Object, e As PaintEventArgs)

        Dim grpBox As GroupBox = DirectCast(sender, GroupBox)

        Dim tSize As Size = TextRenderer.MeasureText(grpBox.Text, grpBox.Font)
        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = (borderRect.Y _
                    + (tSize.Height / 2))
        borderRect.Height = (borderRect.Height _
                    - (tSize.Height / 2))
        ControlPaint.DrawBorder(e.Graphics, borderRect, borderColor, ButtonBorderStyle.Solid)
        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        e.Graphics.FillRectangle(New SolidBrush(grpBox.BackColor), textRect)
        e.Graphics.DrawString(grpBox.Text, grpBox.Font, New SolidBrush(grpBox.ForeColor), textRect)

    End Sub

    Private Sub txtbrand_name_TextChanged(sender As Object, e As EventArgs) Handles txtbrand_name.TextChanged
  '      paintGrpBox(sender, e)
    End Sub

    Private Sub GroupBox5_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox5.Paint
        paintGrpBox(sender, e)
    End Sub

    Private Sub GroupBox4_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox4.Paint
        paintGrpBox(sender, e)
    End Sub

    Private Sub GroupBox6_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox6.Paint
        paintGrpBox(sender, e)
    End Sub

    Private Sub GroupBox3_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox3.Paint
        paintGrpBox(sender, e)
    End Sub

    Private Sub btnEditor_Click(sender As Object, e As EventArgs) Handles btnEditor.Click

        Dim item_code = txta_code.Text
        Dim item_name = txta_name.Text
        Dim uom = txtuom.Text
        Dim brand_name = txtbrand_name.Text
        Dim manufacturer = txtmanufacturer.Text
        Dim indication = txtindication.Text
        Dim interaction = txtdrug_interaction.Text

        Dim frm As New fmaItemViewDiscription
        frm.Tag = 1
        frm.txtcode.Text = item_code
        frm.txtname.Text = item_name
        frm.txtuom.Text = uom
        frm.txtbrand_name.Text = brand_name
        frm.txtmanufacturer.Text = manufacturer
        frm.indication = indication
        frm.interaction = interaction
        frm.BringToFront()
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then

            txtindication.Text = apply_indication
            txtdrug_interaction.Text = apply_interaction

        End If



    End Sub

    Private Sub txta_code_TextChanged(sender As Object, e As EventArgs) Handles txta_code.TextChanged
        If Me.OPERATION = "EDIT" Then
            If txta_code.Text.Length > 0 Then
                displayItemStatus()
            End If
        End If
    End Sub

    Private Sub txta_code_KeyUp(sender As Object, e As KeyEventArgs) Handles txta_code.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.OPERATION = "ADD" Then
                Dim SQLEX As String = "SELECT a_code, a_name FROM inventory_master"
                SQLEX += " Where a_code='" & Me.txta_code.Text & "'"

                Dim MeData As DataTable
                Dim MSGTEXT = "ITEM WITH CODE : "
                MeData = clsDBConn.ExecQuery(SQLEX)
                If MeData.Rows.Count > 0 Then
                    Try
                        MSGTEXT += MeData.Rows(0).Item("a_code").ToString
                        MSGTEXT += vbNewLine & "DESCRIPTION : " & MeData.Rows(0).Item("a_name").ToString

                        MSGTEXT += vbNewLine & "ALREADY EXISTS."

                        MsgBox(MSGTEXT, MsgBoxStyle.Information)
                        txta_name.Text = MeData.Rows(0).Item("a_name").ToString
                    Catch ex As Exception

                    End Try
                Else
                    Me.txta_name.Focus()
                End If

            End If

        End If
    End Sub
End Class