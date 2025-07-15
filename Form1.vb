Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, lblMIS.Click, lblOOP1.Click, lblPDA.Click, lblGRADE.Click, Label5.Click, lblAVERAGE.Click, Label3.Click, lblTOTAL.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnCOMPUTE_Click(sender As Object, e As EventArgs) Handles btnCOMPUTE.Click
        Dim PDA As Single, OOP1 As Single, TOTAL As Single, AVG As Single, MIS As Single

        PDA = CSng(txtPDA.Text)
        MIS = CSng(txtMIS.Text)
        OOP1 = CSng(txtOOP1.Text)
        TOTAL = PDA + mis + OOP1
        AVG = TOTAL / 3
        lblTOTAL.Text = TOTAL.ToString
        lblAVERAGE.Text = AVG.ToString
        If AVG >= 70 And AVG <= 100 Then
            lblGRADE.Text = "A"
        ElseIf AVG >= 60 And AVG <= 69 Then
            lblGRADE.Text = "B"
        ElseIf AVG >= 50 And AVG <= 59 Then
            lblGRADE.Text = "C"
        ElseIf AVG >= 40 And AVG <= 49 Then
            lblGRADE.Text = "D"
        ElseIf AVG >= 30 And AVG <= 39 Then
            lblGRADE.Text = "F"
        ElseIf AVG < 0 Then
            lblGRADE.Text = "invalid"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPDA_TextChanged(sender As Object, e As EventArgs) Handles txtPDA.TextChanged

    End Sub
End Class
