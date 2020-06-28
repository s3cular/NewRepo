Option Strict On

'   Author: Smit Mangroliya
'   File: Average Units Shipped By Employee
'   Date: 27 June, 2020
'   Description: This form will calculate average units shipped by 3 employee of
'                a company and give average units shipped per day by company.

Public Class frmAverageUnits
    'Constants
    Private Const MIN_VALUE As Integer = 0
    Private Const MAX_VALUE As Integer = 5000
    Private Const MAX_DAYS = 7
    Private Const MAX_EMP As Integer = 3

    'Variables
    Dim currentDay As Integer = 1
    Dim runningTotal As Double = 0.0
    Private rowNum As Integer = 0
    Private colNum As Integer = 0
    Private empNum As Integer = 0
    Private daysArray(MAX_EMP - 1, MAX_DAYS - 1) As Integer
    Dim total As Double = 0.0
    Dim average1 As Double = 0.0
    Dim average2 As Double = 0.0
    Dim average3 As Double = 0.0

    ''' <summary>
    ''' Event handler for exit button which handles click event on exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' This sub procedure will reset form to its initial state.
    ''' </summary>
    Sub resetFrm()
        currentDay = 1
        runningTotal = 0
        BoldFont(lblEmployee1, True)
        BoldFont(lblEmployee2, False)
        BoldFont(lblEmployee3, False)
        txtUnits.Enabled = True
        btnEnter.Enabled = True
        CReset(rowNum, colNum)
        Array.Clear(daysArray, MAX_EMP - 1, MAX_DAYS - 1)
        txtUnits.Text = ""
        txtEmp1.Text = ""
        txtEmp2.Text = ""
        txtEmp3.Text = ""
        txtUnits.Focus()
        txtUnits.Select()
        lblDays.Text = "Day 1"
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
        lblResult.Text = ""
    End Sub

    ''' <summary>
    ''' Event handler for reset button. This will reset form by calling sub procedure.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetFrm()

    End Sub

    ''' <summary>
    ''' Event handler for enter button which handles click event on enter button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtUnits.Text
        Dim inputAsInt As Integer

        If IsNumeric(userInput) Then
            inputAsInt = CInt(userInput)
            If inputAsInt.ToString = userInput Then
                If inputAsInt >= MIN_VALUE And inputAsInt <= MAX_VALUE Then
                    If (empNum = 2) Then
                        BoldFont(lblEmployee3, True)
                        If (colNum < MAX_DAYS) Then
                            daysArray(rowNum, colNum) = inputAsInt
                            txtEmp3.Text += daysArray(rowNum, colNum).ToString() + vbCrLf
                            runningTotal += inputAsInt
                            colNum += 1
                            If (colNum = 7) Then
                                CalEmp3(runningTotal)
                                CReset(rowNum, colNum)
                                CalAll(daysArray)
                                Exit Sub
                            End If
                            lblDays.Text = "Day " & (colNum + 1).ToString
                        End If
                    End If
                    If (empNum = 1) Then
                        BoldFont(lblEmployee2, True)
                        If (colNum < MAX_DAYS) Then
                            daysArray(rowNum, colNum) = inputAsInt
                            txtEmp2.Text += daysArray(rowNum, colNum).ToString() + vbCrLf
                            runningTotal += inputAsInt
                            colNum += 1
                            If (colNum = 7) Then
                                CalEmp2(runningTotal)
                                colNum = 0
                                empNum += 1
                            End If
                            lblDays.Text = "Day " & (colNum + 1).ToString
                        End If
                    End If
                    If (empNum = 0) Then
                        BoldFont(lblEmployee1, True)
                        If (colNum < MAX_DAYS) Then
                            daysArray(rowNum, colNum) = inputAsInt
                            txtEmp1.Text += daysArray(rowNum, colNum).ToString() + vbCrLf
                            runningTotal += inputAsInt
                            colNum += 1
                            If (colNum = 7) Then
                                CalEmp1(runningTotal)
                                colNum = 0
                                empNum += 1
                            End If
                            lblDays.Text = "Day " & (colNum + 1).ToString
                        End If
                    End If
                Else
                    MessageBox.Show("Please enter value between " + MAX_VALUE.ToString + " And " + MIN_VALUE.ToString)
                End If
            Else
                MessageBox.Show("Please enter a whole number.")
            End If
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
        txtUnits.Text = ""
    End Sub

    ''' <summary>
    ''' This will reset array and row count to 0
    ''' </summary>
    ''' <param name="rowNum"></param>
    ''' <param name="colNum"></param>
    Private Sub CReset(ByRef rowNum As Integer, ByRef colNum As Integer)
        empNum = 0
        colNum = 0
    End Sub

    ''' <summary>
    ''' It will calculate average units of 7 days for Employee 1
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalEmp1(ByRef runningTotal As Double)
        average1 = runningTotal / MAX_DAYS
        lblOutput1.Text = "Average: " & Math.Round(average1, 2).ToString
        BoldFont(lblEmployee1, False)
        BoldFont(lblEmployee2, True)
        runningTotal = 0.0
    End Sub

    ''' <summary>
    ''' It will calculate average units of 7 days for Employee 2
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalEmp2(ByRef runningTotal As Double)
        average2 = runningTotal / MAX_DAYS
        lblOutput2.Text = "Average: " & Math.Round(average2, 2).ToString
        BoldFont(lblEmployee2, False)
        BoldFont(lblEmployee3, True)
        runningTotal = 0.0
    End Sub

    ''' <summary>
    ''' It will calculate average units of 7 days for Employee 3
    ''' </summary>
    ''' <param name="runningTotal"></param>
    Private Sub CalEmp3(ByRef runningTotal As Double)
        average3 = runningTotal / MAX_DAYS
        lblOutput3.Text = "Average: " & Math.Round(average3, 2).ToString
        BoldFont(lblEmployee3, False)
        runningTotal = 0.0
    End Sub

    ''' <summary>
    ''' It will calculate average units of 3 employee of a week
    ''' </summary>
    ''' <param name="daysArray"></param>
    Private Sub CalAll(daysArray(,) As Integer)
        Dim allAvg As Double = 0.0

        total = average1 + average2 + average3

        allAvg = total / MAX_EMP
        lblResult.Text = "Average per day: " & Math.Round(allAvg, 2).ToString
        txtUnits.Enabled = False
        btnEnter.Enabled = False
        lblDays.Text = "Done"
    End Sub

    ''' <summary>
    ''' This will change the font style between regular and bold.
    ''' </summary>
    ''' <param name="lbCtrl"></param>
    ''' <param name="bold"></param>
    Private Sub BoldFont(lbCtrl As Label, bold As Boolean)
        If bold = True Then
            lbCtrl.Font = New Font(lbCtrl.Font, FontStyle.Bold)
        Else
            lbCtrl.Font = New Font(lbCtrl.Font, FontStyle.Regular)
        End If
    End Sub

End Class
