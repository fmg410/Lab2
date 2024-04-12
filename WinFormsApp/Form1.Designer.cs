namespace WinFormsApp
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            listBoxPokemon = new ListBox();
            button2 = new Button();
            button3 = new Button();
            searchPokemon = new TextBox();
            label1 = new Label();
            labelName = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(654, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(497, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Wyszukaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxPokemon
            // 
            listBoxPokemon.AccessibleName = "";
            listBoxPokemon.FormattingEnabled = true;
            listBoxPokemon.ItemHeight = 15;
            listBoxPokemon.Location = new Point(34, 31);
            listBoxPokemon.Name = "listBoxPokemon";
            listBoxPokemon.Size = new Size(189, 349);
            listBoxPokemon.TabIndex = 2;
            listBoxPokemon.SelectedIndexChanged += listBoxPokemon_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(687, 315);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Usuń wpis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(640, 357);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 4;
            button3.Text = "Wyczyść pokedex";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // searchPokemon
            // 
            searchPokemon.Location = new Point(284, 31);
            searchPokemon.Name = "searchPokemon";
            searchPokemon.Size = new Size(177, 23);
            searchPokemon.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 107);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Nazwa:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(403, 107);
            labelName.Name = "labelName";
            labelName.Size = new Size(58, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Pokemon";
            // 
            // button4
            // 
            button4.Location = new Point(687, 286);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Przykładowe";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(labelName);
            Controls.Add(label1);
            Controls.Add(searchPokemon);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBoxPokemon);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBoxPokemon;
        private Button button2;
        private Button button3;
        private TextBox searchPokemon;
        private Label label1;
        private Label labelName;
        private Button button4;
    }
}
