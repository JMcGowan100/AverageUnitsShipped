<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippped
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
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDayNumber = New System.Windows.Forms.Label()
        Me.tbUserInput = New System.Windows.Forms.TextBox()
        Me.tbEntryDisplay = New System.Windows.Forms.TextBox()
        Me.lbAverageOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tipAvgUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbDayNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(45, 19)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(34, 13)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDayNumber
        '
        Me.lbDayNumber.AutoSize = True
        Me.lbDayNumber.Location = New System.Drawing.Point(57, 56)
        Me.lbDayNumber.Name = "lbDayNumber"
        Me.lbDayNumber.Size = New System.Drawing.Size(26, 13)
        Me.lbDayNumber.TabIndex = 2
        Me.lbDayNumber.Text = "Day"
        Me.lbDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUserInput
        '
        Me.tbUserInput.Location = New System.Drawing.Point(85, 16)
        Me.tbUserInput.Name = "tbUserInput"
        Me.tbUserInput.Size = New System.Drawing.Size(100, 20)
        Me.tbUserInput.TabIndex = 1
        Me.tipAvgUnitsShipped.SetToolTip(Me.tbUserInput, "Enter your number of units here")
        '
        'tbEntryDisplay
        '
        Me.tbEntryDisplay.Location = New System.Drawing.Point(60, 76)
        Me.tbEntryDisplay.Multiline = True
        Me.tbEntryDisplay.Name = "tbEntryDisplay"
        Me.tbEntryDisplay.Size = New System.Drawing.Size(172, 119)
        Me.tbEntryDisplay.TabIndex = 4
        Me.tipAvgUnitsShipped.SetToolTip(Me.tbEntryDisplay, "Displays each day of data here")
        '
        'lbAverageOutput
        '
        Me.lbAverageOutput.AutoSize = True
        Me.lbAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageOutput.Location = New System.Drawing.Point(48, 213)
        Me.lbAverageOutput.MinimumSize = New System.Drawing.Size(200, 0)
        Me.lbAverageOutput.Name = "lbAverageOutput"
        Me.lbAverageOutput.Size = New System.Drawing.Size(200, 15)
        Me.lbAverageOutput.TabIndex = 5
        Me.lbAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAvgUnitsShipped.SetToolTip(Me.lbAverageOutput, "Displays the calculated average of each days number of units")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 231)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Enter"
        Me.tipAvgUnitsShipped.SetToolTip(Me.btnEnter, "Click this button or hit Enter to input and display the value that was typed in")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(106, 231)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.tipAvgUnitsShipped.SetToolTip(Me.btnReset, "Click this button or hit Esc to clear all data and enter another week of data")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.tipAvgUnitsShipped.SetToolTip(Me.btnExit, "Click this button to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbDayNumber
        '
        Me.tbDayNumber.BackColor = System.Drawing.SystemColors.Control
        Me.tbDayNumber.Location = New System.Drawing.Point(85, 53)
        Me.tbDayNumber.Name = "tbDayNumber"
        Me.tbDayNumber.ReadOnly = True
        Me.tbDayNumber.Size = New System.Drawing.Size(25, 20)
        Me.tbDayNumber.TabIndex = 3
        Me.tipAvgUnitsShipped.SetToolTip(Me.tbDayNumber, "Displays the day number")
        '
        'frmAverageUnitsShippped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(289, 266)
        Me.Controls.Add(Me.tbDayNumber)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbAverageOutput)
        Me.Controls.Add(Me.tbEntryDisplay)
        Me.Controls.Add(Me.tbUserInput)
        Me.Controls.Add(Me.lbDayNumber)
        Me.Controls.Add(Me.lbUnits)
        Me.MaximumSize = New System.Drawing.Size(305, 305)
        Me.MinimumSize = New System.Drawing.Size(305, 305)
        Me.Name = "frmAverageUnitsShippped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUnits As Label
    Friend WithEvents lbDayNumber As Label
    Friend WithEvents tbUserInput As TextBox
    Friend WithEvents tbEntryDisplay As TextBox
    Friend WithEvents lbAverageOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tipAvgUnitsShipped As ToolTip
    Friend WithEvents tbDayNumber As TextBox
End Class
