﻿#r "System.Windows.Forms.DataVisualization.dll"
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting

// A collection of tuples containing titles and values for the chart
let data = 
  [ "Africa", 1033043; "Asia", 4166741; "Europe", 732759; 
    "South America", 588649; "North America", 351659; "Oceania", 35838  ]

// Create a chart containing a default area and show it on a form
let chart = new Chart(Dock = DockStyle.Fill)
let form = new Form(Visible = true, Width = 700, Height = 500)
chart.ChartAreas.Add(new ChartArea("MainAre"))
form.Controls.Add(chart)

// Create series and add it to the chart
let series = new Series(ChartType = SeriesChartType.Bar)
chart.Series.Add(series)
// Specify data for the series using data-binding
series.Points.DataBindXY(data, "Item1", data, "Item2")
