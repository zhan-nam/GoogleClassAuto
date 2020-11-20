Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports System.IO
Public Class Form1

    Private Sub Enable_All_State(bool As Boolean)
        timeBox.Enabled = bool
        urlBox.Enabled = bool
        ClearAllToolStripMenuItem.Enabled = bool
        ClearEmailPasswrodToolStripMenuItem.Enabled = bool
        AddEmailPasswordToolStripMenuItem.Enabled = bool
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ButtonClick_Set_Cancel()
    End Sub

    Private Function availableEmail_Password_Link() As Boolean
        If My.Computer.FileSystem.ReadAllText("tarc_email.txt") = "" Then
            MessageBox.Show("There is no email" + vbNewLine + "**right click the interface to insert email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf My.Computer.FileSystem.ReadAllText("tarc_password.txt") = "" Then
            MessageBox.Show("There is no password" + vbNewLine + "**right click the interface to insert password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf urlBox.Text = "" Then
            MessageBox.Show("Please make sure the url is provided ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ButtonClick_Set_Cancel()
        If Guna2Button1.Text = "set" Then
            Dim msg As DialogResult = MessageBox.Show("link will open at the time of " + vbNewLine + timeBox.Value.ToString + vbNewLine + "Are You Sure??", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If msg = DialogResult.Yes Then
                If availableEmail_Password_Link() Then
                    Timer1.Start()
                    Guna2Button1.Text = "cancel"
                    Guna2Button1.FillColor = ColorTranslator.FromHtml("#e63c58")

                    statusbox.ForeColor = Color.Green
                    statusbox.Text = "Trigger time : " + timeBox.Value + vbNewLine + "counting down..."
                    Enable_All_State(False)
                End If
            End If
        Else
            Dim msg As DialogResult = MessageBox.Show("Time timer will be cancel" + vbNewLine + "Are You Sure??", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If msg = DialogResult.Yes Then
                Timer1.Stop()
                Guna2Button1.Text = "set"
                Guna2Button1.FillColor = ColorTranslator.FromHtml("#427ef5")
                statusbox.Text = ""
                Enable_All_State(True)
            End If
        End If
    End Sub

    Private driver As IWebDriver
    Private element As IWebElement

    ' URL redirect location
    Private Sub direct_to(url As String)
        driver.Navigate().GoToUrl(url)
    End Sub

    'click item base on full xpath
    Private Sub click_via_xpath(xpath As String)
        element = driver.FindElement(By.XPath(xpath))
        element.Click()
    End Sub

    'insert string via full xpath
    Private Sub sendkey_via_xpath(xpath As String, val As String)
        element = driver.FindElement(By.XPath(xpath))
        element.SendKeys(val)
    End Sub

    'count down seconds
    Private Sub sleepfor(sec As Integer)
        System.Threading.Thread.Sleep(sec * 1000)
    End Sub

    Private error_tracking As String
    Private Sub open_browser()

        error_tracking = ""

        Guna2Button1.Enabled = False
        statusbox.ForeColor = Color.Orange
        statusbox.Text = "Processing, please wait..."
        Try
            Dim service As ChromeDriverService = ChromeDriverService.CreateDefaultService("Browser")
            service.HideCommandPromptWindow = True


            Dim options As ChromeOptions = New ChromeOptions()
            options.AddArgument("--use-fake-ui-for-media-stream")
            'options.AddLocalStatePreference("permissions.default.camera", 1)
            'options.AddUserProfilePreference("permissions.default.microphone", 1)
            options.AddArgument("start-maximized")


            driver = New ChromeDriver(service, options)
            direct_to("https://accounts.google.com/signin/v2/identifier?hl=EN&flowName=GlifWebSignIn&flowEntry=ServiceLogin")
            'driver.Manage().Window.Maximize()

            error_tracking += "login ⇒ "
            'enter email
            sendkey_via_xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input", My.Computer.FileSystem.ReadAllText("tarc_email.txt"))
            'click
            'click_via_xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button/div[2]")

            sleepfor(6)
            'enter password
            sendkey_via_xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input", My.Computer.FileSystem.ReadAllText("tarc_password.txt"))
            'click
            'click_via_xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button/div[2]")
            error_tracking += "succeed" + vbNewLine

            sleepfor(6)
            error_tracking += "open link ⇒ "
            'google classroom link
            direct_to(urlBox.Text)
            error_tracking += "succeed" + vbNewLine

            sleepfor(7)
            error_tracking += "close mic ⇒ "
            'close mic and cam
            click_via_xpath("/html/body/div[1]/c-wiz/div/div/div[8]/div[3]/div/div/div[2]/div/div[1]/div[1]/div[1]/div/div[4]/div[1]/div/div/div")
            error_tracking += "succeed" + vbNewLine

            error_tracking += "close cam ⇒ "
            click_via_xpath("/html/body/div[1]/c-wiz/div/div/div[8]/div[3]/div/div/div[2]/div/div[1]/div[1]/div[1]/div/div[4]/div[2]/div/div")
            error_tracking += "succeed" + vbNewLine

            sleepfor(1)
            'join
            error_tracking += "join class ⇒ "
            click_via_xpath("/html/body/div[1]/c-wiz/div/div/div[8]/div[3]/div/div/div[2]/div/div[1]/div[2]/div/div[2]/div/div[1]/div[1]/span")
            error_tracking += "succeed" + vbNewLine

            statusbox.ForeColor = Color.Green
            statusbox.Text = "join class at :" + DateTime.Now

        Catch ex As Exception
            driver.Close()
            statusbox.ForeColor = Color.Red
            statusbox.Text = error_tracking + "fail"
        End Try

        Guna2Button1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (DateTime.Now >= timeBox.Value) Then
            Timer1.Stop()
            Guna2Button1.Text = "set"
            Guna2Button1.FillColor = ColorTranslator.FromHtml("#427ef5")

            open_browser()
            Enable_All_State(True)
        End If

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'driver.Close()
    End Sub


    Private Sub ClearEmailPasswrodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearEmailPasswrodToolStripMenuItem.Click
        Dim msg As DialogResult = MessageBox.Show("press yes to continue", "DELETE Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If msg = DialogResult.Yes Then
            Dim St As StreamWriter = New StreamWriter("tarc_email.txt")
            St.Close()
            St = New StreamWriter("tarc_password.txt")
            St.Close()

            statusbox.ForeColor = Color.Green
            statusbox.Text = "email and password cleared"
        End If
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        statusbox.Text = ""
        urlBox.Text = ""
    End Sub

    Private Sub AddEmailPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmailPasswordToolStripMenuItem.Click
        EmailPassword.ShowDialog()
    End Sub
End Class
