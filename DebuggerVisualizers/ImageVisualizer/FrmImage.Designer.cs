namespace DebuggerVisualizers.ImageVisualizer
{
    partial class FrmImage
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblImageTypeInfo = new System.Windows.Forms.Label();
            this.lblImageType = new System.Windows.Forms.Label();
            this.lblNativeResolutionInfo = new System.Windows.Forms.Label();
            this.lblNativeResolution = new System.Windows.Forms.Label();
            this.PicViewer = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.btnSave);
            this.pnlInfo.Controls.Add(this.lblImageTypeInfo);
            this.pnlInfo.Controls.Add(this.lblImageType);
            this.pnlInfo.Controls.Add(this.lblNativeResolutionInfo);
            this.pnlInfo.Controls.Add(this.lblNativeResolution);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 316);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(342, 50);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblImageTypeInfo
            // 
            this.lblImageTypeInfo.AutoSize = true;
            this.lblImageTypeInfo.Location = new System.Drawing.Point(81, 26);
            this.lblImageTypeInfo.Name = "lblImageTypeInfo";
            this.lblImageTypeInfo.Size = new System.Drawing.Size(0, 13);
            this.lblImageTypeInfo.TabIndex = 3;
            // 
            // lblImageType
            // 
            this.lblImageType.AutoSize = true;
            this.lblImageType.Location = new System.Drawing.Point(10, 26);
            this.lblImageType.Name = "lblImageType";
            this.lblImageType.Size = new System.Drawing.Size(65, 13);
            this.lblImageType.TabIndex = 2;
            this.lblImageType.Text = "Type image:";
            // 
            // lblNativeResolutionInfo
            // 
            this.lblNativeResolutionInfo.AutoSize = true;
            this.lblNativeResolutionInfo.Location = new System.Drawing.Point(136, 4);
            this.lblNativeResolutionInfo.Name = "lblNativeResolutionInfo";
            this.lblNativeResolutionInfo.Size = new System.Drawing.Size(0, 13);
            this.lblNativeResolutionInfo.TabIndex = 1;
            // 
            // lblNativeResolution
            // 
            this.lblNativeResolution.AutoSize = true;
            this.lblNativeResolution.Location = new System.Drawing.Point(10, 4);
            this.lblNativeResolution.Name = "lblNativeResolution";
            this.lblNativeResolution.Size = new System.Drawing.Size(120, 13);
            this.lblNativeResolution.TabIndex = 0;
            this.lblNativeResolution.Text = "Native resolution (in px):";
            // 
            // PicViewer
            // 
            this.PicViewer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PicViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicViewer.Location = new System.Drawing.Point(0, 0);
            this.PicViewer.Name = "PicViewer";
            this.PicViewer.Size = new System.Drawing.Size(342, 316);
            this.PicViewer.TabIndex = 0;
            this.PicViewer.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.PicViewer);
            this.Controls.Add(this.pnlInfo);
            this.Name = "FrmImage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Image Visualizer";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblNativeResolutionInfo;
        private System.Windows.Forms.Label lblNativeResolution;
        private System.Windows.Forms.Label lblImageTypeInfo;
        private System.Windows.Forms.Label lblImageType;
        private System.Windows.Forms.PictureBox PicViewer;
        private System.Windows.Forms.Button btnSave;
    }
}