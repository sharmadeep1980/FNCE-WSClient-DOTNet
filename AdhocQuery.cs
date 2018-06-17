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
using System.Text;
using System.Net;

namespace CEWebClientCS
{
	/// <summary>
	/// Summary description for AdhocQuery.
	/// </summary>
	public class AdhocQuery : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Button btnQuery;
		internal System.Windows.Forms.TextBox txtSelect;
		internal System.Windows.Forms.TextBox txtFrom;
		internal System.Windows.Forms.TextBox txtWhere;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dgrdResults;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.TextBox txtMaxRows;

		// Private state
		private Form1 MainForm;

		public AdhocQuery()
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
			this.btnQuery = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMaxRows = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtWhere = new System.Windows.Forms.TextBox();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSelect = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgrdResults = new System.Windows.Forms.DataGrid();
			this.GroupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgrdResults)).BeginInit();
			this.SuspendLayout();
			// 
			// btnQuery
			// 
			this.btnQuery.Location = new System.Drawing.Point(536, 104);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(80, 23);
			this.btnQuery.TabIndex = 5;
			this.btnQuery.Text = "Query Now";
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txtMaxRows);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.txtWhere);
			this.GroupBox1.Controls.Add(this.txtFrom);
			this.GroupBox1.Controls.Add(this.label3);
			this.GroupBox1.Controls.Add(this.label1);
			this.GroupBox1.Controls.Add(this.txtSelect);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.btnQuery);
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(624, 136);
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Query Parameters";
			// 
			// txtMaxRows
			// 
			this.txtMaxRows.Location = new System.Drawing.Point(88, 104);
			this.txtMaxRows.Name = "txtMaxRows";
			this.txtMaxRows.Size = new System.Drawing.Size(136, 20);
			this.txtMaxRows.TabIndex = 4;
			this.txtMaxRows.Text = "100";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Max Rows:";
			// 
			// txtWhere
			// 
			this.txtWhere.Location = new System.Drawing.Point(88, 72);
			this.txtWhere.Name = "txtWhere";
			this.txtWhere.Size = new System.Drawing.Size(528, 20);
			this.txtWhere.TabIndex = 3;
			this.txtWhere.Text = "IsCurrentVersion=true";
			// 
			// txtFrom
			// 
			this.txtFrom.Location = new System.Drawing.Point(88, 46);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(528, 20);
			this.txtFrom.TabIndex = 2;
			this.txtFrom.Text = "Document";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "WHERE:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "FROM:";
			// 
			// txtSelect
			// 
			this.txtSelect.Location = new System.Drawing.Point(88, 24);
			this.txtSelect.Name = "txtSelect";
			this.txtSelect.Size = new System.Drawing.Size(528, 20);
			this.txtSelect.TabIndex = 1;
			this.txtSelect.Text = "DocumentTitle";

			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(16, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "SELECT:";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(288, 448);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgrdResults);
			this.groupBox2.Location = new System.Drawing.Point(16, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(624, 280);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Query Results";
			// 
			// dgrdResults
			// 
			this.dgrdResults.DataMember = "";
			this.dgrdResults.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgrdResults.Location = new System.Drawing.Point(8, 16);
			this.dgrdResults.Name = "dgrdResults";
			this.dgrdResults.Size = new System.Drawing.Size(608, 256);
			this.dgrdResults.TabIndex = 0;
			// 
			// AdhocQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 477);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "AdhocQuery";
			this.Text = "AdhocQuery";
			this.Load += new System.EventHandler(this.AdhocQuery_Load);
			this.GroupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgrdResults)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void AdhocQuery_Load(object sender, System.EventArgs e)
		{
		
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
				objSearch.SearchSQL = "SELECT ";
				if( txtSelect.Text == "" )
					objSearch.SearchSQL = objSearch.SearchSQL + "*";
				else
					objSearch.SearchSQL = objSearch.SearchSQL + txtSelect.Text;
				objSearch.SearchSQL = objSearch.SearchSQL + " FROM " + txtFrom.Text;
				if( txtWhere.Text != "" )
					objSearch.SearchSQL = objSearch.SearchSQL + " WHERE " + txtWhere.Text;
				if( txtMaxRows.Text != "" )
				{
					Int32 iRows = System.Int32.Parse(txtMaxRows.Text);
					objSearch.maxElements = iRows;
					objSearch.maxElementsSpecified = true;
				}

				// Execute the search
				objResponse = objBinding.ExecuteSearch(WSIUtil.GetLocalization(), objSearch);
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
				MessageBox.Show("No results were found for this query - exiting.");
				return;
			}
			lColumnCount = objResponse.Object[0].Property.Length;
			if( lColumnCount < 1 )
			{
				MessageBox.Show("The query succeeded, but the results contain no properties - exiting");
				return;
			}
			/*
			if( lColumnCount > 12 )
			{
				MessageBox.Show("The result set has more than 12 columns.  Only the first 12 columns will be displayed");
				lColumnCount = 12;
			}
			*/

			// Query was successful; display a list of result rows
			// First create a data table that has one column for each property in the 
			//  returned data
			System.Data.DataColumn dtCol;
			System.Data.DataRow dtRow;
			CEWSI.PropertyType prop;

			CEWSI.ObjectValue[] objObjects = objResponse.Object;
			lRowCount = objObjects.Length;
			System.Data.DataTable dtblResults = new System.Data.DataTable("Results");
			for(i=0; i<lColumnCount; i++)
			{
				dtCol = new System.Data.DataColumn(objObjects[0].Property[i].propertyId);
				dtCol.DataType = System.Type.GetType("System.String");
				dtCol.DefaultValue = "";
				dtblResults.Columns.Add(dtCol);
			}

			// Populate the rows
			for(i=0; i<lRowCount; i++)
			{
				dtRow = dtblResults.NewRow();
				for(long iCol=0; iCol<lColumnCount; iCol++)
				{
						prop = objObjects[i].Property[iCol];
						dtRow[prop.propertyId] = IdmObjectType.getPropertyValue(prop);
				}	
				dtblResults.Rows.Add(dtRow);
			}
			dgrdResults.DataSource = dtblResults;
			dgrdResults.Show();
			return;
		}


		/// <summary>
		/// Called by the main form to initialize this form
		/// </summary>
		/// <param name="mForm"></param>
		public void FormInit(Form1 mForm)
		{
			MainForm = mForm;
		}

		private void btnDetails_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
