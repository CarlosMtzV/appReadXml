namespace appReadXML_From_URL
{
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
            txtXMLData = new TextBox();
            lstvData = new ListView();
            btnSaves = new Button();
            SuspendLayout();
            // 
            // txtXMLData
            // 
            txtXMLData.Font = new Font("Segoe UI", 15F);
            txtXMLData.Location = new Point(193, 22);
            txtXMLData.Multiline = true;
            txtXMLData.Name = "txtXMLData";
            txtXMLData.ScrollBars = ScrollBars.Both;
            txtXMLData.Size = new Size(140, 35);
            txtXMLData.TabIndex = 0;
            // 
            // lstvData
            // 
            lstvData.Location = new Point(113, 131);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(444, 259);
            lstvData.TabIndex = 1;
            lstvData.UseCompatibleStateImageBehavior = false;
            lstvData.View = View.Details;
            // 
            // btnSaves
            // 
            btnSaves.Location = new Point(12, 12);
            btnSaves.Name = "btnSaves";
            btnSaves.Size = new Size(121, 62);
            btnSaves.TabIndex = 2;
            btnSaves.Text = "Save";
            btnSaves.UseVisualStyleBackColor = true;
            btnSaves.Click += btnSaves_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 527);
            Controls.Add(btnSaves);
            Controls.Add(lstvData);
            Controls.Add(txtXMLData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtXMLData;
        private ListView lstvData;
        private Button btnSaves;
    }
}
