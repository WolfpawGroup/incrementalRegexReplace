using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace incrementalRegexReplace
{
	public static class myRegex
	{
		public static bool checkValidRegex(string text)
		{
			try
			{
				Regex r = new Regex(text, RegexOptions.ExplicitCapture | RegexOptions.Multiline | RegexOptions.Singleline);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public static bool hasToken(string regex)
		{
			if (checkValidRegex(regex))
			{
				Regex r = new Regex(regex);
				string[] stra = r.GetGroupNames();
				if (stra.Length > 0)
				{
					if (stra.Contains(getTokenCaptureName()))
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			return false;
		}

		/// <summary>
		/// <para>Finds and returns location of token</para>
		/// <para>Returns: {0,0,0} if not found, otherwise {Start|End|Length}</para>
		/// </summary>
		/// <param name="regex">Regex to check</param>
		/// <returns>{0,0,0} if not found, otherwise {Start|End|Length}</returns>
		public static int[] giveTokenLocation(string regex)
		{
			int[] ret = new int[3] { 0, 0, 0 };

			if (checkValidRegex(regex))
			{
				string tok = getTokenCaptureName();
				Regex r = new Regex($@"(?<start>\(\?<{ tok }>)(?<word>((\\\)?|\\\(?)+.*?)(?<end>\))(?<!\\\)))");
				if (r.IsMatch(regex))
				{
					var m = r.Match(regex);
					int s = m.Index;
					int e = m.Index + m.Length;
					int l = m.Length;
					ret[0] = s;
					ret[1] = e;
					ret[2] = l;
				}
				else
				{
					int s = regex.IndexOf($"(?<{ tok }>");
					int e = findFirstUnmatchedClosingBrace(regex.Substring(s + 1) + 1);
					ret[0] = s;
					ret[1] = s + e;
					ret[2] = e;
				}
			}
			
			return ret;
		}

		public static int findFirstUnmatchedClosingBrace(string input)
		{
			int ret = -1;

			int parity = 0;

			for(int i = 0; i < input.Length; i++)
			{
				if(i > 0 && input[i-1] != '\\')
				{
					if(input[i] == '(')
					{
						parity++;
					}
					else if(input[i] == ')')
					{
						parity--;

						if(parity < 0)
						{
							ret = i;
							break;
						}
					}
				}
				else if(i == 0 && input[i] == ')')
				{
					ret = 0;
					break;
				}
				else if (i == 0 && input[i] == '(')
				{
					parity++;
				}
				
			}

			return ret;
		}

		public static string getTokenCaptureName()
		{
			string s = Properties.Resources._s_CaptureToken;
			s = s.Substring(3);
			s = s.Substring(0, s.IndexOf(">"));
			return s;
		}

		public static string replaceRegex(string input, string regEx, int initialNum, int incrementBy, int padTo)
		{
			string ip = input;

			int num = initialNum;
			int inc = incrementBy;
			int pt = padTo;
			string generatedReplacementNumber = "";

			Regex r = new Regex(regEx, RegexOptions.Singleline | RegexOptions.ExplicitCapture);
			int index = 0;
			int len = 0;
			string token = getTokenCaptureName();
			try
			{
				while (r.IsMatch(ip, index))
				{
					generatedReplacementNumber = (num + "").PadLeft(pt, '0');

					Match m = r.Match(ip, index + len);
					index = m.Index + m.Length;
					if (r.GetGroupNames().Contains(token))
					{
						Group g = m.Groups[token];
						ip = ip.Remove(g.Index, g.Length);
						ip = ip.Insert(g.Index, generatedReplacementNumber);
						//ip = ip.Replace(ip.Substring(g.Index, g.Length), generatedReplacementNumber);
						//ip = r.Replace(ip, generatedReplacementNumber);
						num += inc;
					}
				}
			}
			catch
			{
				
			}

			return ip;
		}

		
	}
}
