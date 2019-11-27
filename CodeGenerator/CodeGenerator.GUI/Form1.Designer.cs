﻿namespace CodeGen
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.Path_Model = new System.Windows.Forms.Label();
            this.SelectOutputButton = new System.Windows.Forms.Button();
            this.Path_Output = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectFileButton.Location = new System.Drawing.Point(41, 48);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectFileButton.MaximumSize = new System.Drawing.Size(213, 31);
            this.SelectFileButton.MinimumSize = new System.Drawing.Size(213, 31);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(213, 31);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Datei auswählen...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // Path_Model
            // 
            this.Path_Model.BackColor = System.Drawing.SystemColors.Control;
            this.Path_Model.Location = new System.Drawing.Point(260, 55);
            this.Path_Model.Name = "Path_Model";
            this.Path_Model.Size = new System.Drawing.Size(300, 20);
            this.Path_Model.TabIndex = 1;
            this.Path_Model.Text = "Keine Datei ausgewählt.";
            // 
            // SelectOutputButton
            // 
            this.SelectOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectOutputButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectOutputButton.Location = new System.Drawing.Point(41, 87);
            this.SelectOutputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectOutputButton.MaximumSize = new System.Drawing.Size(213, 31);
            this.SelectOutputButton.MinimumSize = new System.Drawing.Size(213, 31);
            this.SelectOutputButton.Name = "SelectOutputButton";
            this.SelectOutputButton.Size = new System.Drawing.Size(213, 31);
            this.SelectOutputButton.TabIndex = 2;
            this.SelectOutputButton.Text = "Ausgabeort auswählen...";
            this.SelectOutputButton.UseVisualStyleBackColor = true;
            this.SelectOutputButton.Click += new System.EventHandler(this.SelectOutputButton_Click);
            // 
            // Path_Output
            // 
            this.Path_Output.BackColor = System.Drawing.SystemColors.Control;
            this.Path_Output.Location = new System.Drawing.Point(260, 95);
            this.Path_Output.Name = "Path_Output";
            this.Path_Output.Size = new System.Drawing.Size(300, 20);
            this.Path_Output.TabIndex = 3;
            this.Path_Output.Text = "Keinen Ausgabeort ausgewählt.";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(200, 150);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(149, 50);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generieren";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialogDatei";
            this.openFileDialogFile.Filter = "GRAPHML FILES (*.graphml)|*.graphml";
            this.openFileDialogFile.Title = "Select a \".graphml\" file";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 434);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Path_Output);
            this.Controls.Add(this.SelectOutputButton);
            this.Controls.Add(this.Path_Model);
            this.Controls.Add(this.SelectFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(594, 481);
            this.MinimumSize = new System.Drawing.Size(594, 481);
            this.Name = "GUI";
            this.ShowIcon = false;
            this.Text = "CodeGenerator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label Path_Model;
        private System.Windows.Forms.Button SelectOutputButton;
        private System.Windows.Forms.Label Path_Output;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
    }
}

