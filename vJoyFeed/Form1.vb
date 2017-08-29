Imports System.Runtime.InteropServices





Public Class Form1


    Public cd As cdata


    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click



        'http://vjoystick.sourceforge.net/site/includes/SDK_ReadMe.pdf


        Dim id As Int32 = 1
        Dim acq As Boolean = False




        AcquireVJD(id)

        cd.LX = &H4000
        cd.LY = &H4000

        cd.RX = &H2000
        cd.RY = &H6000


        cd.lButtons = Val(txtButtonsVal.Text)


        UpdateVJD(id, cd)



        RelinquishVJD(id)
    End Sub
End Class


Public Module vj

    Public Structure cdata
        Dim bDevice As Byte
        Dim wThrottle As Int32
        Dim wRudder As Int32
        Dim wAileron As Int32

        Dim LX As Int32
        Dim LY As Int32
        Dim LT As Int32

        Dim RX As Int32
        Dim RY As Int32
        Dim RT As Int32

        Dim wSlider As Int32
        Dim wDial As Int32
        Dim wWheel As Int32

        Dim wAxisVX As Int32
        Dim wAxisVY As Int32
        Dim wAxisVZ As Int32

        Dim wAxisVBRX As Int32
        Dim wAxisVBRY As Int32
        Dim wAxisVBRZ As Int32

        Dim lButtons As Int32
        Dim bHats As UInt32
        Dim bHatsEx1 As UInt32
        Dim bHatsEx2 As UInt32
        Dim bHatsEx3 As UInt32

        Dim lButtonsEx1 As Int32
        Dim lButtonsEx2 As Int32
        Dim lButtonsEx3 As Int32

    End Structure


    <DllImport("vJoyInterface.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
    Public Function AcquireVJD(ByVal id As UInt32) As Boolean
    End Function

    <DllImport("vJoyInterface.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
    Public Sub RelinquishVJD(ByVal id As UInt32)
    End Sub

    <DllImport("vJoyInterface.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
    Public Function UpdateVJD(ByVal id As UInt32, ByRef cd As cdata) As Boolean
    End Function

    <DllImport("vJoyInterface.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
    Public Function SetAxis(ByVal val As Int32, ByVal id As UInt32, ByVal Axis As UInt32) As Boolean
    End Function

    <DllImport("vJoyInterface.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
    Public Function ResetVJD(ByVal id As UInt32) As Boolean
    End Function


End Module