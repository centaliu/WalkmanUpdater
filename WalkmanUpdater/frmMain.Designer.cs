namespace WalkmanUpdater
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDstPath = new System.Windows.Forms.TextBox();
			this.lblSrcDisk = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.txtFilenames = new System.Windows.Forms.TextBox();
			this.lblDstDrv = new System.Windows.Forms.Label();
			this.btnMove = new System.Windows.Forms.Button();
			this.txtFileNum = new System.Windows.Forms.TextBox();
			this.lblFilesNumRemove = new System.Windows.Forms.Label();
			this.txtSrcPath = new System.Windows.Forms.TextBox();
			this.btnCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDstPath
			// 
			this.txtDstPath.Location = new System.Drawing.Point(77, 43);
			this.txtDstPath.Name = "txtDstPath";
			this.txtDstPath.Size = new System.Drawing.Size(112, 20);
			this.txtDstPath.TabIndex = 0;
			this.txtDstPath.Text = "F:\\";
			// 
			// lblSrcDisk
			// 
			this.lblSrcDisk.AutoSize = true;
			this.lblSrcDisk.Location = new System.Drawing.Point(8, 15);
			this.lblSrcDisk.Name = "lblSrcDisk";
			this.lblSrcDisk.Size = new System.Drawing.Size(44, 13);
			this.lblSrcDisk.TabIndex = 1;
			this.lblSrcDisk.Text = "Source:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(195, 42);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(78, 20);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtFilenames
			// 
			this.txtFilenames.Location = new System.Drawing.Point(12, 69);
			this.txtFilenames.Multiline = true;
			this.txtFilenames.Name = "txtFilenames";
			this.txtFilenames.Size = new System.Drawing.Size(261, 651);
			this.txtFilenames.TabIndex = 3;
			// 
			// lblDstDrv
			// 
			this.lblDstDrv.AutoSize = true;
			this.lblDstDrv.Location = new System.Drawing.Point(8, 46);
			this.lblDstDrv.Name = "lblDstDrv";
			this.lblDstDrv.Size = new System.Drawing.Size(63, 13);
			this.lblDstDrv.TabIndex = 4;
			this.lblDstDrv.Text = "Destination:";
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(12, 726);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(59, 20);
			this.btnMove.TabIndex = 5;
			this.btnMove.Text = "Remove";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// txtFileNum
			// 
			this.txtFileNum.Location = new System.Drawing.Point(77, 726);
			this.txtFileNum.Name = "txtFileNum";
			this.txtFileNum.Size = new System.Drawing.Size(29, 20);
			this.txtFileNum.TabIndex = 6;
			this.txtFileNum.Text = "10";
			// 
			// lblFilesNumRemove
			// 
			this.lblFilesNumRemove.AutoSize = true;
			this.lblFilesNumRemove.Location = new System.Drawing.Point(112, 729);
			this.lblFilesNumRemove.Name = "lblFilesNumRemove";
			this.lblFilesNumRemove.Size = new System.Drawing.Size(28, 13);
			this.lblFilesNumRemove.TabIndex = 7;
			this.lblFilesNumRemove.Text = "Files";
			// 
			// txtSrcPath
			// 
			this.txtSrcPath.Location = new System.Drawing.Point(77, 12);
			this.txtSrcPath.Name = "txtSrcPath";
			this.txtSrcPath.Size = new System.Drawing.Size(112, 20);
			this.txtSrcPath.TabIndex = 8;
			this.txtSrcPath.Text = "G:\\Training\\mp3\\";
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(197, 12);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(78, 20);
			this.btnCopy.TabIndex = 9;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 748);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtSrcPath);
			this.Controls.Add(this.lblFilesNumRemove);
			this.Controls.Add(this.txtFileNum);
			this.Controls.Add(this.btnMove);
			this.Controls.Add(this.lblDstDrv);
			this.Controls.Add(this.txtFilenames);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.lblSrcDisk);
			this.Controls.Add(this.txtDstPath);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "WalkmanUpdater";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDstPath;
		private System.Windows.Forms.Label lblSrcDisk;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtFilenames;
		private System.Windows.Forms.Label lblDstDrv;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.TextBox txtFileNum;
		private System.Windows.Forms.Label lblFilesNumRemove;
		private System.Windows.Forms.TextBox txtSrcPath;
		private System.Windows.Forms.Button btnCopy;
	}
}

