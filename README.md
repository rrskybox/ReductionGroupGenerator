# ReductionGroupGenerator

Reduction Group Organizer for TheSkyX Full Calibration Mode

Most TSX users know that TheSkyX/64 is capable of full noise reduction on a light frame image.  If not, details can be found in the TSX User Guide starting on page 621.  Noise reduction groups can be applied to individual images, to a folder of images, or in real-time to each light frame upon acquisition.  However, the feature requires the user to manually enter compilations of bias, dark, and flat-field image files.  As a rule, each group is appropriate to reduce a light frame taken at specific exposure (darks and flats) and filter (flats).  If the user is imaging at more than one or two exposures and filters, then the permutations proliferate rapidly.  I find manual configuration of these groups slow and tedious.  This utility addresses that by compiling the Calibration Libraries automatically, producing Image Calibration Groups that adhere to a specified naming convention.  When imaging, I can select the desired reduction group either manually in the Camera “Take Photo” window or programmatically using the ccdsoftCamera.ReductionGroupName method.

The trick is knowing that the structure and location of reduction files for the TSX Calibration Libraries are stored in the TSX AppSettings.ini file.  So, this app works through a pile of FITS files in a user-declared directory tree and correlates them by calibration type, exposure, etc.  to produce sets of reduction groups.  The app then modifies the AppSettings.ini file with the path information for these files.  Upon the next launch of TSX, these reduction groups reappear as Calibration Libraries.

Reduction Group Generator is a Windows Forms executable, written in Visual C#.  The app requires TheSkyX Imaging Edition (Build 10966 or later). The application runs as an uncertified, standalone application under Windows 10/11. 

The source code for this application is available on GitHub under rrskybox/ReductionGroupGenerator.  The One-Click installation package is available in the “publish” directory.  To install, download “HotPursuit.zip” and extract. Then run "setup.exe".  Upon completion, an application icon will have been added to the start menu under "TSXToolKit" with the name "Reduction Group Generator".  This application can be pinned to the Start if desired.

A full description can be found at ReductionGroupGenerator.pdf.

I should also note that the structure and format of the AppSettings.ini configuration file is clearly proprietary, i.e. subject to change without notice or apologies.  But, I will try to keep the app up with the current build, if possible and as time permits.
