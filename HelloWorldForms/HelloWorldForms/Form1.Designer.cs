namespace HelloWorldForms
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
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EnglishButton = new System.Windows.Forms.Button();
			this.Display = new System.Windows.Forms.TextBox();
			this.GermanButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EnglishButton
			// 
			this.EnglishButton.Location = new System.Drawing.Point(32, 24);
			this.EnglishButton.Name = "EnglishButton";
			this.EnglishButton.Size = new System.Drawing.Size(215, 57);
			this.EnglishButton.TabIndex = 0;
			this.EnglishButton.Text = "English";
			this.EnglishButton.UseVisualStyleBackColor = true;
			this.EnglishButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// Display
			// 
			this.Display.Location = new System.Drawing.Point(32, 161);
			this.Display.Name = "Display";
			this.Display.Size = new System.Drawing.Size(215, 26);
			this.Display.TabIndex = 1;
			// 
			// GermanButton
			// 
			this.GermanButton.Location = new System.Drawing.Point(32, 88);
			this.GermanButton.Name = "GermanButton";
			this.GermanButton.Size = new System.Drawing.Size(215, 67);
			this.GermanButton.TabIndex = 2;
			this.GermanButton.Text = "German";
			this.GermanButton.UseVisualStyleBackColor = true;
			this.GermanButton.Click += new System.EventHandler(this.GermanButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 244);
			this.Controls.Add(this.GermanButton);
			this.Controls.Add(this.Display);
			this.Controls.Add(this.EnglishButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button EnglishButton;
		private System.Windows.Forms.TextBox Display;
		private System.Windows.Forms.Button GermanButton;
	}
}

