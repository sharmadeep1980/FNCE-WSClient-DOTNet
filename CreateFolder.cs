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
	/// Summary description for CreateFolder.
	/// </summary>
	public class CreateFolder : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.TextBox txtFolderClass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtParent;

		// Private state
		private Form1 MainForm;

		public CreateFolder()
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
			this.txtParent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFolderClass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txtParent);
			this.GroupBox1.Controls.Add(this.label1);
			this.GroupBox1.Controls.Add(this.txtFolderClass);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.btnCreate);
			this.GroupBox1.Location = new System.Drawing.Point(24, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(624, 128);
			this.GroupBox1.TabIndex = 9;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Folder Parameters";
			// 
			// txtParent
			// 
			this.txtParent.Location = new System.Drawing.Point(104, 48);
			this.txtParent.Name = "txtParent";
			this.txtParent.Size = new System.Drawing.Size(528, 20);
			this.txtParent.TabIndex = 2;
			this.txtParent.Text = "/";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Parent:";
			// 
			// txtFolderClass
			// 
			this.txtFolderClass.Location = new System.Drawing.Point(104, 80);
			this.txtFolderClass.Name = "txtFolderClass";
			this.txtFolderClass.Size = new System.Drawing.Size(240, 20);
			this.txtFolderClass.TabIndex = 3;
			this.txtFolderClass.Text = "Folder";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Folder Class:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(528, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(16, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Name:";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(536, 80);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(80, 23);
			this.btnCreate.TabIndex = 5;
			this.btnCreate.Text = "Create Now";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(280, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 23);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// CreateFolder
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 197);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "CreateFolder";
			this.Text = "CreateFolder";
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
			// Create the ChangeRequest
			CEWSI.ChangeRequestType objChange = new CEWSI.ChangeRequestType();
			CEWSI.CreateAction createVerb = new CEWSI.CreateAction();
			createVerb.classId = txtFolderClass.Text;
			objChange.Action = new CEWSI.ActionType[1];
			objChange.Action[0] = (CEWSI.ActionType)createVerb;
			objChange.TargetSpecification = new CEWSI.ObjectReference();
			objChange.TargetSpecification.classId = "ObjectStore";
			objChange.TargetSpecification.objectId = MainForm.Library;
			objChange.id = "1";

			CEWSI.ModifiablePropertyType[] objInputProps = new CEWSI.ModifiablePropertyType[2];
			objChange.ActionProperties = objInputProps;

			// Build a list of properties to set in the new folder (just the folder name and parent for now)
			//    -Folder name property
			CEWSI.SingletonString objString = new CEWSI.SingletonString();
			objString.Value = txtName.Text;
			objString.propertyId = "FolderName";
			objInputProps[0] = objString;

			//    -Parent property
			CEWSI.ObjectSpecification objSpec = new CEWSI.ObjectSpecification();
			CEWSI.SingletonObject objObject = new CEWSI.SingletonObject();
			objSpec.classId = "Folder";
			objSpec.path = txtParent.Text;
			objSpec.objectStore = MainForm.Library;
			objObject.propertyId = "Parent";
			objObject.Value = (CEWSI.ObjectEntryType)objSpec;
			objInputProps[1] = objObject;

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
				MessageBox.Show("An exception occurred while creating a folder: [" + ex.Message + "]");
				return;
			}
			catch(Exception allEx)
			{
				MessageBox.Show("An exception occurred: [" + allEx.Message + "]");
				return;
			}

			// Created a folder!  Sanity check the results
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
				MessageBox.Show("The folder was created, but the results do not contain a folder ID!");
				return;
			}
			MessageBox.Show("Successfully created a folder!  ID = [" + strObjectId + "]");
			return;
		}
	}
}
