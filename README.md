# ReductionGroupGenerator

Reduction Group Organizer for TheSkyX Full Calibration Mode

TheSkyX/64 has the capability to perform full noise reduction on a light frame image.  The user can apply reduction groups to individual images, to a folder of images, or automatically to each image when acquired.  The TSX User Guide describes Image Reduction (starting on page 621).  The feature requires the user to manually create lists of files in reduction groups, consisting of any number of bias, dark, and flat-field frames.  As a rule, each group is appropriate for a specific exposure (darks and flats) and filter (flats).  If the user is imaging at more than one or two exposures and filters, then the combinations proliferate rapidly.  Manual configuration of these groups is slow and agonizingly tedious, especially with multiple dark exposure times.  This utility fixes that by doing the configuration automatically, producing Image Calibration Groups that adhere to a specified naming convention.  When imaging, the user can select the desired reduction group either manually in the Camera “Take Photo” window or programmatically using the ccdsoftCamera.ReductionGroupName method.

More information in ReductionGroupGenerator.docx
