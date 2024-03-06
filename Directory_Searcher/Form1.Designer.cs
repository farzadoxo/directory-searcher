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


        // Defining the properties of controls

        lblHead = new Label
        {
            Text = "Directory Searcher",
            Location = new Point(5,5)
        };

        btnSearch = new Button
        {
            Text = "Search",
            
            Location = new Point(300,70)

        };


        txtPath = new TextBox
        {
            Size = new Size(350,20),
            Location = new Point(170,40)
        };

        lstResault = new ListBox
        {
            Location = new Point(75,110),
            Size = new Size(550,330),
            BackColor = Color.WhiteSmoke
        };

        lblListBox = new Label
        {
            Text = "Resaults :",
            Location = new Point(80,95),
            
        };

        lblPath = new Label
        {
            Text = "Path :",
            Location = new Point(130,45)
        };

        lblStats = new Label
        {
            Text = "Status ⬇",
            Location = new Point(630,100)
        };

        lblFileCount = new Label
        {
            Text = "",
            Location = new Point(630,120)
        };

        lblFolderCount = new Label
        {
            Text = "",
            Location = new Point(630,140),
            
        };


        // Add controls to form

        this.Controls.Add(btnSearch);
        this.Controls.Add(lblHead);
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
    private Label lblHead;
    private Button btnSearch;
    private TextBox txtPath;
    private ListBox lstResault;
    private Label lblListBox;
    private Label lblPath;
    private Label lblStats;
    private Label lblFileCount;
    private Label lblFolderCount;

}
