Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'setup the chart area 
        Chart1.Titles.Add("Line of x^2") 'specify chart name
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")
        With Chart1.ChartAreas("Default")
            .AxisX.Title = "X" 'x label
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Y" 'y label
        End With
        'specify series plot lines
        Chart1.Series.Clear()
        Chart1.Series.Add("plot1")
        Chart1.Series("plot1").Color = Color.Red
        Chart1.Series("plot1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        Dim n As Integer = 1000 ' number of points
        Dim y As Single
        For x As Integer = 1 To n Step 1
            y = x * x
            Chart1.Series("plot1").Points.AddXY(x, y)
        Next
    End Sub
End Class
