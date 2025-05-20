namespace OS_page_replacement_project
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
            pnlVisualization = new Panel();
            lblRefString = new Label();
            pnlRefString = new Panel();
            flowPanelRefString = new FlowLayoutPanel();
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
            btnNext = new Button();
            btnSkip = new Button();
            btnPrevious = new Button();
            pnlControls = new Panel();
            panel1 = new Panel();
            lblHits = new Label();
            lblHitPercent = new Label();
            lblMissPercent = new Label();
            lblMiss = new Label();
            fieldTotalHit = new TextBox();
            fieldTotalMiss = new TextBox();
            fieldMissPercent = new TextBox();
            fieldHitPercent = new TextBox();
            pnlRefString.SuspendLayout();
            pnlBtnContainer.SuspendLayout();
            gboxSelectedAlgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFrameCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).BeginInit();
            pnlControlContainer.SuspendLayout();
            pnlControls.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlRefString.Controls.Add(flowPanelRefString);
            pnlRefString.Location = new Point(12, 114);
            pnlRefString.Name = "pnlRefString";
            pnlRefString.Size = new Size(895, 77);
            pnlRefString.TabIndex = 4;
            // 
            // flowPanelRefString
            // 
            flowPanelRefString.Dock = DockStyle.Fill;
            flowPanelRefString.Location = new Point(0, 0);
            flowPanelRefString.Name = "flowPanelRefString";
            flowPanelRefString.Padding = new Padding(3);
            flowPanelRefString.Size = new Size(893, 75);
            flowPanelRefString.TabIndex = 0;
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
            lblSelectedAlgo.AutoSize = true;
            lblSelectedAlgo.BackColor = Color.Transparent;
            lblSelectedAlgo.Font = new Font("Roboto Black", 20F);
            lblSelectedAlgo.Location = new Point(114, 11);
            lblSelectedAlgo.Name = "lblSelectedAlgo";
            lblSelectedAlgo.Size = new Size(87, 33);
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
            btnGenerateString.Location = new Point(19, 173);
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
            btnNext.Location = new Point(20, 26);
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
            btnSkip.Location = new Point(20, 112);
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
            btnPrevious.Location = new Point(20, 69);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(214, 29);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "PREVIOUS";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.Top;
            pnlControls.BackColor = Color.FromArgb(45, 45, 45);
            pnlControls.Controls.Add(btnPrevious);
            pnlControls.Controls.Add(btnSkip);
            pnlControls.Controls.Add(btnNext);
            pnlControls.Location = new Point(917, 271);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(255, 174);
            pnlControls.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(fieldMissPercent);
            panel1.Controls.Add(fieldHitPercent);
            panel1.Controls.Add(fieldTotalMiss);
            panel1.Controls.Add(fieldTotalHit);
            panel1.Controls.Add(lblMissPercent);
            panel1.Controls.Add(lblMiss);
            panel1.Controls.Add(lblHitPercent);
            panel1.Controls.Add(lblHits);
            panel1.Location = new Point(917, 455);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 194);
            panel1.TabIndex = 7;
            panel1.Paint += this.panel1_Paint;
            // 
            // lblHits
            // 
            lblHits.AutoSize = true;
            lblHits.BackColor = Color.Transparent;
            lblHits.Font = new Font("Roboto Black", 12F);
            lblHits.ForeColor = Color.White;
            lblHits.Location = new Point(17, 35);
            lblHits.Name = "lblHits";
            lblHits.Size = new Size(83, 19);
            lblHits.TabIndex = 2;
            lblHits.Text = "Total Hits:";
            // 
            // lblHitPercent
            // 
            lblHitPercent.AutoSize = true;
            lblHitPercent.BackColor = Color.Transparent;
            lblHitPercent.Font = new Font("Roboto Black", 12F);
            lblHitPercent.ForeColor = Color.White;
            lblHitPercent.Location = new Point(20, 105);
            lblHitPercent.Name = "lblHitPercent";
            lblHitPercent.Size = new Size(51, 19);
            lblHitPercent.TabIndex = 3;
            lblHitPercent.Text = "Hit %:";
            lblHitPercent.Click += this.lblHitPercent_Click;
            // 
            // lblMissPercent
            // 
            lblMissPercent.AutoSize = true;
            lblMissPercent.BackColor = Color.Transparent;
            lblMissPercent.Font = new Font("Roboto Black", 12F);
            lblMissPercent.ForeColor = Color.White;
            lblMissPercent.Location = new Point(20, 140);
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
            lblMiss.Location = new Point(17, 70);
            lblMiss.Name = "lblMiss";
            lblMiss.Size = new Size(88, 19);
            lblMiss.TabIndex = 4;
            lblMiss.Text = "Total Miss:";
            // 
            // fieldTotalHit
            // 
            fieldTotalHit.BackColor = Color.FromArgb(64, 64, 64);
            fieldTotalHit.BorderStyle = BorderStyle.FixedSingle;
            fieldTotalHit.Font = new Font("Roboto Black", 12F);
            fieldTotalHit.ForeColor = Color.White;
            fieldTotalHit.Location = new Point(102, 31);
            fieldTotalHit.Name = "fieldTotalHit";
            fieldTotalHit.ReadOnly = true;
            fieldTotalHit.Size = new Size(132, 27);
            fieldTotalHit.TabIndex = 6;
            fieldTotalHit.TabStop = false;
            fieldTotalHit.Text = "0";
            fieldTotalHit.TextAlign = HorizontalAlignment.Center;
            fieldTotalHit.TextChanged += this.fieldTotalHit_TextChanged;
            // 
            // fieldTotalMiss
            // 
            fieldTotalMiss.BackColor = Color.FromArgb(64, 64, 64);
            fieldTotalMiss.BorderStyle = BorderStyle.FixedSingle;
            fieldTotalMiss.Font = new Font("Roboto Black", 12F);
            fieldTotalMiss.ForeColor = Color.White;
            fieldTotalMiss.Location = new Point(102, 66);
            fieldTotalMiss.Name = "fieldTotalMiss";
            fieldTotalMiss.ReadOnly = true;
            fieldTotalMiss.Size = new Size(132, 27);
            fieldTotalMiss.TabIndex = 7;
            fieldTotalMiss.TabStop = false;
            fieldTotalMiss.Text = "0";
            fieldTotalMiss.TextAlign = HorizontalAlignment.Center;
            // 
            // fieldMissPercent
            // 
            fieldMissPercent.BackColor = Color.FromArgb(64, 64, 64);
            fieldMissPercent.BorderStyle = BorderStyle.FixedSingle;
            fieldMissPercent.Font = new Font("Roboto Black", 12F);
            fieldMissPercent.ForeColor = Color.White;
            fieldMissPercent.Location = new Point(102, 136);
            fieldMissPercent.Name = "fieldMissPercent";
            fieldMissPercent.ReadOnly = true;
            fieldMissPercent.Size = new Size(132, 27);
            fieldMissPercent.TabIndex = 9;
            fieldMissPercent.TabStop = false;
            fieldMissPercent.Text = "0";
            fieldMissPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // fieldHitPercent
            // 
            fieldHitPercent.BackColor = Color.FromArgb(64, 64, 64);
            fieldHitPercent.BorderStyle = BorderStyle.FixedSingle;
            fieldHitPercent.Font = new Font("Roboto Black", 12F);
            fieldHitPercent.ForeColor = Color.White;
            fieldHitPercent.Location = new Point(102, 101);
            fieldHitPercent.Name = "fieldHitPercent";
            fieldHitPercent.ReadOnly = true;
            fieldHitPercent.Size = new Size(132, 27);
            fieldHitPercent.TabIndex = 8;
            fieldHitPercent.TabStop = false;
            fieldHitPercent.Text = "0";
            fieldHitPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel1);
            Controls.Add(pnlControls);
            Controls.Add(pnlVisualization);
            Controls.Add(lblRefString);
            Controls.Add(pnlRefString);
            Controls.Add(pnlBtnContainer);
            Controls.Add(pnlControlContainer);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page Replacement Algorithm";
            pnlRefString.ResumeLayout(false);
            pnlBtnContainer.ResumeLayout(false);
            gboxSelectedAlgo.ResumeLayout(false);
            gboxSelectedAlgo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFrameCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).EndInit();
            pnlControlContainer.ResumeLayout(false);
            pnlControlContainer.PerformLayout();
            pnlControls.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private FlowLayoutPanel flowPanelRefString;
        private Button btnNext;
        private Button btnSkip;
        private Button btnPrevious;
        private Panel pnlControls;
        private Panel panel1;
        private Label lblHitPercent;
        private Label lblHits;
        private Label lblMissPercent;
        private Label lblMiss;
        private TextBox fieldTotalHit;
        private TextBox fieldTotalMiss;
        private TextBox fieldMissPercent;
        private TextBox fieldHitPercent;
    }
}
