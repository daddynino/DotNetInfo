Imports Microsoft.Win32
Partial Public Class DotNet

    ''' <summary>
    ''' Checks if a specified .NET Framework version is installed by searching the registry in both
    ''' the standard path and the Wow6432Node path for 32-bit frameworks on 64-bit systems.
    ''' </summary>
    ''' <param name="FrameworkKey"> The registry key name for the .NET Framework version. </param>
    ''' <param name="RegWord">     
    ''' The registry value name that indicates whether the framework is installed.
    ''' </param>
    ''' <returns>
    ''' A <see cref="Version" /> object representing the installed .NET Framework version, or <c>
    ''' Version(0, 0, 0, 0) </c> if the framework is not installed.
    ''' </returns>
    Private Shared Function CheckFramework(FrameworkKey As String, RegWord As String) As Version

        Dim version As Version = GetFrameworkVersion("Software\" & FrameworkKey, RegWord)
        If version <> New Version(0, 0, 0, 0) Then
            Return version
        End If

        version = GetFrameworkVersion("SOFTWARE\Wow6432Node\" & FrameworkKey, RegWord)
        Return version
    End Function

    ''' <summary>
    ''' Retrieves the .NET Framework version from the specified registry key path.
    ''' </summary>
    ''' <param name="RegPath">
    ''' The full registry path to the framework key (e.g., "Software\Microsoft\NET Framework Setup\NDP\v4\Full").
    ''' </param>
    ''' <param name="RegWord">
    ''' The registry value name that indicates whether the framework is installed (e.g., "Install").
    ''' </param>
    ''' <returns>
    ''' A <see cref="Version" /> object representing the .NET Framework version found in the
    ''' registry, or <c> Version(0, 0, 0, 0) </c> if the key is not found or the version is not installed.
    ''' </returns>
    ''' <remarks>
    ''' This method reads the registry and checks both the installation status and the "Version"
    ''' value of the .NET Framework.
    ''' </remarks>
    Private Shared Function GetFrameworkVersion(RegPath As String, RegWord As String) As Version
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(RegPath)
            If key IsNot Nothing AndAlso key.GetValue(RegWord) IsNot Nothing Then
                Dim isInstalled As Integer = CInt(key.GetValue(RegWord))
                If isInstalled = 1 AndAlso key.GetValue("Version") IsNot Nothing Then
                    Return New Version(CStr(key.GetValue("Version")))
                End If
            End If
        End Using
        Return New Version(0, 0, 0, 0)
    End Function

End Class
