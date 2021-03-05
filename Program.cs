using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BFInterpreter
{
	class Program
	{
		public static int pointer = 0;
		public static List<int> memory_blocks = new List<int>();
		public static string BFCode;

		static void Main(string[] args)
		{
			foreach (string i in args)
			{
				using (FileStream fs = File.Open(i, FileMode.Open))
				{
					BFCode = "";

					byte[] b = new byte[1024];
					UTF8Encoding decoder = new UTF8Encoding(true);

					while (fs.Read(b, 0, b.Length) > 0)
					{
						BFCode += decoder.GetString(b);
					}
				}

				memory_blocks.Add(0);

				try
				{
					ParseBF(BFCode);
				}
				catch(Exception e)
				{
					Console.WriteLine("\nError:");
					Console.WriteLine(e.Message);
					break;
				}
			}
			Console.Write("\nPress any key to exit . . . .");
			Console.ReadKey();
		}

		static void ParseBF(string code)
		{
			int CurrentChar = 0, NumLoops, CharCopy;
			char chr;

			while (CurrentChar != code.Length)
			{
				if (code[CurrentChar] == '+')
				{
					memory_blocks[pointer] += 1;
				}
				else if (code[CurrentChar] == '-')
				{
					memory_blocks[pointer] -= 1;
				}
				else if (code[CurrentChar] == '>')
				{
					pointer += 1;
				}
				else if (code[CurrentChar] == '<')
				{
					pointer -= 1;
				}
				else if (code[CurrentChar] == '.')
				{
					Console.Write((char)memory_blocks[pointer]);
				}
				else if (code[CurrentChar] == ',')
				{
					chr = Console.ReadKey().ToString().ToCharArray()[0];
					memory_blocks[pointer] = (int)chr;
				}
				else if (code[CurrentChar] == '/')
				{
					CurrentChar++;
					while (code[CurrentChar] != '/')
					{
						CurrentChar++;
					}
				}
				else if (code[CurrentChar] == '[')
				{
					NumLoops = 1;
					CharCopy = CurrentChar + 1;

					while (NumLoops != 0)
					{
						CurrentChar += 1;
						if (code[CurrentChar] == '[')
						{
							NumLoops += 1;
						}
						else if (code[CurrentChar] == ']')
						{
							NumLoops -= 1;
						}
					}

					while (memory_blocks[pointer] != 0)
					{
						ParseBF(code.Substring(CharCopy, CurrentChar - CharCopy));
					}


				}

				CurrentChar += 1;
				while (memory_blocks.Count <= pointer)
				{
					memory_blocks.Add(0);
				}
			}
		}
	}
}