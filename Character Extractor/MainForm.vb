Public Class frmCharacterExtractor

    Const userStringMaxLength As Byte = 64
    Const userStringMinLength As Byte = 6

    Dim checkbox As CheckBox
    Dim label As Label

    Dim userString As String
    Dim userStringLength As Integer

    Private Sub frmCharacterExtractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVersion.Text = "Version " & Application.ProductVersion

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub chkShowString_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowString.CheckedChanged

        Select Case chkShowString.Checked
            Case True
                txtUserString.UseSystemPasswordChar = False
            Case False
                txtUserString.UseSystemPasswordChar = True
        End Select

    End Sub

    Private Sub txtUserString_TextChanged(sender As Object, e As EventArgs) Handles txtUserString.TextChanged

        userString = txtUserString.Text
        userStringLength = Len(userString)

        If userStringLength > userStringMaxLength Then
            txtUserString.Text = vbNullString
            MsgBox(userStringMinLength & "-" & userStringMaxLength & " characters, please", , "Clearing")
        Else
            If Not Len(txtUserString.Text) = Len(Trim(txtUserString.Text)) Then
                txtUserString.Text = userString 'writes back in case trimmed
            End If
            lblStringLength.Text = CType(userStringLength, String)
        End If

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        txtUserString.Text = vbNullString
        lblStringLength.Text = vbNullString
        chkShowString.Checked = False

        ClearSelection()

    End Sub

    Private Sub btnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click

        ClearSelection()

    End Sub

    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click

        Dim checkedBoxList As New List(Of Integer)

        If userStringLength < userStringMinLength Then
            MsgBox("Minimum of " & userStringMinLength & " characters, please", , "Clearing")
            Exit Sub
        End If

        For Each checkbox In grpSelection.Controls
            If checkbox.Checked Then 'add to list array
                If Not CInt(checkbox.Text) > userStringLength Then
                    checkedBoxList.Add(CInt(checkbox.Text))
                Else 'if checkbox higher than user string length
                    checkbox.Checked = False
                End If
            End If
        Next

        checkedBoxList.Sort()

        Select Case checkedBoxList.Count
            Case 1
                UpdateResult1(checkedBoxList(0))
            Case 2
                UpdateResult1(checkedBoxList(0))
                UpdateResult2(checkedBoxList(1))
            Case 3
                UpdateResult1(checkedBoxList(0))
                UpdateResult2(checkedBoxList(1))
                UpdateResult3(checkedBoxList(2))
            Case 4
                UpdateResult1(checkedBoxList(0))
                UpdateResult2(checkedBoxList(1))
                UpdateResult3(checkedBoxList(2))
                UpdateResult4(checkedBoxList(3))
            Case 5
                UpdateResult1(checkedBoxList(0))
                UpdateResult2(checkedBoxList(1))
                UpdateResult3(checkedBoxList(2))
                UpdateResult4(checkedBoxList(3))
                UpdateResult5(checkedBoxList(4))
            Case Else
                'do nothing
        End Select

    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged,
            chk2.CheckedChanged, chk3.CheckedChanged, chk4.CheckedChanged, chk5.CheckedChanged,
            chk6.CheckedChanged, chk7.CheckedChanged, chk8.CheckedChanged, chk9.CheckedChanged,
            chk10.CheckedChanged, chk11.CheckedChanged, chk12.CheckedChanged, chk13.CheckedChanged,
            chk14.CheckedChanged, chk15.CheckedChanged, chk16.CheckedChanged, chk17.CheckedChanged,
            chk18.CheckedChanged, chk19.CheckedChanged, chk20.CheckedChanged, chk21.CheckedChanged,
            chk22.CheckedChanged, chk23.CheckedChanged, chk24.CheckedChanged, chk25.CheckedChanged,
            chk26.CheckedChanged, chk27.CheckedChanged, chk28.CheckedChanged, chk29.CheckedChanged,
            chk30.CheckedChanged, chk31.CheckedChanged, chk32.CheckedChanged, chk33.CheckedChanged,
            chk34.CheckedChanged, chk35.CheckedChanged, chk36.CheckedChanged, chk37.CheckedChanged,
            chk38.CheckedChanged, chk39.CheckedChanged, chk40.CheckedChanged, chk41.CheckedChanged,
            chk42.CheckedChanged, chk43.CheckedChanged, chk44.CheckedChanged, chk45.CheckedChanged,
            chk46.CheckedChanged, chk47.CheckedChanged, chk48.CheckedChanged, chk49.CheckedChanged,
            chk50.CheckedChanged, chk51.CheckedChanged, chk52.CheckedChanged, chk53.CheckedChanged,
            chk54.CheckedChanged, chk55.CheckedChanged, chk56.CheckedChanged, chk57.CheckedChanged,
            chk58.CheckedChanged, chk59.CheckedChanged, chk60.CheckedChanged, chk61.CheckedChanged,
            chk62.CheckedChanged, chk63.CheckedChanged, chk64.CheckedChanged

        Const maxCheckedBoxes As Integer = 5

        'lblCheckedCount.Text = CType(_count, String)

        Select Case getCheckedBoxCount()
            'Case 0
            '    MsgBox("Nothing selected", , "No boxes selected")
            '    Exit Sub
            Case > maxCheckedBoxes
                MsgBox("Maximum of " & maxCheckedBoxes & " checkboxes please", , "Too many boxes selected")
                Exit Sub
            Case Else 'do nothing
        End Select

        lblCheckedCount.Text = CType(getCheckedBoxCount(), String)

    End Sub

    Private Sub UpdateResult1(_selection As Integer)

        lblResultIndex1.Text = _selection.ToString
        lblResult1.Text = GetChar(userString, CInt(_selection))

    End Sub

    Private Sub UpdateResult2(_selection As Integer)

        lblResultIndex2.Text = _selection.ToString
        lblResult2.Text = GetChar(userString, CInt(_selection))

    End Sub

    Private Sub UpdateResult3(_selection As Integer)

        lblResultIndex3.Text = _selection.ToString
        lblResult3.Text = GetChar(userString, CInt(_selection))

    End Sub

    Private Sub UpdateResult4(_selection As Integer)

        lblResultIndex4.Text = _selection.ToString
        lblResult4.Text = GetChar(userString, CInt(_selection))

    End Sub

    Private Sub UpdateResult5(_selection As Integer)

        lblResultIndex5.Text = _selection.ToString
        lblResult5.Text = GetChar(userString, CInt(_selection))

    End Sub

    Private Sub ClearSelection()

        For Each checkbox In grpSelection.Controls
            checkbox.Checked = False
        Next

        For Each label In grpResults.Controls
            label.Text = vbNullString
        Next

    End Sub

    Private Function getCheckedBoxCount() As Integer

        Dim _count As Integer

        For Each checkbox In grpSelection.Controls
            If checkbox.Checked Then _count = _count + 1
        Next

        getCheckedBoxCount = _count

    End Function

    Private Function GetChar(str As String, i As Integer) As String

        GetChar = str.Substring(i - 1, 1)

    End Function

End Class