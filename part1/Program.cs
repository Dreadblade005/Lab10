/// Lab 10
/// File Name: Document
/// @author: Dakota Durst
/// Date: November 8, 2020
///
/// Problem Statement: 
///   Define a class named Document that contains an instance variable of type string named text that stores any textual content for the document.  
///
///
/// Overall Plan:
/// 1) create the 3 classes, file (file will stay in program), email and document
/// 2) create document class and add the needed methods
/// 3) create the email class that is a subset of the document class and also includes variables, redefine Tostring()
/// 4) create the file class similar to the email class
/// 5) create 4 objects to test all fields 
/// 

using System;

namespace part1
{
	class Program
	{
		public class File : Document
		{

			private String pathname;
			public String textdoc3;

			public File(String textMsg, String pathDes)
				: base(textMsg)
			{
				textdoc3 = base.getText();
				pathname = pathDes;
			}

			public String getPathname()
			{
				return pathname;
			}

			public String getText()
			{
				return base.ToString();
			}

			public void setPathname(String newPath)
			{
				pathname = newPath;
			}

			public String toString()
			{
				return pathname + ": " + base.ToString();
			}

			public static Boolean ContainsKeyword(Document docObject, String keyword)
			{
				if (docObject.ToString().IndexOf(keyword, 0) >= 0)
					return true;

				return false;
			}
			static void Main(string[] args)
			{
				String sample1 = "The childrens playing cricket" + " were extremely noisy.";
				String sample2 = "The lion stared at the dog " + "across the street.";
				Document email1 = new Email(sample1, "Peter", "Martin", "Childrens");
				Document email2 = new Email(sample2, "Josh", "Lucky", "animals");

				Document file1 = new File(sample1, "childrens.txt");
				Document file2 = new File(sample2, "animals.txt");
				String testWord = "Cricket";
				if (ContainsKeyword(email1, testWord))
					Console.WriteLine("Email 1 contains the word " + testWord);
				else
					Console.WriteLine("Email 1 does not contain " + "the word " + testWord);
				if (ContainsKeyword(email2, testWord))
					Console.WriteLine("Email 2 contains the word " + testWord);
				else
					Console.WriteLine("Email 2 does not contain" + " the word " + testWord);
				if (ContainsKeyword(file1, testWord))
					Console.WriteLine("File 1 contains the word " + testWord);
				else
					Console.WriteLine("File 1 does not contain" + " the word " + testWord);
				if (ContainsKeyword(file2, testWord))
					Console.WriteLine("File 2 contains the word " + testWord);
				else
					Console.WriteLine("File 2 does not contain" + " the word " + testWord);
				Console.WriteLine("---");
				Console.WriteLine(email1.ToString());
				Console.WriteLine("---");
				Console.WriteLine(email2.ToString());
				Console.WriteLine("---");
				Console.WriteLine(file1.ToString());
				Console.WriteLine(file2.ToString());

			}
		}
	}
}