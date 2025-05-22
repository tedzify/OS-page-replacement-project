namespace OS_page_replacement_project
{
    partial class MainForm
    {
        //  Required designer variable.
        private System.ComponentModel.IContainer components = null;

        //  Clean up any resources being used.
        //  true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        //  Required method for Designer support - do not modify
        //  the contents of this method with the code editor.
        private void InitializeComponent()
        {
            pnlVisualization = new Panel();
            lblRefString = new Label();
            pnlRefString = new Panel();
            pnlBtnContainer = new Panel();
            gboxSelectedAlgo = new GroupBox();
            lblSelectedAlgo = new Label();
            btnOptimal = new Button();
            btnLRU = new Button();
            btnFIFO = new Button();
            lblFrameCount = new Label();
            numFrameCount = new NumericUpDown();
            lblSeqLength = new Label();
            numSeqLength = new NumericUpDown();
            btnGenerateString = new Button();
            pnlControlContainer = new Panel();
            btnReset = new Button();
            btnNext = new Button();
            btnSkip = new Button();
            btnPrevious = new Button();
            pnlStepControls = new Panel();
            pnlStats = new Panel();
            fieldPageFaults = new TextBox();
            lblPageFaults = new Label();
            fieldMissPercent = new TextBox();
            fieldHitPercent = new TextBox();
            fieldTotalMiss = new TextBox();
            fieldTotalHit = new TextBox();
            lblMissPercent = new Label();
            lblMiss = new Label();
            lblHitPercent = new Label();
            lblHits = new Label();
            pnlBtnContainer.SuspendLayout();
            gboxSelectedAlgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFrameCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).BeginInit();
            pnlControlContainer.SuspendLayout();
            pnlStepControls.SuspendLayout();
            pnlStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVisualization
            // 
            pnlVisualization.Anchor = AnchorStyles.Top;
            pnlVisualization.BackColor = Color.FromArgb(45, 45, 45);
            pnlVisualization.Location = new Point(12, 197);
            pnlVisualization.Name = "pnlVisualization";
            pnlVisualization.Size = new Size(895, 452);
            pnlVisualization.TabIndex = 5;
            // 
            // lblRefString
            // 
            lblRefString.AutoSize = true;
            lblRefString.BackColor = Color.Gray;
            lblRefString.Font = new Font("Roboto Black", 12F);
            lblRefString.ForeColor = Color.White;
            lblRefString.Location = new Point(12, 95);
            lblRefString.Margin = new Padding(0);
            lblRefString.Name = "lblRefString";
            lblRefString.Size = new Size(132, 19);
            lblRefString.TabIndex = 5;
            lblRefString.Text = "Reference String";
            lblRefString.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRefString
            // 
            pnlRefString.Anchor = AnchorStyles.Top;
            pnlRefString.BackColor = Color.FromArgb(45, 45, 45);
            pnlRefString.BorderStyle = BorderStyle.FixedSingle;
            pnlRefString.Location = new Point(12, 114);
            pnlRefString.Name = "pnlRefString";
            pnlRefString.Size = new Size(895, 77);
            pnlRefString.TabIndex = 4;
            // 
            // pnlBtnContainer
            // 
            pnlBtnContainer.Anchor = AnchorStyles.Top;
            pnlBtnContainer.BackColor = Color.FromArgb(45, 45, 45);
            pnlBtnContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlBtnContainer.Controls.Add(gboxSelectedAlgo);
            pnlBtnContainer.Controls.Add(btnOptimal);
            pnlBtnContainer.Controls.Add(btnLRU);
            pnlBtnContainer.Controls.Add(btnFIFO);
            pnlBtnContainer.Location = new Point(12, 12);
            pnlBtnContainer.Name = "pnlBtnContainer";
            pnlBtnContainer.Size = new Size(895, 77);
            pnlBtnContainer.TabIndex = 0;
            // 
            // gboxSelectedAlgo
            // 
            gboxSelectedAlgo.Anchor = AnchorStyles.Right;
            gboxSelectedAlgo.BackColor = Color.FromArgb(64, 64, 64);
            gboxSelectedAlgo.Controls.Add(lblSelectedAlgo);
            gboxSelectedAlgo.Font = new Font("Roboto", 9F);
            gboxSelectedAlgo.ForeColor = Color.White;
            gboxSelectedAlgo.Location = new Point(558, 14);
            gboxSelectedAlgo.Name = "gboxSelectedAlgo";
            gboxSelectedAlgo.Size = new Size(315, 47);
            gboxSelectedAlgo.TabIndex = 3;
            gboxSelectedAlgo.TabStop = false;
            gboxSelectedAlgo.Text = "Selected";
            // 
            // lblSelectedAlgo
            // 
            lblSelectedAlgo.BackColor = Color.Transparent;
            lblSelectedAlgo.Font = new Font("Roboto Black", 20F);
            lblSelectedAlgo.Location = new Point(0, 11);
            lblSelectedAlgo.Name = "lblSelectedAlgo";
            lblSelectedAlgo.Size = new Size(315, 33);
            lblSelectedAlgo.TabIndex = 0;
            lblSelectedAlgo.Text = "NONE";
            lblSelectedAlgo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOptimal
            // 
            btnOptimal.BackColor = Color.Gray;
            btnOptimal.FlatAppearance.BorderColor = Color.Gray;
            btnOptimal.FlatAppearance.BorderSize = 0;
            btnOptimal.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnOptimal.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnOptimal.FlatStyle = FlatStyle.Flat;
            btnOptimal.Font = new Font("Roboto Black", 20F);
            btnOptimal.ForeColor = Color.White;
            btnOptimal.Location = new Point(374, 14);
            btnOptimal.Name = "btnOptimal";
            btnOptimal.Size = new Size(166, 47);
            btnOptimal.TabIndex = 0;
            btnOptimal.TabStop = false;
            btnOptimal.Text = "OPTIMAL";
            btnOptimal.UseVisualStyleBackColor = false;
            // 
            // btnLRU
            // 
            btnLRU.BackColor = Color.Gray;
            btnLRU.FlatAppearance.BorderColor = Color.Gray;
            btnLRU.FlatAppearance.BorderSize = 0;
            btnLRU.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnLRU.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnLRU.FlatStyle = FlatStyle.Flat;
            btnLRU.Font = new Font("Roboto Black", 20F);
            btnLRU.ForeColor = Color.White;
            btnLRU.Location = new Point(193, 14);
            btnLRU.Name = "btnLRU";
            btnLRU.Size = new Size(166, 47);
            btnLRU.TabIndex = 0;
            btnLRU.TabStop = false;
            btnLRU.Text = "LRU";
            btnLRU.UseVisualStyleBackColor = false;
            // 
            // btnFIFO
            // 
            btnFIFO.BackColor = Color.Gray;
            btnFIFO.FlatAppearance.BorderColor = Color.Gray;
            btnFIFO.FlatAppearance.BorderSize = 0;
            btnFIFO.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnFIFO.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnFIFO.FlatStyle = FlatStyle.Flat;
            btnFIFO.Font = new Font("Roboto Black", 20F);
            btnFIFO.ForeColor = Color.White;
            btnFIFO.Location = new Point(12, 14);
            btnFIFO.Name = "btnFIFO";
            btnFIFO.Size = new Size(166, 47);
            btnFIFO.TabIndex = 0;
            btnFIFO.TabStop = false;
            btnFIFO.Text = "FIFO";
            btnFIFO.UseVisualStyleBackColor = false;
            // 
            // lblFrameCount
            // 
            lblFrameCount.AutoSize = true;
            lblFrameCount.BackColor = Color.Transparent;
            lblFrameCount.Font = new Font("Roboto Black", 12F);
            lblFrameCount.ForeColor = Color.White;
            lblFrameCount.Location = new Point(16, 19);
            lblFrameCount.Name = "lblFrameCount";
            lblFrameCount.Size = new Size(101, 19);
            lblFrameCount.TabIndex = 1;
            lblFrameCount.Text = "Frame count";
            // 
            // numFrameCount
            // 
            numFrameCount.BackColor = Color.Gray;
            numFrameCount.BorderStyle = BorderStyle.None;
            numFrameCount.Font = new Font("Roboto Black", 12F);
            numFrameCount.ForeColor = Color.White;
            numFrameCount.Location = new Point(19, 40);
            numFrameCount.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numFrameCount.Name = "numFrameCount";
            numFrameCount.Size = new Size(214, 23);
            numFrameCount.TabIndex = 1;
            numFrameCount.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSeqLength
            // 
            lblSeqLength.AutoSize = true;
            lblSeqLength.BackColor = Color.Transparent;
            lblSeqLength.Font = new Font("Roboto Black", 12F);
            lblSeqLength.ForeColor = Color.White;
            lblSeqLength.Location = new Point(16, 93);
            lblSeqLength.Name = "lblSeqLength";
            lblSeqLength.Size = new Size(131, 19);
            lblSeqLength.TabIndex = 3;
            lblSeqLength.Text = "Sequence length";
            // 
            // numSeqLength
            // 
            numSeqLength.BackColor = Color.Gray;
            numSeqLength.BorderStyle = BorderStyle.None;
            numSeqLength.Font = new Font("Roboto Black", 12F);
            numSeqLength.ForeColor = Color.WhiteSmoke;
            numSeqLength.Location = new Point(19, 114);
            numSeqLength.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSeqLength.Name = "numSeqLength";
            numSeqLength.Size = new Size(214, 23);
            numSeqLength.TabIndex = 2;
            numSeqLength.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerateString
            // 
            btnGenerateString.BackColor = Color.Gray;
            btnGenerateString.FlatAppearance.BorderColor = Color.Gray;
            btnGenerateString.FlatAppearance.BorderSize = 0;
            btnGenerateString.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnGenerateString.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnGenerateString.FlatStyle = FlatStyle.Flat;
            btnGenerateString.Font = new Font("Roboto Black", 12F);
            btnGenerateString.ForeColor = Color.White;
            btnGenerateString.Location = new Point(19, 152);
            btnGenerateString.Name = "btnGenerateString";
            btnGenerateString.Size = new Size(214, 29);
            btnGenerateString.TabIndex = 3;
            btnGenerateString.Text = "GENERATE";
            btnGenerateString.UseVisualStyleBackColor = false;
            // 
            // pnlControlContainer
            // 
            pnlControlContainer.Anchor = AnchorStyles.Right;
            pnlControlContainer.BackColor = Color.FromArgb(45, 45, 45);
            pnlControlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlControlContainer.Controls.Add(btnReset);
            pnlControlContainer.Controls.Add(btnGenerateString);
            pnlControlContainer.Controls.Add(numSeqLength);
            pnlControlContainer.Controls.Add(lblSeqLength);
            pnlControlContainer.Controls.Add(numFrameCount);
            pnlControlContainer.Controls.Add(lblFrameCount);
            pnlControlContainer.Location = new Point(917, 12);
            pnlControlContainer.Name = "pnlControlContainer";
            pnlControlContainer.Size = new Size(255, 249);
            pnlControlContainer.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Gray;
            btnReset.FlatAppearance.BorderColor = Color.Gray;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnReset.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Roboto Black", 12F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(19, 196);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(214, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.FlatAppearance.BorderColor = Color.Gray;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNext.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Roboto Black", 12F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(20, 30);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(214, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.Gray;
            btnSkip.FlatAppearance.BorderColor = Color.Gray;
            btnSkip.FlatAppearance.BorderSize = 0;
            btnSkip.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSkip.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Font = new Font("Roboto Black", 12F);
            btnSkip.ForeColor = Color.White;
            btnSkip.Location = new Point(20, 116);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(214, 29);
            btnSkip.TabIndex = 6;
            btnSkip.Text = "SKIP";
            btnSkip.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Gray;
            btnPrevious.FlatAppearance.BorderColor = Color.Gray;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Roboto Black", 12F);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(20, 73);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(214, 29);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "PREVIOUS";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // pnlStepControls
            // 
            pnlStepControls.Anchor = AnchorStyles.Top;
            pnlStepControls.BackColor = Color.FromArgb(45, 45, 45);
            pnlStepControls.Controls.Add(btnPrevious);
            pnlStepControls.Controls.Add(btnSkip);
            pnlStepControls.Controls.Add(btnNext);
            pnlStepControls.Enabled = false;
            pnlStepControls.Location = new Point(917, 271);
            pnlStepControls.Name = "pnlStepControls";
            pnlStepControls.Size = new Size(255, 174);
            pnlStepControls.TabIndex = 6;
            // 
            // pnlStats
            // 
            pnlStats.Anchor = AnchorStyles.Top;
            pnlStats.BackColor = Color.FromArgb(45, 45, 45);
            pnlStats.Controls.Add(fieldPageFaults);
            pnlStats.Controls.Add(lblPageFaults);
            pnlStats.Controls.Add(fieldMissPercent);
            pnlStats.Controls.Add(fieldHitPercent);
            pnlStats.Controls.Add(fieldTotalMiss);
            pnlStats.Controls.Add(fieldTotalHit);
            pnlStats.Controls.Add(lblMissPercent);
            pnlStats.Controls.Add(lblMiss);
            pnlStats.Controls.Add(lblHitPercent);
            pnlStats.Controls.Add(lblHits);
            pnlStats.Location = new Point(917, 455);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(255, 194);
            pnlStats.TabIndex = 7;
            // 
            // fieldPageFaults
            // 
            fieldPageFaults.BackColor = Color.FromArgb(64, 64, 64);
            fieldPageFaults.BorderStyle = BorderStyle.FixedSingle;
            fieldPageFaults.Font = new Font("Roboto Black", 12F);
            fieldPageFaults.ForeColor = Color.White;
            fieldPageFaults.Location = new Point(122, 152);
            fieldPageFaults.Name = "fieldPageFaults";
            fieldPageFaults.ReadOnly = true;
            fieldPageFaults.Size = new Size(114, 27);
            fieldPageFaults.TabIndex = 11;
            fieldPageFaults.TabStop = false;
            fieldPageFaults.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPageFaults
            // 
            lblPageFaults.AutoSize = true;
            lblPageFaults.BackColor = Color.Transparent;
            lblPageFaults.Font = new Font("Roboto Black", 12F);
            lblPageFaults.ForeColor = Color.White;
            lblPageFaults.Location = new Point(22, 156);
            lblPageFaults.Name = "lblPageFaults";
            lblPageFaults.Size = new Size(100, 19);
            lblPageFaults.TabIndex = 10;
            lblPageFaults.Text = "Page Faults:";
            // 
            // fieldMissPercent
            // 
            fieldMissPercent.BackColor = Color.FromArgb(64, 64, 64);
            fieldMissPercent.BorderStyle = BorderStyle.FixedSingle;
            fieldMissPercent.Font = new Font("Roboto Black", 12F);
            fieldMissPercent.ForeColor = Color.White;
            fieldMissPercent.Location = new Point(122, 118);
            fieldMissPercent.Name = "fieldMissPercent";
            fieldMissPercent.ReadOnly = true;
            fieldMissPercent.Size = new Size(114, 27);
            fieldMissPercent.TabIndex = 9;
            fieldMissPercent.TabStop = false;
            fieldMissPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // fieldHitPercent
            // 
            fieldHitPercent.BackColor = Color.FromArgb(64, 64, 64);
            fieldHitPercent.BorderStyle = BorderStyle.FixedSingle;
            fieldHitPercent.Font = new Font("Roboto Black", 12F);
            fieldHitPercent.ForeColor = Color.White;
            fieldHitPercent.Location = new Point(122, 84);
            fieldHitPercent.Name = "fieldHitPercent";
            fieldHitPercent.ReadOnly = true;
            fieldHitPercent.Size = new Size(114, 27);
            fieldHitPercent.TabIndex = 8;
            fieldHitPercent.TabStop = false;
            fieldHitPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // fieldTotalMiss
            // 
            fieldTotalMiss.BackColor = Color.FromArgb(64, 64, 64);
            fieldTotalMiss.BorderStyle = BorderStyle.FixedSingle;
            fieldTotalMiss.Font = new Font("Roboto Black", 12F);
            fieldTotalMiss.ForeColor = Color.White;
            fieldTotalMiss.Location = new Point(122, 50);
            fieldTotalMiss.Name = "fieldTotalMiss";
            fieldTotalMiss.ReadOnly = true;
            fieldTotalMiss.Size = new Size(114, 27);
            fieldTotalMiss.TabIndex = 7;
            fieldTotalMiss.TabStop = false;
            fieldTotalMiss.TextAlign = HorizontalAlignment.Center;
            // 
            // fieldTotalHit
            // 
            fieldTotalHit.BackColor = Color.FromArgb(64, 64, 64);
            fieldTotalHit.BorderStyle = BorderStyle.FixedSingle;
            fieldTotalHit.Font = new Font("Roboto Black", 12F);
            fieldTotalHit.ForeColor = Color.White;
            fieldTotalHit.Location = new Point(122, 16);
            fieldTotalHit.Name = "fieldTotalHit";
            fieldTotalHit.ReadOnly = true;
            fieldTotalHit.Size = new Size(114, 27);
            fieldTotalHit.TabIndex = 6;
            fieldTotalHit.TabStop = false;
            fieldTotalHit.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMissPercent
            // 
            lblMissPercent.AutoSize = true;
            lblMissPercent.BackColor = Color.Transparent;
            lblMissPercent.Font = new Font("Roboto Black", 12F);
            lblMissPercent.ForeColor = Color.White;
            lblMissPercent.Location = new Point(22, 122);
            lblMissPercent.Name = "lblMissPercent";
            lblMissPercent.Size = new Size(64, 19);
            lblMissPercent.TabIndex = 5;
            lblMissPercent.Text = "Miss %:";
            // 
            // lblMiss
            // 
            lblMiss.AutoSize = true;
            lblMiss.BackColor = Color.Transparent;
            lblMiss.Font = new Font("Roboto Black", 12F);
            lblMiss.ForeColor = Color.White;
            lblMiss.Location = new Point(19, 54);
            lblMiss.Name = "lblMiss";
            lblMiss.Size = new Size(88, 19);
            lblMiss.TabIndex = 4;
            lblMiss.Text = "Total Miss:";
            // 
            // lblHitPercent
            // 
            lblHitPercent.AutoSize = true;
            lblHitPercent.BackColor = Color.Transparent;
            lblHitPercent.Font = new Font("Roboto Black", 12F);
            lblHitPercent.ForeColor = Color.White;
            lblHitPercent.Location = new Point(22, 88);
            lblHitPercent.Name = "lblHitPercent";
            lblHitPercent.Size = new Size(51, 19);
            lblHitPercent.TabIndex = 3;
            lblHitPercent.Text = "Hit %:";
            // 
            // lblHits
            // 
            lblHits.AutoSize = true;
            lblHits.BackColor = Color.Transparent;
            lblHits.Font = new Font("Roboto Black", 12F);
            lblHits.ForeColor = Color.White;
            lblHits.Location = new Point(19, 20);
            lblHits.Name = "lblHits";
            lblHits.Size = new Size(83, 19);
            lblHits.TabIndex = 2;
            lblHits.Text = "Total Hits:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlStats);
            Controls.Add(pnlStepControls);
            Controls.Add(pnlVisualization);
            Controls.Add(lblRefString);
            Controls.Add(pnlRefString);
            Controls.Add(pnlBtnContainer);
            Controls.Add(pnlControlContainer);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page Replacement Algorithm";
            pnlBtnContainer.ResumeLayout(false);
            gboxSelectedAlgo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFrameCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).EndInit();
            pnlControlContainer.ResumeLayout(false);
            pnlControlContainer.PerformLayout();
            pnlStepControls.ResumeLayout(false);
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBtnContainer;
        private Button btnFIFO;
        private Button btnLRU;
        private Button btnOptimal;
        private GroupBox gboxSelectedAlgo;
        private Label lblSelectedAlgo;
        private Panel pnlRefString;
        private Label lblRefString;
        private Panel pnlVisualization;
        private Panel pnlControlContainer;
        private Button btnGenerateString;
        private NumericUpDown numSeqLength;
        private Label lblSeqLength;
        private NumericUpDown numFrameCount;
        private Label lblFrameCount;
        private Button btnNext;
        private Button btnSkip;
        private Button btnPrevious;
        private Panel pnlStepControls;
        private Panel pnlStats;
        private Label lblHitPercent;
        private Label lblHits;
        private Label lblMissPercent;
        private Label lblMiss;
        private TextBox fieldTotalHit;
        private TextBox fieldTotalMiss;
        private TextBox fieldMissPercent;
        private TextBox fieldHitPercent;
        private Button btnReset;
        private TextBox fieldPageFaults;
        private Label lblPageFaults;
    }
}
