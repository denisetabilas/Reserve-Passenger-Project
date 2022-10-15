' Copyright (c) Microsoft Corporation. All rights reserved.
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplay))
		Me.txtDocument = New System.Windows.Forms.TextBox()
		Me.btnPageSetup = New System.Windows.Forms.Button()
		Me.btnPrintDialog = New System.Windows.Forms.Button()
		Me.btnPrintPreview = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.FontDialog1 = New System.Windows.Forms.FontDialog()
		Me.btnFont = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtDocument
		'
		Me.txtDocument.AccessibleDescription = "TextBox to contain text for printing"
		Me.txtDocument.AccessibleName = "TextBox for printing"
		Me.txtDocument.BackColor = System.Drawing.Color.White
		Me.txtDocument.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocument.Location = New System.Drawing.Point(12, 10)
		Me.txtDocument.Multiline = True
		Me.txtDocument.Name = "txtDocument"
		Me.txtDocument.ReadOnly = True
		Me.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtDocument.Size = New System.Drawing.Size(336, 413)
		Me.txtDocument.TabIndex = 5
		'
		'btnPageSetup
		'
		Me.btnPageSetup.AccessibleDescription = "Button with text ""Page Setup"""
		Me.btnPageSetup.AccessibleName = "Page Setup button"
		Me.btnPageSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPageSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btnPageSetup.Location = New System.Drawing.Point(384, 193)
		Me.btnPageSetup.Name = "btnPageSetup"
		Me.btnPageSetup.Size = New System.Drawing.Size(88, 58)
		Me.btnPageSetup.TabIndex = 2
		Me.btnPageSetup.Text = "Page &Setup"
		'
		'btnPrintDialog
		'
		Me.btnPrintDialog.AccessibleDescription = "Button with text ""Print Dialog"""
		Me.btnPrintDialog.AccessibleName = "Print Dialog button"
		Me.btnPrintDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrintDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btnPrintDialog.Location = New System.Drawing.Point(384, 12)
		Me.btnPrintDialog.Name = "btnPrintDialog"
		Me.btnPrintDialog.Size = New System.Drawing.Size(88, 58)
		Me.btnPrintDialog.TabIndex = 0
		Me.btnPrintDialog.Text = "&Print"
		'
		'btnPrintPreview
		'
		Me.btnPrintPreview.AccessibleDescription = "Button with text ""Print Preview"""
		Me.btnPrintPreview.AccessibleName = "Print Preview button"
		Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrintPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btnPrintPreview.Location = New System.Drawing.Point(384, 102)
		Me.btnPrintPreview.Name = "btnPrintPreview"
		Me.btnPrintPreview.Size = New System.Drawing.Size(88, 58)
		Me.btnPrintPreview.TabIndex = 1
		Me.btnPrintPreview.Text = "P&rint Preview"
		'
		'PrintDocument1
		'
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
		'
		'PrintPreviewDialog1
		'
		Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.PrintPreviewDialog1.Enabled = True
		Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
		Me.PrintPreviewDialog1.Visible = False
		'
		'btnClose
		'
		Me.btnClose.AccessibleDescription = "Button  ""Close"""
		Me.btnClose.AccessibleName = "Close button"
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btnClose.Location = New System.Drawing.Point(384, 365)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(88, 58)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "&Close"
		'
		'btnFont
		'
		Me.btnFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFont.Location = New System.Drawing.Point(384, 287)
		Me.btnFont.Name = "btnFont"
		Me.btnFont.Size = New System.Drawing.Size(88, 56)
		Me.btnFont.TabIndex = 3
		Me.btnFont.Text = "&Font"
		Me.btnFont.UseVisualStyleBackColor = True
		'
		'frmDisplay
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(497, 454)
		Me.Controls.Add(Me.btnFont)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.txtDocument)
		Me.Controls.Add(Me.btnPageSetup)
		Me.Controls.Add(Me.btnPrintDialog)
		Me.Controls.Add(Me.btnPrintPreview)
		Me.Name = "frmDisplay"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Passenger List"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtDocument As System.Windows.Forms.TextBox
    Friend WithEvents btnPageSetup As System.Windows.Forms.Button
    Friend WithEvents btnPrintDialog As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnFont As System.Windows.Forms.Button

End Class
