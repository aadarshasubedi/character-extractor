<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacterExtractor
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
        Me.lblUserString = New System.Windows.Forms.Label()
        Me.txtUserString = New System.Windows.Forms.TextBox()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.lblResult4 = New System.Windows.Forms.Label()
        Me.lblResult5 = New System.Windows.Forms.Label()
        Me.lblStringLength = New System.Windows.Forms.Label()
        Me.chkShowString = New System.Windows.Forms.CheckBox()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.chk60 = New System.Windows.Forms.CheckBox()
        Me.chk50 = New System.Windows.Forms.CheckBox()
        Me.chk40 = New System.Windows.Forms.CheckBox()
        Me.chk30 = New System.Windows.Forms.CheckBox()
        Me.chk20 = New System.Windows.Forms.CheckBox()
        Me.chk10 = New System.Windows.Forms.CheckBox()
        Me.chk59 = New System.Windows.Forms.CheckBox()
        Me.chk49 = New System.Windows.Forms.CheckBox()
        Me.chk39 = New System.Windows.Forms.CheckBox()
        Me.chk29 = New System.Windows.Forms.CheckBox()
        Me.chk19 = New System.Windows.Forms.CheckBox()
        Me.chk9 = New System.Windows.Forms.CheckBox()
        Me.chk58 = New System.Windows.Forms.CheckBox()
        Me.chk48 = New System.Windows.Forms.CheckBox()
        Me.chk38 = New System.Windows.Forms.CheckBox()
        Me.chk28 = New System.Windows.Forms.CheckBox()
        Me.chk18 = New System.Windows.Forms.CheckBox()
        Me.chk8 = New System.Windows.Forms.CheckBox()
        Me.chk57 = New System.Windows.Forms.CheckBox()
        Me.chk47 = New System.Windows.Forms.CheckBox()
        Me.chk37 = New System.Windows.Forms.CheckBox()
        Me.chk27 = New System.Windows.Forms.CheckBox()
        Me.chk17 = New System.Windows.Forms.CheckBox()
        Me.chk7 = New System.Windows.Forms.CheckBox()
        Me.chk56 = New System.Windows.Forms.CheckBox()
        Me.chk46 = New System.Windows.Forms.CheckBox()
        Me.chk36 = New System.Windows.Forms.CheckBox()
        Me.chk26 = New System.Windows.Forms.CheckBox()
        Me.chk16 = New System.Windows.Forms.CheckBox()
        Me.chk6 = New System.Windows.Forms.CheckBox()
        Me.chk55 = New System.Windows.Forms.CheckBox()
        Me.chk45 = New System.Windows.Forms.CheckBox()
        Me.chk35 = New System.Windows.Forms.CheckBox()
        Me.chk25 = New System.Windows.Forms.CheckBox()
        Me.chk15 = New System.Windows.Forms.CheckBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk64 = New System.Windows.Forms.CheckBox()
        Me.chk54 = New System.Windows.Forms.CheckBox()
        Me.chk44 = New System.Windows.Forms.CheckBox()
        Me.chk34 = New System.Windows.Forms.CheckBox()
        Me.chk24 = New System.Windows.Forms.CheckBox()
        Me.chk14 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk63 = New System.Windows.Forms.CheckBox()
        Me.chk53 = New System.Windows.Forms.CheckBox()
        Me.chk43 = New System.Windows.Forms.CheckBox()
        Me.chk33 = New System.Windows.Forms.CheckBox()
        Me.chk23 = New System.Windows.Forms.CheckBox()
        Me.chk13 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk62 = New System.Windows.Forms.CheckBox()
        Me.chk52 = New System.Windows.Forms.CheckBox()
        Me.chk42 = New System.Windows.Forms.CheckBox()
        Me.chk32 = New System.Windows.Forms.CheckBox()
        Me.chk22 = New System.Windows.Forms.CheckBox()
        Me.chk12 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk61 = New System.Windows.Forms.CheckBox()
        Me.chk51 = New System.Windows.Forms.CheckBox()
        Me.chk41 = New System.Windows.Forms.CheckBox()
        Me.chk31 = New System.Windows.Forms.CheckBox()
        Me.chk21 = New System.Windows.Forms.CheckBox()
        Me.chk11 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lblResultIndex2 = New System.Windows.Forms.Label()
        Me.lblResultIndex3 = New System.Windows.Forms.Label()
        Me.lblResultIndex4 = New System.Windows.Forms.Label()
        Me.lblResultIndex1 = New System.Windows.Forms.Label()
        Me.lblResultIndex5 = New System.Windows.Forms.Label()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblCheckedCount = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpSelection.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserString
        '
        Me.lblUserString.AutoSize = True
        Me.lblUserString.Location = New System.Drawing.Point(22, 11)
        Me.lblUserString.Name = "lblUserString"
        Me.lblUserString.Size = New System.Drawing.Size(214, 17)
        Me.lblUserString.TabIndex = 0
        Me.lblUserString.Text = "1. Enter or paste the string here:"
        '
        'txtUserString
        '
        Me.txtUserString.Location = New System.Drawing.Point(25, 31)
        Me.txtUserString.Name = "txtUserString"
        Me.txtUserString.Size = New System.Drawing.Size(609, 22)
        Me.txtUserString.TabIndex = 1
        Me.txtUserString.UseSystemPasswordChar = True
        '
        'lblResult1
        '
        Me.lblResult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult1.Location = New System.Drawing.Point(6, 80)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(112, 45)
        Me.lblResult1.TabIndex = 3
        Me.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult2
        '
        Me.lblResult2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2.Location = New System.Drawing.Point(124, 80)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(112, 45)
        Me.lblResult2.TabIndex = 3
        Me.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult3
        '
        Me.lblResult3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult3.Location = New System.Drawing.Point(242, 80)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(112, 45)
        Me.lblResult3.TabIndex = 3
        Me.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult4
        '
        Me.lblResult4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult4.Location = New System.Drawing.Point(360, 80)
        Me.lblResult4.Name = "lblResult4"
        Me.lblResult4.Size = New System.Drawing.Size(112, 45)
        Me.lblResult4.TabIndex = 3
        Me.lblResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult5
        '
        Me.lblResult5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult5.Location = New System.Drawing.Point(478, 80)
        Me.lblResult5.Name = "lblResult5"
        Me.lblResult5.Size = New System.Drawing.Size(112, 45)
        Me.lblResult5.TabIndex = 3
        Me.lblResult5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStringLength
        '
        Me.lblStringLength.ForeColor = System.Drawing.Color.Gray
        Me.lblStringLength.Location = New System.Drawing.Point(640, 34)
        Me.lblStringLength.Name = "lblStringLength"
        Me.lblStringLength.Size = New System.Drawing.Size(56, 17)
        Me.lblStringLength.TabIndex = 0
        '
        'chkShowString
        '
        Me.chkShowString.AutoSize = True
        Me.chkShowString.Location = New System.Drawing.Point(25, 59)
        Me.chkShowString.Name = "chkShowString"
        Me.chkShowString.Size = New System.Drawing.Size(111, 21)
        Me.chkShowString.TabIndex = 4
        Me.chkShowString.Text = "&Show string?"
        Me.chkShowString.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(267, 518)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(112, 35)
        Me.btnClearAll.TabIndex = 5
        Me.btnClearAll.Text = "Clear &All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(31, 518)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(112, 35)
        Me.btnExtract.TabIndex = 5
        Me.btnExtract.Text = "&Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(522, 518)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClearSelection
        '
        Me.btnClearSelection.Location = New System.Drawing.Point(149, 518)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(112, 35)
        Me.btnClearSelection.TabIndex = 5
        Me.btnClearSelection.Text = "Clear &Selection"
        Me.btnClearSelection.UseVisualStyleBackColor = True
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.chk60)
        Me.grpSelection.Controls.Add(Me.chk50)
        Me.grpSelection.Controls.Add(Me.chk40)
        Me.grpSelection.Controls.Add(Me.chk30)
        Me.grpSelection.Controls.Add(Me.chk20)
        Me.grpSelection.Controls.Add(Me.chk10)
        Me.grpSelection.Controls.Add(Me.chk59)
        Me.grpSelection.Controls.Add(Me.chk49)
        Me.grpSelection.Controls.Add(Me.chk39)
        Me.grpSelection.Controls.Add(Me.chk29)
        Me.grpSelection.Controls.Add(Me.chk19)
        Me.grpSelection.Controls.Add(Me.chk9)
        Me.grpSelection.Controls.Add(Me.chk58)
        Me.grpSelection.Controls.Add(Me.chk48)
        Me.grpSelection.Controls.Add(Me.chk38)
        Me.grpSelection.Controls.Add(Me.chk28)
        Me.grpSelection.Controls.Add(Me.chk18)
        Me.grpSelection.Controls.Add(Me.chk8)
        Me.grpSelection.Controls.Add(Me.chk57)
        Me.grpSelection.Controls.Add(Me.chk47)
        Me.grpSelection.Controls.Add(Me.chk37)
        Me.grpSelection.Controls.Add(Me.chk27)
        Me.grpSelection.Controls.Add(Me.chk17)
        Me.grpSelection.Controls.Add(Me.chk7)
        Me.grpSelection.Controls.Add(Me.chk56)
        Me.grpSelection.Controls.Add(Me.chk46)
        Me.grpSelection.Controls.Add(Me.chk36)
        Me.grpSelection.Controls.Add(Me.chk26)
        Me.grpSelection.Controls.Add(Me.chk16)
        Me.grpSelection.Controls.Add(Me.chk6)
        Me.grpSelection.Controls.Add(Me.chk55)
        Me.grpSelection.Controls.Add(Me.chk45)
        Me.grpSelection.Controls.Add(Me.chk35)
        Me.grpSelection.Controls.Add(Me.chk25)
        Me.grpSelection.Controls.Add(Me.chk15)
        Me.grpSelection.Controls.Add(Me.chk5)
        Me.grpSelection.Controls.Add(Me.chk64)
        Me.grpSelection.Controls.Add(Me.chk54)
        Me.grpSelection.Controls.Add(Me.chk44)
        Me.grpSelection.Controls.Add(Me.chk34)
        Me.grpSelection.Controls.Add(Me.chk24)
        Me.grpSelection.Controls.Add(Me.chk14)
        Me.grpSelection.Controls.Add(Me.chk4)
        Me.grpSelection.Controls.Add(Me.chk63)
        Me.grpSelection.Controls.Add(Me.chk53)
        Me.grpSelection.Controls.Add(Me.chk43)
        Me.grpSelection.Controls.Add(Me.chk33)
        Me.grpSelection.Controls.Add(Me.chk23)
        Me.grpSelection.Controls.Add(Me.chk13)
        Me.grpSelection.Controls.Add(Me.chk3)
        Me.grpSelection.Controls.Add(Me.chk62)
        Me.grpSelection.Controls.Add(Me.chk52)
        Me.grpSelection.Controls.Add(Me.chk42)
        Me.grpSelection.Controls.Add(Me.chk32)
        Me.grpSelection.Controls.Add(Me.chk22)
        Me.grpSelection.Controls.Add(Me.chk12)
        Me.grpSelection.Controls.Add(Me.chk2)
        Me.grpSelection.Controls.Add(Me.chk61)
        Me.grpSelection.Controls.Add(Me.chk51)
        Me.grpSelection.Controls.Add(Me.chk41)
        Me.grpSelection.Controls.Add(Me.chk31)
        Me.grpSelection.Controls.Add(Me.chk21)
        Me.grpSelection.Controls.Add(Me.chk11)
        Me.grpSelection.Controls.Add(Me.chk1)
        Me.grpSelection.Location = New System.Drawing.Point(25, 86)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(609, 247)
        Me.grpSelection.TabIndex = 6
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "2. Select characters to extract"
        '
        'chk60
        '
        Me.chk60.Location = New System.Drawing.Point(474, 172)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(46, 24)
        Me.chk60.TabIndex = 4
        Me.chk60.Text = "60"
        Me.chk60.UseVisualStyleBackColor = True
        '
        'chk50
        '
        Me.chk50.Location = New System.Drawing.Point(474, 142)
        Me.chk50.Name = "chk50"
        Me.chk50.Size = New System.Drawing.Size(46, 24)
        Me.chk50.TabIndex = 4
        Me.chk50.Text = "50"
        Me.chk50.UseVisualStyleBackColor = True
        '
        'chk40
        '
        Me.chk40.Location = New System.Drawing.Point(474, 112)
        Me.chk40.Name = "chk40"
        Me.chk40.Size = New System.Drawing.Size(46, 24)
        Me.chk40.TabIndex = 4
        Me.chk40.Text = "40"
        Me.chk40.UseVisualStyleBackColor = True
        '
        'chk30
        '
        Me.chk30.Location = New System.Drawing.Point(474, 82)
        Me.chk30.Name = "chk30"
        Me.chk30.Size = New System.Drawing.Size(46, 24)
        Me.chk30.TabIndex = 4
        Me.chk30.Text = "30"
        Me.chk30.UseVisualStyleBackColor = True
        '
        'chk20
        '
        Me.chk20.Location = New System.Drawing.Point(474, 52)
        Me.chk20.Name = "chk20"
        Me.chk20.Size = New System.Drawing.Size(46, 24)
        Me.chk20.TabIndex = 4
        Me.chk20.Text = "20"
        Me.chk20.UseVisualStyleBackColor = True
        '
        'chk10
        '
        Me.chk10.Location = New System.Drawing.Point(475, 22)
        Me.chk10.Name = "chk10"
        Me.chk10.Size = New System.Drawing.Size(46, 24)
        Me.chk10.TabIndex = 4
        Me.chk10.Text = "10"
        Me.chk10.UseVisualStyleBackColor = True
        '
        'chk59
        '
        Me.chk59.Location = New System.Drawing.Point(422, 172)
        Me.chk59.Name = "chk59"
        Me.chk59.Size = New System.Drawing.Size(46, 24)
        Me.chk59.TabIndex = 4
        Me.chk59.Text = "59"
        Me.chk59.UseVisualStyleBackColor = True
        '
        'chk49
        '
        Me.chk49.Location = New System.Drawing.Point(422, 142)
        Me.chk49.Name = "chk49"
        Me.chk49.Size = New System.Drawing.Size(46, 24)
        Me.chk49.TabIndex = 4
        Me.chk49.Text = "49"
        Me.chk49.UseVisualStyleBackColor = True
        '
        'chk39
        '
        Me.chk39.Location = New System.Drawing.Point(422, 112)
        Me.chk39.Name = "chk39"
        Me.chk39.Size = New System.Drawing.Size(46, 24)
        Me.chk39.TabIndex = 4
        Me.chk39.Text = "39"
        Me.chk39.UseVisualStyleBackColor = True
        '
        'chk29
        '
        Me.chk29.Location = New System.Drawing.Point(422, 82)
        Me.chk29.Name = "chk29"
        Me.chk29.Size = New System.Drawing.Size(46, 24)
        Me.chk29.TabIndex = 4
        Me.chk29.Text = "29"
        Me.chk29.UseVisualStyleBackColor = True
        '
        'chk19
        '
        Me.chk19.Location = New System.Drawing.Point(422, 52)
        Me.chk19.Name = "chk19"
        Me.chk19.Size = New System.Drawing.Size(46, 24)
        Me.chk19.TabIndex = 4
        Me.chk19.Text = "19"
        Me.chk19.UseVisualStyleBackColor = True
        '
        'chk9
        '
        Me.chk9.Location = New System.Drawing.Point(423, 22)
        Me.chk9.Name = "chk9"
        Me.chk9.Size = New System.Drawing.Size(46, 24)
        Me.chk9.TabIndex = 4
        Me.chk9.Text = "9"
        Me.chk9.UseVisualStyleBackColor = True
        '
        'chk58
        '
        Me.chk58.Location = New System.Drawing.Point(370, 172)
        Me.chk58.Name = "chk58"
        Me.chk58.Size = New System.Drawing.Size(46, 24)
        Me.chk58.TabIndex = 4
        Me.chk58.Text = "58"
        Me.chk58.UseVisualStyleBackColor = True
        '
        'chk48
        '
        Me.chk48.Location = New System.Drawing.Point(370, 142)
        Me.chk48.Name = "chk48"
        Me.chk48.Size = New System.Drawing.Size(46, 24)
        Me.chk48.TabIndex = 4
        Me.chk48.Text = "48"
        Me.chk48.UseVisualStyleBackColor = True
        '
        'chk38
        '
        Me.chk38.Location = New System.Drawing.Point(370, 112)
        Me.chk38.Name = "chk38"
        Me.chk38.Size = New System.Drawing.Size(46, 24)
        Me.chk38.TabIndex = 4
        Me.chk38.Text = "38"
        Me.chk38.UseVisualStyleBackColor = True
        '
        'chk28
        '
        Me.chk28.Location = New System.Drawing.Point(370, 82)
        Me.chk28.Name = "chk28"
        Me.chk28.Size = New System.Drawing.Size(46, 24)
        Me.chk28.TabIndex = 4
        Me.chk28.Text = "28"
        Me.chk28.UseVisualStyleBackColor = True
        '
        'chk18
        '
        Me.chk18.Location = New System.Drawing.Point(370, 52)
        Me.chk18.Name = "chk18"
        Me.chk18.Size = New System.Drawing.Size(46, 24)
        Me.chk18.TabIndex = 4
        Me.chk18.Text = "18"
        Me.chk18.UseVisualStyleBackColor = True
        '
        'chk8
        '
        Me.chk8.Location = New System.Drawing.Point(371, 22)
        Me.chk8.Name = "chk8"
        Me.chk8.Size = New System.Drawing.Size(46, 24)
        Me.chk8.TabIndex = 4
        Me.chk8.Text = "8"
        Me.chk8.UseVisualStyleBackColor = True
        '
        'chk57
        '
        Me.chk57.Location = New System.Drawing.Point(318, 172)
        Me.chk57.Name = "chk57"
        Me.chk57.Size = New System.Drawing.Size(46, 24)
        Me.chk57.TabIndex = 4
        Me.chk57.Text = "57"
        Me.chk57.UseVisualStyleBackColor = True
        '
        'chk47
        '
        Me.chk47.Location = New System.Drawing.Point(318, 142)
        Me.chk47.Name = "chk47"
        Me.chk47.Size = New System.Drawing.Size(46, 24)
        Me.chk47.TabIndex = 4
        Me.chk47.Text = "47"
        Me.chk47.UseVisualStyleBackColor = True
        '
        'chk37
        '
        Me.chk37.Location = New System.Drawing.Point(318, 112)
        Me.chk37.Name = "chk37"
        Me.chk37.Size = New System.Drawing.Size(46, 24)
        Me.chk37.TabIndex = 4
        Me.chk37.Text = "37"
        Me.chk37.UseVisualStyleBackColor = True
        '
        'chk27
        '
        Me.chk27.Location = New System.Drawing.Point(318, 82)
        Me.chk27.Name = "chk27"
        Me.chk27.Size = New System.Drawing.Size(46, 24)
        Me.chk27.TabIndex = 4
        Me.chk27.Text = "27"
        Me.chk27.UseVisualStyleBackColor = True
        '
        'chk17
        '
        Me.chk17.Location = New System.Drawing.Point(318, 52)
        Me.chk17.Name = "chk17"
        Me.chk17.Size = New System.Drawing.Size(46, 24)
        Me.chk17.TabIndex = 4
        Me.chk17.Text = "17"
        Me.chk17.UseVisualStyleBackColor = True
        '
        'chk7
        '
        Me.chk7.Location = New System.Drawing.Point(319, 22)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(46, 24)
        Me.chk7.TabIndex = 4
        Me.chk7.Text = "7"
        Me.chk7.UseVisualStyleBackColor = True
        '
        'chk56
        '
        Me.chk56.Location = New System.Drawing.Point(266, 172)
        Me.chk56.Name = "chk56"
        Me.chk56.Size = New System.Drawing.Size(46, 24)
        Me.chk56.TabIndex = 4
        Me.chk56.Text = "56"
        Me.chk56.UseVisualStyleBackColor = True
        '
        'chk46
        '
        Me.chk46.Location = New System.Drawing.Point(266, 142)
        Me.chk46.Name = "chk46"
        Me.chk46.Size = New System.Drawing.Size(46, 24)
        Me.chk46.TabIndex = 4
        Me.chk46.Text = "46"
        Me.chk46.UseVisualStyleBackColor = True
        '
        'chk36
        '
        Me.chk36.Location = New System.Drawing.Point(266, 112)
        Me.chk36.Name = "chk36"
        Me.chk36.Size = New System.Drawing.Size(46, 24)
        Me.chk36.TabIndex = 4
        Me.chk36.Text = "36"
        Me.chk36.UseVisualStyleBackColor = True
        '
        'chk26
        '
        Me.chk26.Location = New System.Drawing.Point(266, 82)
        Me.chk26.Name = "chk26"
        Me.chk26.Size = New System.Drawing.Size(46, 24)
        Me.chk26.TabIndex = 4
        Me.chk26.Text = "26"
        Me.chk26.UseVisualStyleBackColor = True
        '
        'chk16
        '
        Me.chk16.Location = New System.Drawing.Point(266, 52)
        Me.chk16.Name = "chk16"
        Me.chk16.Size = New System.Drawing.Size(46, 24)
        Me.chk16.TabIndex = 4
        Me.chk16.Text = "16"
        Me.chk16.UseVisualStyleBackColor = True
        '
        'chk6
        '
        Me.chk6.Location = New System.Drawing.Point(267, 22)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New System.Drawing.Size(46, 24)
        Me.chk6.TabIndex = 4
        Me.chk6.Text = "6"
        Me.chk6.UseVisualStyleBackColor = True
        '
        'chk55
        '
        Me.chk55.Location = New System.Drawing.Point(214, 172)
        Me.chk55.Name = "chk55"
        Me.chk55.Size = New System.Drawing.Size(46, 24)
        Me.chk55.TabIndex = 4
        Me.chk55.Text = "55"
        Me.chk55.UseVisualStyleBackColor = True
        '
        'chk45
        '
        Me.chk45.Location = New System.Drawing.Point(214, 142)
        Me.chk45.Name = "chk45"
        Me.chk45.Size = New System.Drawing.Size(46, 24)
        Me.chk45.TabIndex = 4
        Me.chk45.Text = "45"
        Me.chk45.UseVisualStyleBackColor = True
        '
        'chk35
        '
        Me.chk35.Location = New System.Drawing.Point(214, 112)
        Me.chk35.Name = "chk35"
        Me.chk35.Size = New System.Drawing.Size(46, 24)
        Me.chk35.TabIndex = 4
        Me.chk35.Text = "35"
        Me.chk35.UseVisualStyleBackColor = True
        '
        'chk25
        '
        Me.chk25.Location = New System.Drawing.Point(214, 82)
        Me.chk25.Name = "chk25"
        Me.chk25.Size = New System.Drawing.Size(46, 24)
        Me.chk25.TabIndex = 4
        Me.chk25.Text = "25"
        Me.chk25.UseVisualStyleBackColor = True
        '
        'chk15
        '
        Me.chk15.Location = New System.Drawing.Point(214, 52)
        Me.chk15.Name = "chk15"
        Me.chk15.Size = New System.Drawing.Size(46, 24)
        Me.chk15.TabIndex = 4
        Me.chk15.Text = "15"
        Me.chk15.UseVisualStyleBackColor = True
        '
        'chk5
        '
        Me.chk5.Location = New System.Drawing.Point(215, 22)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(46, 24)
        Me.chk5.TabIndex = 4
        Me.chk5.Text = "5"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk64
        '
        Me.chk64.Location = New System.Drawing.Point(162, 202)
        Me.chk64.Name = "chk64"
        Me.chk64.Size = New System.Drawing.Size(46, 24)
        Me.chk64.TabIndex = 4
        Me.chk64.Text = "64"
        Me.chk64.UseVisualStyleBackColor = True
        '
        'chk54
        '
        Me.chk54.Location = New System.Drawing.Point(162, 172)
        Me.chk54.Name = "chk54"
        Me.chk54.Size = New System.Drawing.Size(46, 24)
        Me.chk54.TabIndex = 4
        Me.chk54.Text = "54"
        Me.chk54.UseVisualStyleBackColor = True
        '
        'chk44
        '
        Me.chk44.Location = New System.Drawing.Point(162, 142)
        Me.chk44.Name = "chk44"
        Me.chk44.Size = New System.Drawing.Size(46, 24)
        Me.chk44.TabIndex = 4
        Me.chk44.Text = "44"
        Me.chk44.UseVisualStyleBackColor = True
        '
        'chk34
        '
        Me.chk34.Location = New System.Drawing.Point(162, 112)
        Me.chk34.Name = "chk34"
        Me.chk34.Size = New System.Drawing.Size(46, 24)
        Me.chk34.TabIndex = 4
        Me.chk34.Text = "34"
        Me.chk34.UseVisualStyleBackColor = True
        '
        'chk24
        '
        Me.chk24.Location = New System.Drawing.Point(162, 82)
        Me.chk24.Name = "chk24"
        Me.chk24.Size = New System.Drawing.Size(46, 24)
        Me.chk24.TabIndex = 4
        Me.chk24.Text = "24"
        Me.chk24.UseVisualStyleBackColor = True
        '
        'chk14
        '
        Me.chk14.Location = New System.Drawing.Point(162, 52)
        Me.chk14.Name = "chk14"
        Me.chk14.Size = New System.Drawing.Size(46, 24)
        Me.chk14.TabIndex = 4
        Me.chk14.Text = "14"
        Me.chk14.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.Location = New System.Drawing.Point(163, 22)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(46, 24)
        Me.chk4.TabIndex = 4
        Me.chk4.Text = "4"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk63
        '
        Me.chk63.Location = New System.Drawing.Point(110, 202)
        Me.chk63.Name = "chk63"
        Me.chk63.Size = New System.Drawing.Size(46, 24)
        Me.chk63.TabIndex = 4
        Me.chk63.Text = "63"
        Me.chk63.UseVisualStyleBackColor = True
        '
        'chk53
        '
        Me.chk53.Location = New System.Drawing.Point(110, 172)
        Me.chk53.Name = "chk53"
        Me.chk53.Size = New System.Drawing.Size(46, 24)
        Me.chk53.TabIndex = 4
        Me.chk53.Text = "53"
        Me.chk53.UseVisualStyleBackColor = True
        '
        'chk43
        '
        Me.chk43.Location = New System.Drawing.Point(110, 142)
        Me.chk43.Name = "chk43"
        Me.chk43.Size = New System.Drawing.Size(46, 24)
        Me.chk43.TabIndex = 4
        Me.chk43.Text = "43"
        Me.chk43.UseVisualStyleBackColor = True
        '
        'chk33
        '
        Me.chk33.Location = New System.Drawing.Point(110, 112)
        Me.chk33.Name = "chk33"
        Me.chk33.Size = New System.Drawing.Size(46, 24)
        Me.chk33.TabIndex = 4
        Me.chk33.Text = "33"
        Me.chk33.UseVisualStyleBackColor = True
        '
        'chk23
        '
        Me.chk23.Location = New System.Drawing.Point(110, 82)
        Me.chk23.Name = "chk23"
        Me.chk23.Size = New System.Drawing.Size(46, 24)
        Me.chk23.TabIndex = 4
        Me.chk23.Text = "23"
        Me.chk23.UseVisualStyleBackColor = True
        '
        'chk13
        '
        Me.chk13.Location = New System.Drawing.Point(110, 52)
        Me.chk13.Name = "chk13"
        Me.chk13.Size = New System.Drawing.Size(46, 24)
        Me.chk13.TabIndex = 4
        Me.chk13.Text = "13"
        Me.chk13.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.Location = New System.Drawing.Point(111, 22)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(46, 24)
        Me.chk3.TabIndex = 4
        Me.chk3.Text = "3"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk62
        '
        Me.chk62.Location = New System.Drawing.Point(58, 202)
        Me.chk62.Name = "chk62"
        Me.chk62.Size = New System.Drawing.Size(46, 24)
        Me.chk62.TabIndex = 4
        Me.chk62.Text = "62"
        Me.chk62.UseVisualStyleBackColor = True
        '
        'chk52
        '
        Me.chk52.Location = New System.Drawing.Point(58, 172)
        Me.chk52.Name = "chk52"
        Me.chk52.Size = New System.Drawing.Size(46, 24)
        Me.chk52.TabIndex = 4
        Me.chk52.Text = "52"
        Me.chk52.UseVisualStyleBackColor = True
        '
        'chk42
        '
        Me.chk42.Location = New System.Drawing.Point(58, 142)
        Me.chk42.Name = "chk42"
        Me.chk42.Size = New System.Drawing.Size(46, 24)
        Me.chk42.TabIndex = 4
        Me.chk42.Text = "42"
        Me.chk42.UseVisualStyleBackColor = True
        '
        'chk32
        '
        Me.chk32.Location = New System.Drawing.Point(58, 112)
        Me.chk32.Name = "chk32"
        Me.chk32.Size = New System.Drawing.Size(46, 24)
        Me.chk32.TabIndex = 4
        Me.chk32.Text = "32"
        Me.chk32.UseVisualStyleBackColor = True
        '
        'chk22
        '
        Me.chk22.Location = New System.Drawing.Point(58, 82)
        Me.chk22.Name = "chk22"
        Me.chk22.Size = New System.Drawing.Size(46, 24)
        Me.chk22.TabIndex = 4
        Me.chk22.Text = "22"
        Me.chk22.UseVisualStyleBackColor = True
        '
        'chk12
        '
        Me.chk12.Location = New System.Drawing.Point(58, 52)
        Me.chk12.Name = "chk12"
        Me.chk12.Size = New System.Drawing.Size(46, 24)
        Me.chk12.TabIndex = 4
        Me.chk12.Text = "12"
        Me.chk12.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.Location = New System.Drawing.Point(59, 22)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(46, 24)
        Me.chk2.TabIndex = 4
        Me.chk2.Text = "2"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk61
        '
        Me.chk61.Location = New System.Drawing.Point(6, 202)
        Me.chk61.Name = "chk61"
        Me.chk61.Size = New System.Drawing.Size(46, 24)
        Me.chk61.TabIndex = 4
        Me.chk61.Text = "61"
        Me.chk61.UseVisualStyleBackColor = True
        '
        'chk51
        '
        Me.chk51.Location = New System.Drawing.Point(6, 172)
        Me.chk51.Name = "chk51"
        Me.chk51.Size = New System.Drawing.Size(46, 24)
        Me.chk51.TabIndex = 4
        Me.chk51.Text = "51"
        Me.chk51.UseVisualStyleBackColor = True
        '
        'chk41
        '
        Me.chk41.Location = New System.Drawing.Point(6, 142)
        Me.chk41.Name = "chk41"
        Me.chk41.Size = New System.Drawing.Size(46, 24)
        Me.chk41.TabIndex = 4
        Me.chk41.Text = "41"
        Me.chk41.UseVisualStyleBackColor = True
        '
        'chk31
        '
        Me.chk31.Location = New System.Drawing.Point(6, 112)
        Me.chk31.Name = "chk31"
        Me.chk31.Size = New System.Drawing.Size(46, 24)
        Me.chk31.TabIndex = 4
        Me.chk31.Text = "31"
        Me.chk31.UseVisualStyleBackColor = True
        '
        'chk21
        '
        Me.chk21.Location = New System.Drawing.Point(6, 82)
        Me.chk21.Name = "chk21"
        Me.chk21.Size = New System.Drawing.Size(46, 24)
        Me.chk21.TabIndex = 4
        Me.chk21.Text = "21"
        Me.chk21.UseVisualStyleBackColor = True
        '
        'chk11
        '
        Me.chk11.Location = New System.Drawing.Point(6, 52)
        Me.chk11.Name = "chk11"
        Me.chk11.Size = New System.Drawing.Size(46, 24)
        Me.chk11.TabIndex = 4
        Me.chk11.Text = "11"
        Me.chk11.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.Location = New System.Drawing.Point(7, 22)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(46, 24)
        Me.chk1.TabIndex = 4
        Me.chk1.Text = "1"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'lblResultIndex2
        '
        Me.lblResultIndex2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIndex2.Location = New System.Drawing.Point(124, 18)
        Me.lblResultIndex2.Name = "lblResultIndex2"
        Me.lblResultIndex2.Size = New System.Drawing.Size(112, 45)
        Me.lblResultIndex2.TabIndex = 3
        Me.lblResultIndex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultIndex3
        '
        Me.lblResultIndex3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIndex3.Location = New System.Drawing.Point(242, 18)
        Me.lblResultIndex3.Name = "lblResultIndex3"
        Me.lblResultIndex3.Size = New System.Drawing.Size(112, 45)
        Me.lblResultIndex3.TabIndex = 3
        Me.lblResultIndex3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultIndex4
        '
        Me.lblResultIndex4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIndex4.Location = New System.Drawing.Point(360, 18)
        Me.lblResultIndex4.Name = "lblResultIndex4"
        Me.lblResultIndex4.Size = New System.Drawing.Size(112, 45)
        Me.lblResultIndex4.TabIndex = 3
        Me.lblResultIndex4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultIndex1
        '
        Me.lblResultIndex1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIndex1.Location = New System.Drawing.Point(6, 18)
        Me.lblResultIndex1.Name = "lblResultIndex1"
        Me.lblResultIndex1.Size = New System.Drawing.Size(112, 45)
        Me.lblResultIndex1.TabIndex = 3
        Me.lblResultIndex1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultIndex5
        '
        Me.lblResultIndex5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIndex5.Location = New System.Drawing.Point(478, 18)
        Me.lblResultIndex5.Name = "lblResultIndex5"
        Me.lblResultIndex5.Size = New System.Drawing.Size(112, 45)
        Me.lblResultIndex5.TabIndex = 3
        Me.lblResultIndex5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lblResultIndex1)
        Me.grpResults.Controls.Add(Me.lblResult2)
        Me.grpResults.Controls.Add(Me.lblResult3)
        Me.grpResults.Controls.Add(Me.lblResultIndex2)
        Me.grpResults.Controls.Add(Me.lblResult4)
        Me.grpResults.Controls.Add(Me.lblResultIndex3)
        Me.grpResults.Controls.Add(Me.lblResultIndex4)
        Me.grpResults.Controls.Add(Me.lblResultIndex5)
        Me.grpResults.Controls.Add(Me.lblResult1)
        Me.grpResults.Controls.Add(Me.lblResult5)
        Me.grpResults.Location = New System.Drawing.Point(25, 354)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(609, 138)
        Me.grpResults.TabIndex = 7
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "3. Click 'Extract' to display results here:"
        '
        'lblCheckedCount
        '
        Me.lblCheckedCount.ForeColor = System.Drawing.Color.Gray
        Me.lblCheckedCount.Location = New System.Drawing.Point(640, 97)
        Me.lblCheckedCount.Name = "lblCheckedCount"
        Me.lblCheckedCount.Size = New System.Drawing.Size(56, 17)
        Me.lblCheckedCount.TabIndex = 0
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.Color.DarkGray
        Me.lblVersion.Location = New System.Drawing.Point(597, 571)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 17)
        Me.lblVersion.TabIndex = 8
        '
        'frmCharacterExtractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 597)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.btnClearSelection)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.chkShowString)
        Me.Controls.Add(Me.txtUserString)
        Me.Controls.Add(Me.lblCheckedCount)
        Me.Controls.Add(Me.lblStringLength)
        Me.Controls.Add(Me.lblUserString)
        Me.Name = "frmCharacterExtractor"
        Me.Text = "Character Extractor"
        Me.grpSelection.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserString As Label
    Friend WithEvents txtUserString As TextBox
    Friend WithEvents lblResult1 As Label
    Friend WithEvents lblResult2 As Label
    Friend WithEvents lblResult3 As Label
    Friend WithEvents lblResult4 As Label
    Friend WithEvents lblResult5 As Label
    Friend WithEvents lblStringLength As Label
    Friend WithEvents chkShowString As CheckBox
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnExtract As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClearSelection As Button
    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents chk10 As CheckBox
    Friend WithEvents chk9 As CheckBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk60 As CheckBox
    Friend WithEvents chk50 As CheckBox
    Friend WithEvents chk40 As CheckBox
    Friend WithEvents chk30 As CheckBox
    Friend WithEvents chk20 As CheckBox
    Friend WithEvents chk59 As CheckBox
    Friend WithEvents chk49 As CheckBox
    Friend WithEvents chk39 As CheckBox
    Friend WithEvents chk29 As CheckBox
    Friend WithEvents chk19 As CheckBox
    Friend WithEvents chk58 As CheckBox
    Friend WithEvents chk48 As CheckBox
    Friend WithEvents chk38 As CheckBox
    Friend WithEvents chk28 As CheckBox
    Friend WithEvents chk18 As CheckBox
    Friend WithEvents chk57 As CheckBox
    Friend WithEvents chk47 As CheckBox
    Friend WithEvents chk37 As CheckBox
    Friend WithEvents chk27 As CheckBox
    Friend WithEvents chk17 As CheckBox
    Friend WithEvents chk56 As CheckBox
    Friend WithEvents chk46 As CheckBox
    Friend WithEvents chk36 As CheckBox
    Friend WithEvents chk26 As CheckBox
    Friend WithEvents chk16 As CheckBox
    Friend WithEvents chk55 As CheckBox
    Friend WithEvents chk45 As CheckBox
    Friend WithEvents chk35 As CheckBox
    Friend WithEvents chk25 As CheckBox
    Friend WithEvents chk15 As CheckBox
    Friend WithEvents chk64 As CheckBox
    Friend WithEvents chk54 As CheckBox
    Friend WithEvents chk44 As CheckBox
    Friend WithEvents chk34 As CheckBox
    Friend WithEvents chk24 As CheckBox
    Friend WithEvents chk14 As CheckBox
    Friend WithEvents chk63 As CheckBox
    Friend WithEvents chk53 As CheckBox
    Friend WithEvents chk43 As CheckBox
    Friend WithEvents chk33 As CheckBox
    Friend WithEvents chk23 As CheckBox
    Friend WithEvents chk13 As CheckBox
    Friend WithEvents chk62 As CheckBox
    Friend WithEvents chk52 As CheckBox
    Friend WithEvents chk42 As CheckBox
    Friend WithEvents chk32 As CheckBox
    Friend WithEvents chk22 As CheckBox
    Friend WithEvents chk12 As CheckBox
    Friend WithEvents chk61 As CheckBox
    Friend WithEvents chk51 As CheckBox
    Friend WithEvents chk41 As CheckBox
    Friend WithEvents chk31 As CheckBox
    Friend WithEvents chk21 As CheckBox
    Friend WithEvents chk11 As CheckBox
    Friend WithEvents lblResultIndex2 As Label
    Friend WithEvents lblResultIndex3 As Label
    Friend WithEvents lblResultIndex4 As Label
    Friend WithEvents lblResultIndex1 As Label
    Friend WithEvents lblResultIndex5 As Label
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lblCheckedCount As Label
    Friend WithEvents lblVersion As Label
End Class
