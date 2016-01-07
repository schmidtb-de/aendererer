namespace Ändererer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Zielpfad = new System.Windows.Forms.TextBox();
            this.Quellpfad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuell = new System.Windows.Forms.Button();
            this.btnZiel = new System.Windows.Forms.Button();
            this.chB_ZQ = new System.Windows.Forms.CheckBox();
            this.chBNurVideo = new System.Windows.Forms.CheckBox();
            this.chBUnterordnerlöschen = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pblöschen = new System.Windows.Forms.ToolStripProgressBar();
            this.chBUmbenennen = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Extrahieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zielpfad
            // 
            this.Zielpfad.AllowDrop = true;
            this.Zielpfad.Location = new System.Drawing.Point(18, 108);
            this.Zielpfad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Zielpfad.Name = "Zielpfad";
            this.Zielpfad.Size = new System.Drawing.Size(481, 26);
            this.Zielpfad.TabIndex = 1;
            this.Zielpfad.TextChanged += new System.EventHandler(this.Zielpfad_TextChanged);
            // 
            // Quellpfad
            // 
            this.Quellpfad.AllowDrop = true;
            this.Quellpfad.Location = new System.Drawing.Point(18, 45);
            this.Quellpfad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quellpfad.Name = "Quellpfad";
            this.Quellpfad.Size = new System.Drawing.Size(481, 26);
            this.Quellpfad.TabIndex = 2;
            this.Quellpfad.TextChanged += new System.EventHandler(this.Quellpfad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quellpfad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zielpfad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // btnQuell
            // 
            this.btnQuell.Location = new System.Drawing.Point(510, 42);
            this.btnQuell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuell.Name = "btnQuell";
            this.btnQuell.Size = new System.Drawing.Size(44, 35);
            this.btnQuell.TabIndex = 6;
            this.btnQuell.Text = "...";
            this.btnQuell.UseVisualStyleBackColor = true;
            this.btnQuell.Click += new System.EventHandler(this.btnQuell_Click);
            // 
            // btnZiel
            // 
            this.btnZiel.Location = new System.Drawing.Point(510, 103);
            this.btnZiel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZiel.Name = "btnZiel";
            this.btnZiel.Size = new System.Drawing.Size(44, 35);
            this.btnZiel.TabIndex = 7;
            this.btnZiel.Text = "...";
            this.btnZiel.UseVisualStyleBackColor = true;
            this.btnZiel.Click += new System.EventHandler(this.btnZiel_Click);
            // 
            // chB_ZQ
            // 
            this.chB_ZQ.AutoSize = true;
            this.chB_ZQ.Location = new System.Drawing.Point(18, 157);
            this.chB_ZQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chB_ZQ.Name = "chB_ZQ";
            this.chB_ZQ.Size = new System.Drawing.Size(222, 24);
            this.chB_ZQ.TabIndex = 8;
            this.chB_ZQ.Text = "Zielpfad ist nicht Quellpfad";
            this.chB_ZQ.UseVisualStyleBackColor = true;
            this.chB_ZQ.CheckedChanged += new System.EventHandler(this.chB_ZQ_CheckedChanged);
            // 
            // chBNurVideo
            // 
            this.chBNurVideo.AutoSize = true;
            this.chBNurVideo.Checked = true;
            this.chBNurVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBNurVideo.Location = new System.Drawing.Point(18, 192);
            this.chBNurVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBNurVideo.Name = "chBNurVideo";
            this.chBNurVideo.Size = new System.Drawing.Size(536, 24);
            this.chBNurVideo.TabIndex = 9;
            this.chBNurVideo.Text = "Nur Videodateien extrahieren (.mpeg, .mpg, .mkv, .xvid, .mp4, .avi, .mka)";
            this.chBNurVideo.UseVisualStyleBackColor = true;
            // 
            // chBUnterordnerlöschen
            // 
            this.chBUnterordnerlöschen.AutoSize = true;
            this.chBUnterordnerlöschen.Checked = true;
            this.chBUnterordnerlöschen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBUnterordnerlöschen.Location = new System.Drawing.Point(18, 228);
            this.chBUnterordnerlöschen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBUnterordnerlöschen.Name = "chBUnterordnerlöschen";
            this.chBUnterordnerlöschen.Size = new System.Drawing.Size(448, 24);
            this.chBUnterordnerlöschen.TabIndex = 10;
            this.chBUnterordnerlöschen.Text = "Unterordner automatisch löschen (inkl. aller Dateien darin!)";
            this.chBUnterordnerlöschen.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pb,
            this.toolStripStatusLabel2,
            this.pblöschen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(588, 31);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 26);
            this.toolStripStatusLabel1.Text = "Extrahieren";
            // 
            // pb
            // 
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 26);
            this.toolStripStatusLabel2.Text = "Löschen:";
            // 
            // pblöschen
            // 
            this.pblöschen.Name = "pblöschen";
            this.pblöschen.Size = new System.Drawing.Size(150, 25);
            // 
            // chBUmbenennen
            // 
            this.chBUmbenennen.AutoSize = true;
            this.chBUmbenennen.Checked = true;
            this.chBUmbenennen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBUmbenennen.Location = new System.Drawing.Point(18, 265);
            this.chBUmbenennen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBUmbenennen.Name = "chBUmbenennen";
            this.chBUmbenennen.Size = new System.Drawing.Size(536, 24);
            this.chBUmbenennen.TabIndex = 12;
            this.chBUmbenennen.Text = "Extrahierte Dateinamen den Ordnernamen entsprechend umbenennen";
            this.chBUmbenennen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 398);
            this.Controls.Add(this.chBUmbenennen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chBUnterordnerlöschen);
            this.Controls.Add(this.chBNurVideo);
            this.Controls.Add(this.chB_ZQ);
            this.Controls.Add(this.btnZiel);
            this.Controls.Add(this.btnQuell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quellpfad);
            this.Controls.Add(this.Zielpfad);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ändererer v0.1.3 - BETA";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Zielpfad;
        private System.Windows.Forms.TextBox Quellpfad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuell;
        private System.Windows.Forms.Button btnZiel;
        private System.Windows.Forms.CheckBox chB_ZQ;
        private System.Windows.Forms.CheckBox chBNurVideo;
        private System.Windows.Forms.CheckBox chBUnterordnerlöschen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar pblöschen;
        private System.Windows.Forms.CheckBox chBUmbenennen;

    }
}

