Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("hello world")
        MsgBox("how are you")
        MsgBox("I hope you are well")

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("welcome to this form")
        MessageBox.Show("this is another message")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kira"
        stLastName = "Cherie"

        MsgBox(" hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Hellen"
        stLastName = "Ariana"

        MsgBox(" hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

    End Sub

    Private Sub btnDataType_Click(sender As Object, e As EventArgs) Handles btnDataType.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#

        MsgBox(" the car is " & stMake & vbNewLine &
                stModel & vbNewLine & stColour & vbNewLine & bTaxed)

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim stFirstName As String

        stFirstName = InputBox("please enter your first name")

        MsgBox("hello " & stFirstName)

    End Sub

    Private Sub btnPound_Click(sender As Object, e As EventArgs) Handles btnPound.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        stOccupation = lstOccupation.SelectedItem

        MsgBox("hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim dblResults As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResults = dblNumber1 + dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 - dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 * dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 / dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 ^ dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 \ dblNumber2
        MsgBox(dblResults)

        dblResults = dblNumber1 Mod dblNumber2
        MsgBox(dblResults)


    End Sub
End Class
