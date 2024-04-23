namespace AreasAndCircumferences
{
    partial class Form1
    {
        private ComboBox choiceComboBox;
        private Label choiceLabel;
        private GroupBox rectangleGroupBox;
        private GroupBox circleGroupBox;
        private GroupBox triangleGroupBox;
        private TextBox rectangleLenghtTextBox;
        private TextBox rectangleWidthTextBox;
        private TextBox circleRadiusTextBox;
        private TextBox triangleSideATextBox;
        private TextBox triangleSideBTextBox;
        private TextBox triangleSideCTextBox;
        private Label rectangleLengthLabel;
        private Label rectangleWidthLabel;
        private Label circleRadiusLabel;
        private Label triangleSideALabel;
        private Label triangleSideBLabel;
        private Label triangleSideCLabel;

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
            choiceComboBox = new ComboBox();
            choiceLabel = new Label();
            rectangleGroupBox = new GroupBox();
            rectangleAreaLabel = new Label();
            rectanglePerimeterLabel = new Label();
            rectangleResultButton = new Button();
            rectangleLengthLabel = new Label();
            rectangleLenghtTextBox = new TextBox();
            rectangleWidthLabel = new Label();
            rectangleWidthTextBox = new TextBox();
            circleGroupBox = new GroupBox();
            cri = new Button();
            circleRadiusLabel = new Label();
            circleRadiusTextBox = new TextBox();
            triangleGroupBox = new GroupBox();
            triangleAreaLabel = new Label();
            trianglePerimeterLabel = new Label();
            triangleResultButton = new Button();
            triangleSideALabel = new Label();
            triangleSideATextBox = new TextBox();
            triangleSideBLabel = new Label();
            triangleSideBTextBox = new TextBox();
            triangleSideCLabel = new Label();
            triangleSideCTextBox = new TextBox();
            rectangleGroupBox.SuspendLayout();
            circleGroupBox.SuspendLayout();
            triangleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // choiceComboBox
            // 
            choiceComboBox.FormattingEnabled = true;
            choiceComboBox.Items.AddRange(new object[] { "Triangle", "Rectangle", "Circle" });
            choiceComboBox.Location = new Point(160, 45);
            choiceComboBox.Margin = new Padding(2, 1, 2, 1);
            choiceComboBox.Name = "choiceComboBox";
            choiceComboBox.Size = new Size(128, 23);
            choiceComboBox.TabIndex = 0;
            choiceComboBox.SelectedIndexChanged += ChoiceComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Location = new Point(43, 26);
            choiceLabel.Margin = new Padding(2, 0, 2, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(81, 15);
            choiceLabel.TabIndex = 1;
            choiceLabel.Text = "Select a shape";
            // 
            // rectangleGroupBox
            // 
            rectangleGroupBox.Controls.Add(rectangleAreaLabel);
            rectangleGroupBox.Controls.Add(rectanglePerimeterLabel);
            rectangleGroupBox.Controls.Add(rectangleResultButton);
            rectangleGroupBox.Controls.Add(rectangleLengthLabel);
            rectangleGroupBox.Controls.Add(rectangleLenghtTextBox);
            rectangleGroupBox.Controls.Add(rectangleWidthLabel);
            rectangleGroupBox.Controls.Add(rectangleWidthTextBox);
            rectangleGroupBox.Location = new Point(11, 70);
            rectangleGroupBox.Margin = new Padding(2, 1, 2, 1);
            rectangleGroupBox.Name = "rectangleGroupBox";
            rectangleGroupBox.Padding = new Padding(2, 1, 2, 1);
            rectangleGroupBox.Size = new Size(277, 159);
            rectangleGroupBox.TabIndex = 2;
            rectangleGroupBox.TabStop = false;
            rectangleGroupBox.Text = "Rectangle Dimensions";
            rectangleGroupBox.Visible = false;
            // 
            // rectangleAreaLabel
            // 
            rectangleAreaLabel.AutoSize = true;
            rectangleAreaLabel.Location = new Point(144, 135);
            rectangleAreaLabel.Name = "rectangleAreaLabel";
            rectangleAreaLabel.Size = new Size(0, 15);
            rectangleAreaLabel.TabIndex = 6;
            // 
            // rectanglePerimeterLabel
            // 
            rectanglePerimeterLabel.AutoSize = true;
            rectanglePerimeterLabel.Location = new Point(144, 105);
            rectanglePerimeterLabel.Name = "rectanglePerimeterLabel";
            rectanglePerimeterLabel.Size = new Size(0, 15);
            rectanglePerimeterLabel.TabIndex = 5;
            // 
            // rectangleResultButton
            // 
            rectangleResultButton.Location = new Point(38, 115);
            rectangleResultButton.Name = "rectangleResultButton";
            rectangleResultButton.Size = new Size(75, 23);
            rectangleResultButton.TabIndex = 4;
            rectangleResultButton.Text = "Calculate";
            rectangleResultButton.UseVisualStyleBackColor = true;
            rectangleResultButton.Click += RectangleResultButton_Click;
            // 
            // rectangleLengthLabel
            // 
            rectangleLengthLabel.AutoSize = true;
            rectangleLengthLabel.Location = new Point(22, 39);
            rectangleLengthLabel.Margin = new Padding(2, 0, 2, 0);
            rectangleLengthLabel.Name = "rectangleLengthLabel";
            rectangleLengthLabel.Size = new Size(47, 15);
            rectangleLengthLabel.TabIndex = 0;
            rectangleLengthLabel.Text = "Length:";
            // 
            // rectangleLenghtTextBox
            // 
            rectangleLenghtTextBox.Location = new Point(123, 36);
            rectangleLenghtTextBox.Margin = new Padding(2, 1, 2, 1);
            rectangleLenghtTextBox.Name = "rectangleLenghtTextBox";
            rectangleLenghtTextBox.Size = new Size(56, 23);
            rectangleLenghtTextBox.TabIndex = 1;
            // 
            // rectangleWidthLabel
            // 
            rectangleWidthLabel.AutoSize = true;
            rectangleWidthLabel.Location = new Point(22, 72);
            rectangleWidthLabel.Margin = new Padding(2, 0, 2, 0);
            rectangleWidthLabel.Name = "rectangleWidthLabel";
            rectangleWidthLabel.Size = new Size(42, 15);
            rectangleWidthLabel.TabIndex = 2;
            rectangleWidthLabel.Text = "Width:";
            // 
            // rectangleWidthTextBox
            // 
            rectangleWidthTextBox.Location = new Point(123, 69);
            rectangleWidthTextBox.Margin = new Padding(2, 1, 2, 1);
            rectangleWidthTextBox.Name = "rectangleWidthTextBox";
            rectangleWidthTextBox.Size = new Size(56, 23);
            rectangleWidthTextBox.TabIndex = 3;
            // 
            // circleGroupBox
            // 
            circleGroupBox.Controls.Add(cri);
            circleGroupBox.Controls.Add(circleRadiusLabel);
            circleGroupBox.Controls.Add(circleRadiusTextBox);
            circleGroupBox.Location = new Point(296, 81);
            circleGroupBox.Margin = new Padding(2, 1, 2, 1);
            circleGroupBox.Name = "circleGroupBox";
            circleGroupBox.Padding = new Padding(2, 1, 2, 1);
            circleGroupBox.Size = new Size(200, 109);
            circleGroupBox.TabIndex = 3;
            circleGroupBox.TabStop = false;
            circleGroupBox.Text = "Circle Dimensions";
            circleGroupBox.Visible = false;
            // 
            // cri
            // 
            cri.Location = new Point(18, 64);
            cri.Name = "cri";
            cri.Size = new Size(75, 23);
            cri.TabIndex = 10;
            cri.Text = "Calculate";
            cri.UseVisualStyleBackColor = true;
            // 
            // circleRadiusLabel
            // 
            circleRadiusLabel.AutoSize = true;
            circleRadiusLabel.Location = new Point(18, 40);
            circleRadiusLabel.Margin = new Padding(2, 0, 2, 0);
            circleRadiusLabel.Name = "circleRadiusLabel";
            circleRadiusLabel.Size = new Size(45, 15);
            circleRadiusLabel.TabIndex = 0;
            circleRadiusLabel.Text = "Radius:";
            // 
            // circleRadiusTextBox
            // 
            circleRadiusTextBox.Location = new Point(115, 38);
            circleRadiusTextBox.Margin = new Padding(2, 1, 2, 1);
            circleRadiusTextBox.Name = "circleRadiusTextBox";
            circleRadiusTextBox.Size = new Size(56, 23);
            circleRadiusTextBox.TabIndex = 1;
            // 
            // triangleGroupBox
            // 
            triangleGroupBox.Controls.Add(triangleAreaLabel);
            triangleGroupBox.Controls.Add(trianglePerimeterLabel);
            triangleGroupBox.Controls.Add(triangleResultButton);
            triangleGroupBox.Controls.Add(triangleSideALabel);
            triangleGroupBox.Controls.Add(triangleSideATextBox);
            triangleGroupBox.Controls.Add(triangleSideBLabel);
            triangleGroupBox.Controls.Add(triangleSideBTextBox);
            triangleGroupBox.Controls.Add(triangleSideCLabel);
            triangleGroupBox.Controls.Add(triangleSideCTextBox);
            triangleGroupBox.Location = new Point(53, 231);
            triangleGroupBox.Margin = new Padding(2, 1, 2, 1);
            triangleGroupBox.Name = "triangleGroupBox";
            triangleGroupBox.Padding = new Padding(2, 1, 2, 1);
            triangleGroupBox.Size = new Size(328, 199);
            triangleGroupBox.TabIndex = 4;
            triangleGroupBox.TabStop = false;
            triangleGroupBox.Text = "Triangle Dimensions";
            triangleGroupBox.Visible = false;
            // 
            // triangleAreaLabel
            // 
            triangleAreaLabel.AutoSize = true;
            triangleAreaLabel.Location = new Point(137, 163);
            triangleAreaLabel.Margin = new Padding(2, 0, 2, 0);
            triangleAreaLabel.Name = "triangleAreaLabel";
            triangleAreaLabel.Size = new Size(0, 15);
            triangleAreaLabel.TabIndex = 10;
            // 
            // trianglePerimeterLabel
            // 
            trianglePerimeterLabel.AutoSize = true;
            trianglePerimeterLabel.Location = new Point(137, 131);
            trianglePerimeterLabel.Margin = new Padding(2, 0, 2, 0);
            trianglePerimeterLabel.Name = "trianglePerimeterLabel";
            trianglePerimeterLabel.Size = new Size(0, 15);
            trianglePerimeterLabel.TabIndex = 5;
            // 
            // triangleResultButton
            // 
            triangleResultButton.Location = new Point(7, 123);
            triangleResultButton.Name = "triangleResultButton";
            triangleResultButton.Size = new Size(75, 23);
            triangleResultButton.TabIndex = 9;
            triangleResultButton.Text = "Calculate";
            triangleResultButton.UseVisualStyleBackColor = true;
            triangleResultButton.Click += TriangleResultButton_Click;
            // 
            // triangleSideALabel
            // 
            triangleSideALabel.AutoSize = true;
            triangleSideALabel.Location = new Point(3, 30);
            triangleSideALabel.Margin = new Padding(2, 0, 2, 0);
            triangleSideALabel.Name = "triangleSideALabel";
            triangleSideALabel.Size = new Size(43, 15);
            triangleSideALabel.TabIndex = 0;
            triangleSideALabel.Text = "Side A:";
            // 
            // triangleSideATextBox
            // 
            triangleSideATextBox.Location = new Point(120, 29);
            triangleSideATextBox.Margin = new Padding(2, 1, 2, 1);
            triangleSideATextBox.Name = "triangleSideATextBox";
            triangleSideATextBox.Size = new Size(56, 23);
            triangleSideATextBox.TabIndex = 1;
            // 
            // triangleSideBLabel
            // 
            triangleSideBLabel.AutoSize = true;
            triangleSideBLabel.Location = new Point(3, 58);
            triangleSideBLabel.Margin = new Padding(2, 0, 2, 0);
            triangleSideBLabel.Name = "triangleSideBLabel";
            triangleSideBLabel.Size = new Size(42, 15);
            triangleSideBLabel.TabIndex = 2;
            triangleSideBLabel.Text = "Side B:";
            // 
            // triangleSideBTextBox
            // 
            triangleSideBTextBox.Location = new Point(120, 55);
            triangleSideBTextBox.Margin = new Padding(2, 1, 2, 1);
            triangleSideBTextBox.Name = "triangleSideBTextBox";
            triangleSideBTextBox.Size = new Size(56, 23);
            triangleSideBTextBox.TabIndex = 3;
            // 
            // triangleSideCLabel
            // 
            triangleSideCLabel.AutoSize = true;
            triangleSideCLabel.Location = new Point(3, 89);
            triangleSideCLabel.Margin = new Padding(2, 0, 2, 0);
            triangleSideCLabel.Name = "triangleSideCLabel";
            triangleSideCLabel.Size = new Size(43, 15);
            triangleSideCLabel.TabIndex = 4;
            triangleSideCLabel.Text = "Side C:";
            // 
            // triangleSideCTextBox
            // 
            triangleSideCTextBox.Location = new Point(120, 85);
            triangleSideCTextBox.Margin = new Padding(2, 1, 2, 1);
            triangleSideCTextBox.Name = "triangleSideCTextBox";
            triangleSideCTextBox.Size = new Size(56, 23);
            triangleSideCTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 435);
            Controls.Add(choiceComboBox);
            Controls.Add(choiceLabel);
            Controls.Add(rectangleGroupBox);
            Controls.Add(circleGroupBox);
            Controls.Add(triangleGroupBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Areas and Circumferences";
            rectangleGroupBox.ResumeLayout(false);
            rectangleGroupBox.PerformLayout();
            circleGroupBox.ResumeLayout(false);
            circleGroupBox.PerformLayout();
            triangleGroupBox.ResumeLayout(false);
            triangleGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button triangleResultButton;
        private Label trianglePerimeterLabel;
        private Label triangleAreaLabel;
        private Button cri;
        private Label rectangleAreaLabel;
        private Label rectanglePerimeterLabel;
        private Button rectangleResultButton;
    }
}
