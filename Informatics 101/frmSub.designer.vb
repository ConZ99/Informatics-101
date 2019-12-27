<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSub))
        Me.lbxShowDir = New System.Windows.Forms.ListBox()
        Me.lblShowDir = New System.Windows.Forms.Label()
        Me.rtbShowCode = New System.Windows.Forms.RichTextBox()
        Me.mnu1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LucruriSuperSerioaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HackNASAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicTacToeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetaliiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeoriePentruDoritoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEn = New System.Windows.Forms.Button()
        Me.back4 = New System.Windows.Forms.Button()
        Me.teorieBack = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.mnu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxShowDir
        '
        Me.lbxShowDir.BackColor = System.Drawing.Color.MintCream
        Me.lbxShowDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxShowDir.FormattingEnabled = True
        Me.lbxShowDir.ItemHeight = 18
        Me.lbxShowDir.Location = New System.Drawing.Point(12, 61)
        Me.lbxShowDir.Name = "lbxShowDir"
        Me.lbxShowDir.Size = New System.Drawing.Size(525, 94)
        Me.lbxShowDir.TabIndex = 4
        '
        'lblShowDir
        '
        Me.lblShowDir.BackColor = System.Drawing.SystemColors.Control
        Me.lblShowDir.Location = New System.Drawing.Point(12, 535)
        Me.lblShowDir.Name = "lblShowDir"
        Me.lblShowDir.Size = New System.Drawing.Size(525, 25)
        Me.lblShowDir.TabIndex = 6
        Me.lblShowDir.Text = "Path"
        '
        'rtbShowCode
        '
        Me.rtbShowCode.BackColor = System.Drawing.Color.MintCream
        Me.rtbShowCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbShowCode.Location = New System.Drawing.Point(12, 161)
        Me.rtbShowCode.Name = "rtbShowCode"
        Me.rtbShowCode.ReadOnly = True
        Me.rtbShowCode.Size = New System.Drawing.Size(525, 371)
        Me.rtbShowCode.TabIndex = 10
        Me.rtbShowCode.Text = ""
        '
        'mnu1
        '
        Me.mnu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnu1.Location = New System.Drawing.Point(0, 0)
        Me.mnu1.Name = "mnu1"
        Me.mnu1.Size = New System.Drawing.Size(547, 24)
        Me.mnu1.TabIndex = 12
        Me.mnu1.Text = "mnu1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LucruriSuperSerioaseToolStripMenuItem, Me.DetaliiToolStripMenuItem, Me.TeoriePentruDoritoriToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LucruriSuperSerioaseToolStripMenuItem
        '
        Me.LucruriSuperSerioaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HackNASAToolStripMenuItem})
        Me.LucruriSuperSerioaseToolStripMenuItem.Name = "LucruriSuperSerioaseToolStripMenuItem"
        Me.LucruriSuperSerioaseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LucruriSuperSerioaseToolStripMenuItem.Text = "Lucruri super serioase"
        '
        'HackNASAToolStripMenuItem
        '
        Me.HackNASAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicTacToeToolStripMenuItem})
        Me.HackNASAToolStripMenuItem.Name = "HackNASAToolStripMenuItem"
        Me.HackNASAToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HackNASAToolStripMenuItem.Text = "Hack N.A.S.A"
        '
        'TicTacToeToolStripMenuItem
        '
        Me.TicTacToeToolStripMenuItem.Name = "TicTacToeToolStripMenuItem"
        Me.TicTacToeToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TicTacToeToolStripMenuItem.Text = "TicTacToe"
        '
        'DetaliiToolStripMenuItem
        '
        Me.DetaliiToolStripMenuItem.Name = "DetaliiToolStripMenuItem"
        Me.DetaliiToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DetaliiToolStripMenuItem.Text = "Detalii"
        '
        'TeoriePentruDoritoriToolStripMenuItem
        '
        Me.TeoriePentruDoritoriToolStripMenuItem.Name = "TeoriePentruDoritoriToolStripMenuItem"
        Me.TeoriePentruDoritoriToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TeoriePentruDoritoriToolStripMenuItem.Text = "Teorie pentru doritori"
        '
        'btnEn
        '
        Me.btnEn.Location = New System.Drawing.Point(137, 27)
        Me.btnEn.Name = "btnEn"
        Me.btnEn.Size = New System.Drawing.Size(119, 28)
        Me.btnEn.TabIndex = 19
        Me.btnEn.Text = "Enuntul problemei"
        Me.btnEn.UseVisualStyleBackColor = True
        '
        'back4
        '
        Me.back4.Location = New System.Drawing.Point(479, 27)
        Me.back4.Name = "back4"
        Me.back4.Size = New System.Drawing.Size(58, 28)
        Me.back4.TabIndex = 18
        Me.back4.Text = "Înapoi"
        Me.back4.UseVisualStyleBackColor = True
        '
        'teorieBack
        '
        Me.teorieBack.Location = New System.Drawing.Point(354, 27)
        Me.teorieBack.Name = "teorieBack"
        Me.teorieBack.Size = New System.Drawing.Size(119, 28)
        Me.teorieBack.TabIndex = 17
        Me.teorieBack.Text = "Teorie"
        Me.teorieBack.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(12, 27)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(119, 28)
        Me.btnRun.TabIndex = 16
        Me.btnRun.Text = "Execută Problema"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'frmSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(547, 569)
        Me.Controls.Add(Me.btnEn)
        Me.Controls.Add(Me.back4)
        Me.Controls.Add(Me.teorieBack)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.rtbShowCode)
        Me.Controls.Add(Me.lblShowDir)
        Me.Controls.Add(Me.lbxShowDir)
        Me.Controls.Add(Me.mnu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu1
        Me.MaximizeBox = False
        Me.Name = "frmSub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backtracking"
        Me.mnu1.ResumeLayout(False)
        Me.mnu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxShowDir As ListBox
    Friend WithEvents lblShowDir As Label
    Friend WithEvents rtbShowCode As RichTextBox
    Friend WithEvents mnu1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LucruriSuperSerioaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HackNASAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicTacToeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetaliiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeoriePentruDoritoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEn As Button
    Friend WithEvents back4 As Button
    Friend WithEvents teorieBack As Button
    Friend WithEvents btnRun As Button
End Class
