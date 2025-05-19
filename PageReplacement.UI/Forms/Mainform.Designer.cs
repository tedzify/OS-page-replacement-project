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
            splitMain = new SplitContainer();
            pnlRefString = new Panel();
            lblRefString = new Label();
            pnlBtnContainer = new Panel();
            gboxSelectedAlgo = new GroupBox();
            lblSelectedAlgo = new Label();
            btnOptimal = new Button();
            btnLRU = new Button();
            btnFIFO = new Button();
            pnlControlContainer = new Panel();
            btnGenerateString = new Button();
            numSeqLength = new NumericUpDown();
            lblSeqLength = new Label();
            numFrameCount = new NumericUpDown();
            lblFrameCount = new Label();
            pnlVisualization = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlBtnContainer.SuspendLayout();
            gboxSelectedAlgo.SuspendLayout();
            pnlControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFrameCount).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.IsSplitterFixed = true;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.BackColor = Color.FromArgb(64, 64, 64);
            splitMain.Panel1.Controls.Add(pnlVisualization);
            splitMain.Panel1.Controls.Add(lblRefString);
            splitMain.Panel1.Controls.Add(pnlRefString);
            splitMain.Panel1.Controls.Add(pnlBtnContainer);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.BackColor = Color.FromArgb(64, 64, 64);
            splitMain.Panel2.Controls.Add(pnlControlContainer);
            splitMain.Size = new Size(1184, 661);
            splitMain.SplitterDistance = 910;
            splitMain.TabIndex = 0;
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
            pnlControlContainer.Location = new Point(3, 12);
            pnlControlContainer.Name = "pnlControlContainer";
            pnlControlContainer.Size = new Size(255, 637);
            pnlControlContainer.TabIndex = 0;
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
            btnGenerateString.Location = new Point(31, 173);
            btnGenerateString.Name = "btnGenerateString";
            btnGenerateString.Size = new Size(190, 29);
            btnGenerateString.TabIndex = 3;
            btnGenerateString.Text = "GENERATE";
            btnGenerateString.UseVisualStyleBackColor = false;
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
            // pnlVisualization
            // 
            pnlVisualization.Anchor = AnchorStyles.Top;
            pnlVisualization.BackColor = Color.FromArgb(45, 45, 45);
            pnlVisualization.BorderStyle = BorderStyle.FixedSingle;
            pnlVisualization.Location = new Point(12, 197);
            pnlVisualization.Name = "pnlVisualization";
            pnlVisualization.Size = new Size(895, 368);
            pnlVisualization.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1184, 661);
            Controls.Add(splitMain);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page Replacement Algorithm";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel1.PerformLayout();
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlBtnContainer.ResumeLayout(false);
            gboxSelectedAlgo.ResumeLayout(false);
            gboxSelectedAlgo.PerformLayout();
            pnlControlContainer.ResumeLayout(false);
            pnlControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSeqLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFrameCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private Panel pnlBtnContainer;
        private Panel pnlControlContainer;
        private Button btnFIFO;
        private Button btnLRU;
        private Button btnOptimal;
        private GroupBox gboxSelectedAlgo;
        private Label lblSelectedAlgo;
        private Label lblFrameCount;
        private NumericUpDown numFrameCount;
        private NumericUpDown numSeqLength;
        private Label lblSeqLength;
        private Button btnGenerateString;
        private Panel pnlRefString;
        private Label lblRefString;
        private Panel pnlVisualization;
    }
}
