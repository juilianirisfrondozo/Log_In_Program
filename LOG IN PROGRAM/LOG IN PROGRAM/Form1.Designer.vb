<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel1 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Heavy", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(135, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 39)
        Label1.TabIndex = 0
        Label1.Text = "LOG IN PROGRAM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(96, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 36)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(74, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 36)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGreen
        Button1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DarkGreen
        Button1.Location = New Point(333, 291)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 38)
        Button1.TabIndex = 3
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkRed
        Button2.Location = New Point(550, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 38)
        Button2.TabIndex = 4
        Button2.Text = "&EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Pink
        TextBox1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(333, 148)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(344, 32)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Pink
        TextBox2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(333, 218)
        TextBox2.MaxLength = 8
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(344, 32)
        TextBox2.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(115, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(562, 69)
        Panel1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(362, 369)
        Label4.Name = "Label4"
        Label4.Size = New Size(343, 25)
        Label4.TabIndex = 8
        Label4.Text = "Created by: Juilian Iris Frondozo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(779, 415)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOG IN PROGRAM"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label

End Class
