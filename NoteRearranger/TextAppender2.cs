using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteRearranger2
{
	internal class TextAppender2 : IDisposable
	{
		StringBuilder sb;

		int line_per_page = 25;

		public string Text { get => sb.ToString(); }
		public TextAppender2()
		{
			sb = new StringBuilder();
			sb.Clear();
		}
		public void Dispose() { sb.Clear(); sb = null; }

		public void ReadText(string text)
		{
			string[] lines = text.Split("\n");
			foreach (string line in lines)
			{
				Append(line);
			}
		}
		public void Append(string text)
		{
			if (string.IsNullOrEmpty(text)) return;

			string s = text;// .Trim();

			if (s.Length < 16) return;

			string[] ss = { "", "" };

			ss[0] = s.Substring(0, 12).Trim();
			ss[1] = s.Substring(15).Trim();

			if (isNumeric(ss[0]))
				if (!string.IsNullOrEmpty(ss[1]))
				{
					if (ss[1].StartsWith("Q.") || ss[1].StartsWith("A."))
						s = (sb.Length == 0 ? "" : "\r\n") + ss[1] + "  ";
					else
						s = ss[1] + " ";

					sb.Append(s);
				}
		}
		private bool isNumeric(string value)
		{
			if (string.IsNullOrEmpty(value)) return false;
			return Regex.IsMatch(value, @"^[-+]?[0-9]*\.?[0-9]+$");
		}
		public string WordWrap(int lineWidth = 55)
		{
			if (lineWidth < 20 || lineWidth > 80) lineWidth = 55;

			StringBuilder sb2 = new StringBuilder();

			int[] pos = { 0, 0, 0 };
			string t;
			try
			{
				do
				{
					//Debug.WriteLine("123456789.123456789.123456789.123456789.123456789.12345");

					pos[2] = Text.IndexOf("\n", pos[0]);
					if (pos[2] < 0) pos[2] = sb.Length - 1;

					pos[1] = pos[0] + lineWidth - 1; // hello, world

					if (pos[2] < pos[1])
					{
						t = Text.Substring(pos[0], pos[2] - pos[0] + 1);
						sb2.Append(t);
						pos[0] = pos[2] + 1;
					}
					else
					{
						bool flag = false;
						string s = "";

						pos[1]++;
						do
						{
							pos[1]--;
							s = Text.Substring(pos[1], 1);
							flag = s == " " || s == "\n" || s == "\r";
						}
						while (!flag && pos[1] > 0);

						if (flag)
						{
							t = Text.Substring(pos[0], pos[1] - pos[0] + 1);
							sb2.AppendLine(t);
							pos[0] = pos[1] + 1;
						}
					}

				} while (pos[0] < sb.Length && pos[0] > -1);
			}
			catch (Exception ex)
			{
				string x = ex.Message;
				sb2.Clear();
			}

			return sb2.ToString();
		}
		public string Print(int lineWidth = 55)
		{
			StringBuilder sb2 = new StringBuilder();
			string[] lines = WordWrap(lineWidth).Split("\n");

			int lineNo = 0;
			int pageNo = 0;
			bool newPage = true;

			sb2.Append("\r\n");

			foreach (string line in lines)
			{
				if (newPage)
				{
					pageNo++;
					sb2.Append(getHeader(pageNo));
					newPage = false;
					lineNo = 0;
				}

				lineNo++;
				sb2.Append($"{lineNo,12}   {line}\n");

				if (lineNo >= line_per_page)
				{
					sb2.Append(getFooter());
					newPage = true;
				}
				else
				{
					sb2.Append("\r\n");
				}
			}

			return sb2.ToString();
		}
		private string getHeader(int pageNo) => $"\f{pageNo,58}\r\n\r\n\r\n";
		private string getFooter() => "\r\n";


	}
}
