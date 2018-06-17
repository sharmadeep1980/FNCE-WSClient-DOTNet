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
	/// Summary description for ServerConfig.
	/// </summary>
	public class ServerConfig : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtURL;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtUser;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.TextBox txtDomain;
		internal System.Windows.Forms.TextBox txtLibrary;

		// Private state
		private Form1 MainForm;

		public ServerConfig()
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
		/// Called by the main form to initialize this form
		/// </summary>
		/// <param name="mForm"></param>
		public void FormInit(Form1 mForm)
		{
			MainForm = mForm;
			txtUser.Text = mForm.User;
			txtPassword.Text = mForm.Password;
			txtURL.Text = mForm.URL;
			txtDomain.Text = mForm.Domain;
			txtLibrary.Text = mForm.Library;
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLibrary = new System.Windows.Forms.TextBox();
			this.txtDomain = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(248, 136);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(480, 96);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txtLibrary);
			this.GroupBox1.Controls.Add(this.txtDomain);
			this.GroupBox1.Controls.Add(this.label5);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.txtURL);
			this.GroupBox1.Controls.Add(this.txtPassword);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtUser);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(552, 112);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Server Config";
			// 
			// txtLibrary
			// 
			this.txtLibrary.Location = new System.Drawing.Point(368, 48);
			this.txtLibrary.Name = "txtLibrary";
			this.txtLibrary.Size = new System.Drawing.Size(168, 20);
			this.txtLibrary.TabIndex = 4;
			this.txtLibrary.Text = "";
			// 
			// txtDomain
			// 
			this.txtDomain.Enabled = false;
			this.txtDomain.Location = new System.Drawing.Point(96, 48);
			this.txtDomain.Name = "txtDomain";
			this.txtDomain.Size = new System.Drawing.Size(176, 20);
			this.txtDomain.TabIndex = 3;
			this.txtDomain.Text = "";
			this.txtDomain.Visible = false;
			// 
			// label5
			// 
			this.label5.Enabled = false;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Domain:";
			this.label5.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(288, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Object Store:";
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(96, 80);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(272, 20);
			this.txtURL.TabIndex = 5;
			this.txtURL.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(368, 24);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(168, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			// 
			// Label3
			// 
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(288, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 16);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Password:";
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(16, 80);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Server URI:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(96, 24);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(176, 20);
			this.txtUser.TabIndex = 1;
			this.txtUser.Text = "";
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "User:";
			// 
			// ServerConfig
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 165);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "ServerConfig";
			this.Text = "ServerConfig";
			this.Load += new System.EventHandler(this.ServerConfig_Load);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			MainForm.User = txtUser.Text;
			MainForm.Password = txtPassword.Text;
			MainForm.URL = txtURL.Text;
			MainForm.Domain = txtDomain.Text;
			MainForm.Library = txtLibrary.Text;
			MainForm.RefreshForm();
			MessageBox.Show("Successfully updated configuration");
		}

		private void ServerConfig_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
