namespace Tugas_Week_3
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textquiz = new TextBox();
            textStatus = new TextBox();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textquiz);
            flowLayoutPanel1.Controls.Add(textStatus);
            flowLayoutPanel1.Controls.Add(buttonA);
            flowLayoutPanel1.Controls.Add(buttonB);
            flowLayoutPanel1.Controls.Add(buttonC);
            flowLayoutPanel1.Controls.Add(buttonD);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textquiz
            // 
            textquiz.Location = new Point(3, 3);
            textquiz.Name = "textquiz";
            textquiz.Size = new Size(377, 39);
            textquiz.TabIndex = 1;
            textquiz.Text = "6 + 4 x 5 = . . .";
            // 
            // textStatus
            // 
            textStatus.Location = new Point(386, 3);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(319, 39);
            textStatus.TabIndex = 2;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(3, 48);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(704, 46);
            buttonA.TabIndex = 3;
            buttonA.Text = "A . 26";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(3, 100);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(704, 46);
            buttonB.TabIndex = 4;
            buttonB.Text = "B. IDK";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(3, 152);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(704, 46);
            buttonC.TabIndex = 5;
            buttonC.Text = "C. 10";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(3, 204);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(704, 46);
            buttonD.TabIndex = 6;
            buttonD.Text = "D. 50";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textquiz;
        private TextBox textStatus;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
    }
}
