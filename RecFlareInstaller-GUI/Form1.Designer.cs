namespace RecFlareInstaller_GUI;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PageHostPanel = new System.Windows.Forms.Panel();
        SuspendLayout();
        // 
        // PageHostPanel
        // 
        PageHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        PageHostPanel.Location = new System.Drawing.Point(0, 0);
        PageHostPanel.Name = "PageHostPanel";
        PageHostPanel.Size = new System.Drawing.Size(457, 388);
        PageHostPanel.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Desktop;
        ClientSize = new System.Drawing.Size(457, 388);
        Controls.Add(PageHostPanel);
        Text = "RecFlare Installer";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel PageHostPanel;

    #endregion
}