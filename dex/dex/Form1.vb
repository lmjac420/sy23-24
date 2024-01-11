﻿Imports System.IO

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
        field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New StreamWriter("data.txt")
        outFile.Write(field1.Text)
        outFile.Write("|")
        outFile.Write(field2.Text)
        outFile.Write("|")
        outFile.Write(field3.Text)
        outFile.Write("|")
        outFile.Write(field4.Text)
        outFile.Write("|")
        outFile.Write(field5.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub
End Class
