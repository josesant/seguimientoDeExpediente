<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_portada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_portada))
        Me.lbl_portada = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.lbl_Autonumeric = New System.Windows.Forms.Label()
        Me.lbl_asunto = New System.Windows.Forms.Label()
        Me.lbl_titu = New System.Windows.Forms.Label()
        Me.box_combo = New System.Windows.Forms.ComboBox()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_portada
        '
        Me.lbl_portada.AutoSize = True
        Me.lbl_portada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_portada.Location = New System.Drawing.Point(200, 29)
        Me.lbl_portada.Name = "lbl_portada"
        Me.lbl_portada.Size = New System.Drawing.Size(116, 31)
        Me.lbl_portada.TabIndex = 0
        Me.lbl_portada.Text = "Portada"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(49, 110)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(149, 25)
        Me.lbl_num.TabIndex = 1
        Me.lbl_num.Text = "N° Expediente"
        '
        'lbl_Autonumeric
        '
        Me.lbl_Autonumeric.AutoSize = True
        Me.lbl_Autonumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Autonumeric.Location = New System.Drawing.Point(292, 110)
        Me.lbl_Autonumeric.Name = "lbl_Autonumeric"
        Me.lbl_Autonumeric.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_Autonumeric.Size = New System.Drawing.Size(144, 25)
        Me.lbl_Autonumeric.TabIndex = 2
        Me.lbl_Autonumeric.Text = "Autonumerico"
        '
        'lbl_asunto
        '
        Me.lbl_asunto.AutoSize = True
        Me.lbl_asunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_asunto.Location = New System.Drawing.Point(77, 159)
        Me.lbl_asunto.Name = "lbl_asunto"
        Me.lbl_asunto.Size = New System.Drawing.Size(79, 25)
        Me.lbl_asunto.TabIndex = 3
        Me.lbl_asunto.Text = "Asunto"
        '
        'lbl_titu
        '
        Me.lbl_titu.AutoSize = True
        Me.lbl_titu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titu.Location = New System.Drawing.Point(77, 207)
        Me.lbl_titu.Name = "lbl_titu"
        Me.lbl_titu.Size = New System.Drawing.Size(65, 25)
        Me.lbl_titu.TabIndex = 4
        Me.lbl_titu.Text = "Titulo"
        '
        'box_combo
        '
        Me.box_combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_combo.FormattingEnabled = True
        Me.box_combo.Location = New System.Drawing.Point(273, 156)
        Me.box_combo.Name = "box_combo"
        Me.box_combo.Size = New System.Drawing.Size(158, 33)
        Me.box_combo.TabIndex = 5
        '
        'txt_titulo
        '
        Me.txt_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo.Location = New System.Drawing.Point(273, 204)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(158, 31)
        Me.txt_titulo.TabIndex = 6
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(77, 257)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(72, 25)
        Me.lbl_fecha.TabIndex = 7
        Me.lbl_fecha.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(254, 260)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(202, 332)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(114, 39)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "Agregar Portada"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'frm_portada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(530, 415)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.box_combo)
        Me.Controls.Add(Me.lbl_titu)
        Me.Controls.Add(Me.lbl_asunto)
        Me.Controls.Add(Me.lbl_Autonumeric)
        Me.Controls.Add(Me.lbl_num)
        Me.Controls.Add(Me.lbl_portada)
        Me.Name = "frm_portada"
        Me.Text = "Portada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_portada As Label
    Friend WithEvents lbl_num As Label
    Friend WithEvents lbl_Autonumeric As Label
    Friend WithEvents lbl_asunto As Label
    Friend WithEvents lbl_titu As Label
    Friend WithEvents box_combo As ComboBox
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_agregar As Button
End Class
