namespace NoteRearranger2
{
	partial class Form2
	{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			groupBox1 = new GroupBox();
			button3 = new Button();
			richTextBox2 = new RichTextBox();
			button2 = new Button();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label5 = new Label();
			textBox1 = new TextBox();
			groupBox2 = new GroupBox();
			richTextBox1 = new RichTextBox();
			button1 = new Button();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(richTextBox2);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(353, 5);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(342, 423);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			groupBox1.Text = "Output :";
			// 
			// button3
			// 
			button3.Location = new Point(249, 52);
			button3.Name = "button3";
			button3.Size = new Size(87, 43);
			button3.TabIndex = 17;
			button3.Text = "Refresh";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// richTextBox2
			// 
			richTextBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			richTextBox2.Location = new Point(6, 101);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.Size = new Size(331, 307);
			richTextBox2.TabIndex = 16;
			richTextBox2.Text = "";
			// 
			// button2
			// 
			button2.Location = new Point(249, 16);
			button2.Name = "button2";
			button2.Size = new Size(88, 30);
			button2.TabIndex = 15;
			button2.Text = "Save File";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(6, 62);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(85, 19);
			radioButton2.TabIndex = 14;
			radioButton2.Text = "Word Wrap";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(6, 31);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(71, 19);
			radioButton1.TabIndex = 13;
			radioButton1.TabStop = true;
			radioButton1.Text = "Raw Text";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(97, 64);
			label5.Name = "label5";
			label5.Size = new Size(70, 15);
			label5.TabIndex = 12;
			label5.Text = "Line Width :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(173, 61);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(41, 23);
			textBox1.TabIndex = 11;
			textBox1.Text = "54";
			textBox1.TextAlign = HorizontalAlignment.Right;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(richTextBox1);
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new Point(5, 5);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(342, 423);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Input :";
			// 
			// richTextBox1
			// 
			richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			richTextBox1.Location = new Point(5, 101);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(331, 307);
			richTextBox1.TabIndex = 15;
			richTextBox1.Text = "";
			// 
			// button1
			// 
			button1.Location = new Point(256, 16);
			button1.Name = "button1";
			button1.Size = new Size(80, 43);
			button1.TabIndex = 14;
			button1.Text = "Open File";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(71, 33);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 13;
			label4.Text = "label4";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(7, 33);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 12;
			label3.Text = "File Name :";
			// 
			// label2
			// 
			label2.Location = new Point(71, 64);
			label2.Name = "label2";
			label2.Size = new Size(265, 34);
			label2.TabIndex = 11;
			label2.Text = "label2";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(7, 64);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 10;
			label1.Text = "File Path :";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(702, 433);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Form2";
			Text = "Form2";
			FormClosing += Form2_Closing;
			FormClosed += Form2_Closed;
			Load += Form2_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox groupBox1;
		private Button button2;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Label label5;
		private TextBox textBox1;
		private RichTextBox richTextBox2;
		private GroupBox groupBox2;
		private RichTextBox richTextBox1;
		private Button button1;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button3;
	}
}