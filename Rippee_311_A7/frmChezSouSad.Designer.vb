<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChezSouSad
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
        Me.btnRightRaw = New System.Windows.Forms.Button()
        Me.btnLeftRaw = New System.Windows.Forms.Button()
        Me.btnRightPrep = New System.Windows.Forms.Button()
        Me.btnLeftPrep = New System.Windows.Forms.Button()
        Me.lstRawSelected = New System.Windows.Forms.ListBox()
        Me.lblSelectedPrep = New System.Windows.Forms.Label()
        Me.lstPreppedSelected = New System.Windows.Forms.ListBox()
        Me.lblSelectedDish = New System.Windows.Forms.Label()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.lstRaw = New System.Windows.Forms.ListBox()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.txtPrep = New System.Windows.Forms.TextBox()
        Me.btnAddPrep = New System.Windows.Forms.Button()
        Me.lstPrep = New System.Windows.Forms.ListBox()
        Me.lblPrep = New System.Windows.Forms.Label()
        Me.txtDish = New System.Windows.Forms.TextBox()
        Me.btnAddDish = New System.Windows.Forms.Button()
        Me.lstDish = New System.Windows.Forms.ListBox()
        Me.lblDish = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRightRaw
        '
        Me.btnRightRaw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRightRaw.Location = New System.Drawing.Point(335, 472)
        Me.btnRightRaw.Name = "btnRightRaw"
        Me.btnRightRaw.Size = New System.Drawing.Size(104, 42)
        Me.btnRightRaw.TabIndex = 39
        Me.btnRightRaw.Text = "->"
        Me.btnRightRaw.UseVisualStyleBackColor = True
        Me.btnRightRaw.Visible = False
        '
        'btnLeftRaw
        '
        Me.btnLeftRaw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLeftRaw.Location = New System.Drawing.Point(335, 420)
        Me.btnLeftRaw.Name = "btnLeftRaw"
        Me.btnLeftRaw.Size = New System.Drawing.Size(104, 42)
        Me.btnLeftRaw.TabIndex = 38
        Me.btnLeftRaw.Text = "<-"
        Me.btnLeftRaw.UseVisualStyleBackColor = True
        Me.btnLeftRaw.Visible = False
        '
        'btnRightPrep
        '
        Me.btnRightPrep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRightPrep.Location = New System.Drawing.Point(335, 276)
        Me.btnRightPrep.Name = "btnRightPrep"
        Me.btnRightPrep.Size = New System.Drawing.Size(104, 42)
        Me.btnRightPrep.TabIndex = 37
        Me.btnRightPrep.Text = "->"
        Me.btnRightPrep.UseVisualStyleBackColor = True
        Me.btnRightPrep.Visible = False
        '
        'btnLeftPrep
        '
        Me.btnLeftPrep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLeftPrep.Location = New System.Drawing.Point(335, 224)
        Me.btnLeftPrep.Name = "btnLeftPrep"
        Me.btnLeftPrep.Size = New System.Drawing.Size(104, 42)
        Me.btnLeftPrep.TabIndex = 36
        Me.btnLeftPrep.Text = "<-"
        Me.btnLeftPrep.UseVisualStyleBackColor = True
        Me.btnLeftPrep.Visible = False
        '
        'lstRawSelected
        '
        Me.lstRawSelected.FormattingEnabled = True
        Me.lstRawSelected.ItemHeight = 15
        Me.lstRawSelected.Location = New System.Drawing.Point(12, 420)
        Me.lstRawSelected.Name = "lstRawSelected"
        Me.lstRawSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRawSelected.Size = New System.Drawing.Size(300, 94)
        Me.lstRawSelected.TabIndex = 35
        '
        'lblSelectedPrep
        '
        Me.lblSelectedPrep.AutoSize = True
        Me.lblSelectedPrep.Location = New System.Drawing.Point(12, 401)
        Me.lblSelectedPrep.Name = "lblSelectedPrep"
        Me.lblSelectedPrep.Size = New System.Drawing.Size(228, 15)
        Me.lblSelectedPrep.TabIndex = 34
        Me.lblSelectedPrep.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'lstPreppedSelected
        '
        Me.lstPreppedSelected.FormattingEnabled = True
        Me.lstPreppedSelected.ItemHeight = 15
        Me.lstPreppedSelected.Location = New System.Drawing.Point(12, 224)
        Me.lstPreppedSelected.Name = "lstPreppedSelected"
        Me.lstPreppedSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstPreppedSelected.Size = New System.Drawing.Size(300, 94)
        Me.lstPreppedSelected.TabIndex = 33
        '
        'lblSelectedDish
        '
        Me.lblSelectedDish.AutoSize = True
        Me.lblSelectedDish.Location = New System.Drawing.Point(12, 205)
        Me.lblSelectedDish.Name = "lblSelectedDish"
        Me.lblSelectedDish.Size = New System.Drawing.Size(172, 15)
        Me.lblSelectedDish.TabIndex = 32
        Me.lblSelectedDish.Text = "Prepped Items in Selected Dish:"
        '
        'txtRaw
        '
        Me.txtRaw.Location = New System.Drawing.Point(545, 537)
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.Size = New System.Drawing.Size(281, 23)
        Me.txtRaw.TabIndex = 31
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(464, 520)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(75, 55)
        Me.btnAddRaw.TabIndex = 30
        Me.btnAddRaw.Text = "Add New Raw Ingr"
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'lstRaw
        '
        Me.lstRaw.FormattingEnabled = True
        Me.lstRaw.ItemHeight = 15
        Me.lstRaw.Location = New System.Drawing.Point(464, 420)
        Me.lstRaw.Name = "lstRaw"
        Me.lstRaw.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRaw.Size = New System.Drawing.Size(362, 94)
        Me.lstRaw.TabIndex = 29
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Location = New System.Drawing.Point(464, 401)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(114, 15)
        Me.lblRaw.TabIndex = 28
        Me.lblRaw.Text = "List of all Raw Items:"
        '
        'txtPrep
        '
        Me.txtPrep.Location = New System.Drawing.Point(545, 341)
        Me.txtPrep.Name = "txtPrep"
        Me.txtPrep.Size = New System.Drawing.Size(281, 23)
        Me.txtPrep.TabIndex = 27
        '
        'btnAddPrep
        '
        Me.btnAddPrep.Location = New System.Drawing.Point(464, 324)
        Me.btnAddPrep.Name = "btnAddPrep"
        Me.btnAddPrep.Size = New System.Drawing.Size(75, 55)
        Me.btnAddPrep.TabIndex = 26
        Me.btnAddPrep.Text = "Add New Prepped Item"
        Me.btnAddPrep.UseVisualStyleBackColor = True
        '
        'lstPrep
        '
        Me.lstPrep.FormattingEnabled = True
        Me.lstPrep.ItemHeight = 15
        Me.lstPrep.Location = New System.Drawing.Point(464, 224)
        Me.lstPrep.Name = "lstPrep"
        Me.lstPrep.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstPrep.Size = New System.Drawing.Size(362, 94)
        Me.lstPrep.TabIndex = 25
        '
        'lblPrep
        '
        Me.lblPrep.AutoSize = True
        Me.lblPrep.Location = New System.Drawing.Point(464, 205)
        Me.lblPrep.Name = "lblPrep"
        Me.lblPrep.Size = New System.Drawing.Size(136, 15)
        Me.lblPrep.TabIndex = 24
        Me.lblPrep.Text = "List of all Prepped Items:"
        '
        'txtDish
        '
        Me.txtDish.Location = New System.Drawing.Point(545, 146)
        Me.txtDish.Name = "txtDish"
        Me.txtDish.Size = New System.Drawing.Size(281, 23)
        Me.txtDish.TabIndex = 23
        '
        'btnAddDish
        '
        Me.btnAddDish.Location = New System.Drawing.Point(464, 129)
        Me.btnAddDish.Name = "btnAddDish"
        Me.btnAddDish.Size = New System.Drawing.Size(75, 55)
        Me.btnAddDish.TabIndex = 22
        Me.btnAddDish.Text = "Add New Dish"
        Me.btnAddDish.UseVisualStyleBackColor = True
        '
        'lstDish
        '
        Me.lstDish.FormattingEnabled = True
        Me.lstDish.ItemHeight = 15
        Me.lstDish.Location = New System.Drawing.Point(12, 29)
        Me.lstDish.Name = "lstDish"
        Me.lstDish.Size = New System.Drawing.Size(814, 94)
        Me.lstDish.TabIndex = 21
        '
        'lblDish
        '
        Me.lblDish.AutoSize = True
        Me.lblDish.Location = New System.Drawing.Point(12, 10)
        Me.lblDish.Name = "lblDish"
        Me.lblDish.Size = New System.Drawing.Size(94, 15)
        Me.lblDish.TabIndex = 20
        Me.lblDish.Text = "List of all Dishes:"
        '
        'frmChezSouSad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 605)
        Me.Controls.Add(Me.btnRightRaw)
        Me.Controls.Add(Me.btnLeftRaw)
        Me.Controls.Add(Me.btnRightPrep)
        Me.Controls.Add(Me.btnLeftPrep)
        Me.Controls.Add(Me.lstRawSelected)
        Me.Controls.Add(Me.lblSelectedPrep)
        Me.Controls.Add(Me.lstPreppedSelected)
        Me.Controls.Add(Me.lblSelectedDish)
        Me.Controls.Add(Me.txtRaw)
        Me.Controls.Add(Me.btnAddRaw)
        Me.Controls.Add(Me.lstRaw)
        Me.Controls.Add(Me.lblRaw)
        Me.Controls.Add(Me.txtPrep)
        Me.Controls.Add(Me.btnAddPrep)
        Me.Controls.Add(Me.lstPrep)
        Me.Controls.Add(Me.lblPrep)
        Me.Controls.Add(Me.txtDish)
        Me.Controls.Add(Me.btnAddDish)
        Me.Controls.Add(Me.lstDish)
        Me.Controls.Add(Me.lblDish)
        Me.Name = "frmChezSouSad"
        Me.Text = "Chez Sou Sad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRightRaw As Button
    Friend WithEvents btnLeftRaw As Button
    Friend WithEvents btnRightPrep As Button
    Friend WithEvents btnLeftPrep As Button
    Friend WithEvents lstRawSelected As ListBox
    Friend WithEvents lblSelectedPrep As Label
    Friend WithEvents lstPreppedSelected As ListBox
    Friend WithEvents lblSelectedDish As Label
    Friend WithEvents txtRaw As TextBox
    Friend WithEvents btnAddRaw As Button
    Friend WithEvents lstRaw As ListBox
    Friend WithEvents lblRaw As Label
    Friend WithEvents txtPrep As TextBox
    Friend WithEvents btnAddPrep As Button
    Friend WithEvents lstPrep As ListBox
    Friend WithEvents lblPrep As Label
    Friend WithEvents txtDish As TextBox
    Friend WithEvents btnAddDish As Button
    Friend WithEvents lstDish As ListBox
    Friend WithEvents lblDish As Label
End Class
