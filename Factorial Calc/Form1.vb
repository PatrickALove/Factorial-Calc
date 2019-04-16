Public Class frmFactorialCalculator
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Uses loops to calculate the factorial and display it

        'Declare Variables
        Dim strFactorial As String
        Dim intFactorial As Integer
        Dim intTotalFact As Integer = 1
        Dim intCounter As Integer = 1
        Dim intMax As Integer


        'Input variables
        Dim strInputMessage As String = "Please enter the factorial"
        Dim strInputHeading As String = "Factorial"
        Dim strNormalMessage As String = "Enter the factorial you want"
        Dim strNonNumericError As String = "Error- Please enter a number for the factorial you wish to use"
        Dim strNegativeError As String = "Error- Please enter a positive number for the factorial you wish to use"
        Dim strTooHighError As String = "Error- Please enter a number smaller than 12 for the factorial you wish to use"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        'Calculate the factorial
        strFactorial = InputBox(strInputMessage, strInputHeading, " ")
        If IsNumeric(strFactorial) Then
            intMax = Convert.ToInt32(strFactorial)
            If intMax > 12 Then
                MessageBox.Show(strTooHighError)
                lstFactorialResult.Items.Clear()
                btnCalc.Enabled = True
            End If
            If intMax > 0 Then
                For intFactorial = 1 To intMax
                    intNumberOfEntries += 1
                    intCounter *= intFactorial
                    lstFactorialResult.Items.Add("!" & intFactorial & "==" & intCounter)
                Next
            Else
                MessageBox.Show(strNegativeError)
                lstFactorialResult.Items.Clear()
                btnCalc.Enabled = True
            End If
        Else
            MessageBox.Show(strNonNumericError)
        End If
        If intNumberOfEntries <= intMax Then
            strFactorial = InputBox(strInputMessage, strInputHeading, " ")
        End If
        If strFactorial = strCancelClicked Then
            lstFactorialResult.Items.Clear()
            btnCalc.Enabled = True
        End If
        'disable the button
        btnCalc.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear_Click event clears the ListBox object and also enables the Calculate button

        lstFactorialResult.Items.Clear()
        btnCalc.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' mnuExit_Click event closes the window and exits the application

        Close()
    End Sub
End Class
