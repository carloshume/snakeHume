namespace snakeHume.UI
{
    partial class testBoard
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstBoxResults = new System.Windows.Forms.ListBox();
            this.btnMoveSnakeRight = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(348, 475);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBoxResults
            // 
            this.lstBoxResults.BackColor = System.Drawing.Color.Black;
            this.lstBoxResults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstBoxResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstBoxResults.FormattingEnabled = true;
            this.lstBoxResults.ItemHeight = 18;
            this.lstBoxResults.Location = new System.Drawing.Point(12, 5);
            this.lstBoxResults.Name = "lstBoxResults";
            this.lstBoxResults.Size = new System.Drawing.Size(786, 454);
            this.lstBoxResults.TabIndex = 1;
            // 
            // btnMoveSnakeRight
            // 
            this.btnMoveSnakeRight.Enabled = false;
            this.btnMoveSnakeRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMoveSnakeRight.Location = new System.Drawing.Point(348, 525);
            this.btnMoveSnakeRight.Name = "btnMoveSnakeRight";
            this.btnMoveSnakeRight.Size = new System.Drawing.Size(108, 57);
            this.btnMoveSnakeRight.TabIndex = 2;
            this.btnMoveSnakeRight.Text = "move Snake Right";
            this.btnMoveSnakeRight.UseVisualStyleBackColor = true;
            this.btnMoveSnakeRight.Click += new System.EventHandler(this.btnMoveSnakeRight_Click);
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(348, 588);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 44);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "end!";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // testBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(825, 642);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnMoveSnakeRight);
            this.Controls.Add(this.lstBoxResults);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "testBoard";
            this.Text = "snakeHumeGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStart;
        private ListBox lstBoxResults;
        private Button btnMoveSnakeRight;
        private Button btn_close;
    }
}