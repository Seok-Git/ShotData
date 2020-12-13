
namespace TestXYZ
{
    partial class Form2
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
            this.chartViewer = new ChartDirector.WinChartViewer();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // chartViewer
            // 
            this.chartViewer.HotSpotCursor = System.Windows.Forms.Cursors.Hand;
            this.chartViewer.Location = new System.Drawing.Point(249, 104);
            this.chartViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartViewer.Name = "chartViewer";
            this.chartViewer.Size = new System.Drawing.Size(91, 75);
            this.chartViewer.TabIndex = 9;
            this.chartViewer.TabStop = false;
            this.chartViewer.ViewPortChanged += new ChartDirector.WinViewPortEventHandler(this.chartViewer_ViewPortChanged);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(716, 27);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(72, 62);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "새로고침";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.chartViewer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Leave += new System.EventHandler(this.Form2_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Refresh;
        public ChartDirector.WinChartViewer chartViewer;
    }
}