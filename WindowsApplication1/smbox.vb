Imports System.IO.Ports

Public Class SmartBox

    Shared sp As New SerialPort

    Dim OutputState As New BitArray(8)
    Shared InputState As New BitArray(8)
    Shared InpBinaryString As String
    Shared LastCommand As LastSentCommand
    Shared AnalogueByteValues(3) As Byte

    Public Enum MotorDirection As SByte
        Left = 1
        Right = -1
        [Stop] = 0
    End Enum

    Public Enum MotorOutput As Byte
        OutputA = 0
        OutputB = 1
        OutputC = 2
        OutputD = 3
        AllMotors = 4
    End Enum

    Public Enum AnalogueInput As Byte
        InputA = 1
        InputB = 2
        InputC = 3
        InputD = 4
    End Enum

    Public Enum DigitalOutput As Byte
        Output0 = 0
        Output1 = 1
        Output2 = 2
        Output3 = 3
        Output4 = 4
        Output5 = 5
        Output6 = 6
        Output7 = 7
    End Enum

    Public Enum DigitalInput As Byte
        Input0 = 0
        Input1 = 1
        Input2 = 2
        Input3 = 3
        Input4 = 4
        Input5 = 5
        Input6 = 6
        Input7 = 7
    End Enum

    Private Enum LastSentCommand As Byte
        DigitalRead = 1
        MotorWrite = 2
        DigitalAllWrite = 3
        AnalogueReadA = 4
        AnalogueReadB = 5
        AnalogueReadC = 6
        AnalogueReadD = 7
        ResetInterface = 255
    End Enum

    Public Sub New()

        Try
            Debug.WriteLine("New Sub Called")

            With sp
                .BaudRate = 9600
                .Handshake = Handshake.RequestToSend
                .DataBits = 8
                .Parity = Parity.None
            End With

            AddHandler sp.DataReceived, AddressOf DataReceivedHandler

        Catch ex As Exception : Debug.WriteLine("New Sub Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Protected Overrides Sub Finalize()

        Try

            Debug.WriteLine("Finalize Sub Called")
            If sp.IsOpen Then
                sp.Close()
                sp.Dispose()
            End If

        Catch ex As Exception
            Debug.WriteLine("Finalize Sub Exception: " & ex.Message.ToString)
        Finally : MyBase.Finalize()
        End Try

    End Sub

    Public Function OpenInterface(ByVal PortName As String) As Boolean

        Try
            Debug.WriteLine("OpenInterface Called Port Name: " & PortName)

            If sp.IsOpen Then 'this means that the port is actually already open
                Return True
            Else
                sp.PortName = PortName
                sp.Open()
                If sp.IsOpen Then
                    sp.DiscardInBuffer()
                    Return True
                Else : Return False
                End If
            End If

        Catch ex As Exception
            Debug.WriteLine("OpenInterface Exception: " & ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Sub CloseInterface()

        Try
            If sp.IsOpen Then

                Debug.WriteLine("CloseInterface Sub Called")
                sp.Close()

            End If
        Catch ex As Exception : Debug.WriteLine("CloseInterface Sub Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub ResetInterface()

        Try
            If sp.IsOpen Then

                Debug.WriteLine("ResetInterface Sub Called")
                sp.Write(Chr(2) & Chr(255))
                sp.DiscardInBuffer()
                LastCommand = LastSentCommand.ResetInterface

            End If
        Catch ex As Exception : Debug.WriteLine("ResetInterface Sub Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub DigitalWrite(ByVal DigitalOutput As DigitalOutput, ByVal High As Boolean)

        Try
            If sp.IsOpen Then

                Debug.WriteLine("DigitalWrite Called: " & DigitalOutput & " Status: " & High)

                Select Case High
                    Case True : OutputState(Convert.ToByte(DigitalOutput)) = True
                    Case False : OutputState(Convert.ToByte(DigitalOutput)) = False
                End Select

                Dim SendBytes(OutputState.Length) As Byte
                OutputState.CopyTo(SendBytes, 0)

                Debug.WriteLine("DigitalWrite Bytes Value: " & SendBytes(0))

                DigitalAllWrite(SendBytes(0))

            End If
        Catch ex As Exception : Debug.WriteLine("DigitalWrite Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub DigitalAllWrite(ByVal AllPinState As Byte)

        Try
            If sp.IsOpen Then
                Debug.WriteLine("DigitalAllWrite Called: " & AllPinState)
                sp.Write(Chr(20) & Chr(AllPinState))
                LastCommand = LastSentCommand.DigitalAllWrite
                Debug.WriteLine("DigitalAllWrite Finished")
            End If
        Catch ex As Exception : Debug.WriteLine("DigitalAllWrite Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub MotorWrite(ByVal MotorOutput As MotorOutput, ByVal MotorDirection As MotorDirection)

        Try
            If sp.IsOpen Then

                Debug.WriteLine("MotorWrite Sub Called: " & MotorOutput & " Direction: " & MotorDirection)

                If MotorOutput <> MotorOutput.AllMotors Then

                    Select Case MotorDirection
                        Case MotorDirection.Right : sp.Write(Chr(13))
                        Case MotorDirection.Left : sp.Write(Chr(12))
                        Case MotorDirection.Stop : sp.Write(Chr(14))
                    End Select

                    sp.Write(Chr(Convert.ToByte(MotorOutput)))

                Else : sp.Write(Chr(10) & Chr(0))
                End If

                LastCommand = LastSentCommand.MotorWrite

                Debug.WriteLine("MotorWrite Sub Finished")

            End If
        Catch ex As Exception : Debug.WriteLine("MotorWrite Sub Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub DigitalAllRead()

        Try
            If sp.IsOpen Then

                Debug.WriteLine("DigitalAllRead Called")
                sp.Write(Chr(90))
                LastCommand = LastSentCommand.DigitalRead

            End If

        Catch ex As Exception : Debug.WriteLine("DigitalAllRead Exception: " & ex.Message.ToString)
        End Try

    End Sub

    Public Function DigitalRead(ByVal DigitalInput As DigitalInput) As Boolean '#####

        Try
            Debug.WriteLine("DigitalRead Function Called: " & Convert.ToByte(DigitalInput))
            DigitalAllRead()
            Return InputState(Convert.ToByte(DigitalInput))

        Catch ex As Exception
            Debug.WriteLine("DigitalRead Exception: " & ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function AnalogueRead(ByVal AnalogueInput As AnalogueInput) As Byte

        Try
            If sp.IsOpen Then

                Debug.WriteLine("AnalogueRead Function Called: " & AnalogueInput)

                sp.Write(Chr(40) & Chr(Convert.ToByte(AnalogueInput)))

                Select Case AnalogueInput
                    Case AnalogueInput.InputA : LastCommand = LastSentCommand.AnalogueReadA
                    Case AnalogueInput.InputB : LastCommand = LastSentCommand.AnalogueReadB
                    Case AnalogueInput.InputC : LastCommand = LastSentCommand.AnalogueReadC
                    Case AnalogueInput.InputD : LastCommand = LastSentCommand.AnalogueReadD
                End Select

                Return AnalogueByteValues(Convert.ToByte(AnalogueInput) - 1)

            Else : Return 0
            End If

        Catch ex As Exception
            Debug.WriteLine("AnalogueRead Exception: " & ex.Message.ToString)
            Return 0
        End Try

    End Function

    Private Shared Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)

        Try
            Debug.WriteLine("DataReceivedHandler Called")
            Debug.WriteLine("Serial Port Bytes To Read: " & sp.BytesToRead)

            If sp.BytesToRead = 1 Then

                Select Case LastCommand
                    Case LastSentCommand.DigitalRead

                        InpBinaryString = Convert.ToString(sp.ReadByte, 2).PadLeft(8, "0")  'Convert integer to biary string.

                        Debug.WriteLine("Input Binary String: " & InpBinaryString)

                        Dim j As Byte = 7

                        For Each i As Char In InpBinaryString
                            Select Case i
                                Case "0" : InputState(j) = False
                                Case "1" : InputState(j) = True
                            End Select
                            j -= 1
                        Next

                    Case LastSentCommand.AnalogueReadA, LastSentCommand.AnalogueReadB, LastSentCommand.AnalogueReadC, LastSentCommand.AnalogueReadD
                        AnalogueByteValues(Convert.ToByte(LastCommand) - 4) = Convert.ToByte(sp.ReadByte)
                End Select

                sp.DiscardInBuffer()

            Else : sp.DiscardInBuffer()
            End If

        Catch ex As Exception : Debug.WriteLine("DataReceivedHandler Exception: " & ex.Message.ToString)
        End Try

    End Sub

End Class
