using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
	public class Document
	{
		public String text;

		public Document(String textDoc)
		{
			setText(textDoc);
		}
		public void setText(String newTextDoc)
		{
			text = newTextDoc;
		}
		public string getText()
        {
			return text;
        }
		public String ToString()
		{
			return text;
		}
	}
}
