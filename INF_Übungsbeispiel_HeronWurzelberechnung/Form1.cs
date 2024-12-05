namespace INF_Übungsbeispiel_HeronWurzelberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            BerechneErgebnis();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Aktivieren/Deaktivieren der TextBoxen basierend auf dem ausgewählten RadioButton
            if (radioButtonIteration.Checked)
            {
                textBoxIteration.Enabled = true;
                textBoxFehler.Enabled = false;
            }
            else if (radioButtonFehler.Checked)
            {
                textBoxFehler.Enabled = true;
                textBoxIteration.Enabled = false;
            }

            // Automatisch das Ergebnis berechnen
            BerechneErgebnis();
        }

        private void BerechneErgebnis()
        {
            try
            {
                // ListBox leeren
                listBoxZwischenschritte.Items.Clear();

                // Zahl a einlesen
                if (string.IsNullOrWhiteSpace(textBoxA.Text))
                {
                    labelErgebnis.Text = "Bitte Zahl a eingeben!";
                    return;
                }

                double a = double.Parse(textBoxA.Text);

                if (a <= 0)
                {
                    labelErgebnis.Text = "Zahl a muss größer als 0 sein!";
                    return;
                }

                // Iterationsmodus
                if (radioButtonIteration.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBoxIteration.Text))
                    {
                        labelErgebnis.Text = "Bitte Iterationsanzahl eingeben!";
                        return;
                    }

                    int iterations = int.Parse(textBoxIteration.Text);
                    double result = HeronIterationen(a, iterations);
                    labelErgebnis.Text = $"Ergebnis: {Math.Round(result, 2)}";
                }
                // Fehlermodus
                else if (radioButtonFehler.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBoxFehler.Text))
                    {
                        labelErgebnis.Text = "Bitte Fehlergrenze eingeben!";
                        return;
                    }

                    double fehler = double.Parse(textBoxFehler.Text);
                    double result = HeronFehler(a, fehler);
                    labelErgebnis.Text = $"Ergebnis: {Math.Round(result, 2)}";
                }
            }
            catch (FormatException)
            {
                labelErgebnis.Text = "Ungültige Eingabe! Bitte Zahlen verwenden.";
            }
        }

        private double HeronIterationen(double a, int steps)
        {
            double x = a / 2.0;
            for (int i = 0; i < steps; i++)
            {
                x = 0.5 * (x + a / x);
                listBoxZwischenschritte.Items.Insert(0, $"Schritt {i + 1}: {x}");
            }
            return x;
        }

        private double HeronFehler(double a, double fehler)
        {
            double x = a / 2.0;
            double lastX;
            int step = 0;
            do
            {
                lastX = x;
                x = 0.5 * (x + a / x);
                step++;
                listBoxZwischenschritte.Items.Insert(0, $"Schritt {step}: {x}");
            } while (Math.Abs(x - lastX) > fehler);
            return x;
        }

        private void textBoxIteration_TextChanged(object sender, EventArgs e)
        {
            // Fehler-TextBox deaktivieren, wenn Iterationen eingegeben werden
            textBoxFehler.Enabled = string.IsNullOrWhiteSpace(textBoxIteration.Text);
        }

        private void textBoxFehler_TextChanged(object sender, EventArgs e)
        {
            // Iterationen-TextBox deaktivieren, wenn Fehler eingegeben werden
            textBoxIteration.Enabled = string.IsNullOrWhiteSpace(textBoxFehler.Text);
        }
    }
}
