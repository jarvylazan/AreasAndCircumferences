﻿namespace AreasAndCircumferences
{
    partial class Form1
    {
        private ComboBox choiceComboBox;
        private Label choiceLabel;
        private GroupBox rectangleGroupBox;
        private GroupBox circleGroupBox;
        private GroupBox triangleGroupBox;
        private TextBox rectangleLenghtTextBox;
        private TextBox rectangleLengthTextBox;
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
            rectangleLengthLabel = new Label();
            rectangleLenghtTextBox = new TextBox();
            rectangleWidthLabel = new Label();
            rectangleLengthTextBox = new TextBox();
            circleGroupBox = new GroupBox();
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
            cri = new Button();
            rectangleGroupBox.SuspendLayout();
            circleGroupBox.SuspendLayout();
            triangleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // choiceComboBox
            // 
            choiceComboBox.FormattingEnabled = true;
            choiceComboBox.Items.AddRange(new object[] { "Triangle", "Rectangle", "Circle" });
            choiceComboBox.Location = new Point(297, 96);
            choiceComboBox.Margin = new Padding(4, 2, 4, 2);
            choiceComboBox.Name = "choiceComboBox";
            choiceComboBox.Size = new Size(234, 40);
            choiceComboBox.TabIndex = 0;
            choiceComboBox.SelectedIndexChanged += ChoiceComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Location = new Point(80, 55);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(167, 32);
            choiceLabel.TabIndex = 1;
            choiceLabel.Text = "Select a shape";
            // 
            // rectangleGroupBox
            // 
            rectangleGroupBox.Controls.Add(rectangleLengthLabel);
            rectangleGroupBox.Controls.Add(rectangleLenghtTextBox);
            rectangleGroupBox.Controls.Add(rectangleWidthLabel);
            rectangleGroupBox.Controls.Add(rectangleLengthTextBox);
            rectangleGroupBox.Location = new Point(117, 235);
            rectangleGroupBox.Margin = new Padding(4, 2, 4, 2);
            rectangleGroupBox.Name = "rectangleGroupBox";
            rectangleGroupBox.Padding = new Padding(4, 2, 4, 2);
            rectangleGroupBox.Size = new Size(362, 233);
            rectangleGroupBox.TabIndex = 2;
            rectangleGroupBox.TabStop = false;
            rectangleGroupBox.Text = "Rectangle Dimensions";
            rectangleGroupBox.Visible = false;
            // 
            // rectangleLengthLabel
            // 
            rectangleLengthLabel.AutoSize = true;
            rectangleLengthLabel.Location = new Point(41, 83);
            rectangleLengthLabel.Margin = new Padding(4, 0, 4, 0);
            rectangleLengthLabel.Name = "rectangleLengthLabel";
            rectangleLengthLabel.Size = new Size(93, 32);
            rectangleLengthLabel.TabIndex = 0;
            rectangleLengthLabel.Text = "Length:";
            // 
            // rectangleLenghtTextBox
            // 
            rectangleLenghtTextBox.Location = new Point(228, 77);
            rectangleLenghtTextBox.Margin = new Padding(4, 2, 4, 2);
            rectangleLenghtTextBox.Name = "rectangleLenghtTextBox";
            rectangleLenghtTextBox.Size = new Size(101, 39);
            rectangleLenghtTextBox.TabIndex = 1;
            // 
            // rectangleWidthLabel
            // 
            rectangleWidthLabel.AutoSize = true;
            rectangleWidthLabel.Location = new Point(41, 154);
            rectangleWidthLabel.Margin = new Padding(4, 0, 4, 0);
            rectangleWidthLabel.Name = "rectangleWidthLabel";
            rectangleWidthLabel.Size = new Size(83, 32);
            rectangleWidthLabel.TabIndex = 2;
            rectangleWidthLabel.Text = "Width:";
            // 
            // rectangleLengthTextBox
            // 
            rectangleLengthTextBox.Location = new Point(228, 147);
            rectangleLengthTextBox.Margin = new Padding(4, 2, 4, 2);
            rectangleLengthTextBox.Name = "rectangleLengthTextBox";
            rectangleLengthTextBox.Size = new Size(101, 39);
            rectangleLengthTextBox.TabIndex = 3;
            // 
            // circleGroupBox
            // 
            circleGroupBox.Controls.Add(cri);
            circleGroupBox.Controls.Add(circleRadiusLabel);
            circleGroupBox.Controls.Add(circleRadiusTextBox);
            circleGroupBox.Location = new Point(487, 235);
            circleGroupBox.Margin = new Padding(4, 2, 4, 2);
            circleGroupBox.Name = "circleGroupBox";
            circleGroupBox.Padding = new Padding(4, 2, 4, 2);
            circleGroupBox.Size = new Size(371, 233);
            circleGroupBox.TabIndex = 3;
            circleGroupBox.TabStop = false;
            circleGroupBox.Text = "Circle Dimensions";
            circleGroupBox.Visible = false;
            // 
            // circleRadiusLabel
            // 
            circleRadiusLabel.AutoSize = true;
            circleRadiusLabel.Location = new Point(33, 85);
            circleRadiusLabel.Margin = new Padding(4, 0, 4, 0);
            circleRadiusLabel.Name = "circleRadiusLabel";
            circleRadiusLabel.Size = new Size(89, 32);
            circleRadiusLabel.TabIndex = 0;
            circleRadiusLabel.Text = "Radius:";
            // 
            // circleRadiusTextBox
            // 
            circleRadiusTextBox.Location = new Point(214, 81);
            circleRadiusTextBox.Margin = new Padding(4, 2, 4, 2);
            circleRadiusTextBox.Name = "circleRadiusTextBox";
            circleRadiusTextBox.Size = new Size(101, 39);
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
            triangleGroupBox.Location = new Point(99, 493);
            triangleGroupBox.Margin = new Padding(4, 2, 4, 2);
            triangleGroupBox.Name = "triangleGroupBox";
            triangleGroupBox.Padding = new Padding(4, 2, 4, 2);
            triangleGroupBox.Size = new Size(610, 424);
            triangleGroupBox.TabIndex = 4;
            triangleGroupBox.TabStop = false;
            triangleGroupBox.Text = "Triangle Dimensions";
            triangleGroupBox.Visible = false;
            // 
            // triangleAreaLabel
            // 
            triangleAreaLabel.AutoSize = true;
            triangleAreaLabel.Location = new Point(255, 347);
            triangleAreaLabel.Name = "triangleAreaLabel";
            triangleAreaLabel.Size = new Size(0, 32);
            triangleAreaLabel.TabIndex = 10;
            // 
            // trianglePerimeterLabel
            // 
            trianglePerimeterLabel.AutoSize = true;
            trianglePerimeterLabel.Location = new Point(255, 280);
            trianglePerimeterLabel.Name = "trianglePerimeterLabel";
            trianglePerimeterLabel.Size = new Size(0, 32);
            trianglePerimeterLabel.TabIndex = 5;
            // 
            // triangleResultButton
            // 
            triangleResultButton.Location = new Point(13, 263);
            triangleResultButton.Margin = new Padding(6);
            triangleResultButton.Name = "triangleResultButton";
            triangleResultButton.Size = new Size(139, 49);
            triangleResultButton.TabIndex = 9;
            triangleResultButton.Text = "Calculate";
            triangleResultButton.UseVisualStyleBackColor = true;
            triangleResultButton.Click += ResultButton_Click;
            // 
            // triangleSideALabel
            // 
            triangleSideALabel.AutoSize = true;
            triangleSideALabel.Location = new Point(6, 64);
            triangleSideALabel.Margin = new Padding(4, 0, 4, 0);
            triangleSideALabel.Name = "triangleSideALabel";
            triangleSideALabel.Size = new Size(87, 32);
            triangleSideALabel.TabIndex = 0;
            triangleSideALabel.Text = "Side A:";
            // 
            // triangleSideATextBox
            // 
            triangleSideATextBox.Location = new Point(223, 62);
            triangleSideATextBox.Margin = new Padding(4, 2, 4, 2);
            triangleSideATextBox.Name = "triangleSideATextBox";
            triangleSideATextBox.Size = new Size(101, 39);
            triangleSideATextBox.TabIndex = 1;
            // 
            // triangleSideBLabel
            // 
            triangleSideBLabel.AutoSize = true;
            triangleSideBLabel.Location = new Point(6, 124);
            triangleSideBLabel.Margin = new Padding(4, 0, 4, 0);
            triangleSideBLabel.Name = "triangleSideBLabel";
            triangleSideBLabel.Size = new Size(86, 32);
            triangleSideBLabel.TabIndex = 2;
            triangleSideBLabel.Text = "Side B:";
            // 
            // triangleSideBTextBox
            // 
            triangleSideBTextBox.Location = new Point(223, 117);
            triangleSideBTextBox.Margin = new Padding(4, 2, 4, 2);
            triangleSideBTextBox.Name = "triangleSideBTextBox";
            triangleSideBTextBox.Size = new Size(101, 39);
            triangleSideBTextBox.TabIndex = 3;
            // 
            // triangleSideCLabel
            // 
            triangleSideCLabel.AutoSize = true;
            triangleSideCLabel.Location = new Point(6, 190);
            triangleSideCLabel.Margin = new Padding(4, 0, 4, 0);
            triangleSideCLabel.Name = "triangleSideCLabel";
            triangleSideCLabel.Size = new Size(87, 32);
            triangleSideCLabel.TabIndex = 4;
            triangleSideCLabel.Text = "Side C:";
            // 
            // triangleSideCTextBox
            // 
            triangleSideCTextBox.Location = new Point(223, 181);
            triangleSideCTextBox.Margin = new Padding(4, 2, 4, 2);
            triangleSideCTextBox.Name = "triangleSideCTextBox";
            triangleSideCTextBox.Size = new Size(101, 39);
            triangleSideCTextBox.TabIndex = 5;
            // 
            // cri
            // 
            cri.Location = new Point(33, 137);
            cri.Margin = new Padding(6);
            cri.Name = "cri";
            cri.Size = new Size(139, 49);
            cri.TabIndex = 10;
            cri.Text = "Calculate";
            cri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 928);
            Controls.Add(choiceComboBox);
            Controls.Add(choiceLabel);
            Controls.Add(rectangleGroupBox);
            Controls.Add(circleGroupBox);
            Controls.Add(triangleGroupBox);
            Margin = new Padding(4, 2, 4, 2);
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
    }
}
