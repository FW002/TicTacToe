namespace TicTacToe
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
            this.panel = new System.Windows.Forms.Panel();
            this.DebugL = new System.Windows.Forms.Label();
            this.ResetState = new System.Windows.Forms.Button();
            this.PlayerL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel.Location = new System.Drawing.Point(184, 92);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(357, 307);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // DebugL
            // 
            this.DebugL.AutoSize = true;
            this.DebugL.Location = new System.Drawing.Point(323, 414);
            this.DebugL.Name = "DebugL";
            this.DebugL.Size = new System.Drawing.Size(50, 17);
            this.DebugL.TabIndex = 1;
            this.DebugL.Text = "Coord.";
            // 
            // ResetState
            // 
            this.ResetState.Location = new System.Drawing.Point(13, 92);
            this.ResetState.Name = "ResetState";
            this.ResetState.Size = new System.Drawing.Size(75, 23);
            this.ResetState.TabIndex = 2;
            this.ResetState.Text = "Reset";
            this.ResetState.UseVisualStyleBackColor = true;
            this.ResetState.Click += new System.EventHandler(this.OnResetClick);
            // 
            // PlayerL
            // 
            this.PlayerL.AutoSize = true;
            this.PlayerL.Location = new System.Drawing.Point(326, 41);
            this.PlayerL.Name = "PlayerL";
            this.PlayerL.Size = new System.Drawing.Size(48, 17);
            this.PlayerL.TabIndex = 3;
            this.PlayerL.Text = "--------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerL);
            this.Controls.Add(this.ResetState);
            this.Controls.Add(this.DebugL);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label DebugL;
        private System.Windows.Forms.Button ResetState;
        private System.Windows.Forms.Label PlayerL;
    }
}

