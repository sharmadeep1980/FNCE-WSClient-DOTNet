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
using System.Data;

namespace CEWebClientCS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TextBox txtUser;
		internal System.Windows.Forms.TextBox txtURL;
		internal System.Windows.Forms.Label lblLogonUser;
		internal System.Windows.Forms.Label lblConnecting;
		internal System.Windows.Forms.Button btnChangeServer;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// Client config state
		public String URL = "https://<hostname>:<sslport>/wsi/FNCEWS40MTOM/";
		public String User = "user_name";
		public String Domain = "";
		public String Library = "object_store_name";
		public String Password = "password";

		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox txtLibrary;
		private System.Windows.Forms.Button btnAdhocQuery;
		private System.Windows.Forms.Button btnCreateDoc;
		private System.Windows.Forms.Button btnFolderTree;
		private System.Windows.Forms.Button btnCreateFolder;
		private System.Windows.Forms.Button btnCreatePTemp;
		private System.Windows.Forms.Button btnCreateClass;


		public Form1()
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
				if (components != null) 
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
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.txtLibrary = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.lblLogonUser = new System.Windows.Forms.Label();
			this.lblConnecting = new System.Windows.Forms.Label();
			this.btnChangeServer = new System.Windows.Forms.Button();
			this.btnAdhocQuery = new System.Windows.Forms.Button();
			this.btnCreateDoc = new System.Windows.Forms.Button();
			this.btnFolderTree = new System.Windows.Forms.Button();
			this.btnCreateFolder = new System.Windows.Forms.Button();
			this.btnCreatePTemp = new System.Windows.Forms.Button();
			this.btnCreateClass = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(440, 128);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.txtLibrary);
			this.GroupBox3.Controls.Add(this.label1);
			this.GroupBox3.Controls.Add(this.txtUser);
			this.GroupBox3.Controls.Add(this.txtURL);
			this.GroupBox3.Controls.Add(this.lblLogonUser);
			this.GroupBox3.Controls.Add(this.lblConnecting);
			this.GroupBox3.Controls.Add(this.btnChangeServer);
			this.GroupBox3.Location = new System.Drawing.Point(24, 8);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(584, 72);
			this.GroupBox3.TabIndex = 12;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Server Config";
			// 
			// txtLibrary
			// 
			this.txtLibrary.Enabled = false;
			this.txtLibrary.Location = new System.Drawing.Point(112, 16);
			this.txtLibrary.Name = "txtLibrary";
			this.txtLibrary.Size = new System.Drawing.Size(128, 20);
			this.txtLibrary.TabIndex = 18;
			this.txtLibrary.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(248, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "At:";
			// 
			// txtUser
			// 
			this.txtUser.Enabled = false;
			this.txtUser.Location = new System.Drawing.Point(112, 40);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(376, 20);
			this.txtUser.TabIndex = 16;
			this.txtUser.Text = "";
			// 
			// txtURL
			// 
			this.txtURL.Enabled = false;
			this.txtURL.Location = new System.Drawing.Point(280, 16);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(208, 20);
			this.txtURL.TabIndex = 15;
			this.txtURL.Text = "";
			// 
			// lblLogonUser
			// 
			this.lblLogonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLogonUser.Location = new System.Drawing.Point(72, 40);
			this.lblLogonUser.Name = "lblLogonUser";
			this.lblLogonUser.Size = new System.Drawing.Size(36, 16);
			this.lblLogonUser.TabIndex = 14;
			this.lblLogonUser.Text = "As:";
			// 
			// lblConnecting
			// 
			this.lblConnecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblConnecting.Location = new System.Drawing.Point(8, 16);
			this.lblConnecting.Name = "lblConnecting";
			this.lblConnecting.Size = new System.Drawing.Size(88, 23);
			this.lblConnecting.TabIndex = 13;
			this.lblConnecting.Text = "Connecting To:";
			// 
			// btnChangeServer
			// 
			this.btnChangeServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnChangeServer.Location = new System.Drawing.Point(504, 16);
			this.btnChangeServer.Name = "btnChangeServer";
			this.btnChangeServer.Size = new System.Drawing.Size(72, 24);
			this.btnChangeServer.TabIndex = 1;
			this.btnChangeServer.Text = "Change";
			this.btnChangeServer.Click += new System.EventHandler(this.btnChangeServer_Click);
			// 
			// btnAdhocQuery
			// 
			this.btnAdhocQuery.Location = new System.Drawing.Point(24, 96);
			this.btnAdhocQuery.Name = "btnAdhocQuery";
			this.btnAdhocQuery.Size = new System.Drawing.Size(96, 23);
			this.btnAdhocQuery.TabIndex = 2;
			this.btnAdhocQuery.Text = "Ad hoc Query";
			this.btnAdhocQuery.Click += new System.EventHandler(this.btnAdhocQuery_Click);
			// 
			// btnCreateDoc
			// 
			this.btnCreateDoc.Location = new System.Drawing.Point(512, 96);
			this.btnCreateDoc.Name = "btnCreateDoc";
			this.btnCreateDoc.Size = new System.Drawing.Size(96, 23);
			this.btnCreateDoc.TabIndex = 5;
			this.btnCreateDoc.Text = "Create a Doc";
			this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
			// 
			// btnFolderTree
			// 
			this.btnFolderTree.Location = new System.Drawing.Point(192, 96);
			this.btnFolderTree.Name = "btnFolderTree";
			this.btnFolderTree.Size = new System.Drawing.Size(80, 23);
			this.btnFolderTree.TabIndex = 3;
			this.btnFolderTree.Text = "Folder Tree";
			this.btnFolderTree.Click += new System.EventHandler(this.btnFolderTree_Click);
			// 
			// btnCreateFolder
			// 
			this.btnCreateFolder.Location = new System.Drawing.Point(344, 96);
			this.btnCreateFolder.Name = "btnCreateFolder";
			this.btnCreateFolder.Size = new System.Drawing.Size(96, 23);
			this.btnCreateFolder.TabIndex = 4;
			this.btnCreateFolder.Text = "Create a Folder";
			this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
			// 
			// btnCreatePTemp
			// 
			this.btnCreatePTemp.Location = new System.Drawing.Point(72, 128);
			this.btnCreatePTemp.Name = "btnCreatePTemp";
			this.btnCreatePTemp.Size = new System.Drawing.Size(152, 24);
			this.btnCreatePTemp.TabIndex = 6;
			this.btnCreatePTemp.Text = "Create a Property Template";
			this.btnCreatePTemp.Click += new System.EventHandler(this.btnCreatePTemp_Click);
			// 
			// btnCreateClass
			// 
			this.btnCreateClass.Location = new System.Drawing.Point(256, 128);
			this.btnCreateClass.Name = "btnCreateClass";
			this.btnCreateClass.Size = new System.Drawing.Size(144, 24);
			this.btnCreateClass.TabIndex = 7;
			this.btnCreateClass.Text = "Create a Class";
			this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 165);
			this.Controls.Add(this.btnCreateClass);
			this.Controls.Add(this.btnCreatePTemp);
			this.Controls.Add(this.btnCreateFolder);
			this.Controls.Add(this.btnFolderTree);
			this.Controls.Add(this.btnCreateDoc);
			this.Controls.Add(this.btnAdhocQuery);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.btnClose);
			this.Name = "Form1";
			this.Text = "FileNet Content Engine Web Service Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.GroupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnChangeServer_Click(object sender, System.EventArgs e)
		{
			ServerConfig  configWindow = new ServerConfig();

			configWindow.FormInit(this);
			configWindow.Activate();
			configWindow.Show();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//txtUser.Text = User + "@" + Domain;
			txtUser.Text = User;
			txtLibrary.Text = Library;
			txtURL.Text = URL;
		}

		public void RefreshForm()
		{
			//txtUser.Text = User + "@" + Domain;
			txtUser.Text = User;
			txtLibrary.Text = Library;
			txtURL.Text = URL;
		}


		private void btnAdhocQuery_Click(object sender, System.EventArgs e)
		{
			AdhocQuery  queryWindow = new AdhocQuery();

			queryWindow.FormInit(this);
			queryWindow.Activate();
			queryWindow.Show();
		}

		private void btnCreateDoc_Click(object sender, System.EventArgs e)
		{
			CreateDoc  createDocWindow = new CreateDoc();

			createDocWindow.FormInit(this);
			createDocWindow.Activate();
			createDocWindow.Show();
		}

		private void btnFolderTree_Click(object sender, System.EventArgs e)
		{
			FolderTree  folderTreeWindow = new FolderTree();

			folderTreeWindow.FormInit(this);
			folderTreeWindow.Activate();
			folderTreeWindow.Show();
		}

		private void btnCreateFolder_Click(object sender, System.EventArgs e)
		{
			CreateFolder  createFolderWindow = new CreateFolder();

			createFolderWindow.FormInit(this);
			createFolderWindow.Activate();
			createFolderWindow.Show();
		}

		private void btnCreatePTemp_Click(object sender, System.EventArgs e)
		{
			CreatePropTemplate  createPTempWindow = new CreatePropTemplate();

			createPTempWindow.FormInit(this);
			createPTempWindow.Activate();
			createPTempWindow.Show();
		}

		private void btnCreateClass_Click(object sender, System.EventArgs e)
		{
			CreateClassSelect  createClassWindow = new CreateClassSelect();

			createClassWindow.FormInit(this);
			createClassWindow.Activate();
			createClassWindow.Show();
		}
	}
}
