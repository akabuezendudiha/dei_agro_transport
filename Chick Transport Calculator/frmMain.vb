Public Class frmMain

    Const NAIRA_SYMBOL As String = "₦"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Gets users decision to close app
        Dim closeApp As DialogResult = MessageBox.Show("Close the Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeApp = DialogResult.Yes Then Close()  ' Closes the App if yes
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' Collects the parameters
        Dim nosOfChicks As Integer = Val(txtNoOfChicks.Text)
        Dim gitInsuranceCost As Decimal = Val(removeCommasFromNumbers(txtComputedGITCost.Text))
        Dim fixedCharge As Integer = Val(txtFixedCharge.Text)
        Dim totalDistanceCharge As Integer = Val(removeCommasFromNumbers(txtTotalDistanceCharge.Text))

        ' Calcuates the cost of chick transport
        Dim costOfChickTransport As Decimal = (fixedCharge + gitInsuranceCost + totalDistanceCharge) / nosOfChicks

        lblComputedCostOfChick.Text = String.Format("{0}{1}", NAIRA_SYMBOL, formatNumberWithCommas(costOfChickTransport))
    End Sub

    Private Sub CheckTextInputForInvalids_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtDistanceOfTravel.KeyPress, txtNoOfChicks.KeyPress, txtGITPercentage.KeyPress, txtFixedCharge.KeyPress, txtDistanceChargePerKm.KeyPress, txtCostPerDayoldChick.KeyPress, txtTotalValueOfChicks.KeyPress, txtTotalDistanceCharge.KeyPress
        e.Handled = Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = vbBack)
    End Sub

    Private Sub ValueComputeOnTextChanged_TextChanged(sender As Object, e As EventArgs) Handles txtNoOfChicks.TextChanged, txtGITPercentage.TextChanged, txtCostPerDayoldChick.TextChanged, txtDistanceChargePerKm.TextChanged, txtDistanceOfTravel.TextChanged
        Dim paramTextBox As TextBox = CType(sender, TextBox)
        Select Case paramTextBox.Name
            Case txtNoOfChicks.Name, txtCostPerDayoldChick.Name, txtGITPercentage.Name
                Dim noOfChicks As Integer = Val(txtNoOfChicks.Text)
                Dim costPerChick As Decimal = Val(txtCostPerDayoldChick.Text)
                Dim gitPercentage = Val(txtGITPercentage.Text) / 100
                Dim totalValueOfChicks As Decimal = Val(noOfChicks * costPerChick)
                ' Computes the total value of chicks
                txtTotalValueOfChicks.Text = formatNumberWithCommas(totalValueOfChicks)
                ' Computes the GIT insurance cost
                Dim gitInsurance = Val(totalValueOfChicks * gitPercentage)
                txtComputedGITCost.Text = formatNumberWithCommas(gitInsurance)
            Case txtDistanceChargePerKm.Text, txtDistanceOfTravel.Name
                Dim distanceChargePerKm As Integer = Val(txtDistanceChargePerKm.Text)
                Dim totalDistanceToDestination As Integer = Val(txtDistanceOfTravel.Text)
                Dim totalDistanceCharge = distanceChargePerKm * (totalDistanceToDestination * 2)
                txtTotalDistanceCharge.Text = formatNumberWithCommas(totalDistanceCharge.ToString)
            Case Else
                Debug.WriteLine("No Computation Required.")
        End Select
    End Sub

    Function formatNumberWithCommas(ByVal number As String) As String
        Return FormatNumber(number, NumDigitsAfterDecimal:=2)
    End Function

    Function removeCommasFromNumbers(ByVal number As String) As String
        Return number.Replace(",", "")
    End Function
End Class