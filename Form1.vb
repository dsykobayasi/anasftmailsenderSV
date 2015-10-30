Public Class Form1
    Dim strMailAddress As String
    Dim strMailName As String
    Dim strMailPassword As String
    Dim strPOPServer As String
    Dim strPOPPort As String
    Dim strPOPAccount As String
    Dim strPOPPassword As String
    Dim strSMTPServer As String
    Dim strSMTPPort As String
    Dim strSMTPAccount As String
    Dim strSMTPPassword As String
    Dim timerflg As Boolean = False

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        Dim blnret As Boolean

        blnret = True

        blnret = mailsend(txtMailAddress.Text _
                          , My.Settings.MailName _
                          , txtMailPassword.Text _
                          , txtPOPServer.Text _
                          , txtPOPPort.Text _
                          , txtPOPAccount.Text _
                          , txtPOPPassword.Text _
                          , txtSMTPServer.Text _
                          , txtSMTPPort.Text _
                          , txtSMTPAccount.Text _
                          , txtSMTPPassword.Text _
                          , txtTO.Text _
                          , txtCC.Text _
                          , txtBCC.Text _
                          , txtSubject.Text _
                          , txtBody.Text)
    End Sub

    Private Sub btnGetKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetKey.Click
        getMailSettings()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clearSettings()
    End Sub

    Private Sub getMailSettings()
        strMailAddress = My.Settings.MailAddress
        strMailName = My.Settings.MailName
        strMailPassword = My.Settings.MailPassword
        strPOPServer = My.Settings.POPServer
        strPOPPort = My.Settings.POPPort
        strPOPAccount = My.Settings.POPAccount
        strPOPPassword = My.Settings.POPPassword
        strSMTPServer = My.Settings.SMTPServer
        strSMTPPort = My.Settings.SMTPPort
        strSMTPAccount = My.Settings.SMTPAccount
        strSMTPPassword = My.Settings.SMTPPassword

        setTextBox()
    End Sub

    Private Sub clearSettings()
        strMailAddress = ""
        strMailPassword = ""
        strPOPServer = ""
        strPOPPort = ""
        strPOPAccount = ""
        strPOPPassword = ""
        strSMTPServer = ""
        strSMTPPort = ""
        strSMTPAccount = ""
        strSMTPPassword = ""

        setTextBox()
    End Sub

    Private Sub setTextBox()
        txtMailAddress.Text = strMailName & "<" & strMailAddress & ">"
        txtMailPassword.Text = strMailPassword
        txtPOPServer.Text = strPOPServer
        txtPOPPort.Text = strPOPPort
        txtPOPAccount.Text = strPOPAccount
        txtPOPPassword.Text = strPOPPassword
        txtSMTPServer.Text = strSMTPServer
        txtSMTPPort.Text = strSMTPPort
        txtSMTPAccount.Text = strSMTPAccount
        txtSMTPPassword.Text = strSMTPPassword
    End Sub

    Private Sub btnClearKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearKey.Click
        clearSettings()
    End Sub

    Private Sub btnConnectDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectDB.Click
        If connectDb() Then
            MsgBox("DB接続成功")
        Else
            MsgBox("DB接続失敗")
        End If
    End Sub

    Private Sub btnCloseDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseDB.Click
        If closeDB() Then
            MsgBox("DB切断成功")
        Else
            MsgBox("DB切断失敗")
        End If
    End Sub

    Private Sub btnGetDataCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataCount.Click

    End Sub

    Private Sub btnIsSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIsSendMail.Click
        If isMailData() Then
            MsgBox("送信予定メールあり")
        Else
            MsgBox("送信予定メールなし")
        End If
    End Sub

    Private Sub btnSendMailTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMailTest.Click
        sendMailSub()
    End Sub

    Private Sub btnEnableTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnableTimer.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            btnEnableTimer.Text = "タイマー無効"
        Else
            Timer1.Enabled = False
            btnEnableTimer.Text = "タイマー有効"
        End If

        Timer1.Interval = 60000

    End Sub

    'timerイベント
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If timerflg = False Then
            timerflg = True

            sendMailSub()

            timerflg = False
        End If
    End Sub

    Private Sub btnconvertMailAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvertMailAddress.Click
        MsgBox(convertMailAddress(InputBox("メールアドレス")))
    End Sub
End Class
