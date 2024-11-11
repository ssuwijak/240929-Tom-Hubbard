using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteRearranger2
{
	public partial class Form2 : Form
	{
		private TextAppender2 ap;
		public Form2()
		{
			InitializeComponent();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			this.Text = Application.ProductName;
			ap = new TextAppender2();
			label2.Text = "";
			label4.Text = "";
			groupBox1.Enabled = false;
		}
		private void Form2_Closing(object sender, FormClosingEventArgs e)
		{
			ap.Dispose();
			ap = null;
		}
		private void Form2_Closed(object sender, FormClosedEventArgs e)
		{

		}
		private (bool, string) fileExists(string filePath)
		{
			bool ret = false;

			if (string.IsNullOrEmpty(filePath)) return (ret, "");

			string p = filePath.Trim();
			if (string.IsNullOrEmpty(p)) return (ret, p);

			ret = File.Exists(p);

			return (ret, p);
		}
		private string openFileDialog(string path = "")
		{
			string selectedFilePath = "";

			if (string.IsNullOrEmpty(path.Trim())) path = Environment.CurrentDirectory;
			string filters = "Text files (*.txt)|*.txt|Log files|*.log|All files (*.*)|*.*";

			OpenFileDialog openFileDialog1 = new OpenFileDialog();


			openFileDialog1.InitialDirectory = Path.GetDirectoryName(path);
			openFileDialog1.Filter = filters;
			// openFileDialog.Title = title;
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = true;

			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				selectedFilePath = openFileDialog1.FileName;

			return selectedFilePath;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			string s = openFileDialog(label2.Text);
			if (!string.IsNullOrEmpty(s))
			{
				label2.Text = s;
				label4.Text = Path.GetFileName(s);

				StringBuilder sb = new StringBuilder();
				sb.Clear();
				sb.Append(File.ReadAllText(s));

				ap.ReadText(sb.ToString());

				richTextBox1.Clear();
				richTextBox1.Text = sb.ToString();

				rearrange();

				groupBox1.Enabled = label2.Text != "";
			}
		}

		private void rearrange()
		{
			richTextBox2.Clear();

			if (radioButton1.Checked)
				richTextBox2.Text = ap.Text;
			else
			{
				bool ret = false;
				int w = 0;

				(ret, w) = isInteger(textBox1.Text.Trim(), 54);

				if (ret)
					w = int.Parse(textBox1.Text.Trim());

				textBox1.Text = w.ToString();

				richTextBox2.Text = ap.Print(w);
			}
			if (ap.Text.Length < 1)
			{
				richTextBox2.Clear();
				richTextBox2.Text = $"unable to read and re-arrange this file,\n\n'{label4.Text}'";
			}
		}
		private (bool, int) isInteger(string value, int notIntReturn = 0)
		{
			bool ret = false;
			int i = notIntReturn;

			value = value.Trim();
			if (string.IsNullOrEmpty(value)) return (ret, notIntReturn);

			ret = int.TryParse(value, out i);

			return (ret, i);
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			rearrange();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			rearrange();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			rearrange();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string path = Path.GetDirectoryName(label2.Text);
			string fileName = "rearrange_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".txt";
			string filePath = Path.Combine(path, fileName);

			string msg = "do you want to save the result as a file ?\n\n" + filePath;

			DialogResult ans = MessageBox.Show(msg, "Save the result", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

			if (ans == DialogResult.Yes)
			{
				try
				{
					File.WriteAllText(filePath, richTextBox2.Text);
					MessageBox.Show("save file complete", "Save the result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("save file failed\n\n" + ex.Message, "Save the result", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}



		}
	}
}
