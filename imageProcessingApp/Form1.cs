using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.ComplexFilters;
using AForge.Math;
using AForge.Math.Geometry;

namespace imageProcessingApp
{
    public partial class Form1 : Form
    {
                  
        public Form1()
        {
            InitializeComponent(); 
        }

        // Declare openfiledialog and savefiledialog
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
    
        private void Form1_Load(object sender, EventArgs e)
        {
            // Colouring the form
            this.BackColor = Color.Black;
            this.ForeColor = Color.Blue;
            // Lock the picturebox
            pictureBox1.Enabled = false;  
            // Initialise labelboxes
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void colourFiltering()
        // Colour filtering
        {
            // Declare variables
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            // create filter
            ColorFiltering filter = new ColorFiltering();
            // set color ranges to keep
            filter.Red = new IntRange(100, 255);
            filter.Green = new IntRange(0, 75);
            filter.Blue = new IntRange(0, 75);
            // apply the filter
            filter.ApplyInPlace(bitmap);
            pictureBox1.Image = bitmap;
        }
       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            { 
            // Declare variables
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            Color mycolor = bitmap.GetPixel(e.X, e.Y);
            // Display image properties on label boxes
            label1.Text = Convert.ToString("X=" + " " + e.X + "," + " " + "Y=" + " " + e.Y);
            label2.Text = Convert.ToString("A=" + " " + mycolor.A + "," + " " + "R=" + " " + mycolor.R + "," + " " + "G=" + " " + mycolor.G + "," + " " + "B=" + " " + mycolor.B);
            label3.Text = Convert .ToString("Image Width=" + bitmap.Width + "," + " " + "Image Height=" + "" + bitmap.Height);
                }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + " " + exc.Message + "," + " " + "please try again!");                
            }
        }

        private void connectedComponentsLabeling()
        // Connected components labelling
        {
            // Declare variables
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            // create filter
            ConnectedComponentsLabeling filter = new ConnectedComponentsLabeling();
            // apply the filter
            Bitmap ccLImage = filter.Apply(bitmap);
            // check objects count
            int objectCount = filter.ObjectCount;
            pictureBox1.Image = ccLImage;
        }

        private void contrastCorrection()
        {
            // Declare variables
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            // create filter
            ContrastCorrection filter = new ContrastCorrection(15);
            // apply the filter
            filter.ApplyInPlace(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void getObjectsRectangles()
        // Get objects rectangles
        {
        // Declare image
        Bitmap bmp = new Bitmap(pictureBox1.Image);        
        BlobCounter blobCounter = new BlobCounter(bmp);
        blobCounter.MinWidth = 5;
        blobCounter.MinHeight = 5;
        blobCounter.FilterBlobs = true;
        blobCounter.ProcessImage(bmp);
        Rectangle[] rects = blobCounter.GetObjectsRectangles();
        foreach (Rectangle recs in rects)
            if (rects.Length > 0)
            {
                foreach (Rectangle objectRect in rects)
                {

                    Graphics g = Graphics.FromImage(bmp);

                    using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }

                    g.Dispose();
                    pictureBox1.Image = bmp;                }
            }        }

        private void grayscale()
        // Apply Grayscale filter
        {           
            // Declare image
             Bitmap bmp = new Bitmap(pictureBox1.Image);
            IFilter filter = Grayscale.CommonAlgorithms.BT709;
            bmp = filter.Apply(bmp);
            pictureBox1.Image = bmp;
        }

        private void extractBiggestBlob()
        // Extract biggest blob
        {            
            try {          
             // Delare image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            // create filter
            ExtractBiggestBlob filter = new ExtractBiggestBlob();
            // apply the filter
            Bitmap biggestBlobsImage = filter.Apply(bmp);
            pictureBox1.Image = biggestBlobsImage;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
    
        }

        private void filterBlobs()
        // Filter blobs
        {           
            // Delare image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            // create filter
            BlobsFiltering filter = new BlobsFiltering();
            // configure filter
            filter.CoupledSizeFiltering = true;
            filter.MinWidth = 70;
            filter.MinHeight = 70;
            // apply the filter
            filter.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }

        private void hSLFiltering()
        // HSL Filtering
        {
            // Delare image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            // create filter
            HSLFiltering filter = new HSLFiltering();
            // set color ranges to keep
            filter.Hue = new IntRange(335, 0);
            filter.Saturation = new Range(0.6f, 1);
            filter.Luminance = new Range(0.1f, 1);
            // apply the filter
            filter.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }

        private void convexHull()
       // Convex Hull
        {
            // Declare image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(bmp);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create convex hull searching algorithm
            GrahamConvexHull hullFinder = new GrahamConvexHull();

            // lock image to draw on it
            BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, bmp.PixelFormat);

            // process each blob
            foreach (Blob blob in blobs)
            {
                List<IntPoint> leftPoints, rightPoints, edgePoints;
                edgePoints = new List<IntPoint>();
                // get blob's edge points
                blobCounter.GetBlobsLeftAndRightEdges(blob,
                    out leftPoints, out rightPoints);

                edgePoints.AddRange(leftPoints);
                edgePoints.AddRange(rightPoints);

                // blob's convex hull
                List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                Drawing.Polygon(data, hull, Color.Red);
            }

            bmp.UnlockBits(data);
            pictureBox1.Image = bmp;
        }

        private void thresholding()
        // Threshold Image
        {
            // Declare Image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            // create filters sequence
            FiltersSequence filter = new AForge.Imaging.Filters.FiltersSequence();

            // add filters to the sequence
            filter.Add(new Grayscale(0.299, 0.587, 0.114));
            filter.Add(new Threshold(128));

            // apply the filter sequence
            Bitmap newbmp = filter.Apply(bmp);
            pictureBox1.Image = newbmp;
        }

        private void invertColour()
        // Invert Image colour
        {
            // Declare variables
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int a, r, g, b;

            // Loop through image, get pixels, invert and set the pixels to the image
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    a = bmp.GetPixel(x, y).A;
                    r = bmp.GetPixel(x, y).R;
                    g = bmp.GetPixel(x, y).G;
                    b = bmp.GetPixel(x, y).B;

                    bmp.SetPixel(x, y, Color.FromArgb(a, 255 - r, 255 - g, 255 - b));
                }
            }
            pictureBox1.Refresh();
            pictureBox1.Image = bmp;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

        private void showNumberOfSegmentedBlobs()
        {
            // Declare image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            BlobCounter blobCounter = new BlobCounter(bmp);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            // Show number of segmented blobs in image
            MessageBox.Show("Number of segmented blobs:" + blobCounter.ObjectsCount.ToString());
        }

        private void openImage()
        {                              
                // Filter file formats
                ofd.Filter = "JPG file|*.jpg|BMP file|*.bmp|PNG file|*.png|GIF file|*.gif|PDF file|*.pdf";
                // Conditions to select a file
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Enable the picturebox
                    pictureBox1.Enabled = true;
                    pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    label4.Visible = false;
                    // Declare new size of both image
                    Size newSize = new Size(650, 600);
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    // Apply new size to image
                    bitmap = new Bitmap(pictureBox1 .Image, newSize);
                    // Make image fit to picturebox
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBox1.Image = bitmap;
                }
                // Conditions if a file is not selected
                else
                {
                    pictureBox1.Enabled = false;
                }
        }

        private void saveImage()
        {
            // Save file dialog
            sfd.Filter = "JPG file|*.jpg|BMP file|*.bmp|PNG file|*.png|GIF file|*.gif|PDF file|*.pdf";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK && sfd.FileName.Length > 0)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //select the image
                openImage();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //save the image
                saveImage();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void resizeImageNormal()
        {
                // Declare image 
                Bitmap bmp = new Bitmap(pictureBox1 .Image );
                // Declare new size of image
                Size newSize = new Size(650, 600);
                // Apply new size to both images
                bmp = new Bitmap(pictureBox1 .Image , newSize);
                // Display result on picturebox
                pictureBox1 .Image = bmp;
                // Stretch image to fit picturebox
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bmp;
        }

        private void resizeImageBigger()
        {
   
                // Declare image 
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                // Declare new size of image
                Size newSize = new Size(700, 650);
                // Apply new size to both images
                bmp = new Bitmap(pictureBox1.Image, newSize);
                // Display result on picturebox
                pictureBox1.Image = bmp;
                // Stretch image to fit picturebox
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bmp;
        }

        private void resizeImageSmaller()
        {
                // Declare image 
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                // Declare new size of image
                Size newSize = new Size(550, 500);
                // Apply new size to both images
                bmp = new Bitmap(pictureBox1.Image, newSize);
                // Display result on picturebox
                pictureBox1.Image = bmp;
                // Stretch image to fit picturebox
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bmp;

            }
            

        private void colourFilteringToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colourFiltering();
        }

        private void biggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resizeImageBigger();
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resizeImageNormal();
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resizeImageSmaller();
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Quit the application
            Application.Exit();

        }

        private void restartApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Restart application
            Application.Restart();
        }

        private void connectedComponentsLabelingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            connectedComponentsLabeling();
        }

        private void getObjectsRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getObjectsRectangles();
        }

        private void contrastCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contrastCorrection();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayscale();
        }

        private void filterBlobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterBlobs();
        }

        private void blobCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extractBiggestBlob();
        }

        private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hSLFiltering();
        }

        private void convexHullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convexHull();
        }

        private void thresholdingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thresholding();
        }

        private void invertColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invertColour();
        }

        private void showNumberOfSegmentedBlobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNumberOfSegmentedBlobs();
        }


        
    }}
