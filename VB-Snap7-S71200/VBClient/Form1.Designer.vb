<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSlot = New System.Windows.Forms.TextBox()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.DisconnectBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_PLC_Status = New System.Windows.Forms.Button()
        Me.Txt_PLC_Status = New System.Windows.Forms.TextBox()
        Me.Btn_Run = New System.Windows.Forms.Button()
        Me.Btn_Stop = New System.Windows.Forms.Button()
        Me.BtmodoAutomatico = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btEsteiraStart = New System.Windows.Forms.Button()
        Me.btEsteiraStop = New System.Windows.Forms.Button()
        Me.btmodomanual = New System.Windows.Forms.Button()
        Me.TabCtrl_Option = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.tbURPosZ = New System.Windows.Forms.TextBox()
        Me.tbURPosY = New System.Windows.Forms.TextBox()
        Me.tbURPosX = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.tbURVelZ = New System.Windows.Forms.TextBox()
        Me.tbURVelY = New System.Windows.Forms.TextBox()
        Me.tbURVelX = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tbURForceX = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.tbURForceY = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.tbURForceZ = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tbURnobjetos = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbURncopos = New System.Windows.Forms.TextBox()
        Me.tbURntabuleiros = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.tbURnpratos = New System.Windows.Forms.TextBox()
        Me.tbURnfacas = New System.Windows.Forms.TextBox()
        Me.tbURngarfos = New System.Windows.Forms.TextBox()
        Me.btstart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TbXlocation = New System.Windows.Forms.TextBox()
        Me.tbYlocation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbObjeto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbZlocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btVentosaOn = New System.Windows.Forms.Button()
        Me.btVentosaOff = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel_PosActual_Man = New System.Windows.Forms.Panel()
        Me.label125 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btReadALL = New System.Windows.Forms.Button()
        Me.tbreading = New System.Windows.Forms.TextBox()
        Me.tbRead = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.tbAlarms = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.TabCtrl_Option.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel_PosActual_Man.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(28, 32)
        Me.TxtIP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(97, 22)
        Me.TxtIP.TabIndex = 1
        Me.TxtIP.Text = "192.168.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rack"
        '
        'TxtRack
        '
        Me.TxtRack.Location = New System.Drawing.Point(151, 32)
        Me.TxtRack.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRack.Name = "TxtRack"
        Me.TxtRack.Size = New System.Drawing.Size(57, 22)
        Me.TxtRack.TabIndex = 2
        Me.TxtRack.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Slot"
        '
        'TxtSlot
        '
        Me.TxtSlot.Location = New System.Drawing.Point(225, 32)
        Me.TxtSlot.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSlot.Name = "TxtSlot"
        Me.TxtSlot.Size = New System.Drawing.Size(57, 22)
        Me.TxtSlot.TabIndex = 3
        Me.TxtSlot.Text = "0"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectBtn.Location = New System.Drawing.Point(28, 94)
        Me.ConnectBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(146, 57)
        Me.ConnectBtn.TabIndex = 4
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Enabled = False
        Me.DisconnectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisconnectBtn.Location = New System.Drawing.Point(199, 94)
        Me.DisconnectBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(146, 57)
        Me.DisconnectBtn.TabIndex = 8
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "S71200/1500"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Rack=0, Slot=0"
        '
        'Btn_PLC_Status
        '
        Me.Btn_PLC_Status.Enabled = False
        Me.Btn_PLC_Status.Location = New System.Drawing.Point(28, 175)
        Me.Btn_PLC_Status.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_PLC_Status.Name = "Btn_PLC_Status"
        Me.Btn_PLC_Status.Size = New System.Drawing.Size(146, 39)
        Me.Btn_PLC_Status.TabIndex = 28
        Me.Btn_PLC_Status.Text = "PLC Status"
        Me.Btn_PLC_Status.UseVisualStyleBackColor = True
        '
        'Txt_PLC_Status
        '
        Me.Txt_PLC_Status.Location = New System.Drawing.Point(199, 175)
        Me.Txt_PLC_Status.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_PLC_Status.Multiline = True
        Me.Txt_PLC_Status.Name = "Txt_PLC_Status"
        Me.Txt_PLC_Status.Size = New System.Drawing.Size(146, 39)
        Me.Txt_PLC_Status.TabIndex = 29
        '
        'Btn_Run
        '
        Me.Btn_Run.Enabled = False
        Me.Btn_Run.Location = New System.Drawing.Point(18, 110)
        Me.Btn_Run.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Run.Name = "Btn_Run"
        Me.Btn_Run.Size = New System.Drawing.Size(129, 40)
        Me.Btn_Run.TabIndex = 33
        Me.Btn_Run.Text = "PLC Run"
        Me.Btn_Run.UseVisualStyleBackColor = True
        '
        'Btn_Stop
        '
        Me.Btn_Stop.Enabled = False
        Me.Btn_Stop.Location = New System.Drawing.Point(155, 110)
        Me.Btn_Stop.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(129, 40)
        Me.Btn_Stop.TabIndex = 34
        Me.Btn_Stop.Text = "PLC Stop"
        Me.Btn_Stop.UseVisualStyleBackColor = True
        '
        'BtmodoAutomatico
        '
        Me.BtmodoAutomatico.Enabled = False
        Me.BtmodoAutomatico.Location = New System.Drawing.Point(386, 60)
        Me.BtmodoAutomatico.Margin = New System.Windows.Forms.Padding(4)
        Me.BtmodoAutomatico.Name = "BtmodoAutomatico"
        Me.BtmodoAutomatico.Size = New System.Drawing.Size(129, 28)
        Me.BtmodoAutomatico.TabIndex = 35
        Me.BtmodoAutomatico.Text = "Automático"
        Me.BtmodoAutomatico.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btEsteiraStart
        '
        Me.btEsteiraStart.Enabled = False
        Me.btEsteiraStart.Location = New System.Drawing.Point(29, 36)
        Me.btEsteiraStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btEsteiraStart.Name = "btEsteiraStart"
        Me.btEsteiraStart.Size = New System.Drawing.Size(129, 47)
        Me.btEsteiraStart.TabIndex = 39
        Me.btEsteiraStart.Text = "Start "
        Me.btEsteiraStart.UseVisualStyleBackColor = True
        '
        'btEsteiraStop
        '
        Me.btEsteiraStop.Enabled = False
        Me.btEsteiraStop.Location = New System.Drawing.Point(176, 36)
        Me.btEsteiraStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btEsteiraStop.Name = "btEsteiraStop"
        Me.btEsteiraStop.Size = New System.Drawing.Size(129, 47)
        Me.btEsteiraStop.TabIndex = 42
        Me.btEsteiraStop.Text = "Stop "
        Me.btEsteiraStop.UseVisualStyleBackColor = True
        '
        'btmodomanual
        '
        Me.btmodomanual.Enabled = False
        Me.btmodomanual.Location = New System.Drawing.Point(406, 43)
        Me.btmodomanual.Margin = New System.Windows.Forms.Padding(4)
        Me.btmodomanual.Name = "btmodomanual"
        Me.btmodomanual.Size = New System.Drawing.Size(129, 28)
        Me.btmodomanual.TabIndex = 45
        Me.btmodomanual.Text = "Manual"
        Me.btmodomanual.UseVisualStyleBackColor = True
        '
        'TabCtrl_Option
        '
        Me.TabCtrl_Option.Controls.Add(Me.TabPage3)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage2)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage1)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage4)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage6)
        Me.TabCtrl_Option.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.TabCtrl_Option.ItemSize = New System.Drawing.Size(100, 50)
        Me.TabCtrl_Option.Location = New System.Drawing.Point(0, 27)
        Me.TabCtrl_Option.Margin = New System.Windows.Forms.Padding(0)
        Me.TabCtrl_Option.Multiline = True
        Me.TabCtrl_Option.Name = "TabCtrl_Option"
        Me.TabCtrl_Option.Padding = New System.Drawing.Point(0, 0)
        Me.TabCtrl_Option.SelectedIndex = 0
        Me.TabCtrl_Option.Size = New System.Drawing.Size(844, 511)
        Me.TabCtrl_Option.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabCtrl_Option.TabIndex = 65
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.ImageKey = "Programas.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 54)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage3.Size = New System.Drawing.Size(836, 453)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Configuração"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btn_Run)
        Me.Panel3.Controls.Add(Me.Btn_Stop)
        Me.Panel3.Location = New System.Drawing.Point(444, 119)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 232)
        Me.Panel3.TabIndex = 19
        '
        'Label25
        '
        Me.Label25.AllowDrop = True
        Me.Label25.BackColor = System.Drawing.Color.DarkGray
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(444, 94)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(346, 27)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "PLC Status"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Btn_PLC_Status)
        Me.Panel2.Controls.Add(Me.ConnectBtn)
        Me.Panel2.Controls.Add(Me.Txt_PLC_Status)
        Me.Panel2.Controls.Add(Me.DisconnectBtn)
        Me.Panel2.Controls.Add(Me.TxtIP)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtRack)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtSlot)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(26, 119)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 232)
        Me.Panel2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(26, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(394, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PLC Connection"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.tbURnobjetos)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.tbURncopos)
        Me.TabPage2.Controls.Add(Me.tbURntabuleiros)
        Me.TabPage2.Controls.Add(Me.Label62)
        Me.TabPage2.Controls.Add(Me.Label61)
        Me.TabPage2.Controls.Add(Me.Label51)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.Label57)
        Me.TabPage2.Controls.Add(Me.tbURnpratos)
        Me.TabPage2.Controls.Add(Me.tbURnfacas)
        Me.TabPage2.Controls.Add(Me.tbURngarfos)
        Me.TabPage2.Controls.Add(Me.btstart)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.BtmodoAutomatico)
        Me.TabPage2.ImageKey = "C:\Users\bbpei\OneDrive - Universidade de Aveiro\4ºAno\2ºSemestre\Projeto em Sist" &
    "emas de Automacao\VB-Snap7-S71200\VB-Snap7-S71200\imagens\Aut.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(836, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Automático"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label67)
        Me.Panel6.Controls.Add(Me.tbURPosZ)
        Me.Panel6.Controls.Add(Me.tbURPosY)
        Me.Panel6.Controls.Add(Me.tbURPosX)
        Me.Panel6.Controls.Add(Me.Label63)
        Me.Panel6.Controls.Add(Me.Label64)
        Me.Panel6.Controls.Add(Me.Label68)
        Me.Panel6.Controls.Add(Me.Label65)
        Me.Panel6.Controls.Add(Me.Label66)
        Me.Panel6.Controls.Add(Me.tbURVelZ)
        Me.Panel6.Controls.Add(Me.tbURVelY)
        Me.Panel6.Controls.Add(Me.tbURVelX)
        Me.Panel6.Controls.Add(Me.Label44)
        Me.Panel6.Controls.Add(Me.Label41)
        Me.Panel6.Controls.Add(Me.Label40)
        Me.Panel6.Controls.Add(Me.tbURForceX)
        Me.Panel6.Controls.Add(Me.Label52)
        Me.Panel6.Controls.Add(Me.tbURForceY)
        Me.Panel6.Controls.Add(Me.Label50)
        Me.Panel6.Controls.Add(Me.tbURForceZ)
        Me.Panel6.Controls.Add(Me.Label49)
        Me.Panel6.Location = New System.Drawing.Point(13, 256)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(592, 184)
        Me.Panel6.TabIndex = 110
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label67.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label67.Location = New System.Drawing.Point(107, 45)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(36, 17)
        Me.Label67.TabIndex = 97
        Me.Label67.Text = "(mm)"
        '
        'tbURPosZ
        '
        Me.tbURPosZ.Location = New System.Drawing.Point(88, 125)
        Me.tbURPosZ.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURPosZ.Name = "tbURPosZ"
        Me.tbURPosZ.Size = New System.Drawing.Size(74, 22)
        Me.tbURPosZ.TabIndex = 104
        '
        'tbURPosY
        '
        Me.tbURPosY.Location = New System.Drawing.Point(88, 95)
        Me.tbURPosY.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURPosY.Name = "tbURPosY"
        Me.tbURPosY.Size = New System.Drawing.Size(74, 22)
        Me.tbURPosY.TabIndex = 101
        '
        'tbURPosX
        '
        Me.tbURPosX.Location = New System.Drawing.Point(88, 64)
        Me.tbURPosX.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURPosX.Name = "tbURPosX"
        Me.tbURPosX.Size = New System.Drawing.Size(74, 22)
        Me.tbURPosX.TabIndex = 99
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label63.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label63.Location = New System.Drawing.Point(527, 45)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(24, 17)
        Me.Label63.TabIndex = 95
        Me.Label63.Text = "(N)"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label64.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label64.Location = New System.Drawing.Point(341, 45)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(35, 17)
        Me.Label64.TabIndex = 106
        Me.Label64.Text = "(m/s)"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label68.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label68.Location = New System.Drawing.Point(5, 65)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(59, 17)
        Me.Label68.TabIndex = 96
        Me.Label68.Text = "Posição X"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label65.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label65.Location = New System.Drawing.Point(5, 126)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(57, 17)
        Me.Label65.TabIndex = 100
        Me.Label65.Text = "Posição Z"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label66.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label66.Location = New System.Drawing.Point(5, 96)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(59, 17)
        Me.Label66.TabIndex = 98
        Me.Label66.Text = "Posição Y"
        '
        'tbURVelZ
        '
        Me.tbURVelZ.Location = New System.Drawing.Point(318, 125)
        Me.tbURVelZ.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURVelZ.Name = "tbURVelZ"
        Me.tbURVelZ.Size = New System.Drawing.Size(74, 22)
        Me.tbURVelZ.TabIndex = 70
        '
        'tbURVelY
        '
        Me.tbURVelY.Location = New System.Drawing.Point(318, 95)
        Me.tbURVelY.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURVelY.Name = "tbURVelY"
        Me.tbURVelY.Size = New System.Drawing.Size(74, 22)
        Me.tbURVelY.TabIndex = 67
        '
        'tbURVelX
        '
        Me.tbURVelX.Location = New System.Drawing.Point(318, 64)
        Me.tbURVelX.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURVelX.Name = "tbURVelX"
        Me.tbURVelX.Size = New System.Drawing.Size(74, 22)
        Me.tbURVelX.TabIndex = 65
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label44.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label44.Location = New System.Drawing.Point(232, 66)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(72, 17)
        Me.Label44.TabIndex = 62
        Me.Label44.Text = "Velocidade X"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(232, 97)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 17)
        Me.Label41.TabIndex = 64
        Me.Label41.Text = "Velocidade Y"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(232, 127)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(70, 17)
        Me.Label40.TabIndex = 66
        Me.Label40.Text = "Velocidade Z"
        '
        'tbURForceX
        '
        Me.tbURForceX.Location = New System.Drawing.Point(507, 63)
        Me.tbURForceX.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURForceX.Name = "tbURForceX"
        Me.tbURForceX.Size = New System.Drawing.Size(74, 22)
        Me.tbURForceX.TabIndex = 75
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label52.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label52.Location = New System.Drawing.Point(443, 63)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(48, 17)
        Me.Label52.TabIndex = 72
        Me.Label52.Text = "Força X"
        '
        'tbURForceY
        '
        Me.tbURForceY.Location = New System.Drawing.Point(507, 94)
        Me.tbURForceY.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURForceY.Name = "tbURForceY"
        Me.tbURForceY.Size = New System.Drawing.Size(74, 22)
        Me.tbURForceY.TabIndex = 77
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(443, 94)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(48, 17)
        Me.Label50.TabIndex = 74
        Me.Label50.Text = "Força Y"
        '
        'tbURForceZ
        '
        Me.tbURForceZ.Location = New System.Drawing.Point(507, 124)
        Me.tbURForceZ.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURForceZ.Name = "tbURForceZ"
        Me.tbURForceZ.Size = New System.Drawing.Size(74, 22)
        Me.tbURForceZ.TabIndex = 80
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label49.Location = New System.Drawing.Point(443, 124)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(46, 17)
        Me.Label49.TabIndex = 76
        Me.Label49.Text = "Força Z"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label42.Location = New System.Drawing.Point(618, 60)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(60, 17)
        Me.Label42.TabIndex = 107
        Me.Label42.Text = "Nº Objetos"
        '
        'tbURnobjetos
        '
        Me.tbURnobjetos.Location = New System.Drawing.Point(716, 60)
        Me.tbURnobjetos.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURnobjetos.Name = "tbURnobjetos"
        Me.tbURnobjetos.Size = New System.Drawing.Size(74, 22)
        Me.tbURnobjetos.TabIndex = 108
        '
        'Label28
        '
        Me.Label28.AllowDrop = True
        Me.Label28.BackColor = System.Drawing.Color.DarkGray
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label28.Location = New System.Drawing.Point(13, 231)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(592, 27)
        Me.Label28.TabIndex = 109
        Me.Label28.Text = "Informação Robot"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbURncopos
        '
        Me.tbURncopos.Location = New System.Drawing.Point(716, 174)
        Me.tbURncopos.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURncopos.Name = "tbURncopos"
        Me.tbURncopos.Size = New System.Drawing.Size(74, 22)
        Me.tbURncopos.TabIndex = 93
        '
        'tbURntabuleiros
        '
        Me.tbURntabuleiros.Location = New System.Drawing.Point(716, 205)
        Me.tbURntabuleiros.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURntabuleiros.Name = "tbURntabuleiros"
        Me.tbURntabuleiros.Size = New System.Drawing.Size(74, 22)
        Me.tbURntabuleiros.TabIndex = 94
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label62.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label62.Location = New System.Drawing.Point(619, 205)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(74, 17)
        Me.Label62.TabIndex = 92
        Me.Label62.Text = "Nº Tabuleiros"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label61.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label61.Location = New System.Drawing.Point(618, 176)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(55, 17)
        Me.Label61.TabIndex = 91
        Me.Label61.Text = "Nº Copos"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label51.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label51.Location = New System.Drawing.Point(618, 147)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(56, 17)
        Me.Label51.TabIndex = 85
        Me.Label51.Text = "Nº Garfos"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label56.Location = New System.Drawing.Point(618, 117)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(54, 17)
        Me.Label56.TabIndex = 83
        Me.Label56.Text = "Nº Facas"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label57.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label57.Location = New System.Drawing.Point(618, 86)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(55, 17)
        Me.Label57.TabIndex = 82
        Me.Label57.Text = "Nº Pratos"
        '
        'tbURnpratos
        '
        Me.tbURnpratos.Location = New System.Drawing.Point(716, 86)
        Me.tbURnpratos.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURnpratos.Name = "tbURnpratos"
        Me.tbURnpratos.Size = New System.Drawing.Size(74, 22)
        Me.tbURnpratos.TabIndex = 84
        '
        'tbURnfacas
        '
        Me.tbURnfacas.Location = New System.Drawing.Point(716, 117)
        Me.tbURnfacas.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURnfacas.Name = "tbURnfacas"
        Me.tbURnfacas.Size = New System.Drawing.Size(74, 22)
        Me.tbURnfacas.TabIndex = 86
        '
        'tbURngarfos
        '
        Me.tbURngarfos.Location = New System.Drawing.Point(716, 147)
        Me.tbURngarfos.Margin = New System.Windows.Forms.Padding(2)
        Me.tbURngarfos.Name = "tbURngarfos"
        Me.tbURngarfos.Size = New System.Drawing.Size(74, 22)
        Me.tbURngarfos.TabIndex = 89
        '
        'btstart
        '
        Me.btstart.Enabled = False
        Me.btstart.Location = New System.Drawing.Point(386, 102)
        Me.btstart.Margin = New System.Windows.Forms.Padding(4)
        Me.btstart.Name = "btstart"
        Me.btstart.Size = New System.Drawing.Size(129, 28)
        Me.btstart.TabIndex = 36
        Me.btstart.Text = "Start"
        Me.btstart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TbXlocation)
        Me.Panel1.Controls.Add(Me.tbYlocation)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbObjeto)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbZlocation)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(13, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 184)
        Me.Panel1.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(15, 149)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 17)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "PosZ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(15, 119)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 17)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "PosY"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label21.Location = New System.Drawing.Point(203, 62)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 17)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "(mm)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label22.Location = New System.Drawing.Point(15, 88)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 17)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "PosX"
        '
        'TbXlocation
        '
        Me.TbXlocation.Location = New System.Drawing.Point(185, 88)
        Me.TbXlocation.Margin = New System.Windows.Forms.Padding(2)
        Me.TbXlocation.Name = "TbXlocation"
        Me.TbXlocation.Size = New System.Drawing.Size(74, 22)
        Me.TbXlocation.TabIndex = 50
        '
        'tbYlocation
        '
        Me.tbYlocation.Location = New System.Drawing.Point(185, 119)
        Me.tbYlocation.Margin = New System.Windows.Forms.Padding(2)
        Me.tbYlocation.Name = "tbYlocation"
        Me.tbYlocation.Size = New System.Drawing.Size(74, 22)
        Me.tbYlocation.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(270, 155)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "IB513/514"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "IB508"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(270, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "IB509/510"
        '
        'tbObjeto
        '
        Me.tbObjeto.Location = New System.Drawing.Point(185, 16)
        Me.tbObjeto.Margin = New System.Windows.Forms.Padding(2)
        Me.tbObjeto.Name = "tbObjeto"
        Me.tbObjeto.Size = New System.Drawing.Size(74, 22)
        Me.tbObjeto.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 125)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "IB511/512"
        '
        'tbZlocation
        '
        Me.tbZlocation.Location = New System.Drawing.Point(185, 149)
        Me.tbZlocation.Margin = New System.Windows.Forms.Padding(2)
        Me.tbZlocation.Name = "tbZlocation"
        Me.tbZlocation.Size = New System.Drawing.Size(74, 22)
        Me.tbZlocation.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Objeto"
        '
        'Label23
        '
        Me.Label23.AllowDrop = True
        Me.Label23.BackColor = System.Drawing.Color.DarkGray
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label23.Location = New System.Drawing.Point(13, 18)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(346, 27)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Informação Objeto"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Label45)
        Me.TabPage1.Controls.Add(Me.Panel_PosActual_Man)
        Me.TabPage1.Controls.Add(Me.label125)
        Me.TabPage1.Controls.Add(Me.btmodomanual)
        Me.TabPage1.ImageKey = "man1.png"
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(836, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manual"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btVentosaOn)
        Me.Panel5.Controls.Add(Me.btVentosaOff)
        Me.Panel5.Location = New System.Drawing.Point(13, 226)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(346, 138)
        Me.Panel5.TabIndex = 46
        '
        'btVentosaOn
        '
        Me.btVentosaOn.Enabled = False
        Me.btVentosaOn.Location = New System.Drawing.Point(29, 36)
        Me.btVentosaOn.Margin = New System.Windows.Forms.Padding(4)
        Me.btVentosaOn.Name = "btVentosaOn"
        Me.btVentosaOn.Size = New System.Drawing.Size(129, 47)
        Me.btVentosaOn.TabIndex = 39
        Me.btVentosaOn.Text = "ON"
        Me.btVentosaOn.UseVisualStyleBackColor = True
        '
        'btVentosaOff
        '
        Me.btVentosaOff.Enabled = False
        Me.btVentosaOff.Location = New System.Drawing.Point(176, 36)
        Me.btVentosaOff.Margin = New System.Windows.Forms.Padding(4)
        Me.btVentosaOff.Name = "btVentosaOff"
        Me.btVentosaOff.Size = New System.Drawing.Size(129, 47)
        Me.btVentosaOff.TabIndex = 42
        Me.btVentosaOff.Text = "OFF"
        Me.btVentosaOff.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AllowDrop = True
        Me.Label45.BackColor = System.Drawing.Color.DarkGray
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(13, 201)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(346, 27)
        Me.Label45.TabIndex = 47
        Me.Label45.Text = "Ativação das Ventosas"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_PosActual_Man
        '
        Me.Panel_PosActual_Man.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_PosActual_Man.Controls.Add(Me.btEsteiraStart)
        Me.Panel_PosActual_Man.Controls.Add(Me.btEsteiraStop)
        Me.Panel_PosActual_Man.Location = New System.Drawing.Point(13, 43)
        Me.Panel_PosActual_Man.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_PosActual_Man.Name = "Panel_PosActual_Man"
        Me.Panel_PosActual_Man.Size = New System.Drawing.Size(346, 138)
        Me.Panel_PosActual_Man.TabIndex = 0
        '
        'label125
        '
        Me.label125.AllowDrop = True
        Me.label125.BackColor = System.Drawing.Color.DarkGray
        Me.label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label125.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label125.Location = New System.Drawing.Point(13, 18)
        Me.label125.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label125.Name = "label125"
        Me.label125.Size = New System.Drawing.Size(346, 27)
        Me.label125.TabIndex = 4
        Me.label125.Text = "Ativação da esteira"
        Me.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.LightGray
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.ImageKey = "Tabelas.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 54)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(836, 453)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ler Memórias"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btReadALL)
        Me.Panel4.Controls.Add(Me.tbreading)
        Me.Panel4.Controls.Add(Me.tbRead)
        Me.Panel4.Location = New System.Drawing.Point(8, 41)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 326)
        Me.Panel4.TabIndex = 113
        '
        'btReadALL
        '
        Me.btReadALL.Location = New System.Drawing.Point(37, 44)
        Me.btReadALL.Margin = New System.Windows.Forms.Padding(4)
        Me.btReadALL.Name = "btReadALL"
        Me.btReadALL.Size = New System.Drawing.Size(92, 24)
        Me.btReadALL.TabIndex = 115
        Me.btReadALL.Text = "Ler"
        Me.btReadALL.UseVisualStyleBackColor = True
        '
        'tbreading
        '
        Me.tbreading.Location = New System.Drawing.Point(291, 46)
        Me.tbreading.Margin = New System.Windows.Forms.Padding(2)
        Me.tbreading.Multiline = True
        Me.tbreading.Name = "tbreading"
        Me.tbreading.Size = New System.Drawing.Size(201, 252)
        Me.tbreading.TabIndex = 46
        '
        'tbRead
        '
        Me.tbRead.Location = New System.Drawing.Point(147, 45)
        Me.tbRead.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRead.Name = "tbRead"
        Me.tbRead.Size = New System.Drawing.Size(111, 22)
        Me.tbRead.TabIndex = 85
        '
        'Label46
        '
        Me.Label46.AllowDrop = True
        Me.Label46.BackColor = System.Drawing.Color.DarkGray
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(8, 16)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(568, 27)
        Me.Label46.TabIndex = 114
        Me.Label46.Text = "PLC Reading"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 66
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.LightGray
        Me.TabPage6.Controls.Add(Me.tbAlarms)
        Me.TabPage6.ImageKey = "Avisos2.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 54)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Size = New System.Drawing.Size(836, 453)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Alarmes"
        '
        'tbAlarms
        '
        Me.tbAlarms.Location = New System.Drawing.Point(71, 59)
        Me.tbAlarms.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAlarms.Multiline = True
        Me.tbAlarms.Name = "tbAlarms"
        Me.tbAlarms.Size = New System.Drawing.Size(645, 326)
        Me.tbAlarms.TabIndex = 30
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.LightGray
        Me.TabPage5.ImageKey = "Parametros.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 54)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(1032, 702)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Lista de Memórias"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(847, 26)
        Me.StatusStrip1.TabIndex = 66
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Timer5
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 566)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabCtrl_Option)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "SNAP7 - Demo 27.03.2017"
        Me.TabCtrl_Option.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel_PosActual_Man.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtRack As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSlot As System.Windows.Forms.TextBox
    Friend WithEvents ConnectBtn As System.Windows.Forms.Button
    Friend WithEvents DisconnectBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_PLC_Status As System.Windows.Forms.Button
    Friend WithEvents Txt_PLC_Status As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Run As System.Windows.Forms.Button
    Friend WithEvents Btn_Stop As System.Windows.Forms.Button
    Friend WithEvents BtmodoAutomatico As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btEsteiraStart As System.Windows.Forms.Button
    Friend WithEvents btEsteiraStop As System.Windows.Forms.Button
    Friend WithEvents btmodomanual As Button
    Private WithEvents TabCtrl_Option As TabControl
    Private WithEvents TabPage1 As TabPage
    Friend WithEvents Panel_PosActual_Man As Panel
    Friend WithEvents label125 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    'Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents btstart As Button
    Private WithEvents Label40 As Label
    Private WithEvents Label41 As Label
    Private WithEvents Label44 As Label
    Friend WithEvents tbURVelX As TextBox
    Friend WithEvents tbURVelY As TextBox
    Friend WithEvents tbURVelZ As TextBox
    Private WithEvents Label51 As Label
    Private WithEvents Label56 As Label
    Private WithEvents Label57 As Label
    Friend WithEvents tbURnpratos As TextBox
    Friend WithEvents tbURnfacas As TextBox
    Friend WithEvents tbURngarfos As TextBox
    Private WithEvents Label49 As Label
    Private WithEvents Label50 As Label
    Private WithEvents Label52 As Label
    Friend WithEvents tbURForceX As TextBox
    Friend WithEvents tbURForceY As TextBox
    Friend WithEvents tbURForceZ As TextBox
    Friend WithEvents tbURncopos As TextBox
    Friend WithEvents tbURntabuleiros As TextBox
    Private WithEvents Label62 As Label
    Private WithEvents Label61 As Label
    Friend WithEvents Timer2 As Timer
    Private WithEvents Label64 As Label
    Private WithEvents Label65 As Label
    Private WithEvents Label66 As Label
    Private WithEvents Label67 As Label
    Private WithEvents Label68 As Label
    Friend WithEvents tbURPosX As TextBox
    Friend WithEvents tbURPosY As TextBox
    Friend WithEvents tbURPosZ As TextBox
    Private WithEvents Label63 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Private WithEvents Label42 As Label
    Friend WithEvents tbURnobjetos As TextBox
    Friend WithEvents btReadALL As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btVentosaOn As Button
    Friend WithEvents btVentosaOff As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer5 As Timer
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbreading As TextBox
    Friend WithEvents tbRead As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents Label19 As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label22 As Label
    Friend WithEvents TbXlocation As TextBox
    Friend WithEvents tbYlocation As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbObjeto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbZlocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tbAlarms As TextBox
End Class
