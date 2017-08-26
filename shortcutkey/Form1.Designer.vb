<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.timer_enter = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.lbl_showstate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtms = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timer_enter
        '
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.Location = New System.Drawing.Point(199, 105)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(134, 32)
        Me.lbl_state.TabIndex = 0
        Me.lbl_state.Text = "STATUS:"
        '
        'lbl_showstate
        '
        Me.lbl_showstate.AutoSize = True
        Me.lbl_showstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_showstate.Location = New System.Drawing.Point(339, 105)
        Me.lbl_showstate.Name = "lbl_showstate"
        Me.lbl_showstate.Size = New System.Drawing.Size(71, 32)
        Me.lbl_showstate.TabIndex = 1
        Me.lbl_showstate.Text = "OFF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(62, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Press F10 to Turn On and Press F11 to Turn Off"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Interval : "
        '
        'txtms
        '
        Me.txtms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtms.Location = New System.Drawing.Point(291, 222)
        Me.txtms.Name = "txtms"
        Me.txtms.Size = New System.Drawing.Size(77, 30)
        Me.txtms.TabIndex = 4
        Me.txtms.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(621, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "***100 ms is recommended. Keep value less than 100 if your ping is lower than 25." &
    ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_showstate)
        Me.Controls.Add(Me.lbl_state)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 350)
        Me.MinimumSize = New System.Drawing.Size(750, 350)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Join Game Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer_enter As Timer
    Friend WithEvents lbl_state As Label
    Friend WithEvents lbl_showstate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtms As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
