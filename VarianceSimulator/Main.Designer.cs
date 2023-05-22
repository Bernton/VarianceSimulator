namespace VarianceSimulator
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            _buttonRoll = new System.Windows.Forms.Button();
            _textBoxRollAmount = new System.Windows.Forms.TextBox();
            _labelPossibilies = new System.Windows.Forms.Label();
            _textBoxPossibilies = new System.Windows.Forms.TextBox();
            _labelEdge = new System.Windows.Forms.Label();
            _textBoxEdge = new System.Windows.Forms.TextBox();
            _labelEarningsPerRollValue = new System.Windows.Forms.Label();
            _chart = new System.Windows.Forms.Panel();
            _labelEarningsPerRoll = new System.Windows.Forms.Label();
            _labelRollAmount = new System.Windows.Forms.Label();
            _labelBetSize = new System.Windows.Forms.Label();
            _textBoxBetSize = new System.Windows.Forms.TextBox();
            _buttonReset = new System.Windows.Forms.Button();
            _labelMinimum = new System.Windows.Forms.Label();
            _labelMinimumValue = new System.Windows.Forms.Label();
            _labelMaximum = new System.Windows.Forms.Label();
            _labelMaximumValue = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // _buttonRoll
            // 
            _buttonRoll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _buttonRoll.Location = new System.Drawing.Point(867, 14);
            _buttonRoll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _buttonRoll.Name = "_buttonRoll";
            _buttonRoll.Size = new System.Drawing.Size(120, 27);
            _buttonRoll.TabIndex = 0;
            _buttonRoll.Text = "Roll";
            _buttonRoll.UseVisualStyleBackColor = true;
            _buttonRoll.Click += OnButtonRollClick;
            // 
            // _textBoxRollAmount
            // 
            _textBoxRollAmount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _textBoxRollAmount.Location = new System.Drawing.Point(871, 157);
            _textBoxRollAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _textBoxRollAmount.Name = "_textBoxRollAmount";
            _textBoxRollAmount.Size = new System.Drawing.Size(114, 23);
            _textBoxRollAmount.TabIndex = 3;
            _textBoxRollAmount.Text = "1";
            _textBoxRollAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _labelPossibilies
            // 
            _labelPossibilies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _labelPossibilies.AutoSize = true;
            _labelPossibilies.Location = new System.Drawing.Point(869, 197);
            _labelPossibilies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelPossibilies.Name = "_labelPossibilies";
            _labelPossibilies.Size = new System.Drawing.Size(68, 15);
            _labelPossibilies.TabIndex = 5;
            _labelPossibilies.Text = "Possibilities";
            // 
            // _textBoxPossibilies
            // 
            _textBoxPossibilies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _textBoxPossibilies.Location = new System.Drawing.Point(869, 215);
            _textBoxPossibilies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _textBoxPossibilies.Name = "_textBoxPossibilies";
            _textBoxPossibilies.Size = new System.Drawing.Size(116, 23);
            _textBoxPossibilies.TabIndex = 4;
            _textBoxPossibilies.Text = "2";
            _textBoxPossibilies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _labelEdge
            // 
            _labelEdge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _labelEdge.AutoSize = true;
            _labelEdge.Location = new System.Drawing.Point(869, 253);
            _labelEdge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelEdge.Name = "_labelEdge";
            _labelEdge.Size = new System.Drawing.Size(54, 15);
            _labelEdge.TabIndex = 7;
            _labelEdge.Text = "Edge (%)";
            // 
            // _textBoxEdge
            // 
            _textBoxEdge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _textBoxEdge.Location = new System.Drawing.Point(869, 271);
            _textBoxEdge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _textBoxEdge.Name = "_textBoxEdge";
            _textBoxEdge.Size = new System.Drawing.Size(116, 23);
            _textBoxEdge.TabIndex = 5;
            _textBoxEdge.Text = "0";
            _textBoxEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _labelEarningsPerRollValue
            // 
            _labelEarningsPerRollValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _labelEarningsPerRollValue.Location = new System.Drawing.Point(871, 455);
            _labelEarningsPerRollValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelEarningsPerRollValue.Name = "_labelEarningsPerRollValue";
            _labelEarningsPerRollValue.Size = new System.Drawing.Size(114, 21);
            _labelEarningsPerRollValue.TabIndex = 9;
            _labelEarningsPerRollValue.Text = "0 $";
            _labelEarningsPerRollValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _chart
            // 
            _chart.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _chart.BackColor = System.Drawing.Color.White;
            _chart.Location = new System.Drawing.Point(14, 14);
            _chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _chart.Name = "_chart";
            _chart.Size = new System.Drawing.Size(845, 462);
            _chart.TabIndex = 0;
            _chart.Paint += OnChartPaint;
            _chart.Resize += OnChartResize;
            // 
            // _labelEarningsPerRoll
            // 
            _labelEarningsPerRoll.AutoSize = true;
            _labelEarningsPerRoll.Location = new System.Drawing.Point(893, 440);
            _labelEarningsPerRoll.Name = "_labelEarningsPerRoll";
            _labelEarningsPerRoll.Size = new System.Drawing.Size(90, 15);
            _labelEarningsPerRoll.TabIndex = 10;
            _labelEarningsPerRoll.Text = "Average per roll";
            // 
            // _labelRollAmount
            // 
            _labelRollAmount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _labelRollAmount.AutoSize = true;
            _labelRollAmount.Location = new System.Drawing.Point(871, 139);
            _labelRollAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelRollAmount.Name = "_labelRollAmount";
            _labelRollAmount.Size = new System.Drawing.Size(72, 15);
            _labelRollAmount.TabIndex = 11;
            _labelRollAmount.Text = "Roll amount";
            // 
            // _labelBetSize
            // 
            _labelBetSize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _labelBetSize.AutoSize = true;
            _labelBetSize.Location = new System.Drawing.Point(871, 86);
            _labelBetSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelBetSize.Name = "_labelBetSize";
            _labelBetSize.Size = new System.Drawing.Size(68, 15);
            _labelBetSize.TabIndex = 13;
            _labelBetSize.Text = "Bet size in $";
            // 
            // _textBoxBetSize
            // 
            _textBoxBetSize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _textBoxBetSize.Location = new System.Drawing.Point(871, 104);
            _textBoxBetSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _textBoxBetSize.Name = "_textBoxBetSize";
            _textBoxBetSize.Size = new System.Drawing.Size(114, 23);
            _textBoxBetSize.TabIndex = 2;
            _textBoxBetSize.Text = "1";
            _textBoxBetSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _buttonReset
            // 
            _buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _buttonReset.Location = new System.Drawing.Point(867, 47);
            _buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _buttonReset.Name = "_buttonReset";
            _buttonReset.Size = new System.Drawing.Size(120, 27);
            _buttonReset.TabIndex = 1;
            _buttonReset.Text = "Reset";
            _buttonReset.UseVisualStyleBackColor = true;
            _buttonReset.Click += OnButtonResetClick;
            // 
            // _labelMinimum
            // 
            _labelMinimum.AutoSize = true;
            _labelMinimum.Location = new System.Drawing.Point(893, 401);
            _labelMinimum.Name = "_labelMinimum";
            _labelMinimum.Size = new System.Drawing.Size(75, 15);
            _labelMinimum.TabIndex = 16;
            _labelMinimum.Text = "Lowest value";
            // 
            // _labelMinimumValue
            // 
            _labelMinimumValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _labelMinimumValue.Location = new System.Drawing.Point(871, 416);
            _labelMinimumValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelMinimumValue.Name = "_labelMinimumValue";
            _labelMinimumValue.Size = new System.Drawing.Size(114, 21);
            _labelMinimumValue.TabIndex = 15;
            _labelMinimumValue.Text = "0 $";
            _labelMinimumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelMaximum
            // 
            _labelMaximum.AutoSize = true;
            _labelMaximum.Location = new System.Drawing.Point(893, 362);
            _labelMaximum.Name = "_labelMaximum";
            _labelMaximum.Size = new System.Drawing.Size(79, 15);
            _labelMaximum.TabIndex = 18;
            _labelMaximum.Text = "Highest value";
            // 
            // _labelMaximumValue
            // 
            _labelMaximumValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _labelMaximumValue.Location = new System.Drawing.Point(871, 377);
            _labelMaximumValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _labelMaximumValue.Name = "_labelMaximumValue";
            _labelMaximumValue.Size = new System.Drawing.Size(114, 21);
            _labelMaximumValue.TabIndex = 17;
            _labelMaximumValue.Text = "0 $";
            _labelMaximumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 493);
            Controls.Add(_labelMaximum);
            Controls.Add(_labelMaximumValue);
            Controls.Add(_labelMinimum);
            Controls.Add(_labelMinimumValue);
            Controls.Add(_buttonReset);
            Controls.Add(_labelBetSize);
            Controls.Add(_textBoxBetSize);
            Controls.Add(_labelRollAmount);
            Controls.Add(_labelEarningsPerRoll);
            Controls.Add(_labelEarningsPerRollValue);
            Controls.Add(_textBoxEdge);
            Controls.Add(_labelEdge);
            Controls.Add(_textBoxPossibilies);
            Controls.Add(_labelPossibilies);
            Controls.Add(_textBoxRollAmount);
            Controls.Add(_buttonRoll);
            Controls.Add(_chart);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(347, 225);
            Name = "Main";
            Text = "Variance Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel _chart;
        private System.Windows.Forms.Button _buttonRoll;
        private System.Windows.Forms.TextBox _textBoxRollAmount;
        private System.Windows.Forms.Label _labelPossibilies;
        private System.Windows.Forms.TextBox _textBoxPossibilies;
        private System.Windows.Forms.Label _labelEdge;
        private System.Windows.Forms.TextBox _textBoxEdge;
        private System.Windows.Forms.Label _labelEarningsPerRollValue;
        private System.Windows.Forms.Label _labelEarningsPerRoll;
        private System.Windows.Forms.Label _labelRollAmount;
        private System.Windows.Forms.Label _labelBetSize;
        private System.Windows.Forms.TextBox _textBoxBetSize;
        private System.Windows.Forms.Button _buttonReset;
        private System.Windows.Forms.Label _labelMinimum;
        private System.Windows.Forms.Label _labelMinimumValue;
        private System.Windows.Forms.Label _labelMaximum;
        private System.Windows.Forms.Label _labelMaximumValue;
    }
}

