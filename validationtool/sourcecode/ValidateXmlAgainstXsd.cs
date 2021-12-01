using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XmlXsdValidator
{
	public partial class ValidateXmlWithXsdForm : Form
	{
		private static List<string> validationErrors;
		private static List<string> validationWarnings;
		public ValidateXmlWithXsdForm()
		{
			InitializeComponent();
		}

		private void ValidateXmlWithXsdFormLoad(object sender, EventArgs e)
		{
			PictureBox dnvLogoPicctureBox = new PictureBox();
			dnvLogoPicctureBox.Location = new System.Drawing.Point(32, 171);
			dnvLogoPicctureBox.Width = 100;
			dnvLogoPicctureBox.Height = 54;

			dnvLogoPicctureBox.Image = Properties.Resources.DNV_logo_RGB;
			dnvLogoPicctureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			Controls.Add(dnvLogoPicctureBox);

			EnDisableSchemaValidation(false);
		}

		private void XmlFileButtonClick(object sender, EventArgs e)
		{
			XmlFileTextBox.Text =  SelectFile("xml");
		}

		private void XsdFileButtonClick(object sender, EventArgs e)
		{
			XsdFileTextBox.Text = SelectFile("xsd");
		}

		private string SelectFile(string defaultExt)
		{
			string result = "";
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Select " + defaultExt + " file",
				DefaultExt = defaultExt,
				Filter = defaultExt + " files (*." + defaultExt + ")|*." + defaultExt,
				//RestoreDirectory = true,
				//ReadOnlyChecked = true,
				//ShowReadOnly = true,
				CheckFileExists = true,
				CheckPathExists = true
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
			return result;
		}

		private void LogFileButtonClick(object sender, EventArgs e)
		{
			SaveTextFile();
		}

		private void SaveTextFile()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file|*.txt";
			saveFileDialog.Title = "Save Text File";
			saveFileDialog.ShowDialog();

			LogFileTextBox.Text = saveFileDialog.FileName;
		}

		private void ValidateXmlWithXsdButtonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(XmlFileTextBox.Text))
			{
				if (!string.IsNullOrEmpty(XsdFileTextBox.Text))
				{
					if (!string.IsNullOrEmpty(LogFileTextBox.Text))
					{
						if (UseXmlSchemaCheckBox.Checked && string.IsNullOrEmpty(XmlSchemaTextBox.Text))
						{
							MessageBox.Show("Use xml schema validation is checked, but no xml schema is specified." + Environment.NewLine + Environment.NewLine +
								"Either specify a xml schema or uncheck the \"" + UseXmlSchemaCheckBox.Text + "\" checkbox.", "No xml schema specified", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						}
						else
						{
							validationErrors = new List<string>();
							validationWarnings = new List<string>();

							XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
							if (UseXmlSchemaCheckBox.Checked)
							{
								try
								{
									xmlReaderSettings.Schemas.Add(XmlSchemaTextBox.Text, XsdFileTextBox.Text);
								}
								catch (Exception sex)
								{
									validationErrors.Add("Error validating xml schema: " + sex.Message);
								}
							}
							else
							{
								xmlReaderSettings.Schemas.Add(null, XsdFileTextBox.Text);
							}
							xmlReaderSettings.ValidationType = ValidationType.Schema;
							xmlReaderSettings.ValidationEventHandler += new ValidationEventHandler(XmlReaderSettingsValidationEventHandler);

							using (XmlReader xmlReader = XmlReader.Create(XmlFileTextBox.Text, xmlReaderSettings))
							{
								try
								{
									while (xmlReader.Read()) { }
								}
								catch (Exception rex)
								{
									validationErrors.Add("Error reading xml file: " + rex.Message);
								}
							}

							try
							{
								WriteValidationResults(LogFileTextBox.Text);
								MessageBox.Show("Done reading and validating xml file. Check log for validation results", "Validation done", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							catch (Exception)
							{
								MessageBox.Show("Error occurred while writing the log file with validation results, please check if log file path is correct and possible to write to.", "Error writing log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					else
					{
						MessageBox.Show("No log file specified, please select a log file to write validation results to.", "No file specified", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				else
				{
					MessageBox.Show("No xsd file specified, please select a xsd file to validate with.", "No file specified", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			else
			{
				MessageBox.Show("No xml file specified, please select a xml file to validate.", "No file specified", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void WriteValidationResults(string filePath)
		{
			List<string> validationResults = new List<string>();
			if (validationErrors.Count > 0)
			{
				validationResults.Add("Errors found:");
				for (int i = 0; i < validationErrors.Count; i++)
				{
					validationResults.Add("  - " + validationErrors[i]);
				}
			}
			else
			{
				validationResults.Add("No errors found");
			}
			validationResults.Add("");
			if (validationWarnings.Count > 0)
			{
				validationResults.Add("Warnings found:");
				for (int i = 0; i < validationWarnings.Count; i++)
				{
					validationResults.Add("  - " + validationWarnings[i]);
				}
			}
			else
			{
				validationResults.Add("No warnings found");
			}
			File.WriteAllLines(filePath, validationResults.ToArray());
		}

		private static void XmlReaderSettingsValidationEventHandler(object sender, ValidationEventArgs e)
		{
			if (e.Severity == XmlSeverityType.Warning)
			{
				//Console.Write("WARNING: ");
				//Console.WriteLine(e.Message);
				validationWarnings.Add("Line: " + e.Exception.LineNumber + "; Position: " + e.Exception.LinePosition + "; Message: " + e.Message);
				//logFile.WriteLine("Hello");
			}
			else if (e.Severity == XmlSeverityType.Error)
			{
				//Console.Write("ERROR: ");
				//Console.WriteLine(e.Message);
				validationErrors.Add("Line: " + e.Exception.LineNumber + "; Position: " + e.Exception.LinePosition + "; Message: " + e.Message);
			}
		}

		private void UseXmlSchemaCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			EnDisableSchemaValidation(UseXmlSchemaCheckBox.Checked);
		}

		private void EnDisableSchemaValidation(bool useSchemaValidation)
		{
			XmlSchemaLabel.Enabled = useSchemaValidation;
			XmlSchemaTextBox.Enabled = useSchemaValidation;
		}
	}
}
