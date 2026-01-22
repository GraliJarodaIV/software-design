namespace BubbleSort
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
            beforeSort = new ListBox();
            button1 = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // beforeSort
            // 
            beforeSort.FormattingEnabled = true;
            beforeSort.Location = new Point(281, 54);
            beforeSort.Name = "beforeSort";
            beforeSort.Size = new Size(220, 229);
            beforeSort.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(55, 54);
            button1.Name = "button1";
            button1.Size = new Size(204, 120);
            button1.TabIndex = 1;
            button1.Text = "Bubble Sort!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(507, 54);
            listBox.Name = "listBox";
            listBox.Size = new Size(212, 229);
            listBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(beforeSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox beforeSort;
        private Button button1;
        private ListBox listBox;
    }
}
