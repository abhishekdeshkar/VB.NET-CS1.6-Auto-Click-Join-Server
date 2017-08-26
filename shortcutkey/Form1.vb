Public Class Form1

    <System.Runtime.InteropServices.DllImport("user32")> Private Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Integer
    End Function

    WithEvents Timer As New System.Windows.Forms.Timer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Timer.Enabled = True
        Timer.Interval = 50
        Timer.Start()
    End Sub
    Private Sub TimerTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        '  If CBool(GetAsyncKeyState(Keys.Alt)) And CBool(GetAsyncKeyState(Keys.A)) = True Then
        '    Microsoft.VisualBasic.Interaction.MsgBox("a & alt button was pressed.")
        If CBool(GetAsyncKeyState(Keys.F10)) Then
            'start it
            lbl_showstate.ForeColor = Color.Green
            lbl_showstate.Text = "STARTED"
            timer_enter.Enabled = True
            timer_enter.Interval = Int(txtms.Text)
            timer_enter.Start()

            txtms.Enabled = False


        ElseIf CBool(GetAsyncKeyState(Keys.F11)) Then
            'Stop it
            lbl_showstate.ForeColor = Color.Red
            lbl_showstate.Text = "STOPPED"
            timer_enter.Enabled = False
            timer_enter.Stop()

            txtms.Enabled = True

        End If
    End Sub

    Private Sub timer_enter_Tick(sender As Object, e As EventArgs) Handles timer_enter.Tick
        LeftClick()

    End Sub


End Class