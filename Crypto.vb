Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Crypto
    Public Enum CryptoTypes
        encTypeDES = 0
        encTypeRC2
        encTypeRijndael
        encTypeTripleDES
    End Enum

    Private Const CRYPT_DEFAULT_PASSWORD As String = "CB06cfE507a1"
    Private Const CRYPT_DEFAULT_METHOD As CryptoTypes = CryptoTypes.encTypeRijndael
    Private mKey As Byte() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private mIV As Byte() = {65, 110, 68, 26, 69, 178, 200, 219}
    Private SaltByteArray As Byte() = {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76}
    Private mCryptoType As CryptoTypes = CRYPT_DEFAULT_METHOD
    Private mPassword As String = CRYPT_DEFAULT_PASSWORD

    Public Sub New()
        calculateNewKeyAndIV()
    End Sub

    Public Sub New(ByVal CryptoType As CryptoTypes)
        Me.CryptoType = CryptoType
    End Sub

    Public Property CryptoType As CryptoTypes
        Get
            Return mCryptoType
        End Get
        Set(ByVal value As CryptoTypes)

            If mCryptoType <> value Then
                mCryptoType = value
                calculateNewKeyAndIV()
            End If
        End Set
    End Property

    Public Property Password As String
        Get
            Return mPassword
        End Get
        Set(ByVal value As String)

            If mPassword <> value Then
                mPassword = value
                calculateNewKeyAndIV()
            End If
        End Set
    End Property

    Public Function Encrypt(ByVal inputText As String) As String
        Dim UTF8Encoder As UTF8Encoding = New UTF8Encoding()
        Dim inputBytes As Byte() = UTF8Encoder.GetBytes(inputText)
        Return Convert.ToBase64String(EncryptDecrypt(inputBytes, True))
    End Function

    Public Function Encrypt(ByVal inputText As String, ByVal password As String) As String
        Me.Password = password
        Return Me.Encrypt(inputText)
    End Function

    Public Function Encrypt(ByVal inputText As String, ByVal password As String, ByVal cryptoType As CryptoTypes) As String
        mCryptoType = cryptoType
        Return Me.Encrypt(inputText, password)
    End Function

    Public Function Encrypt(ByVal inputText As String, ByVal cryptoType As CryptoTypes) As String
        Me.CryptoType = cryptoType
        Return Me.Encrypt(inputText)
    End Function

    Public Function Decrypt(ByVal inputText As String) As String
        Dim UTF8Encoder As UTF8Encoding = New UTF8Encoding()
        Dim inputBytes As Byte() = Convert.FromBase64String(inputText)
        Return UTF8Encoder.GetString(EncryptDecrypt(inputBytes, False))
    End Function

    Public Function Decrypt(ByVal inputText As String, ByVal password As String) As String
        Me.Password = password
        Return Decrypt(inputText)
    End Function

    Public Function Decrypt(ByVal inputText As String, ByVal password As String, ByVal cryptoType As CryptoTypes) As String
        mCryptoType = cryptoType
        Return Decrypt(inputText, password)
    End Function

    Public Function Decrypt(ByVal inputText As String, ByVal cryptoType As CryptoTypes) As String
        Me.CryptoType = cryptoType
        Return Decrypt(inputText)
    End Function

    Private Function EncryptDecrypt(ByVal inputBytes As Byte(), ByVal Encrpyt As Boolean) As Byte()
        Dim transform As ICryptoTransform = getCryptoTransform(Encrpyt)
        Dim memStream As MemoryStream = New MemoryStream()

        Try
            Dim cryptStream As CryptoStream = New CryptoStream(memStream, transform, CryptoStreamMode.Write)
            cryptStream.Write(inputBytes, 0, inputBytes.Length)
            cryptStream.FlushFinalBlock()
            Dim output As Byte() = memStream.ToArray()
            cryptStream.Close()
            Return output
        Catch e As Exception
            Throw New Exception("Error in symmetric engine. Error : " & e.Message, e)
        End Try
    End Function

    Private Function getCryptoTransform(ByVal encrypt As Boolean) As ICryptoTransform
        Dim SA As SymmetricAlgorithm = selectAlgorithm()
        SA.Key = mKey
        SA.IV = mIV

        If encrypt Then
            Return SA.CreateEncryptor()
        Else
            Return SA.CreateDecryptor()
        End If
    End Function

    Private Function selectAlgorithm() As SymmetricAlgorithm
        Dim SA As SymmetricAlgorithm

        Select Case mCryptoType
            Case CryptoTypes.encTypeDES
                SA = DES.Create()
            Case CryptoTypes.encTypeRC2
                SA = RC2.Create()
            Case CryptoTypes.encTypeRijndael
                SA = Rijndael.Create()
            Case CryptoTypes.encTypeTripleDES
                SA = TripleDES.Create()
            Case Else
                SA = TripleDES.Create()
        End Select

        Return SA
    End Function

    Private Sub calculateNewKeyAndIV()
        Dim pdb As PasswordDeriveBytes = New PasswordDeriveBytes(mPassword, SaltByteArray)
        Dim algo As SymmetricAlgorithm = selectAlgorithm()
        mKey = pdb.GetBytes(algo.KeySize / 8)
        mIV = pdb.GetBytes(algo.BlockSize / 8)
    End Sub
End Class

Public Class Hashing
        Public Enum HashingTypes
            SHA
            SHA256
            SHA384
            SHA512
            MD5
        End Enum

        Public Shared Function Hash(ByVal inputText As String) As String
            Return ComputeHash(inputText, HashingTypes.MD5)
        End Function

        Public Shared Function Hash(ByVal inputText As String, ByVal hashingType As HashingTypes) As String
            Return ComputeHash(inputText, hashingType)
        End Function

        Public Shared Function isHashEqual(ByVal inputText As String, ByVal hashText As String) As Boolean
            Return (Hash(inputText) = hashText)
        End Function

        Public Shared Function isHashEqual(ByVal inputText As String, ByVal hashText As String, ByVal hashingType As HashingTypes) As Boolean
            Return (Hash(inputText, hashingType) = hashText)
        End Function

        Private Shared Function ComputeHash(ByVal inputText As String, ByVal hashingType As HashingTypes) As String
            Dim HA As HashAlgorithm = getHashAlgorithm(hashingType)
            Dim UTF8Encoder As UTF8Encoding = New UTF8Encoding()
            Dim inputBytes As Byte() = UTF8Encoder.GetBytes(inputText)
            Dim output As Byte() = HA.ComputeHash(inputBytes)
            Return Convert.ToBase64String(output)
        End Function

        Private Shared Function getHashAlgorithm(ByVal hashingType As HashingTypes) As HashAlgorithm
            Select Case hashingType
                Case HashingTypes.MD5
                    Return New MD5CryptoServiceProvider()
                Case HashingTypes.SHA
                    Return New SHA1CryptoServiceProvider()
                Case HashingTypes.SHA256
                    Return New SHA256Managed()
                Case HashingTypes.SHA384
                    Return New SHA384Managed()
                Case HashingTypes.SHA512
                    Return New SHA512Managed()
                Case Else
                    Return New MD5CryptoServiceProvider()
            End Select
        End Function
End Class