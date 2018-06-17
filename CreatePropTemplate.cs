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
	/// Summary description for CreatePropTemplate.
	/// </summary>
	public class CreatePropTemplate : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtSymName;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ComboBox cmbDataType;

		// Private state
		private Form1 MainForm;

		public CreatePropTemplate()
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbDataType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSymName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.cmbDataType);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.txtSymName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.btnCreate);
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(624, 120);
			this.GroupBox1.TabIndex = 11;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Property Template Parameters";
			// 
			// cmbDataType
			// 
			this.cmbDataType.AllowDrop = true;
			this.cmbDataType.Items.AddRange(new object[] {
															 "String",
															 "Integer",
															 "Float",
															 "Boolean",
															 "ID",
															 "Binary",
															 "DateTime"});
			this.cmbDataType.Location = new System.Drawing.Point(112, 88);
			this.cmbDataType.Name = "cmbDataType";
			this.cmbDataType.Size = new System.Drawing.Size(121, 21);
			this.cmbDataType.TabIndex = 2;
			this.cmbDataType.Text = "String";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Data Type:";
			// 
			// txtSymName
			// 
			this.txtSymName.Location = new System.Drawing.Point(112, 24);
			this.txtSymName.Name = "txtSymName";
			this.txtSymName.Size = new System.Drawing.Size(504, 20);
			this.txtSymName.TabIndex = 1;
			this.txtSymName.Text = "";
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(16, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Symbolic Name:";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(536, 88);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(80, 23);
			this.btnCreate.TabIndex = 3;
			this.btnCreate.Text = "Create Now";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(288, 144);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// CreatePropTemplate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 173);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "CreatePropTemplate";
			this.Text = "CreatePropTemplate";
			this.GroupBox1.ResumeLayout(false);
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

		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			// We first need to create a Create verb, populate it
			CEWSI.CreateAction createVerb = new CEWSI.CreateAction();

			CEWSI.ChangeRequestType objChange = new CEWSI.ChangeRequestType();
			objChange.Action = new CEWSI.ActionType[1];
			objChange.TargetSpecification = new CEWSI.ObjectReference();
			objChange.TargetSpecification.classId = "ObjectStore";
			objChange.TargetSpecification.objectId = MainForm.Library;
			objChange.id = "1";

			// Build a list of properties to set in the new property template
			// The following meta-properties will be set:
			//   SymbolicName		String
			//   IsNameProperty		Boolean
			//   Cardinality		Integer
			//   IsPersistent		Boolean
			//   DisplayNames		ListOfObject
			CEWSI.ModifiablePropertyType[] objInputProps = new CEWSI.ModifiablePropertyType[5];

			// Symbolic name
			CEWSI.SingletonString objSymName = new CEWSI.SingletonString();
			objSymName.Value = txtSymName.Text;
			objSymName.propertyId = "SymbolicName";
			objInputProps[0] = objSymName;

			// Hardcode the IsNameProperty for now
			CEWSI.SingletonBoolean objIsName = new CEWSI.SingletonBoolean();
			objIsName.Value = false;
			objIsName.ValueSpecified = true;
			objIsName.propertyId = "IsNameProperty";
			objInputProps[1] = objIsName;

			// Hardcode the Cardinality for now
			CEWSI.SingletonInteger32 objCardinality = new CEWSI.SingletonInteger32();
			objCardinality.Value = 0;
			objCardinality.ValueSpecified = true;
			objCardinality.propertyId = "Cardinality";
			objInputProps[2] = objCardinality;

			// Hardcode the IsPersistent property for now
			CEWSI.SingletonBoolean objIsPersistent = new CEWSI.SingletonBoolean();
			objIsPersistent.Value = true;
			objIsPersistent.ValueSpecified = true;
			objIsPersistent.propertyId = "IsPersistent";
			objInputProps[3] = objIsPersistent;

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
			objText.Value = txtSymName.Text;
			nameProps[1] = objText;
			dispName.Property = nameProps;

			objInputProps[4] = objNameList;

			// Set the class of the new template according to the data type
			switch(cmbDataType.Text)
			{
				case "String":
					createVerb.classId = "PropertyTemplateString";
					break;
				case "Boolean":
					createVerb.classId = "PropertyTemplateBoolean";
					break;
				case "Float":
					createVerb.classId = "PropertyTemplateFloat64";
					break;
				case "Integer":
					createVerb.classId = "PropertyTemplateInteger32";
					break;
				case "ID":
					createVerb.classId = "PropertyTemplateId";
					break;
				case "Object":
					createVerb.classId = "PropertyTemplateObject";
					break;
				case "Binary":
					createVerb.classId = "PropertyTemplateBinary";
					break;
				case "DateTime":
					createVerb.classId = "PropertyTemplateDateTime";
					break;
				default:
					MessageBox.Show("Invalid property type selected!");
					return;
			}
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
				MessageBox.Show("An exception occurred while creating a property template: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}


			// Created a template!  Sanity check the results
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
				MessageBox.Show("The property template was created, but the results do not contain an ID!");
				return;
			}
			MessageBox.Show("Successfully created a property template!  ID = [" + strObjectId + "]");
			return;
		}
	}
}
