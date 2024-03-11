namespace Directory_Searcher;
using System.IO;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btnSearch.Click += btnSearh_Click;
        btnLog.Click += btnLog_Click;
    }

    private void btnSearh_Click(object sender , EventArgs e)
    {
        lstResault.Items.Clear();
        string path = txtPath.Text;
        try
        {  
            lblStats.Visible = true;
            btnLog.Enabled = true; 
            // Directories
            lstResault.Items.Add("------------------ 📂 Directories 📂------------------");
            lstResault.Items.AddRange(Directory.GetDirectories(path));
            // Files
            lstResault.Items.Add("------------------ 📄 Files 📄 ------------------");
            lstResault.Items.AddRange(Directory.GetFiles(path));

            // Status and counters
            string file_count = String.Format("{0}",Directory.GetFiles(path).Length);
            lblFileCount.Text = String.Format("Files : {0}",file_count.ToString());

            string folder_count = String.Format("{0}",Directory.GetDirectories(path).Length);
            lblFolderCount.Text = String.Format("Folders : {0}",folder_count.ToString());
        }
        catch
        {
            lblStats.Visible = false;
            btnLog.Enabled = false;
            lstResault.Items.Clear();
            
            lblFileCount.Text = "";
            lblFolderCount.Text = "";

            MessageBox.Show("Invalid Path addres !","Invalid Path !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }

    private void btnLog_Click(object sender , EventArgs e)
    {
        if(sfdLog.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(sfdLog.FileName,"---------- 📁 Directories 📁 ---------- \n\n");
            File.AppendAllLines(sfdLog.FileName,Directory.GetDirectories(txtPath.Text));
            File.AppendAllText(sfdLog.FileName,"\n ---------- 📄 Files 📄 ---------- \n\n");
            File.AppendAllLines(sfdLog.FileName,Directory.GetFiles(txtPath.Text));
        }
    }
}
