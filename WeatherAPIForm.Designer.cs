namespace WinFormsApp1
{
    partial class WeatherAPIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetWeather = new Button();
            btnGetWeatherJson = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCity = new TextBox();
            txtLatitude = new TextBox();
            txtLongitude = new TextBox();
            txtTemp = new TextBox();
            txtLow = new TextBox();
            txtHigh = new TextBox();
            txtFeelsLike = new TextBox();
            txtWind = new TextBox();
            textBox10 = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnGetWeather
            // 
            btnGetWeather.BackColor = SystemColors.ActiveCaption;
            btnGetWeather.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGetWeather.Location = new Point(112, 31);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(474, 65);
            btnGetWeather.TabIndex = 0;
            btnGetWeather.Text = "Get Weather (XML)";
            btnGetWeather.UseVisualStyleBackColor = false;
            btnGetWeather.Click += button1_Click;
            // 
            // btnGetWeatherJson
            // 
            btnGetWeatherJson.BackColor = SystemColors.ActiveCaption;
            btnGetWeatherJson.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGetWeatherJson.Location = new Point(112, 144);
            btnGetWeatherJson.Name = "btnGetWeatherJson";
            btnGetWeatherJson.Size = new Size(474, 63);
            btnGetWeatherJson.TabIndex = 1;
            btnGetWeatherJson.Text = "Get Weather (JSON)";
            btnGetWeatherJson.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 256);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 3;
            label1.Text = "Enter the zip code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 315);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 384);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Latitude";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 458);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 6;
            label4.Text = "Temperature";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 522);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Wind";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(370, 384);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Longitude";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(240, 458);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 9;
            label7.Text = "Low";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(360, 458);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 10;
            label8.Text = "High";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(468, 458);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 11;
            label9.Text = "Feels Like";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(336, 522);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 12;
            label10.Text = "Clouds";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.WindowFrame;
            txtCity.Enabled = false;
            txtCity.Location = new Point(115, 343);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(453, 23);
            txtCity.TabIndex = 13;
            // 
            // txtLatitude
            // 
            txtLatitude.BackColor = SystemColors.WindowFrame;
            txtLatitude.Enabled = false;
            txtLatitude.Location = new Point(115, 413);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(225, 23);
            txtLatitude.TabIndex = 14;
            // 
            // txtLongitude
            // 
            txtLongitude.BackColor = SystemColors.WindowFrame;
            txtLongitude.Enabled = false;
            txtLongitude.Location = new Point(370, 413);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(198, 23);
            txtLongitude.TabIndex = 15;
            // 
            // txtTemp
            // 
            txtTemp.BackColor = SystemColors.WindowFrame;
            txtTemp.Enabled = false;
            txtTemp.Location = new Point(115, 476);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(100, 23);
            txtTemp.TabIndex = 16;
            // 
            // txtLow
            // 
            txtLow.BackColor = SystemColors.WindowFrame;
            txtLow.Enabled = false;
            txtLow.Location = new Point(240, 476);
            txtLow.Name = "txtLow";
            txtLow.Size = new Size(100, 23);
            txtLow.TabIndex = 17;
            // 
            // txtHigh
            // 
            txtHigh.BackColor = SystemColors.WindowFrame;
            txtHigh.Enabled = false;
            txtHigh.Location = new Point(360, 476);
            txtHigh.Name = "txtHigh";
            txtHigh.Size = new Size(100, 23);
            txtHigh.TabIndex = 18;
            // 
            // txtFeelsLike
            // 
            txtFeelsLike.BackColor = SystemColors.WindowFrame;
            txtFeelsLike.Enabled = false;
            txtFeelsLike.Location = new Point(468, 476);
            txtFeelsLike.Name = "txtFeelsLike";
            txtFeelsLike.Size = new Size(100, 23);
            txtFeelsLike.TabIndex = 19;
            // 
            // txtWind
            // 
            txtWind.BackColor = SystemColors.WindowFrame;
            txtWind.Enabled = false;
            txtWind.Location = new Point(115, 540);
            txtWind.Name = "txtWind";
            txtWind.Size = new Size(200, 23);
            txtWind.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.WindowFrame;
            textBox10.Enabled = false;
            textBox10.Location = new Point(336, 540);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(232, 23);
            textBox10.TabIndex = 21;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(580, 593);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 52);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // WeatherAPIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 742);
            Controls.Add(btnClose);
            Controls.Add(textBox10);
            Controls.Add(txtWind);
            Controls.Add(txtFeelsLike);
            Controls.Add(txtHigh);
            Controls.Add(txtLow);
            Controls.Add(txtTemp);
            Controls.Add(txtLongitude);
            Controls.Add(txtLatitude);
            Controls.Add(txtCity);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnGetWeatherJson);
            Controls.Add(btnGetWeather);
            Name = "WeatherAPIForm";
            Text = "S";
            Load += WeatherAPIForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetWeather;
        private Button btnGetWeatherJson;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCity;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private TextBox txtTemp;
        private TextBox txtLow;
        private TextBox txtHigh;
        private TextBox txtFeelsLike;
        private TextBox txtWind;
        private TextBox textBox10;
        private Button btnClose;
    }
}
