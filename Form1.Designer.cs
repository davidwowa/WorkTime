namespace WorkTime
{
    partial class WorkTimeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTimeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.screenPause = new LedControls.LedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.screentStartTime = new LedControls.LedPanel();
            this.screentWorkTime = new LedControls.LedPanel();
            this.segmentScreen = new LedControls.LedPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.pcWorkTime = new System.Windows.Forms.Label();
            this.onTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.workTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.screenPause);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.screentStartTime);
            this.panel1.Controls.Add(this.screentWorkTime);
            this.panel1.Controls.Add(this.segmentScreen);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelStartTime);
            this.panel1.Controls.Add(this.pcWorkTime);
            this.panel1.Controls.Add(this.onTimeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 323);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(150, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pause:";
            // 
            // screenPause
            // 
            this.screenPause.BackColor = System.Drawing.Color.Black;
            this.screenPause.DisenabledColor = System.Drawing.Color.Silver;
            this.screenPause.DisplayHour = 0;
            this.screenPause.DisplayMin = 0;
            this.screenPause.DisplaySec = 0;
            this.screenPause.DisplayTime = new System.DateTime(2012, 11, 9, 0, 0, 0, 0);
            this.screenPause.EnabledColor = System.Drawing.Color.White;
            this.screenPause.ForeColor = System.Drawing.Color.Transparent;
            this.screenPause.LedLayout = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Silver};
            this.screenPause.Location = new System.Drawing.Point(260, 186);
            this.screenPause.Name = "screenPause";
            this.screenPause.ShowDisenabledSegments = false;
            this.screenPause.Size = new System.Drawing.Size(246, 52);
            this.screenPause.TabIndex = 12;
            this.screenPause.Text = "ledPanel2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(150, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktuell: ";
            // 
            // screentStartTime
            // 
            this.screentStartTime.BackColor = System.Drawing.Color.Black;
            this.screentStartTime.DisenabledColor = System.Drawing.Color.LightGray;
            this.screentStartTime.DisplayHour = 0;
            this.screentStartTime.DisplayMin = 0;
            this.screentStartTime.DisplaySec = 0;
            this.screentStartTime.DisplayTime = new System.DateTime(2012, 11, 9, 0, 0, 0, 0);
            this.screentStartTime.EnabledColor = System.Drawing.Color.White;
            this.screentStartTime.ForeColor = System.Drawing.Color.Transparent;
            this.screentStartTime.LedLayout = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray};
            this.screentStartTime.Location = new System.Drawing.Point(263, 12);
            this.screentStartTime.Name = "screentStartTime";
            this.screentStartTime.ShowDisenabledSegments = false;
            this.screentStartTime.Size = new System.Drawing.Size(246, 52);
            this.screentStartTime.TabIndex = 10;
            this.screentStartTime.Text = "ledPanel2";
            // 
            // screentWorkTime
            // 
            this.screentWorkTime.BackColor = System.Drawing.Color.Black;
            this.screentWorkTime.DisenabledColor = System.Drawing.Color.Silver;
            this.screentWorkTime.DisplayHour = 0;
            this.screentWorkTime.DisplayMin = 0;
            this.screentWorkTime.DisplaySec = 0;
            this.screentWorkTime.DisplayTime = new System.DateTime(2012, 11, 9, 0, 0, 0, 0);
            this.screentWorkTime.EnabledColor = System.Drawing.Color.White;
            this.screentWorkTime.ForeColor = System.Drawing.Color.Transparent;
            this.screentWorkTime.LedLayout = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Silver};
            this.screentWorkTime.Location = new System.Drawing.Point(260, 70);
            this.screentWorkTime.Name = "screentWorkTime";
            this.screentWorkTime.ShowDisenabledSegments = false;
            this.screentWorkTime.Size = new System.Drawing.Size(246, 52);
            this.screentWorkTime.TabIndex = 9;
            this.screentWorkTime.Text = "ledPanel2";
            // 
            // segmentScreen
            // 
            this.segmentScreen.BackColor = System.Drawing.Color.Black;
            this.segmentScreen.DisenabledColor = System.Drawing.Color.Silver;
            this.segmentScreen.DisplayHour = 0;
            this.segmentScreen.DisplayMin = 0;
            this.segmentScreen.DisplaySec = 0;
            this.segmentScreen.DisplayTime = new System.DateTime(2012, 11, 9, 0, 0, 0, 0);
            this.segmentScreen.EnabledColor = System.Drawing.Color.White;
            this.segmentScreen.ForeColor = System.Drawing.Color.Transparent;
            this.segmentScreen.LedLayout = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Silver};
            this.segmentScreen.Location = new System.Drawing.Point(260, 128);
            this.segmentScreen.Name = "segmentScreen";
            this.segmentScreen.ShowDisenabledSegments = false;
            this.segmentScreen.Size = new System.Drawing.Size(246, 52);
            this.segmentScreen.TabIndex = 8;
            this.segmentScreen.Text = "ledPanel2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Beenden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.BackColor = System.Drawing.Color.Black;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.Transparent;
            this.labelStartTime.Location = new System.Drawing.Point(90, 241);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(309, 29);
            this.labelStartTime.TabIndex = 2;
            this.labelStartTime.Text = "Donnerstag, 08 November";
            // 
            // pcWorkTime
            // 
            this.pcWorkTime.AutoSize = true;
            this.pcWorkTime.BackColor = System.Drawing.Color.Black;
            this.pcWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcWorkTime.ForeColor = System.Drawing.Color.Transparent;
            this.pcWorkTime.Location = new System.Drawing.Point(29, 83);
            this.pcWorkTime.Name = "pcWorkTime";
            this.pcWorkTime.Size = new System.Drawing.Size(225, 29);
            this.pcWorkTime.TabIndex = 1;
            this.pcWorkTime.Text = "Rechnerarbeitzeit: ";
            // 
            // onTimeLabel
            // 
            this.onTimeLabel.AutoSize = true;
            this.onTimeLabel.BackColor = System.Drawing.Color.Black;
            this.onTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onTimeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.onTimeLabel.Location = new System.Drawing.Point(90, 24);
            this.onTimeLabel.Name = "onTimeLabel";
            this.onTimeLabel.Size = new System.Drawing.Size(164, 29);
            this.onTimeLabel.TabIndex = 0;
            this.onTimeLabel.Text = "Einschaltzeit:";
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // workTimeTimer
            // 
            this.workTimeTimer.Tick += new System.EventHandler(this.workTimeTimer_Tick);
            // 
            // WorkTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "WorkTimeForm";
            this.Text = "WorkTime";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label pcWorkTime;
        private System.Windows.Forms.Label onTimeLabel;
        private System.Windows.Forms.Button button1;
        private LedControls.LedPanel segmentScreen;
        private System.Windows.Forms.Timer currentTimeTimer;
        private LedControls.LedPanel screentWorkTime;
        private System.Windows.Forms.Timer workTimeTimer;
        private System.Windows.Forms.Label label2;
        private LedControls.LedPanel screenPause;
        private System.Windows.Forms.Label label1;
        private LedControls.LedPanel screentStartTime;
    }
}

