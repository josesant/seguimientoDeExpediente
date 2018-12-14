<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_oficina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_oficina))
        Me.lbl_oficina = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.lbl_ubicacion = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_oficina
        '
        Me.lbl_oficina.AutoSize = True
        Me.lbl_oficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oficina.Location = New System.Drawing.Point(222, 29)
        Me.lbl_oficina.Name = "lbl_oficina"
        Me.lbl_oficina.Size = New System.Drawing.Size(106, 31)
        Me.lbl_oficina.TabIndex = 0
        Me.lbl_oficina.Text = "Oficina"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(76, 92)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(87, 25)
        Me.lbl_num.TabIndex = 1
        Me.lbl_num.Text = "Numero"
        '
        'lbl_ubicacion
        '
        Me.lbl_ubicacion.AutoSize = True
        Me.lbl_ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ubicacion.Location = New System.Drawing.Point(59, 144)
        Me.lbl_ubicacion.Name = "lbl_ubicacion"
        Me.lbl_ubicacion.Size = New System.Drawing.Size(104, 25)
        Me.lbl_ubicacion.TabIndex = 2
        Me.lbl_ubicacion.Text = "ubicacion"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(76, 199)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(87, 25)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.Location = New System.Drawing.Point(228, 92)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(180, 31)
        Me.txt_num.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(228, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 31)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(228, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 31)
        Me.TextBox2.TabIndex = 6
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(228, 264)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(124, 45)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'frm_oficina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(498, 348)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_ubicacion)
        Me.Controls.Add(Me.lbl_num)
        Me.Controls.Add(Me.lbl_oficina)
        Me.Name = "frm_oficina"
        Me.Text = "Oficina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_oficina As Label
    Friend WithEvents lbl_num As Label
    Friend WithEvents lbl_ubicacion As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_agregar As Button
End Class
