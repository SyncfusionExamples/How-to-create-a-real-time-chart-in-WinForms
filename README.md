# How to create a real-time chart in WinForms?

This example illustrates how to create a real time [chart in WinForms](https://help.syncfusion.com/windowsforms/chart/getting-started). Real-time charts can be created by continuously adding new points in existing series in chart. Timer is used to continuously add new points in the chart.

**Step1:** Create a dataset with table, which should contain two columns. The following code example shows how to create a [dataset](https://help.syncfusion.com/windowsforms/chart/chart-data#binding-a-dataset-to-the-chart) with table.
```
string tableName = "Products";
prodDs1 = new DataSet();
prodDs1.Tables.Add(tableName);
DataColumn ExpiresDate = prodDs1.Tables[tableName].Columns.Add("Date", typeof(System.DateTime));
DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Load", typeof(double));
```

**Step2:** Bind the dataset as data source for the series using **SeriesModel**, and then map the columns in the table for x and y-values using the **XName** and **YNames** properties.
```
ChartSeries series = new ChartSeries();
series.Name = "Products";
series.Text = series.Name;
model = new ChartDataBindModel(this.prodDs1, "Products");
model.XName = "Date";
model.YNames = new String[] { "Load" };
series.SeriesModel = model;
series.Type = ChartSeriesType.Spline;
series.Style.DisplayShadow = false;
this.chartControl1.Series.Add(series);
```

**Step3:** Add new rows in table, which is bound as data source for the chart, using timer tick event.
```
private void timer1_Tick(object sender, System.EventArgs e)
{
    try
    {
        string tableName = "Products";
        Random rand = new Random();
        if (prodDs1 != null && prodDs1.Tables.Count > 0)
        {
            DataRow drEmpty = prodDs1.Tables[tableName].NewRow();
            prodDs1.Tables[tableName].Rows.Add(drEmpty);
            int count = Math.Max(0, prodDs1.Tables[tableName].Rows.Count - 1);
            prodDs1.Tables[tableName].Rows[count]["Load"] = (double)rand.Next(0, 60);
            prodDs1.Tables[tableName].Rows[count]["Date"] = lastTime.AddMinutes(30);
        }
     }
     catch (Exception ex)
     {
         Console.WriteLine(ex.ToString());
     }
}
```
The above codes will automatically update the chart with new values present in the data table.

## See also

[How to make the added points as empty at runtime](https://www.syncfusion.com/kb/9498/how-to-make-added-points-as-empty-at-runtime)

[How to bind the data source via chart wizard](https://www.syncfusion.com/kb/7680/how-to-bind-the-data-source-via-chart-wizard)

[How to create a chart in vb.net WinForms](https://www.syncfusion.com/kb/10806/how-to-create-chart-in-vb-net-windows-forms)
