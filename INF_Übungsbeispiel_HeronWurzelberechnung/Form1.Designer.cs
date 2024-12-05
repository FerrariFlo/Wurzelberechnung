namespace INF_Übungsbeispiel_HeronWurzelberechnung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxA = new TextBox();
            radioButtonIteration = new RadioButton();
            radioButtonFehler = new RadioButton();
            buttonBerechnen = new Button();
            labelErgebnis = new Label();
            listBoxZwischenschritte = new ListBox();
            label1 = new Label();
            textBoxIteration = new TextBox();
            textBoxFehler = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(756, 67);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(225, 43);
            textBoxA.TabIndex = 0;
            // 
            // radioButtonIteration
            // 
            radioButtonIteration.AutoSize = true;
            radioButtonIteration.Location = new Point(72, 169);
            radioButtonIteration.Name = "radioButtonIteration";
            radioButtonIteration.Size = new Size(27, 26);
            radioButtonIteration.TabIndex = 2;
            radioButtonIteration.TabStop = true;
            radioButtonIteration.UseVisualStyleBackColor = true;
            // 
            // radioButtonFehler
            // 
            radioButtonFehler.AutoSize = true;
            radioButtonFehler.Location = new Point(72, 232);
            radioButtonFehler.Name = "radioButtonFehler";
            radioButtonFehler.Size = new Size(55, 41);
            radioButtonFehler.TabIndex = 3;
            radioButtonFehler.TabStop = true;
            radioButtonFehler.Text = " ";
            radioButtonFehler.UseVisualStyleBackColor = true;
            // 
            // buttonBerechnen
            // 
            buttonBerechnen.Location = new Point(939, 195);
            buttonBerechnen.Name = "buttonBerechnen";
            buttonBerechnen.Size = new Size(169, 52);
            buttonBerechnen.TabIndex = 4;
            buttonBerechnen.Text = "Berechnen";
            buttonBerechnen.UseVisualStyleBackColor = true;
            buttonBerechnen.Click += buttonBerechnen_Click;
            // 
            // labelErgebnis
            // 
            labelErgebnis.AutoSize = true;
            labelErgebnis.Location = new Point(639, 333);
            labelErgebnis.Name = "labelErgebnis";
            labelErgebnis.Size = new Size(24, 37);
            labelErgebnis.TabIndex = 5;
            labelErgebnis.Text = " ";
            // 
            // listBoxZwischenschritte
            // 
            listBoxZwischenschritte.FormattingEnabled = true;
            listBoxZwischenschritte.ItemHeight = 37;
            listBoxZwischenschritte.Location = new Point(1152, 67);
            listBoxZwischenschritte.Name = "listBoxZwischenschritte";
            listBoxZwischenschritte.Size = new Size(398, 670);
            listBoxZwischenschritte.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(676, 37);
            label1.TabIndex = 7;
            label1.Text = "Berechne die Wurzel für folgende Zahl Näherungsweise:";
            // 
            // textBoxIteration
            // 
            textBoxIteration.Location = new Point(634, 164);
            textBoxIteration.Name = "textBoxIteration";
            textBoxIteration.Size = new Size(225, 43);
            textBoxIteration.TabIndex = 8;
            // 
            // textBoxFehler
            // 
            textBoxFehler.Location = new Point(634, 234);
            textBoxFehler.Name = "textBoxFehler";
            textBoxFehler.Size = new Size(225, 43);
            textBoxFehler.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 164);
            label2.Name = "label2";
            label2.Size = new Size(285, 37);
            label2.TabIndex = 10;
            label2.Text = "Anzahl der Iterationen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 234);
            label3.Name = "label3";
            label3.Size = new Size(450, 37);
            label3.TabIndex = 11;
            label3.Text = "Solange, bis der Fehler kleiner ist als:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 333);
            label4.Name = "label4";
            label4.Size = new Size(125, 37);
            label4.TabIndex = 12;
            label4.Text = "Ergebnis:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 847);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxFehler);
            Controls.Add(textBoxIteration);
            Controls.Add(label1);
            Controls.Add(listBoxZwischenschritte);
            Controls.Add(labelErgebnis);
            Controls.Add(buttonBerechnen);
            Controls.Add(radioButtonFehler);
            Controls.Add(radioButtonIteration);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private RadioButton radioButtonIteration;
        private RadioButton radioButtonFehler;
        private Button buttonBerechnen;
        private Label labelErgebnis;
        private ListBox listBoxZwischenschritte;
        private Label label1;
        private TextBox textBoxIteration;
        private TextBox textBoxFehler;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
