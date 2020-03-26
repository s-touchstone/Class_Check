# Version Control

Note: This is a new re-envisioned version of the original application I was developing.
	Although it starts at version 1, this is actually the 4th version of this application.
	I want to have a full and accessable source code availiable for anyone who uses this after me.
	I am starting over and logging every single detail of changes made and bugs fixed here.
	From this point on, new versions will only be released after full sets of changes have been applied.
	Whether that be organizational, optimizational, or functional changes.

About: This application was developed to help aid in East Central University's Information Technologies
	offices. It's intention is to minimize paperwork generated, make it easier to look up information,
	cross reference with other similar sources of data, amd generally make an easy interface that a
	student workers can use to update that information on the fly from any computer connected to their
	server. On a personal note, I found that taking inventory, and going through a funtionality checklist
	of every classroom on campus generated a lot of paper. It creates clutter and makes it difficult to look
	back on any notes that were made in a specific classroom. After the issues were addressed and the
	checklist finished, the paperwork would just by sent to waste. I had the idea to create a database
	and an application to control it in order to cut back on this waste of paper. You could simply 
	generate any type of report using the information gathered from the multitude of locations. In other
	words the potential to cut a stack of papers down to just a few leafs with the added benefit of 
	looking up specific information much faster than sorting through that paperwork.

**********VERSION 1.0**********
EDIT:03/04/19
	-I created the project as a brand-new project and linked it to my Azure DevOps account.
	-I added a resources folder and placed the following contents into it:
		Access_Database_Engine.exe
		Black_Rubber.jpg
		Blue_Check.ico
		Bright_Classroom.jpg
		configuration.cfg
		Framework_4.6.1.exe
		Peaceful_Blue.jpg
		Tech_DB.accdb
		Version_Control_Log.md
		Cam_Check.exe
		Mic_Check.exe
	-Separate cs file for the functions created.
	-Ability to read configuration file to create variables for the database information added.
	-Connection to database established and verifyed.
	-Links to other windows created.
	-Other windows created: Checklist, Settings, Inventory, and Report.
	-Basic navigation between windows added.

EDIT:03/05/19
	-Created a dictionary to reference information gathered from config file.
	-Added while loop to simplify information references and code.
	-Included many Exception handling events to ensure files exist.
	-Automatic cinfig file creation if the file does not exist.
	-A catch all was created to output error information to a log file for variable creation and database connection testing.
	-Started adding textboxes and labels to the settings window.

EDIT:03/06/19
	-Modified fields in settings window.
	-Created function to fill the individual fields with current information.