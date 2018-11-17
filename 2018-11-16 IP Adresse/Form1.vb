Public Class Form1
    Dim IPone As Long
    Dim IPtwo As Long
    Dim IPthree As Long
    Dim IPfour As Long
    Dim fip As Long
    Dim achtb As Long
    Dim erg As Long
    Dim sammler As String
    Dim xyz As Single
    Dim gesamt As String
    Dim lenght As Single
    Dim difference As Single

    Private Sub cmdKnopf_Click(sender As Object, e As EventArgs) Handles cmdKnopf.Click
        IPone = txtIPone.Text
        IPtwo = txtIPtwo.Text
        IPthree = txtIPthree.Text
        IPfour = txtIPfour.Text
        achtb = 128
        xyz = 0

        IPone = dezubin(IPone)
        IPtwo = dezubin(IPtwo)
        IPthree = dezubin(IPthree)
        IPfour = dezubin(IPfour)

        'IPone = addleadzeros(IPone)
        'IPtwo = addleadzeros(IPtwo)
        'IPthree = addleadzeros(IPthree)
        'IPfour = addleadzeros(IPfour)

        gesamt = IPone & IPtwo & IPthree & IPfour
        txtTest.Text = IPone
        txtAusgabe.Text = gesamt

    End Sub

    Public Function dezubin(fip)
        achtb = 128
        erg = 0
        sammler = ""
        xyz = 0

        While xyz < 8
            'MsgBox("IP: " & fip)
            'MsgBox("Teiler: " & achtb)
            erg = fip - achtb   ' IP - 128 =     IP - 64   etc
            If erg >= 0 Then
                sammler = sammler & "1"
                fip = erg ' fip = IP - 128
            Else
                sammler = sammler & "0"
            End If
            achtb = achtb / 2   '128/2 = 64   64/2 
            xyz = xyz + 1


            'MsgBox("Sammler: " & sammler)
        End While
        dezubin = sammler
    End Function


    'Public Function addleadzeros(fip)
    '    lenght = Len(fip)
    '    MsgBox(lenght)
    '    difference = 8 - lenght
    '    If lenght < 8 Then
    '        fip.ToString().PadLeft(difference, "0")
    '    End If
    '    MsgBox(difference)
    '    addleadzeros = fip
    'End Function
End Class
