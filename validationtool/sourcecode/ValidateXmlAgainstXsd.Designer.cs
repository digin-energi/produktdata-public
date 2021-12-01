
namespace XmlXsdValidator
{
	partial class ValidateXmlWithXsdForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateXmlWithXsdForm));
			this.ValidateXmlWithXsdButton = new System.Windows.Forms.Button();
			this.XsdFileButton = new System.Windows.Forms.Button();
			this.XsdFileTextBox = new System.Windows.Forms.TextBox();
			this.XsdFileLabel = new System.Windows.Forms.Label();
			this.XmlFileButton = new System.Windows.Forms.Button();
			this.XmlFileTextBox = new System.Windows.Forms.TextBox();
			this.XmlFileLabel = new System.Windows.Forms.Label();
			this.LogFileButton = new System.Windows.Forms.Button();
			this.LogFileTextBox = new System.Windows.Forms.TextBox();
			this.LogFileLabel = new System.Windows.Forms.Label();
			this.UseXmlSchemaCheckBox = new System.Windows.Forms.CheckBox();
			this.XmlSchemaTextBox = new System.Windows.Forms.TextBox();
			this.XmlSchemaLabel = new System.Windows.Forms.Label();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.SuspendLayout();
			// 
			// ValidateXmlWithXsdButton
			// 
			this.ValidateXmlWithXsdButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ValidateXmlWithXsdButton.Location = new System.Drawing.Point(174, 177);
			this.ValidateXmlWithXsdButton.Name = "ValidateXmlWithXsdButton";
			this.ValidateXmlWithXsdButton.Size = new System.Drawing.Size(498, 43);
			this.ValidateXmlWithXsdButton.TabIndex = 12;
			this.ValidateXmlWithXsdButton.Text = "Validate XML file with XSD";
			this.ValidateXmlWithXsdButton.UseVisualStyleBackColor = true;
			this.ValidateXmlWithXsdButton.Click += new System.EventHandler(this.ValidateXmlWithXsdButtonClick);
			// 
			// XsdFileButton
			// 
			this.XsdFileButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XsdFileButton.Location = new System.Drawing.Point(679, 65);
			this.XsdFileButton.Name = "XsdFileButton";
			this.XsdFileButton.Size = new System.Drawing.Size(75, 23);
			this.XsdFileButton.TabIndex = 5;
			this.XsdFileButton.Text = "...";
			this.XsdFileButton.UseVisualStyleBackColor = true;
			this.XsdFileButton.Click += new System.EventHandler(this.XsdFileButtonClick);
			// 
			// XsdFileTextBox
			// 
			this.XsdFileTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XsdFileTextBox.Location = new System.Drawing.Point(174, 64);
			this.XsdFileTextBox.Name = "XsdFileTextBox";
			this.XsdFileTextBox.ReadOnly = true;
			this.XsdFileTextBox.Size = new System.Drawing.Size(498, 24);
			this.XsdFileTextBox.TabIndex = 4;
			this.XsdFileTextBox.TabStop = false;
			// 
			// XsdFileLabel
			// 
			this.XsdFileLabel.AutoSize = true;
			this.XsdFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XsdFileLabel.Location = new System.Drawing.Point(42, 67);
			this.XsdFileLabel.Name = "XsdFileLabel";
			this.XsdFileLabel.Size = new System.Drawing.Size(54, 17);
			this.XsdFileLabel.TabIndex = 3;
			this.XsdFileLabel.Text = "XSD file:";
			// 
			// XmlFileButton
			// 
			this.XmlFileButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XmlFileButton.Location = new System.Drawing.Point(678, 35);
			this.XmlFileButton.Name = "XmlFileButton";
			this.XmlFileButton.Size = new System.Drawing.Size(75, 23);
			this.XmlFileButton.TabIndex = 2;
			this.XmlFileButton.Text = "...";
			this.XmlFileButton.UseVisualStyleBackColor = true;
			this.XmlFileButton.Click += new System.EventHandler(this.XmlFileButtonClick);
			// 
			// XmlFileTextBox
			// 
			this.XmlFileTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XmlFileTextBox.Location = new System.Drawing.Point(174, 34);
			this.XmlFileTextBox.Name = "XmlFileTextBox";
			this.XmlFileTextBox.ReadOnly = true;
			this.XmlFileTextBox.Size = new System.Drawing.Size(498, 24);
			this.XmlFileTextBox.TabIndex = 1;
			this.XmlFileTextBox.TabStop = false;
			// 
			// XmlFileLabel
			// 
			this.XmlFileLabel.AutoSize = true;
			this.XmlFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XmlFileLabel.Location = new System.Drawing.Point(42, 37);
			this.XmlFileLabel.Name = "XmlFileLabel";
			this.XmlFileLabel.Size = new System.Drawing.Size(57, 17);
			this.XmlFileLabel.TabIndex = 0;
			this.XmlFileLabel.Text = "XML file:";
			// 
			// LogFileButton
			// 
			this.LogFileButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogFileButton.Location = new System.Drawing.Point(679, 95);
			this.LogFileButton.Name = "LogFileButton";
			this.LogFileButton.Size = new System.Drawing.Size(75, 23);
			this.LogFileButton.TabIndex = 8;
			this.LogFileButton.Text = "...";
			this.LogFileButton.UseVisualStyleBackColor = true;
			this.LogFileButton.Click += new System.EventHandler(this.LogFileButtonClick);
			// 
			// LogFileTextBox
			// 
			this.LogFileTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogFileTextBox.Location = new System.Drawing.Point(174, 94);
			this.LogFileTextBox.Name = "LogFileTextBox";
			this.LogFileTextBox.ReadOnly = true;
			this.LogFileTextBox.Size = new System.Drawing.Size(498, 24);
			this.LogFileTextBox.TabIndex = 7;
			this.LogFileTextBox.TabStop = false;
			// 
			// LogFileLabel
			// 
			this.LogFileLabel.AutoSize = true;
			this.LogFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogFileLabel.Location = new System.Drawing.Point(42, 97);
			this.LogFileLabel.Name = "LogFileLabel";
			this.LogFileLabel.Size = new System.Drawing.Size(105, 17);
			this.LogFileLabel.TabIndex = 6;
			this.LogFileLabel.Text = "Validation logfile:";
			// 
			// UseXmlSchemaCheckBox
			// 
			this.UseXmlSchemaCheckBox.AutoSize = true;
			this.UseXmlSchemaCheckBox.Location = new System.Drawing.Point(174, 124);
			this.UseXmlSchemaCheckBox.Name = "UseXmlSchemaCheckBox";
			this.UseXmlSchemaCheckBox.Size = new System.Drawing.Size(208, 17);
			this.UseXmlSchemaCheckBox.TabIndex = 9;
			this.UseXmlSchemaCheckBox.Text = "use following xml schema for validation";
			this.UseXmlSchemaCheckBox.UseVisualStyleBackColor = true;
			this.UseXmlSchemaCheckBox.CheckedChanged += new System.EventHandler(this.UseXmlSchemaCheckBoxCheckedChanged);
			// 
			// XmlSchemaTextBox
			// 
			this.XmlSchemaTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XmlSchemaTextBox.Location = new System.Drawing.Point(174, 147);
			this.XmlSchemaTextBox.Name = "XmlSchemaTextBox";
			this.XmlSchemaTextBox.Size = new System.Drawing.Size(498, 24);
			this.XmlSchemaTextBox.TabIndex = 11;
			// 
			// XmlSchemaLabel
			// 
			this.XmlSchemaLabel.AutoSize = true;
			this.XmlSchemaLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XmlSchemaLabel.Location = new System.Drawing.Point(42, 150);
			this.XmlSchemaLabel.Name = "XmlSchemaLabel";
			this.XmlSchemaLabel.Size = new System.Drawing.Size(83, 17);
			this.XmlSchemaLabel.TabIndex = 10;
			this.XmlSchemaLabel.Text = "XML schema:";
			// 
			// ValidateXmlWithXsdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 258);
			this.Controls.Add(this.XmlSchemaTextBox);
			this.Controls.Add(this.XmlSchemaLabel);
			this.Controls.Add(this.UseXmlSchemaCheckBox);
			this.Controls.Add(this.LogFileButton);
			this.Controls.Add(this.LogFileTextBox);
			this.Controls.Add(this.LogFileLabel);
			this.Controls.Add(this.ValidateXmlWithXsdButton);
			this.Controls.Add(this.XsdFileButton);
			this.Controls.Add(this.XsdFileTextBox);
			this.Controls.Add(this.XsdFileLabel);
			this.Controls.Add(this.XmlFileButton);
			this.Controls.Add(this.XmlFileTextBox);
			this.Controls.Add(this.XmlFileLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ValidateXmlWithXsdForm";
			this.Text = "Validate XML with XSD";
			this.Load += new System.EventHandler(this.ValidateXmlWithXsdFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ValidateXmlWithXsdButton;
		private System.Windows.Forms.Button XsdFileButton;
		private System.Windows.Forms.TextBox XsdFileTextBox;
		private System.Windows.Forms.Label XsdFileLabel;
		private System.Windows.Forms.Button XmlFileButton;
		private System.Windows.Forms.TextBox XmlFileTextBox;
		private System.Windows.Forms.Label XmlFileLabel;
		private System.Windows.Forms.Button LogFileButton;
		private System.Windows.Forms.TextBox LogFileTextBox;
		private System.Windows.Forms.Label LogFileLabel;
		private System.Windows.Forms.CheckBox UseXmlSchemaCheckBox;
		private System.Windows.Forms.TextBox XmlSchemaTextBox;
		private System.Windows.Forms.Label XmlSchemaLabel;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
	}
}

