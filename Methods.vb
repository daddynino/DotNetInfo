Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Partial Public Class DotNet

    ''' <summary>
    ''' Initializes a new instance of the class and populates version details.
    ''' </summary>

    Public Sub New()

        LoadRuntimeListFromCmdLine()
        ' Framework
        GetDotNetFramework1To4Version()
        GetDotNetFramework45PlusVersion()
        ' Core & Runtime
        GetDotNetCoreAndRuntimeVersions()
        ' DesktopRuntime
        GetDesktopRuntimeVersions()
        ' ASPNet
        GetDotNETASPVersions()
        ' ASPNetCore
        GetASPCoreVersions()

    End Sub

    Private Shared Function GetFirstNonZeroVersion(inlineProperties As List(Of Version)) As Version
        ' Loop through each version in the inline list
        For Each version In inlineProperties
            ' Check if the version is non-zero (at least one part is non-zero)
            If version IsNot Nothing AndAlso (version.Major <> 0 Or version.Minor <> 0 Or version.Build <> 0 Or version.Revision <> 0) Then
                ' Return the non-zero version number
                Return version
            End If
        Next

        ' Return Nothing if no non-zero version was found
        Return Nothing
    End Function

    ''' <summary>
    ''' Retrieves the installed ASP.NET Core runtime versions from the `CmdLineOutput`. Populates
    ''' the runtime version lists based on the parsed version strings.
    ''' </summary>
    ''' <remarks>
    ''' This method uses regular expressions to extract the runtime versions from the command-line
    ''' output. It then categorizes and adds the versions to specific lists based on their major
    ''' version numbers.
    ''' </remarks>
    Private Sub GetASPCoreVersions()
        Try
            'sanity check
            If CmdLineError Or Not CmdLineChecked Then
                Exit Sub
            End If

            ' Define a regular expression to capture the runtime versions from the output.
            Dim regex As New Regex("Microsoft\.ASPNetCore\.App ([\d.]+)")
            Dim matches As MatchCollection = regex.Matches(CmdLineOutput)

            ' Iterate through the matches and add each version to the appropriate list.
            For Each match As Match In matches
                Dim versionString As String = match.Groups(1).Value

                ' Create a Version object from the matched string.
                Dim parsedVersion As New Version(versionString)

                ' Use the major version to determine which list to update.
                Select Case parsedVersion.Major
                    Case 1
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core1Versions Is Nothing Then Core1Versions = New List(Of Version)()
                                If Not Core1Versions.Contains(parsedVersion) Then
                                    Core1Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core11Versions Is Nothing Then Core11Versions = New List(Of Version)()
                                If Not Core11Versions.Contains(parsedVersion) Then
                                    Core11Versions.Add(parsedVersion)
                                End If
                        End Select
                    Case 2
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core2Versions Is Nothing Then Core2Versions = New List(Of Version)
                                If Not Core2Versions.Contains(parsedVersion) Then
                                    Core2Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core21Versions Is Nothing Then Core21Versions = New List(Of Version)
                                If Not Core21Versions.Contains(parsedVersion) Then
                                    Core21Versions.Add(parsedVersion)
                                End If
                            Case 2
                                If Core22Versions Is Nothing Then Core22Versions = New List(Of Version)
                                If Not Core22Versions.Contains(parsedVersion) Then
                                    Core22Versions.Add(parsedVersion)
                                End If
                        End Select
                    Case 3
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core3Versions Is Nothing Then Core3Versions = New List(Of Version)()
                                If Not Core3Versions.Contains(parsedVersion) Then
                                    Core3Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core31Versions Is Nothing Then Core31Versions = New List(Of Version)()
                                If Not Core31Versions.Contains(parsedVersion) Then
                                    Core31Versions.Add(parsedVersion)
                                End If
                        End Select

                    Case 5
                        If Core5Versions Is Nothing Then Core5Versions = New List(Of Version)()
                        If Not Core5Versions.Contains(parsedVersion) Then
                            Core5Versions.Add(parsedVersion)
                        End If
                    Case 6
                        If Core6Versions Is Nothing Then Core6Versions = New List(Of Version)()
                        If Not Core6Versions.Contains(parsedVersion) Then
                            Core6Versions.Add(parsedVersion)
                        End If
                    Case 7
                        If Core7Versions Is Nothing Then Core7Versions = New List(Of Version)()
                        If Not Core7Versions.Contains(parsedVersion) Then
                            Core7Versions.Add(parsedVersion)
                        End If
                    Case 8
                        If Core8Versions Is Nothing Then Core8Versions = New List(Of Version)()
                        If Not Core8Versions.Contains(parsedVersion) Then
                            Core8Versions.Add(parsedVersion)
                        End If
                    Case 9
                        If Core9Versions Is Nothing Then Core9Versions = New List(Of Version)()
                        If Not Core9Versions.Contains(parsedVersion) Then
                            Core9Versions.Add(parsedVersion)
                        End If
                End Select

            Next
        Catch ex As Exception
            ' Log or handle the exception as necessary. Currently, it silently catches errors. You
            ' can add logging here if needed.
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the installed .NET desktop runtime versions from the `CmdLineOutput`. Populates
    ''' the runtime version lists based on the parsed version strings.
    ''' </summary>
    ''' <remarks>
    ''' This method uses regular expressions to extract the runtime versions from the command-line
    ''' output. It then categorizes and adds the versions to specific lists based on their major
    ''' version numbers.
    ''' </remarks>
    Private Sub GetDesktopRuntimeVersions()
        Try
            'sanity check
            If CmdLineError Or Not CmdLineChecked Then
                Exit Sub
            End If

            ' Define a regular expression to capture the runtime versions from the output.
            Dim regex As New Regex("Microsoft\.WindowsDesktop\.App ([\d.]+)")
            Dim matches As MatchCollection = regex.Matches(CmdLineOutput)

            ' Iterate through the matches and add each version to the appropriate list.
            For Each match As Match In matches
                Dim versionString As String = match.Groups(1).Value

                ' Create a Version object from the matched string.
                Dim parsedVersion As New Version(versionString)

                ' Use the major version to determine which list to update.
                Select Case parsedVersion.Major
                    Case 5
                        If DesktopRuntime5Versions Is Nothing Then DesktopRuntime5Versions = New List(Of Version)()
                        If Not DesktopRuntime5Versions.Contains(parsedVersion) Then
                            If Not DesktopRuntime5Versions.Contains(parsedVersion) Then
                                DesktopRuntime5Versions.Add(parsedVersion)
                            End If
                        End If
                    Case 6
                        If DesktopRuntime6Versions Is Nothing Then DesktopRuntime6Versions = New List(Of Version)()
                        If Not DesktopRuntime6Versions.Contains(parsedVersion) Then
                            If Not DesktopRuntime6Versions.Contains(parsedVersion) Then
                                DesktopRuntime6Versions.Add(parsedVersion)
                            End If
                        End If
                    Case 7
                        If DesktopRuntime7Versions Is Nothing Then DesktopRuntime7Versions = New List(Of Version)()
                        If Not DesktopRuntime7Versions.Contains(parsedVersion) Then
                            If Not DesktopRuntime7Versions.Contains(parsedVersion) Then
                                DesktopRuntime7Versions.Add(parsedVersion)
                            End If
                        End If
                    Case 8
                        If DesktopRuntime8Versions Is Nothing Then DesktopRuntime8Versions = New List(Of Version)()
                        If Not DesktopRuntime8Versions.Contains(parsedVersion) Then
                            If Not DesktopRuntime8Versions.Contains(parsedVersion) Then
                                DesktopRuntime8Versions.Add(parsedVersion)
                            End If
                        End If
                    Case 9
                        If DesktopRuntime9Versions Is Nothing Then DesktopRuntime9Versions = New List(Of Version)()
                        If Not DesktopRuntime9Versions.Contains(parsedVersion) Then
                            If Not DesktopRuntime9Versions.Contains(parsedVersion) Then
                                DesktopRuntime9Versions.Add(parsedVersion)
                            End If
                        End If
                End Select
            Next
        Catch ex As Exception
            ' Log or handle the exception as necessary. Currently, it silently catches errors. You
            ' can add logging here if needed.
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the installed ASP.NET runtime versions from the `CmdLineOutput`. Populates the
    ''' runtime version lists based on the parsed version strings.
    ''' </summary>
    ''' <remarks>
    ''' This method uses regular expressions to extract the runtime versions from the command-line
    ''' output. It then categorizes and adds the versions to specific lists based on their major
    ''' version numbers.
    ''' </remarks>
    Private Sub GetDotNETASPVersions()
        Try
            'sanity check
            If CmdLineError Or Not CmdLineChecked Then
                Exit Sub
            End If

            ' Define a regular expression to capture the runtime versions from the output.
            Dim regex As New Regex("Microsoft\.ASPNet\.App ([\d.]+)")
            Dim matches As MatchCollection = regex.Matches(CmdLineOutput)

            ' Iterate through the matches and add each version to the appropriate list.
            For Each match As Match In matches
                Dim versionString As String = match.Groups(1).Value

                ' Create a Version object from the matched string.
                Dim parsedVersion As New Version(versionString)

                ' Use the major version to determine which list to update.
                Select Case parsedVersion.Major
                    Case 1
                        Select Case parsedVersion.Minor
                            Case 0
                                If ASP1Versions Is Nothing Then ASP1Versions = New List(Of Version)()
                                If Not ASP1Versions.Contains(parsedVersion) Then
                                    ASP1Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If ASP11Versions Is Nothing Then ASP11Versions = New List(Of Version)()
                                If Not ASP11Versions.Contains(parsedVersion) Then
                                    ASP11Versions.Add(parsedVersion)
                                End If
                        End Select
                    Case 2

                        If ASP2Versions Is Nothing Then ASP2Versions = New List(Of Version)
                        If Not ASP2Versions.Contains(parsedVersion) Then
                            ASP2Versions.Add(parsedVersion)
                        End If

                    Case 3

                        If ASP35Versions Is Nothing Then ASP35Versions = New List(Of Version)()
                        If Not ASP35Versions.Contains(parsedVersion) Then
                            ASP35Versions.Add(parsedVersion)
                        End If
                    Case 4
                        Select Case parsedVersion.Minor
                            Case 0
                                If ASP4Versions Is Nothing Then ASP4Versions = New List(Of Version)()
                                If Not ASP4Versions.Contains(parsedVersion) Then
                                    ASP4Versions.Add(parsedVersion)
                                End If
                            Case 5
                                If ASP45Versions Is Nothing Then ASP45Versions = New List(Of Version)()
                                If Not ASP45Versions.Contains(parsedVersion) Then
                                    ASP45Versions.Add(parsedVersion)
                                End If
                        End Select
                End Select

            Next
        Catch ex As Exception
            ' Log or handle the exception as necessary. Currently, it silently catches errors. You
            ' can add logging here if needed.
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the installed .NET Core runtime versions from the `CmdLineOutput`. Populates the
    ''' runtime version lists based on the parsed version strings.
    ''' </summary>
    ''' <remarks>
    ''' This method uses regular expressions to extract the runtime versions from the command-line
    ''' output. It then categorizes and adds the versions to specific lists based on their major
    ''' version numbers.
    ''' </remarks>
    Private Sub GetDotNetCoreAndRuntimeVersions()
        Try
            'sanity check
            If CmdLineError Or Not CmdLineChecked Then
                Exit Sub
            End If

            ' Define a regular expression to capture the runtime versions from the output.
            Dim regex As New Regex("Microsoft\.NETCore\.App ([\d.]+)")
            Dim matches As MatchCollection = regex.Matches(CmdLineOutput)

            ' Iterate through the matches and add each version to the appropriate list.
            For Each match As Match In matches
                Dim versionString As String = match.Groups(1).Value

                ' Create a Version object from the matched string.
                Dim parsedVersion As New Version(versionString)

                ' Use the major version to determine which list to update.
                Select Case parsedVersion.Major
                    Case 1
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core1Versions Is Nothing Then Core1Versions = New List(Of Version)()
                                If Not Core1Versions.Contains(parsedVersion) Then
                                    Core1Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core11Versions Is Nothing Then Core11Versions = New List(Of Version)()
                                If Not Core11Versions.Contains(parsedVersion) Then
                                    Core11Versions.Add(parsedVersion)
                                End If
                        End Select
                    Case 2
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core2Versions Is Nothing Then Core2Versions = New List(Of Version)
                                If Not Core2Versions.Contains(parsedVersion) Then
                                    Core2Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core21Versions Is Nothing Then Core21Versions = New List(Of Version)
                                If Not Core21Versions.Contains(parsedVersion) Then
                                    Core21Versions.Add(parsedVersion)
                                End If
                            Case 2
                                If Core22Versions Is Nothing Then Core22Versions = New List(Of Version)
                                If Not Core22Versions.Contains(parsedVersion) Then
                                    Core22Versions.Add(parsedVersion)
                                End If
                        End Select
                    Case 3
                        Select Case parsedVersion.Minor
                            Case 0
                                If Core3Versions Is Nothing Then Core3Versions = New List(Of Version)()
                                If Not Core3Versions.Contains(parsedVersion) Then
                                    Core3Versions.Add(parsedVersion)
                                End If
                            Case 1
                                If Core31Versions Is Nothing Then Core31Versions = New List(Of Version)()
                                If Not Core31Versions.Contains(parsedVersion) Then
                                    Core31Versions.Add(parsedVersion)
                                End If
                        End Select

                    Case 5
                        If Runtime5Versions Is Nothing Then Runtime5Versions = New List(Of Version)()
                        If Not Runtime5Versions.Contains(parsedVersion) Then
                            Runtime5Versions.Add(parsedVersion)
                        End If
                    Case 6
                        If Runtime6Versions Is Nothing Then Runtime6Versions = New List(Of Version)()
                        If Not Runtime6Versions.Contains(parsedVersion) Then
                            Runtime6Versions.Add(parsedVersion)
                        End If
                    Case 7
                        If Runtime7Versions Is Nothing Then Runtime7Versions = New List(Of Version)()
                        If Not Runtime7Versions.Contains(parsedVersion) Then
                            Runtime7Versions.Add(parsedVersion)
                        End If
                    Case 8
                        If Runtime8Versions Is Nothing Then Runtime8Versions = New List(Of Version)()
                        If Not Runtime8Versions.Contains(parsedVersion) Then
                            Runtime8Versions.Add(parsedVersion)
                        End If
                    Case 9
                        If Runtime9Versions Is Nothing Then Runtime9Versions = New List(Of Version)()
                        If Not Runtime9Versions.Contains(parsedVersion) Then
                            Runtime9Versions.Add(parsedVersion)
                        End If
                End Select
            Next
        Catch ex As Exception
            ' Log or handle the exception as necessary. Currently, it silently catches errors. You
            ' can add logging here if needed.
        End Try
    End Sub

    ''' <summary>
    ''' Populates dotnet framework 1 to 4 version numbers
    ''' </summary>
    Private Sub GetDotNetFramework1To4Version()
        Dim framework1Key As String = "Microsoft\.NET Framework Setup\NDP\v1.0.3705"
        Dim framework11Key As String = "Microsoft\NET Framework Setup\NDP\v1.1.4322"
        Dim framework2Key As String = "Microsoft\NET Framework Setup\NDP\v2.0.50727"
        Dim framework3Key As String = "Microsoft\NET Framework Setup\NDP\v3.0\Setup"
        Dim framework35Key As String = "Microsoft\NET Framework Setup\NDP\v3.5"
        Dim framework4ClientKey As String = "Microsoft\NET Framework Setup\NDP\v4.0\Client"

        Dim RegWord1 As String = "Install"
        Dim RegWord11 As String = "Install"
        Dim RegWord2 As String = "Install"
        Dim RegWord3 As String = "InstallSuccess"
        Dim RegWord35 As String = "Install"
        Dim RegWord4Client As String = "Install"

        Framework1Version = CheckFramework(framework1Key, RegWord1)
        Framework11Version = CheckFramework(framework11Key, RegWord11)
        Framework2Version = CheckFramework(framework2Key, RegWord2)
        Framework3Version = CheckFramework(framework3Key, RegWord3)
        Framework35Version = CheckFramework(framework35Key, RegWord35)
        Framework4Version = CheckFramework(framework4ClientKey, RegWord4Client)
    End Sub

    ''' <summary>
    ''' Populates dotnet framework 4.5 and up version number
    ''' </summary>
    Private Sub GetDotNetFramework45PlusVersion()
        Dim version As New Version ' = ""
        Try
            Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full")
                If key IsNot Nothing Then
                    Dim releaseKey As Integer = CInt(key.GetValue("Release"))
                    If releaseKey >= 533325 Then
                        version = New Version("4.8.1")
                    ElseIf releaseKey >= 528040 Then
                        version = New Version("4.8")
                    ElseIf releaseKey >= 461808 Then
                        version = New Version("4.7.2")
                    ElseIf releaseKey >= 461308 Then
                        version = New Version("4.7.1")
                    ElseIf releaseKey >= 460798 Then
                        version = New Version("4.7")
                    ElseIf releaseKey >= 394802 Then
                        version = New Version("4.6.2")
                    ElseIf releaseKey >= 394254 Then
                        version = New Version("4.6.1")
                    ElseIf releaseKey >= 393295 Then
                        version = New Version("4.6")
                    ElseIf releaseKey >= 379893 Then
                        version = New Version("4.5.2")
                    ElseIf releaseKey >= 378675 Then
                        version = New Version("4.5.1")
                    ElseIf releaseKey >= 378389 Then
                        version = New Version("4.5")
                    End If
                End If

                If version Is Nothing Then
                    Framework45PlusVersion = New Version(0, 0, 0, 0)
                Else
                    Framework45PlusVersion = version
                End If
            End Using
        Catch ex As Exception
            Framework45PlusVersion = New Version(0, 0, 0, 0)
        End Try

    End Sub

    ''' <summary>
    ''' Gets the maximum version from a list of version lists.
    ''' </summary>
    ''' <param name="inlineProperties"> A list of lists containing <see cref="Version" /> objects. </param>
    ''' <returns>
    ''' The maximum <see cref="Version" /> found across all lists. Returns a default version
    ''' (0.0.0.0) if an error occurs or if no versions are available.
    ''' </returns>
    Private Function GetMaxVersion(inlineProperties As List(Of List(Of Version))) As Version
        Try

            Dim maxVersion As Version = Nothing

            ' Loop through each property in the inline list
            For Each versionList In inlineProperties
                ' Loop through the list of versions for the current property
                For Each version In versionList
                    ' If maxVersion is Nothing, or this version is greater, update maxVersion
                    If maxVersion Is Nothing OrElse version.CompareTo(maxVersion) > 0 Then
                        maxVersion = version
                    End If
                Next
            Next

            ' Return the maximum version found
            Return maxVersion
        Catch ex As Exception
            Return New Version(0, 0, 0, 0)
        End Try
    End Function

    ''' <summary>
    ''' Executes the `dotnet --list-runtimes` command to retrieve a list of installed .NET runtimes.
    ''' </summary>
    ''' <remarks>
    ''' The method uses a `Process` to run the command-line tool and reads the output to determine
    ''' which runtimes are installed. If successful, the command output is stored in the
    ''' `CmdLineOutput` property. If an error occurs, the method handles the exception and sets the
    ''' appropriate flags.
    ''' </remarks>
    Private Sub LoadRuntimeListFromCmdLine()
        Try
            ' Initialize the ProcessStartInfo object with the command and its arguments.
            Dim processInfo As New ProcessStartInfo()
            processInfo.FileName = "dotnet"
            processInfo.Arguments = "--list-runtimes"
            processInfo.RedirectStandardOutput = True
            processInfo.UseShellExecute = False
            processInfo.CreateNoWindow = True

            ' Start the process and read the standard output stream.
            Using process As Process = Process.Start(processInfo)
                Using reader As System.IO.StreamReader = process.StandardOutput
                    ' Capture the command output.
                    Dim output As String = reader.ReadToEnd()

                    ' Set the flags and capture the output.
                    CmdLineChecked = True
                    CmdLineError = False
                    CmdLineOutput = output
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that occur and set error flags accordingly.
            CmdLineChecked = True
            CmdLineError = True
            CmdLineOutput = String.Empty
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the latest runtime version from a collection of ASP Core runtime lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the ASP Core runtime version lists. Returns <c>
    ''' Nothing </c> if no versions are available.
    ''' </returns>
    Public Function LatestASPCoreRuntime() As Version
        ' Combine the lists of versions into a single list
        Dim customProperties As New List(Of List(Of Version)) From {
            ASPCore9Versions,
            ASPCore8Versions,
            ASPCore7Versions,
            ASPCore6Versions,
            ASPCore5Versions,
            ASPCore31Versions,
            ASPCore3Versions,
            ASPCore22Versions,
            ASPCore21Versions,
            ASPCore2Versions,
            ASPCore1Versions
            }

        ' Get the maximum version from the combined list
        Return GetMaxVersion(customProperties)
    End Function

    ''' <summary>
    ''' Retrieves the latest ASP runtime version from a collection of ASP runtime lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the ASP runtime version lists. Returns <c>
    ''' Nothing </c> if no versions are available.
    ''' </returns>
    Public Function LatestASPRuntime() As Version
        ' Combine the lists of versions into a single list
        Dim customProperties As New List(Of List(Of Version)) From {
            ASP45Versions,
            ASP4Versions,
            ASP35Versions,
            ASP2Versions,
            ASP11Versions,
            ASP1Versions
        }

        ' Get the maximum version from the combined list
        Return GetMaxVersion(customProperties)
    End Function

    ''' <summary>
    ''' Retrieves the latest Core runtime version from a collection of Core runtime lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the Core runtime version lists. Returns <c>
    ''' Nothing </c> if no versions are available.
    ''' </returns>
    Public Function LatestCoreRuntime() As Version
        ' Combine the lists of versions into a single list
        Dim customProperties As New List(Of List(Of Version)) From {
            Core9Versions,
            Core8Versions,
            Core7Versions,
            Core6Versions,
            Core5Versions,
            Core31Versions,
            Core3Versions,
            Core22Versions,
            Core21Versions,
            Core2Versions,
            Core11Versions,
            Core1Versions
         }

        ' Get the maximum version from the combined list
        Return GetMaxVersion(customProperties)
    End Function

    ''' <summary>
    ''' Retrieves the latest desktop runtime version from a collection of Desktop runtime lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the Desktop runtime version lists. Returns <c>
    ''' Nothing </c> if no versions are available.
    ''' </returns>
    Public Function LatestDesktopRuntime() As Version
        ' Combine the lists of versions into a single list
        Dim customProperties As New List(Of List(Of Version)) From {
            DesktopRuntime9Versions,
            DesktopRuntime8Versions,
            DesktopRuntime7Versions,
            DesktopRuntime6Versions,
            DesktopRuntime5Versions
        }

        ' Get the maximum version from the combined list
        Return GetMaxVersion(customProperties)
    End Function

    ''' <summary>
    ''' Retrieves the latest runtime version from a collection of DotNet Framework lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the DotNet Framework lists. Returns <c> Nothing
    ''' </c> if no versions are available.
    ''' </returns>
    Public Function LatestFrameworkVersion() As Version

        Dim customProperties As New List(Of Version) From {
            Framework45PlusVersion,
            Framework4Version,
            Framework35Version,
            Framework3Version,
            Framework2Version,
            Framework11Version,
            Framework1Version
        }

        Dim result = GetFirstNonZeroVersion(customProperties)

        If result IsNot Nothing Then
            Return result
        Else
            Return New Version(0, 0, 0, 0)
        End If
    End Function

    ''' <summary>
    ''' Retrieves the latest runtime version from a collection of runtime lists.
    ''' </summary>
    ''' <returns>
    ''' The latest <see cref="Version" /> found in the runtime version lists. Returns <c> Nothing
    ''' </c> if no versions are available.
    ''' </returns>
    Public Function LatestRuntime() As Version
        ' Combine the lists of versions into a single list
        Dim customProperties As New List(Of List(Of Version)) From {
            Runtime9Versions,
            Runtime8Versions,
            Runtime7Versions,
            Runtime6Versions,
            Runtime5Versions
        }

        ' Get the maximum version from the combined list
        Return GetMaxVersion(customProperties)
    End Function

End Class
