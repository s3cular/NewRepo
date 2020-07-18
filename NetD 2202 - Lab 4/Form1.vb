Option Strict On

Public Class frmCarInventory

#Region "Variable Declaration"
    Dim car As carClass
    Dim cars As New List(Of carClass)
    Dim updateData As Boolean = False
    Dim currentlySelectedIndex As Integer = -1
    Dim isCarSelected As Boolean = False
#End Region

#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        lvCarlist.SelectedItems.Clear()
        txtModel.Text = String.Empty
        lblOutput.Text = String.Empty
        txtPrice.Text = String.Empty
        cbMake.SelectedIndex = -1
        cbYear.SelectedIndex = -1
        ckNew.Checked = False
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If ValidateInputs() = True Then
            lblOutput.Text = "The car details is entered."

            If Not isCarSelected Then
                car = New carClass(cbMake.Text, txtModel.Text, CInt(cbYear.Text), Convert.ToDecimal(txtPrice.Text), ckNew.Checked)
                cars.Add(car)
            ElseIf car.IdentificationNumber.ToString.Trim.Length > 0 Then
                car.Make = cbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(cbYear.Text)
                car.Price = Convert.ToDecimal(txtPrice.Text)
                car.NewStatus = ckNew.Checked

            End If
            SetDefault()
        End If
    End Sub

    Private Sub ListSelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCarlist.SelectedIndexChanged
        If lvCarlist.SelectedIndices.Count = 1 Then
            car = cars(lvCarlist.SelectedIndices(0))
            isCarSelected = True
            cbMake.Text = car.Make
            txtModel.Text = car.Model
            cbYear.Text = car.Year.ToString
            txtPrice.Text = car.Price.ToString
            ckNew.Checked = car.NewStatus
            lblOutput.Text = car.GetCarData()
        End If
        isCarSelected = False
    End Sub

    Private Sub lvCarlist_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvCarlist.ItemCheck
        If Not updateData Then
            e.NewValue = e.CurrentValue
        End If
    End Sub
#End Region

#Region "Sub and Function"

    Private Sub SetDefault()
        cbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        ckNew.Checked = False
        lblOutput.Text = String.Empty
        PL()
        isCarSelected = False
        txtModel.Focus()
    End Sub
    Private Function ValidateInputs() As Boolean

        Dim errorM As String = String.Empty
        Dim carValue As Decimal = 0.00D
        Dim returnV As Boolean = True
        If cbMake.SelectedIndex = -1 Then
            errorM += "Please select any value from the drop down list" & Environment.NewLine
            returnV = False
        End If

        If txtModel.Text.Trim.Length = 0 Then
            errorM += "Please enter model name." & Environment.NewLine
            returnV = False
        End If

        If cbYear.SelectedIndex = -1 Then
            errorM += "Please select any value from the drop down list" & Environment.NewLine
            returnV = False
        End If

        If txtPrice.Text.Trim.Length = 0 Then
            errorM += "Please enter price of car." & Environment.NewLine
            returnV = False
        ElseIf Not (Decimal.TryParse(txtPrice.Text, carValue) And carValue > 0) Then
            errorM = "Entered price value must be numeric and positive number." & Environment.NewLine
            returnV = False
        End If

        If returnV = False Then
            lblOutput.Text = "Error" & Environment.NewLine & errorM
        End If

        Return returnV
    End Function

    Sub PL()
        lvCarlist.Items.Clear()
        For index As Integer = 0 To cars.Count - 1
            Dim cI As New ListViewItem()
            cI.SubItems.Add(cars(index).IdentificationNumber.ToString)
            cI.SubItems.Add(cars(index).Make)
            cI.SubItems.Add(cars(index).Model)
            cI.SubItems.Add(cars(index).Year.ToString)
            cI.SubItems.Add(cars(index).Price.ToString)
            cI.Checked = cars(index).NewStatus
        Next
    End Sub
#End Region

End Class
