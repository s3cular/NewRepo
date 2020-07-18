<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.ckNew = New System.Windows.Forms.CheckBox()
        Me.lvCarlist = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(9, 18)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Tesla", "Hyundai", "BMW"})
        Me.cbMake.Location = New System.Drawing.Point(67, 17)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 24)
        Me.cbMake.TabIndex = 1
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(9, 50)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(67, 50)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 3
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(9, 85)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", ""})
        Me.cbYear.Location = New System.Drawing.Point(67, 82)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 24)
        Me.cbYear.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(9, 115)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(67, 112)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 7
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(10, 143)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(100, 23)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        '
        'ckNew
        '
        Me.ckNew.AutoSize = True
        Me.ckNew.Location = New System.Drawing.Point(67, 142)
        Me.ckNew.Name = "ckNew"
        Me.ckNew.Size = New System.Drawing.Size(18, 17)
        Me.ckNew.TabIndex = 9
        Me.ckNew.UseVisualStyleBackColor = True
        '
        'lvCarlist
        '
        Me.lvCarlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvCarlist.FullRowSelect = True
        Me.lvCarlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCarlist.HideSelection = False
        Me.lvCarlist.Location = New System.Drawing.Point(12, 175)
        Me.lvCarlist.MultiSelect = False
        Me.lvCarlist.Name = "lvCarlist"
        Me.lvCarlist.Size = New System.Drawing.Size(519, 231)
        Me.lvCarlist.TabIndex = 10
        Me.ttToolTip.SetToolTip(Me.lvCarlist, "Added cars detail list")
        Me.lvCarlist.UseCompatibleStateImageBehavior = False
        Me.lvCarlist.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 88
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 94
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 76
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(294, 550)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 33)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttToolTip.SetToolTip(Me.btnEnter, "Press enter to add details to list.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(375, 550)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 33)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttToolTip.SetToolTip(Me.btnReset, "Press reset button to set form to it's default state.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 550)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ttToolTip.SetToolTip(Me.btnExit, "Press exit button to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(13, 413)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(518, 134)
        Me.lblOutput.TabIndex = 11
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(540, 587)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvCarlist)
        Me.Controls.Add(Me.ckNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents ckNew As CheckBox
    Friend WithEvents lvCarlist As ListView
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents ttToolTip As ToolTip
    Friend WithEvents lblOutput As Label
End Class
