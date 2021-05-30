
namespace Geohasher
{
    partial class UserInterface
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
            this.uxYear = new System.Windows.Forms.TextBox();
            this.uxMonth = new System.Windows.Forms.TextBox();
            this.uxDay = new System.Windows.Forms.TextBox();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxDayLabel = new System.Windows.Forms.Label();
            this.uxDowOpening = new System.Windows.Forms.TextBox();
            this.uxDowLabel = new System.Windows.Forms.Label();
            this.uxLatitudeLabel = new System.Windows.Forms.Label();
            this.uxLatitude = new System.Windows.Forms.TextBox();
            this.uxLongitudeLabel = new System.Windows.Forms.Label();
            this.uxLongitude = new System.Windows.Forms.TextBox();
            this.uxGeohash = new System.Windows.Forms.Button();
            this.uxOutputLatitudeLabel = new System.Windows.Forms.Label();
            this.uxOutputLatitude = new System.Windows.Forms.TextBox();
            this.uxOutputLongitudeLabel = new System.Windows.Forms.Label();
            this.uxOutputLongitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxYear
            // 
            this.uxYear.Location = new System.Drawing.Point(39, 43);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(74, 27);
            this.uxYear.TabIndex = 0;
            // 
            // uxMonth
            // 
            this.uxMonth.Location = new System.Drawing.Point(132, 43);
            this.uxMonth.Name = "uxMonth";
            this.uxMonth.Size = new System.Drawing.Size(51, 27);
            this.uxMonth.TabIndex = 1;
            // 
            // uxDay
            // 
            this.uxDay.Location = new System.Drawing.Point(201, 43);
            this.uxDay.Name = "uxDay";
            this.uxDay.Size = new System.Drawing.Size(56, 27);
            this.uxDay.TabIndex = 2;
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Location = new System.Drawing.Point(62, 20);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(37, 20);
            this.uxYearLabel.TabIndex = 3;
            this.uxYearLabel.Text = "Year";
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Location = new System.Drawing.Point(132, 20);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(52, 20);
            this.uxMonthLabel.TabIndex = 4;
            this.uxMonthLabel.Text = "Month";
            // 
            // uxDayLabel
            // 
            this.uxDayLabel.AutoSize = true;
            this.uxDayLabel.Location = new System.Drawing.Point(210, 20);
            this.uxDayLabel.Name = "uxDayLabel";
            this.uxDayLabel.Size = new System.Drawing.Size(35, 20);
            this.uxDayLabel.TabIndex = 5;
            this.uxDayLabel.Text = "Day";
            // 
            // uxDowOpening
            // 
            this.uxDowOpening.Location = new System.Drawing.Point(146, 91);
            this.uxDowOpening.Name = "uxDowOpening";
            this.uxDowOpening.Size = new System.Drawing.Size(114, 27);
            this.uxDowOpening.TabIndex = 6;
            // 
            // uxDowLabel
            // 
            this.uxDowLabel.AutoSize = true;
            this.uxDowLabel.Location = new System.Drawing.Point(39, 94);
            this.uxDowLabel.Name = "uxDowLabel";
            this.uxDowLabel.Size = new System.Drawing.Size(101, 20);
            this.uxDowLabel.TabIndex = 7;
            this.uxDowLabel.Text = "Dow Opening";
            // 
            // uxLatitudeLabel
            // 
            this.uxLatitudeLabel.AutoSize = true;
            this.uxLatitudeLabel.Location = new System.Drawing.Point(70, 139);
            this.uxLatitudeLabel.Name = "uxLatitudeLabel";
            this.uxLatitudeLabel.Size = new System.Drawing.Size(122, 20);
            this.uxLatitudeLabel.TabIndex = 9;
            this.uxLatitudeLabel.Text = "Degrees Latitude";
            // 
            // uxLatitude
            // 
            this.uxLatitude.Location = new System.Drawing.Point(201, 136);
            this.uxLatitude.Name = "uxLatitude";
            this.uxLatitude.Size = new System.Drawing.Size(59, 27);
            this.uxLatitude.TabIndex = 8;
            // 
            // uxLongitudeLabel
            // 
            this.uxLongitudeLabel.AutoSize = true;
            this.uxLongitudeLabel.Location = new System.Drawing.Point(57, 180);
            this.uxLongitudeLabel.Name = "uxLongitudeLabel";
            this.uxLongitudeLabel.Size = new System.Drawing.Size(135, 20);
            this.uxLongitudeLabel.TabIndex = 11;
            this.uxLongitudeLabel.Text = "Degrees Longitude";
            // 
            // uxLongitude
            // 
            this.uxLongitude.Location = new System.Drawing.Point(201, 177);
            this.uxLongitude.Name = "uxLongitude";
            this.uxLongitude.Size = new System.Drawing.Size(59, 27);
            this.uxLongitude.TabIndex = 10;
            // 
            // uxGeohash
            // 
            this.uxGeohash.Location = new System.Drawing.Point(39, 212);
            this.uxGeohash.Name = "uxGeohash";
            this.uxGeohash.Size = new System.Drawing.Size(221, 29);
            this.uxGeohash.TabIndex = 12;
            this.uxGeohash.Text = "Calculate Location";
            this.uxGeohash.UseVisualStyleBackColor = true;
            this.uxGeohash.Click += new System.EventHandler(this.uxGeohash_Click);
            // 
            // uxOutputLatitudeLabel
            // 
            this.uxOutputLatitudeLabel.AutoSize = true;
            this.uxOutputLatitudeLabel.Location = new System.Drawing.Point(39, 260);
            this.uxOutputLatitudeLabel.Name = "uxOutputLatitudeLabel";
            this.uxOutputLatitudeLabel.Size = new System.Drawing.Size(63, 20);
            this.uxOutputLatitudeLabel.TabIndex = 14;
            this.uxOutputLatitudeLabel.Text = "Latitude";
            // 
            // uxOutputLatitude
            // 
            this.uxOutputLatitude.Location = new System.Drawing.Point(108, 257);
            this.uxOutputLatitude.Name = "uxOutputLatitude";
            this.uxOutputLatitude.Size = new System.Drawing.Size(152, 27);
            this.uxOutputLatitude.TabIndex = 13;
            // 
            // uxOutputLongitudeLabel
            // 
            this.uxOutputLongitudeLabel.AutoSize = true;
            this.uxOutputLongitudeLabel.Location = new System.Drawing.Point(26, 293);
            this.uxOutputLongitudeLabel.Name = "uxOutputLongitudeLabel";
            this.uxOutputLongitudeLabel.Size = new System.Drawing.Size(76, 20);
            this.uxOutputLongitudeLabel.TabIndex = 16;
            this.uxOutputLongitudeLabel.Text = "Longitude";
            // 
            // uxOutputLongitude
            // 
            this.uxOutputLongitude.Location = new System.Drawing.Point(108, 290);
            this.uxOutputLongitude.Name = "uxOutputLongitude";
            this.uxOutputLongitude.Size = new System.Drawing.Size(152, 27);
            this.uxOutputLongitude.TabIndex = 15;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 350);
            this.Controls.Add(this.uxOutputLongitudeLabel);
            this.Controls.Add(this.uxOutputLongitude);
            this.Controls.Add(this.uxOutputLatitudeLabel);
            this.Controls.Add(this.uxOutputLatitude);
            this.Controls.Add(this.uxGeohash);
            this.Controls.Add(this.uxLongitudeLabel);
            this.Controls.Add(this.uxLongitude);
            this.Controls.Add(this.uxLatitudeLabel);
            this.Controls.Add(this.uxLatitude);
            this.Controls.Add(this.uxDowLabel);
            this.Controls.Add(this.uxDowOpening);
            this.Controls.Add(this.uxDayLabel);
            this.Controls.Add(this.uxMonthLabel);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.uxDay);
            this.Controls.Add(this.uxMonth);
            this.Controls.Add(this.uxYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uxForm";
            this.Text = "Geohasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxYear;
        private System.Windows.Forms.TextBox uxMonth;
        private System.Windows.Forms.TextBox uxDay;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxDayLabel;
        private System.Windows.Forms.TextBox uxDowOpening;
        private System.Windows.Forms.Label uxDowLabel;
        private System.Windows.Forms.Label uxLatitudeLabel;
        private System.Windows.Forms.TextBox uxLatitude;
        private System.Windows.Forms.Label uxLongitudeLabel;
        private System.Windows.Forms.TextBox uxLongitude;
        private System.Windows.Forms.Button uxGeohash;
        private System.Windows.Forms.Label uxOutputLatitudeLabel;
        private System.Windows.Forms.TextBox uxOutputLatitude;
        private System.Windows.Forms.Label uxOutputLongitudeLabel;
        private System.Windows.Forms.TextBox uxOutputLongitude;
    }
}

