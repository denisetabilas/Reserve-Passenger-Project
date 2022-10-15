<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPassenger
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.lblSeatExample = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lstWaitlist = New System.Windows.Forms.ListBox()
        Me.lblWaitlist = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Schoolbook", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(32, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(204, 64)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Schoolbook", 15.0!)
        Me.txtName.Location = New System.Drawing.Point(242, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(511, 56)
        Me.txtName.TabIndex = 1
        '
        'txtSeat
        '
        Me.txtSeat.Font = New System.Drawing.Font("Century Schoolbook", 15.0!)
        Me.txtSeat.Location = New System.Drawing.Point(969, 50)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(330, 56)
        Me.txtSeat.TabIndex = 3
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Font = New System.Drawing.Font("Century Schoolbook", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeat.Location = New System.Drawing.Point(781, 42)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(166, 64)
        Me.lblSeat.TabIndex = 2
        Me.lblSeat.Text = "Seat:"
        '
        'lblSeatExample
        '
        Me.lblSeatExample.AutoSize = True
        Me.lblSeatExample.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatExample.Location = New System.Drawing.Point(962, 124)
        Me.lblSeatExample.Name = "lblSeatExample"
        Me.lblSeatExample.Size = New System.Drawing.Size(315, 38)
        Me.lblSeatExample.TabIndex = 4
        Me.lblSeatExample.Text = "(1A, 1B -- 10A, 10B)"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Schoolbook", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Location = New System.Drawing.Point(43, 213)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(696, 148)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Passenger"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Century Schoolbook", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Location = New System.Drawing.Point(43, 396)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(696, 148)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete Passenger"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Century Schoolbook", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.Location = New System.Drawing.Point(43, 762)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(696, 148)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("Century Schoolbook", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnList.Location = New System.Drawing.Point(43, 575)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(696, 148)
        Me.btnList.TabIndex = 7
        Me.btnList.Text = "List Passengers"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Century Schoolbook", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(43, 957)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(696, 148)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtOutput.Location = New System.Drawing.Point(792, 213)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(519, 521)
        Me.txtOutput.TabIndex = 10
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblCount.Location = New System.Drawing.Point(997, 747)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(280, 38)
        Me.lblCount.TabIndex = 11
        Me.lblCount.Text = "Passenger Count: "
        '
        'lstWaitlist
        '
        Me.lstWaitlist.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lstWaitlist.FormattingEnabled = True
        Me.lstWaitlist.ItemHeight = 32
        Me.lstWaitlist.Location = New System.Drawing.Point(792, 877)
        Me.lstWaitlist.Name = "lstWaitlist"
        Me.lstWaitlist.Size = New System.Drawing.Size(519, 228)
        Me.lstWaitlist.TabIndex = 12
        '
        'lblWaitlist
        '
        Me.lblWaitlist.AutoSize = True
        Me.lblWaitlist.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblWaitlist.Location = New System.Drawing.Point(785, 836)
        Me.lblWaitlist.Name = "lblWaitlist"
        Me.lblWaitlist.Size = New System.Drawing.Size(143, 38)
        Me.lblWaitlist.TabIndex = 13
        Me.lblWaitlist.Text = "Waitlist:"
        '
        'frmEditPassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1385, 1166)
        Me.Controls.Add(Me.lblWaitlist)
        Me.Controls.Add(Me.lstWaitlist)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSeatExample)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmEditPassenger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project5 - Passengers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents lblSeat As Label
    Friend WithEvents lblSeatExample As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnList As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lstWaitlist As ListBox
    Friend WithEvents lblWaitlist As Label
End Class
