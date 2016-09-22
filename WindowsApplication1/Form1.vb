Imports System.IO.Ports

Public Class frmSmartBox

    Dim sb As New SmartBox()

    Private Sub btnOpenInterface_Click(sender As Object, e As EventArgs) Handles btnOpenInterface.Click

        If sb.OpenInterface("COM14") = True Then
            lblStatus.Text = "Port Opened"
            sb.ResetInterface()
            btnOpenInterface.Enabled = False
            btnCloseInterface.Enabled = True
            'tmrDInputs.Enabled = True
            tmrAInputs.Enabled = True
        Else : lblStatus.Text = "Port Not Opened"
        End If

    End Sub

    Private Sub frmSmartBox_Closed(sender As Object, e As EventArgs) Handles Me.Disposed
        sb.CloseInterface()
    End Sub

    Private Sub btnCloseInterface_Click(sender As Object, e As EventArgs) Handles btnCloseInterface.Click
        sb.CloseInterface()
        btnOpenInterface.Enabled = True
        btnCloseInterface.Enabled = False
        'tmrDInputs.Enabled = False
        tmrAInputs.Enabled = False
        lblStatus.Text = "Interface Closed"
    End Sub

    Private Sub cbO0_CheckedChanged(sender As Object, e As EventArgs) Handles cbO0.CheckedChanged
        If cbO0.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output0, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output0, False)
        End If
    End Sub

    Private Sub cbO1_CheckedChanged(sender As Object, e As EventArgs) Handles cbO1.CheckedChanged
        If cbO1.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output1, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output1, False)
        End If
    End Sub

    Private Sub cbO2_CheckedChanged(sender As Object, e As EventArgs) Handles cbO2.CheckedChanged
        If cbO2.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output2, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output2, False)
        End If
    End Sub

    Private Sub cbO3_CheckedChanged(sender As Object, e As EventArgs) Handles cbO3.CheckedChanged
        If cbO3.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output3, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output3, False)
        End If
    End Sub

    Private Sub cbO4_CheckedChanged(sender As Object, e As EventArgs) Handles cbO4.CheckedChanged
        If cbO4.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output4, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output4, False)
        End If
    End Sub

    Private Sub cbO5_CheckedChanged(sender As Object, e As EventArgs) Handles cbO5.CheckedChanged
        If cbO5.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output5, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output5, False)
        End If
    End Sub

    Private Sub cbO6_CheckedChanged(sender As Object, e As EventArgs) Handles cbO6.CheckedChanged
        If cbO6.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output6, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output6, False)
        End If
    End Sub

    Private Sub cbO7_CheckedChanged(sender As Object, e As EventArgs) Handles cbO7.CheckedChanged
        If cbO7.Checked Then
            sb.DigitalWrite(SmartBox.DigitalOutput.Output7, True)
        Else : sb.DigitalWrite(SmartBox.DigitalOutput.Output7, False)
        End If
    End Sub

    Private Sub tmrInputs_Tick(sender As Object, e As EventArgs) Handles tmrDInputs.Tick

        Try
            If sb.DigitalRead(SmartBox.DigitalInput.Input0) Then cbI0.Checked = True Else cbI0.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input1) Then cbI1.Checked = True Else cbI1.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input2) Then cbI2.Checked = True Else cbI2.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input3) Then cbI3.Checked = True Else cbI3.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input4) Then cbI4.Checked = True Else cbI4.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input5) Then cbI5.Checked = True Else cbI5.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input6) Then cbI6.Checked = True Else cbI6.Checked = False
            If sb.DigitalRead(SmartBox.DigitalInput.Input7) Then cbI7.Checked = True Else cbI7.Checked = False

        Catch ex As Exception
        End Try

    End Sub

    Private Sub tmrAInputs_Tick(sender As Object, e As EventArgs) Handles tmrAInputs.Tick
        pbAnA.Value = sb.AnalogueRead(SmartBox.AnalogueInput.InputA)
        Threading.Thread.Sleep(100)
        pbAnB.Value = sb.AnalogueRead(SmartBox.AnalogueInput.InputB)
        Threading.Thread.Sleep(100)
        pbAnC.Value = sb.AnalogueRead(SmartBox.AnalogueInput.InputC)
        Threading.Thread.Sleep(100)
        pbAnD.Value = sb.AnalogueRead(SmartBox.AnalogueInput.InputD)
    End Sub

    Private Sub rMAL_CheckedChanged(sender As Object, e As EventArgs) Handles rMAL.CheckedChanged
        If rMAL.Checked Then sb.MotorWrite(SmartBox.MotorOutput.OutputA, SmartBox.MotorDirection.Left)
    End Sub

    Private Sub rMAS_CheckedChanged(sender As Object, e As EventArgs) Handles rMAS.CheckedChanged
        If rMAS.Checked Then sb.MotorWrite(SmartBox.MotorOutput.OutputA, SmartBox.MotorDirection.Stop)
    End Sub

    Private Sub rMAR_CheckedChanged(sender As Object, e As EventArgs) Handles rMAR.CheckedChanged
        If rMAR.Checked Then sb.MotorWrite(SmartBox.MotorOutput.OutputA, SmartBox.MotorDirection.Right)
    End Sub

End Class
