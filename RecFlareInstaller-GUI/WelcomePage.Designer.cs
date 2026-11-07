using System.ComponentModel;

namespace RecFlareInstaller_GUI;

partial class WelcomePage
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
        WelcomeText = new System.Windows.Forms.Label();
        WelcomeInformation = new System.Windows.Forms.Label();
        WelcomeYes = new System.Windows.Forms.Button();
        WelcomeNo = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // WelcomeText
        // 
        WelcomeText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        WelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        WelcomeText.Location = new System.Drawing.Point(0, 1);
        WelcomeText.Name = "WelcomeText";
        WelcomeText.Size = new System.Drawing.Size(456, 69);
        WelcomeText.TabIndex = 0;
        WelcomeText.Text = "RecFlare Installer";
        WelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // WelcomeInformation
        // 
        WelcomeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        WelcomeInformation.AutoSize = true;
        WelcomeInformation.BackColor = System.Drawing.Color.Transparent;
        WelcomeInformation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        WelcomeInformation.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        WelcomeInformation.Location = new System.Drawing.Point(20, 113);
        WelcomeInformation.Name = "WelcomeInformation";
        WelcomeInformation.Size = new System.Drawing.Size(331, 84);
        WelcomeInformation.TabIndex = 1;
        WelcomeInformation.Text = "Welcome to the RecFlare Installer\r\n\r\nBegin installation?\r\n";
        // 
        // WelcomeYes
        // 
        WelcomeYes.Location = new System.Drawing.Point(295, 339);
        WelcomeYes.Name = "WelcomeYes";
        WelcomeYes.Size = new System.Drawing.Size(144, 35);
        WelcomeYes.TabIndex = 2;
        WelcomeYes.Text = "Yes!";
        WelcomeYes.UseVisualStyleBackColor = true;
        WelcomeYes.Click += WelcomeYes_Click;
        // 
        // WelcomeNo
        // 
        WelcomeNo.Location = new System.Drawing.Point(20, 339);
        WelcomeNo.Name = "WelcomeNo";
        WelcomeNo.Size = new System.Drawing.Size(144, 35);
        WelcomeNo.TabIndex = 3;
        WelcomeNo.Text = "No!";
        WelcomeNo.UseVisualStyleBackColor = true;
        WelcomeNo.Click += WelcomeNo_Click;
        // 
        // WelcomePage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        Controls.Add(WelcomeNo);
        Controls.Add(WelcomeYes);
        Controls.Add(WelcomeInformation);
        Controls.Add(WelcomeText);
        Size = new System.Drawing.Size(457, 388);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button WelcomeYes;
    private System.Windows.Forms.Button WelcomeNo;

    private System.Windows.Forms.Label WelcomeInformation;

    private System.Windows.Forms.Label WelcomeText;

    #endregion
}