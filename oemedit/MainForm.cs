/*
 * oemedit main form class
 * Copyright (C) 2013, Petros Kyladitis
 * 
 * This program is free software distributed under the GNU GPL 3,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.gnu.org/licenses/>.
 */
 
using System ;
using System.Collections.Generic ;
using System.Drawing ;
using System.Windows.Forms ;
using Microsoft.Win32 ;

namespace oemedit{
	public partial class MainForm : Form{
		
		//Registry keys & values constants
		private const string REGISTRY_OEMINFO_KEY_NAME = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation" ;
		private const string REGISTRY_LOGO_VNAME = "Logo" ;
		private const string REGISTRY_MANUFACTURER_VNAME = "Manufacturer" ; 
		private const string REGISTRY_MODEL_VNAME = "Model" ;
		private const string REGISTRY_SUPPORT_HOURS_VNAME = "SupportHours" ;
		private const string REGISTRY_SUPPORT_URL_VNAME = "SupportURL" ;
		private const string REGISTRY_SUPPORT_TEL_VNAME = "SupportPhone" ;
		
		//General use constants
		private	const string EMPTY_STR = "" ;
		
		//UX constants
		private const string ABOUT_BOX_MESSAGE = "OEM Information Editor - v 1.0\nCopyright (c) 2013, Petros Kyladitis\n\nA simple utility for setup or change the OEM Infromation at MS Windows Vista and above.\n\nThis program is free software distributed under the GNU GPL 3, for license details see at 'license.txt' file, distributed with this program, or see at <http://www.gnu.org/licenses/>." ;
		private const string ABOUT_BOX_TITLE = "About this program..." ;
		private const string ERROR_BOX_LOADING_MESSAGE = "OEM Information Editor - v 1.0\nCopyright (c) 2013, Petros Kyladitis\nThis program designed for MS Windows Vista and above.\nCan't be run at your system." ;
		private const string ERROR_BOX_LOADING_TITLE = "OEM Information Editor" ;
		private const string ERROR_BOX_SAVE_TITLE = "Saving values error!" ;
		private const string ERROR_BOX_BAD_IMAGE_MESSAGE = "Image is not acceptable.\nYou must select a bitmap 120x120 pixels max" ;
		private const string ERROR_BOX_BAD_IMAGE_TITLE = "Image selection error" ;
		
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(buttonCancel, "Exit, ignoring the changes") ;
			tip.SetToolTip(buttonClearLogo, "Clear the selected OEM Logo image") ;
			tip.SetToolTip(buttonClearOemInfo, "Clear all the OEM Info fields") ;
			tip.SetToolTip(buttonSave, "Store all information to the registry") ;
			tip.SetToolTip(buttonSelect, "Select OEM Logo image") ;
		}
		
		/// <summary>
		/// Check if an image file has the acceptable dimensions
		/// </summary>
		/// <param name="imageFile">The image file name</param>
		/// <param name="maxHeight">Maximun acceptable image height</param>
		/// <param name="maxWidth">Maximum acceptable image width</param>
		/// <param name="minHeight">Minimum acceptable image height</param>
		/// <param name="minWidth">Minimum acceptable image width</param>
		/// <returns>false if image dimensions exceed the acceptables, or on file opening error, else true</returns>
		private bool HasAcceptableDimensions(string imageFile, int maxHeight, int maxWidth, int minHeight, int minWidth){
			Image image ;
			try{
				image = Image.FromFile(imageFile) ;
			}catch(Exception){ //on error return false
				return false ;
			}
			if(image.Height > maxHeight || image.Height < minHeight){
				return false ;
			}
			if(image.Width > maxWidth || image.Width < minWidth){
				return false ;
			}
			return true ;
		}
		
		/// <summary>
		/// Read values from registry and fill the texboxes. If no value at registry (null returned), set an empty string.
		/// </summary>
		private void LoadValues(){
			string regLogoPath = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_LOGO_VNAME, EMPTY_STR) ;
			if(regLogoPath != EMPTY_STR){
				textBoxLogoPath.Text = regLogoPath ;
				try{ //try to load the image, on error do nothing
					pictureBoxLogo.Image = Image.FromFile(regLogoPath);
				}catch(Exception){}
			}
			textBoxManufacturer.Text = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_MANUFACTURER_VNAME, EMPTY_STR) ;
			textBoxModel.Text = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_MODEL_VNAME, EMPTY_STR) ;
			textBoxSupportHours.Text = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_HOURS_VNAME, EMPTY_STR) ;
			textBoxSupportTel.Text = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_TEL_VNAME, EMPTY_STR) ;
			textBoxSupportUrl.Text = (string) Registry.GetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_URL_VNAME, EMPTY_STR) ;
		}
		
		/// <summary>
		/// Store form fileds values to the registry. On exception, show information with a message box
		/// </summary>
		private void SaveValues(){
			try{
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_LOGO_VNAME, textBoxLogoPath.Text, RegistryValueKind.String) ;
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_MANUFACTURER_VNAME, textBoxManufacturer.Text, RegistryValueKind.String) ;
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_MODEL_VNAME, textBoxModel.Text, RegistryValueKind.String) ;
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_HOURS_VNAME, textBoxSupportHours.Text, RegistryValueKind.String) ;
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_TEL_VNAME, textBoxSupportTel.Text, RegistryValueKind.String) ;
				Registry.SetValue(REGISTRY_OEMINFO_KEY_NAME, REGISTRY_SUPPORT_URL_VNAME, textBoxSupportUrl.Text, RegistryValueKind.String) ;
			}catch(Exception exc){
				MessageBox.Show(exc.ToString(), ERROR_BOX_SAVE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}
		}
		
		void ButtonSelectClick(object sender, EventArgs e){
			openFileDialogSelectLogo.ShowDialog() ;
		}
		
		//if image has acceptable dimensions load it to pictureBox and the file path to text box, else show the error message
		void OpenFileDialogSelectLogoFileOk(object sender, System.ComponentModel.CancelEventArgs e){
			string file = openFileDialogSelectLogo.FileName ;
			if(HasAcceptableDimensions(file, 120, 120, 1, 1)){
				pictureBoxLogo.Image = Image.FromFile(file) ;
				textBoxLogoPath.Text = file ;
				this.Refresh() ;
			}else{
				MessageBox.Show(ERROR_BOX_BAD_IMAGE_MESSAGE, ERROR_BOX_BAD_IMAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}
		}
		
		//exit the application
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		//exit the application
		void ButtonCancelClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		//set image to null and clear the file path text
		void ButtonClearLogoClick(object sender, EventArgs e){
			pictureBoxLogo.Image = null ;
			textBoxLogoPath.Clear() ;
			this.Refresh() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			//if detect windows version prior to vista (major:6), show message and exit
			if(Environment.OSVersion.Version.Major < 6){
				MessageBox.Show(ERROR_BOX_LOADING_MESSAGE, ERROR_BOX_LOADING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
				Application.Exit() ;
			}
			LoadValues() ; //load values from registry to the form
		}
		
		//clear all text boxes and the picture box
		void ButtonClearOemInfoClick(object sender, EventArgs e){
			textBoxLogoPath.Clear() ;
			textBoxManufacturer.Clear() ;
			textBoxModel.Clear() ;
			textBoxSupportHours.Clear() ;
			textBoxSupportTel.Clear() ;
			textBoxSupportUrl.Clear() ;
			pictureBoxLogo.Image = null ;
		}
		
		void ButtonSaveClick(object sender, EventArgs e){
			SaveValues() ;
		}
		
		//show about info box
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show(ABOUT_BOX_MESSAGE, ABOUT_BOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
	}
}
