Imports System
Imports System.Windows.Forms.AxHost
Imports Snap7


'When WordLen=S7WLBit the Offset (Start) must be expressed in bits.
'Ex.The Start for DB4.DBX 10.3 Is (10*8)+3 = 83

Public Class MainForm

    Dim Buffer(65536) As Byte ' Buffer  
    Dim Client As Snap7.S7Client ' Client Object
    Dim alarme = 0
    Dim alarme2 = 0



    '----------------------Load Program -----------------------
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "UR10 Monitorization"
        Timer5.Enabled = True
        ToolStripStatusLabel1.Text = "Welcome To The UR10 Monitorization Aplication  "
        ToolStripStatusLabel3.Text = " || Bernardo Peixoto, João Venâncio, Rodrigo Baltazar, Samuel Figueira ||"


    End Sub

    'Private Sub ShowResult(ByVal Result As Integer)
    ' This function returns a textual explaination of the error code
    'TextError.Text = Client.ErrorText(Result)
    'End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Client = New S7Client

        If IntPtr.Size = 4 Then
            Text = Text + " - Running 32 bit Code"
        Else
            Text = Text + " - Running 64 bit Code"
        End If

    End Sub
    '-----------------------CONNECT PLC -----------------------
    Private Sub ConnectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectBtn.Click
        Dim Result As Integer
        Dim Rack As Integer = System.Convert.ToInt32(TxtRack.Text)
        Dim Slot As Integer = System.Convert.ToInt32(TxtSlot.Text)


        Result = Client.ConnectTo(TxtIP.Text, Rack, Slot)
        'ShowResult(Result)
        If Result = 0 Then
            TxtIP.Enabled = False
            TxtRack.Enabled = False
            TxtSlot.Enabled = False
            ConnectBtn.Enabled = False
            DisconnectBtn.Enabled = True
            Btn_Run.Enabled = True
            Btn_Stop.Enabled = True
            BtmodoAutomatico.Enabled = True
            Btn_PLC_Status.Enabled = True
            btmodomanual.Enabled = True
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
            Timer4.Enabled = True



        End If

    End Sub

    '-----------------------DISCONNECT PLC COMMUNICATION-----------------------
    Private Sub DisconnectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectBtn.Click
        Client.Disconnect()
        TxtIP.Enabled = True
        TxtRack.Enabled = True
        TxtSlot.Enabled = True
        ConnectBtn.Enabled = True
        DisconnectBtn.Enabled = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False


    End Sub


    '-----------------------PLC STATUS-----------------------
    Private Sub Btn_PLC_Status_Click(sender As Object, e As EventArgs) Handles Btn_PLC_Status.Click
        Dim Result As Integer
        Dim Status As Integer


        Result = Client.PlcGetStatus(Status)

        If Status = 8 Then
            Txt_PLC_Status.Text = "Running"
        End If

        If Status = 4 Then
            Txt_PLC_Status.Text = "Stop"
        End If
    End Sub

    '-----------------------RUN PLC-----------------------
    Private Sub Btn_Run_Click(sender As Object, e As EventArgs) Handles Btn_Run.Click
        ' PLC Run
        Client.PlcHotStart()
    End Sub

    '-----------------------STOP PLC-----------------------
    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        ' PLC Stop
        Client.PlcStop()

    End Sub


    '-----------------------Ligar Modo Automático & Desligar Modo Manual-----------------------

    Private Sub BtmodoAutomatico_Click(sender As Object, e As EventArgs) Handles BtmodoAutomatico.Click

        Dim Start = "0.1"
        Dim Amount As Int32 = 1
        Dim Result
        Dim result2
        Dim arraysplit

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 1
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, Amount, S7Client.S7WLBit, Buffer)

        Start = "0.0"
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 0
        result2 = Client.WriteArea(S7Client.S7AreaDB, 3, Start, Amount, S7Client.S7WLBit, Buffer)
        ToolStripStatusLabel1.Text = " Modo Manual ativado"

        If Result = 0 & result2 = 0 Then
            ToolStripStatusLabel1.Text = " Modo Automático ativado"
        End If

    End Sub


    '-----------------------START MODO AUTO----------------------- 
    Private Sub Btstart_Click(sender As Object, e As EventArgs) Handles btstart.Click

        Dim Start = "0.3"
        Dim Result
        Dim arraysplit

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Buffer(0) = 1
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)
        If Result = 0 Then
            ToolStripStatusLabel1.Text = "Modo Automático ligado e iniciado"
        End If
    End Sub




    '------------------TIMER 1 lEITURA POSIÇAO OBJETO---------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Ler se está a detetar Q226
        Dim Area = 132 ' Hex(81) em decimal
        Dim DBNumber = 12
        Dim Amount As Int32 = 1
        Dim Wordlen = S7Client.S7WLWord
        Dim Result



        'Objeto detetado
        Buffer(0) = 0
        Result = Client.ReadArea(Area, DBNumber, 45, Amount, S7Client.S7WLByte, Buffer)
        If Result = 0 Then
            Try
                Select Case Buffer(0)
                    Case 9
                        tbObjeto.Text = "Empty"
                    Case 2
                        tbObjeto.Text = "Copo"
                    Case 3
                        tbObjeto.Text = "Garfo"
                    Case 4
                        tbObjeto.Text = "Prato"
                    Case 5
                        tbObjeto.Text = "Faca"
                    Case 6
                        tbObjeto.Text = "Tabuleiro"
                End Select

            Catch
                ToolStripStatusLabel1.Text = "Not able To read Object"
            End Try
        End If
        'Location X
        Buffer(0) = 0
        Result = Client.ReadArea(Area, DBNumber, 60, Amount, Wordlen, Buffer)

        If Result = 0 Then

            Try
                TbXlocation.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To determine X Location"
            End Try
        End If
        'Location Y
        Buffer(0) = 0
        Buffer(1) = 0
        Result = Client.ReadArea(Area, DBNumber, 76, Amount, Wordlen, Buffer)

        If Result = 0 Then
            Try
                tbYlocation.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To determine Y Location"
            End Try
        End If


        'Location Z
        Buffer(0) = 0
        Buffer(1) = 0
        Result = Client.ReadArea(Area, DBNumber, 92, Amount, Wordlen, Buffer)

        If Result = 0 Then
            Try
                tbZlocation.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To determine Z Location"
            End Try
        End If

    End Sub


    '------------------TIMER 2 monitorização de velocidade/posição/forcas--------------------
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim Area = 132 ' Hex(84) em decimal
        Dim DBNumber = 12
        Dim Amount As Int32 = 1
        Dim Wordlen = S7Client.S7WLReal
        Dim Result

        'Result = Client.ReadArea(Area, DBnumber, Start, Amount, Wordlen, Buffer)

        'UR_X
        'Pos
        Result = Client.ReadArea(Area, DBNumber, 106, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURPosX.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_X Position"
            End Try
        End If

        'velocity
        Result = Client.ReadArea(Area, DBNumber, 110, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURVelX.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_X Velocity"
            End Try
        End If

        'Force
        Result = Client.ReadArea(Area, DBNumber, 114, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURForceX.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_X Force"
            End Try
        End If


        'UR_Y
        'Pos
        Result = Client.ReadArea(Area, DBNumber, 118, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURPosY.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Y Position"
            End Try
        End If

        'velocity
        Result = Client.ReadArea(Area, DBNumber, 122, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURVelY.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Y Velocity"
            End Try
        End If

        'Force
        Result = Client.ReadArea(Area, DBNumber, 126, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURForceY.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Y Force"
            End Try
        End If

        'UR_Z
        'Pos
        Result = Client.ReadArea(Area, DBNumber, 130, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURPosZ.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Z Position"
            End Try
        End If

        'velocity
        Result = Client.ReadArea(Area, DBNumber, 134, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURVelZ.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Z Velocity"
            End Try
        End If

        'Force
        Result = Client.ReadArea(Area, DBNumber, 138, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURForceZ.Text = Buffer(0)

            Catch
                ToolStripStatusLabel1.Text = "Not able To read UR_Z Force"
            End Try
        End If




    End Sub

    '------------------Timer 4 Contadores-----------------------
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim Area = 28 ' Hex(1C) em decimal
        Dim Amount As Int32 = 1
        Dim Wordlen = S7Client.S7WLWord
        Dim Result

        'Result = Client.ReadArea(Area, DBnumber, Start, Amount, Wordlen, Buffer)

        'Counter Copos
        Result = Client.ReadArea(Area, 11, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURncopos.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number Of copos collected"
            End Try
        End If

        'Counter facas
        Result = Client.ReadArea(Area, 10, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURnfacas.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number Of facas collected"
            End Try
        End If

        'Counter garfos
        Result = Client.ReadArea(Area, 9, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURngarfos.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number Of garfos collected"
            End Try
        End If

        'Counter peças totais
        Result = Client.ReadArea(Area, 7, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURnobjetos.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number o items collected"
            End Try
        End If

        'Counter tabueleiros
        Result = Client.ReadArea(Area, 8, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURntabuleiros.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number Of tabuleiros collected"
            End Try
        End If

        'Counter pratos
        Result = Client.ReadArea(Area, 13, 4, Amount, Wordlen, Buffer)
        If Result = 0 Then
            Try
                tbURnpratos.Text = Buffer(0)
            Catch
                ToolStripStatusLabel1.Text = "Not able To read number Of Pratos collected"
            End Try
        End If


    End Sub

    '------------------Timer 5 Horas-------------------------------
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub


    '-----------------------Ativar MODO MANUAL-----------------------
    Private Sub Btmodomanual_Click(sender As Object, e As EventArgs) Handles btmodomanual.Click

        Dim Area = S7Client.S7AreaDB ' Hex(81) em decimal
        Dim Start = "0.0"
        Dim Amount As Int32 = 1
        Dim Wordlen = S7Client.S7WLBit
        Dim Result
        Dim result2
        Dim arraysplit

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 1
        Result = Client.WriteArea(Area, 3, Start - 1, Amount, Wordlen, Buffer)

        Start = "0.1"
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 0
        result2 = Client.WriteArea(Area, 3, Start, Amount, Wordlen, Buffer)
        If Result = 0 & result2 = 0 Then
            ToolStripStatusLabel1.Text = " Modo Manual ativado"
        End If

    End Sub



    '----------------------- Ativar Esteira-----------------------
    Private Sub BtEsteiraStart_Click(sender As Object, e As EventArgs) Handles btEsteiraStart.Click
        Dim Start = "0.2"
        Dim Result
        Dim arraysplit
      
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Buffer(0) = 1
        'Result = Client.ReadArea(Area, DBNumber, Start, Amount, Wordlen, Buffer)
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)

        If Result = 0 Then
            ToolStripStatusLabel1.Text = "Esteira On"
            Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)
        End If

    End Sub

    '-----------------------Desligar esteira-----------------------
    Private Sub BtEsteiraStop_Click(sender As Object, e As EventArgs) Handles btEsteiraStop.Click
        Dim Start = "0.2"
        Dim arraysplit
        Dim Result

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Buffer(0) = 0
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)

        If Result = 0 Then
            ToolStripStatusLabel1.Text = "Esteira OFF"
            Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)
        End If
    End Sub




    '------------------READ ALL ATRAVÉS DE CHAVE-------------
    Private Sub btReadALL_Click(sender As Object, e As EventArgs) Handles btReadALL.Click
        Dim Area
        Dim DBNumber
        Dim Start
        Dim startbit
        Dim Amount
        Dim Wordlen
        Dim Result
        Dim arraysplit

        arraysplit = Split(tbRead.Text, ".")
        Area = arraysplit(0)
        DBNumber = arraysplit(1)
        Start = arraysplit(2)
        Amount = arraysplit(3)

        Select Case arraysplit(4)
            Case 1
                Wordlen = S7Client.S7WLBit
                startbit = Split(Start, ":")
                Start = CInt(startbit(0)) * 8 + CInt(startbit(1))
            Case 2
                Wordlen = S7Client.S7WLByte
            Case 4
                Wordlen = S7Client.S7WLWord
            Case 6
                Wordlen = S7Client.S7WLDWord
            Case 8
                Wordlen = S7Client.S7WLReal
            Case 28
                Wordlen = S7Client.S7WLCounter
            Case 29
                Wordlen = S7Client.S7WLTimer
            Case Else
                Return
        End Select

        Result = Client.WriteArea(Area, 3, Start - 1, Amount, Wordlen, Buffer)
        If Result = 0 Then
            tbreading.Text = tbreading.Text + vbCrLf + Buffer(Amount - 1)
        End If


    End Sub


    '------------------Ativação das ventosas------------------------
    Private Sub btVentosaOn_Click(sender As Object, e As EventArgs) Handles btVentosaOn.Click
        Dim Start = "0.4"
        Dim Result
        Dim arraysplit
        Dim result2

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Buffer(0) = 1
        'Result = Client.ReadArea(Area, DBNumber, Start, Amount, Wordlen, Buffer)
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)


        Start = "0.5"
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 0
        result2 = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)

        If Result = 0 & result2 = 0 Then
            ToolStripStatusLabel1.Text = "Ventosa On"
        End If


    End Sub

    '------------------Desligar as ventosas------------------------
    Private Sub btVentosaOff_Click(sender As Object, e As EventArgs) Handles btVentosaOff.Click
        Dim Start = "0.5"
        Dim Result
        Dim arraysplit
        Dim result2

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Buffer(0) = 1
        'Result = Client.ReadArea(Area, DBNumber, Start, Amount, Wordlen, Buffer)
        Result = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)


        Start = "0.4"
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))
        Buffer(0) = 0
        result2 = Client.WriteArea(S7Client.S7AreaDB, 3, Start, 1, S7Client.S7WLBit, Buffer)

        If Result = 0 & result2 = 0 Then
            ToolStripStatusLabel1.Text = "Ventosa Off"
        End If
    End Sub
    '------------------------Timer alarmes------------------------------
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Start = "401.3"
        Dim Result
        Dim arraysplit
        Dim result2

        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        Result = Client.ReadArea(131, 0, Start, 1, S7Client.S7WLBit, Buffer)

        If Result = 0 & Buffer(0) = 1 Then
            If alarme = 0 Then
                tbAlarms.Text = tbAlarms.Text + vbCrLf + Now.ToString("HH:mm:ss") + " |Paragem de emergência aplicado pela consola |"
                alarme = 1
            End If
        End If

        If Result = 0 & Buffer(0) = 0 Then
            If alarme = 1 Then
                alarme = 0
            End If
        End If

        '........................................................

        Start = "401.4"
        arraysplit = Split(Start, ".")
        Start = CInt(arraysplit(0)) * 8 + CInt(arraysplit(1))

        result2 = Client.ReadArea(131, 0, Start, 1, S7Client.S7WLBit, Buffer)


        If Result = 0 & Buffer(0) = 1 Then
            If alarme2 = 0 Then
                tbAlarms.Text = tbAlarms.Text + vbCrLf + Now.ToString("HH:mm:ss") + " |Paragem de emergência aplicado pelo Operador |"
                alarme2 = 1
            End If

        End If

        If Result = 0 & Buffer(0) = 0 Then
            If alarme2 = 1 Then
                alarme2 = 0
            End If
        End If

    End Sub
End Class



