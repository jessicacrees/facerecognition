using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace FaceRecognitionTest
{
    public partial class CameraCapture : Form
    {
        //*****************************************************************
        //                          Global Variables
        //*****************************************************************
        private Capture capture;        //takes images from camera as image frames
        
        Image<Bgr, byte> ImageFrame;    //The Global "Input Image"

        //***************For Face Detector(Haar Classifier)****************
        private HaarCascade haar;       //the viola-jones classifier (detector)

        //Set the Default values of the parameters
        //to be used as a variable in call to DetectHaarCascade()
        private int WindowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int MinNeighbors = 3;

        Bitmap[] ExtFaces;
        int faceNo = 0;

        //*****************************************************************
        //*****************************************************************
        
        public CameraCapture()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // adjust path to find your XML file 
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        //------------------------------------------------------------------------------//
        //Process Frame() below is our user defined function in which we will create an EmguCv 
        //type image called ImageFrame. capture a frame from camera and allocate it to our 
        //ImageFrame. then show this image in ourEmguCV imageBox
        //------------------------------------------------------------------------------//
        private void ProcessFrame(object sender, EventArgs arg)
        {
            //fetch the frame captured by web camera
            ImageFrame = capture.QueryFrame();

            //show the image in the EmguCV ImageBox
            CamImageBox.Image = ImageFrame;
            
            //Read an image from hard disk at location e.g ‘E:\IMAGES\’
            //Image InputImg = Image.FromFile(@"C:\Users\user\Pictures\ManyFacesImage.jpg");
            //Image<Bgr, byte> ImageFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
            
            //Below 2 lines of code capture image from webcam
            //Image<Bgr, Byte> ImageFrame = capture.QueryFrame();
            //CamImageBox.Image = ImageFrame;
            //ImageFrame.Save(@"C:\Users\user\Desktop\IS Thesis Code\FaceRecognitionTest\FaceRecognitionTest\Image.jpg");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (btnStart.Text == "Detect Face")
                {  //if camera is getting frames then pause the capture and set button Text to
                    // "Resume" for resuming capture
                    btnStart.Text = "Resume Live Video"; //

                    //Pause the live streaming video
                    Application.Idle -= ProcessFrame;

                    //Call face detection
                    DetectFaces();
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Pause" for pausing capture
                    btnStart.Text = "Detect Face";
                    Application.Idle += ProcessFrame;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                ImageFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = ImageFrame;
                DetectFaces();
            }
        }

        //Allows user to select a desired camera and starts it
        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the camera number to the one selected via combo box
            int CamNumber = -1;
            CamNumber = int.Parse(cbCamIndex.Text);

            //Start the selected camera
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(CamNumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            //Start showing the stream from camera
            btnStart_Click(sender, e);
            btnStart.Enabled = true;   //enable the button for pause/resume
        }

        private void DetectFaces()
        {
            //convert the image to gray scale
            Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();

            //Assign user-defined Values to parameter variables:
            MinNeighbors = int.Parse(comboBoxMinNeigh.Text); //the 3rd parameter
            WindowsSize = int.Parse(textBoxWinSize.Text); //the 5th parameter
            ScaleIncreaseRate = Double.Parse(comboBoxScIncRte.Text); //the 2nd parameter

            //Detect faces from the gray-scale image and store into an array of type 'var',i.e 'MCvAvgComp[]'
            var faces = grayframe.DetectHaarCascade(haar, ScaleIncreaseRate, MinNeighbors,
                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                    new Size(WindowsSize, WindowsSize))[0];
            if (faces.Length > 0)
            {
                MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());
                Bitmap BmpInput = grayframe.ToBitmap();
                Bitmap ExtractedFace;   //empty
                Graphics FaceCanvas;
                ExtFaces = new Bitmap[faces.Length];

                //draw a green rectangle on each detected face in image
                foreach (var face in faces)
                {
                    ImageFrame.Draw(face.rect, new Bgr(Color.Green), 3);

                    //set the size of the empty box(ExtractedFace) which will later contain the detected face
                    ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);

                    //set image as FaceCanvas, for painting
                    FaceCanvas = Graphics.FromImage(ExtractedFace);

                    //Taken detected face and copied it into ExtractedFace
                    FaceCanvas.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);

                    ExtFaces[faceNo] = ExtractedFace;
                    faceNo++;
                }
                faceNo = 0;
                pbExtractedFaces.Image = ExtFaces[faceNo];

                //Display the detected faces in imagebox
                CamImageBox.Image = ImageFrame;    //CamImageBox is an EmguCV imageBox

                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }

        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (faceNo < ExtFaces.Length - 1)
            {
                faceNo++;
                pbExtractedFaces.Image = ExtFaces[faceNo];
            }
            else
                MessageBox.Show("Last image!");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                pbExtractedFaces.Image = ExtFaces[faceNo];
            }
            else
                MessageBox.Show("1st image!");
        }
    }
}
