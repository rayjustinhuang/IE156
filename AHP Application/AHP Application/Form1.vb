Public Class frmmain

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        If CheckForWrongInput() = False Then
            Exit Sub
        End If
        PopulateDGVPCM()
    End Sub

    Private Function CheckForWrongInput()
        If IsNumeric(txtncriteria.Text) = False Or IsNumeric(txtnalternatives.Text) = False Then
            MsgBox("Please enter a valid positive integer")
            Return False
        ElseIf txtncriteria.Text <= 0 Or txtnalternatives.Text <= 0 Then
            MsgBox("Please enter a valid positive integer greater than 0")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub PopulateDGVPCM()
        For i As Integer = 0 To txtncriteria.Text
            dgvpcm.Columns.Add(DGVNewColumn)
            dgvpcm.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvpcm.Rows.Add()
        Next
        For i As Integer = 1 To txtncriteria.Text
            dgvpcm.Rows(i).Cells(i).Value = 1
        Next
    End Sub

    Private Function DGVNewColumn()
        Dim blanktextcolumn As New DataGridViewTextBoxColumn
        Return blanktextcolumn
    End Function

    Private Sub dgvpcm_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpcm.CellValueChanged
        If e.RowIndex = 0 Or e.ColumnIndex = 0 Then
            If e.RowIndex = 0 And e.ColumnIndex > 0 Then
                dgvpcm.Rows(e.ColumnIndex).Cells(0).Value = dgvpcm.Rows(0).Cells(e.ColumnIndex).Value
            ElseIf e.ColumnIndex = 0 And e.RowIndex > 0 Then
                dgvpcm.Rows(0).Cells(e.RowIndex).Value = dgvpcm.Rows(e.RowIndex).Cells(0).Value
            End If
        ElseIf e.RowIndex > 0 And e.ColumnIndex > 0 Then
            If IsNumeric(dgvpcm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = False Then
                dgvpcm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                MsgBox("Please enter a numeric positive number")
                Exit Sub
            ElseIf dgvpcm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value < 0 Then
                dgvpcm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                MsgBox("Please enter a numeric positive number")
                Exit Sub
            End If
            dgvpcm.Rows(e.ColumnIndex).Cells(e.RowIndex).Value = 1 / dgvpcm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If
        dgvpcm.Rows(0).Cells(0).Value = ""
    End Sub

    Private Sub btnnormalize_Click(sender As Object, e As EventArgs) Handles btnnormalize.Click
        PopulateDGVNormalizedPCM()
        NormalizePCM()
    End Sub

    Private Sub PopulateDGVNormalizedPCM()
        For i As Integer = 0 To txtncriteria.Text + 1
            dgvnormalizedpcm.Columns.Add(DGVNewColumn)
            dgvnormalizedpcm.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvnormalizedpcm.Rows.Add()
        Next
        For i As Integer = 0 To txtncriteria.Text
            dgvnormalizedpcm.Rows(0).Cells(i).Value = dgvpcm.Rows(0).Cells(i).Value
        Next
        For i As Integer = 0 To txtncriteria.Text
            dgvnormalizedpcm.Rows(i).Cells(0).Value = dgvpcm.Rows(i).Cells(0).Value
        Next
        dgvnormalizedpcm.Rows(txtncriteria.Text + 1).Cells(0).Value = "Sum"
        Dim maxcol As Integer = txtncriteria.Text + 1
        dgvnormalizedpcm.Rows(0).Cells(maxcol).Value = "Average"
    End Sub

    Private Sub NormalizePCM()
        Dim currentsum As Double = 0
        Dim maxcolumn As Integer = txtncriteria.Text + 1
        For i As Integer = 1 To txtncriteria.Text
            For j As Integer = 1 To txtncriteria.Text
                currentsum = currentsum + dgvpcm.Rows(j).Cells(i).Value
            Next
            dgvnormalizedpcm.Rows(maxcolumn).Cells(i).Value = currentsum
            currentsum = 0
        Next
        For i As Integer = 1 To txtncriteria.Text
            For j As Integer = 1 To txtncriteria.Text
                dgvnormalizedpcm.Rows(i).Cells(j).Value = dgvpcm.Rows(i).Cells(j).Value / dgvnormalizedpcm.Rows(maxcolumn).Cells(j).Value
            Next
        Next
        currentsum = 0
        For i As Integer = 1 To txtncriteria.Text
            For j As Integer = 1 To txtncriteria.Text
                currentsum = currentsum + dgvnormalizedpcm.Rows(i).Cells(j).Value
            Next
            dgvnormalizedpcm.Rows(i).Cells(maxcolumn).Value = currentsum / txtncriteria.Text
            currentsum = 0
        Next
    End Sub

    Private Sub btninitialize_Click(sender As Object, e As EventArgs) Handles btninitialize.Click
        PopulateDGVFinalDec
        PopulateCriteriaandWeights
    End Sub

    Private Sub PopulateDGVFinalDec()
        For i As Integer = 0 To txtncriteria.Text + 1
            dgvfinaldec.Columns.Add(DGVNewColumn)
            dgvfinaldec.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        For i As Integer = 0 To txtnalternatives.Text + 1
            dgvfinaldec.Rows.Add()
        Next
    End Sub

    Private Sub PopulateCriteriaandWeights()
        Dim maxcolumn As Integer = txtncriteria.Text + 1
        For i As Integer = 1 To txtncriteria.Text
            dgvfinaldec.Rows(0).Cells(i).Value = dgvpcm.Rows(0).Cells(i).Value
        Next
        For i As Integer = 1 To txtncriteria.Text
            dgvfinaldec.Rows(1).Cells(i).Value = dgvnormalizedpcm.Rows(i).Cells(maxcolumn).Value
        Next
    End Sub

    Private Sub dgvfinaldec_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvfinaldec.CellValueChanged
        If e.RowIndex > 1 And e.ColumnIndex > 0 Then
            If IsNumeric(dgvfinaldec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = False Then
                MsgBox("Please enter a positive number")
                dgvfinaldec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                Exit Sub
            ElseIf dgvfinaldec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value < 0 Then
                MsgBox("Please enter a positive number")
                dgvfinaldec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btncalfinaldec_Click(sender As Object, e As EventArgs) Handles btncalfinaldec.Click
        Dim currentsum As Double = 0
        Dim maxcolumn As Integer = txtncriteria.Text + 1
        For i As Integer = 2 To txtnalternatives.Text + 1
            For j As Integer = 1 To txtncriteria.Text
                currentsum = currentsum + dgvfinaldec.Rows(i).Cells(j).Value * dgvfinaldec.Rows(1).Cells(j).Value
            Next
            dgvfinaldec.Rows(i).Cells(maxcolumn).Value() = currentsum
            currentsum = 0
        Next
    End Sub

End Class