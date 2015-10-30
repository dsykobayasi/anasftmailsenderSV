Imports System.Net
Imports System.Web
Imports System.Text.RegularExpressions

Module sendMail

    Public cSqlConnection As System.Data.SqlClient.SqlConnection
    Public msc As New System.Net.Mail.SmtpClient()

    Private Function BEncode(ByVal str As String, ByVal encoding As System.Text.Encoding) As String
        Return String.Format("=?{0}?B?{1}?=", encoding.HeaderName, Convert.ToBase64String(encoding.GetBytes(str)))
    End Function

    Public Function mailServerConnect(ByVal MailAddress As String _
                     , ByVal MailName As String _
                     , ByVal MailPassword As String _
                     , ByVal POPServer As String _
                     , ByVal POPPort As String _
                     , ByVal POPAccount As String _
                     , ByVal POPPassword As String _
                     , ByVal SMTPServer As String _
                     , ByVal SMTPPort As String _
                     , ByVal SMTPAccount As String _
                     , ByVal SMTPPassword As String) As Boolean
        Try
            msc = New System.Net.Mail.SmtpClient()
            'SMTPサーバーの設定をする
            msc.Host = SMTPServer
            msc.Port = SMTPPort
            msc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
            'SSL認証を有効にする
            msc.EnableSsl = True
            'ユーザー名とパスワードを設定する
            msc.Credentials = New System.Net.NetworkCredential(SMTPAccount, SMTPPassword)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'メール送信
    Public Function mailsend(ByVal MailAddress As String _
                     , ByVal MailName As String _
                     , ByVal MailPassword As String _
                     , ByVal POPServer As String _
                     , ByVal POPPort As String _
                     , ByVal POPAccount As String _
                     , ByVal POPPassword As String _
                     , ByVal SMTPServer As String _
                     , ByVal SMTPPort As String _
                     , ByVal SMTPAccount As String _
                     , ByVal SMTPPassword As String _
                     , ByVal MAILTO As String _
                     , ByVal MAILCC As String _
                     , ByVal MAILBCC As String _
                     , ByVal Subject As String _
                     , ByVal Body As String) As Boolean



        Dim msg As New System.Net.Mail.MailMessage()
        Dim SpecialDomain As String = My.Settings.SpecialDomain
        Dim SpecialAccount As String = ""
        Dim NormalAccount As String = ""

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim myEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding(50220)

        Try
            If MAILBCC <> "" Then
                For i = 0 To UBound(Split(MAILBCC, ","))
                    For j = 0 To UBound(Split(SpecialDomain, ","))
                        '特別なドメインのメールアドレスか特定する。
                        If InStr(Split(MAILBCC, ",")(i), Split(SpecialDomain, ",")(j)) > 0 Then
                            If SpecialAccount <> "" Then
                                SpecialAccount = SpecialAccount & "," & Split(MAILBCC, ",")(i)
                            Else
                                SpecialAccount = Split(MAILBCC, ",")(i)
                            End If
                        Else
                            If NormalAccount <> "" Then
                                NormalAccount = NormalAccount & "," & Split(MAILBCC, ",")(i)
                            Else
                                NormalAccount = Split(MAILBCC, ",")(i)
                            End If
                        End If
                    Next
                Next
            End If


            msg.From = New System.Net.Mail.MailAddress(MailAddress, BEncode(MailName, myEnc))
            'If MAILTO <> "" Then
            '    For i = 0 To UBound(Split(MAILTO, ","))
            '        'msg.To.Add(New System.Net.Mail.MailAddress(MAILTO))
            '        msg.To.Add(New System.Net.Mail.MailAddress(Split(MAILTO, ",")(i)))
            '    Next
            'End If

            If NormalAccount <> "" Then
                msg.Bcc.Clear()

                For i = 0 To UBound(Split(NormalAccount, ","))
                    msg.Bcc.Add(New System.Net.Mail.MailAddress(Split(NormalAccount, ",")(i)))
                Next
            Else
                msg.To.Clear()
                msg.To.Add(New System.Net.Mail.MailAddress(MailAddress))

                msg.Bcc.Clear()

                For i = 0 To UBound(Split(SpecialAccount, ","))
                    msg.Bcc.Add(New System.Net.Mail.MailAddress(Split(SpecialAccount, ",")(i)))
                Next
            End If

            '            If NormalAccount <> "" Then

            msg.Subject = Subject
            'msg.SubjectEncoding = myEnc
            msg.IsBodyHtml = True
            msg.Body = getTextOnly(Body)
            msg.AlternateViews.Add(addAlternativemultipart(Body))
            'msg.BodyEncoding = System.Text.Encoding.GetEncoding("shift_jis")
            msg.BodyEncoding = myEnc


            'Dim sc As New System.Net.Mail.SmtpClient()
            ''SMTPサーバーなどを設定する
            'sc.Host = SMTPServer
            'sc.Port = SMTPPort
            'sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
            ''SSL認証を有効にする
            'sc.EnableSsl = True
            ''ユーザー名とパスワードを設定する
            'sc.Credentials = New System.Net.NetworkCredential(SMTPAccount, SMTPPassword)
            ''メッセージを送信する
            'sc.Send(msg)
            msc.Send(msg)

            'End If

            ''特別なドメイン(Docomo等のBCCのみ送信を許可していないドメイン)の場合、TOに自分自身を付加して送信する。
            'If SpecialAccount <> "" Then
            '    msg.To.Clear()
            '    msg.To.Add(New System.Net.Mail.MailAddress(MailAddress))

            '    msg.Bcc.Clear()

            '    For i = 0 To UBound(Split(SpecialAccount, ","))
            '        msg.Bcc.Add(New System.Net.Mail.MailAddress(Split(SpecialAccount, ",")(i)))
            '    Next

            '    msg.Subject = Subject
            '    'msg.SubjectEncoding = myEnc
            '    msg.IsBodyHtml = True

            '    msg.Body = getTextOnly(Body)
            '    msg.AlternateViews.Add(addAlternativemultipart(Body))
            '    msg.BodyEncoding = myEnc


            '    Dim sc As New System.Net.Mail.SmtpClient()
            '    'SMTPサーバーなどを設定する
            '    sc.Host = SMTPServer
            '    sc.Port = SMTPPort
            '    sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
            '    'SSL認証を有効にする
            '    sc.EnableSsl = True
            '    'ユーザー名とパスワードを設定する
            '    sc.Credentials = New System.Net.NetworkCredential(SMTPAccount, SMTPPassword)
            '    'メッセージを送信する
            '    sc.Send(msg)

            'End If

            '後始末
            msg.Dispose()
            '後始末（.NET Framework 4.0以降）

            Return True

        Catch ex As Exception
            Debug.Print("エラー：" + ex.Message)
            Return False
        End Try
    End Function

    Private Function addAlternativemultipart(ByVal body As String) As System.Net.Mail.AlternateView
        Dim retbody As String = ""

        'Encodingにnullを指定しているため、UTF-8/Base64でエンコードされる
        Dim htmlView As System.Net.Mail.AlternateView = _
            System.Net.Mail.AlternateView.CreateAlternateViewFromString( _
                body, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)

        htmlView.TransferEncoding = Mime.TransferEncoding.Base64

        Return htmlView

    End Function


    Private Function getTextOnly(ByVal editorcontent As String) As String
        Dim strtext As String = ""

        strtext = Regex.Replace(editorcontent, "<(.|\n)*?>", String.Empty)

        Return strtext
    End Function


    'メール送信フラグの更新
    Public Sub updateSend_Flg(ByVal mail_code As String)
        Dim strsql As String
        Dim cmd As New System.Data.SqlClient.SqlCommand

        strsql = ""
        strsql = My.Settings.UpdateFlgSql

        strsql = Replace(strsql, "@MAIL_CODE", mail_code)

        Try
            connectDb()

            cmd.Connection = cSqlConnection

            cmd.CommandText = strsql

            cmd.ExecuteNonQuery()

            cmd.Dispose()

            closeDB()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    'エラーログの書込み
    Public Sub writeErrorLog(ByVal send_group_code As String _
                            , ByVal mail_code As String _
                            , ByVal mail_address As String _
                            , ByVal user_name As String)
        Dim strSql As String
        Dim cmd As New System.Data.SqlClient.SqlCommand

        strSql = ""
        strSql = My.Settings.ErrorLogSql

        strSql = Replace(strSql, "@SEND_GROUP_CODE", send_group_code)
        strSql = Replace(strSql, "@MAIL_CODE", mail_code)
        strSql = Replace(strSql, "@MAIL_ADDRESS", mail_address)
        strSql = Replace(strSql, "@USER_NAME", user_name)

        Try
            connectDb()

            cmd.Connection = cSqlConnection

            cmd.CommandText = strSql

            cmd.ExecuteNonQuery()

            cmd.Dispose()

            closeDB()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    'DB接続
    Public Function connectDb() As Boolean
        Try
            ' 接続文字列を生成する
            Dim stConnectionString As String = String.Empty
            stConnectionString = My.Settings.ANASOFTMAILConnectionString

            ' SqlConnection の新しいインスタンスを生成する (接続文字列を指定)
            cSqlConnection = New System.Data.SqlClient.SqlConnection(stConnectionString)

            ' データベース接続を開く
            cSqlConnection.Open()

            Return True
        Catch ex As Exception
            MessageBox.Show("接続失敗")

            Return False
        End Try
    End Function

    'DB切断
    Public Function closeDB() As Boolean
        Try
            If Not cSqlConnection Is Nothing Then
                cSqlConnection.Close()
                cSqlConnection.Dispose()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'メールデータの存在チェック
    Public Function isMailData() As Boolean
        Try
            If getDataCount("SELECT * FROM T_MAIL WHERE SEND_FLG = '0' AND SEND_SCHEDULE_DATE < GETDATE() ") > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function



    'データ件数の取得
    Public Function getDataCount(ByVal sqlString As String) As Integer
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim icnt As Integer = 0
        Try
            If connectDb() Then
                cmd.Connection = cSqlConnection

                cmd.CommandText = sqlString

                icnt = cmd.ExecuteScalar

                cmd.Dispose()

                closeDB()
            End If

            Return icnt
        Catch ex As Exception
            Return icnt
        End Try
    End Function

    Public Function isMailMember(ByVal Send_Group_Code As String) As Boolean
        Dim dr As System.Data.SqlClient.SqlDataReader
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim strsend_group_code As String = ""
        Dim blnMember As Boolean = False
        Dim strSql As String = ""
        Try
            If connectDb() Then
                cmd.Connection = cSqlConnection

                dr = cmd.ExecuteReader("SELECT * FROM T_MAIL WHERE SEND_GROUP_CODE = '" & Send_Group_Code & "' AND SEND_FLG = '0' AND SEND_SCHEDULE_DATE < GETDATE() ")

                While dr.Read
                    strsend_group_code = dr("SEND_GROUP_CODE")
                    strSql = ""
                    strSql = strSql & "SELECT * FROM M_USER WHERE SEND_GROUP_CODE = '" & strsend_group_code & "' "
                    strSql = strSql & "AND LIMIT > CONVERT(DATE, GETDATE()) "

                    If getDataCount(strSql) Then
                        blnMember = True
                    End If
                End While

                dr.Close()
                cmd.Dispose()
                closeDB()
            End If

        Catch ex As Exception

        End Try
    End Function

    Public Sub sendMailSub()
        Dim dr1 As System.Data.SqlClient.SqlDataReader
        Dim dr2 As System.Data.SqlClient.SqlDataReader
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim mailbcc As String = ""
        Dim send_group_code As String = ""
        Dim strSql As String = ""
        Dim sendgroupcodelist() As String
        Dim mailSubjectList() As String
        Dim mailBodyList() As String
        Dim mailCodeList() As String
        Dim blnret As Boolean = False
        Dim blnret2 As Boolean = False
        Dim mailAddress As String = ""
        Dim userName As String = ""

        Try
            If connectDb() Then
                cmd.Connection = cSqlConnection
                cmd.CommandText = "SELECT * FROM T_MAIL WHERE SEND_FLG = '0' AND SEND_SCHEDULE_DATE < GETDATE() "

                dr1 = cmd.ExecuteReader()

                'メール件名・本文取得
                Dim i As Integer = -1
                While dr1.Read
                    i = i + 1
                    ReDim Preserve mailCodeList(i)
                    ReDim Preserve sendgroupcodelist(i)
                    ReDim Preserve mailSubjectList(i)
                    ReDim Preserve mailBodyList(i)

                    mailCodeList(i) = dr1("MAIL_CODE")
                    sendgroupcodelist(i) = dr1("SEND_GROUP_CODE")
                    mailSubjectList(i) = dr1("MAIL_SUBJECT")
                    mailBodyList(i) = dr1("MAIL_BODY")
                End While

                dr1.Close()

                If i > -1 Then
                    'メールサーバに接続する
                    blnret = mailServerConnect(My.Settings.MailAddress _
                                    , My.Settings.MailName _
                                    , My.Settings.MailPassword _
                                    , My.Settings.POPServer _
                                    , My.Settings.POPPort _
                                    , My.Settings.POPAccount _
                                    , My.Settings.POPPassword _
                                    , My.Settings.SMTPServer _
                                    , My.Settings.SMTPPort _
                                    , My.Settings.SMTPAccount _
                                    , My.Settings.SMTPPassword)

                    If Not blnret Then
                        writeErrorLog("", "", "メールサーバ", "接続失敗")

                        cmd.Dispose()
                        closeDB()

                        Exit Sub
                    End If

                    For i = 0 To UBound(sendgroupcodelist)
                        mailbcc = ""

                        strSql = ""
                        strSql = strSql & "SELECT U.* FROM M_USER U, M_SEND_GROUP S WHERE U.SEND_GROUP_CODE = " & sendgroupcodelist(i) & " "
                        strSql = strSql & "AND U.SEND_GROUP_CODE = S.SEND_GROUP_CODE "
                        strSql = strSql & "AND ((S.LIMIT_FLG = 0 AND U.LIMIT > CONVERT(DATE, GETDATE())) OR (S.LIMIT_FLG = 1)) "

                        cmd.CommandText = strSql

                        dr2 = cmd.ExecuteReader()

                        'メアド取得
                        While dr2.Read
                            mailAddress = convertMailAddress(dr2("MAIL_ADDRESS"))
                            userName = dr2("USER_NAME")
                            'If mailbcc <> "" Then
                            '    mailbcc = mailbcc & ", " & mailAddress
                            'Else
                            mailbcc = mailAddress
                            'End If

                            If mailAddress <> "" Then
                                blnret = mailsend(My.Settings.MailAddress _
                                                , My.Settings.MailName _
                                                , My.Settings.MailPassword _
                                                , My.Settings.POPServer _
                                                , My.Settings.POPPort _
                                                , My.Settings.POPAccount _
                                                , My.Settings.POPPassword _
                                                , My.Settings.SMTPServer _
                                                , My.Settings.SMTPPort _
                                                , My.Settings.SMTPAccount _
                                                , My.Settings.SMTPPassword _
                                                , "" _
                                                , "" _
                                                , mailAddress _
                                                , mailSubjectList(i) _
                                                , mailBodyList(i))

                                If blnret Then
                                    blnret2 = True
                                Else
                                    writeErrorLog(sendgroupcodelist(i), mailCodeList(i), mailAddress, userName)
                                End If

                            End If

                            Threading.Thread.Sleep(My.Settings.SleepTime)
                        End While
                        dr2.Close()

                        '1通でもメールが送れたら
                        If blnret2 Then
                            updateSend_Flg(mailCodeList(i))
                        End If
                        'メール送信
                        'If mailbcc <> "" Then
                        '    blnret = mailsend(My.Settings.MailName & "<" & My.Settings.MailAddress & ">" _
                        '                    , My.Settings.MailPassword _
                        '                    , My.Settings.POPServer _
                        '                    , My.Settings.POPPort _
                        '                    , My.Settings.POPAccount _
                        '                    , My.Settings.POPPassword _
                        '                    , My.Settings.SMTPServer _
                        '                    , My.Settings.SMTPPort _
                        '                    , My.Settings.SMTPAccount _
                        '                    , My.Settings.SMTPPassword _
                        '                    , "" _
                        '                    , "" _
                        '                    , mailbcc _
                        '                    , mailSubjectList(i) _
                        '                    , mailBodyList(i))

                        '    updateSend_Flg(mailCodeList(i))

                        'End If
                    Next

                End If

                cmd.Dispose()

                closeDB()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub

    Public Function convertMailAddress(ByVal mailAddress As String) As String
        Dim strmailAddress As String = ""
        Const errorString = ";:,*]/^~!""#%&()=<>? "
        Dim i As Integer
        strmailAddress = mailAddress

        ' 全角文字を半角文字に変換する
        strmailAddress = StrConv(strmailAddress, VbStrConv.Narrow)

        ' 不正な文字の除去
        For i = 1 To Len(errorString)
            strmailAddress = Replace(strmailAddress, Mid(errorString, i, 1), "")
        Next

        Return strmailAddress

    End Function
End Module
