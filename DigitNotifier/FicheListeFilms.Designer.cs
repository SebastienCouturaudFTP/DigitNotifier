namespace TestNotify
{
    partial class FicheListeFilms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheListeFilms));
            this.notifyIconDigit = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridFilm = new System.Windows.Forms.DataGridView();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITFILM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).BeginInit();
            this.contextMenuStripIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconDigit
            // 
            this.notifyIconDigit.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIconDigit.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDigit.Icon")));
            // 
            // dataGridFilm
            // 
            this.dataGridFilm.AllowUserToAddRows = false;
            this.dataGridFilm.AllowUserToDeleteRows = false;
            this.dataGridFilm.AllowUserToResizeRows = false;
            this.dataGridFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.TITFILM});
            this.dataGridFilm.Location = new System.Drawing.Point(12, 30);
            this.dataGridFilm.Name = "dataGridFilm";
            this.dataGridFilm.Size = new System.Drawing.Size(823, 320);
            this.dataGridFilm.TabIndex = 3;
            // 
            // TID
            // 
            this.TID.DataPropertyName = "TID";
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.Width = 53;
            // 
            // TITFILM
            // 
            this.TITFILM.DataPropertyName = "TITFILM";
            this.TITFILM.HeaderText = "TITRE";
            this.TITFILM.Name = "TITFILM";
            this.TITFILM.Width = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(123, 28);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FicheListeFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 362);
            this.Controls.Add(this.dataGridFilm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FicheListeFilms";
            this.Text = "Digit notifier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).EndInit();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIconDigit;
        private System.Windows.Forms.DataGridView dataGridFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITFILM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

