<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_foja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_foja))
        Me.lbl_foja = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.lbl_descrip = New System.Windows.Forms.Label()
        Me.lbl_autonumerico = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_foja
        '
        Me.lbl_foja.AutoSize = True
        Me.lbl_foja.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_foja.Location = New System.Drawing.Point(315, 27)
        Me.lbl_foja.Name = "lbl_foja"
        Me.lbl_foja.Size = New System.Drawing.Size(71, 31)
        Me.lbl_foja.TabIndex = 0
        Me.lbl_foja.Text = "Foja"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(206, 79)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(87, 25)
        Me.lbl_num.TabIndex = 1
        Me.lbl_num.Text = "Número"
        '
        'lbl_descrip
        '
        Me.lbl_descrip.AutoSize = True
        Me.lbl_descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descrip.Location = New System.Drawing.Point(180, 133)
        Me.lbl_descrip.Name = "lbl_descrip"
        Me.lbl_descrip.Size = New System.Drawing.Size(125, 25)
        Me.lbl_descrip.TabIndex = 2
        Me.lbl_descrip.Text = "Descripción"
        '
        'lbl_autonumerico
        '
        Me.lbl_autonumerico.AutoSize = True
        Me.lbl_autonumerico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autonumerico.Location = New System.Drawing.Point(394, 79)
        Me.lbl_autonumerico.Name = "lbl_autonumerico"
        Me.lbl_autonumerico.Size = New System.Drawing.Size(119, 25)
        Me.lbl_autonumerico.TabIndex = 3
        Me.lbl_autonumerico.Text = "Automatico"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(387, 122)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(333, 211)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(286, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_foja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lbl_autonumerico)
        Me.Controls.Add(Me.lbl_descrip)
        Me.Controls.Add(Me.lbl_num)
        Me.Controls.Add(Me.lbl_foja)
        Me.Name = "frm_foja"
        Me.Text = "Agergar Foja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_foja As Label
    Friend WithEvents lbl_num As Label
    Friend WithEvents lbl_descrip As Label
    Friend WithEvents lbl_autonumerico As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
