<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn4, "btn4")
        Me.btn4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn4.Name = "btn4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn1, "btn1")
        Me.btn1.ForeColor = System.Drawing.Color.Maroon
        Me.btn1.Name = "btn1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn2, "btn2")
        Me.btn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn2.Name = "btn2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn3, "btn3")
        Me.btn3.ForeColor = System.Drawing.Color.Yellow
        Me.btn3.Name = "btn3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn5, "btn5")
        Me.btn5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn5.Name = "btn5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn6, "btn6")
        Me.btn6.ForeColor = System.Drawing.Color.Navy
        Me.btn6.Name = "btn6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'MainScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Informatics_101.My.Resources.Resources.Main_back_1_
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.MaximizeBox = False
        Me.Name = "MainScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn4 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
End Class
