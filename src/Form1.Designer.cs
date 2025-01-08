namespace Directory_Searcher;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(700, 450);
        this.Text = "Directory Searcher";
        this.BackColor = Color.Azure;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Icon = new Icon(@"c:\users\farzad\documents\github repositories\directory-searcher\media\folder.ico");


        // Defining the properties of controls


        btnSearch = new Button
        {
            Text = "Search",
            Location = new Point(396,10)

        };


        txtPath = new TextBox
        {
            Size = new Size(350,20),
            Location = new Point(40,10)
        };

        lstResault = new ListBox
        {
            Location = new Point(7,74),
            Size = new Size(600,370),
            BackColor = Color.WhiteSmoke
        };

        lblListBox = new Label
        {
            Text = "Resaults :",
            Location = new Point(5,50),
            
        };

        lblPath = new Label
        {
            Text = "Path :",
            Location = new Point(5,13)
        };

        lblStats = new Label
        {
            Text = "Status ⬇",
            Location = new Point(610,80),
            Visible = false
        };

        lblFileCount = new Label
        {
            Text = "",
            Location = new Point(610,100)
        };

        lblFolderCount = new Label
        {
            Text = "",
            Location = new Point(610,120),
            
        };

        btnLog = new Button
        {
            Text = "Log",
            Location = new Point(396,35),
            Enabled = false
        };
        
        sfdLog = new SaveFileDialog
        {
            DefaultExt = "txt",
            Title = "List your directory item in text file !",
            Filter = "Text Files (*.txt)|*.txt"
        };


        // Add controls to form

        this.Controls.Add(btnSearch);
        this.Controls.Add(btnLog);
        this.Controls.Add(txtPath);
        this.Controls.Add(lstResault);
        this.Controls.Add(lblListBox);
        this.Controls.Add(lblPath);
        this.Controls.Add(lblStats);
        this.Controls.Add(lblFileCount);
        this.Controls.Add(lblFolderCount);


        
    }

    #endregion

    // Define controls

    private Button btnSearch;
    private TextBox txtPath;
    private ListBox lstResault;
    private Label lblListBox;
    private Label lblPath;
    private Label lblStats;
    private Label lblFileCount;
    private Label lblFolderCount;
    private Button btnLog;
    private SaveFileDialog sfdLog;

}
