using System.Drawing.Configuration;

namespace Rock___Paper___Scissor;

partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CreateLabels();
        CreateButtons();
    }

    // Tạo và thiết lập các Label
    private void CreateLabels()
    {
        List<(string Text, System.Drawing.Point Location)> labels = new List<(string, System.Drawing.Point)>
        {
            ("Your score", new System.Drawing.Point(50, 100)),
            ("Computer's score", new System.Drawing.Point(600, 101)),
            ("Your choice", new System.Drawing.Point(325, 180)),
            ("Computer's choice", new System.Drawing.Point(300, 5))
        };

        foreach (var (text, location) in labels)
        {
            Label listLabel = new Label
            {
                Text = text,
                Location = location,
                Size = new System.Drawing.Size(200, 30),
                Font = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold),
                AutoSize = false,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            };

            Controls.Add(listLabel);
        }
    }

    // Tạo và thiết lập các Button
    private void CreateButtons()
    {
        List<(string Text, System.Drawing.Point Location, System.Drawing.Color Color)> buttons = new List<(string, System.Drawing.Point, System.Drawing.Color)>
        {
            ("Rock", new System.Drawing.Point(75, 350), System.Drawing.Color.SlateGray),
            ("Paper", new System.Drawing.Point(325, 350), System.Drawing.Color.SlateGray),
            ("Scissor", new System.Drawing.Point(575, 350), System.Drawing.Color.SlateGray)
        };

        foreach (var (text, location, color) in buttons)
        {
            var button = CreateButton(text, location, color);
            button.Click += (sender, e) => MessageBox.Show($"You clicked {text}!");
            Controls.Add(button);
        }
    }

    private Button CreateButton(string text, System.Drawing.Point location, System.Drawing.Color color)
    {
        return new Button
        {
            Text = text,
            Size = new System.Drawing.Size(100, 50),
            Location = location,
            BackColor = color
        };
    }
}