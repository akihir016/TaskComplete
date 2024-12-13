Imports NAudio.Wave
Imports System.IO

Public Class AudioRecorder
    Private waveIn As WaveInEvent
    Private waveFile As WaveFileWriter
    Private outputFilePath As String

    Public Sub StartRecording()
        ' Create the "recorded" folder if it doesn't exist
        Dim recordedFolderPath As String = Path.Combine(Application.StartupPath, "Recorded")
        If Not Directory.Exists(recordedFolderPath) Then
            Directory.CreateDirectory(recordedFolderPath)
        End If

        ' Set the output file path with the current date
        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        outputFilePath = Path.Combine(recordedFolderPath, $"TcRecorder_{currentDate}.wav")

        waveIn = New WaveInEvent()
        waveIn.WaveFormat = New WaveFormat(44100, 1) ' 44.1kHz, Mono
        waveFile = New WaveFileWriter(outputFilePath, waveIn.WaveFormat)

        AddHandler waveIn.DataAvailable, AddressOf OnDataAvailable
        AddHandler waveIn.RecordingStopped, AddressOf OnRecordingStopped

        waveIn.StartRecording()
    End Sub

    Public Sub StopRecording()
        If waveIn IsNot Nothing Then
            waveIn.StopRecording()
        End If
    End Sub

    Private Sub OnDataAvailable(sender As Object, e As WaveInEventArgs)
        If waveFile IsNot Nothing Then
            waveFile.Write(e.Buffer, 0, e.BytesRecorded)
            waveFile.Flush()
        End If
    End Sub

    Private Sub OnRecordingStopped(sender As Object, e As StoppedEventArgs)
        If waveFile IsNot Nothing Then
            waveFile.Dispose()
            waveFile = Nothing
        End If

        If waveIn IsNot Nothing Then
            waveIn.Dispose()
            waveIn = Nothing
        End If
    End Sub
End Class