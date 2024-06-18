<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabCtrl_Option = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel_PosActual_Man = New System.Windows.Forms.Panel()
        Me.txt_ManPosY = New System.Windows.Forms.TextBox()
        Me.txt_ManPosZ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label122 = New System.Windows.Forms.Label()
        Me.txt_ManPosX = New System.Windows.Forms.TextBox()
        Me.label131 = New System.Windows.Forms.Label()
        Me.label125 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Bt_Envio = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Bt_Config_Porta = New System.Windows.Forms.Button()
        Me.Bt_Iniciar_Com = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_envio = New System.Windows.Forms.TextBox()
        Me.cb_altura = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_velocidade_avanco = New System.Windows.Forms.ComboBox()
        Me.CB_pontencia_laser = New System.Windows.Forms.ComboBox()
        Me.bt_paragem = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.Button_Generate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.label_starting_point = New System.Windows.Forms.Label()
        Me.label_font_size_input = New System.Windows.Forms.Label()
        Me.label_text_input = New System.Windows.Forms.Label()
        Me.txt_starting_point = New System.Windows.Forms.TextBox()
        Me.TextBox_text_input = New System.Windows.Forms.TextBox()
        Me.bt_limpar = New System.Windows.Forms.Button()
        Me.TabCtrl_Option.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel_PosActual_Man.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCtrl_Option
        '
        Me.TabCtrl_Option.Controls.Add(Me.TabPage1)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage2)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage3)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage4)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage5)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage6)
        Me.TabCtrl_Option.Controls.Add(Me.TabPage7)
        Me.TabCtrl_Option.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.TabCtrl_Option.ItemSize = New System.Drawing.Size(100, 50)
        Me.TabCtrl_Option.Location = New System.Drawing.Point(47, 9)
        Me.TabCtrl_Option.Margin = New System.Windows.Forms.Padding(0)
        Me.TabCtrl_Option.Multiline = True
        Me.TabCtrl_Option.Name = "TabCtrl_Option"
        Me.TabCtrl_Option.Padding = New System.Drawing.Point(0, 0)
        Me.TabCtrl_Option.SelectedIndex = 0
        Me.TabCtrl_Option.Size = New System.Drawing.Size(1239, 760)
        Me.TabCtrl_Option.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabCtrl_Option.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.Panel_PosActual_Man)
        Me.TabPage1.Controls.Add(Me.label125)
        Me.TabPage1.ImageKey = "man1.png"
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Man"
        '
        'Panel_PosActual_Man
        '
        Me.Panel_PosActual_Man.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_PosActual_Man.Controls.Add(Me.txt_ManPosY)
        Me.Panel_PosActual_Man.Controls.Add(Me.txt_ManPosZ)
        Me.Panel_PosActual_Man.Controls.Add(Me.Label2)
        Me.Panel_PosActual_Man.Controls.Add(Me.Label1)
        Me.Panel_PosActual_Man.Controls.Add(Me.label122)
        Me.Panel_PosActual_Man.Controls.Add(Me.txt_ManPosX)
        Me.Panel_PosActual_Man.Controls.Add(Me.label131)
        Me.Panel_PosActual_Man.Location = New System.Drawing.Point(13, 43)
        Me.Panel_PosActual_Man.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_PosActual_Man.Name = "Panel_PosActual_Man"
        Me.Panel_PosActual_Man.Size = New System.Drawing.Size(346, 232)
        Me.Panel_PosActual_Man.TabIndex = 0
        '
        'txt_ManPosY
        '
        Me.txt_ManPosY.BackColor = System.Drawing.SystemColors.Info
        Me.txt_ManPosY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ManPosY.Enabled = False
        Me.txt_ManPosY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_ManPosY.Location = New System.Drawing.Point(192, 82)
        Me.txt_ManPosY.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ManPosY.Name = "txt_ManPosY"
        Me.txt_ManPosY.Size = New System.Drawing.Size(93, 23)
        Me.txt_ManPosY.TabIndex = 53
        Me.txt_ManPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ManPosZ
        '
        Me.txt_ManPosZ.BackColor = System.Drawing.SystemColors.Info
        Me.txt_ManPosZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ManPosZ.Enabled = False
        Me.txt_ManPosZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_ManPosZ.Location = New System.Drawing.Point(192, 113)
        Me.txt_ManPosZ.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ManPosZ.Name = "txt_ManPosZ"
        Me.txt_ManPosZ.Size = New System.Drawing.Size(93, 23)
        Me.txt_ManPosZ.TabIndex = 52
        Me.txt_ManPosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(25, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Eixo Z"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(25, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Eixo Y"
        '
        'label122
        '
        Me.label122.AutoSize = True
        Me.label122.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.label122.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label122.Location = New System.Drawing.Point(192, 27)
        Me.label122.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(59, 17)
        Me.label122.TabIndex = 49
        Me.label122.Text = "Pos (mm)"
        '
        'txt_ManPosX
        '
        Me.txt_ManPosX.BackColor = System.Drawing.SystemColors.Info
        Me.txt_ManPosX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ManPosX.Enabled = False
        Me.txt_ManPosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_ManPosX.Location = New System.Drawing.Point(192, 52)
        Me.txt_ManPosX.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ManPosX.Name = "txt_ManPosX"
        Me.txt_ManPosX.Size = New System.Drawing.Size(93, 23)
        Me.txt_ManPosX.TabIndex = 47
        Me.txt_ManPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label131
        '
        Me.label131.AutoSize = True
        Me.label131.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.label131.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label131.Location = New System.Drawing.Point(25, 58)
        Me.label131.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label131.Name = "label131"
        Me.label131.Size = New System.Drawing.Size(44, 17)
        Me.label131.TabIndex = 48
        Me.label131.Text = "Eixo X "
        '
        'label125
        '
        Me.label125.AllowDrop = True
        Me.label125.BackColor = System.Drawing.Color.DarkGray
        Me.label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label125.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label125.Location = New System.Drawing.Point(13, 18)
        Me.label125.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label125.Name = "label125"
        Me.label125.Size = New System.Drawing.Size(346, 27)
        Me.label125.TabIndex = 4
        Me.label125.Text = "Posiçao Actual"
        Me.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(13, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 232)
        Me.Panel1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(192, 82)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 23)
        Me.TextBox1.TabIndex = 53
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(192, 113)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(93, 23)
        Me.TextBox2.TabIndex = 52
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(25, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Eixo Z"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(25, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Eixo Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label5.Location = New System.Drawing.Point(192, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Pos (mm)"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(192, 52)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(93, 23)
        Me.TextBox3.TabIndex = 47
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label6.Location = New System.Drawing.Point(25, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Eixo X "
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Label7.Location = New System.Drawing.Point(13, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Posiçao Actual"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.ImageKey = "Programas.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 54)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage3.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Programas"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.LightGray
        Me.TabPage4.ImageKey = "Tabelas.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 54)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tabelas"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.LightGray
        Me.TabPage5.ImageKey = "Parametros.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 54)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Parametros"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.LightGray
        Me.TabPage6.ImageKey = "Avisos2.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 54)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Avisos"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.LightGray
        Me.TabPage7.Controls.Add(Me.Label15)
        Me.TabPage7.Controls.Add(Me.Bt_Envio)
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.Controls.Add(Me.Panel5)
        Me.TabPage7.Controls.Add(Me.Panel4)
        Me.TabPage7.Controls.Add(Me.cb_altura)
        Me.TabPage7.Controls.Add(Me.Label13)
        Me.TabPage7.Controls.Add(Me.cb_velocidade_avanco)
        Me.TabPage7.Controls.Add(Me.CB_pontencia_laser)
        Me.TabPage7.Controls.Add(Me.bt_paragem)
        Me.TabPage7.Controls.Add(Me.Button_close)
        Me.TabPage7.Controls.Add(Me.Button_Generate)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Controls.Add(Me.label_starting_point)
        Me.TabPage7.Controls.Add(Me.label_font_size_input)
        Me.TabPage7.Controls.Add(Me.label_text_input)
        Me.TabPage7.Controls.Add(Me.txt_starting_point)
        Me.TabPage7.Controls.Add(Me.TextBox_text_input)
        Me.TabPage7.Controls.Add(Me.bt_limpar)
        Me.TabPage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage7.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TabPage7.Location = New System.Drawing.Point(4, 54)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1231, 702)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "ABC"
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.BackColor = System.Drawing.Color.DarkGray
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(45, 43)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(320, 28)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Configuração de comunicação"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bt_Envio
        '
        Me.Bt_Envio.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Bt_Envio.Location = New System.Drawing.Point(841, 43)
        Me.Bt_Envio.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Envio.Name = "Bt_Envio"
        Me.Bt_Envio.Size = New System.Drawing.Size(147, 44)
        Me.Bt_Envio.TabIndex = 31
        Me.Bt_Envio.Text = "Envio Msg"
        Me.Bt_Envio.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.BackColor = System.Drawing.Color.DarkGray
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(630, 43)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 27)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Dados a enviar"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Bt_Config_Porta)
        Me.Panel5.Controls.Add(Me.Bt_Iniciar_Com)
        Me.Panel5.Location = New System.Drawing.Point(45, 69)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(320, 105)
        Me.Panel5.TabIndex = 47
        '
        'Bt_Config_Porta
        '
        Me.Bt_Config_Porta.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Bt_Config_Porta.Location = New System.Drawing.Point(54, 4)
        Me.Bt_Config_Porta.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Config_Porta.Name = "Bt_Config_Porta"
        Me.Bt_Config_Porta.Size = New System.Drawing.Size(216, 44)
        Me.Bt_Config_Porta.TabIndex = 30
        Me.Bt_Config_Porta.Text = "Configuração da Porta"
        Me.Bt_Config_Porta.UseVisualStyleBackColor = True
        '
        'Bt_Iniciar_Com
        '
        Me.Bt_Iniciar_Com.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Bt_Iniciar_Com.Location = New System.Drawing.Point(53, 56)
        Me.Bt_Iniciar_Com.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Iniciar_Com.Name = "Bt_Iniciar_Com"
        Me.Bt_Iniciar_Com.Size = New System.Drawing.Size(216, 44)
        Me.Bt_Iniciar_Com.TabIndex = 32
        Me.Bt_Iniciar_Com.Text = "Iniciar Comunicação"
        Me.Bt_Iniciar_Com.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_envio)
        Me.Panel4.Location = New System.Drawing.Point(630, 69)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(203, 534)
        Me.Panel4.TabIndex = 47
        '
        'txt_envio
        '
        Me.txt_envio.Location = New System.Drawing.Point(5, 4)
        Me.txt_envio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_envio.Multiline = True
        Me.txt_envio.Name = "txt_envio"
        Me.txt_envio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_envio.Size = New System.Drawing.Size(192, 524)
        Me.txt_envio.TabIndex = 29
        '
        'cb_altura
        '
        Me.cb_altura.AllowDrop = True
        Me.cb_altura.FormattingEnabled = True
        Me.cb_altura.Location = New System.Drawing.Point(45, 378)
        Me.cb_altura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_altura.Name = "cb_altura"
        Me.cb_altura.Size = New System.Drawing.Size(96, 28)
        Me.cb_altura.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 357)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Altura da linha (mm)"
        '
        'cb_velocidade_avanco
        '
        Me.cb_velocidade_avanco.AllowDrop = True
        Me.cb_velocidade_avanco.FormattingEnabled = True
        Me.cb_velocidade_avanco.Location = New System.Drawing.Point(45, 302)
        Me.cb_velocidade_avanco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_velocidade_avanco.Name = "cb_velocidade_avanco"
        Me.cb_velocidade_avanco.Size = New System.Drawing.Size(96, 28)
        Me.cb_velocidade_avanco.TabIndex = 44
        '
        'CB_pontencia_laser
        '
        Me.CB_pontencia_laser.AllowDrop = True
        Me.CB_pontencia_laser.FormattingEnabled = True
        Me.CB_pontencia_laser.Location = New System.Drawing.Point(45, 227)
        Me.CB_pontencia_laser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_pontencia_laser.Name = "CB_pontencia_laser"
        Me.CB_pontencia_laser.Size = New System.Drawing.Size(96, 28)
        Me.CB_pontencia_laser.TabIndex = 43
        '
        'bt_paragem
        '
        Me.bt_paragem.BackColor = System.Drawing.Color.Red
        Me.bt_paragem.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.bt_paragem.Location = New System.Drawing.Point(840, 498)
        Me.bt_paragem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_paragem.Name = "bt_paragem"
        Me.bt_paragem.Size = New System.Drawing.Size(360, 105)
        Me.bt_paragem.TabIndex = 41
        Me.bt_paragem.Text = "Paragem emêrgencia"
        Me.bt_paragem.UseVisualStyleBackColor = False
        '
        'Button_close
        '
        Me.Button_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button_close.Location = New System.Drawing.Point(1098, 628)
        Me.Button_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(109, 66)
        Me.Button_close.TabIndex = 41
        Me.Button_close.Text = "Fechar"
        Me.Button_close.UseVisualStyleBackColor = True
        '
        'Button_Generate
        '
        Me.Button_Generate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button_Generate.Location = New System.Drawing.Point(500, 533)
        Me.Button_Generate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Generate.Name = "Button_Generate"
        Me.Button_Generate.Size = New System.Drawing.Size(109, 70)
        Me.Button_Generate.TabIndex = 42
        Me.Button_Generate.Text = "Gerar código ISO"
        Me.Button_Generate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Velocidade Avanço"
        '
        'label_starting_point
        '
        Me.label_starting_point.AutoSize = True
        Me.label_starting_point.Location = New System.Drawing.Point(48, 434)
        Me.label_starting_point.Name = "label_starting_point"
        Me.label_starting_point.Size = New System.Drawing.Size(165, 20)
        Me.label_starting_point.TabIndex = 38
        Me.label_starting_point.Text = "Corrir ponto de início"
        '
        'label_font_size_input
        '
        Me.label_font_size_input.AutoSize = True
        Me.label_font_size_input.Location = New System.Drawing.Point(48, 206)
        Me.label_font_size_input.Name = "label_font_size_input"
        Me.label_font_size_input.Size = New System.Drawing.Size(116, 20)
        Me.label_font_size_input.TabIndex = 39
        Me.label_font_size_input.Text = "Potência laser"
        '
        'label_text_input
        '
        Me.label_text_input.AutoSize = True
        Me.label_text_input.Location = New System.Drawing.Point(48, 510)
        Me.label_text_input.Name = "label_text_input"
        Me.label_text_input.Size = New System.Drawing.Size(134, 20)
        Me.label_text_input.TabIndex = 37
        Me.label_text_input.Text = "Texto a escrever"
        '
        'txt_starting_point
        '
        Me.txt_starting_point.Location = New System.Drawing.Point(45, 457)
        Me.txt_starting_point.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_starting_point.Name = "txt_starting_point"
        Me.txt_starting_point.Size = New System.Drawing.Size(153, 26)
        Me.txt_starting_point.TabIndex = 36
        '
        'TextBox_text_input
        '
        Me.TextBox_text_input.Location = New System.Drawing.Point(45, 533)
        Me.TextBox_text_input.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox_text_input.Multiline = True
        Me.TextBox_text_input.Name = "TextBox_text_input"
        Me.TextBox_text_input.Size = New System.Drawing.Size(449, 70)
        Me.TextBox_text_input.TabIndex = 35
        '
        'bt_limpar
        '
        Me.bt_limpar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bt_limpar.Location = New System.Drawing.Point(841, 95)
        Me.bt_limpar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_limpar.Name = "bt_limpar"
        Me.bt_limpar.Size = New System.Drawing.Size(147, 44)
        Me.bt_limpar.TabIndex = 33
        Me.bt_limpar.Text = "Limpar Texto"
        Me.bt_limpar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 803)
        Me.Controls.Add(Me.TabCtrl_Option)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.TabCtrl_Option.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel_PosActual_Man.ResumeLayout(False)
        Me.Panel_PosActual_Man.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TabCtrl_Option As TabControl
    Private WithEvents TabPage1 As TabPage
    Friend WithEvents Panel_PosActual_Man As Panel
    Private WithEvents txt_ManPosY As TextBox
    Private WithEvents txt_ManPosZ As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents label122 As Label
    Public WithEvents txt_ManPosX As TextBox
    Private WithEvents label131 As Label
    Friend WithEvents label125 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents Bt_Envio As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Bt_Config_Porta As Button
    Friend WithEvents Bt_Iniciar_Com As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_envio As TextBox
    Friend WithEvents cb_altura As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cb_velocidade_avanco As ComboBox
    Friend WithEvents CB_pontencia_laser As ComboBox
    Friend WithEvents bt_paragem As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents Button_Generate As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents label_starting_point As Label
    Friend WithEvents label_font_size_input As Label
    Friend WithEvents label_text_input As Label
    Friend WithEvents txt_starting_point As TextBox
    Friend WithEvents TextBox_text_input As TextBox
    Friend WithEvents bt_limpar As Button
End Class
