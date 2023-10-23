Public Class fmaPOS_RemoveItemForm

    Public Event ITEM_DELETED()

    'Dim dtgvOrderList As System.Windows.Forms.DataGridView = New System.Windows.Forms.DataGridView


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal tdvgrid As System.Windows.Forms.DataGridView)
        InitializeComponent()

        Me.dtgvOrderList.Rows.Clear()


        Dim rowcount As Integer = tdvgrid.Rows.Count

        For jRows As Integer = 0 To (rowcount - 1)
            Dim n As Integer = dtgvOrderList.Rows.Add()
            dtgvOrderList.Rows.Item(n).Cells(0).Value = tdvgrid.Item(0, jRows).Value.ToString
            dtgvOrderList.Rows.Item(n).Cells(1).Value = tdvgrid.Item(1, jRows).Value.ToString
            dtgvOrderList.Rows.Item(n).Cells(2).Value = tdvgrid.Item(2, jRows).Value.ToString
            dtgvOrderList.Rows.Item(n).Cells(3).Value = tdvgrid.Item(3, jRows).Value.ToString
            dtgvOrderList.Rows.Item(n).Cells(4).Value = tdvgrid.Item(4, jRows).Value.ToString
            dtgvOrderList.Rows.Item(n).Cells(5).Value = tdvgrid.Item(5, jRows).Value.ToString

        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'If MessageBox.Show("Are you sure you want to REMOVE this ITEM?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        dtgvOrderList.Rows.Remove(dtgvOrderList.CurrentRow)
        RaiseEvent ITEM_DELETED()
        'End If

        Me.Close()
    End Sub

    Private Sub dtgvOrderList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgvOrderList.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                dtgvOrderList.Rows.Remove(dtgvOrderList.CurrentRow)
                RaiseEvent ITEM_DELETED()
            Catch ex As Exception
            End Try
            
        End If
    End Sub

End Class