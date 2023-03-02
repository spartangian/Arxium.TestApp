namespace Arxium.TestApp
{
    partial class frmMain
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
            this.lblIncrementer = new System.Windows.Forms.Button();
            this.lblDrug1 = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblDrug2 = new System.Windows.Forms.Label();
            this.lblDrug3 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIncrementer
            // 
            this.lblIncrementer.Location = new System.Drawing.Point(202, 244);
            this.lblIncrementer.Name = "lblIncrementer";
            this.lblIncrementer.Size = new System.Drawing.Size(75, 23);
            this.lblIncrementer.TabIndex = 0;
            this.lblIncrementer.Text = "Increment";
            this.lblIncrementer.UseVisualStyleBackColor = true;
            this.lblIncrementer.Click += new System.EventHandler(this.lblIncrementer_Click);
            // 
            // lblDrug1
            // 
            this.lblDrug1.AutoSize = true;
            this.lblDrug1.Location = new System.Drawing.Point(226, 83);
            this.lblDrug1.Name = "lblDrug1";
            this.lblDrug1.Size = new System.Drawing.Size(39, 15);
            this.lblDrug1.TabIndex = 1;
            this.lblDrug1.Text = "Drug1";
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Location = new System.Drawing.Point(390, 83);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(40, 15);
            this.lblCount1.TabIndex = 2;
            this.lblCount1.Text = "Count";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(446, 244);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(86, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display Log";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblDrug2
            // 
            this.lblDrug2.AutoSize = true;
            this.lblDrug2.Location = new System.Drawing.Point(226, 113);
            this.lblDrug2.Name = "lblDrug2";
            this.lblDrug2.Size = new System.Drawing.Size(39, 15);
            this.lblDrug2.TabIndex = 6;
            this.lblDrug2.Text = "Drug2";
            // 
            // lblDrug3
            // 
            this.lblDrug3.AutoSize = true;
            this.lblDrug3.Location = new System.Drawing.Point(226, 144);
            this.lblDrug3.Name = "lblDrug3";
            this.lblDrug3.Size = new System.Drawing.Size(39, 15);
            this.lblDrug3.TabIndex = 7;
            this.lblDrug3.Text = "Drug3";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Location = new System.Drawing.Point(390, 113);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(40, 15);
            this.lblCount2.TabIndex = 8;
            this.lblCount2.Text = "Count";
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.Location = new System.Drawing.Point(390, 144);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(40, 15);
            this.lblCount3.TabIndex = 9;
            this.lblCount3.Text = "Count";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.lblCount3);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblDrug3);
            this.Controls.Add(this.lblDrug2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.lblDrug1);
            this.Controls.Add(this.lblIncrementer);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button lblIncrementer;
        private Label lblDrug1;
        private Label lblCount1;
        private Button btnReset;
        private Button btnExit;
        private Button btnDisplay;
        private Label lblDrug2;
        private Label lblDrug3;
        private Label lblCount2;
        private Label lblCount3;
    }
}