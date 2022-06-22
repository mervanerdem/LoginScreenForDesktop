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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUsername = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogin.Appearance.Options.UseForeColor = True
        Me.BtnLogin.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent
        Me.BtnLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnLogin.ImageOptions.SvgImage = CType(resources.GetObject("BtnLogin.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnLogin.Location = New System.Drawing.Point(114, 161)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnLogin.Size = New System.Drawing.Size(75, 34)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Login"
        '
        'BtnExit
        '
        Me.BtnExit.Appearance.ForeColor = System.Drawing.Color.IndianRed
        Me.BtnExit.Appearance.Options.UseForeColor = True
        Me.BtnExit.ImageOptions.SvgImage = CType(resources.GetObject("BtnExit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnExit.Location = New System.Drawing.Point(195, 161)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnExit.Size = New System.Drawing.Size(75, 34)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(67, 121)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPassword.Properties.Appearance.Options.UseFont = True
        Me.TxtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtPassword.Properties.UseSystemPasswordChar = True
        Me.TxtPassword.Size = New System.Drawing.Size(203, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtUsername
        '
        Me.TxtUsername.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.TxtUsername.Location = New System.Drawing.Point(67, 78)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUsername.Properties.Appearance.Options.UseFont = True
        Me.TxtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUsername.Size = New System.Drawing.Size(203, 20)
        Me.TxtUsername.TabIndex = 3
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(403, 224)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnLogin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUsername As DevExpress.XtraEditors.TextEdit
End Class
