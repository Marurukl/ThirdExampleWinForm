namespace ThirdExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxForDay = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // textBoxForDay
            // 
            this.textBoxForDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForDay.Location = new System.Drawing.Point(13, 13);
            this.textBoxForDay.Name = "textBoxForDay";
            this.textBoxForDay.ReadOnly = true;
            this.textBoxForDay.Size = new System.Drawing.Size(143, 22);
            this.textBoxForDay.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(168, 13);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 1;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 323);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.textBoxForDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForDay;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}

