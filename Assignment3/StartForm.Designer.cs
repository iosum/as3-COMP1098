namespace Assignment3
{
    partial class StartForm
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.savedOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(234, 195);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(321, 58);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "Start A New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // savedOrderButton
            // 
            this.savedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedOrderButton.Location = new System.Drawing.Point(234, 271);
            this.savedOrderButton.Name = "savedOrderButton";
            this.savedOrderButton.Size = new System.Drawing.Size(321, 56);
            this.savedOrderButton.TabIndex = 1;
            this.savedOrderButton.Text = "Open a Saved Order";
            this.savedOrderButton.UseVisualStyleBackColor = true;
            this.savedOrderButton.Click += new System.EventHandler(this.savedOrderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(234, 344);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(321, 54);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.savedOrderButton);
            this.Controls.Add(this.newOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button savedOrderButton;
        private System.Windows.Forms.Button exitButton;
    }
}

