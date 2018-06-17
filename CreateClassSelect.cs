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
	/// Summary description for CreateClassSelect.
	/// </summary>
	public class CreateClassSelect : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dgrdResults;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnCreateSubclass;
		private System.Windows.Forms.CheckBox chkIncludeSystem;
		private System.Windows.Forms.CheckBox chkIncludeHidden;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		internal System.Windows.Forms.Button button1;
		internal System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtSymbolicName;
		internal System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CreateClassSelect()
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
            this.btnCreateSubclass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrdResults = new System.Windows.Forms.DataGrid();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIncludeHidden = new System.Windows.Forms.CheckBox();
            this.chkIncludeSystem = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSymbolicName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResults)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateSubclass
            // 
            this.btnCreateSubclass.Enabled = false;
            this.btnCreateSubclass.Location = new System.Drawing.Point(152, 416);
            this.btnCreateSubclass.Name = "btnCreateSubclass";
            this.btnCreateSubclass.Size = new System.Drawing.Size(120, 23);
            this.btnCreateSubclass.TabIndex = 6;
            this.btnCreateSubclass.Text = "Create Subclass";
            this.btnCreateSubclass.Click += new System.EventHandler(this.btnCreateSubclass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrdResults);
            this.groupBox2.Location = new System.Drawing.Point(24, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 168);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query Results";
            // 
            // dgrdResults
            // 
            this.dgrdResults.DataMember = "";
            this.dgrdResults.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgrdResults.Location = new System.Drawing.Point(8, 24);
            this.dgrdResults.Name = "dgrdResults";
            this.dgrdResults.PreferredColumnWidth = 140;
            this.dgrdResults.Size = new System.Drawing.Size(608, 136);
            this.dgrdResults.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.groupBox3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.chkIncludeHidden);
            this.GroupBox1.Controls.Add(this.chkIncludeSystem);
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this.lblName);
            this.GroupBox1.Location = new System.Drawing.Point(24, 16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(624, 136);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Specify Parent Class";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(8, 624);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(208, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Include Hidden Classes";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(16, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(176, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Include System Classes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Query Now";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click the Query Now button to generate a list of sub-classable class definitions." +
                "  Then select the desired class definition and click the Create Subclass button." +
                "";
            // 
            // chkIncludeHidden
            // 
            this.chkIncludeHidden.Location = new System.Drawing.Point(208, 104);
            this.chkIncludeHidden.Name = "chkIncludeHidden";
            this.chkIncludeHidden.Size = new System.Drawing.Size(176, 24);
            this.chkIncludeHidden.TabIndex = 3;
            this.chkIncludeHidden.Text = "Include Hidden Classes";
            // 
            // chkIncludeSystem
            // 
            this.chkIncludeSystem.Location = new System.Drawing.Point(16, 104);
            this.chkIncludeSystem.Name = "chkIncludeSystem";
            this.chkIncludeSystem.Size = new System.Drawing.Size(176, 24);
            this.chkIncludeSystem.TabIndex = 2;
            this.chkIncludeSystem.Text = "Include System Classes";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name Filter:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(544, 120);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Query Now";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(416, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSymbolicName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(24, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 56);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class Parameters";
            // 
            // txtSymbolicName
            // 
            this.txtSymbolicName.Location = new System.Drawing.Point(112, 24);
            this.txtSymbolicName.Name = "txtSymbolicName";
            this.txtSymbolicName.Size = new System.Drawing.Size(504, 20);
            this.txtSymbolicName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Symbolic Name:";
            // 
            // CreateClassSelect
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCreateSubclass);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.GroupBox1);
            this.Name = "CreateClassSelect";
            this.Text = "Create Class";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResults)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		// Private state
		private Form1 MainForm;
		private CEWSI.ObjectValue[] g_Classes;

		public void FormInit(Form1 mForm)
		{
			MainForm = mForm;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnQuery_Click(object sender, System.EventArgs e)
		{
			CEWSI.ObjectSetType objResponse = null;

			// Perform the requested query
			try
			{
				// Set up a connection to the web service.
				// Fill in the security headers...
                CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                    MainForm.Domain, MainForm.Password, MainForm.URL);

				// Create a search object
				// Set up the scope for the query
				// Set up the SQL for the search
				CEWSI.RepositorySearch objSearch = new CEWSI.RepositorySearch();
				CEWSI.ObjectStoreScope objSearchScope = new CEWSI.ObjectStoreScope();
				objSearchScope.objectStore = MainForm.Library;
				objSearch.SearchScope = objSearchScope;
				objSearch.SearchSQL = "SELECT SymbolicName, Id, IsHidden, IsSystemOwned, This FROM ClassDefinition ";
				objSearch.SearchSQL = objSearch.SearchSQL + " WHERE AllowsSubclasses=TRUE";

				if( txtName.Text != "" )
					objSearch.SearchSQL = objSearch.SearchSQL + " AND SymbolicName LIKE '" + txtName.Text + "%'";
				if( !chkIncludeSystem.Checked )
					objSearch.SearchSQL = objSearch.SearchSQL + " AND IsSystemOwned=FALSE";
				if( !chkIncludeHidden.Checked )
					objSearch.SearchSQL = objSearch.SearchSQL + " AND IsHidden=FALSE";

				// Execute the search
				objResponse = objBinding.ExecuteSearch(WSIUtil.GetLocalization() ,objSearch);
			}
			catch( System.Net.WebException ex)
			{
				MessageBox.Show("An exception occurred while querying: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}

			// Sanity check the results data
			long lColumnCount = 0;
			long lRowCount = 0;
			long i;
			if( objResponse==null || objResponse.Object==null )
			{
				MessageBox.Show("The query completed successfully but the results were null!");
				return;
			}
			if( objResponse.Object.Length < 1 )
			{
				MessageBox.Show("No results were found for this query.");
				return;
			}
			lColumnCount = objResponse.Object[0].Property.Length;
			if( lColumnCount < 5 )
			{
				MessageBox.Show("The query succeeded, but the results are missing requested data");
				return;
			}

			// Query was successful; display a list of result rows
			// First create a data table that has one column for each property
			System.Data.DataColumn dtCol;
			System.Data.DataRow dtRow;
			CEWSI.PropertyType prop;

			g_Classes = objResponse.Object;
			lRowCount = g_Classes.Length;
			System.Data.DataTable dtblResults = new System.Data.DataTable("Results");

			// Name
			dtCol = new System.Data.DataColumn("Name");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			// Class
			dtCol = new System.Data.DataColumn("Class");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			// IsSystem
			dtCol = new System.Data.DataColumn("IsSystem");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			// IsHidden
			dtCol = new System.Data.DataColumn("IsHidden");
			dtCol.DataType = System.Type.GetType("System.String");
			dtCol.DefaultValue = "";
			dtblResults.Columns.Add(dtCol);

			// Populate the rows
			CEWSI.ObjectReference objRef;
			for(i=0; i<lRowCount; i++)
			{
				dtRow = dtblResults.NewRow();
				prop = g_Classes[i].Property[0];
				dtRow["Name"] = IdmObjectType.getPropertyValue(prop);
				prop = g_Classes[i].Property[4];
				objRef = (CEWSI.ObjectReference)((CEWSI.SingletonObject)prop).Value;
				dtRow["Class"] = objRef.classId;
				prop = g_Classes[i].Property[3];
				dtRow["IsSystem"] = IdmObjectType.getPropertyValue(prop);
				prop = g_Classes[i].Property[2];
				dtRow["IsHidden"] = IdmObjectType.getPropertyValue(prop);

				dtblResults.Rows.Add(dtRow);
			}
			dgrdResults.PreferredColumnWidth = 140;
			dgrdResults.DataSource = dtblResults;
			dgrdResults.Show();
			btnCreateSubclass.Enabled = true;
			return;
		}

		private void btnCreateSubclass_Click(object sender, System.EventArgs e)
		{
			String				strParentClassName;
			String				strParentClassId;
			int					iRow;
			CEWSI.PropertyType	prop;
			CEWSI.ObjectReference objRef;

			// First find the selected parent class, and extract the name and ID for it
			iRow = dgrdResults.CurrentRowIndex;
			if( iRow<0 )
			{
				MessageBox.Show("Please select a class first");
				return;
			}
			prop = g_Classes[iRow].Property[4];
			if( prop==null )
			{
				MessageBox.Show("Cannot find the This property");
				return;
			}
			if (prop.GetType() == typeof(CEWSI.SingletonObject))
			{
				CEWSI.SingletonObject objSO = (CEWSI.SingletonObject)prop;
				objRef = (CEWSI.ObjectReference)((CEWSI.SingletonObject)prop).Value;
				try
				{
					objRef = (CEWSI.ObjectReference)objSO.Value;
					strParentClassName = objRef.classId;
					strParentClassId = objRef.objectId;
				}
				catch (System.Exception)
				{
					MessageBox.Show("Cannot extract the class and Id of the selected item");
					return;
				}
				

			}
			else
			{
				MessageBox.Show("Expected to find an object valued property");
				return;
			}

			// Create a Create verb, populate it
			CEWSI.CreateAction createVerb = new CEWSI.CreateAction();
			createVerb.classId = strParentClassName;

			CEWSI.ChangeRequestType objChange = new CEWSI.ChangeRequestType();
			objChange.Action = new CEWSI.ActionType[1];
			objChange.TargetSpecification = new CEWSI.ObjectReference();
			objChange.TargetSpecification.classId = strParentClassName;
			objChange.TargetSpecification.objectId = strParentClassId;
			objChange.TargetSpecification.objectStore = MainForm.Library;
			objChange.id = "1";

			// Build a list of properties to set in the new property template
			// The following meta-properties will be set:
			//   SymbolicName		String
			//   DisplayNames		ListOfObject
			CEWSI.ModifiablePropertyType[] objInputProps = new CEWSI.ModifiablePropertyType[2];

			// Symbolic name
			CEWSI.SingletonString objSymName = new CEWSI.SingletonString();
			objSymName.Value = txtSymbolicName.Text;
			objSymName.propertyId = "SymbolicName";
			objInputProps[0] = objSymName;

			// Set up the DisplayNames property
			//  DisplayNames is a dependent object that has the following properties:
			//    LocaleName		String
			//    LocalizedText		String
			CEWSI.ListOfObject objNameList = new CEWSI.ListOfObject();
			objNameList.propertyId = "DisplayNames";
			CEWSI.DependentObjectType[] theNames = new CEWSI.DependentObjectType[1];
			CEWSI.DependentObjectType dispName = new CEWSI.DependentObjectType();
			theNames[0] = dispName;
			objNameList.Value = theNames;

			dispName.dependentAction = CEWSI.DependentObjectTypeDependentAction.Insert;
			dispName.dependentActionSpecified = true;
			dispName.classId = "LocalizedString";

			CEWSI.PropertyType[] nameProps = new CEWSI.PropertyType[2];
			CEWSI.SingletonString objLocale = new CEWSI.SingletonString();
			objLocale.propertyId = "LocaleName";
			objLocale.Value = "en-us";
			nameProps[0] = objLocale;

			CEWSI.SingletonString objText = new CEWSI.SingletonString();
			objText.propertyId = "LocalizedText";
			objText.Value = txtSymbolicName.Text;
			nameProps[1] = objText;
			dispName.Property = nameProps;

			objInputProps[1] = objNameList;
			objChange.ActionProperties = objInputProps;
			objChange.Action[0] = (CEWSI.ActionType)createVerb;

			// Fill in the security headers...
            CEWSI.FNCEWS40PortTypeClient objBinding = WSIUtil.ConfigureBinding(MainForm.User,
                                            MainForm.Domain, MainForm.Password, MainForm.URL);
			
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
				MessageBox.Show("An exception occurred while creating a new class: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}


			// Created a class!  Sanity check the results
			string strObjectId = "";
			bool bFound = false;

			if( objResponseArray==null || objResponseArray.Length < 1 )
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
				MessageBox.Show("The class was created, but the results do not contain an ID!");
				return;
			}
			MessageBox.Show("Successfully created a new class!  ID = [" + strObjectId + "]");
			return;
		}
	}
}
