Public Class Form1
    Dim IPone As String
    Dim IPtwo As String
    Dim IPthree As String
    Dim IPfour As String
    Dim fip As Long
    Dim achtb As Long
    Dim erg As Long
    Dim sammler As String
    Dim xyz As Single
    Dim gesamt As String

    Private Sub cmdKnopf_Click(sender As Object, e As EventArgs) Handles cmdKnopf.Click
        IPone = txtIPone.Text
        IPtwo = txtIPtwo.Text
        IPthree = txtIPthree.Text
        IPfour = txtIPfour.Text
        achtb = 128
        xyz = 0

        IPone = dezubin(CStr(IPone))
        IPtwo = dezubin(CStr(IPtwo))
        IPthree = dezubin(CStr(IPthree))
        IPfour = dezubin(CStr(IPfour))

        gesamt = IPone & IPtwo & IPthree & IPfour

        txtAusgabe.Text = gesamt
    End Sub

    Public Function dezubin(fip)
        achtb = 128
        erg = 0
        sammler = ""
        xyz = 0

        While xyz < 8
            erg = fip - achtb   ' IP - 128 =     IP - 64   etc
            If erg >= 0 Then
                sammler = sammler & "1"
                fip = erg ' fip = IP - 128
            Else
                sammler = sammler & "0"
            End If
            achtb = achtb / 2   '128/2 = 64   64/2 
            xyz = xyz + 1
        End While
        dezubin = sammler
    End Function

End Class
