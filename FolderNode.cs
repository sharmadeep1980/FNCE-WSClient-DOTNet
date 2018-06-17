/*
	IBM grants you a nonexclusive copyright license to use all programming code 
	examples from which you can generate similar function tailored to your own 
	specific needs.

	All sample code is provided by IBM for illustrative purposes only.
	These examples have not been thoroughly tested under all conditions. IBM, 
	therefore cannot guarantee or imply reliability, serviceability, or function of 
	these programs.

	All Programs or code component contained herein are provided to you "AS IS" 
	without any warranties of any kind.
	The implied warranties of non-infringement, merchantability and fitness for a 
	particular purpose are expressly disclaimed.

	© Copyright IBM Corporation 2007, 2008, ALL RIGHTS RESERVED.
 */

using System;

namespace CEWebClientCS
{
	/// <summary>
	/// Summary description for FolderNode.
	/// </summary>
	public class FolderNode
	{
		private string m_strName;
		private string m_strId;
		private bool   m_blnExpanded;

		public FolderNode()
		{
			m_strName = "";
			m_strId = "";
			m_blnExpanded = false;
		}

		public string Name
		{
			get	{  return m_strName;  }
			set	{  m_strName = value;  }
		}
		public string Id
		{
			get	{  return m_strId;  }
			set {  m_strId = value;  }
		}
		public bool Expanded
		{
			get	{  return m_blnExpanded;  }
			set {  m_blnExpanded = value;  }
		}
	}
}
