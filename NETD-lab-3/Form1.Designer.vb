﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.txtEmp3 = New System.Windows.Forms.TextBox()
        Me.txtEmp2 = New System.Windows.Forms.TextBox()
        Me.txtEmp1 = New System.Windows.Forms.TextBox()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 156)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(150, 25)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(150, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightToolStripPanel.Location = New System.Drawing.Point(150, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 156)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 156)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 156)
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(297, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttToolTip.SetToolTip(Me.btnExit, "Click the exit button to exit the form.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(155, 345)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 35)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttToolTip.SetToolTip(Me.btnReset, "Click reset button to clear the form.")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEnter.Location = New System.Drawing.Point(20, 345)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(129, 35)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttToolTip.SetToolTip(Me.btnEnter, "Click enter button to calculate units average.")
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(20, 313)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(401, 29)
        Me.lblResult.TabIndex = 12
        Me.ttToolTip.SetToolTip(Me.lblResult, "This lebel display avergae units per day by the company.")
        '
        'lblOutput3
        '
        Me.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput3.Location = New System.Drawing.Point(297, 290)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(125, 23)
        Me.lblOutput3.TabIndex = 11
        Me.ttToolTip.SetToolTip(Me.lblOutput3, "This display average units shipped per day by employee 3.")
        '
        'lblOutput2
        '
        Me.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput2.Location = New System.Drawing.Point(155, 290)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(136, 23)
        Me.lblOutput2.TabIndex = 10
        Me.ttToolTip.SetToolTip(Me.lblOutput2, "This display average units shipped per day by employee 2.")
        '
        'lblOutput1
        '
        Me.lblOutput1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput1.Location = New System.Drawing.Point(21, 290)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(128, 23)
        Me.lblOutput1.TabIndex = 9
        Me.ttToolTip.SetToolTip(Me.lblOutput1, "This display average units shipped per day by employee 1.")
        '
        'txtEmp3
        '
        Me.txtEmp3.Location = New System.Drawing.Point(297, 108)
        Me.txtEmp3.Multiline = True
        Me.txtEmp3.Name = "txtEmp3"
        Me.txtEmp3.ReadOnly = True
        Me.txtEmp3.Size = New System.Drawing.Size(125, 171)
        Me.txtEmp3.TabIndex = 8
        Me.txtEmp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttToolTip.SetToolTip(Me.txtEmp3, "This textbox display units shipped by employee 3.")
        '
        'txtEmp2
        '
        Me.txtEmp2.Location = New System.Drawing.Point(155, 108)
        Me.txtEmp2.Multiline = True
        Me.txtEmp2.Name = "txtEmp2"
        Me.txtEmp2.ReadOnly = True
        Me.txtEmp2.Size = New System.Drawing.Size(136, 172)
        Me.txtEmp2.TabIndex = 7
        Me.txtEmp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttToolTip.SetToolTip(Me.txtEmp2, "This textbox display units shipped by employee 2.")
        '
        'txtEmp1
        '
        Me.txtEmp1.Location = New System.Drawing.Point(21, 108)
        Me.txtEmp1.Multiline = True
        Me.txtEmp1.Name = "txtEmp1"
        Me.txtEmp1.ReadOnly = True
        Me.txtEmp1.Size = New System.Drawing.Size(128, 172)
        Me.txtEmp1.TabIndex = 6
        Me.txtEmp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttToolTip.SetToolTip(Me.txtEmp1, "This textbox display units shipped by employee 1.")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(315, 81)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(179, 81)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(41, 81)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnits.Location = New System.Drawing.Point(76, 45)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 22)
        Me.txtUnits.TabIndex = 2
        Me.ttToolTip.SetToolTip(Me.txtUnits, "This is input text box of units.")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(18, 45)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(18, 15)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(45, 17)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Day 1"
        '
        'ttToolTip
        '
        Me.ttToolTip.Tag = "ttToolTip"
        '
        'frmAverageUnits
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(434, 391)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.txtEmp3)
        Me.Controls.Add(Me.txtEmp2)
        Me.Controls.Add(Me.txtEmp1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDays)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents txtEmp3 As TextBox
    Friend WithEvents txtEmp2 As TextBox
    Friend WithEvents txtEmp1 As TextBox
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents ttToolTip As ToolTip
End Class
