Option Strict On
Public Class frmAverageUnits
    'Constants
    Private Const MIN_VALUE As Integer = 0
    Private Const MAX_VALUE As Integer = 5000
    Private Const MAX_DAYS As Integer = 7

    'Variables
    Dim currentDay As Integer = 1
    Dim runningTotal As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        currentDay = 1
        runningTotal = 0

        txtUnits.Text = ""
        txtEmp1.Text = ""
        txtEmp2.Text = ""
        txtEmp3.Text = ""

        lblEmployee1.Text = ""
        lblEmployee2.Text = ""
        lblEmployee3.Text = ""

        lblResult.Text = ""

        btnEnter.Enabled = True
    End Sub



End Class
