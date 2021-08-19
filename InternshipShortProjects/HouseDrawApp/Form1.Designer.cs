
namespace HouseDrawApp
{
    partial class mainForm
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
            this.drawPanel = new System.Windows.Forms.Panel();
            this.btnSaveInFile = new System.Windows.Forms.Button();
            this.btnSaveInBinaryFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnLoadFromBinaryFile = new System.Windows.Forms.Button();
            this.grpBoxTriangleOptions = new System.Windows.Forms.GroupBox();
            this.radBtnFilledTriangle = new System.Windows.Forms.RadioButton();
            this.radBtnEmptyTriangle = new System.Windows.Forms.RadioButton();
            this.grpBoxRectangleOptions = new System.Windows.Forms.GroupBox();
            this.radBtnFilledRectangle = new System.Windows.Forms.RadioButton();
            this.radBtnEmptyRectangle = new System.Windows.Forms.RadioButton();
            this.btnClearRadio = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpBoxTriangleOptions.SuspendLayout();
            this.grpBoxRectangleOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawPanel.Location = new System.Drawing.Point(119, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(916, 579);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Click += new System.EventHandler(this.drawPanel_Click);
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.Location = new System.Drawing.Point(12, 52);
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Size = new System.Drawing.Size(100, 37);
            this.btnSaveInFile.TabIndex = 1;
            this.btnSaveInFile.Text = "Save File";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // btnSaveInBinaryFile
            // 
            this.btnSaveInBinaryFile.Location = new System.Drawing.Point(12, 113);
            this.btnSaveInBinaryFile.Name = "btnSaveInBinaryFile";
            this.btnSaveInBinaryFile.Size = new System.Drawing.Size(100, 37);
            this.btnSaveInBinaryFile.TabIndex = 2;
            this.btnSaveInBinaryFile.Text = "Save Binary File";
            this.btnSaveInBinaryFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(12, 177);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(100, 37);
            this.btnLoadFromFile.TabIndex = 3;
            this.btnLoadFromFile.Text = "Load File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromBinaryFile
            // 
            this.btnLoadFromBinaryFile.Location = new System.Drawing.Point(12, 241);
            this.btnLoadFromBinaryFile.Name = "btnLoadFromBinaryFile";
            this.btnLoadFromBinaryFile.Size = new System.Drawing.Size(100, 37);
            this.btnLoadFromBinaryFile.TabIndex = 4;
            this.btnLoadFromBinaryFile.Text = "Load Binary File";
            this.btnLoadFromBinaryFile.UseVisualStyleBackColor = true;
            // 
            // grpBoxTriangleOptions
            // 
            this.grpBoxTriangleOptions.Controls.Add(this.radBtnFilledTriangle);
            this.grpBoxTriangleOptions.Controls.Add(this.radBtnEmptyTriangle);
            this.grpBoxTriangleOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxTriangleOptions.Location = new System.Drawing.Point(3, 337);
            this.grpBoxTriangleOptions.Name = "grpBoxTriangleOptions";
            this.grpBoxTriangleOptions.Size = new System.Drawing.Size(115, 93);
            this.grpBoxTriangleOptions.TabIndex = 5;
            this.grpBoxTriangleOptions.TabStop = false;
            this.grpBoxTriangleOptions.Text = "Triangle Options";
            // 
            // radBtnFilledTriangle
            // 
            this.radBtnFilledTriangle.AutoSize = true;
            this.radBtnFilledTriangle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnFilledTriangle.Location = new System.Drawing.Point(7, 62);
            this.radBtnFilledTriangle.Name = "radBtnFilledTriangle";
            this.radBtnFilledTriangle.Size = new System.Drawing.Size(97, 17);
            this.radBtnFilledTriangle.TabIndex = 1;
            this.radBtnFilledTriangle.TabStop = true;
            this.radBtnFilledTriangle.Text = "Filled Triangle";
            this.radBtnFilledTriangle.UseVisualStyleBackColor = true;
            // 
            // radBtnEmptyTriangle
            // 
            this.radBtnEmptyTriangle.AutoSize = true;
            this.radBtnEmptyTriangle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnEmptyTriangle.Location = new System.Drawing.Point(7, 38);
            this.radBtnEmptyTriangle.Name = "radBtnEmptyTriangle";
            this.radBtnEmptyTriangle.Size = new System.Drawing.Size(100, 17);
            this.radBtnEmptyTriangle.TabIndex = 0;
            this.radBtnEmptyTriangle.TabStop = true;
            this.radBtnEmptyTriangle.Text = "Empty Triangle";
            this.radBtnEmptyTriangle.UseVisualStyleBackColor = true;
            // 
            // grpBoxRectangleOptions
            // 
            this.grpBoxRectangleOptions.Controls.Add(this.radBtnFilledRectangle);
            this.grpBoxRectangleOptions.Controls.Add(this.radBtnEmptyRectangle);
            this.grpBoxRectangleOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxRectangleOptions.Location = new System.Drawing.Point(3, 459);
            this.grpBoxRectangleOptions.Name = "grpBoxRectangleOptions";
            this.grpBoxRectangleOptions.Size = new System.Drawing.Size(115, 88);
            this.grpBoxRectangleOptions.TabIndex = 6;
            this.grpBoxRectangleOptions.TabStop = false;
            this.grpBoxRectangleOptions.Text = "Rectangle Options";
            // 
            // radBtnFilledRectangle
            // 
            this.radBtnFilledRectangle.AutoSize = true;
            this.radBtnFilledRectangle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnFilledRectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radBtnFilledRectangle.Location = new System.Drawing.Point(7, 65);
            this.radBtnFilledRectangle.Name = "radBtnFilledRectangle";
            this.radBtnFilledRectangle.Size = new System.Drawing.Size(107, 17);
            this.radBtnFilledRectangle.TabIndex = 1;
            this.radBtnFilledRectangle.Text = "Filled Rectangle";
            this.radBtnFilledRectangle.UseVisualStyleBackColor = true;
            // 
            // radBtnEmptyRectangle
            // 
            this.radBtnEmptyRectangle.AutoSize = true;
            this.radBtnEmptyRectangle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnEmptyRectangle.Location = new System.Drawing.Point(7, 42);
            this.radBtnEmptyRectangle.Name = "radBtnEmptyRectangle";
            this.radBtnEmptyRectangle.Size = new System.Drawing.Size(110, 17);
            this.radBtnEmptyRectangle.TabIndex = 0;
            this.radBtnEmptyRectangle.Text = "Empty Rectangle";
            this.radBtnEmptyRectangle.UseVisualStyleBackColor = true;
            // 
            // btnClearRadio
            // 
            this.btnClearRadio.Location = new System.Drawing.Point(10, 553);
            this.btnClearRadio.Name = "btnClearRadio";
            this.btnClearRadio.Size = new System.Drawing.Size(107, 23);
            this.btnClearRadio.TabIndex = 7;
            this.btnClearRadio.Text = "Clear Radio";
            this.btnClearRadio.UseVisualStyleBackColor = true;
            this.btnClearRadio.Click += new System.EventHandler(this.btnClearRadio_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "MyHouse";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 603);
            this.Controls.Add(this.btnClearRadio);
            this.Controls.Add(this.grpBoxRectangleOptions);
            this.Controls.Add(this.grpBoxTriangleOptions);
            this.Controls.Add(this.btnLoadFromBinaryFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveInBinaryFile);
            this.Controls.Add(this.btnSaveInFile);
            this.Controls.Add(this.drawPanel);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.grpBoxTriangleOptions.ResumeLayout(false);
            this.grpBoxTriangleOptions.PerformLayout();
            this.grpBoxRectangleOptions.ResumeLayout(false);
            this.grpBoxRectangleOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button btnSaveInFile;
        private System.Windows.Forms.Button btnSaveInBinaryFile;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnLoadFromBinaryFile;
        private System.Windows.Forms.GroupBox grpBoxTriangleOptions;
        private System.Windows.Forms.GroupBox grpBoxRectangleOptions;
        private System.Windows.Forms.RadioButton radBtnFilledTriangle;
        private System.Windows.Forms.RadioButton radBtnEmptyTriangle;
        private System.Windows.Forms.RadioButton radBtnEmptyRectangle;
        private System.Windows.Forms.RadioButton radBtnFilledRectangle;
        private System.Windows.Forms.Button btnClearRadio;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

