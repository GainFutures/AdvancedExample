using System;
using System.Drawing;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Histogram chart. Draws histogram chart
    /// </summary>
    public partial class HistogramChart : UserControl
    {
        private const int Indent = 30;
        private const int BarWidth = 30;
        private const int BarSpaceBetween = 10;
        private readonly Font _labelFont = new Font(FontFamily.GenericSerif, 7);
        private string _caption = string.Empty;
        private HistEntry[] _hist;

        //int m_maxY = int.MinValue;
        private int _maxX = int.MinValue;

        private float _pixelPerVolume = float.NaN;
        private int _zeroX = int.MinValue;
        private int _zeroY = int.MinValue;

        /// <summary>
        ///     Histogram chart constructor
        /// </summary>
        public HistogramChart()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Draws new histogram
        /// </summary>
        /// <param name="contractName">Contract name</param>
        /// <param name="histogram">Histogram data</param>
        public void DrawHistogram(string contractName, HistEntry[] histogram)
        {
            _hist = histogram;
            _caption = contractName;
            Invalidate();
        }

        /// <summary>
        ///     Clears histogram
        /// </summary>
        public void ClearHistogram()
        {
            Graphics gr = Graphics.FromHwnd(Handle);
            gr.Clear(BackColor);
        }

        /// <summary>
        ///     Repaint histogram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistogramChart_Paint(object sender, PaintEventArgs e)
        {
            if (_hist == null || _hist.Length == 0)
                return;

            Graphics gr = e.Graphics;
            FullfillRealCoordinates();
            DrawCaption(gr);
            DrawAxis(gr);
            DrawBars(gr);
        }

        /// <summary>
        ///     Draws histogram bars
        /// </summary>
        /// <param name="gr">Graphics on which to draw</param>
        private void DrawBars(Graphics gr)
        {
            for (int i = 0; i < _hist.Length; i++)
            {
                var barHeight = GetBarHeightFromValue(_hist[i].Volume);
                var x = _zeroX + i*(BarWidth + BarSpaceBetween);
                gr.FillRectangle(Brushes.MediumBlue, x, _zeroY - barHeight, BarWidth, barHeight);

                string label = _hist[i].Volume.ToString();
                SizeF rect = gr.MeasureString(label, _labelFont);

                gr.DrawString(_hist[i].Volume.ToString(), _labelFont, Brushes.Black, x + (BarWidth - rect.Width)/2,
                    _zeroY - barHeight - rect.Height - 2);
            }
        }

        /// <summary>
        ///     Draws caption of histogram (name of contract)
        /// </summary>
        /// <param name="gr">Graphics on which to draw</param>
        private void DrawCaption(Graphics gr)
        {
            gr.DrawString(_caption, _labelFont, Brushes.Chocolate, 20, 2);
        }

        /// <summary>
        ///     Calculates Bar height in chart scale
        /// </summary>
        /// <param name="volume">Bar volume</param>
        /// <returns>Bar height in chart scale</returns>
        private int GetBarHeightFromValue(int volume)
        {
            return (int) Math.Round(volume/_pixelPerVolume);
        }

        /// <summary>
        ///     Draws axis
        /// </summary>
        /// <param name="gr">Graphics on which to draw</param>
        private void DrawAxis(Graphics gr)
        {
            gr.DrawLine(Pens.Black, _zeroX, _zeroY, _maxX - Indent, _zeroY);
            for (int i = 0; i < _hist.Length; i++)
            {
                string label = _hist[i].Price.ToString("#.##");
                SizeF rect = gr.MeasureString(label, _labelFont);

                gr.DrawString(_hist[i].Price.ToString("#.##"), _labelFont, Brushes.Black,
                    _zeroX + i*(BarWidth + BarSpaceBetween) + (BarWidth - rect.Width)/2, _zeroY + 2);
            }
        }

        /// <summary>
        ///     Fullfills fields with real coordinates (in chart's scale) from resized Histogram control
        /// </summary>
        private void FullfillRealCoordinates()
        {
            var scrollOffset = new Size(AutoScrollPosition);

            _zeroY = Height - Indent;
            _zeroX = Indent + scrollOffset.Width;
            _maxX = Indent + (BarSpaceBetween + BarWidth)*_hist.Length + Indent;


            AutoScrollMinSize = new Size(_maxX, 0);

            int maxVolume = GetMaximumVolume();

            float chartHeight = (Height - Indent - 30.0F);
            _pixelPerVolume = maxVolume/chartHeight;
            if (Math.Abs(_pixelPerVolume) < 1)
                _pixelPerVolume = 1;
        }

        /// <summary>
        ///     Gets maximum volume of histohram bars
        /// </summary>
        /// <returns></returns>
        private int GetMaximumVolume()
        {
            int maxVolume = int.MinValue;
            foreach (HistEntry hist in _hist)
                if (hist.Volume > maxVolume)
                    maxVolume = hist.Volume;
            return maxVolume;
        }
    }

    /// <summary>
    ///     Stores histogram bar information
    /// </summary>
    public class HistEntry
    {
        private readonly int _level = int.MinValue;
        private readonly Single _price = Single.NaN;

        private readonly int _volume = int.MinValue;

        /// <summary>
        ///     Creates instance of histogram bar info class
        /// </summary>
        /// <param name="level">Histogram level</param>
        /// <param name="price">Histogram price</param>
        /// <param name="volume">Histogram volume</param>
        public HistEntry(int level, Single price, int volume)
        {
            _level = level;
            _price = price;
            _volume = volume;
        }

        /// <summary>
        ///     Histogram price
        /// </summary>
        public Single Price
        {
            get { return _price; }
        }

        /// <summary>
        ///     Histogram volume
        /// </summary>
        public int Volume
        {
            get { return _volume; }
        }

        /// <summary>
        ///     Histogram level
        /// </summary>
        public int Level
        {
            get { return _level; }
        }
    }
}