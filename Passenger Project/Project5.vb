
Public Class frmEditPassenger
  Dim arystrPassengers(10, 4) As String
  Dim intWaitlistCount As Integer = 0
  'row #0 and col#0 for total
  Dim intCount As Integer = 0
  Dim intCapacity As Integer = 40

  Private Sub frmEditPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    For intRow As Integer = 0 To 10
      For intCol As Integer = 0 To 4
        arystrPassengers(intRow, intCol) = "0"
      Next
    Next
    DisplayChart()

  End Sub
  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    'Add a passenger to list if there is an open seat
    'if no seat availabe, add to waitlist

    'validate if there is a name
    If txtName.Text.Length = 0 Then
      MessageBox.Show("Must enter a name")
      Return
    End If

    'check if passenger is already seated
    If SearchName(txtName.Text) = True Then 'name is found in list
      MessageBox.Show("Passenger '" & txtName.Text & "' is already seated")
      Return
    End If

    'If reached max capacity, add to waitlist
    If intCount = intCapacity Then
      lstWaitlist.Items.Add(txtName.Text)
      intWaitlistCount += 1
      Return
    End If

    'If seat is specified, validate seat
    If txtSeat.Text.Length <> 0 Then
      If ValidateSeat(txtSeat.Text) Then
        'check if seat is vacant
        Dim aryintPos() As Integer = TranslateSeat(txtSeat.Text) 'MessageBox.Show(CStr(aryintPos(0)) & " " + CStr(aryintPos(1)))
        If isVacant(aryintPos(0), aryintPos(1)) = True Then
          'insert reservation
          AddPassenger(aryintPos(0), aryintPos(1), txtName.Text)
          DisplayChart()
          Return
        Else
          MessageBox.Show("Seat is occupied")
          Return
        End If
      Else
        MessageBox.Show("Invalid Seat Format")
        Return
      End If
    End If

    'seat is not specified, add to any open seat
    FindVacantSeat(txtName.Text) 'TEST
  End Sub

  Function SearchName(strName As String)
    'return true if name is found and display seat, else return false
    For intRow As Integer = 1 To 10
      If CInt(arystrPassengers(intRow, 0)) > 0 Then 'row is not empty
        For intCol As Integer = 1 To 4
          If arystrPassengers(intRow, intCol) = strName Then
            txtSeat.Text = TranslateSeatPosition(intRow, intCol)
            Return True
          End If
        Next
      End If
    Next
    Return False
  End Function

  Private Sub FindVacantSeat(strName As String)
    For intRow As Integer = 1 To 10
      If CInt(arystrPassengers(intRow, 0)) < 4 Then 'if row is not full
        For intCol As Integer = 1 To 4
          If isVacant(intRow, intCol) = True Then 'found vacancy
            AddPassenger(intRow, intCol, strName)
            txtSeat.Text = TranslateSeatPosition(intRow, intCol)
            DisplayChart()
            Return
          End If
        Next
      End If
    Next
  End Sub
  Function ValidateSeat(strSeat As String)
    'check if strSeat is valid

    'check if there are 2 characters in string 
    If strSeat.Length() > 3 Or strSeat.Length < 2 Then
      Return False
    End If

    Dim strFirst As String = ""
    Dim strSec As String = ""
    If strSeat.Length() = 2 Then
      strFirst = strSeat.Substring(0, 1)
      strSec = strSeat.Substring(1, 1).ToUpper()
    Else 'length = 3
      strFirst = strSeat.Substring(0, 2)
      strSec = strSeat.Substring(2, 1).ToUpper()
    End If

    'check if strFirst is numeric and is 1-10
    If IsNumeric(strFirst) = False Then
      Return False
    Else
      Dim intNum As Integer = CInt(strFirst)
      If intNum < 1 Or intNum > 10 Then
        Return False
      End If
    End If

    'check if strSecond is a letter and is A-D
    If IsNumeric(strSec) = True Then
      Return False
    Else
      If strSec < "A" Or strSec > "D" Then
        Return False
      End If
    End If
    Return True
  End Function
  Function TranslateSeat(strSeat As String)
    'translate strSeat to position in 2d array
    Dim aryintSeatPos(1) As Integer
    Dim strSec As Char 'strSeat.Substring(1, 1).ToUpper
    If strSeat.Length() = 2 Then
      aryintSeatPos(0) = CInt(strSeat.Substring(0, 1))
      strSec = strSeat.Substring(1, 1).ToUpper()
    Else
      aryintSeatPos(0) = 10
      strSec = strSeat.Substring(2, 1).ToUpper()
    End If
    Select Case strSec
      Case "A"
        aryintSeatPos(1) = 1
      Case "B"
        aryintSeatPos(1) = 2
      Case "C"
        aryintSeatPos(1) = 3
      Case Else
        aryintSeatPos(1) = 4
    End Select
    Return aryintSeatPos
  End Function
  Function isVacant(intX As Integer, intY As Integer)
    If arystrPassengers(intX, intY) = "0" Then
      Return True
    End If
    Return False
  End Function
  Private Sub AddPassenger(intX As Integer, intY As Integer, strName As String)
    arystrPassengers(intX, intY) = strName
    arystrPassengers(intX, 0) = CInt(arystrPassengers(intX, 0)) + 1
    arystrPassengers(0, intY) = CInt(arystrPassengers(0, intY)) + 1
    intCount += 1
  End Sub
  Private Sub DisplayChart()
    txtOutput.Text = "Row  A  B    C  D" & vbCrLf
    Dim fmtStr As String = "{0, 2}{1, 4}{2, 3}{3, 5}{4,3}"
    For intRow As Integer = 1 To 10
      Dim strRowNum As String = CStr(intRow)
      Dim data(3) As String
      For intCol As Integer = 1 To 4
        If isVacant(intRow, intCol) = False Then
          data(intCol - 1) = "X"
        Else
          data(intCol - 1) = " "
        End If
      Next
      txtOutput.Text += String.Format(fmtStr, strRowNum, data(0), data(1), data(2), data(3))
      txtOutput.Text += vbCrLf
    Next
    lblCount.Text = "Passenger Count: " & CStr(intCount)
  End Sub
  Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    'Deletes passenger's resservation given their name 
    If txtName.TextLength() = 0 Then
      MessageBox.Show("Must enter name to delete")
      Return
    End If

    'loop through passenger array to search for name, if found, delete
    For intRow As Integer = 1 To 10
      If CInt(arystrPassengers(intRow, 0)) > 0 Then 'if row is not empty
        For intCol As Integer = 1 To 4
          If arystrPassengers(intRow, intCol) = txtName.Text Then 'found
            DeletePassenger(intRow, intCol)
            DisplayChart()
            Return
          End If
        Next
      End If
    Next
    'not found
    MessageBox.Show("Passenger '" & txtName.Text & "' not found")
  End Sub
  Private Sub DeletePassenger(intX, intY)
    arystrPassengers(intX, intY) = "0"
    intCount -= 1
    arystrPassengers(intX, 0) = CInt(arystrPassengers(intX, 0)) - 1
    arystrPassengers(0, intY) = CInt(arystrPassengers(0, intY)) - 1

    If intWaitlistCount > 0 Then 'if thereis someone on waitlist, add first to deleted position
      Dim strName As String = lstWaitlist.Items(0)
      lstWaitlist.Items.RemoveAt(0)
      intWaitlistCount -= 1
      AddPassenger(intX, intY, strName)
    End If

  End Sub
  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
  Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
    Dim strText As String = ""
    strText = "#:  Passenger Name:          Seat:" & vbCrLf
    Dim fmtStr As String = "{0, 2}{1, 23}{2, 7}"
    Dim intNum As Integer = 1
    For intRow As Integer = 1 To 10
      For intCol As Integer = 1 To 4
        Dim strName As String = arystrPassengers(intRow, intCol)
        If strName = "0" Then
          strName = "*** Available *******"
        End If
        strText += String.Format(fmtStr, CStr(intNum),
        strName, TranslateSeatPosition(intRow, intCol)) &
        vbCrLf
        intNum += 1
      Next
    Next

    Dim frmDisplay As New frmDisplay
    frmDisplay.txtDocument.Text = strText
    frmDisplay.txtDocument.SelectionStart = 0
    frmDisplay.ShowDialog()

  End Sub
  Function TranslateSeatPosition(intX As Integer, intY As Integer)
    Dim strResult As String = ""
    strResult += CStr(intX)
    Select Case intY
      Case 1
        strResult += "A"
      Case 2
        strResult += "B"
      Case 3
        strResult += "C"
      Case Else
        strResult += "D"
    End Select
    Return strResult
  End Function

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    For intRow As Integer = 0 To 10
      For intCol As Integer = 0 To 4
        arystrPassengers(intRow, intCol) = "0"
      Next
    Next
    intCount = 0
    DisplayChart()
  End Sub
End Class
