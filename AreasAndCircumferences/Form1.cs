namespace AreasAndCircumferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all group boxes initially
            rectangleGroupBox.Visible = false;
            circleGroupBox.Visible = false;
            triangleGroupBox.Visible = false;

            // Show the corresponding group box based on the selection
            switch (choiceComboBox.SelectedItem.ToString())
            {
                case "Rectangle":
                    rectangleGroupBox.Visible = true;
                    break;
                case "Circle":
                    circleGroupBox.Visible = true;
                    break;
                case "Triangle":
                    triangleGroupBox.Visible = true;
                    break;
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(triangleSideATextBox.Text);
                double side2 = double.Parse(triangleSideBTextBox.Text);
                double side3 = double.Parse(triangleSideCTextBox.Text);
                Triangle triangle = new Triangle(side1, side2, side3);
                areaLabel.Text = "Area: " + triangle.Area();
                circumferenceLabel.Text = "Circumference: " + triangle.Circumference();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}