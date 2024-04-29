namespace ЛР_14_tabul_wind_
{
    partial class ResultsForm
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
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.BackColor = System.Drawing.Color.YellowGreen;
            this.resultsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsListBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 25;
            this.resultsListBox.Location = new System.Drawing.Point(0, 0);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(628, 392);
            this.resultsListBox.TabIndex = 0;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(628, 392);
            this.Controls.Add(this.resultsListBox);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
    }
}