﻿
Imports System.Reflection
Imports WinPaletter.XenonCore

Public Class Localizer
    Sub New()

    End Sub

#Region "Language Info"
    Property Name
    Property TrVer
    Property Lang
    Property LangCode
    Property AppVer
    Property RightToLeft As Boolean = False
#End Region

#Region "Deep-In-Code Strings"
    Property InvalidTheme As String = "Error: Invalid Theme File."
    Property ThemeNotExist As String = "Theme File doesn't exist."
    Property OK As String = "OK"
    Property Next_ As String = "Next"
    Property Yes As String = "Yes"
    Property No As String = "No"
    Property NewTag As String = "Create New Theme (Palette) File"
    Property OpenTag As String = "Open a Theme File"
    Property SaveTag As String = "Save Theme File"
    Property SaveAsTag As String = "Save Theme File as ..."
    Property EditInfoTag As String = "Edit Information of current Theme File"
    Property NewUpdate As String = "New Update Available"
    Property OpenForActions As String = "Open Updates form for actions."
    Property By As String = "By"
    Property X1 As String = "Start Menu, Taskbar and Action Center"
    Property X2 As String = "Action Center Hover and Links"
    Property X3 As String = "Lines, Toggles and Buttons"
    Property X4 As String = "Taskbar Active App Background"
    Property X5 As String = "Start Menu and Action Center Colors"
    Property X6 As String = "Taskbar Color"
    Property X7 As String = "Settings Icons, Text Selection, Focus Dots, Some Pressed Buttons"
    Property X8 As String = "Start Button Hover, Some Pressed Buttons"
    Property X9 As String = "Start Menu Accent Color (Maybe not effective)"
    Property X10 As String = "Taskbar Background (Maybe not effective)"
    Property X11 As String = "Start Icon Hover"
    Property X12 As String = "Settings Icons, Taskbar App Underline & Some Pressed Buttons"
    Property X13 As String = "Start Menu, Action Center, Taskbar Active App Background"
    Property X14 As String = "Links"
    Property X15 As String = "Taskbar App Underline"
    Property X16 As String = "Not Used"
    Property X17 As String = "To colorize active titlebar, please activate the toggle"
    Property X18 As String = "To colorize inactive titlebar, please activate the toggle"
    Property X19 As String = "To colorize taskbar, please activate the toggle"
    Property X20 As String = "To colorize start menu, action center and taskbar, please activate the toggle"
    Property X21 As String = "To colorize start menu and action center, please activate the toggle"
    Property X22 As String = "This will restart the explorer, don't worry this won't close other applications."
    Property X23 As String = "Windows Volume slider, UAC and Windows 10 LogonUI follow this color"
    Property NoDefResExplorer = "Restarting Explorer is diabled from settings. If the palette is not applied correctly, <br> restart explorer."
    Property CurrentMode As String = "Current Mode"
    Property SaveMsg As String = "Do you want to save Settings?"
    Property SettingsSaved As String = "Settings Saved"
    Property RemoveExtMsg As String = "Are you sure from removing files association (*.wpth, *.wpsf) from registry?"
    Property RemoveExtMsgNote As String = "Note: You can reassociate them by activating its checkbox and restarting the application."
    Property UninstallMsgLine1 As String = "Are you sure from Uninstalling the program?"
    Property UninstallMsgLine2 As String = "This will delete associated files extensions from registry."
    Property RestartRecommendation As String = "It's Recommended. Don't worry it won't close your work. If you are obsessed about this, save your work at first."
    Property EmptyName As String = "You can't leave Palette Name Empty. Please type a name to it."
    Property EmptyAuthorName As String = "You can't leave Author's Name Empty. Please type Author's name or your name."
    Property EmptyVer As String = "You can't leave Palette Version Empty. Please type a version to it in this style (x.x.x.x), replacing (x) by numbers"
    Property WrongVerFormat As String = "Wrong Version Fomrat. Please type the version to it in this style (x.x.x.x), replacing (x) by numbers."
    Property Extracting As String = "Extracting palette from image depends on your device's performance, maximum palette colors number, image quality and its resolution ..."
    Property Sorting As String = "Sorting Colors in Palette ..."
    Property ErrorPhrasingChangelog As String = "Error phrasing changelog"
    Property VersionNotReleased As String = "is not released yet, deleted or written in a wrong format."
    Property ReleasedOn As String = "Released on:"
    Property Version As String = "Version"
    Property Label5_Checking As String = "Checking ..."
    Property Error_Online As String = "Error reading changelog online"
    Property NoNetwork As String = "No Network is Available"
    Property CheckConnection As String = "Check your connection and try again"
    Property XenonButton1_UpdateAvailable As String = "Do Action"
    Property XenonAlertBox2_UpdateAvailable As String = "Update Available"
    Property XenonButton1_NoUpdateAvailable As String = "Check for updates"
    Property XenonAlertBox2_NoUpdateAvailable As String = "No Available Updates"
    Property XenonButton1_Error As String = "Check for updates"
    Property XenonAlertBox2_Error As String = "Network Error"
    Property XenonButton1_ServerError As String = "Check for updates"
    Property XenonAlertBox2_ServerError As String = "Error: Network issues or Github repository is private or deleted. Visit Github page for details."
    Property Msgbox_Downloaded As String = "Downloaded Successfully"
    Property MBSizeUnit As String = "MB"
    Property Stable As String = "Stable"
    Property Beta As String = "Beta"
    Property Channel As String = "Channel"
    Property LngExported As String = "Language Exported Successfully"
    Property MenuNativeWin As String = "From Init (Native Windows)"
    Property MenuInit As String = "From Init (Empty Colors)"
    Property MenuAppliedReg As String = "From Current Applied Palette"
    Property ScalingTip As String = "Scaling option is only a preview, the cursor will be saved with different sizes and the situable size will be loaded according to your DPI settings."
    Property Win32UISavingThemeError As String = "Error saving file: "
    Property CMD_Enable As String = "You should enable terminal editing from the toggle above."
    Property ExtTer_NotFound As String = "Terminal not found. Select a valid one from the list."
    Property ExtTer_Set As String = "Terminal Preferences are set successfully!"
    Property ExtTer_NewSuccess As String = "This key is entered into registry successfully."
    Property ExtTer_NewError As String = "Couldn't write this entry to registry. Please check if this key already exists or check permissions."
    Property ErrorDetails As String = "Error Details: "
    Property Terminal_alreadyset As String = "You can't set this name as it is already set to another profile."
    Property TerminalStable_notFound As String = "Windows Terminal Stable isn't installed or ""settings.json"" isn't accessible."
    Property TerminalPreview_notFound As String = "Windows Terminal Preview isn't installed or ""settings.json"" isn't accessible."
    Property PowerShellx86_notFound As String = "Microsoft PowerShell x86 is not installed."
    Property PowerShellx64_notFound As String = "Microsoft PowerShell x64 is not installed."
    Property Terminal_supposed As String = "It is supposed to be located in: "
    Property Terminal_Bypass As String = "However, you can bypass this restriction in Settings > Terminals (In case you want to design a theme for all Versions of Windows and save it as a file for sharing, not applying it)."
    Property Terminal_CantRun As String = "You can't run Windows Terminal in current OS. It is available only in Windows 10 and 11."
    Property Terminal_ErrorFile As String = "Error occurred while reading settings file: "
    Property Terminal_ProfileNotCloneable As String = "Default Profile isn't cloneable, select a different profile."
    Property Terminal_ThemeNotCloneable As String = "Default themes (Dark\Light\System) are not cloneable, select a different theme or create a new theme if you want to clone."
    Property Terminal_Clone As String = "Clone"
    Property Terminal_SettingsNotExist As String = "Settings doesn't exist: "
#End Region

    Public Sub ExportNativeLang(File As String)
        Dim lx As New List(Of String)
        lx.Clear()

        lx.Add("!Name = Abdelrhman-AK")
        lx.Add("!TrVer = 1.0")
        lx.Add("!Lang = English")
        lx.Add("!LangCode = EN-US")
        lx.Add("!AppVer = " & My.Application.Info.Version.ToString)
        lx.Add("!RightToLeft = False")

        Dim type1 As Type = [GetType]() : Dim properties1 As PropertyInfo() = type1.GetProperties()

        For Each [property] As PropertyInfo In properties1
            If Not String.IsNullOrWhiteSpace([property].GetValue(Me)) Then lx.Add(String.Format("@{0} = {1}", [property].Name, [property].GetValue(Me)))
        Next

        Dim LS As New List(Of String)
        LS.Clear()

        For Each f In Assembly.GetExecutingAssembly().GetTypes().Where(Function(t) GetType(Form).IsAssignableFrom(t))
            Using ins = DirectCast(Activator.CreateInstance(f), Form)
                LS.Add(ins.Name & ".Text = " & ins.Text)
                For Each ctrl In GetAllControls(ins)
                    If Not String.IsNullOrWhiteSpace(ctrl.Text) And Not IsNumeric(ctrl.Text) And Not ctrl.Text.Count = 1 And Not ctrl.Text = ctrl.Name Then
                        LS.Add(ins.Name & "." & ctrl.Name & ".Text = " & ctrl.Text.Replace(vbCrLf, "<br>"))
                    End If

                    If Not String.IsNullOrWhiteSpace(ctrl.Tag) Then
                        LS.Add(ins.Name & "." & ctrl.Name & ".Tag = " & ctrl.Tag.Replace(vbCrLf, "<br>"))
                    End If
                Next
            End Using
        Next



        IO.File.WriteAllText(File, CStr_FromList(lx) & vbCrLf & CStr_FromList(LS))
    End Sub

    Public Sub LoadLanguageFromFile(File As String, Optional [_Form] As Form = Nothing)
        If IO.File.Exists(File) Then
            Dim Dic As New List(Of ControlsBase)
            Dic.Clear()

            For Each X As String In IO.File.ReadAllLines(File)
                If X.StartsWith("!") Then
                    If X.StartsWith("!Name = ") Then Name = X.Remove(0, "!Name = ".Count)
                    If X.StartsWith("!TrVer = ") Then TrVer = X.Remove(0, "!TrVer = ".Count)
                    If X.StartsWith("!Lang = ") Then Lang = X.Remove(0, "!Lang = ".Count)
                    If X.StartsWith("!LangCode = ") Then LangCode = X.Remove(0, "!LangCode = ".Count)
                    If X.StartsWith("!AppVer = ") Then AppVer = X.Remove(0, "!AppVer = ".Count)
                    If X.StartsWith("!RightToLeft = ") Then RightToLeft = X.Remove(0, "!RightToLeft = ".Count)

                ElseIf X.StartsWith("@") Then
                    Dim x0, x1 As String
                    x0 = X.Split("=")(0).Trim
                    x1 = X.Split("=")(1).Trim
                    x1 = x1

                    Dim type1 As Type = [GetType]() : Dim properties1 As PropertyInfo() = type1.GetProperties()

                    For Each [property] As PropertyInfo In properties1
                        If [property].Name.ToLower = x0.Remove(0, 1).ToLower Then
                            [property].SetValue(Me, Convert.ChangeType(x1.Replace("<br>", vbCrLf), [property].PropertyType), Nothing)
                        End If
                    Next

                Else
                    Dim FormName, ControlName, Prop, Value As String


                    Select Case X.Split("=")(0).Trim.Split(".").Count
                        Case 3
                            FormName = X.Split("=")(0).Trim.Split(".")(0)
                            ControlName = X.Split("=")(0).Trim.Split(".")(1)
                            Prop = X.Split("=")(0).Trim.Split(".")(2)
                        Case 2
                            FormName = X.Split("=")(0).Trim.Split(".")(0)
                            ControlName = Nothing
                            Prop = X.Split("=")(0).Trim.Split(".")(1)
                    End Select

                    Value = X.Split("=")(1).Trim

                    Dic.Add(New ControlsBase(FormName, ControlName, Prop, Value))
                End If
            Next

            If [_Form] Is Nothing Then
                For x As Integer = 0 To My.Application.allForms.Count - 1
                    Populate(Dic, My.Application.GetFormFromName(My.Application.allForms(x)))
                Next
            Else
                Populate(Dic, [_Form])
            End If

            My.Application.AdjustFonts()

        End If
    End Sub

    Sub LoadInternal()
        MainFrm.ToolStripMenuItem2.Text = MenuInit
        MainFrm.FromCurrentPaletteToolStripMenuItem.Text = MenuAppliedReg

        My.Application.AdjustFonts()
    End Sub

    Sub Populate(ByVal Dic As List(Of ControlsBase), [Form] As Form)
        [Form].SuspendLayout()

        For Each dicX As ControlsBase In Dic

            If [Form].Name = dicX.Form Then
                If dicX.Control = Nothing Then
                    '# Form
                    If dicX.Prop.ToLower = "text" Then [Form].Text = dicX.Value
                    If dicX.Prop.ToLower = "tag" Then [Form].Tag = dicX.Value
                    [Form].RightToLeft = If(RightToLeft, 1, 0)
                    [Form].RightToLeftLayout = RightToLeft
                    RTL([Form])
                    [Form].Refresh()

                Else
                    '# Control
                    For Each ctrl As Control In [Form].Controls.Find(dicX.Control, True)
                        ctrl.SuspendLayout()
                        If dicX.Prop.ToLower = "text" Then ctrl.Text = dicX.Value.ToString.Replace("<br>", vbCrLf)
                        If dicX.Prop.ToLower = "tag" Then ctrl.Tag = dicX.Value.ToString.Replace("<br>", vbCrLf)
                        ctrl.RightToLeft = If(RightToLeft, 1, 0)
                        ctrl.Refresh()
                        [Form].Refresh()
                        ctrl.ResumeLayout()
                    Next

                End If
            End If

        Next

        MainFrm.ToolStripMenuItem2.Text = MenuInit
        MainFrm.FromCurrentPaletteToolStripMenuItem.Text = MenuAppliedReg

        [Form].ResumeLayout()
    End Sub
    Sub RTL(Parent As Control)
        If RightToLeft Then

            For Each XeTP As XenonTabControl In Parent.Controls.OfType(Of XenonTabControl)
                XeTP.RightToLeft = If(RightToLeft, 1, 0)
                XeTP.RightToLeftLayout = RightToLeft

                For i = 0 To XeTP.TabPages.Count - 1
                    XeTP.TabPages.Item(i).RightToLeft = If(RightToLeft, 1, 0)
                    If XeTP.TabPages.Item(i).HasChildren Then RTL(XeTP.TabPages.Item(i))

                    For Each Cx As Control In XeTP.TabPages.Item(i).Controls
                        Cx.Left = XeTP.TabPages.Item(i).Width - Cx.Left - Cx.Width
                        If Cx.HasChildren Then RTL(Cx)
                    Next
                Next
            Next

            For Each XeTP As Control In Parent.Controls
                If TypeOf XeTP Is XenonGroupBox Or TypeOf XeTP Is Panel Then
                    XeTP.RightToLeft = If(RightToLeft, 1, 0)
                    For Each Cx As Control In XeTP.Controls
                        Cx.Left = XeTP.Width - Cx.Left - Cx.Width
                        If Cx.HasChildren Then RTL(Cx)
                    Next
                End If
            Next

        End If
    End Sub

    Private Function GetAllControls(parent As Control) As IEnumerable(Of Control)
        Dim cs = parent.Controls.OfType(Of Control)
        Return cs.SelectMany(Function(c) GetAllControls(c)).Concat(cs)
    End Function

End Class

Public Class ControlsBase
    Public Sub New(Form As String, Control As String, Prop As String, Value As Object)
        Me.Form = Form
        Me.Control = Control
        Me.Prop = Prop
        Me.Value = Value
    End Sub
    Public Property Form As String
    Public Property Control As String
    Public Property Prop As String
    Public Property Value As Object

End Class
