<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtMailAddress = New System.Windows.Forms.TextBox
        Me.txtMailPassword = New System.Windows.Forms.TextBox
        Me.txtPOPServer = New System.Windows.Forms.TextBox
        Me.txtPOPPort = New System.Windows.Forms.TextBox
        Me.txtPOPAccount = New System.Windows.Forms.TextBox
        Me.txtPOPPassword = New System.Windows.Forms.TextBox
        Me.txtSMTPServer = New System.Windows.Forms.TextBox
        Me.txtSMTPPort = New System.Windows.Forms.TextBox
        Me.txtSMTPAccount = New System.Windows.Forms.TextBox
        Me.txtSMTPPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTO = New System.Windows.Forms.TextBox
        Me.txtCC = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtBCC = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.lblSubject = New System.Windows.Forms.Label
        Me.txtBody = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmdSend = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnGetKey = New System.Windows.Forms.Button
        Me.btnClearKey = New System.Windows.Forms.Button
        Me.btnConnectDB = New System.Windows.Forms.Button
        Me.btnCloseDB = New System.Windows.Forms.Button
        Me.btnGetDataCount = New System.Windows.Forms.Button
        Me.btnIsSendMail = New System.Windows.Forms.Button
        Me.btnSendMailTest = New System.Windows.Forms.Button
        Me.ANASOFTMAILDataSet = New anasftmailsenderSV.ANASOFTMAILDataSet
        Me.btnEnableTimer = New System.Windows.Forms.Button
        Me.btnconvertMailAddress = New System.Windows.Forms.Button
        CType(Me.ANASOFTMAILDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMailAddress
        '
        Me.txtMailAddress.Location = New System.Drawing.Point(128, 8)
        Me.txtMailAddress.Name = "txtMailAddress"
        Me.txtMailAddress.Size = New System.Drawing.Size(209, 19)
        Me.txtMailAddress.TabIndex = 0
        Me.txtMailAddress.Text = "anasoftmail@bell.ocn.ne.jp"
        '
        'txtMailPassword
        '
        Me.txtMailPassword.Location = New System.Drawing.Point(128, 33)
        Me.txtMailPassword.Name = "txtMailPassword"
        Me.txtMailPassword.Size = New System.Drawing.Size(209, 19)
        Me.txtMailPassword.TabIndex = 1
        Me.txtMailPassword.Text = "AnasoftMa!!"
        Me.txtMailPassword.UseSystemPasswordChar = True
        '
        'txtPOPServer
        '
        Me.txtPOPServer.Location = New System.Drawing.Point(128, 80)
        Me.txtPOPServer.Name = "txtPOPServer"
        Me.txtPOPServer.Size = New System.Drawing.Size(209, 19)
        Me.txtPOPServer.TabIndex = 2
        Me.txtPOPServer.Text = "pop.ocn.ne.jp"
        '
        'txtPOPPort
        '
        Me.txtPOPPort.Location = New System.Drawing.Point(128, 105)
        Me.txtPOPPort.Name = "txtPOPPort"
        Me.txtPOPPort.Size = New System.Drawing.Size(209, 19)
        Me.txtPOPPort.TabIndex = 3
        Me.txtPOPPort.Text = "110"
        '
        'txtPOPAccount
        '
        Me.txtPOPAccount.Location = New System.Drawing.Point(128, 130)
        Me.txtPOPAccount.Name = "txtPOPAccount"
        Me.txtPOPAccount.Size = New System.Drawing.Size(209, 19)
        Me.txtPOPAccount.TabIndex = 4
        Me.txtPOPAccount.Text = "anasoftmail@bell.ocn.ne.jp"
        '
        'txtPOPPassword
        '
        Me.txtPOPPassword.Location = New System.Drawing.Point(128, 155)
        Me.txtPOPPassword.Name = "txtPOPPassword"
        Me.txtPOPPassword.Size = New System.Drawing.Size(209, 19)
        Me.txtPOPPassword.TabIndex = 5
        Me.txtPOPPassword.Text = "AnasoftMa!!"
        Me.txtPOPPassword.UseSystemPasswordChar = True
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.Location = New System.Drawing.Point(128, 209)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(209, 19)
        Me.txtSMTPServer.TabIndex = 6
        Me.txtSMTPServer.Text = "smtp.ocn.ne.jp"
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Location = New System.Drawing.Point(128, 234)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(209, 19)
        Me.txtSMTPPort.TabIndex = 7
        Me.txtSMTPPort.Text = "587"
        '
        'txtSMTPAccount
        '
        Me.txtSMTPAccount.Location = New System.Drawing.Point(128, 259)
        Me.txtSMTPAccount.Name = "txtSMTPAccount"
        Me.txtSMTPAccount.Size = New System.Drawing.Size(209, 19)
        Me.txtSMTPAccount.TabIndex = 8
        Me.txtSMTPAccount.Text = "anasoftmail@bell.ocn.ne.jp"
        '
        'txtSMTPPassword
        '
        Me.txtSMTPPassword.Location = New System.Drawing.Point(128, 284)
        Me.txtSMTPPassword.Name = "txtSMTPPassword"
        Me.txtSMTPPassword.Size = New System.Drawing.Size(209, 19)
        Me.txtSMTPPassword.TabIndex = 9
        Me.txtSMTPPassword.Text = "AnasoftMa!!"
        Me.txtSMTPPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "メールアドレス"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "メールパスワード"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "サーバ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ポート"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ＰＯＰサーバ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "アカウント"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "パスワード"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 12)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "パスワード"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "アカウント"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ＳＭＴＰサーバ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 12)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "ポート"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 12)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "サーバ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 12)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "ＴＯ"
        '
        'txtTO
        '
        Me.txtTO.Location = New System.Drawing.Point(128, 334)
        Me.txtTO.Name = "txtTO"
        Me.txtTO.Size = New System.Drawing.Size(206, 19)
        Me.txtTO.TabIndex = 23
        Me.txtTO.Text = "daira1903@gmail.com, daira1903_sma2008_prv@yahoo.co.jp, ma785gm_propus620@docomo." & _
            "ne.jp,  0rk1.903726253g@ezweb.ne.jp"
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(128, 359)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(206, 19)
        Me.txtCC.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 362)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 12)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "ＣＣ"
        '
        'txtBCC
        '
        Me.txtBCC.Location = New System.Drawing.Point(128, 384)
        Me.txtBCC.Name = "txtBCC"
        Me.txtBCC.Size = New System.Drawing.Size(206, 19)
        Me.txtBCC.TabIndex = 27
        Me.txtBCC.Text = "daira1903@gmail.com, daira1903_sma2008_prv@yahoo.co.jp, ma785gm_propus620@docomo." & _
            "ne.jp,  0rk1.903726253g@ezweb.ne.jp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 387)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 12)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "ＢＣＣ"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(128, 427)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(206, 19)
        Me.txtSubject.TabIndex = 29
        Me.txtSubject.Text = "テストメール送信"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(20, 430)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(29, 12)
        Me.lblSubject.TabIndex = 28
        Me.lblSubject.Text = "件名"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(128, 468)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(393, 113)
        Me.txtBody.TabIndex = 31
        Me.txtBody.Text = resources.GetString("txtBody.Text")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 471)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 12)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "本文"
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(388, 593)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(133, 36)
        Me.cmdSend.TabIndex = 32
        Me.cmdSend.Text = "送信"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'btnGetKey
        '
        Me.btnGetKey.Location = New System.Drawing.Point(79, 593)
        Me.btnGetKey.Name = "btnGetKey"
        Me.btnGetKey.Size = New System.Drawing.Size(102, 35)
        Me.btnGetKey.TabIndex = 33
        Me.btnGetKey.Text = "キー取得"
        Me.btnGetKey.UseVisualStyleBackColor = True
        '
        'btnClearKey
        '
        Me.btnClearKey.Location = New System.Drawing.Point(231, 596)
        Me.btnClearKey.Name = "btnClearKey"
        Me.btnClearKey.Size = New System.Drawing.Size(119, 31)
        Me.btnClearKey.TabIndex = 34
        Me.btnClearKey.Text = "キークリア"
        Me.btnClearKey.UseVisualStyleBackColor = True
        '
        'btnConnectDB
        '
        Me.btnConnectDB.Location = New System.Drawing.Point(437, 225)
        Me.btnConnectDB.Name = "btnConnectDB"
        Me.btnConnectDB.Size = New System.Drawing.Size(117, 37)
        Me.btnConnectDB.TabIndex = 35
        Me.btnConnectDB.Text = "db接続"
        Me.btnConnectDB.UseVisualStyleBackColor = True
        '
        'btnCloseDB
        '
        Me.btnCloseDB.Location = New System.Drawing.Point(439, 284)
        Me.btnCloseDB.Name = "btnCloseDB"
        Me.btnCloseDB.Size = New System.Drawing.Size(117, 37)
        Me.btnCloseDB.TabIndex = 36
        Me.btnCloseDB.Text = "db切断"
        Me.btnCloseDB.UseVisualStyleBackColor = True
        '
        'btnGetDataCount
        '
        Me.btnGetDataCount.Location = New System.Drawing.Point(437, 167)
        Me.btnGetDataCount.Name = "btnGetDataCount"
        Me.btnGetDataCount.Size = New System.Drawing.Size(114, 38)
        Me.btnGetDataCount.TabIndex = 37
        Me.btnGetDataCount.Text = "メール件数確認"
        Me.btnGetDataCount.UseVisualStyleBackColor = True
        '
        'btnIsSendMail
        '
        Me.btnIsSendMail.Location = New System.Drawing.Point(437, 108)
        Me.btnIsSendMail.Name = "btnIsSendMail"
        Me.btnIsSendMail.Size = New System.Drawing.Size(119, 39)
        Me.btnIsSendMail.TabIndex = 38
        Me.btnIsSendMail.Text = "送信メールはあるか？"
        Me.btnIsSendMail.UseVisualStyleBackColor = True
        '
        'btnSendMailTest
        '
        Me.btnSendMailTest.Location = New System.Drawing.Point(437, 49)
        Me.btnSendMailTest.Name = "btnSendMailTest"
        Me.btnSendMailTest.Size = New System.Drawing.Size(133, 39)
        Me.btnSendMailTest.TabIndex = 39
        Me.btnSendMailTest.Text = "送信テスト"
        Me.btnSendMailTest.UseVisualStyleBackColor = True
        '
        'ANASOFTMAILDataSet
        '
        Me.ANASOFTMAILDataSet.DataSetName = "ANASOFTMAILDataSet"
        Me.ANASOFTMAILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEnableTimer
        '
        Me.btnEnableTimer.Location = New System.Drawing.Point(437, 343)
        Me.btnEnableTimer.Name = "btnEnableTimer"
        Me.btnEnableTimer.Size = New System.Drawing.Size(119, 35)
        Me.btnEnableTimer.TabIndex = 40
        Me.btnEnableTimer.Text = "タイマー無効"
        Me.btnEnableTimer.UseVisualStyleBackColor = True
        '
        'btnconvertMailAddress
        '
        Me.btnconvertMailAddress.Location = New System.Drawing.Point(439, 407)
        Me.btnconvertMailAddress.Name = "btnconvertMailAddress"
        Me.btnconvertMailAddress.Size = New System.Drawing.Size(119, 35)
        Me.btnconvertMailAddress.TabIndex = 41
        Me.btnconvertMailAddress.Text = "不正文字除去"
        Me.btnconvertMailAddress.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 641)
        Me.Controls.Add(Me.btnconvertMailAddress)
        Me.Controls.Add(Me.btnEnableTimer)
        Me.Controls.Add(Me.btnSendMailTest)
        Me.Controls.Add(Me.btnIsSendMail)
        Me.Controls.Add(Me.btnGetDataCount)
        Me.Controls.Add(Me.btnCloseDB)
        Me.Controls.Add(Me.btnConnectDB)
        Me.Controls.Add(Me.btnClearKey)
        Me.Controls.Add(Me.btnGetKey)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.txtBCC)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSMTPPassword)
        Me.Controls.Add(Me.txtSMTPAccount)
        Me.Controls.Add(Me.txtSMTPPort)
        Me.Controls.Add(Me.txtSMTPServer)
        Me.Controls.Add(Me.txtPOPPassword)
        Me.Controls.Add(Me.txtPOPAccount)
        Me.Controls.Add(Me.txtPOPPort)
        Me.Controls.Add(Me.txtPOPServer)
        Me.Controls.Add(Me.txtMailPassword)
        Me.Controls.Add(Me.txtMailAddress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ANASOFTMAILDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ANASOFTMAILDataSet As anasftmailsenderSV.ANASOFTMAILDataSet
    Friend WithEvents txtMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMailPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPOPServer As System.Windows.Forms.TextBox
    Friend WithEvents txtPOPPort As System.Windows.Forms.TextBox
    Friend WithEvents txtPOPAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPOPPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPServer As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTO As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBCC As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnGetKey As System.Windows.Forms.Button
    Friend WithEvents btnClearKey As System.Windows.Forms.Button
    Friend WithEvents btnConnectDB As System.Windows.Forms.Button
    Friend WithEvents btnCloseDB As System.Windows.Forms.Button
    Friend WithEvents btnGetDataCount As System.Windows.Forms.Button
    Friend WithEvents btnIsSendMail As System.Windows.Forms.Button
    Friend WithEvents btnSendMailTest As System.Windows.Forms.Button
    Friend WithEvents btnEnableTimer As System.Windows.Forms.Button
    Friend WithEvents btnconvertMailAddress As System.Windows.Forms.Button

End Class
