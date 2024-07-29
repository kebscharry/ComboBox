<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStart = New Button()
        btnGo = New Button()
        btnVariables = New Button()
        btnDataType = New Button()
        btnInput = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        lblLastName = New Label()
        lblGender = New Label()
        txtLastName = New TextBox()
        txtGender = New TextBox()
        btnPound = New Button()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        lblNumber1 = New Label()
        lblNumber2 = New Label()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.Highlight
        btnStart.Location = New Point(1, 3)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(106, 29)
        btnStart.TabIndex = 0
        btnStart.Text = "press here"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(1, 212)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(106, 29)
        btnGo.TabIndex = 1
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' btnVariables
        ' 
        btnVariables.Location = New Point(1, 51)
        btnVariables.Name = "btnVariables"
        btnVariables.Size = New Size(106, 29)
        btnVariables.TabIndex = 2
        btnVariables.Text = "Variables"
        btnVariables.UseVisualStyleBackColor = True
        ' 
        ' btnDataType
        ' 
        btnDataType.Location = New Point(1, 161)
        btnDataType.Name = "btnDataType"
        btnDataType.Size = New Size(106, 29)
        btnDataType.TabIndex = 3
        btnDataType.Text = "Data Type"
        btnDataType.UseVisualStyleBackColor = True
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(1, 104)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(106, 29)
        btnInput.TabIndex = 4
        btnInput.Text = "input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(228, 27)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(161, 23)
        txtFirstName.TabIndex = 5
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(114, 30)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(64, 15)
        lblFirstName.TabIndex = 6
        lblFirstName.Text = "First Name"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(120, 89)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(63, 15)
        lblLastName.TabIndex = 7
        lblLastName.Text = "Last Name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(133, 144)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 8
        lblGender.Text = "Gender"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(228, 86)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(161, 23)
        txtLastName.TabIndex = 9
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(232, 144)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(161, 23)
        txtGender.TabIndex = 10
        ' 
        ' btnPound
        ' 
        btnPound.Location = New Point(192, 212)
        btnPound.Name = "btnPound"
        btnPound.Size = New Size(150, 38)
        btnPound.TabIndex = 11
        btnPound.Text = "pound"
        btnPound.UseVisualStyleBackColor = True
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 15
        lstOccupation.Items.AddRange(New Object() {"Developer", "Doctor", "Programmer", "Student", "Tutor"})
        lstOccupation.Location = New Point(413, 42)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(107, 199)
        lstOccupation.TabIndex = 12
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(413, 16)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(69, 15)
        lblOccupation.TabIndex = 13
        lblOccupation.Text = "Occupation"
        ' 
        ' lblNumber1
        ' 
        lblNumber1.AutoSize = True
        lblNumber1.Location = New Point(566, 39)
        lblNumber1.Name = "lblNumber1"
        lblNumber1.Size = New Size(60, 15)
        lblNumber1.TabIndex = 14
        lblNumber1.Text = "Number 1"
        ' 
        ' lblNumber2
        ' 
        lblNumber2.AutoSize = True
        lblNumber2.Location = New Point(563, 78)
        lblNumber2.Name = "lblNumber2"
        lblNumber2.Size = New Size(60, 15)
        lblNumber2.TabIndex = 15
        lblNumber2.Text = "Number 2"
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(647, 39)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(127, 23)
        txtNumber1.TabIndex = 16
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(647, 78)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(127, 23)
        txtNumber2.TabIndex = 17
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(587, 153)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(154, 46)
        btnCalculate.TabIndex = 18
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Controls.Add(lblNumber2)
        Controls.Add(lblNumber1)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(btnPound)
        Controls.Add(txtGender)
        Controls.Add(txtLastName)
        Controls.Add(lblGender)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnInput)
        Controls.Add(btnDataType)
        Controls.Add(btnVariables)
        Controls.Add(btnGo)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataType As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnPound As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnCalculate As Button

End Class
