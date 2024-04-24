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
            // Hide all group boxes initially, reset the textboxes and result labels.
            this.rectangleGroupBox.Hide();
            this.circleGroupBox.Hide();
            this.triangleGroupBox.Hide();

            this.rectangleLengthTextBox.Text = string.Empty;
            this.rectangleWidthTextBox.Text = string.Empty;
            this.triangleSideATextBox.Text = string.Empty;
            this.triangleSideBTextBox.Text = string.Empty;
            this.triangleSideCTextBox.Text = string.Empty;
            this.rectangleAreaLabel.Text = string.Empty;
            this.rectanglePerimeterLabel.Text = string.Empty;
            this.circleAreaLabel.Text = string.Empty;
            this.circumferenceLabel.Text = string.Empty;
            this.triangleAreaLabel.Text = string.Empty;
            this.trianglePerimeterLabel.Text = string.Empty;

            // Show the corresponding group box based on the selection
            switch (this.choiceComboBox.SelectedItem.ToString())
            {
                case "Rectangle":
                    this.rectangleGroupBox.Show();
                    break;
                case "Circle":
                    this.circleGroupBox.Show();
                    break;
                case "Triangle":
                    this.triangleGroupBox.Show();
                    break;
            }
        }

        // Calculate triangle area and perimeter
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

        // Calculate rectangle area and perimeter
        private void RectangleResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(this.rectangleLengthTextBox.Text);
                double width = double.Parse(this.rectangleWidthTextBox.Text);
                Rectangle rectangle = new Rectangle(length, width);
                this.rectangleAreaLabel.Text = "Area: " + rectangle.Area();
                this.rectanglePerimeterLabel.Text = "Perimeter: " + rectangle.Perimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculate circle area and circumference
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