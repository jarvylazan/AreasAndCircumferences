namespace AreasAndCircumferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void ChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all group boxes initially
            this.rectangleGroupBox.Visible = false;
            this.circleGroupBox.Visible = false;
            this.triangleGroupBox.Visible = false;

            // Show the corresponding group box based on the selection
            switch (this.choiceComboBox.SelectedItem.ToString())
            {
                case "Rectangle":
                    this.rectangleGroupBox.Visible = true;
                    break;
                case "Circle":
                    this.circleGroupBox.Visible = true;
                    break;
                case "Triangle":
                    this.triangleGroupBox.Visible = true;
                    break;
            }
        }

        private void TriangleResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(this.triangleSideATextBox.Text);
                double side2 = double.Parse(this.triangleSideBTextBox.Text);
                double side3 = double.Parse(this.triangleSideCTextBox.Text);
                Triangle triangle = new Triangle(side1, side2, side3);
                this.triangleAreaLabel.Text = "Area: " + triangle.Area();
                this.trianglePerimeterLabel.Text = "Perimeter: " + triangle.Perimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RectangleResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(this.rectangleLenghtTextBox.Text);
                double width = double.Parse(this.rectangleWidthTextBox.Text);
                Rectangle rectangle = new Rectangle(length, width);
                this.rectangleAreaLabel.Text = "Area: " + rectangle.Area();
                this.rectanglePerimeterLabel.Text = "Perimeter: " + rectangle.Perimeter();
                this.trianglePerimeterLabel.Text = "Perimeter: " + triangle.Perimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CircleResultLabel_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(this.circleRadiusTextBox.Text);

                Circle circle = new Circle(radius);

                this.circleAreaLabel.Text = "Area: " + Math.Round(circle.Area(), 2);

                this.circumferenceLabel.Text = "Circumference: " + Math.Round(circle.Perimeter(), 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}