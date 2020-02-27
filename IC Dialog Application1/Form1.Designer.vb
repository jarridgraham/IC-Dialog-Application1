<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdLive = New System.Windows.Forms.Button()
        Me.cmdProperties = New System.Windows.Forms.Button()
        Me.cmdDevice = New System.Windows.Forms.Button()
        Me.IcImagingControl1 = New TIS.Imaging.ICImagingControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLive
        '
        Me.cmdLive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLive.Location = New System.Drawing.Point(666, 70)
        Me.cmdLive.Name = "cmdLive"
        Me.cmdLive.Size = New System.Drawing.Size(83, 23)
        Me.cmdLive.TabIndex = 2
        Me.cmdLive.Text = "Start Live"
        Me.cmdLive.UseVisualStyleBackColor = True
        '
        'cmdProperties
        '
        Me.cmdProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdProperties.Location = New System.Drawing.Point(666, 41)
        Me.cmdProperties.Name = "cmdProperties"
        Me.cmdProperties.Size = New System.Drawing.Size(83, 23)
        Me.cmdProperties.TabIndex = 1
        Me.cmdProperties.Text = "Properties"
        Me.cmdProperties.UseVisualStyleBackColor = True
        '
        'cmdDevice
        '
        Me.cmdDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDevice.Location = New System.Drawing.Point(666, 12)
        Me.cmdDevice.Name = "cmdDevice"
        Me.cmdDevice.Size = New System.Drawing.Size(83, 23)
        Me.cmdDevice.TabIndex = 0
        Me.cmdDevice.Text = "Device"
        Me.cmdDevice.UseVisualStyleBackColor = True
        '
        'IcImagingControl1
        '
        Me.IcImagingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IcImagingControl1.BackColor = System.Drawing.Color.White
        Me.IcImagingControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IcImagingControl1.DeviceListChangedExecutionMode = TIS.Imaging.EventExecutionMode.Invoke
        Me.IcImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke
        Me.IcImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded
        Me.IcImagingControl1.LiveDisplayPosition = New System.Drawing.Point(0, 0)
        Me.IcImagingControl1.Location = New System.Drawing.Point(10, 13)
        Me.IcImagingControl1.Name = "IcImagingControl1"
        Me.IcImagingControl1.Size = New System.Drawing.Size(640, 480)
        Me.IcImagingControl1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Focus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(666, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "350"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(670, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 22)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(669, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(78, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "140"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(671, 290)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(77, 20)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "780"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(671, 320)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(75, 20)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.Text = "40"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 506)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IcImagingControl1)
        Me.Controls.Add(Me.cmdLive)
        Me.Controls.Add(Me.cmdProperties)
        Me.Controls.Add(Me.cmdDevice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IC Dialog Application1"
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdLive As System.Windows.Forms.Button
    Private WithEvents cmdProperties As System.Windows.Forms.Button
    Private WithEvents cmdDevice As System.Windows.Forms.Button

    Friend WithEvents IcImagingControl1 As TIS.Imaging.ICImagingControl
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
