using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VarianceSimulator
{
    internal partial class Main : Form
    {
        private readonly RandomGenerator _random = new();
        private readonly List<double> _values = new() { 0.0 };
        private readonly string _earingsPerRollFormat = "0." + new string('#', 8);

        private double CurrentValue => _values[^1];

        internal Main()
        {
            InitializeComponent();
            _chart.SetDoubleBuffered();
        }

        private void OnChartPaint(object sender, PaintEventArgs e)
        {
            double highestValue = _values.Max();
            double lowestValue = _values.Min();
            double earningsPerRoll = CurrentValue / _values.Count;

            _labelMaximumValue.Text = $"{highestValue:0.##} $";
            _labelMinimumValue.Text = $"{lowestValue:0.##} $";
            _labelEarningsPerRollValue.Text = $"{earningsPerRoll.ToString(_earingsPerRollFormat)} $";

            Graphics g = e.Graphics;
            Pen linePen = new(Color.LightGray, 1);
            Pen middleLinePen = new(Color.Gray, 1);
            Pen chartLinePen = new(Color.Black, 1);

            int chartYMiddle = Round(_chart.Height / 2.0);

            double peak;

            if (highestValue > Math.Abs(lowestValue))
            {
                peak = highestValue;
            }
            else
            {
                peak = Math.Abs(lowestValue);
            }

            double YUnitLength = _chart.Height / peak / 2.0;
            double XUnitLength = (double)_chart.Width / (_values.Count - 1);

            int xPart = Round(_chart.Width / 10.0);
            int yPart = Round(_chart.Height / 10.0);

            for (int i = 1; i < 10; i++)
            {
                g.DrawLine(linePen, xPart * i, 0, xPart * i, _chart.Height);
                g.DrawLine(linePen, 0, yPart * i, _chart.Width, yPart * i);
            }

            for (int i = 1; i <= 10; i++)
            {
                int valueX = ((int)((_values.Count - 1) / 10.0 * i));
                g.DrawString(valueX.ToString(), _chart.Font, Brushes.Black, _chart.Width / 10 * i - g.MeasureString(valueX.ToString(), _chart.Font).Width, _chart.Height - _chart.Font.Size * 2);
            }

            for (int i = 0; i < 11; i++)
            {
                int valueY = (int)(peak - ((peak / 5.0 * i)));
                string displayed = valueY + " $";

                int offSet = Round(g.MeasureString(displayed, _chart.Font).Height / 10.0 * i);
                g.DrawString(displayed, _chart.Font, Brushes.Black, _chart.Font.Size / 2, (_chart.Height / 10 * i) - offSet);
            }

            g.DrawLine(middleLinePen, 0, chartYMiddle, _chart.Width, chartYMiddle);

            for (int i = 0; i < _values.Count - 1; i++)
            {
                g.DrawLine(chartLinePen, Round(i * XUnitLength), -Round(_values[i] * YUnitLength) + chartYMiddle, Round((i + 1) * XUnitLength), -Round(_values[i + 1] * YUnitLength) + chartYMiddle);
            }
        }

        private void OnChartResize(object sender, EventArgs e)
        {
            _chart.Invalidate();
        }

        private static int Round(double number)
        {
            return (int)Math.Round(number);
        }



        private void Roll(int possibilities, double edge, double bet)
        {
            double randomNumber = _random.Next();

            double edgeRatio = 1.0 + (edge / 100.0);
            double chance = edgeRatio / possibilities;

            bool isHit = randomNumber < chance;

            double winning = isHit ? possibilities * bet : 0;
            double newValue = CurrentValue + winning - bet;

            _values.Add(newValue);
        }

        private void OnButtonRollClick(object sender, EventArgs e)
        {
            if (double.TryParse(_textBoxBetSize.Text, out double betSize) &&
                int.TryParse(_textBoxRollAmount.Text, out int iterations) &&
                int.TryParse(_textBoxPossibilies.Text, out int possibilities) &&
                double.TryParse(_textBoxEdge.Text, out double edge))
            {
                for (int i = 0; i < iterations; i++)
                {
                    Roll(possibilities, edge, betSize);
                }

                _chart.Invalidate();
            }
        }

        private void OnButtonResetClick(object sender, EventArgs e)
        {
            _values.Clear();
            _values.Add(0.0);
            _chart.Invalidate();
        }
    }
}
