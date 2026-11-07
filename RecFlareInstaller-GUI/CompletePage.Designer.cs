using System.ComponentModel;

namespace RecFlareInstaller_GUI;

partial class CompletePage
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
        InstallationPageLabel = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        InstallationPageQuit = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // InstallationPageLabel
        // 
        InstallationPageLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        InstallationPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        InstallationPageLabel.Location = new System.Drawing.Point(1, 2);
        InstallationPageLabel.Name = "InstallationPageLabel";
        InstallationPageLabel.Size = new System.Drawing.Size(455, 82);
        InstallationPageLabel.TabIndex = 0;
        InstallationPageLabel.Text = "RecFlare Installer";
        InstallationPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        label1.Location = new System.Drawing.Point(6, 99);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(339, 146);
        label1.TabIndex = 1;
        label1.Text = "Installation Complete!\r\n\r\nYou may close the installer.\r\n";
        // 
        // InstallationPageQuit
        // 
        InstallationPageQuit.Location = new System.Drawing.Point(307, 334);
        InstallationPageQuit.Name = "InstallationPageQuit";
        InstallationPageQuit.Size = new System.Drawing.Size(135, 39);
        InstallationPageQuit.TabIndex = 2;
        InstallationPageQuit.Text = "Quit";
        InstallationPageQuit.UseVisualStyleBackColor = true;
        InstallationPageQuit.Click += InstallationPageQuit_Click;
        // 
        // CompletePage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        Controls.Add(InstallationPageQuit);
        Controls.Add(label1);
        Controls.Add(InstallationPageLabel);
        Size = new System.Drawing.Size(457, 388);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button InstallationPageQuit;

    private System.Windows.Forms.Label InstallationPageLabel;

    private System.Windows.Forms.Label label1;

    #endregion
}