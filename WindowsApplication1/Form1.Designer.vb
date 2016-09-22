<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnOpenInterface = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tmrDInputs = New System.Windows.Forms.Timer(Me.components)
        Me.btnCloseInterface = New System.Windows.Forms.Button()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.cbO0 = New System.Windows.Forms.CheckBox()
        Me.cbO1 = New System.Windows.Forms.CheckBox()
        Me.cbO2 = New System.Windows.Forms.CheckBox()
        Me.cbO3 = New System.Windows.Forms.CheckBox()
        Me.cbO4 = New System.Windows.Forms.CheckBox()
        Me.cbO5 = New System.Windows.Forms.CheckBox()
        Me.cbO6 = New System.Windows.Forms.CheckBox()
        Me.cbO7 = New System.Windows.Forms.CheckBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.cbI0 = New System.Windows.Forms.CheckBox()
        Me.cbI1 = New System.Windows.Forms.CheckBox()
        Me.cbI2 = New System.Windows.Forms.CheckBox()
        Me.cbI3 = New System.Windows.Forms.CheckBox()
        Me.cbI4 = New System.Windows.Forms.CheckBox()
        Me.cbI5 = New System.Windows.Forms.CheckBox()
        Me.cbI6 = New System.Windows.Forms.CheckBox()
        Me.cbI7 = New System.Windows.Forms.CheckBox()
        Me.pbAnA = New System.Windows.Forms.ProgressBar()
        Me.pbAnB = New System.Windows.Forms.ProgressBar()
        Me.pbAnC = New System.Windows.Forms.ProgressBar()
        Me.pbAnD = New System.Windows.Forms.ProgressBar()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrAInputs = New System.Windows.Forms.Timer(Me.components)
        Me.gp4 = New System.Windows.Forms.GroupBox()
        Me.rMAR = New System.Windows.Forms.RadioButton()
        Me.rMAS = New System.Windows.Forms.RadioButton()
        Me.rMAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb2.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.gp4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenInterface
        '
        Me.btnOpenInterface.Location = New System.Drawing.Point(12, 12)
        Me.btnOpenInterface.Name = "btnOpenInterface"
        Me.btnOpenInterface.Size = New System.Drawing.Size(124, 23)
        Me.btnOpenInterface.TabIndex = 0
        Me.btnOpenInterface.Text = "&Open Interface"
        Me.btnOpenInterface.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(17, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 1
        '
        'tmrDInputs
        '
        Me.tmrDInputs.Interval = 2000
        '
        'btnCloseInterface
        '
        Me.btnCloseInterface.Enabled = False
        Me.btnCloseInterface.Location = New System.Drawing.Point(150, 12)
        Me.btnCloseInterface.Name = "btnCloseInterface"
        Me.btnCloseInterface.Size = New System.Drawing.Size(124, 23)
        Me.btnCloseInterface.TabIndex = 10
        Me.btnCloseInterface.Text = "&Close Interface"
        Me.btnCloseInterface.UseVisualStyleBackColor = True
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.cbO0)
        Me.gb2.Controls.Add(Me.cbO1)
        Me.gb2.Controls.Add(Me.cbO2)
        Me.gb2.Controls.Add(Me.cbO3)
        Me.gb2.Controls.Add(Me.cbO4)
        Me.gb2.Controls.Add(Me.cbO5)
        Me.gb2.Controls.Add(Me.cbO6)
        Me.gb2.Controls.Add(Me.cbO7)
        Me.gb2.Location = New System.Drawing.Point(157, 75)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(97, 213)
        Me.gb2.TabIndex = 11
        Me.gb2.TabStop = False
        Me.gb2.Text = "Digital Outputs"
        '
        'cbO0
        '
        Me.cbO0.AutoSize = True
        Me.cbO0.Location = New System.Drawing.Point(15, 184)
        Me.cbO0.Name = "cbO0"
        Me.cbO0.Size = New System.Drawing.Size(67, 17)
        Me.cbO0.TabIndex = 19
        Me.cbO0.Text = "Output 0"
        Me.cbO0.UseVisualStyleBackColor = True
        '
        'cbO1
        '
        Me.cbO1.AutoSize = True
        Me.cbO1.Location = New System.Drawing.Point(15, 161)
        Me.cbO1.Name = "cbO1"
        Me.cbO1.Size = New System.Drawing.Size(67, 17)
        Me.cbO1.TabIndex = 18
        Me.cbO1.Text = "Output 1"
        Me.cbO1.UseVisualStyleBackColor = True
        '
        'cbO2
        '
        Me.cbO2.AutoSize = True
        Me.cbO2.Location = New System.Drawing.Point(15, 138)
        Me.cbO2.Name = "cbO2"
        Me.cbO2.Size = New System.Drawing.Size(67, 17)
        Me.cbO2.TabIndex = 17
        Me.cbO2.Text = "Output 2"
        Me.cbO2.UseVisualStyleBackColor = True
        '
        'cbO3
        '
        Me.cbO3.AutoSize = True
        Me.cbO3.Location = New System.Drawing.Point(15, 115)
        Me.cbO3.Name = "cbO3"
        Me.cbO3.Size = New System.Drawing.Size(67, 17)
        Me.cbO3.TabIndex = 16
        Me.cbO3.Text = "Output 3"
        Me.cbO3.UseVisualStyleBackColor = True
        '
        'cbO4
        '
        Me.cbO4.AutoSize = True
        Me.cbO4.Location = New System.Drawing.Point(15, 92)
        Me.cbO4.Name = "cbO4"
        Me.cbO4.Size = New System.Drawing.Size(67, 17)
        Me.cbO4.TabIndex = 15
        Me.cbO4.Text = "Output 4"
        Me.cbO4.UseVisualStyleBackColor = True
        '
        'cbO5
        '
        Me.cbO5.AutoSize = True
        Me.cbO5.Location = New System.Drawing.Point(15, 69)
        Me.cbO5.Name = "cbO5"
        Me.cbO5.Size = New System.Drawing.Size(67, 17)
        Me.cbO5.TabIndex = 14
        Me.cbO5.Text = "Output 5"
        Me.cbO5.UseVisualStyleBackColor = True
        '
        'cbO6
        '
        Me.cbO6.AutoSize = True
        Me.cbO6.Location = New System.Drawing.Point(15, 46)
        Me.cbO6.Name = "cbO6"
        Me.cbO6.Size = New System.Drawing.Size(67, 17)
        Me.cbO6.TabIndex = 13
        Me.cbO6.Text = "Output 6"
        Me.cbO6.UseVisualStyleBackColor = True
        '
        'cbO7
        '
        Me.cbO7.AutoSize = True
        Me.cbO7.Location = New System.Drawing.Point(15, 23)
        Me.cbO7.Name = "cbO7"
        Me.cbO7.Size = New System.Drawing.Size(67, 17)
        Me.cbO7.TabIndex = 12
        Me.cbO7.Text = "Output 7"
        Me.cbO7.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.cbI0)
        Me.gb1.Controls.Add(Me.cbI1)
        Me.gb1.Controls.Add(Me.cbI2)
        Me.gb1.Controls.Add(Me.cbI3)
        Me.gb1.Controls.Add(Me.cbI4)
        Me.gb1.Controls.Add(Me.cbI5)
        Me.gb1.Controls.Add(Me.cbI6)
        Me.gb1.Controls.Add(Me.cbI7)
        Me.gb1.Location = New System.Drawing.Point(26, 75)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(97, 213)
        Me.gb1.TabIndex = 20
        Me.gb1.TabStop = False
        Me.gb1.Text = "Digital Inputs"
        '
        'cbI0
        '
        Me.cbI0.AutoSize = True
        Me.cbI0.Location = New System.Drawing.Point(15, 184)
        Me.cbI0.Name = "cbI0"
        Me.cbI0.Size = New System.Drawing.Size(59, 17)
        Me.cbI0.TabIndex = 19
        Me.cbI0.Text = "Input 0"
        Me.cbI0.UseVisualStyleBackColor = True
        '
        'cbI1
        '
        Me.cbI1.AutoSize = True
        Me.cbI1.Location = New System.Drawing.Point(15, 161)
        Me.cbI1.Name = "cbI1"
        Me.cbI1.Size = New System.Drawing.Size(59, 17)
        Me.cbI1.TabIndex = 18
        Me.cbI1.Text = "Input 1"
        Me.cbI1.UseVisualStyleBackColor = True
        '
        'cbI2
        '
        Me.cbI2.AutoSize = True
        Me.cbI2.Location = New System.Drawing.Point(15, 138)
        Me.cbI2.Name = "cbI2"
        Me.cbI2.Size = New System.Drawing.Size(59, 17)
        Me.cbI2.TabIndex = 17
        Me.cbI2.Text = "Input 2"
        Me.cbI2.UseVisualStyleBackColor = True
        '
        'cbI3
        '
        Me.cbI3.AutoSize = True
        Me.cbI3.Location = New System.Drawing.Point(15, 115)
        Me.cbI3.Name = "cbI3"
        Me.cbI3.Size = New System.Drawing.Size(59, 17)
        Me.cbI3.TabIndex = 16
        Me.cbI3.Text = "Input 3"
        Me.cbI3.UseVisualStyleBackColor = True
        '
        'cbI4
        '
        Me.cbI4.AutoSize = True
        Me.cbI4.Location = New System.Drawing.Point(15, 92)
        Me.cbI4.Name = "cbI4"
        Me.cbI4.Size = New System.Drawing.Size(59, 17)
        Me.cbI4.TabIndex = 15
        Me.cbI4.Text = "Input 4"
        Me.cbI4.UseVisualStyleBackColor = True
        '
        'cbI5
        '
        Me.cbI5.AutoSize = True
        Me.cbI5.Location = New System.Drawing.Point(15, 69)
        Me.cbI5.Name = "cbI5"
        Me.cbI5.Size = New System.Drawing.Size(59, 17)
        Me.cbI5.TabIndex = 14
        Me.cbI5.Text = "Input 5"
        Me.cbI5.UseVisualStyleBackColor = True
        '
        'cbI6
        '
        Me.cbI6.AutoSize = True
        Me.cbI6.Location = New System.Drawing.Point(15, 46)
        Me.cbI6.Name = "cbI6"
        Me.cbI6.Size = New System.Drawing.Size(59, 17)
        Me.cbI6.TabIndex = 13
        Me.cbI6.Text = "Input 6"
        Me.cbI6.UseVisualStyleBackColor = True
        '
        'cbI7
        '
        Me.cbI7.AutoSize = True
        Me.cbI7.Location = New System.Drawing.Point(15, 23)
        Me.cbI7.Name = "cbI7"
        Me.cbI7.Size = New System.Drawing.Size(59, 17)
        Me.cbI7.TabIndex = 12
        Me.cbI7.Text = "Input 7"
        Me.cbI7.UseVisualStyleBackColor = True
        '
        'pbAnA
        '
        Me.pbAnA.Location = New System.Drawing.Point(24, 29)
        Me.pbAnA.Maximum = 255
        Me.pbAnA.Name = "pbAnA"
        Me.pbAnA.Size = New System.Drawing.Size(198, 21)
        Me.pbAnA.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbAnA.TabIndex = 21
        '
        'pbAnB
        '
        Me.pbAnB.Location = New System.Drawing.Point(24, 56)
        Me.pbAnB.Maximum = 255
        Me.pbAnB.Name = "pbAnB"
        Me.pbAnB.Size = New System.Drawing.Size(198, 21)
        Me.pbAnB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbAnB.TabIndex = 22
        '
        'pbAnC
        '
        Me.pbAnC.Location = New System.Drawing.Point(24, 83)
        Me.pbAnC.Maximum = 255
        Me.pbAnC.Name = "pbAnC"
        Me.pbAnC.Size = New System.Drawing.Size(198, 21)
        Me.pbAnC.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbAnC.TabIndex = 23
        '
        'pbAnD
        '
        Me.pbAnD.Location = New System.Drawing.Point(24, 110)
        Me.pbAnD.Maximum = 255
        Me.pbAnD.Name = "pbAnD"
        Me.pbAnD.Size = New System.Drawing.Size(198, 21)
        Me.pbAnD.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbAnD.TabIndex = 24
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.Label4)
        Me.gb3.Controls.Add(Me.Label3)
        Me.gb3.Controls.Add(Me.Label2)
        Me.gb3.Controls.Add(Me.Label1)
        Me.gb3.Controls.Add(Me.pbAnA)
        Me.gb3.Controls.Add(Me.pbAnD)
        Me.gb3.Controls.Add(Me.pbAnB)
        Me.gb3.Controls.Add(Me.pbAnC)
        Me.gb3.Location = New System.Drawing.Point(26, 294)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(228, 142)
        Me.gb3.TabIndex = 25
        Me.gb3.TabStop = False
        Me.gb3.Text = "Analogue Inputs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "D:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "B:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "A:"
        '
        'tmrAInputs
        '
        Me.tmrAInputs.Interval = 1000
        '
        'gp4
        '
        Me.gp4.Controls.Add(Me.rMAR)
        Me.gp4.Controls.Add(Me.rMAS)
        Me.gp4.Controls.Add(Me.rMAL)
        Me.gp4.Location = New System.Drawing.Point(26, 442)
        Me.gp4.Name = "gp4"
        Me.gp4.Size = New System.Drawing.Size(228, 50)
        Me.gp4.TabIndex = 26
        Me.gp4.TabStop = False
        Me.gp4.Text = "Motor A"
        '
        'rMAR
        '
        Me.rMAR.AutoSize = True
        Me.rMAR.Location = New System.Drawing.Point(163, 20)
        Me.rMAR.Name = "rMAR"
        Me.rMAR.Size = New System.Drawing.Size(50, 17)
        Me.rMAR.TabIndex = 29
        Me.rMAR.TabStop = True
        Me.rMAR.Text = "Right"
        Me.rMAR.UseVisualStyleBackColor = True
        '
        'rMAS
        '
        Me.rMAS.AutoSize = True
        Me.rMAS.Location = New System.Drawing.Point(89, 20)
        Me.rMAS.Name = "rMAS"
        Me.rMAS.Size = New System.Drawing.Size(47, 17)
        Me.rMAS.TabIndex = 28
        Me.rMAS.TabStop = True
        Me.rMAS.Text = "Stop"
        Me.rMAS.UseVisualStyleBackColor = True
        '
        'rMAL
        '
        Me.rMAL.AutoSize = True
        Me.rMAL.Location = New System.Drawing.Point(16, 20)
        Me.rMAL.Name = "rMAL"
        Me.rMAL.Size = New System.Drawing.Size(43, 17)
        Me.rMAL.TabIndex = 27
        Me.rMAL.TabStop = True
        Me.rMAL.Text = "Left"
        Me.rMAL.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 495)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 50)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motor B"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(163, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton4.TabIndex = 29
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Right"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(89, 20)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton5.TabIndex = 28
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Stop"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(16, 20)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton6.TabIndex = 27
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Left"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 548)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 50)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Motor C"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(163, 20)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton7.TabIndex = 29
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Right"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(89, 20)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton8.TabIndex = 28
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Stop"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(16, 20)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton9.TabIndex = 27
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Left"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton10)
        Me.GroupBox3.Controls.Add(Me.RadioButton11)
        Me.GroupBox3.Controls.Add(Me.RadioButton12)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 602)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 50)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Motor D"
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(163, 20)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton10.TabIndex = 29
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Right"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(89, 20)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton11.TabIndex = 28
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Stop"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(16, 20)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton12.TabIndex = 27
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Left"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 659)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Clear All Motors"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSmartBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 690)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gp4)
        Me.Controls.Add(Me.gb3)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.btnCloseInterface)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnOpenInterface)
        Me.Name = "frmSmartBox"
        Me.Text = "Form1"
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        Me.gp4.ResumeLayout(False)
        Me.gp4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenInterface As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents tmrDInputs As Timer
    Friend WithEvents btnCloseInterface As Button
    Friend WithEvents gb2 As GroupBox
    Friend WithEvents cbO0 As CheckBox
    Friend WithEvents cbO1 As CheckBox
    Friend WithEvents cbO2 As CheckBox
    Friend WithEvents cbO3 As CheckBox
    Friend WithEvents cbO4 As CheckBox
    Friend WithEvents cbO5 As CheckBox
    Friend WithEvents cbO6 As CheckBox
    Friend WithEvents cbO7 As CheckBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents cbI0 As CheckBox
    Friend WithEvents cbI1 As CheckBox
    Friend WithEvents cbI2 As CheckBox
    Friend WithEvents cbI3 As CheckBox
    Friend WithEvents cbI4 As CheckBox
    Friend WithEvents cbI5 As CheckBox
    Friend WithEvents cbI6 As CheckBox
    Friend WithEvents cbI7 As CheckBox
    Friend WithEvents pbAnA As ProgressBar
    Friend WithEvents pbAnB As ProgressBar
    Friend WithEvents pbAnC As ProgressBar
    Friend WithEvents pbAnD As ProgressBar
    Friend WithEvents gb3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrAInputs As Timer
    Friend WithEvents gp4 As GroupBox
    Friend WithEvents rMAR As RadioButton
    Friend WithEvents rMAS As RadioButton
    Friend WithEvents rMAL As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents Button1 As Button
End Class
