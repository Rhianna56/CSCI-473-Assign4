  
/*
  _______________________________________________________________
 /                                                               \
||  Course: CSCI-473    Assignment #: 4  Semester: Spring 2021   ||
||                                                               ||
||  NAME1:  Rhianna Eberle                 Z-ID: z1848017        ||
||                                                               ||
||  NAME2:  Dillion Chappell                 Z-ID: z1761203      ||
||                                                               ||
||  NAME3: Karen Astorga                    Z-ID: z176117        ||
||                                                               ||
||  Professor: Daniel Rogness                                    ||
||                                                               ||
||  Due: Thursday 3/18/2021 by 11:59PM                           ||
||                                                               ||
||  Description:                                                 ||
||     This file is the form file.                               ||
||                                                               ||
 \_______________________________________________________________/
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChappellEberleAstorga_Assign4
{
    public partial class Form1 : Form
    {
        private static Pen whitePen;
        private static Pen selectedPen;
        private static int xMax = 10;
        private static int xMin = -10;
        private static int yMax = 10;
        private static int yMin = -10;

        public Form1()
        {
            InitializeComponent();

            whitePen = new Pen(Color.White);
            selectedPen = new Pen(Color.White);
            //color choices
            string[] colors = { "White", "Red", "Green", "Blue" };
            linearColor.DataSource = colors;
            linearColor.BindingContext = new BindingContext();
            quadColor.DataSource = colors;
            quadColor.BindingContext = new BindingContext();
            cubicColor.DataSource = colors;
            cubicColor.BindingContext = new BindingContext();
            circleColor.DataSource = colors;
            circleColor.BindingContext = new BindingContext();

        }
        
           /* -------------------------------------------------------------------------------
        * Function: Private void Set_Bounds()
        * 
        * Use:  Creates the bounds to the graphing calulator     
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/

        private void Set_Bounds(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            xMin = Convert.ToInt32(xMinRange.Value);
            xMax = Convert.ToInt32(xMaxRange.Value);
            yMin = Convert.ToInt32(yMinRange.Value);
            yMax = Convert.ToInt32(yMaxRange.Value);

            SolidBrush paintItBlack = new SolidBrush(Color.Black);
            g.FillRectangle(paintItBlack, 0, 0, CoordinatePlane.Width, CoordinatePlane.Height);

            //Horizontal Axis
            g.DrawLine(whitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), CoordinatePlane.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical Axis
            g.DrawLine(whitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), CoordinatePlane.Height);
        }

       /* -------------------------------------------------------------------------------
        * Function: Private void Draw Axes
        * 
        * Use:  draws the horizonal and verical axis
        *
        * Parameters: object sender, PaintEventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/

        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Horizontal 
            g.DrawLine(whitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), CoordinatePlane.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical 
            g.DrawLine(whitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), CoordinatePlane.Height);

        }

 /* -------------------------------------------------------------------------------
        * Function: clearGraph()
        * 
        * Use: used to clear the graph
        *        
        * Parameters: object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/
        private void clearGraph(object sender, EventArgs e)
        {

            Graphics g = CoordinatePlane.CreateGraphics();

            xMin = Convert.ToInt32(xMinRange.Value);
            xMax = Convert.ToInt32(xMaxRange.Value);
            yMin = Convert.ToInt32(yMinRange.Value);
            yMax = Convert.ToInt32(yMaxRange.Value);

            SolidBrush paintItBlack = new SolidBrush(Color.Black);
            g.FillRectangle(paintItBlack, 0, 0, CoordinatePlane.Width, CoordinatePlane.Height);

            //Horizontal 
            g.DrawLine(whitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), CoordinatePlane.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical 
            g.DrawLine(whitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), CoordinatePlane.Height);
        }

        /* -------------------------------------------------------------------------------
        * Function: Private float convert_X_point
        * 
        * Use:  Convert the X point on the axis
        *
        * Parameters:float x
        * 
        * Returns: integer
        * -------------------------------------------------------------------------------*/
        private float Convert_X_Point(float x)
        {
            float min = (float)xMin;
            float max = (float)xMax;
            
            //if x min is lower then 0
            if (xMin < 0)
            {
                return ((x + Math.Abs(min)) * (600 / (max - min)));
            }
            //if xmin is higher then 0
            else
            {
                return (x * (600 / (max - min)));
            }

        }
        /* -------------------------------------------------------------------------------
        * Function: Private void convert_Y_point()
        * 
        * Use: to convert the y point
        *
        * Parameters:float y
        * 
        * Returns: integer
        * -------------------------------------------------------------------------------*/

        private float Convert_Y_Point(float y)
        {
            float min = (float)yMin;
            float max = (float)yMax;

            return (Math.Abs(y - max) * (600 / (max - min)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Header;

            linearColor.SelectedIndex = -1;
            quadColor.SelectedIndex = -1;
            cubicColor.SelectedIndex = -1;
            circleColor.SelectedIndex = -1;
        }

         /* -------------------------------------------------------------------------------
        * Function:  linEqHint()
        * 
        * Use: Uses the rich text area to diaplay the error message      
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: string message
        * -------------------------------------------------------------------------------*/
        private void LinEqHint(object sender, EventArgs e)
        {
             //if clear.... prints message on what to do
            displayBoxBottom.Clear();   
            string linHint = "Linear Equations (y = mx + b) where 'm' is the slope and 'b' is the y-intercept";
            displayBoxBottom.Text = linHint;
        }
         /* -------------------------------------------------------------------------------
        * Function: QuadEqHint()
        * 
        * Use: Uses the rich text area to diaplay the error message   
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: string message
        * -------------------------------------------------------------------------------*/
        private void QuadEqHint(object sender, EventArgs e)
        {
            //if clear print a message on what to do
            displayBoxBottom.Clear(); 
            string linHint = "Quadratic Equations (y = ax^2 + bx + c), where a, b, and c are real number coefficients";
            displayBoxBottom.Text = linHint;
        }
         /* -------------------------------------------------------------------------------
        * Function: CubEqHint()
        * 
        * Use: Uses the rich text area to diaplay the error message      
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: string message
        * -------------------------------------------------------------------------------*/
        private void CubEqHint(object sender, EventArgs e)
        {
            ///if clear print a message on what to do
            displayBoxBottom.Clear(); 
            string linHint = "Cubic Equations (y = ax^3 + bx^2 + cx + d), where a, b, c, and d are real number coefficients";
            displayBoxBottom.Text = linHint;
        }
         /* -------------------------------------------------------------------------------
        * Function: CirEqHint()
        * 
        * Use: Uses the rich text area to diaplay the error message    
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: string message
        * -------------------------------------------------------------------------------*/
        private void CirEqHint(object sender, EventArgs e)
        {
           //if clear print a message on what to do
            displayBoxBottom.Clear(); 
            string linHint = "Circle Equations ((x - h)^2 + (y - k)^2 = r^2 ), where (h, k) is the center of the circle, and r is the radius";
            displayBoxBottom.Text = linHint;
        }
        
            /* -------------------------------------------------------------------------------
        * Function:  private void linearGraph()
        * 
        * Use: lets a user choose a color uses the color to print out line
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: draw line
        * -------------------------------------------------------------------------------*/
        private void linearGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            //lets user select color they want to use for the equation 
            if ((string)linearColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)linearColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)linearColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)linearColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }


            float m = float.Parse(linearM.Text);
            float b = float.Parse(linearB.Text);
            float y = (float)yMax;
            float x1;
            float x2;
            float y1;
            float y2;

            if (m != 0)
            {
                y1 = y;
                x1 = (y - b) / m;

                if (x1 < (float)xMin)
                {
                    x1 = (float)xMin;
                    y1 = (m * x1) + b;
                }

                x1 = Convert_X_Point(x1);
                y1 = Convert_Y_Point(y1);

                //Find point for the second point
                y = (float)yMin;

                y2 = y;
                x2 = (y - b) / m;

                if (x2 > (float)xMax)
                {
                    x2 = (float)xMax;
                    y2 = (m * x2) + b;
                }

                x2 = Convert_X_Point(x2);
                y2 = Convert_Y_Point(y2);
            }
            else
            {
                x1 = 0;
                y1 = b;
                x2 = CoordinatePlane.Width;
                y2 = b;

                y1 = Convert_Y_Point(y1);
                y2 = Convert_Y_Point(y2);
            }
 
            //draw the line
            g.DrawLine(selectedPen, x1, y1, x2, y2);

        }
            /* -------------------------------------------------------------------------------
        * Function:  private void quadGraph()
        * 
        * Use: lets a user choose a color uses the color to print out line
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: draw line
        * -------------------------------------------------------------------------------*/
        private void quadGraph(object sender, EventArgs e)
        {                      

            Graphics g = CoordinatePlane.CreateGraphics();
             
            //lets user select color
            if ((string)quadColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)quadColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)quadColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)quadColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }
            
            //makes list
            List<PointF> pointList = new List<PointF>();   
            //gets min x makes it fit box
            float xMinR = Convert.ToSingle(xMinRange.Value); 
            //gets max x makes it fit box
            float xMaxR = Convert.ToSingle(xMaxRange.Value); 
            float AbsXMinR = Math.Abs(xMinR);
            float AbsXMaxR = Math.Abs(xMaxR);
            float scale = CoordinatePlane.Height/(AbsXMaxR+AbsXMinR);
            float a = Convert.ToSingle(quadA.Text) * scale;
            float b = Convert.ToSingle(quadB.Text) * scale;
            float c = Convert.ToSingle(quadC.Text) * scale;

            //loops through the range 
            for (float x = xMinR; x < xMaxR; x++)
            {
                //quad equation 
                float y = (a * (x * x) + (b * x + c));
                pointList.Add(new PointF((scale * AbsXMinR) + x * scale, (scale * AbsXMaxR) - y));
            }
            PointF[] pointArray = pointList.ToArray();
            //draw the curve
            g.DrawCurve(selectedPen, pointArray);            
        }
            /* -------------------------------------------------------------------------------
        * Function:   private void cubicGraph()
        * 
        * Use: lets a user choose a color uses the color to print out line
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: draw line
        * -------------------------------------------------------------------------------*/
        private void cubicGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            //lets user select color
            if ((string)cubicColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)cubicColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)cubicColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)cubicColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }
            //create list 
            List<PointF> pointList = new List<PointF>();
            //gets min x makes it fit box
            float xMinR = Convert.ToSingle(xMinRange.Value); 
             //gets max x makes it fit box
            float xMaxR = Convert.ToSingle(xMaxRange.Value); 
            //gets absolute value MinRangeX
            float AbsXMinR = Math.Abs(xMinR);
            //gets absolute value MaxRangeX
            float AbsXMaxR = Math.Abs(xMaxR);
            //gets min y makes it fit box
            float yMinR = Convert.ToSingle(yMinRange.Value); 
            //gets max y makes it fit box
            float yMaxR = Convert.ToSingle(yMaxRange.Value); 
            float AbsYMinR = Math.Abs(yMinR);
            float AbsYMaxR = Math.Abs(yMaxR);
            float scaleModX = (AbsXMinR + AbsXMaxR) / 2;
            float scaleModY = (AbsYMinR + AbsYMaxR) / 2;
            float scale = CoordinatePlane.Height / (AbsXMaxR + AbsXMinR);            
            float a = Convert.ToSingle(cubicA.Text) * scale;
            float b = Convert.ToSingle(cubicB.Text) * scale;
            float c = Convert.ToSingle(cubicC.Text) * scale;
            float d = Convert.ToSingle(cubicD.Text) * scale;                 

            //loops through the range 
            for (float x = xMinR; x < xMaxR; x++)
            {

                //cubic equation 
                float y = ((a * (x * x * x) + (b * (x * x) + (c * x) + d)));
                pointList.Add(new PointF((scale * scaleModX) + x * scale, (scale * AbsXMaxR) - y));
            }
            PointF[] pointArray = pointList.ToArray();
            //draw the curve
            g.DrawCurve(selectedPen, pointArray);

        }
            /* -------------------------------------------------------------------------------
        * Function:     private void circleGraph()
        * 
        * Use: lets a user choose a color uses the color to print out line
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: draw line
        * -------------------------------------------------------------------------------*/
        private void circleGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            //lets user select color
            if ((string)circleColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)circleColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)circleColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)circleColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }

            //gets min x and make it fit box
            float xMinR = Convert.ToSingle(xMinRange.Value); 
            //gets max x and make it fit box
            float xMaxR = Convert.ToSingle(xMaxRange.Value); 
            float AbsXMinR = Math.Abs(xMinR);
            float AbsXMaxR = Math.Abs(xMaxR);
            //gets min x and make it fit box
            float yMinR = Convert.ToSingle(yMinRange.Value); 
            //gets max x and make it fit box
            float yMaxR = Convert.ToSingle(yMaxRange.Value); 
            float AbsYMinR = Math.Abs(yMinR);
            float AbsYMaxR = Math.Abs(yMaxR);
            float scaleModX = (AbsXMinR + AbsXMaxR)/2;
            float scaleModY = (AbsYMinR + AbsYMaxR)/2;
            float scaleX = CoordinatePlane.Height / (AbsXMaxR + AbsXMinR);
            float scaleY = CoordinatePlane.Height / (AbsYMinR + AbsYMaxR);
            float h = Convert.ToSingle(circleH.Text) * scaleX;
            float k = Convert.ToSingle(circleK.Text) * scaleY;
            double tempR = Convert.ToSingle(circleR.Text);
            //fits the radius
            float r = (float)Math.Sqrt(tempR) * scaleX;
            //draws the ellipse
            g.DrawEllipse(selectedPen, h + (scaleModX * scaleX) - r, (scaleY * scaleModY) - k - r, r * 2, r * 2);

        }        
            /* -------------------------------------------------------------------------------
        * Function:   private void linearMTxtChange()
        * 
        * Use: These functions simply prevent the user from entering letters
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void linearMTxtChange(object sender, EventArgs e)
        {
            //if user enters letters
            if (System.Text.RegularExpressions.Regex.IsMatch(linearM.Text, "  ^ [0-9]"))
            {
                linearM.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void linearMKeyPress()
        * 
        * Use: 
        *
        * Parameters: object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void linearMKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void linearBTxtChange()
        * 
        * Use: 
        *
        * Parameters: object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void linearBTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(linearB.Text, "  ^ [0-9]"))
            {
                linearB.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void linearBKeyPress(
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void linearBKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void quadATxtChange(
        * 
        * Use:
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: 
        * -------------------------------------------------------------------------------*/
        private void quadATxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadA.Text, "  ^ [0-9]"))
            {
                quadA.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:   private void quadAKeyPress()
        * 
        * Use: 
        *
        * Parameters: object sender, KeyPressEventArgs e
        * 
        * Returns: 
        * -------------------------------------------------------------------------------*/
        private void quadAKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void quadBTxtChange()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: 
        * -------------------------------------------------------------------------------*/
        private void quadBTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadB.Text, "  ^ [0-9]"))
            {
                quadB.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void quadBKeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: 
        * -------------------------------------------------------------------------------*/
        private void quadBKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
             /* -------------------------------------------------------------------------------
        * Function: private void quadCTxtChange()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void quadCTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadC.Text, "  ^ [0-9]"))
            {
                quadC.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void quadCKeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void quadCKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function: private void cubicA_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void cubicA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicA.Text, "  ^ [0-9]"))
            {
                cubicA.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void cubicA_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: 
        * -------------------------------------------------------------------------------*/
        private void cubicA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function: private void cubicB_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void cubicB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicB.Text, "  ^ [0-9]"))
            {
                cubicB.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void cubicB_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void cubicB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void cubicC_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void cubicC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicC.Text, "  ^ [0-9]"))
            {
                cubicC.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void cubicC_KeyPress()
        * 
        * Use: 
        *
        * Parameters: object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void cubicC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void cubicD_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void cubicD_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicD.Text, "  ^ [0-9]"))
            {
                cubicD.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void cubicD_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void cubicD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
           /* -------------------------------------------------------------------------------
        * Function:  private void circleH_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void circleH_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleH.Text, "  ^ [0-9]"))
            {
                circleH.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function: private void circleH_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void circleH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void circleK_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void circleK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleK.Text, "  ^ [0-9]"))
            {
                circleK.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void circleK_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void circleK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
            /* -------------------------------------------------------------------------------
        * Function: private void circleR_TextChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text
        * -------------------------------------------------------------------------------*/
        private void circleR_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleR.Text, "  ^ [0-9]"))
            {
                circleR.Text = "";
            }
        }
            /* -------------------------------------------------------------------------------
        * Function: private void circleR_KeyPress()
        * 
        * Use: 
        *
        * Parameters:object sender, KeyPressEventArgs e
        * 
        * Returns: bool
        * -------------------------------------------------------------------------------*/
        private void circleR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
           /* -------------------------------------------------------------------------------
        * Function:  private void xMinChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/
        private void xMinChanged(object sender, EventArgs e)
        {
            //get int
            int min = Convert.ToInt32(xMinRange.Value); 
            int max = Convert.ToInt32(xMaxRange.Value); 

            if (min > max)
            {
                //if min ever gets larger than max then make min = max
                xMaxRange.Value = xMinRange.Value; 
            }
        }
             /* -------------------------------------------------------------------------------
        * Function:  private void xMaxChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/
        private void xMaxChanged(object sender, EventArgs e)
        {
             //get int
            int min = Convert.ToInt32(xMinRange.Value); 
            int max = Convert.ToInt32(xMaxRange.Value); 

            if (max < min)
            {
                //if min ever gets larger than max then make min = max
                xMinRange.Value = xMaxRange.Value; 
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:  private void yMinChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/
        private void yMinChanged(object sender, EventArgs e)
        {
              //get int
            int min = Convert.ToInt32(yMinRange.Value); 
            int max = Convert.ToInt32(yMaxRange.Value);

            if (min > max)
            {
                //if min ever gets larger than max then make min = max
                yMaxRange.Value = yMinRange.Value; 
            }
        }
            /* -------------------------------------------------------------------------------
        * Function:    private void yMaxChanged()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: N/A
        * -------------------------------------------------------------------------------*/
        private void yMaxChanged(object sender, EventArgs e)
        {
            //gets int 
            int min = Convert.ToInt32(yMinRange.Value); 
            int max = Convert.ToInt32(yMaxRange.Value); 

            if (min > max)
            {
                //if min ever gets larger than max then make min = max
                yMinRange.Value = yMaxRange.Value; 
            }
        }
           /* -------------------------------------------------------------------------------
        * Function: private void Coordinate_Click()
        * 
        * Use: 
        *
        * Parameters:object sender, EventArgs e
        * 
        * Returns: text 
        * -------------------------------------------------------------------------------*/
        private void Coordinate_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            MessageBox.Show("X: " + coordinates.X + " Y: " + coordinates.Y);

        }        
    }
}
