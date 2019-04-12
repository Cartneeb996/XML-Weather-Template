namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.sunRise = new System.Windows.Forms.Label();
            this.sunSet = new System.Windows.Forms.Label();
            this.sunRiseOut = new System.Windows.Forms.Label();
            this.sunSetOut = new System.Windows.Forms.Label();
            this.weatherSymbol = new System.Windows.Forms.PictureBox();
            this.windDirection = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.windDirectionOut = new System.Windows.Forms.Label();
            this.windSpeedOut = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(133, 19);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(116, 30);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(117, 248);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(36, 13);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(77, 248);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(117, 220);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(36, 13);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(77, 220);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(7, 103);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(238, 29);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(167, 357);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // currentTemp
            // 
            this.currentTemp.BackColor = System.Drawing.Color.Transparent;
            this.currentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.ForeColor = System.Drawing.Color.White;
            this.currentTemp.Location = new System.Drawing.Point(24, 132);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(206, 74);
            this.currentTemp.TabIndex = 43;
            this.currentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunRise
            // 
            this.sunRise.AutoSize = true;
            this.sunRise.BackColor = System.Drawing.Color.Transparent;
            this.sunRise.ForeColor = System.Drawing.Color.White;
            this.sunRise.Location = new System.Drawing.Point(21, 344);
            this.sunRise.Name = "sunRise";
            this.sunRise.Size = new System.Drawing.Size(50, 13);
            this.sunRise.TabIndex = 44;
            this.sunRise.Text = "Sun Rise";
            // 
            // sunSet
            // 
            this.sunSet.AutoSize = true;
            this.sunSet.BackColor = System.Drawing.Color.Transparent;
            this.sunSet.ForeColor = System.Drawing.Color.White;
            this.sunSet.Location = new System.Drawing.Point(21, 366);
            this.sunSet.Name = "sunSet";
            this.sunSet.Size = new System.Drawing.Size(45, 13);
            this.sunSet.TabIndex = 45;
            this.sunSet.Text = "Sun Set";
            // 
            // sunRiseOut
            // 
            this.sunRiseOut.BackColor = System.Drawing.Color.White;
            this.sunRiseOut.Location = new System.Drawing.Point(77, 344);
            this.sunRiseOut.Name = "sunRiseOut";
            this.sunRiseOut.Size = new System.Drawing.Size(64, 13);
            this.sunRiseOut.TabIndex = 46;
            // 
            // sunSetOut
            // 
            this.sunSetOut.BackColor = System.Drawing.Color.White;
            this.sunSetOut.Location = new System.Drawing.Point(77, 366);
            this.sunSetOut.Name = "sunSetOut";
            this.sunSetOut.Size = new System.Drawing.Size(64, 13);
            this.sunSetOut.TabIndex = 47;
            // 
            // weatherSymbol
            // 
            this.weatherSymbol.BackColor = System.Drawing.Color.Transparent;
            this.weatherSymbol.BackgroundImage = global::XMLWeather.Properties.Resources.Sunny;
            this.weatherSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherSymbol.Location = new System.Drawing.Point(13, 10);
            this.weatherSymbol.Name = "weatherSymbol";
            this.weatherSymbol.Size = new System.Drawing.Size(112, 90);
            this.weatherSymbol.TabIndex = 48;
            this.weatherSymbol.TabStop = false;
            // 
            // windDirection
            // 
            this.windDirection.AutoSize = true;
            this.windDirection.BackColor = System.Drawing.Color.Transparent;
            this.windDirection.ForeColor = System.Drawing.Color.White;
            this.windDirection.Location = new System.Drawing.Point(31, 273);
            this.windDirection.Name = "windDirection";
            this.windDirection.Size = new System.Drawing.Size(72, 13);
            this.windDirection.TabIndex = 49;
            this.windDirection.Text = "wind direction";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.ForeColor = System.Drawing.Color.White;
            this.windSpeed.Location = new System.Drawing.Point(39, 300);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(61, 13);
            this.windSpeed.TabIndex = 50;
            this.windSpeed.Text = "wind speed";
            // 
            // windDirectionOut
            // 
            this.windDirectionOut.BackColor = System.Drawing.Color.Transparent;
            this.windDirectionOut.ForeColor = System.Drawing.Color.White;
            this.windDirectionOut.Location = new System.Drawing.Point(117, 273);
            this.windDirectionOut.Name = "windDirectionOut";
            this.windDirectionOut.Size = new System.Drawing.Size(80, 13);
            this.windDirectionOut.TabIndex = 51;
            // 
            // windSpeedOut
            // 
            this.windSpeedOut.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedOut.ForeColor = System.Drawing.Color.White;
            this.windSpeedOut.Location = new System.Drawing.Point(117, 300);
            this.windSpeedOut.Name = "windSpeedOut";
            this.windSpeedOut.Size = new System.Drawing.Size(80, 13);
            this.windSpeedOut.TabIndex = 52;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(133, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 54);
            this.dateLabel.TabIndex = 53;
            this.dateLabel.Text = "Date";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.background2;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.windSpeedOut);
            this.Controls.Add(this.windDirectionOut);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.windDirection);
            this.Controls.Add(this.weatherSymbol);
            this.Controls.Add(this.sunSetOut);
            this.Controls.Add(this.sunRiseOut);
            this.Controls.Add(this.sunSet);
            this.Controls.Add(this.sunRise);
            this.Controls.Add(this.currentTemp);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.weatherSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.Label sunRise;
        private System.Windows.Forms.Label sunSet;
        private System.Windows.Forms.Label sunRiseOut;
        private System.Windows.Forms.Label sunSetOut;
        private System.Windows.Forms.PictureBox weatherSymbol;
        private System.Windows.Forms.Label windDirection;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label windDirectionOut;
        private System.Windows.Forms.Label windSpeedOut;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Label cityOutput;
    }
}
