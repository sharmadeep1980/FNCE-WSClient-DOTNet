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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CEWebClientCS
{
	/// <summary>
	/// Summary description for CreateDoc.
	/// </summary>
	public class CreateDoc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtDocClass;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtContentLocation;
		private System.Windows.Forms.CheckBox chkContent;
		private System.Windows.Forms.CheckBox chkFile;
		private System.Windows.Forms.TextBox txtFolderName;
		private System.Windows.Forms.CheckBox chkContentReference;
		private System.Windows.Forms.TextBox txtContentURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMimeType;
		private System.Windows.Forms.CheckBox chkCheckIn;

		// Private state
		private Form1 MainForm;

		public CreateDoc()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnClose = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chkCheckIn = new System.Windows.Forms.CheckBox();
			this.txtMimeType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkContentReference = new System.Windows.Forms.CheckBox();
			this.txtContentURL = new System.Windows.Forms.TextBox();
			this.txtFolderName = new System.Windows.Forms.TextBox();
			this.chkFile = new System.Windows.Forms.CheckBox();
			this.chkContent = new System.Windows.Forms.CheckBox();
			this.txtContentLocation = new System.Windows.Forms.TextBox();
			this.txtDocClass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(296, 280);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.chkCheckIn);
			this.GroupBox1.Controls.Add(this.txtMimeType);
			this.GroupBox1.Controls.Add(this.label1);
			this.GroupBox1.Controls.Add(this.chkContentReference);
			this.GroupBox1.Controls.Add(this.txtContentURL);
			this.GroupBox1.Controls.Add(this.txtFolderName);
			this.GroupBox1.Controls.Add(this.chkFile);
			this.GroupBox1.Controls.Add(this.chkContent);
			this.GroupBox1.Controls.Add(this.txtContentLocation);
			this.GroupBox1.Controls.Add(this.txtDocClass);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.txtTitle);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.btnCreate);
			this.GroupBox1.Location = new System.Drawing.Point(24, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(624, 256);
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Document Parameters";
			// 
			// chkCheckIn
			// 
			this.chkCheckIn.Location = new System.Drawing.Point(24, 216);
			this.chkCheckIn.Name = "chkCheckIn";
			this.chkCheckIn.Size = new System.Drawing.Size(160, 24);
			this.chkCheckIn.TabIndex = 21;
			this.chkCheckIn.Text = "Check In Document";
			// 
			// txtMimeType
			// 
			this.txtMimeType.Enabled = false;
			this.txtMimeType.Location = new System.Drawing.Point(208, 120);
			this.txtMimeType.Name = "txtMimeType";
			this.txtMimeType.Size = new System.Drawing.Size(408, 20);
			this.txtMimeType.TabIndex = 6;
			this.txtMimeType.Text = "text/plain";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Content MIME Type:";
			// 
			// chkContentReference
			// 
			this.chkContentReference.Location = new System.Drawing.Point(24, 88);
			this.chkContentReference.Name = "chkContentReference";
			this.chkContentReference.Size = new System.Drawing.Size(168, 24);
			this.chkContentReference.TabIndex = 4;
			this.chkContentReference.Text = "Include Content at URL:";
			this.chkContentReference.CheckedChanged += new System.EventHandler(this.chkContentReference_CheckedChanged);
			// 
			// txtContentURL
			// 
			this.txtContentURL.Enabled = false;
			this.txtContentURL.Location = new System.Drawing.Point(208, 88);
			this.txtContentURL.Name = "txtContentURL";
			this.txtContentURL.Size = new System.Drawing.Size(408, 20);
			this.txtContentURL.TabIndex = 5;
			this.txtContentURL.Text = "http://www.filenet.com";
			// 
			// txtFolderName
			// 
			this.txtFolderName.Enabled = false;
			this.txtFolderName.Location = new System.Drawing.Point(208, 184);
			this.txtFolderName.Name = "txtFolderName";
			this.txtFolderName.Size = new System.Drawing.Size(224, 20);
			this.txtFolderName.TabIndex = 9;
			this.txtFolderName.Text = "/";
			// 
			// chkFile
			// 
			this.chkFile.Location = new System.Drawing.Point(24, 184);
			this.chkFile.Name = "chkFile";
			this.chkFile.Size = new System.Drawing.Size(168, 24);
			this.chkFile.TabIndex = 8;
			this.chkFile.Text = " File In Folder:";
			this.chkFile.CheckedChanged += new System.EventHandler(this.chkFile_CheckedChanged);
			// 
			// chkContent
			// 
			this.chkContent.Location = new System.Drawing.Point(24, 56);
			this.chkContent.Name = "chkContent";
			this.chkContent.Size = new System.Drawing.Size(168, 24);
			this.chkContent.TabIndex = 2;
			this.chkContent.Text = "Include Content at Location:";
			this.chkContent.CheckedChanged += new System.EventHandler(this.chkContent_CheckedChanged);
			// 
			// txtContentLocation
			// 
			this.txtContentLocation.Enabled = false;
			this.txtContentLocation.Location = new System.Drawing.Point(208, 56);
			this.txtContentLocation.Name = "txtContentLocation";
			this.txtContentLocation.Size = new System.Drawing.Size(408, 20);
			this.txtContentLocation.TabIndex = 3;
			this.txtContentLocation.Text = "C:\\Temp\\xxx.txt";
			// 
			// txtDocClass
			// 
			this.txtDocClass.Location = new System.Drawing.Point(208, 152);
			this.txtDocClass.Name = "txtDocClass";
			this.txtDocClass.Size = new System.Drawing.Size(224, 20);
			this.txtDocClass.TabIndex = 7;
			this.txtDocClass.Text = "Document";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Document Class:";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(208, 24);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(408, 20);
			this.txtTitle.TabIndex = 1;
			this.txtTitle.Text = "";
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(24, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Title:";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(536, 168);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(80, 23);
			this.btnCreate.TabIndex = 10;
			this.btnCreate.Text = "Create Now";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
			// 
			// CreateDoc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 309);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "CreateDoc";
			this.Text = "CreateDoc";
			this.Load += new System.EventHandler(this.CreateDoc_Load);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCreate_Click_1(object sender, System.EventArgs e)
		{
			long					lngPropCount = 1;
			long					lngActionCount = 1;
			string					strContentLocation = "";
			string					strRetrievalName = "";
			ulong					ulContentSize = 0;

			// If content was specified, do some sanity checks and prepare...
			if( chkContent.Checked )
			{
				// Extract the location, retrieval name, and MIME type
				if( txtContentLocation.Text == "" )
				{
					MessageBox.Show("Looks like you forgot to specify a content location - aborting");
					return;
				}
				if( txtMimeType.Text == "" )
				{
					MessageBox.Show("Looks like you forgot to specify a MIME type - aborting");
					return;
				}
				strContentLocation = txtContentLocation.Text.Replace('/', '\\');
				int nStart = strContentLocation.LastIndexOf('\\');
				strRetrievalName = (nStart > 1) ? strContentLocation.Substring(nStart+1, (strContentLocation.Length-nStart-1)) : strContentLocation;

				// Verify that the file exists and get its size
				ulContentSize = getFileContentSize(strContentLocation);
				if( ulContentSize == 0 )
				{
					MessageBox.Show("The specified content file either does not exist, or is of zero length");
					return;
				}
				lngPropCount += 1;
			}

			// Sanity checks if content by reference was specified...
			if( chkContentReference.Checked )
			{
				if( txtContentURL.Text == "" )
				{
					MessageBox.Show("Looks like you forgot to specify a content URL - aborting");
					return;
				}
				if( txtMimeType.Text == "" )
				{
					MessageBox.Show("Looks like you forgot to specify a MIME type - aborting");
					return;
				}
				lngPropCount += 1;
			}

			// Get the WS binding object
			//  (this will be used to set WS-Security parameters)
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                MainForm.Domain, MainForm.Password, MainForm.URL);

			// We first need to create a Create verb, populate it
			CEWSI.CreateAction createVerb = new CEWSI.CreateAction();
			createVerb.classId = txtDocClass.Text;

			// If the user wants to check the document in, then we'll add a separate
			//  Checkin verb as well
			CEWSI.CheckinAction checkinVerb = new CEWSI.CheckinAction();
			if( chkCheckIn.Checked )
			{
				checkinVerb.checkinMinorVersion = true;
				checkinVerb.checkinMinorVersionSpecified = true;
				lngActionCount += 1;
			}

			CEWSI.ChangeRequestType objChange = new CEWSI.ChangeRequestType();
			objChange.Action = new CEWSI.ActionType[lngActionCount];
			objChange.Action[0] = (CEWSI.ActionType)createVerb;
			if( chkCheckIn.Checked )
				objChange.Action[1] = (CEWSI.ActionType)checkinVerb;

			objChange.TargetSpecification = new CEWSI.ObjectReference();
			objChange.TargetSpecification.classId = "ObjectStore";
			objChange.TargetSpecification.objectId = MainForm.Library;
			objChange.id = "1";

			// Build a list of properties to set in the new document 
			CEWSI.ModifiablePropertyType[] objInputProps = new CEWSI.ModifiablePropertyType[lngPropCount];
			CEWSI.SingletonString objString = new CEWSI.SingletonString();
			objString.Value = txtTitle.Text;
			objString.propertyId = "DocumentTitle";
			objInputProps[0] = objString;

			if( chkContent.Checked || chkContentReference.Checked )
			{
				// Create content properties array
				//   ContentTransfer elements will take three properties:
				//		* RetrievalName
				//		* Content
				//		* ContentType
				//   ContentReference elements will take two properties:
				//		* ContentLocation
				//		* ContentType
				CEWSI.PropertyType[] ctProps = null;
				if( chkContent.Checked )
					ctProps = new CEWSI.PropertyType[3];
				else
					ctProps = new CEWSI.PropertyType[2];

				// Set the ContentType property
				CEWSI.SingletonString typeProp = new CEWSI.SingletonString();
				typeProp.propertyId = "ContentType";
				typeProp.Value = txtMimeType.Text;
				ctProps[0] = typeProp;

				// Create the dependent object type object
				CEWSI.DependentObjectType ct = new CEWSI.DependentObjectType();
				ct.dependentAction = CEWSI.DependentObjectTypeDependentAction.Insert;
				ct.dependentActionSpecified = true;

				// ContentTransfer case
				if( chkContent.Checked )
				{
					// create RetrievalName name property
					CEWSI.SingletonString nameProp = new CEWSI.SingletonString();
					nameProp.propertyId = "RetrievalName";
					nameProp.Value = strRetrievalName;
					ctProps[1] = nameProp;

					// create content data object
					CEWSI.ContentData contData = new CEWSI.ContentData();
					contData.propertyId = "Content";

                    CEWSI.InlineContent ic = new CEWSI.InlineContent();
                    ic.Binary = getSouceFileContent(strContentLocation);

                    contData.Value = ic;
					ctProps[2] = contData;

					// Dependent object is of type ContentTransfer
					ct.classId = "ContentTransfer";
				}

				// ContentReference case
				else
				{
					// Create the ContentLocation property
					CEWSI.SingletonString locationProp = new CEWSI.SingletonString();
					locationProp.propertyId = "ContentLocation";
					locationProp.Value = txtContentURL.Text;
					ctProps[1] = locationProp;

					// Dependent object is of type ContentReference
					ct.classId = "ContentReference";
				}

				//	create content object list
				ct.Property = ctProps;
				CEWSI.DependentObjectType[] contentObjects = new CEWSI.DependentObjectType[1];
				contentObjects[0] = ct;

				//	Create the content element list and set it into the document's properties
				CEWSI.ListOfObject objContentList = new CEWSI.ListOfObject();
				objContentList.propertyId = "ContentElements";
				objContentList.Value = contentObjects;
				objInputProps[1] = objContentList;
			}
			objChange.ActionProperties = objInputProps;

			// Send off the request
			CEWSI.ChangeResponseType[] objResponseArray = null;
			CEWSI.ExecuteChangesRequest objRequest = new CEWSI.ExecuteChangesRequest();
			objRequest.refresh = true;
			objRequest.refreshSpecified = true;
			objRequest.ChangeRequest = new CEWSI.ChangeRequestType[1];
			objRequest.ChangeRequest[0] = objChange;
			try
			{
				objResponseArray = objBinding.ExecuteChanges(WSIUtil.GetLocalization(), objRequest);
			}
			catch(System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while creating a document: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}


			// Created a document!  Sanity check the results
			string strObjectId = "";
			bool bFound = false;

			if( objResponseArray==null || objResponseArray.Length<1 )
			{
				MessageBox.Show("The change request was executed, but a valid object was not returned");
				return;
			}
			CEWSI.ChangeResponseType objResponse = objResponseArray[0];
			foreach (CEWSI.PropertyType objProp in objResponse.Property)
			{
				if (objProp.propertyId.CompareTo("Id") == 0)
				{
					strObjectId = IdmObjectType.getPropertyValue(objProp);
					bFound = true;
					break;
				}
			}
			if( !bFound )
			{
				MessageBox.Show("The document was created, but the results do not contain a document ID!");
				return;
			}

			if( chkFile.Checked )
			{
				MessageBox.Show("Successfully created a document!  ID = [" + strObjectId + "].  Now filing.");
				FileDoc(strObjectId, txtDocClass.Text, txtTitle.Text, txtFolderName.Text);
			}
			else
				MessageBox.Show("Successfully created a document!  ID = [" + strObjectId + "]");
			return;
		}

		private void FileDoc(string strDocId, string strDocClass, string strDocTitle, string strFolderPath)
		{
			// Create a Create verb, populate it to create a new RCR
			CEWSI.CreateAction createVerb = new CEWSI.CreateAction();
			createVerb.autoUniqueContainmentName = true;
			createVerb.autoUniqueContainmentNameSpecified = true;
			createVerb.classId = "DynamicReferentialContainmentRelationship";

			CEWSI.ChangeRequestType objChange = new CEWSI.ChangeRequestType();
			objChange.Action = new CEWSI.ActionType[1];
			objChange.Action[0] = (CEWSI.ActionType)createVerb;
			objChange.TargetSpecification = new CEWSI.ObjectReference();
			objChange.TargetSpecification.classId = "ObjectStore";
			objChange.TargetSpecification.objectId = MainForm.Library;
			objChange.id = "1";

			// Create the properties of the new RCR
			CEWSI.ObjectReference objHeadRef = new CEWSI.ObjectReference();
			objHeadRef.classId = strDocClass;
			objHeadRef.objectId = strDocId;
			objHeadRef.objectStore = MainForm.Library;
			CEWSI.SingletonObject propHead = new CEWSI.SingletonObject();
			propHead.propertyId = "Head";
			propHead.Value = (CEWSI.ObjectEntryType)objHeadRef;

			CEWSI.ObjectReference objTailRef = new CEWSI.ObjectReference();
			objTailRef.classId = "Folder";
			objTailRef.objectId = strFolderPath;
			objTailRef.objectStore = MainForm.Library;
			CEWSI.SingletonObject propTail = new CEWSI.SingletonObject();
			propTail.propertyId = "Tail";
			propTail.Value = (CEWSI.ObjectEntryType)objTailRef;

			CEWSI.SingletonString propContainmentName = new CEWSI.SingletonString();
			propContainmentName.propertyId = "ContainmentName";
			propContainmentName.Value = strDocTitle;

			CEWSI.ModifiablePropertyType[] objProps = new CEWSI.ModifiablePropertyType[3];
			objProps[0] = propTail;
			objProps[1] = propHead;
			objProps[2] = propContainmentName;
			objChange.ActionProperties = objProps;
					
			// Fill in the security headers...
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                MainForm.Domain, MainForm.Password, MainForm.URL);

			// Send off the request
			CEWSI.ChangeResponseType[] objResponseArray = null;
			CEWSI.ExecuteChangesRequest objRequest = new CEWSI.ExecuteChangesRequest();
			objRequest.refresh = false;
			objRequest.refreshSpecified = true;
			objRequest.ChangeRequest = new CEWSI.ChangeRequestType[1];
			objRequest.ChangeRequest[0] = objChange;
			try
			{
				objResponseArray = objBinding.ExecuteChanges(WSIUtil.GetLocalization(), objRequest);
			}
			catch(System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while filing a document: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}

			MessageBox.Show("Successfully filed a document!");
			return;
		}

		public ulong getFileContentSize(string strSource)
		{
			ulong ulFileSize = 0;
			try 
			{
				System.IO.FileStream  inFile = new System.IO.FileStream(strSource,
					System.IO.FileMode.Open,
					System.IO.FileAccess.Read);
				ulFileSize = (ulong)inFile.Length;
				inFile.Close();
			}
			catch (System.Exception) 
			{
				return 0;
			}
			return ulFileSize;
		}

		public byte[] getSouceFileContent(string strSource)
		{
			byte[]  binaryData;
			try 
			{
				System.IO.FileStream inFile = new System.IO.FileStream(strSource,
					System.IO.FileMode.Open,
					System.IO.FileAccess.Read);
				binaryData = new Byte[inFile.Length];
				long bytesRead = inFile.Read(binaryData, 0,(int) inFile.Length);
				inFile.Close();
			}
			catch (System.Exception exp) 
			{
				throw new System.Exception(exp.Message, exp);
			}
			return binaryData;
		}

		/// <summary>
		/// Called by the main form to initialize this form
		/// </summary>
		/// <param name="mForm"></param>
		public void FormInit(Form1 mForm)
		{
			MainForm = mForm;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void chkContent_CheckedChanged(object sender, System.EventArgs e)
		{
			if( chkContent.Checked )
			{
				txtContentLocation.Enabled = true;
				txtContentURL.Enabled = false;
				chkContentReference.Checked = false;
				txtMimeType.Enabled = true;
			}
			else
			{
				txtContentLocation.Enabled = false;
				txtMimeType.Enabled = false;
			}
		}

		private void CreateDoc_Load(object sender, System.EventArgs e)
		{
		
		}

		private void chkFile_CheckedChanged(object sender, System.EventArgs e)
		{
			if( chkFile.Checked )
				txtFolderName.Enabled = true;
			else
				txtFolderName.Enabled = false;
		}

		private void chkContentReference_CheckedChanged(object sender, System.EventArgs e)
		{
			if( chkContentReference.Checked )
			{
				txtContentURL.Enabled = true;
				txtContentLocation.Enabled = false;
				chkContent.Checked = false;
				txtMimeType.Enabled = true;
			}
			else
			{
				txtContentURL.Enabled = false;
				txtMimeType.Enabled = false;
			}
		}
	}
}
