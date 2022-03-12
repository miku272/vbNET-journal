<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TrackBarRed = New System.Windows.Forms.TrackBar()
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar()
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1072, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(544, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Green: "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(120, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 43)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(651, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(283, 43)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(1159, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(283, 43)
        Me.TextBox3.TabIndex = 6
        '
        'TrackBarRed
        '
        Me.TrackBarRed.Location = New System.Drawing.Point(39, 293)
        Me.TrackBarRed.Maximum = 255
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(1403, 45)
        Me.TrackBarRed.TabIndex = 7
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.Location = New System.Drawing.Point(39, 503)
        Me.TrackBarGreen.Maximum = 255
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(1403, 45)
        Me.TrackBarGreen.TabIndex = 8
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.Location = New System.Drawing.Point(39, 708)
        Me.TrackBarBlue.Maximum = 255
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(1403, 45)
        Me.TrackBarBlue.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1577, 840)
        Me.Controls.Add(Me.TrackBarBlue)
        Me.Controls.Add(Me.TrackBarGreen)
        Me.Controls.Add(Me.TrackBarRed)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "journal_program_42"
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TrackBarRed As TrackBar
    Friend WithEvents TrackBarGreen As TrackBar
    Friend WithEvents TrackBarBlue As TrackBar
End Class
