namespace menu
{
    partial class moyen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStatues = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStatues
            // 
            this.lblStatues.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatues.Location = new System.Drawing.Point(860, 158);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(136, 20);
            this.lblStatues.TabIndex = 4;
            this.lblStatues.Text = "Match or MisMatch";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(834, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Debut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Location = new System.Drawing.Point(872, 227);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(124, 20);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Temps rester :100";
            this.lblTimeLeft.Click += new System.EventHandler(this.lblTimeLeft_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10000;
            this.GameTimer.Tick += new System.EventHandler(this.TamerEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::menu.Properties.Resources.noir;
            this.ClientSize = new System.Drawing.Size(1071, 623);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatues);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStatues;
        private Button button1;
        private Label lblTimeLeft;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
    }
}