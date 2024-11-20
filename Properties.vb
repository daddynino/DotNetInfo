Partial Public Class DotNet

#Region "Private variables"

    Private CmdLineChecked As Boolean
    Private CmdLineError As Boolean
    Private CmdLineOutput As String

#End Region

#Region "DotNet Version Properties - Private"

#Region "Framework - Private"

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 1.0.
    ''' </summary>
    Private Property _Framework1Version As Version = Nothing
    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 1.1.
    ''' </summary>
    Private Property _Framework11Version As Version = Nothing

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 2.0.
    ''' </summary>
    Private Property _Framework2Version As Version = Nothing

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 3.0.
    ''' </summary>
    Private Property _Framework3Version As Version = Nothing
    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 3.5.
    ''' </summary>
    Private Property _Framework35Version As Version = Nothing

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 4.0.
    ''' </summary>
    Private Property _Framework4Version As Version = Nothing

    ''' <summary>
    ''' Gets or sets the installed .NET Framework 4.5 and above versions.
    ''' </summary>
    Private Property _Framework45PlusVersion As Version = Nothing

#End Region

#Region "ASP Core - Private"

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 1 versions
    ''' </summary>
    Private Property _ASPCore1Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 2.1 versions
    ''' </summary>
    Private Property _ASPCore21Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 2.2 versions
    ''' </summary>
    Private Property _ASPCore22Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 2 versions
    ''' </summary>
    Private Property _ASPCore2Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 3.1 versions
    ''' </summary>
    Private Property _ASPCore31Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 3 versions
    ''' </summary>
    Private Property _ASPCore3Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 5 versions
    ''' </summary>
    Private Property _ASPCore5Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 6 versions
    ''' </summary>
    Private Property _ASPCore6Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 7 versions
    ''' </summary>
    Private Property _ASPCore7Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 8 versions
    ''' </summary>
    Private Property _ASPCore8Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASPCore 9 versions
    ''' </summary>
    Private Property _ASPCore9Versions As List(Of Version)

#End Region

#Region "ASP.NET - Private"

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 1.1 versions
    ''' </summary>
    Private Property _ASP11Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 1 versions
    ''' </summary>
    Private Property _ASP1Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 2.0 versions
    ''' </summary>
    Private Property _ASP2Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 3.5 versions
    ''' </summary>
    Private Property _ASP35Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 4.5 versions
    ''' </summary>
    Private Property _ASP45Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET ASP 4 versions
    ''' </summary>
    Private Property _ASP4Versions As List(Of Version)

#End Region

#Region ".Net Core - Private"

    ''' <summary>
    ''' Gets or sets the installed .NET Core 1.1 versions
    ''' </summary>
    Private Property _Core11Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 1 versions
    ''' </summary>
    Private Property _Core1Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 2.1 versions
    ''' </summary>
    Private Property _Core21Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 2.2 versions
    ''' </summary>
    Private Property _Core22Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 2 versions
    ''' </summary>
    Private Property _Core2Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 3.1 versions
    ''' </summary>
    Private Property _Core31Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 3.0 versions
    ''' </summary>
    Private Property _Core3Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 5.0 versions
    ''' </summary>
    Private Property _Core5Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 6.0 versions
    ''' </summary>
    Private Property _Core6Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 7.0 versions
    ''' </summary>
    Private Property _Core7Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 8.0 versions
    ''' </summary>
    Private Property _Core8Versions As List(Of Version)

    ''' <summary>
    ''' Gets or sets the installed .NET Core 9.0 versions
    ''' </summary>
    Private Property _Core9Versions As List(Of Version)

#End Region

#Region "Runtimes - Private"

    ''' <summary>
    ''' A private list that stores installed versions of .NET 5 runtimes.
    ''' </summary>
    Private Property _Runtime5Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 6 runtimes.
    ''' </summary>
    Private Property _Runtime6Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 7 runtimes.
    ''' </summary>
    Private Property _Runtime7Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 8 runtimes.
    ''' </summary>
    Private Property _Runtime8Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 9 runtimes.
    ''' </summary>
    Private Property _Runtime9Versions As List(Of Version)

#End Region

#Region "Desktop Runtimes - Private"

    ''' <summary>
    ''' A private list that stores installed versions of .NET 5 Desktop Runtimes.
    ''' </summary>
    Private Property _DesktopRuntime5Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 6 Desktop Runtimes.
    ''' </summary>
    Private Property _DesktopRuntime6Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 7 Desktop Runtimes.
    ''' </summary>
    Private Property _DesktopRuntime7Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 8 Desktop Runtimes.
    ''' </summary>
    Private Property _DesktopRuntime8Versions As List(Of Version)

    ''' <summary>
    ''' A private list that stores installed versions of .NET 9 Desktop Runtimes.
    ''' </summary>
    Private Property _DesktopRuntime9Versions As List(Of Version)

#End Region

#End Region

#Region "DotNet Version Properties - Public"

#Region "Framework - Public"

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 1.1
    ''' </summary>
    Public Property Framework11Version As Version
        Get
            Return If(_Framework11Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework11Version = value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 1.0
    ''' </summary>
    Public Property Framework1Version As Version
        Get
            Return If(_Framework1Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework1Version = value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 2
    ''' </summary>
    Public Property Framework2Version As Version
        Get
            Return If(_Framework2Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework2Version = value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 3.5
    ''' </summary>
    Public Property Framework35Version As Version
        Get
            Return If(_Framework35Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework35Version = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 3
    ''' </summary>
    Public Property Framework3Version As Version
        Get
            Return If(_Framework3Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework3Version = value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 4.5 or higher (max 4.8.1)
    ''' </summary>
    Public Property Framework45PlusVersion As Version
        Get
            Return If(_Framework45PlusVersion, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework45PlusVersion = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the installed .NET Framework version 4
    ''' </summary>
    Public Property Framework4Version As Version
        Get
            Return If(_Framework4Version, New Version(0, 0, 0, 0))
        End Get
        Set(value As Version)
            _Framework4Version = value
        End Set

    End Property

#End Region

#Region "ASP Core - Public"

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 1.0 runtime versions
    ''' </summary>
    Public Property ASPCore1Versions As List(Of Version)
        Get
            If _ASPCore1Versions Is Nothing Then
                _ASP1Versions = New List(Of Version)
            End If
            Return _ASPCore1Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore1Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 2.1 runtime versions
    ''' </summary>
    Public Property ASPCore21Versions As List(Of Version)
        Get
            If _ASPCore21Versions Is Nothing Then
                _ASPCore21Versions = New List(Of Version)
            End If
            Return _ASPCore21Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore21Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 2.2 runtime versions
    ''' </summary>
    Public Property ASPCore22Versions As List(Of Version)
        Get
            If _ASPCore22Versions Is Nothing Then
                _ASPCore22Versions = New List(Of Version)
            End If
            Return _ASPCore22Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore22Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 2.0 runtime versions
    ''' </summary>
    Public Property ASPCore2Versions As List(Of Version)
        Get
            If _ASPCore2Versions Is Nothing Then
                _ASPCore2Versions = New List(Of Version)
            End If
            Return _ASPCore2Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore2Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 3.1 runtime versions
    ''' </summary>
    Public Property ASPCore31Versions As List(Of Version)
        Get
            If _ASPCore31Versions Is Nothing Then
                _ASPCore31Versions = New List(Of Version)
            End If
            Return _ASPCore31Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore31Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 3.0 runtime versions
    ''' </summary>
    Public Property ASPCore3Versions As List(Of Version)
        Get
            If _ASPCore3Versions Is Nothing Then
                _ASPCore3Versions = New List(Of Version)
            End If
            Return _ASPCore3Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore3Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 5.0 runtime versions
    ''' </summary>
    Public Property ASPCore5Versions As List(Of Version)
        Get
            If _ASPCore5Versions Is Nothing Then
                _ASPCore5Versions = New List(Of Version)
            End If
            Return _ASPCore5Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore5Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 6.0 runtime versions
    ''' </summary>
    Public Property ASPCore6Versions As List(Of Version)
        Get
            If _ASPCore6Versions Is Nothing Then
                _ASPCore6Versions = New List(Of Version)
            End If
            Return _ASPCore6Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore6Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 7.0 runtime versions
    ''' </summary>
    Public Property ASPCore7Versions As List(Of Version)
        Get
            If _ASPCore7Versions Is Nothing Then
                _ASPCore7Versions = New List(Of Version)
            End If
            Return _ASPCore7Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore7Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 8.0 runtime versions
    ''' </summary>
    Public Property ASPCore8Versions As List(Of Version)
        Get
            If _ASPCore8Versions Is Nothing Then
                _ASPCore8Versions = New List(Of Version)
            End If
            Return _ASPCore8Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore8Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net Core 9.0 runtime versions
    ''' </summary>
    Public Property ASPCore9Versions As List(Of Version)
        Get
            If _ASPCore9Versions Is Nothing Then
                _ASPCore9Versions = New List(Of Version)
            End If
            Return _ASPCore9Versions
        End Get
        Set(value As List(Of Version))
            _ASPCore9Versions = value
        End Set
    End Property

#End Region

#Region "ASP.Net - Public"

    ''' <summary>
    ''' Gets or sets the list of installed .Net ASP 1.1 runtime versions
    ''' </summary>
    Public Property ASP11Versions As List(Of Version)
        Get
            If _ASP11Versions Is Nothing Then
                _ASP11Versions = New List(Of Version)
            End If
            Return _ASP11Versions
        End Get
        Set(value As List(Of Version))
            _ASP11Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed ASP.Net 1.0 runtime versions
    ''' </summary>
    Public Property ASP1Versions As List(Of Version)
        Get
            If _ASP1Versions Is Nothing Then
                _ASP1Versions = New List(Of Version)
            End If
            Return _ASP1Versions
        End Get
        Set(value As List(Of Version))
            _ASP1Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net ASP 2.0 runtime versions
    ''' </summary>
    Public Property ASP2Versions As List(Of Version)
        Get
            If _ASP2Versions Is Nothing Then
                _ASP2Versions = New List(Of Version)
            End If
            Return _ASP2Versions
        End Get
        Set(value As List(Of Version))
            _ASP2Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net ASP 3.5 runtime versions
    ''' </summary>
    Public Property ASP35Versions As List(Of Version)
        Get
            If _ASP35Versions Is Nothing Then
                _ASP35Versions = New List(Of Version)
            End If
            Return _ASP35Versions
        End Get
        Set(value As List(Of Version))
            _ASP35Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net ASP 4.5 runtime versions
    ''' </summary>
    Public Property ASP45Versions As List(Of Version)
        Get
            If _ASP45Versions Is Nothing Then
                _ASP45Versions = New List(Of Version)
            End If
            Return _ASP45Versions
        End Get
        Set(value As List(Of Version))
            _ASP45Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net ASP 4 runtime versions
    ''' </summary>
    Public Property ASP4Versions As List(Of Version)
        Get
            If _ASP4Versions Is Nothing Then
                _ASP4Versions = New List(Of Version)
            End If
            Return _ASP4Versions
        End Get
        Set(value As List(Of Version))
            _ASP4Versions = value
        End Set
    End Property

#End Region

#Region ".Net Core - Public"

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 1.1 runtime versions
    ''' </summary>
    Public Property Core11Versions As List(Of Version)
        Get
            If _Core11Versions Is Nothing Then
                _Core11Versions = New List(Of Version)
            End If
            Return _Core11Versions
        End Get
        Set(value As List(Of Version))
            _Core11Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 1.0 runtime versions
    ''' </summary>
    Public Property Core1Versions As List(Of Version)
        Get
            If _Core1Versions Is Nothing Then
                _Core1Versions = New List(Of Version)
            End If
            Return _Core1Versions
        End Get
        Set(value As List(Of Version))
            _Core1Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 2.1 runtime versions
    ''' </summary>
    Public Property Core21Versions As List(Of Version)
        Get
            If _Core21Versions Is Nothing Then
                _Core21Versions = New List(Of Version)
            End If
            Return _Core21Versions
        End Get
        Set(value As List(Of Version))
            _Core21Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 2.2 runtime versions
    ''' </summary>
    Public Property Core22Versions As List(Of Version)
        Get
            If _Core22Versions Is Nothing Then
                _Core22Versions = New List(Of Version)
            End If
            Return _Core22Versions
        End Get
        Set(value As List(Of Version))
            _Core22Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 2.0 runtime versions
    ''' </summary>
    Public Property Core2Versions As List(Of Version)
        Get
            If _Core2Versions Is Nothing Then
                _Core2Versions = New List(Of Version)
            End If
            Return _Core2Versions
        End Get
        Set(value As List(Of Version))
            _Core2Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 3.1 runtime versions
    ''' </summary>
    Public Property Core31Versions As List(Of Version)
        Get
            If _Core31Versions Is Nothing Then
                _Core31Versions = New List(Of Version)
            End If
            Return _Core31Versions
        End Get
        Set(value As List(Of Version))
            _Core31Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 3.0 runtime versions
    ''' </summary>
    Public Property Core3Versions As List(Of Version)
        Get
            If _Core3Versions Is Nothing Then
                _Core3Versions = New List(Of Version)
            End If
            Return _Core3Versions
        End Get
        Set(value As List(Of Version))
            _Core3Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 5 runtime versions
    ''' </summary>
    Public Property Core5Versions As List(Of Version)
        Get
            If _Core5Versions Is Nothing Then
                _Core5Versions = New List(Of Version)
            End If
            Return _Core5Versions
        End Get
        Set(value As List(Of Version))
            _Core5Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 6 runtime versions
    ''' </summary>
    Public Property Core6Versions As List(Of Version)
        Get
            If _Core6Versions Is Nothing Then
                _Core6Versions = New List(Of Version)
            End If
            Return _Core6Versions
        End Get
        Set(value As List(Of Version))
            _Core6Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 7 runtime versions
    ''' </summary>
    Public Property Core7Versions As List(Of Version)
        Get
            If _Core7Versions Is Nothing Then
                _Core7Versions = New List(Of Version)
            End If
            Return _Core7Versions
        End Get
        Set(value As List(Of Version))
            _Core7Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 8 runtime versions
    ''' </summary>
    Public Property Core8Versions As List(Of Version)
        Get
            If _Core8Versions Is Nothing Then
                _Core8Versions = New List(Of Version)
            End If
            Return _Core8Versions
        End Get
        Set(value As List(Of Version))
            _Core8Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .Net Core 9 runtime versions
    ''' </summary>
    Public Property Core9Versions As List(Of Version)
        Get
            If _Core9Versions Is Nothing Then
                _Core9Versions = New List(Of Version)
            End If
            Return _Core9Versions
        End Get
        Set(value As List(Of Version))
            _Core9Versions = value
        End Set
    End Property

#End Region

#Region "Runtimes - Public"

    ''' <summary>
    ''' Gets or sets the list of installed .NET 5 runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property Runtime5Versions As List(Of Version)
        Get
            If _Runtime5Versions Is Nothing Then
                _Runtime5Versions = New List(Of Version)
            End If
            Return _Runtime5Versions
        End Get
        Set(value As List(Of Version))
            _Runtime5Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 6 runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property Runtime6Versions As List(Of Version)
        Get
            If _Runtime6Versions Is Nothing Then
                _Runtime6Versions = New List(Of Version)
            End If
            Return _Runtime6Versions
        End Get
        Set(value As List(Of Version))
            _Runtime6Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 7 runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property Runtime7Versions As List(Of Version)
        Get
            If _Runtime7Versions Is Nothing Then
                _Runtime7Versions = New List(Of Version)
            End If
            Return _Runtime7Versions
        End Get
        Set(value As List(Of Version))
            _Runtime7Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 8 runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property Runtime8Versions As List(Of Version)
        Get
            If _Runtime8Versions Is Nothing Then
                _Runtime8Versions = New List(Of Version)
            End If
            Return _Runtime8Versions
        End Get
        Set(value As List(Of Version))
            _Runtime8Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 9 runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property Runtime9Versions As List(Of Version)
        Get
            If _Runtime9Versions Is Nothing Then
                _Runtime9Versions = New List(Of Version)
            End If
            Return _Runtime9Versions
        End Get
        Set(value As List(Of Version))
            _Runtime9Versions = value
        End Set
    End Property

#End Region

#Region "Desktop Runtimes - Public"

    ''' <summary>
    ''' Gets or sets the list of installed .NET 5 Desktop Runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property DesktopRuntime5Versions As List(Of Version)
        Get
            If _DesktopRuntime5Versions Is Nothing Then
                _DesktopRuntime5Versions = New List(Of Version)
            End If
            Return _DesktopRuntime5Versions
        End Get
        Set(value As List(Of Version))
            _DesktopRuntime5Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 6 Desktop Runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property DesktopRuntime6Versions As List(Of Version)
        Get
            If _DesktopRuntime6Versions Is Nothing Then
                _DesktopRuntime6Versions = New List(Of Version)
            End If
            Return _DesktopRuntime6Versions
        End Get
        Set(value As List(Of Version))
            _DesktopRuntime6Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 7 Desktop Runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property DesktopRuntime7Versions As List(Of Version)
        Get
            If _DesktopRuntime7Versions Is Nothing Then
                _DesktopRuntime7Versions = New List(Of Version)
            End If
            Return _DesktopRuntime7Versions
        End Get
        Set(value As List(Of Version))
            _DesktopRuntime7Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 8 Desktop Runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property DesktopRuntime8Versions As List(Of Version)
        Get
            If _DesktopRuntime8Versions Is Nothing Then
                _DesktopRuntime8Versions = New List(Of Version)
            End If
            Return _DesktopRuntime8Versions
        End Get
        Set(value As List(Of Version))
            _DesktopRuntime8Versions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the list of installed .NET 9 Desktop Runtime versions.
    ''' </summary>
    ''' <returns> A list of <see cref="Version" /> objects. </returns>
    Public Property DesktopRuntime9Versions As List(Of Version)
        Get
            If _DesktopRuntime9Versions Is Nothing Then
                _DesktopRuntime9Versions = New List(Of Version)
            End If
            Return _DesktopRuntime9Versions
        End Get
        Set(value As List(Of Version))
            _DesktopRuntime9Versions = value
        End Set
    End Property

#End Region

#End Region

End Class
