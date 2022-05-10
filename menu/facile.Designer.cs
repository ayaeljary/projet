namespace menu
{
    partial class facile
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatues = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10000;
            this.GameTimer.Tick += new System.EventHandler(this.TamerEvent);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(789, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Debut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // lblStatues
            // 
            this.lblStatues.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatues.Location = new System.Drawing.Point(804, 117);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(136, 20);
            this.lblStatues.TabIndex = 3;
            this.lblStatues.Text = "Match or MisMatch";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Location = new System.Drawing.Point(804, 171);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(124, 20);
            this.lblTimeLeft.TabIndex = 4;
            this.lblTimeLeft.Text = "Temps rester :100";
            this.lblTimeLeft.Click += new System.EventHandler(this.lblTimeLeft_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::menu.Properties.Resources.noir;
            this.ClientSize = new System.Drawing.Size(1013, 509);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblStatues);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private Button button1;
        private Label lblStatues;
        private Label lblTimeLeft;
    }
}