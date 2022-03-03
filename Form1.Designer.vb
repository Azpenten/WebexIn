<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Prof1 = New System.Windows.Forms.Label()
        Me.Time1 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Prof2 = New System.Windows.Forms.Label()
        Me.Time2 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Prof3 = New System.Windows.Forms.Label()
        Me.Time3 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Сегодня:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "[Дата]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Prof1)
        Me.GroupBox1.Controls.Add(Me.Time1)
        Me.GroupBox1.Controls.Add(Me.Name1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Первая пара"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(359, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "<Идёт>"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label13.Visible = False
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Преподаватель:"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Время:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Предмет:"
        '
        'Prof1
        '
        Me.Prof1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Prof1.AutoSize = True
        Me.Prof1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Prof1.Location = New System.Drawing.Point(144, 62)
        Me.Prof1.Name = "Prof1"
        Me.Prof1.Size = New System.Drawing.Size(63, 20)
        Me.Prof1.TabIndex = 2
        Me.Prof1.Text = "[Имя1]"
        '
        'Time1
        '
        Me.Time1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Time1.AutoSize = True
        Me.Time1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Time1.Location = New System.Drawing.Point(74, 42)
        Me.Time1.Name = "Time1"
        Me.Time1.Size = New System.Drawing.Size(83, 20)
        Me.Time1.TabIndex = 1
        Me.Time1.Text = "[Время1]"
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name1.Location = New System.Drawing.Point(95, 22)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(111, 20)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "[Название1]"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Prof2)
        Me.GroupBox2.Controls.Add(Me.Time2)
        Me.GroupBox2.Controls.Add(Me.Name2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Вторая пара"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(363, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "<Идёт>"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label14.Visible = False
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Преподаватель:"
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Время:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Предмет:"
        '
        'Prof2
        '
        Me.Prof2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Prof2.AutoSize = True
        Me.Prof2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Prof2.Location = New System.Drawing.Point(144, 62)
        Me.Prof2.Name = "Prof2"
        Me.Prof2.Size = New System.Drawing.Size(63, 20)
        Me.Prof2.TabIndex = 2
        Me.Prof2.Text = "[Имя2]"
        '
        'Time2
        '
        Me.Time2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Time2.AutoSize = True
        Me.Time2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Time2.Location = New System.Drawing.Point(74, 42)
        Me.Time2.Name = "Time2"
        Me.Time2.Size = New System.Drawing.Size(83, 20)
        Me.Time2.TabIndex = 1
        Me.Time2.Text = "[Время2]"
        '
        'Name2
        '
        Me.Name2.AutoSize = True
        Me.Name2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name2.Location = New System.Drawing.Point(95, 22)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(111, 20)
        Me.Name2.TabIndex = 0
        Me.Name2.Text = "[Название2]"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Prof3)
        Me.GroupBox3.Controls.Add(Me.Time3)
        Me.GroupBox3.Controls.Add(Me.Name3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Третья пара"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(329, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "<Идёт>"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label15.Visible = False
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Преподаватель:"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Время:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Предмет:"
        '
        'Prof3
        '
        Me.Prof3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Prof3.AutoSize = True
        Me.Prof3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Prof3.Location = New System.Drawing.Point(144, 62)
        Me.Prof3.Name = "Prof3"
        Me.Prof3.Size = New System.Drawing.Size(63, 20)
        Me.Prof3.TabIndex = 2
        Me.Prof3.Text = "[Имя3]"
        '
        'Time3
        '
        Me.Time3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Time3.AutoSize = True
        Me.Time3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Time3.Location = New System.Drawing.Point(74, 42)
        Me.Time3.Name = "Time3"
        Me.Time3.Size = New System.Drawing.Size(83, 20)
        Me.Time3.TabIndex = 1
        Me.Time3.Text = "[Время3]"
        '
        'Name3
        '
        Me.Name3.AutoSize = True
        Me.Name3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name3.Location = New System.Drawing.Point(95, 22)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(111, 20)
        Me.Name3.TabIndex = 0
        Me.Name3.Text = "[Название3]"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(382, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Подключение"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 19)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "[Время]"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(286, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Вручную"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 422)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(540, 460)
        Me.MinimumSize = New System.Drawing.Size(540, 460)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebexIn v2.0b"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Name1 As Label
    Friend WithEvents Time1 As Label
    Friend WithEvents Prof1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Prof2 As Label
    Friend WithEvents Time2 As Label
    Friend WithEvents Name2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Prof3 As Label
    Friend WithEvents Time3 As Label
    Friend WithEvents Name3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
End Class
