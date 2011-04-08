﻿#r "System.Windows.Forms.DataVisualization.dll"
open System
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting

// Calculate X and Y coordinates using two functions
let data = 
  [ for i in 0.0 .. 0.02 .. 2.0 * Math.PI -> 
      sin i, cos i * sin i ]

// Create a chart containing a default area and show it on a form
let chart = new Chart(Dock = DockStyle.Fill)
let form = new Form(Visible = true, Width = 700, Height = 500)
chart.ChartAreas.Add(new ChartArea("MainArea"))
form.Controls.Add(chart)

// Create series and add it to the chart
let series = new Series(ChartType = SeriesChartType.Line)
chart.Series.Add(series)

// Add data to the series in a loop
for x, y in data do
  series.Points.AddXY(x, y) |> ignore
