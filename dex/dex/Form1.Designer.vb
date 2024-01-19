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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.field1 = New System.Windows.Forms.TextBox()
        Me.field2 = New System.Windows.Forms.TextBox()
        Me.field3 = New System.Windows.Forms.TextBox()
        Me.field4 = New System.Windows.Forms.TextBox()
        Me.field5 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstButton = New System.Windows.Forms.Button()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pos1 = New System.Windows.Forms.Label()
        Me.pos2 = New System.Windows.Forms.Label()
        Me.pos3 = New System.Windows.Forms.Label()
        Me.pos4 = New System.Windows.Forms.Label()
        Me.pos5 = New System.Windows.Forms.Label()
        Me.pos6 = New System.Windows.Forms.Label()
        Me.pos7 = New System.Windows.Forms.Label()
        Me.pos8 = New System.Windows.Forms.Label()
        Me.pos9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0002"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(165, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'field1
        '
        Me.field1.Location = New System.Drawing.Point(59, 89)
        Me.field1.Name = "field1"
        Me.field1.Size = New System.Drawing.Size(100, 23)
        Me.field1.TabIndex = 3
        '
        'field2
        '
        Me.field2.Location = New System.Drawing.Point(59, 118)
        Me.field2.Name = "field2"
        Me.field2.Size = New System.Drawing.Size(100, 23)
        Me.field2.TabIndex = 4
        '
        'field3
        '
        Me.field3.Location = New System.Drawing.Point(59, 147)
        Me.field3.Name = "field3"
        Me.field3.Size = New System.Drawing.Size(100, 23)
        Me.field3.TabIndex = 5
        '
        'field4
        '
        Me.field4.Location = New System.Drawing.Point(59, 176)
        Me.field4.Name = "field4"
        Me.field4.Size = New System.Drawing.Size(100, 23)
        Me.field4.TabIndex = 6
        '
        'field5
        '
        Me.field5.Location = New System.Drawing.Point(59, 205)
        Me.field5.Name = "field5"
        Me.field5.Size = New System.Drawing.Size(100, 23)
        Me.field5.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstButton
        '
        Me.firstButton.Location = New System.Drawing.Point(470, 415)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(75, 23)
        Me.firstButton.TabIndex = 10
        Me.firstButton.Text = "First"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'prevButton
        '
        Me.prevButton.Location = New System.Drawing.Point(551, 415)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(75, 23)
        Me.prevButton.TabIndex = 11
        Me.prevButton.Text = "Previous"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(632, 415)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 12
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(713, 415)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(75, 23)
        Me.lastButton.TabIndex = 13
        Me.lastButton.Text = "Last"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "0003"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "0004"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "0005"
        '
        'pos1
        '
        Me.pos1.Location = New System.Drawing.Point(12, 419)
        Me.pos1.Name = "pos1"
        Me.pos1.Size = New System.Drawing.Size(15, 15)
        Me.pos1.TabIndex = 17
        Me.pos1.Text = "1"
        '
        'pos2
        '
        Me.pos2.Location = New System.Drawing.Point(33, 419)
        Me.pos2.Name = "pos2"
        Me.pos2.Size = New System.Drawing.Size(15, 15)
        Me.pos2.TabIndex = 18
        Me.pos2.Text = "2"
        '
        'pos3
        '
        Me.pos3.Location = New System.Drawing.Point(54, 419)
        Me.pos3.Name = "pos3"
        Me.pos3.Size = New System.Drawing.Size(15, 15)
        Me.pos3.TabIndex = 19
        Me.pos3.Text = "3"
        '
        'pos4
        '
        Me.pos4.Location = New System.Drawing.Point(75, 419)
        Me.pos4.Name = "pos4"
        Me.pos4.Size = New System.Drawing.Size(15, 15)
        Me.pos4.TabIndex = 20
        Me.pos4.Text = "4"
        '
        'pos5
        '
        Me.pos5.Location = New System.Drawing.Point(96, 419)
        Me.pos5.Name = "pos5"
        Me.pos5.Size = New System.Drawing.Size(15, 15)
        Me.pos5.TabIndex = 21
        Me.pos5.Text = "5"
        '
        'pos6
        '
        Me.pos6.Location = New System.Drawing.Point(117, 419)
        Me.pos6.Name = "pos6"
        Me.pos6.Size = New System.Drawing.Size(15, 15)
        Me.pos6.TabIndex = 22
        Me.pos6.Text = "6"
        '
        'pos7
        '
        Me.pos7.Location = New System.Drawing.Point(138, 419)
        Me.pos7.Name = "pos7"
        Me.pos7.Size = New System.Drawing.Size(15, 15)
        Me.pos7.TabIndex = 23
        Me.pos7.Text = "7"
        '
        'pos8
        '
        Me.pos8.Location = New System.Drawing.Point(159, 419)
        Me.pos8.Name = "pos8"
        Me.pos8.Size = New System.Drawing.Size(15, 15)
        Me.pos8.TabIndex = 24
        Me.pos8.Text = "8"
        '
        'pos9
        '
        Me.pos9.Location = New System.Drawing.Point(180, 419)
        Me.pos9.Name = "pos9"
        Me.pos9.Size = New System.Drawing.Size(15, 15)
        Me.pos9.TabIndex = 25
        Me.pos9.Text = "9"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(201, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "10"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pos9)
        Me.Controls.Add(Me.pos8)
        Me.Controls.Add(Me.pos7)
        Me.Controls.Add(Me.pos6)
        Me.Controls.Add(Me.pos5)
        Me.Controls.Add(Me.pos4)
        Me.Controls.Add(Me.pos3)
        Me.Controls.Add(Me.pos2)
        Me.Controls.Add(Me.pos1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.firstButton)
        Me.Controls.Add(Me.field5)
        Me.Controls.Add(Me.field4)
        Me.Controls.Add(Me.field3)
        Me.Controls.Add(Me.field2)
        Me.Controls.Add(Me.field1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents field1 As TextBox
    Friend WithEvents field2 As TextBox
    Friend WithEvents field3 As TextBox
    Friend WithEvents field4 As TextBox
    Friend WithEvents field5 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents firstButton As Button
    Friend WithEvents prevButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents lastButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pos1 As Label
    Friend WithEvents pos2 As Label
    Friend WithEvents pos3 As Label
    Friend WithEvents pos4 As Label
    Friend WithEvents pos5 As Label
    Friend WithEvents pos6 As Label
    Friend WithEvents pos7 As Label
    Friend WithEvents pos8 As Label
    Friend WithEvents pos9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class
