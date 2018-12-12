<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nuevoUsuario))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_dni = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apelli = New System.Windows.Forms.Label()
        Me.lbl_domici = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(144, 35)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(207, 31)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Nuevo Usuario"
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dni.Location = New System.Drawing.Point(113, 107)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(47, 25)
        Me.lbl_dni.TabIndex = 2
        Me.lbl_dni.Text = "DNI"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(73, 152)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(87, 25)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apelli
        '
        Me.lbl_apelli.AutoSize = True
        Me.lbl_apelli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apelli.Location = New System.Drawing.Point(71, 199)
        Me.lbl_apelli.Name = "lbl_apelli"
        Me.lbl_apelli.Size = New System.Drawing.Size(89, 25)
        Me.lbl_apelli.TabIndex = 4
        Me.lbl_apelli.Text = "Apellido"
        '
        'lbl_domici
        '
        Me.lbl_domici.AutoSize = True
        Me.lbl_domici.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_domici.Location = New System.Drawing.Point(61, 242)
        Me.lbl_domici.Name = "lbl_domici"
        Me.lbl_domici.Size = New System.Drawing.Size(99, 25)
        Me.lbl_domici.TabIndex = 5
        Me.lbl_domici.Text = "Domicilio"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel.Location = New System.Drawing.Point(61, 289)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(96, 25)
        Me.lbl_tel.TabIndex = 6
        Me.lbl_tel.Text = "Teléfono"
        '
        'txt_dni
        '
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(192, 104)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(183, 31)
        Me.txt_dni.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(192, 149)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(183, 31)
        Me.txt_nombre.TabIndex = 8
        '
        'txt_apellido
        '
        Me.txt_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(192, 196)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(183, 31)
        Me.txt_apellido.TabIndex = 9
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domicilio.Location = New System.Drawing.Point(192, 239)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(183, 31)
        Me.txt_domicilio.TabIndex = 10
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(192, 286)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(183, 31)
        Me.txt_tel.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(194, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(194, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_nuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(477, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.lbl_tel)
        Me.Controls.Add(Me.lbl_domici)
        Me.Controls.Add(Me.lbl_apelli)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_dni)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "frm_nuevoUsuario"
        Me.Text = "Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_dni As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_apelli As Label
    Friend WithEvents lbl_domici As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_domicilio As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
