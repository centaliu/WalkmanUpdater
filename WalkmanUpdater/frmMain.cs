using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WalkmanUpdater
{
	public partial class frmMain : Form
	{
		private static int roundsEachCopy = 5;

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			txtFilenames.Text = "";
			string[] fileEntries = Directory.GetFiles(txtDstPath.Text);
			foreach (string fileName in fileEntries)
			{
				txtFilenames.Text += fileName + "\r\n";
			}
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			int cnt = 0;
			//1:detect if destination path exists
			if (!Directory.Exists(txtDstPath.Text))
			{
				MessageBox.Show("destination folder doesn't exist!!");
				return;
			}
			DialogResult dialogResult = MessageBox.Show("remove " + txtFileNum.Text + " Files from " + txtDstPath.Text, "double confirm", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes) {
				cnt = Convert.ToInt32(txtFileNum.Text);
				string[] fileEntries = Directory.GetFiles(txtDstPath.Text);
				foreach (string fileName in fileEntries)
				{
					if (cnt <= 0) break;
					File.Delete(fileName);
					cnt--;
				}
				btnList_Click(null, null);
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			//1:detect if destination path exists
			if (!Directory.Exists(txtDstPath.Text))
			{
				MessageBox.Show("destination folder doesn't exist!!");
				return;
			}
			//2:detect if source path exists
			if (!Directory.Exists(txtSrcPath.Text))
			{
				MessageBox.Show("source folder doesn't exist!!");
				return;
			}
			string[] filesSongs = { };
			string[] filesTalks = { };
			string[] filesChatrooms = { };
			
			Random random = new Random();
			int rnd = 0;
			//3.copy four songs and four chatroom english mp3 files, then move one talking auido files a time
			filesSongs = Directory.GetFiles(txtSrcPath.Text + @"songs\");
			filesChatrooms = Directory.GetFiles(txtSrcPath.Text + @"chatroom\");
			for (int i = 0; i < roundsEachCopy; i++)
			{
				for (int j = 0; j<3; j++)
				{
					//3.1.the song portion
					rnd = random.Next(0, filesSongs.Length - 1);
					foreach (string f in filesSongs)
					{
						rnd--;
						if (rnd==0)
						{
							if (!File.Exists(@txtDstPath.Text + Path.GetFileName(f)))
							{
								File.Copy(f, @txtDstPath.Text + Path.GetFileName(f));
								btnList_Click(null, null);
								Application.DoEvents();
							}
							else j--; //skip if the file name exists already
						}
					}
					//3.2.the english portion
					rnd = random.Next(0, filesChatrooms.Length - 1);
					foreach (string f in filesChatrooms)
					{
						rnd--;
						if (rnd == 0)
						{
							if (!File.Exists(@txtDstPath.Text + Path.GetFileName(f)))
							{
								File.Copy(f, @txtDstPath.Text + Path.GetFileName(f));
								btnList_Click(null, null);
								Application.DoEvents();
							}
							else j--; //skip if the file name exists already
						}
					}
				}
				filesTalks = Directory.GetFiles(txtSrcPath.Text + @"queue\").OrderBy(f => f).ToArray();
				File.Move(filesTalks[0], @txtDstPath.Text + Path.GetFileName(filesTalks[0]));
				btnList_Click(null, null);
				Application.DoEvents();
			}
			MessageBox.Show("done!!");
		}
	}
}
