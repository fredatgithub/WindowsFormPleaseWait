namespace WindowsFormPleaseWait
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonStartProcess = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonStartProcess
      // 
      this.buttonStartProcess.Location = new System.Drawing.Point(82, 53);
      this.buttonStartProcess.Name = "buttonStartProcess";
      this.buttonStartProcess.Size = new System.Drawing.Size(134, 23);
      this.buttonStartProcess.TabIndex = 0;
      this.buttonStartProcess.Text = "Start process";
      this.buttonStartProcess.UseVisualStyleBackColor = true;
      this.buttonStartProcess.Click += new System.EventHandler(this.Button1_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(330, 149);
      this.Controls.Add(this.buttonStartProcess);
      this.Name = "FormMain";
      this.Text = "Application";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button buttonStartProcess;
    }
}

