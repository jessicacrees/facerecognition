namespace FaceRecognitionTest
{
    partial class CameraCapture
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
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxScIncRte = new System.Windows.Forms.ComboBox();
            this.comboBoxMinNeigh = new System.Windows.Forms.ComboBox();
            this.textBoxWinSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxTuneDetectParam = new System.Windows.Forms.GroupBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbExtractedFaces = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBoxTuneDetectParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(7, 12);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(418, 298);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(329, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Live Video!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Camera:";
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(218, 321);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(64, 21);
            this.cbCamIndex.TabIndex = 5;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // comboBoxScIncRte
            // 
            this.comboBoxScIncRte.FormattingEnabled = true;
            this.comboBoxScIncRte.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.comboBoxScIncRte.Location = new System.Drawing.Point(138, 22);
            this.comboBoxScIncRte.Name = "comboBoxScIncRte";
            this.comboBoxScIncRte.Size = new System.Drawing.Size(54, 21);
            this.comboBoxScIncRte.TabIndex = 6;
            this.comboBoxScIncRte.Text = "1.1";
            // 
            // comboBoxMinNeigh
            // 
            this.comboBoxMinNeigh.FormattingEnabled = true;
            this.comboBoxMinNeigh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(138, 49);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(54, 21);
            this.comboBoxMinNeigh.TabIndex = 7;
            this.comboBoxMinNeigh.Text = "2";
            // 
            // textBoxWinSize
            // 
            this.textBoxWinSize.Location = new System.Drawing.Point(138, 76);
            this.textBoxWinSize.Name = "textBoxWinSize";
            this.textBoxWinSize.Size = new System.Drawing.Size(54, 20);
            this.textBoxWinSize.TabIndex = 8;
            this.textBoxWinSize.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Scale Increase Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min Neighbours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Min Detection Scale\r\n(Window Size)";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 319);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxTuneDetectParam
            // 
            this.groupBoxTuneDetectParam.Controls.Add(this.label2);
            this.groupBoxTuneDetectParam.Controls.Add(this.label3);
            this.groupBoxTuneDetectParam.Controls.Add(this.label4);
            this.groupBoxTuneDetectParam.Controls.Add(this.textBoxWinSize);
            this.groupBoxTuneDetectParam.Controls.Add(this.comboBoxScIncRte);
            this.groupBoxTuneDetectParam.Controls.Add(this.comboBoxMinNeigh);
            this.groupBoxTuneDetectParam.Location = new System.Drawing.Point(431, 12);
            this.groupBoxTuneDetectParam.Name = "groupBoxTuneDetectParam";
            this.groupBoxTuneDetectParam.Size = new System.Drawing.Size(200, 121);
            this.groupBoxTuneDetectParam.TabIndex = 15;
            this.groupBoxTuneDetectParam.TabStop = false;
            this.groupBoxTuneDetectParam.Text = "Tune Detection Parameters:";
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(431, 276);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 23);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(479, 276);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbExtractedFaces
            // 
            this.pbExtractedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExtractedFaces.Location = new System.Drawing.Point(431, 163);
            this.pbExtractedFaces.Name = "pbExtractedFaces";
            this.pbExtractedFaces.Size = new System.Drawing.Size(90, 107);
            this.pbExtractedFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtractedFaces.TabIndex = 18;
            this.pbExtractedFaces.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Extracted Face:";
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbExtractedFaces);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBoxTuneDetectParam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CamImageBox);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBoxTuneDetectParam.ResumeLayout(false);
            this.groupBoxTuneDetectParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.ComboBox comboBoxScIncRte;
        private System.Windows.Forms.ComboBox comboBoxMinNeigh;
        private System.Windows.Forms.TextBox textBoxWinSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxTuneDetectParam;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbExtractedFaces;
        private System.Windows.Forms.Label label5;
    }
}

