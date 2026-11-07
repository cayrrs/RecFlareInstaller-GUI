using System.ComponentModel;

namespace RecFlareInstaller_GUI;

partial class InstallationPage
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        InstallationLabel = new System.Windows.Forms.Label();
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // InstallationLabel
        // 
        InstallationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        InstallationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        InstallationLabel.Location = new System.Drawing.Point(1, 0);
        InstallationLabel.Name = "InstallationLabel";
        InstallationLabel.Size = new System.Drawing.Size(455, 65);
        InstallationLabel.TabIndex = 0;
        InstallationLabel.Text = "RecFlare Installer";
        InstallationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = System.Drawing.Color.Black;
        richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        richTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        richTextBox1.Location = new System.Drawing.Point(0, 88);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        richTextBox1.Size = new System.Drawing.Size(458, 191);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        label1.Location = new System.Drawing.Point(1, 294);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(455, 65);
        label1.TabIndex = 2;
        label1.Text = "Installing..";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // InstallationPage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        Controls.Add(label1);
        Controls.Add(richTextBox1);
        Controls.Add(InstallationLabel);
        Size = new System.Drawing.Size(457, 388);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.Label InstallationLabel;

    #endregion
}