using System;
using System.Drawing;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     OLHC chart control. Draws OLHC chart
    /// </summary>
    public partial class OLHCChart : UserControl
    {
        private const int Step = 30; // step on X axis
        private const int LittleStep = 5;
        private const int IndentX = 25; // control X axis border
        private const string LabelTimeFormat = "HH:mm";
        private const string LabelPriceFormat = "#.##";
        private readonly Font _labelFont = new Font(FontFamily.GenericSerif, 7);
        private Bar[] _bars;
        private string _caption = string.Empty;

        private int _indentY = -1; //control Y axis border
        private bool _isNeedClear;

        //coordinates of chart end points

        //minimum and maximum prices
        private double _maxValPrice = -1;
        private int _maxX = -1;
        private int _maxY = -1;
        private double _minValPrice = -1;
        private double _pixPrice = -1; //price per 1 pixel
        private int _zeroX = -1;
        private int _zeroY = -1;

        /// <summary>
        ///     OLHC chart constructor
        /// </summary>
        public OLHCChart()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Returns number of possible intervals, calculated from this control width
        /// </summary>
        public int IntervalCnt
        {
            get { return (Width - 50)/Step; }
        }

        /// <summary>
        ///     Clears chart drawing area
        /// </summary>
        public void ClearChart()
        {
            _isNeedClear = true;

            Invalidate();
        }

        /// <summary>
        ///     draws new time-price chart
        /// </summary>
        /// <param name="contractName">Contract name</param>
        /// <param name="bars">Bars</param>
        public void DrawChart(string contractName, Bar[] bars)
        {
            Invalidate();

            _caption = contractName;
            _bars = bars;
/*
            DateTimeFormatInfo fi = new DateTimeFormatInfo();
            m_timeLabels = new DateTime[4] {new DateTime(2007,5,5,  13, 15, 0),
                new DateTime(2007,5,5,  13, 20, 0),
                new DateTime(2007,5,5,  13, 25, 0),
                new DateTime(2007,5,5,  13, 30, 0) };

            m_priceLabels = new double[4] { 700, 600, 800, 200 };
*/

            Invalidate();
        }

        /// <summary>
        ///     Sets minimum value price from bars
        /// </summary>
        private void SetMinValuePrice()
        {
            _minValPrice = double.MaxValue;
            foreach (Bar bar in _bars)
            {
                if (bar.Low < _minValPrice)
                    _minValPrice = bar.Low;
            }
        }

        /// <summary>
        ///     Sets maximum value price from bars
        /// </summary>
        private void SetMaxValuePrice()
        {
            _maxValPrice = double.MinValue;
            foreach (Bar bar in _bars)
                if (bar.High > _maxValPrice)
                    _maxValPrice = bar.High;
        }

        /// <summary>
        ///     Redraw chart
        /// </summary>
        private void TimePriceChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            if (_isNeedClear)
            {
                gr.Clear(BackColor);
                _isNeedClear = false;
                return;
            }

            if (_bars == null || _bars.Length == 0)
                return;

            //gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            FullFillRealCoordinates(gr);
            DrawCaption(gr);
            DrawAxes(gr);
            DrawLine(gr);
        }

        /// <summary>
        ///     Draws chart caption (name of contract)
        /// </summary>
        /// <param name="gr">Graphics to which to draw</param>
        private void DrawCaption(Graphics gr)
        {
            gr.DrawString(_caption, _labelFont, Brushes.Chocolate, 20, 2);
        }

        /// <summary>
        ///     Draws OHLC bars
        /// </summary>
        /// <param name="gr">Graphics to which to draw</param>
        private void DrawLine(Graphics gr)
        {
            int x = _zeroX;
            int cnt = _bars.Length;
            for (int i = 0; i < cnt; i++)
            {
                gr.DrawLine(Pens.Red, x, _zeroY - GetYFromPrice(_bars[i].Low), x, _zeroY - GetYFromPrice(_bars[i].High));
                gr.DrawLine(Pens.Red, x - LittleStep, _zeroY - GetYFromPrice(_bars[i].Open), x,
                    _zeroY - GetYFromPrice(_bars[i].Open));
                gr.DrawLine(Pens.Red, x, _zeroY - GetYFromPrice(_bars[i].Close), x + LittleStep,
                    _zeroY - GetYFromPrice(_bars[i].Close));
                x += Step;
            }
        }

        /// <summary>
        ///     Converts price to real Y coorinate
        /// </summary>
        /// <param name="price">price to convert</param>
        /// <returns>real Y coordinate</returns>
        private int GetYFromPrice(double price)
        {
            return (int) Math.Round((price - _minValPrice)/_pixPrice);
        }

        /// <summary>
        ///     Draws axes
        /// </summary>
        /// <param name="gr"></param>
        private void DrawAxes(Graphics gr)
        {
            int zeroXaxis = _zeroX - 10; //to shift Y axis little to the left

            //draw axes
            gr.DrawLine(Pens.Black, zeroXaxis, _zeroY, _maxX, _zeroY); // draw X axes
            gr.DrawLine(Pens.Black, zeroXaxis, _zeroY, zeroXaxis, _maxY); // draw Y axes

            int cntY = (Height - IndentX)/Step;
            int cntX = _bars.Length;

            // X axis
            int x = _zeroX;
            for (int i = 0; i < cntX; i++)
            {
                gr.DrawLine(Pens.Black, x, _zeroY - 3, x, _zeroY + 3);

                gr.DrawString(_bars[i].Timestamp.ToLocalTime().ToString(LabelTimeFormat), _labelFont, Brushes.Black,
                    x - 13, _zeroY + 4);

                x += Step;
            }

            // Y axis
            int y = _zeroY;
            for (int i = 0; i < cntY; i++)
            {
                gr.DrawLine(Pens.Black, zeroXaxis - 3, y, zeroXaxis + 3, y);

                double label = _minValPrice + (_zeroY - y)*_pixPrice;
                gr.DrawString(label.ToString(LabelPriceFormat), _labelFont, Brushes.Black, 0, y - 5);

                y -= Step;
            }
        }

        /// <summary>
        ///     Calculating variables, depends on control size
        /// </summary>
        /// <param name="gr"></param>
        private void FullFillRealCoordinates(Graphics gr)
        {
            //gets minimum and maximum prices. Miminum price is to find lowest point on chart's Y(price) axis, and maximum is to find highest
            SetMaxValuePrice();
            SetMinValuePrice();

            //shifts minimum and maximum prices to 10% of it's difference, to 
            double window = _maxValPrice - _minValPrice;
            if (Math.Abs(window) < 1)
                window = 1;
            _minValPrice -= window/10;
            _maxValPrice += window/10;

            _indentY = (int) gr.MeasureString(_maxValPrice.ToString(LabelPriceFormat), _labelFont).Width + 30;
            _zeroY = Height - IndentX;
            _zeroX = _indentY;
            _maxY = IndentX;
            _maxX = Right - 3;

            double chartHeight = _zeroY - _maxY;
            _pixPrice = (_maxValPrice - _minValPrice)/chartHeight;

            if (Math.Abs(_pixPrice) < 1)
                _pixPrice = 1;
        }
    }
}