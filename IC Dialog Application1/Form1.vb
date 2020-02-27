Imports System.Windows.Forms

Public Class Form1


    ' This attribute controls whether the live display is scaled in order
    ' to match the size of the IC Imaging Control window on the form.
    private m_bFitImageToWindow as boolean = True
    Private VCDProp As TIS.Imaging.VCDHelpers.VCDSimpleProperty

    Private Delegate Sub DeviceLostDelegate()

    Private Delegate Sub ShowBufferDelegate(ByVal buffer As TIS.Imaging.ImageBuffer)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open the last used video capture device.
        Try
            IcImagingControl1.LoadDeviceStateFromFile("device.xml", True)
        Catch
            ' Either the xml file does not exist or the device
            ' could not be loaded. In both cases we do nothing and proceed.
        End Try

        cmdLive.Enabled = IcImagingControl1.DeviceValid
        cmdProperties.Enabled = IcImagingControl1.DeviceValid

        if m_bFitImageToWindow = true then
            ' Adjust live display size to the control size.
            icImagingControl1.LiveDisplayDefault = false
            icImagingControl1.LiveDisplayHeight = icImagingControl1.Height
            icImagingControl1.LiveDisplayWidth = icImagingControl1.Width
        End If



    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If IcImagingControl1.DeviceValid = True Then
            IcImagingControl1.LiveStop()
        End If
    End Sub

    '
    ' Adjust live display size to the control size.
    '
    Private Sub Form1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If m_bFitImageToWindow = True Then
            If IcImagingControl1.DeviceValid = True Then
                IcImagingControl1.LiveDisplayHeight = IcImagingControl1.Height
                IcImagingControl1.LiveDisplayWidth = IcImagingControl1.Width
            End If
        End If
    End Sub

    '
    ' Show the device selection dialog of IC Imaging Control.
    '
    Private Sub OpenVideoCaptureDevice()
        If IcImagingControl1.DeviceValid Then
            StopLiveVideo()
        Else
            IcImagingControl1.Device = ""
        End If
        IcImagingControl1.ShowDeviceSettingsDialog()
        If IcImagingControl1.DeviceValid Then
            ' Save the currently used device into a file in order to 
            ' be able to open it automatically at the next program start.
            IcImagingControl1.SaveDeviceStateToFile("device.xml")
        End If
        cmdLive.Enabled = IcImagingControl1.DeviceValid
        cmdProperties.Enabled = IcImagingControl1.DeviceValid
    End Sub

    '
    ' Show the device's property dialog for modifying exposure, brightness etc. 
    ' All changes are saved to the file 'device.xml'.
    '
    Private Sub ShowDeviceProperties()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.ShowPropertyDialog()
            IcImagingControl1.SaveDeviceStateToFile("device.xml")
        End If
    End Sub

    '
    ' Start the live video and update the state of the start/stop button.
    '
    Private Sub StartLiveVideo()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.LiveStart()
            cmdLive.Text = "Stop Live"
        End If
    End Sub

    '
    ' Stop the live video and update the state of the start/stop button.
    '
    Private Sub StopLiveVideo()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.LiveStop()
            cmdLive.Text = "Start Live"
        End If
    End Sub

    '
    ' Show the device selection dialog of IC Imaging Control.
    '
    Private Sub cmdDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevice.Click
        OpenVideoCaptureDevice()
    End Sub

    '
    ' Show the device's property dialog for exposure, brightness etc.
    '
    Private Sub cmdProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProperties.Click
        ShowDeviceProperties()
    End Sub

    ' 
    ' Start/stop the live video and update the state of the start/stop button.
    '
    Private Sub cmdLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLive.Click
        If IcImagingControl1.LiveVideoRunning Then
            StopLiveVideo()
        Else
            StartLiveVideo()
        End If
    End Sub

    '
    ' Handle the DeviceLost event.
    '
    Private Sub DeviceLost()
        MessageBox.Show("Device Lost!")
        cmdLive.Text = "Start Live"
        cmdLive.Enabled = False
        cmdProperties.Enabled = False
    End Sub

    Private Sub IcImagingControl1_DeviceLost(ByVal sender As System.Object, ByVal e As TIS.Imaging.ICImagingControl.DeviceLostEventArgs) Handles IcImagingControl1.DeviceLost
        BeginInvoke(New DeviceLostDelegate(AddressOf DeviceLost))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        VCDProp = TIS.Imaging.VCDHelpers.VCDSimpleModule.GetSimplePropertyContainer(IcImagingControl1.VCDPropertyItems)
        VCDProp.RangeValue(TIS.Imaging.VCDIDs.VCDID_Focus) = TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim focus As Integer
        VCDProp = TIS.Imaging.VCDHelpers.VCDSimpleModule.GetSimplePropertyContainer(IcImagingControl1.VCDPropertyItems)
        For focus = TextBox2.Text To TextBox3.Text Step TextBox4.Text
            VCDProp.RangeValue(TIS.Imaging.VCDIDs.VCDID_Focus) = focus
            TextBox1.Text = focus
            TextBox1.Update()
            IcImagingControl1.MemorySnapImage(2000)
            IcImagingControl1.MemorySaveImage(focus.ToString + ".bmp")
        Next
    End Sub


End Class
