﻿#r "System.Windows.Forms.DataVisualization.dll"
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting

// Create a chart containing a default area and show it on a form
let chart = new Chart(Dock = DockStyle.Fill)
let form = new Form(Visible = true, Width = 700, Height = 500)
chart.ChartAreas.Add(new ChartArea("MainArea"))
form.Controls.Add(chart)

// Create series and add it to the chart
let series = new Series(ChartType = SeriesChartType.BoxPlot)
chart.Series.Add(series)

// Add data to the series in a loop
[| -12.7; 11.6; -8.3; 6.4; -2.5; -1.6 |]
|> Array.map box |> series.Points.AddY |> ignore
