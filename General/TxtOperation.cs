using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZMCL.General
{
	public class TxtOperation
	{
		private string FilePath;
		private Encoding EncodingType;
		public TxtOperation(string filePath,Encoding encoding)
		{
			this.EncodingType = encoding;
			this.FilePath = (new Uri(Environment.CurrentDirectory + filePath, UriKind.Relative)).ToString();
		}

		public List<string> ReadTxt()
		{
			List<string> result = new List<string>();
			try
			{
				using (StreamReader streamReader = new StreamReader(this.FilePath, this.EncodingType))
				{
					while (streamReader.Peek() > 0)
					{
						result.Add(streamReader.ReadLine());
					}
				}
			}
			catch
			{

			}
			return result;
		}

		public void WriteTxt(List<string> txtList)
		{
			using (FileStream fileStream = new FileStream(this.FilePath, FileMode.Create))
			{
				using (StreamWriter sw = new StreamWriter(fileStream, this.EncodingType))
				{
					while(txtList.Count>0)
					{
						sw.WriteLine(txtList[0]);
						sw.Flush();
						txtList.RemoveAt(0);
					}
				}
			}
		}
	}
}
