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
using System.Windows.Forms;

namespace CEWebClientCS
{
	/// <summary>
	/// Summary description for FolderTree.
	/// </summary>
	public class FolderTree : System.Windows.Forms.Form
	{
        // If this field set true, the sample will use a separate GetContent request
        // to retrieve the content of a document.
        private static readonly bool UseGetContent = true;

		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TreeView treeFolders;
		private System.Windows.Forms.Button btnPopulate;

		// Private state
		private Form1 MainForm;
		private System.Windows.Forms.DataGrid dgrdContainees;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnContainees;
		private bool  g_blnInitialized = false;
		private System.Windows.Forms.Button btnGetContent;
		private System.Data.DataTable g_dtblResults = null;

		public FolderTree()
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
			this.treeFolders = new System.Windows.Forms.TreeView();
			this.btnPopulate = new System.Windows.Forms.Button();
			this.dgrdContainees = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnContainees = new System.Windows.Forms.Button();
			this.btnGetContent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgrdContainees)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(400, 488);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// treeFolders
			// 
			this.treeFolders.ImageIndex = -1;
			this.treeFolders.Location = new System.Drawing.Point(8, 8);
			this.treeFolders.Name = "treeFolders";
			this.treeFolders.SelectedImageIndex = -1;
			this.treeFolders.Size = new System.Drawing.Size(672, 248);
			this.treeFolders.TabIndex = 8;
			this.treeFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolders_AfterSelect);
			// 
			// btnPopulate
			// 
			this.btnPopulate.Location = new System.Drawing.Point(176, 264);
			this.btnPopulate.Name = "btnPopulate";
			this.btnPopulate.Size = new System.Drawing.Size(112, 23);
			this.btnPopulate.TabIndex = 1;
			this.btnPopulate.Text = "Find Sub-Folders";
			this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
			// 
			// dgrdContainees
			// 
			this.dgrdContainees.DataMember = "";
			this.dgrdContainees.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgrdContainees.Location = new System.Drawing.Point(24, 320);
			this.dgrdContainees.Name = "dgrdContainees";
			this.dgrdContainees.Size = new System.Drawing.Size(640, 144);
			this.dgrdContainees.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 296);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(672, 184);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Containees";
			// 
			// btnContainees
			// 
			this.btnContainees.Location = new System.Drawing.Point(384, 264);
			this.btnContainees.Name = "btnContainees";
			this.btnContainees.Size = new System.Drawing.Size(104, 23);
			this.btnContainees.TabIndex = 2;
			this.btnContainees.Text = "Get Containees";
			this.btnContainees.Click += new System.EventHandler(this.btnContainees_Click);
			// 
			// btnGetContent
			// 
			this.btnGetContent.Enabled = false;
			this.btnGetContent.Location = new System.Drawing.Point(192, 488);
			this.btnGetContent.Name = "btnGetContent";
			this.btnGetContent.Size = new System.Drawing.Size(80, 23);
			this.btnGetContent.TabIndex = 3;
			this.btnGetContent.Text = "Get Content";
			this.btnGetContent.Click += new System.EventHandler(this.button1_Click);
			// 
			// FolderTree
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 517);
			this.Controls.Add(this.btnGetContent);
			this.Controls.Add(this.btnContainees);
			this.Controls.Add(this.dgrdContainees);
			this.Controls.Add(this.btnPopulate);
			this.Controls.Add(this.treeFolders);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Name = "FolderTree";
			this.Text = "FolderTree";
			this.Load += new System.EventHandler(this.FolderTree_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgrdContainees)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Called by the main form to initialize this form
		/// </summary>
		/// <param name="mForm"></param>
		public void FormInit(Form1 mForm)
		{
			MainForm = mForm;
		}

		private void treeFolders_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		}

		private void FolderTree_Load(object sender, System.EventArgs e)
		{
		}

		private int ExpandNode(System.Windows.Forms.TreeNode objParent, FolderNode fNode)
		{
			int numSubfolders = 0;

			// Don't waste time expanding the same node twice...
			if( fNode.Expanded )
				return 0;

			// Properties to exclude in the query results
			string strFolderId = fNode.Id;
			string[] strExclude = new string[5];
			strExclude[0] = "DateCreated";
			strExclude[1] = "DateLastModified";

			// Comment out stuff that gets us in trouble when recursion is enabled
			strExclude[2] = "ObjectStore";
			strExclude[3] = "ClassDescription";
			strExclude[4] = "Parent";

			// Get the folder's Subfolders list object
			CEWSI.ObjectRequestType	objSubFoldersRequest = new CEWSI.ObjectRequestType();
			CEWSI.ObjectSpecification objSubFoldersSpec = new CEWSI.ObjectSpecification();
			objSubFoldersSpec.classId = "Folder";
			objSubFoldersSpec.objectId = strFolderId;
			objSubFoldersSpec.objectStore = MainForm.Library;
			objSubFoldersSpec.propertyId = "SubFolders";
			objSubFoldersRequest.SourceSpecification = objSubFoldersSpec;
			objSubFoldersRequest.id = "1";
			objSubFoldersRequest.PropertyFilter = new CEWSI.PropertyFilterType();
			objSubFoldersRequest.PropertyFilter.ExcludeProperties = strExclude;
			//objSubFoldersRequest.PropertyFilter.maxRecursion = 3;
			//objSubFoldersRequest.PropertyFilter.maxRecursionSpecified = true;
			//objSubFoldersRequest.maxElements = 2;
			//objSubFoldersRequest.maxElementsSpecified = true;

			// Get the folder itself
			//CEWSI.ObjectRequestType objFolderRequest = new CEWSI.ObjectRequestType();
			//CEWSI.ObjectSpecification objFolderSpec = new CEWSI.ObjectSpecification();
			//objFolderSpec.classId = "Folder";
			//objFolderSpec.objectId = strFolderId;
			//objFolderSpec.objectStore = MainForm.Library;
			//objFolderRequest.SourceSpecification = objFolderSpec;
			//objFolderRequest.id = "3";
			//objFolderRequest.PropertyFilter = new CEWSI.PropertyFilterType();
			//objFolderRequest.PropertyFilter.ExcludeProperties = strExclude;

			// Create the request array
			CEWSI.ObjectRequestType[] objRequestArray = new CEWSI.ObjectRequestType[1];
			objRequestArray[0] = objSubFoldersRequest;

			// Fill in the security headers...
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                MainForm.Domain, MainForm.Password, MainForm.URL);
				
			// Send off the request
			CEWSI.ObjectResponseType[] objResponses = null;
			try
			{
				objResponses = objBinding.GetObjects(WSIUtil.GetLocalization(), objRequestArray);
			}
			catch( System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while querying for a folder: [" + ex.Message + "]");
				return 0;
			}

			// Get the nodes below the parent
			if (objResponses.Length > 0 && objResponses[0].id == "1")
			{
				if( objResponses[0].GetType() == typeof(CEWSI.ErrorStackResponse) )
				{
					CEWSI.ErrorStackResponse objErrResponse = (CEWSI.ErrorStackResponse)objResponses[0];
					CEWSI.ErrorStackType objStack = objErrResponse.ErrorStack;
					CEWSI.ErrorRecordType objErr = objStack.ErrorRecord[0];
					MessageBox.Show("Error [" + objErr.Description + "] occurred. " +
						" Err source is [" + objErr.Source + "]");
					return 0;
				}
				
				CEWSI.ObjectSetResponse objSetResponse = (CEWSI.ObjectSetResponse)objResponses[0];
				CEWSI.ObjectSetType objSet = objSetResponse.ObjectSet;
				if( objSet.Object != null && objSet.Object.Length > 0 )
				{
					foreach (CEWSI.ObjectValue objValue in (CEWSI.ObjectValue[])objSet.Object)
					{
						numSubfolders += 1;
						System.Windows.Forms.TreeNode objNode = new System.Windows.Forms.TreeNode();
						FolderNode newNode = new FolderNode();
						foreach (CEWSI.PropertyType objProp in objValue.Property)
						{
							if( objProp.propertyId == "FolderName" )
							{
								string strName = ((CEWSI.SingletonString)objProp).Value;
								objNode.Text = strName;
								newNode.Name = strName;
							}
							if( objProp.propertyId == "Id" )
							{
								string strId = ((CEWSI.SingletonId)objProp).Value;
								newNode.Id = strId;
							}
						}
						objNode.Tag = (object)newNode;
						objParent.Nodes.Add(objNode);
					}
				}
			}
			objParent.Expand();
			fNode.Expanded = true;
			return numSubfolders;
		}


		// Initialize the tree view
		private void btnPopulate_Click(object sender, System.EventArgs e)
		{
			// Query for subfolders and containees
			// If we are not yet initialized, then set the query folder to
			//  the magic 'root folder' ID
			// Else, get the selected node and set the query folder to it
			if( !g_blnInitialized )
			{
				string strFolderId = "{0F1E2D3C-4B5A-6978-8796-A5B4C3D2E1F0}";
				treeFolders.Nodes.Add("/");
				FolderNode fNode = new FolderNode();
				fNode.Name = "";
				fNode.Id = strFolderId;
				treeFolders.Nodes[0].Tag = (object)fNode;
				if( ExpandNode(treeFolders.TopNode, fNode) > 0 )
					g_blnInitialized = true;
			}
			else
			{
				if(treeFolders.SelectedNode != null)
				{
					int i = ExpandNode(treeFolders.SelectedNode, (FolderNode)treeFolders.SelectedNode.Tag);
				}
				else
					MessageBox.Show("Please select a folder to expand first!");
			}
		}

		private void btnContainees_Click(object sender, System.EventArgs e)
		{
			FolderNode folder;

			// Reset the data grid
			dgrdContainees.DataSource = null;
			dgrdContainees.Show();
			btnGetContent.Enabled = false;

			// Get the ID of the folder we are to search for containees
			if( treeFolders.SelectedNode == null )
			{
				MessageBox.Show("You must first select a folder node");
				return;
			}
			folder = (FolderNode)treeFolders.SelectedNode.Tag;
			string strFolderId = folder.Id;

			// Properties to exclude in the query results
			string[] strExclude = new string[2];
			strExclude[0] = "DateCreated";
			strExclude[1] = "DateLastModified";

			// Get the folder's Containees list object
			CEWSI.ObjectRequestType objContaineesRequest = new CEWSI.ObjectRequestType();
			CEWSI.ObjectSpecification objContaineesSpec = new CEWSI.ObjectSpecification();
			objContaineesSpec.classId = "Folder";
			objContaineesSpec.objectId = strFolderId;
			objContaineesSpec.objectStore = MainForm.Library;
			objContaineesSpec.propertyId = "Containees";
			objContaineesRequest.SourceSpecification = objContaineesSpec;
			objContaineesRequest.id = "1";

			// Make sure to ask for the Head property of the RCR
			objContaineesRequest.PropertyFilter = new CEWSI.PropertyFilterType();
			CEWSI.FilterElementType filterHead = new CEWSI.FilterElementType();
			CEWSI.FilterElementType filterCName = new CEWSI.FilterElementType();
			CEWSI.FilterElementType filterId = new CEWSI.FilterElementType();
			CEWSI.FilterElementType filterCreator = new CEWSI.FilterElementType();
			CEWSI.FilterElementType filterContentSize = new CEWSI.FilterElementType();
			CEWSI.FilterElementType filterTitle = new CEWSI.FilterElementType();

			filterHead.Value = "Head";
			filterCName.Value = "ContainmentName";
			filterId.Value = "Id";
			filterCreator.Value = "Creator";
			filterContentSize.Value = "ContentSize";
			filterTitle.Value = "DocumentTitle";

			objContaineesRequest.PropertyFilter.IncludeProperties = new CEWSI.FilterElementType[6];
			objContaineesRequest.PropertyFilter.IncludeProperties[0] = filterHead;
			objContaineesRequest.PropertyFilter.IncludeProperties[1] = filterCName;
			objContaineesRequest.PropertyFilter.IncludeProperties[2] = filterId;
			objContaineesRequest.PropertyFilter.IncludeProperties[3] = filterCreator;
			objContaineesRequest.PropertyFilter.IncludeProperties[4] = filterContentSize;
			objContaineesRequest.PropertyFilter.IncludeProperties[5] = filterTitle;
			objContaineesRequest.PropertyFilter.ExcludeProperties = strExclude;
			objContaineesRequest.PropertyFilter.maxRecursion = 1;
			objContaineesRequest.PropertyFilter.maxRecursionSpecified = true;
			// Test continuation  objContaineesRequest.maxElements = 2;
			//                    objContaineesRequest.maxElementsSpecified = true;

			// Create the request array
			CEWSI.ObjectRequestType[] objRequestArray = new CEWSI.ObjectRequestType[1];
			objRequestArray[0] = objContaineesRequest;

			// Fill in the security headers...
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                MainForm.Domain, MainForm.Password, MainForm.URL);

			// Send off the request
			CEWSI.ObjectResponseType[] objResponses = null;
			try
			{
				objResponses = objBinding.GetObjects(WSIUtil.GetLocalization(), objRequestArray);
			}
			catch( System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while querying for containees: [" + ex.Message + "]");
				return;
			}			
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}


			// Get the containees
			if( objResponses.Length < 1 )
			{
				MessageBox.Show("No containees found");
				return;
			}

			if( objResponses[0].GetType() == typeof(CEWSI.ErrorStackResponse) )
			{
				CEWSI.ErrorStackResponse objErrResponse = (CEWSI.ErrorStackResponse)objResponses[0];
				CEWSI.ErrorStackType objStack = objErrResponse.ErrorStack;
				CEWSI.ErrorRecordType objErr = objStack.ErrorRecord[0];
				MessageBox.Show("Error [" + objErr.Description + "] occurred. " +
					" Err source is [" + objErr.Source + "]");
				return;
			}
			
			CEWSI.ObjectSetResponse objSetResponse = (CEWSI.ObjectSetResponse)objResponses[0];
			CEWSI.ObjectSetType objResults = objSetResponse.ObjectSet;
			if( objResults.Object == null || objResults.Object.Length < 1 ) 
			{
				MessageBox.Show("No containees found");
				return;
			}

			// Query was successful; display a list of result rows
			// First create a data table that has our columns in it
			System.Data.DataColumn dtCol;
			System.Data.DataRow dtRow;

			System.Data.DataTable dtblResults = new System.Data.DataTable("Results");

			dtCol = new System.Data.DataColumn("RCRId");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("ContainmentName");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("Id");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("ClassID");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("Title");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("Creator");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			dtCol = new System.Data.DataColumn("ContentSize");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			// For each containee, make an entry in our data table
			CEWSI.ObjectValue objHead = null;
			foreach (CEWSI.ObjectValue objContainee in (CEWSI.ObjectValue[])objResults.Object)
			{
				dtRow = dtblResults.NewRow();
				foreach (CEWSI.PropertyType objProp in objContainee.Property)
				{
					if( objProp.propertyId == "ContainmentName" )
					{  
                        dtRow["ContainmentName"] = IdmObjectType.getPropertyValue(objProp);	
                    }
					
                    if( objProp.propertyId == "Id" )
					{  
                        dtRow["RCRId"] = IdmObjectType.getPropertyValue(objProp);	
                    }

					if( objProp.propertyId == "Head" )
					{
						objHead = (CEWSI.ObjectValue)((CEWSI.SingletonObject)objProp).Value;

						dtRow["ClassId"] = objHead.classId.ToString();

						foreach (CEWSI.PropertyType objHeadProp in objHead.Property)
						{
							if( objHeadProp.propertyId == "Id" )
							{  
                                dtRow["Id"] = IdmObjectType.getPropertyValue(objHeadProp);	
                            }
							if( objHeadProp.propertyId == "Creator" )
							{  
                                dtRow["Creator"] = IdmObjectType.getPropertyValue(objHeadProp);	
                            }
							if( objHeadProp.propertyId == "ContentSize" )
							{  
                                dtRow["ContentSize"] = IdmObjectType.getPropertyValue(objHeadProp);	
                            }
							if( objHeadProp.propertyId == "DocumentTitle" )
							{  
                                dtRow["Title"] = IdmObjectType.getPropertyValue(objHeadProp);	
                            }
						}
					}
				}
				dtblResults.Rows.Add(dtRow);
				btnGetContent.Enabled = true;
			}	
			dgrdContainees.DataSource = dtblResults;
			dgrdContainees.Show();
			g_dtblResults = dtblResults;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// OK, what are we supposed to retrieve
			System.Data.DataRow dtRow;
			int i = dgrdContainees.CurrentRowIndex;
			dtRow = g_dtblResults.Rows[i];
			string strId = (string)dtRow["Id"];
			string strContentSize = (string)dtRow["ContentSize"];
			MessageBox.Show("Retrieving content for document [" + strId + "]  size= " + strContentSize + " bytes.");

			// Retrieve the document
			CEWSI.ObjectRequestType objContentRequest = new CEWSI.ObjectRequestType();
			CEWSI.ObjectSpecification objContentSpec = new CEWSI.ObjectSpecification();
			objContentSpec.classId = "Document";
			objContentSpec.objectId = strId;
			objContentSpec.objectStore = MainForm.Library;
			objContentRequest.SourceSpecification = objContentSpec;
			objContentRequest.id = "1";

			// Ask for the content properties...
			CEWSI.FilterElementType[] incContentProps;
            if (UseGetContent)
                incContentProps = new CEWSI.FilterElementType[1];
            else
                incContentProps = new CEWSI.FilterElementType[2];
            incContentProps[0] = new CEWSI.FilterElementType();
			incContentProps[0].Value = "ContentElements";
            if (!UseGetContent)
            {
                incContentProps[1] = new CEWSI.FilterElementType();
                incContentProps[1].Value = "Content";
                incContentProps[1].maxSize = 1000000;
                incContentProps[1].maxSizeSpecified = true;
            }

			objContentRequest.PropertyFilter = new CEWSI.PropertyFilterType();
			objContentRequest.PropertyFilter.IncludeProperties = incContentProps;
			objContentRequest.PropertyFilter.maxRecursion = 1;
			objContentRequest.PropertyFilter.maxRecursionSpecified = true;

			// Create the request array
			CEWSI.ObjectRequestType[] objRequestArray = new CEWSI.ObjectRequestType[1];
			objRequestArray[0] = objContentRequest;

			// Fill in the security headers...
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                MainForm.Domain, MainForm.Password, MainForm.URL);

			// Send off the request
			CEWSI.ObjectResponseType[] objResponses = null;
			try
			{
				objResponses = objBinding.GetObjects(WSIUtil.GetLocalization(), objRequestArray);
			}
			catch( System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while querying for containees: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}


			// Did we get some content?
			if( objResponses.Length < 1 )
			{
				MessageBox.Show("No content found");
				return;
			}
			if( objResponses[0].GetType() == typeof(CEWSI.ErrorStackResponse) )
			{
				CEWSI.ErrorStackResponse errStackResponse = (CEWSI.ErrorStackResponse)objResponses[0];
				CEWSI.ErrorStackType objStack = errStackResponse.ErrorStack;
				CEWSI.ErrorRecordType objErr = objStack.ErrorRecord[0];
				MessageBox.Show("Error [" + objErr.Description + "] occurred. " +
							" Err source is [" + objErr.Source + "]");
				return;
			}

			// Extract the document object from the response
			CEWSI.ObjectValue objDoc = null;
			if( objResponses[0].GetType() == typeof(CEWSI.SingleObjectResponse) )
			{
				CEWSI.SingleObjectResponse objResponse = (CEWSI.SingleObjectResponse)objResponses[0];
				objDoc = objResponse.Object;
			}
			else if( objResponses[0].GetType() == typeof(CEWSI.ObjectSetResponse) )
			{
				CEWSI.ObjectSetResponse objSetResponse = (CEWSI.ObjectSetResponse)objResponses[0];
				CEWSI.ObjectSetType objSet = objSetResponse.ObjectSet;
				objDoc = objSet.Object[0];
			}
			else
			{
				MessageBox.Show("Unknown data type returned in ObjectReponse: [" + objResponses[0].GetType().ToString() + "]");
				return;
			}

			// OK, we got some content.  Get the bits from the response packet
			// First find the ContentElements property
			/*
			if( objDoc.Property == null )
			{
				MessageBox.Show("Received a document with no properties!");
				return;
			}
			*/

			// Extract the content for each content element
			foreach( CEWSI.PropertyType objProp in objDoc.Property )
			{
				if (objProp.propertyId.ToLower().CompareTo("contentelements") == 0)
				{
					CEWSI.DependentObjectType[] contTrans = (CEWSI.DependentObjectType[])((CEWSI.ListOfObject)objProp).Value;
					if( contTrans == null )
					{
						MessageBox.Show("The selected document has no content");
						break;
					}
					for (int nItem=0; nItem<contTrans.Length; nItem++)
					{
						Byte[] byteContent = null;

                        if (UseGetContent)
                        {
                            CEWSI.ContentRequestType crt = new CEWSI.ContentRequestType();
                            crt.cacheAllowed = true;
                            crt.cacheAllowedSpecified = true;
                            crt.id = "1";
                            crt.maxBytes = 100 * 1024;
                            crt.maxBytesSpecified = true;
                            crt.startOffset = 0;
                            crt.startOffsetSpecified = true;
                            crt.continueFrom = null;

                            CEWSI.ElementSpecificationType est = new CEWSI.ElementSpecificationType();
                            est.itemIndex = nItem;
                            est.itemIndexSpecified = true;
                            est.elementSequenceNumber = 0;
                            est.elementSequenceNumberSpecified = false;

                            crt.ElementSpecification = est;

                            CEWSI.ObjectSpecification objSpec = new CEWSI.ObjectSpecification();
                            objSpec.classId = "Document";
                            objSpec.objectId = strId;
                            objSpec.objectStore = MainForm.Library;

                            crt.SourceSpecification = objSpec;

                            CEWSI.ContentRequestType[] contReqArray = new CEWSI.ContentRequestType[1];
                            contReqArray[0] = crt;

                            CEWSI.FNCEWS40PortTypeClient binding2 = WSIUtil.ConfigureBinding(MainForm.User,
                                MainForm.Domain, MainForm.Password, MainForm.URL);

                            // Send off the request
                            CEWSI.GetContentRequest gcr = new CEWSI.GetContentRequest();
                            gcr.ContentRequest = contReqArray;
                            gcr.validateOnly = false;
                            gcr.validateOnlySpecified = true;
                            CEWSI.ContentResponseType[] contResponses = null;
                            try
                            {
                                contResponses = binding2.GetContent(WSIUtil.GetLocalization(), gcr);
                            }
                            catch (System.Net.WebException ex)
                            {
                                MessageBox.Show("An exception occurred while fetching content for a content element: [" + ex.Message + "]");
                                return;
                            }
                            catch (Exception allEx)
                            {
                                MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
                                return;
                            }

                            CEWSI.ContentResponseType crt2 = contResponses[0];
                            if (crt2 is CEWSI.ContentErrorResponse)
                            {
                                CEWSI.ContentErrorResponse cer = (CEWSI.ContentErrorResponse)crt2;
                                CEWSI.ErrorStackType objStack = cer.ErrorStack;
                                CEWSI.ErrorRecordType objErr = objStack.ErrorRecord[0];
                                MessageBox.Show("Error [" + objErr.Description + "] occurred. " +
                                            " Err source is [" + objErr.Source + "]");
                                return;
                            }
                            else if (crt2 is CEWSI.ContentElementResponse)
                            {
                                CEWSI.ContentElementResponse elem = (CEWSI.ContentElementResponse)crt2;
                                CEWSI.InlineContent ic = (CEWSI.InlineContent)elem.Content;

                                byteContent = ic.Binary;
                            }
                            else
                            {
                                MessageBox.Show("Unknown data type returned in content response: [" + crt.GetType().ToString() + "]");
                                return;
                            }
                        }       // end if (UseGetContent)
                        else
                        {
                            CEWSI.DependentObjectType contTran = (CEWSI.DependentObjectType)contTrans[nItem];
                            CEWSI.PropertyType[] props = (CEWSI.PropertyType[])contTran.Property;
                            if (props != null)
                            {
                                CEWSI.ContentData contData = (CEWSI.ContentData)props[0];
                                CEWSI.InlineContent ic = (CEWSI.InlineContent)contData.Value;

                                byteContent = ic.Binary;
                            }
                        }

                        // Write the retrieved content out to a file
						System.DateTime now = System.DateTime.Now;
						string strFileName = "C:\\Temp\\ContentElement0"; // + nItem.ToString();
						strFileName = strFileName + "_" + now.Month.ToString();
						strFileName = strFileName + "_" + now.Day.ToString();
						strFileName = strFileName + "_" + now.Year.ToString();
						strFileName = strFileName + "_" + now.Hour.ToString();
						strFileName = strFileName + "_" + now.Minute.ToString();
						strFileName = strFileName + "_" + now.Millisecond.ToString();
						MessageBox.Show("Saving content of size " + byteContent.Length.ToString() + " to file: " + strFileName);
						saveContentToFile(strFileName, byteContent);
					}
				}
			}
		}

		public void saveContentToFile(string strName, byte[] binaryData)
		{
			try 
			{
				System.IO.FileStream outFile = new System.IO.FileStream(strName,
					System.IO.FileMode.CreateNew,
					System.IO.FileAccess.Write);
				outFile.Write(binaryData, 0, (int)binaryData.Length);
				outFile.Close();
			}
			catch( System.IO.DirectoryNotFoundException )
			{
				MessageBox.Show("Cannot save content because there is no C:\\Temp directory.  This app requires C:\\Temp");
				return;
			}
			catch (System.Exception exp) 
			{
				MessageBox.Show("Exception occurred writing to " + strName + " : [" + exp.ToString() + "]");
				return;
			}
			return;
		}
	}
}
