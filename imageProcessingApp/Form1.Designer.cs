namespace imageProcessingApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedComponentsLabelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getObjectsRectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBlobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convexHullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNumberOfSegmentedBlobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.blobActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.resizeImageToolStripMenuItem,
            this.restartApplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // resizeImageToolStripMenuItem
            // 
            this.resizeImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biggerToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.smallerToolStripMenuItem});
            this.resizeImageToolStripMenuItem.Name = "resizeImageToolStripMenuItem";
            this.resizeImageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.resizeImageToolStripMenuItem.Text = "Resize Image";
            // 
            // biggerToolStripMenuItem
            // 
            this.biggerToolStripMenuItem.Name = "biggerToolStripMenuItem";
            this.biggerToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.biggerToolStripMenuItem.Text = "Bigger";
            this.biggerToolStripMenuItem.Click += new System.EventHandler(this.biggerToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // smallerToolStripMenuItem
            // 
            this.smallerToolStripMenuItem.Name = "smallerToolStripMenuItem";
            this.smallerToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.smallerToolStripMenuItem.Text = "Smaller";
            this.smallerToolStripMenuItem.Click += new System.EventHandler(this.smallerToolStripMenuItem_Click);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restartApplicationToolStripMenuItem.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourFilteringToolStripMenuItem,
            this.connectedComponentsLabelingToolStripMenuItem,
            this.contrastCorrectionToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.hSLFilteringToolStripMenuItem,
            this.thresholdingToolStripMenuItem,
            this.invertColourToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.ShowShortcutKeys = false;
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filtersToolStripMenuItem.Text = "Apply Filters";
            // 
            // colourFilteringToolStripMenuItem
            // 
            this.colourFilteringToolStripMenuItem.Name = "colourFilteringToolStripMenuItem";
            this.colourFilteringToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.colourFilteringToolStripMenuItem.Text = "Colour Filtering";
            this.colourFilteringToolStripMenuItem.Click += new System.EventHandler(this.colourFilteringToolStripMenuItem_Click_1);
            // 
            // connectedComponentsLabelingToolStripMenuItem
            // 
            this.connectedComponentsLabelingToolStripMenuItem.Name = "connectedComponentsLabelingToolStripMenuItem";
            this.connectedComponentsLabelingToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.connectedComponentsLabelingToolStripMenuItem.Text = "Connected Components Labeling";
            this.connectedComponentsLabelingToolStripMenuItem.Click += new System.EventHandler(this.connectedComponentsLabelingToolStripMenuItem_Click_1);
            // 
            // contrastCorrectionToolStripMenuItem
            // 
            this.contrastCorrectionToolStripMenuItem.Name = "contrastCorrectionToolStripMenuItem";
            this.contrastCorrectionToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.contrastCorrectionToolStripMenuItem.Text = "Contrast Correction";
            this.contrastCorrectionToolStripMenuItem.Click += new System.EventHandler(this.contrastCorrectionToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // hSLFilteringToolStripMenuItem
            // 
            this.hSLFilteringToolStripMenuItem.Name = "hSLFilteringToolStripMenuItem";
            this.hSLFilteringToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.hSLFilteringToolStripMenuItem.Text = "HSL Filtering";
            this.hSLFilteringToolStripMenuItem.Click += new System.EventHandler(this.hSLFilteringToolStripMenuItem_Click);
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            this.thresholdingToolStripMenuItem.Click += new System.EventHandler(this.thresholdingToolStripMenuItem_Click);
            // 
            // invertColourToolStripMenuItem
            // 
            this.invertColourToolStripMenuItem.Name = "invertColourToolStripMenuItem";
            this.invertColourToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.invertColourToolStripMenuItem.Text = "Invert Colour";
            this.invertColourToolStripMenuItem.Click += new System.EventHandler(this.invertColourToolStripMenuItem_Click);
            // 
            // blobActionsToolStripMenuItem
            // 
            this.blobActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getObjectsRectanglesToolStripMenuItem,
            this.blobCounterToolStripMenuItem,
            this.filterBlobsToolStripMenuItem,
            this.convexHullToolStripMenuItem,
            this.showNumberOfSegmentedBlobsToolStripMenuItem});
            this.blobActionsToolStripMenuItem.Name = "blobActionsToolStripMenuItem";
            this.blobActionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.blobActionsToolStripMenuItem.Text = "Blob Actions";
            // 
            // getObjectsRectanglesToolStripMenuItem
            // 
            this.getObjectsRectanglesToolStripMenuItem.Name = "getObjectsRectanglesToolStripMenuItem";
            this.getObjectsRectanglesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.getObjectsRectanglesToolStripMenuItem.Text = "Get Objects Rectangles";
            this.getObjectsRectanglesToolStripMenuItem.Click += new System.EventHandler(this.getObjectsRectanglesToolStripMenuItem_Click);
            // 
            // blobCounterToolStripMenuItem
            // 
            this.blobCounterToolStripMenuItem.Name = "blobCounterToolStripMenuItem";
            this.blobCounterToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.blobCounterToolStripMenuItem.Text = "Extract Biggest Blob";
            this.blobCounterToolStripMenuItem.Click += new System.EventHandler(this.blobCounterToolStripMenuItem_Click);
            // 
            // filterBlobsToolStripMenuItem
            // 
            this.filterBlobsToolStripMenuItem.Name = "filterBlobsToolStripMenuItem";
            this.filterBlobsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.filterBlobsToolStripMenuItem.Text = "Filter Blobs";
            this.filterBlobsToolStripMenuItem.Click += new System.EventHandler(this.filterBlobsToolStripMenuItem_Click);
            // 
            // convexHullToolStripMenuItem
            // 
            this.convexHullToolStripMenuItem.Name = "convexHullToolStripMenuItem";
            this.convexHullToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.convexHullToolStripMenuItem.Text = "Convex Hull";
            this.convexHullToolStripMenuItem.Click += new System.EventHandler(this.convexHullToolStripMenuItem_Click);
            // 
            // showNumberOfSegmentedBlobsToolStripMenuItem
            // 
            this.showNumberOfSegmentedBlobsToolStripMenuItem.Name = "showNumberOfSegmentedBlobsToolStripMenuItem";
            this.showNumberOfSegmentedBlobsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.showNumberOfSegmentedBlobsToolStripMenuItem.Text = "Show number of Segmented Blobs";
            this.showNumberOfSegmentedBlobsToolStripMenuItem.Click += new System.EventHandler(this.showNumberOfSegmentedBlobsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1001, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1001, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1001, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 606);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click \"Open Image\" to choose an image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedComponentsLabelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getObjectsRectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterBlobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convexHullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNumberOfSegmentedBlobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

