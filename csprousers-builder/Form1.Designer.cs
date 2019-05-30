namespace csprousers_builder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonServeLocalBuild = new System.Windows.Forms.Button();
            this.buttonProductionBuild = new System.Windows.Forms.Button();
            this.buttonCleanBuild = new System.Windows.Forms.Button();
            this.buttonOpenBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonServeLocalBuild
            // 
            this.buttonServeLocalBuild.Location = new System.Drawing.Point(46, 42);
            this.buttonServeLocalBuild.Name = "buttonServeLocalBuild";
            this.buttonServeLocalBuild.Size = new System.Drawing.Size(98, 23);
            this.buttonServeLocalBuild.TabIndex = 0;
            this.buttonServeLocalBuild.Text = "Serve local build";
            this.buttonServeLocalBuild.UseVisualStyleBackColor = true;
            this.buttonServeLocalBuild.Click += new System.EventHandler(this.buttonServeLocalBuild_Click);
            // 
            // buttonProductionBuild
            // 
            this.buttonProductionBuild.Location = new System.Drawing.Point(201, 90);
            this.buttonProductionBuild.Name = "buttonProductionBuild";
            this.buttonProductionBuild.Size = new System.Drawing.Size(98, 23);
            this.buttonProductionBuild.TabIndex = 3;
            this.buttonProductionBuild.Text = "Production build";
            this.buttonProductionBuild.UseVisualStyleBackColor = true;
            this.buttonProductionBuild.Click += new System.EventHandler(this.buttonProductionBuild_Click);
            // 
            // buttonCleanBuild
            // 
            this.buttonCleanBuild.Location = new System.Drawing.Point(46, 138);
            this.buttonCleanBuild.Name = "buttonCleanBuild";
            this.buttonCleanBuild.Size = new System.Drawing.Size(98, 23);
            this.buttonCleanBuild.TabIndex = 2;
            this.buttonCleanBuild.Text = "Clean build";
            this.buttonCleanBuild.UseVisualStyleBackColor = true;
            this.buttonCleanBuild.Click += new System.EventHandler(this.buttonCleanBuild_Click);
            // 
            // buttonOpenBrowse
            // 
            this.buttonOpenBrowse.Location = new System.Drawing.Point(46, 90);
            this.buttonOpenBrowse.Name = "buttonOpenBrowse";
            this.buttonOpenBrowse.Size = new System.Drawing.Size(98, 23);
            this.buttonOpenBrowse.TabIndex = 1;
            this.buttonOpenBrowse.Text = "Open browser";
            this.buttonOpenBrowse.UseVisualStyleBackColor = true;
            this.buttonOpenBrowse.Click += new System.EventHandler(this.buttonOpenBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.buttonOpenBrowse);
            this.Controls.Add(this.buttonCleanBuild);
            this.Controls.Add(this.buttonProductionBuild);
            this.Controls.Add(this.buttonServeLocalBuild);
            this.Name = "Form1";
            this.Text = "csprousers.org builder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonServeLocalBuild;
        private System.Windows.Forms.Button buttonProductionBuild;
        private System.Windows.Forms.Button buttonCleanBuild;
        private System.Windows.Forms.Button buttonOpenBrowse;
    }
}

