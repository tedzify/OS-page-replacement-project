namespace OS_page_replacement_project
{
    // MainForm manages the UI for the page replacement simulation.
    public partial class MainForm : Form
    {
        // New fields for sequence and state management.
        private List<int> _generatedSequence;
        private List<PageReferenceEvent> _currentEvents;
        private int _currentColumnIndex;
        private int _frameCount;
        private IPageReplacementAlgorithm _algorithm;

        public MainForm()
        {
            InitializeComponent();
            WireUpUi();

            // Initialize non-nullable fields to default values.
            _generatedSequence = new List<int>();
            _currentEvents = new List<PageReferenceEvent>();
            _algorithm = null!; // Will be set later based on the selected algorithm.
        }

        // WireUpUi sets up the event handlers and initial UI state.
        private void WireUpUi()
        {
            // Set initial enabled/disabled status of panels and buttons.
            pnlBtnContainer.Enabled = false;
            pnlStats.Enabled = false;
            pnlStepControls.Enabled = false;
            btnReset.Enabled = false;

            // Register event handlers for button clicks.
            btnGenerateString.Click += BtnGenerateString_Click;
            btnReset.Click += BtnReset_Click;
            btnFIFO.Click += AlgorithmButton_Click;
            btnLRU.Click += AlgorithmButton_Click;
            btnOptimal.Click += AlgorithmButton_Click;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            btnSkip.Click += BtnSkip_Click;
        }

        // BtnGenerateString_Click generates a random reference sequence and enables UI controls.
        private void BtnGenerateString_Click(object? sender, EventArgs e)
        {
            // 1) Read controls: get frame count and sequence length from numeric controls.
            _frameCount = (int)numFrameCount.Value;
            int seqLength = (int)numSeqLength.Value;

            // 2) Generate and display the reference string on the UI.
            _generatedSequence = RandomSequenceGenerator.GenerateSequence(seqLength);
            FrameStackControl.RenderSequence(pnlRefString, _generatedSequence);

            // 3) Clear previous stats displayed in UI fields.
            fieldTotalHit.Clear();
            fieldTotalMiss.Clear();
            fieldMissPercent.Clear();
            fieldHitPercent.Clear();
            fieldPageFaults.Clear();

            // 4) Enable algorithm buttons and step controls, disable regenerate button.
            pnlBtnContainer.Enabled = true;
            pnlStats.Enabled = true;
            pnlStepControls.Enabled = true;
            btnReset.Enabled = true;
        }

        // BtnReset_Click clears the UI and resets the state to the launch state.
        private void BtnReset_Click(object? sender, EventArgs e)
        {
            pnlBtnContainer.Enabled = false;
            pnlStats.Enabled = false;
            pnlStepControls.Enabled = false;
            btnReset.Enabled = false;
            btnGenerateString.Enabled = true;

            // Clear the reference string and visualization panels.
            pnlRefString.Controls.Clear();
            pnlVisualization.Controls.Clear();
        }

        // AlgorithmButton_Click updates the UI to indicate which algorithm is selected.
        private void AlgorithmButton_Click(object? sender, EventArgs e)
        {
            if (sender == btnFIFO)
            {
                // FIFO algorithm selected.
                lblSelectedAlgo.Text = "FIFO";
            }
            else if (sender == btnLRU)
            {
                // LRU algorithm selected.
                lblSelectedAlgo.Text = "LRU";
            }
            else if (sender == btnOptimal)
            {
                // OPTIMAL algorithm selected.
                lblSelectedAlgo.Text = "OPTIMAL";
            }
        }

        // BtnNext_Click will step to the next event in the simulation.
        private void BtnNext_Click(object? sender, EventArgs e)
        {
            // Implementation pending.
        }

        // BtnPrevious_Click will step back to the previous event in the simulation.
        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            // Implementation pending.
        }

        // BtnSkip_Click will perform a skip operation in the simulation.
        private void BtnSkip_Click(object? sender, EventArgs e)
        {
            // Implementation pending.
        }

        // ────── Utility for sequence generation ──────
        // RandomSequenceGenerator generates a shuffled sequence of integers.
        internal static class RandomSequenceGenerator
        {
            private static readonly Random _random = new Random();

            internal static List<int> GenerateSequence(int sequenceLength)
            {
                if (sequenceLength <= 0)
                    throw new ArgumentException("Sequence length must be > 0.", nameof(sequenceLength));
                var sequence = new List<int>(sequenceLength);
                for (int i = 0; i < sequenceLength; i++)
                    sequence.Add(_random.Next(0, 10));
                // shuffle
                return sequence.OrderBy(x => _random.Next()).ToList();
            }
        }

        // ────── Algorithm interface & events ──────
        internal interface IPageReplacementAlgorithm
        {
            // Run the page replacement algorithm using the provided reference string and frame count.
            List<PageReferenceEvent> Run(List<int> referenceString, int frameCount);
        }

        // Represents a single event in the page replacement simulation.
        // It records the page number being referenced, whether it resulted in a hit or a miss,
        // and the state of the frames at the time of the reference.
        internal class PageReferenceEvent
        {
            // The number of the page referenced during the simulation.
            public int PageNumber { get; set; }

            // Indicates if the page reference was a hit (true) or a miss (false).
            public bool IsHit { get; set; }

            // The state of the frames after processing this page reference.
            public List<int> FrameState { get; set; }

            // Initializes a new instance of the PageReferenceEvent class.
            // Parameters:
            //   pageNumber - The number of the page being referenced.
            //   isHit - True if the reference was a hit; false if it was a miss.
            //   frameState - The list representing current frames after this event.
            public PageReferenceEvent(int pageNumber, bool isHit, List<int> frameState)
            {
                PageNumber = pageNumber;
                IsHit = isHit;
                // Ensures that FrameState is not null by initializing to an empty list if null.
                FrameState = frameState ?? new List<int>();
            }
        }

        // ────── FIFO algorithm ──────
        internal class AlgorithmFIFO : IPageReplacementAlgorithm
        {
            public List<PageReferenceEvent> Run(List<int> referenceString, int frameCount)
            {
                if (referenceString == null)
                    throw new ArgumentNullException(nameof(referenceString));
                if (frameCount <= 0)
                    throw new ArgumentException("Frame count must be greater than 0.", nameof(frameCount));

                List<PageReferenceEvent> events = new List<PageReferenceEvent>();
                Queue<int> fifoQueue = new Queue<int>(frameCount);
                List<int> currentFrames = new List<int>();

                foreach (var page in referenceString)
                {
                    // Check if page already exists in the frames.
                    bool isHit = currentFrames.Contains(page);
                    if (!isHit)
                    {
                        // If frames are full, remove the oldest page.
                        if (currentFrames.Count == frameCount) // Check currentFrames.Count instead of fifoQueue.Count for full
                        {
                            int removedPage = fifoQueue.Dequeue();
                            currentFrames.Remove(removedPage);
                        }
                        // Add the new page to the queue and current state.
                        fifoQueue.Enqueue(page);
                        currentFrames.Add(page);
                    }
                    // Record the current state of frames after this page reference.
                    events.Add(new PageReferenceEvent(page, isHit, new List<int>(currentFrames)));
                }
                return events;
            }
        }

        // ────── LRU algorithm ──────
        internal class AlgorithmLRU : IPageReplacementAlgorithm
        {
            public List<PageReferenceEvent> Run(List<int> referenceString, int frameCount)
            {
                if (referenceString == null)
                    throw new ArgumentNullException(nameof(referenceString));
                if (frameCount <= 0)
                    throw new ArgumentException("Frame count must be greater than 0.", nameof(frameCount));

                // List to record page reference events.
                List<PageReferenceEvent> events = new List<PageReferenceEvent>();
                // List representing current frames and tracking usage order.
                List<int> currentFrames = new List<int>();

                foreach (var page in referenceString)
                {
                    bool isHit = currentFrames.Contains(page);
                    if (isHit)
                    {
                        // For a hit, update usage by moving the page to the most recent end.
                        currentFrames.Remove(page);
                    }
                    else
                    {
                        // For a miss, remove the least recently used page when full.
                        if (currentFrames.Count == frameCount)
                        {
                            currentFrames.RemoveAt(0);
                        }
                    }
                    // Add the current page as most recently used.
                    currentFrames.Add(page);
                    // Record the current state after this event.
                    events.Add(new PageReferenceEvent(page, isHit, new List<int>(currentFrames)));
                }
                return events;
            }
        }

        // ────── Optimal algorithm ──────
        // Implements the Optimal page replacement strategy.
        internal class AlgorithmOptimal : IPageReplacementAlgorithm
        {
            public List<PageReferenceEvent> Run(List<int> referenceString, int frameCount)
            {
                if (referenceString == null)
                    throw new ArgumentNullException(nameof(referenceString));
                if (frameCount <= 0)
                    throw new ArgumentException("Frame count must be greater than 0.", nameof(frameCount));

                List<PageReferenceEvent> events = new List<PageReferenceEvent>();
                List<int> currentFrames = new List<int>();

                // Iterate through each page reference.
                for (int i = 0; i < referenceString.Count; i++)
                {
                    int page = referenceString[i];
                    bool isHit = currentFrames.Contains(page);

                    if (!isHit)
                    {
                        // For a miss, if there is an empty frame, add the page directly.
                        if (currentFrames.Count < frameCount)
                        {
                            currentFrames.Add(page);
                        }
                        else
                        {
                            // Determine the page to replace by looking ahead.
                            int pageToReplace = -1;
                            int farthestNextUse = -1;

                            foreach (var framePage in currentFrames)
                            {
                                int nextUseIndex = -1;
                                // Look ahead in the reference string.
                                for (int j = i + 1; j < referenceString.Count; j++)
                                {
                                    if (referenceString[j] == framePage)
                                    {
                                        nextUseIndex = j;
                                        break;
                                    }
                                }
                                // If the page is never used again, select it for replacement.
                                if (nextUseIndex == -1)
                                {
                                    pageToReplace = framePage;
                                    break;
                                }
                                // Otherwise, select the page with the farthest next usage.
                                else if (nextUseIndex > farthestNextUse)
                                {
                                    farthestNextUse = nextUseIndex;
                                    pageToReplace = framePage;
                                }
                            }
                            // Replace the selected page with the new page.
                            currentFrames.Remove(pageToReplace);
                            currentFrames.Add(page);
                        }
                    }
                    // Record the event after processing the current page.
                    events.Add(new PageReferenceEvent(page, isHit, new List<int>(currentFrames)));
                }
                return events;
            }
        }

        // ────── Runner & UI helpers ──────
        // FrameStackControl handles rendering of labels representing pages in the UI.
        internal class FrameStackControl
        {
            // Renders the generated reference string onto a panel.
            public static void RenderSequence(Panel pnlRefString, List<int> sequence)
            {
                // Clear any previous controls in the panel.
                pnlRefString.Controls.Clear();
                if (sequence == null || sequence.Count == 0)
                    return;

                // Configuration for each label.
                const int baseLabelSize = 70;
                const float baseFontSize = 20F;
                const int margin = 5;
                int totalLabels = sequence.Count;
                int totalNeededWidth = totalLabels * (baseLabelSize + (margin * 2));
                int availWidth = pnlRefString.ClientSize.Width;

                // Calculate scaling factor so that labels fit within the panel.
                float factor = Math.Min(1f, (float)availWidth / totalNeededWidth);
                if (totalNeededWidth == 0) factor = 1f;

                int labelSize = (int)(baseLabelSize * factor);
                float fontSize = baseFontSize * factor;
                if (labelSize == 0) labelSize = 1;
                if (fontSize < 1f && baseFontSize >= 1f) fontSize = 1f;

                // Center the labels horizontally.
                int totalLayoutWidth = totalLabels * (labelSize + (margin * 2));
                int startX = (pnlRefString.ClientSize.Width - totalLayoutWidth) / 2;
                if (startX < 0) startX = 0;

                // Center labels vertically.
                int posY = (pnlRefString.ClientSize.Height - labelSize) / 2;
                if (posY < 0) posY = 0;

                int currentX = startX;
                // Create and add each label for the sequence.
                for (int i = 0; i < sequence.Count; i++)
                {   
                    var page = sequence[i];
                    Label lblPage = new Label
                    {
                        Font = new Font("Roboto Black", fontSize),
                        ForeColor = Color.White,
                        Size = new Size(labelSize, labelSize),
                        TabIndex = 0,
                        Text = page.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(margin),
                        Location = new Point(currentX, posY)
                    };
                    currentX += labelSize + (margin * 2);
                    pnlRefString.Controls.Add(lblPage);
                }
            }
        }
    }
}