
namespace InternetInfoGather
{
    partial class MainForm
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
            this.btnNormalLinear = new System.Windows.Forms.Button();
            this.btnParallelLinear = new System.Windows.Forms.Button();
            this.btnNormalAsync = new System.Windows.Forms.Button();
            this.btnParallelAsync = new System.Windows.Forms.Button();
            this.tboxTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNormalLinear
            // 
            this.btnNormalLinear.Location = new System.Drawing.Point(12, 214);
            this.btnNormalLinear.Name = "btnNormalLinear";
            this.btnNormalLinear.Size = new System.Drawing.Size(776, 49);
            this.btnNormalLinear.TabIndex = 0;
            this.btnNormalLinear.Text = "Normal Linear";
            this.btnNormalLinear.UseVisualStyleBackColor = true;
            this.btnNormalLinear.Click += new System.EventHandler(this.btnNormalLinear_Click);
            // 
            // btnParallelLinear
            // 
            this.btnParallelLinear.Location = new System.Drawing.Point(12, 269);
            this.btnParallelLinear.Name = "btnParallelLinear";
            this.btnParallelLinear.Size = new System.Drawing.Size(776, 49);
            this.btnParallelLinear.TabIndex = 1;
            this.btnParallelLinear.Text = "Parallel Linear";
            this.btnParallelLinear.UseVisualStyleBackColor = true;
            this.btnParallelLinear.Click += new System.EventHandler(this.btnParallelLinear_Click);
            // 
            // btnNormalAsync
            // 
            this.btnNormalAsync.Location = new System.Drawing.Point(12, 324);
            this.btnNormalAsync.Name = "btnNormalAsync";
            this.btnNormalAsync.Size = new System.Drawing.Size(776, 49);
            this.btnNormalAsync.TabIndex = 2;
            this.btnNormalAsync.Text = "Normal Async";
            this.btnNormalAsync.UseVisualStyleBackColor = true;
            this.btnNormalAsync.Click += new System.EventHandler(this.btnNormalAsync_Click);
            // 
            // btnParallelAsync
            // 
            this.btnParallelAsync.Location = new System.Drawing.Point(12, 379);
            this.btnParallelAsync.Name = "btnParallelAsync";
            this.btnParallelAsync.Size = new System.Drawing.Size(776, 49);
            this.btnParallelAsync.TabIndex = 3;
            this.btnParallelAsync.Text = "Parallel Async";
            this.btnParallelAsync.UseVisualStyleBackColor = true;
            this.btnParallelAsync.Click += new System.EventHandler(this.btnParallelAsync_Click);
            // 
            // tboxTest
            // 
            this.tboxTest.Location = new System.Drawing.Point(12, 29);
            this.tboxTest.Multiline = true;
            this.tboxTest.Name = "tboxTest";
            this.tboxTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxTest.Size = new System.Drawing.Size(776, 158);
            this.tboxTest.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxTest);
            this.Controls.Add(this.btnParallelAsync);
            this.Controls.Add(this.btnNormalAsync);
            this.Controls.Add(this.btnParallelLinear);
            this.Controls.Add(this.btnNormalLinear);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalLinear;
        private System.Windows.Forms.Button btnParallelLinear;
        private System.Windows.Forms.Button btnNormalAsync;
        private System.Windows.Forms.Button btnParallelAsync;
        private System.Windows.Forms.TextBox tboxTest;
    }
}

