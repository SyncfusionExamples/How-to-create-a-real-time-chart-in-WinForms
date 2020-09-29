using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private DataSet prodDs1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private ChartDataBindModel model = null;
        private ChartDataBindModel model1 = null;
        private ChartDataBindModel model2 = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

        DateTime lastTime = DateTime.Now;
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.Depth = 1F;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(136, 612);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Rotation = 0.1F;
            this.chartControl1.Size = new System.Drawing.Size(545, 637);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Syncfusion Essential Chart";
            this.chartControl1.Tilt = 0.1F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Syncfusion Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(547, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 855);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(77, 286);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(261, 39);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(77, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(75, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Line Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(77, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.Location = new System.Drawing.Point(77, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 40);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(77, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 40);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 643);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(910, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Time Scenario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            chartControl1.Trackball.Visible = true;
            chartControl1.Trackball.TrackballTooltipRendering += Trackball_TrackballTooltipRendering1;
        }

        private void Trackball_TrackballTooltipRendering1(object sender, TrackballTooltipEventArgs args)
        {
            args.Text = "";
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            chartControl1.Trackball.Visible = true;
        }

        private void ChartControl1_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {

            int pointIndex = e.Region.PointIndex;
            int seriesIndex = e.Region.SeriesIndex;

            if (pointIndex != -1)
            {
                chartControl1.Trackball.Visible = true;
                MessageBox.Show("X value: " + this.chartControl1.Series[seriesIndex].Points[pointIndex].X + "\nY value: " + this.chartControl1.Series[seriesIndex].Points[pointIndex].YValues[0]);
            }
        }
        #endregion


        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateDataSet();
            InitializeChartData();
            InitializeControlSettings();
            ChartAppearanceStyles.ApplyClassicStyle(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeControlSettings

        private void InitializeControlSettings()
        {
            foreach (string dashstyle in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(dashstyle);
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.Items.Add(100);
            this.comboBox2.Items.Add(200);
            this.comboBox2.Items.Add(400);
            this.comboBox2.Items.Add(600);
            this.comboBox2.Items.Add(800);
            this.comboBox2.Items.Add(1000);
            this.comboBox2.SelectedIndex = 3;
        }
        #endregion

        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.chartControl1.Indexed = false;
            ChartSeries series = new ChartSeries();
            ChartSeries series1 = new ChartSeries();
            ChartSeries series2 = new ChartSeries();
            series.Name = "Products";
            series.Text = series.Name;
            model = new ChartDataBindModel(this.prodDs1, "Products");
            model.XName = "Date";
            model.YNames = new String[] { "Load" };
            model1 = new ChartDataBindModel(this.prodDs1, "Products");
            model1.XName = "Date";
            model1.YNames = new String[] { "Load1" };
            model2 = new ChartDataBindModel(this.prodDs1, "Products");
            model2.XName = "Date";
            model2.YNames = new String[] { "Load2" };
            series.SeriesModel = model;
            series.Type = ChartSeriesType.Custom;
            series.Renderer = new CustomScatterRenderer(series);
            series.Points.Add(10, 01, 10);
            series.Style.DisplayShadow = false;
            this.chartControl1.Series.Add(series);
            series1.SeriesModel = model1;
            series1.Type = ChartSeriesType.Spline;
            series1.Style.DisplayShadow = false;
            series2.SeriesModel = model2;
            series2.Type = ChartSeriesType.Custom;
            series2.Renderer = new CustomScatterRenderer(series2);
            this.chartControl1.Trackball.Line.Color = Color.Blue;
            this.chartControl1.Trackball.Line.Width = 3;
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "hh tt";
            this.chartControl1.PrimaryXAxis.RoundingPlaces = 12;
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(lastTime, lastTime.AddDays(1), 4, ChartDateTimeIntervalType.Hours);
        }
        #endregion

        #region CreateDataSet
        private void CreateDataSet()
        {
            string tableName = "Products";
            prodDs1 = new DataSet();
            prodDs1.Tables.Add(tableName);

            DataColumn ExpiresDate = prodDs1.Tables[tableName].Columns.Add("Date", typeof(System.DateTime));
            DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Load", typeof(double));
            DataColumn Quantity1 = prodDs1.Tables[tableName].Columns.Add("Load1", typeof(double));
            DataColumn Quantity2 = prodDs1.Tables[tableName].Columns.Add("Load2", typeof(double));
            this.timer1.Start();
        }
        #endregion
        #endregion

        #region Events
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

                    prodDs1.Tables[tableName].Rows[count]["Load"] = (double)rand.Next(0, 40);
                    prodDs1.Tables[tableName].Rows[count]["Load1"] = (double)rand.Next(0, 20);
                    prodDs1.Tables[tableName].Rows[count]["Load2"] = (double)rand.Next(40, 80);
                    prodDs1.Tables[tableName].Rows[count]["Date"] = lastTime.AddMinutes(60);
                    lastTime = (DateTime)prodDs1.Tables[tableName].Rows[count]["Date"];

                    if (lastTime >= this.chartControl1.PrimaryXAxis.DateTimeRange.End)
                        this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(this.chartControl1.PrimaryXAxis.DateTimeRange.End, this.chartControl1.PrimaryXAxis.DateTimeRange.End.AddDays(1), 4, ChartDateTimeIntervalType.Hours);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.timer1.Interval = (int)this.comboBox2.SelectedItem;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.Width = float.Parse(this.numericUpDown1.Value.ToString());
            this.chartControl1.Refresh();
        }

        #endregion

    }

    public class CustomScatterRenderer : ChartSeriesRenderer
    {

        public int MyProperty { get; set; }
        public CustomScatterRenderer(ChartSeries series)
            : base(series)
        {

        }
        public override void Render(ChartRenderArgs2D args)
        {
            IndexRange visibleRange = this.CalculateVisibleRange();
            ChartStyledPoint[] styledPoints = this.PrepearePoints();

            Graphics g = (Graphics)args.Graph.GetType().GetProperty("Graphics").GetValue(args.Graph);

            Brush br = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Black);
            pen.LineJoin = LineJoin.Round;
            Font font = new Font("Segoe UI", 12);

            for (int i = visibleRange.From; i <= visibleRange.To; i++)
            {
                ChartStyledPoint point = styledPoints[i];

                if (point.IsVisible)
                {
                    GraphicsPath gp = new GraphicsPath();

                    PointF ptF = args.GetPoint(point.X, point.YValues[0]);
                    Size size = point.Style.Symbol.Size;

                    //Drawing custom symbol
                    RectangleF rect = new RectangleF(ptF.X - size.Width / 2, ptF.Y - size.Height / 2, size.Width + 30, size.Height);

                    gp.AddRectangle(rect);
                    g.FillPath(br, gp);
                    g.DrawPath(pen, gp);

                    //Tooltip for Scatter symbols
                    if (this.Chart.NeedRegionUpdate)
                    {
                        Region region = new Region(gp);
                        this.Chart.ChartRegions.Add(new ChartRegion(region, this.Chart.Series.IndexOf(m_series), point.Index, point.ToolTip, "Symbol"));
                    }
                }
            }

            //Disposing Pen, Brush and Font objects
            font.Dispose();
            br.Dispose();
            pen.Dispose();
        }
    }
}

