using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
	public class Email: Document
	{
	public String sender;
	public String recipient;
	public String title;
	public String textdoc2;

	public Email(String textDoc, String senderMsg, String recipientMsg, String titleMsg)
			: base(textDoc)
		{
			String nothing = textDoc;
			textdoc2 = base.getText();
			sender = senderMsg;
			recipient = recipientMsg;
			title = titleMsg;
	}

	public String getSender()
	{
		return sender;
	}

	public String getRecipient()
	{
		return recipient;
	}

	public String getTitle()
	{
		return title;
	}

	public String gettext()
	{
			return textdoc2;
	}

	public void setSender(String newSenderMsg)
	{
		sender = newSenderMsg;
	}

	public void setRecipient(String newRecMsg)
	{
		recipient = newRecMsg;
	}

	public void setTitle(String newTitleMsg)
	{
		title = newTitleMsg;
	}

	public String toString()
	{
		return "From: " + sender + "\nTo: " + recipient + "\n" + title + "\n\n" + base.ToString();

	}
}
}
