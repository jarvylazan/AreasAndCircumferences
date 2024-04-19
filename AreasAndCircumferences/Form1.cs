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
    }
}