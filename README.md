# julianoteapp

This is a simple Windows Forms application for taking and managing notes. It consists of two forms: Form1 for adding new notes, and Form2 for viewing and managing existing notes.

## Form1 (Add Note)
Form1 allows users to add new notes by entering a title and content. Upon clicking the "Save" button, the note is saved to a SQL Server database.

### Components:
- Titlebox: TextBox for entering the note title.
- RichTextBox1: RichTextBox for entering the note content.
- Save Button: Button to save the note.

## Form2 (View and Manage Notes)
Form2 displays all saved notes from the database in a DataGridView. Users can view, search, and delete notes from this form.

### Components:
- DataGridView1: DataGridView for displaying saved notes.
- Searchbyname TextBox: TextBox for searching notes by title.
- Search Button: Button to search for notes based on the entered title.
- Delete Button: Button to delete the selected note.

## Technologies Used:
- Language: C#
- Database: Microsoft SQL Server
- Data Access Library: Microsoft.Data.SqlClient
- User Interface: Windows Forms (WinForms)

## Requirements:
- Microsoft SQL Server installed and running.
- Access to a database named "julianotedb" on a SQL Server instance named "LAB109PC20\SQLEXPRESS".
- Windows operating system to run the Windows Forms application.

## Usage:
1. Launch the application.
2. Form1: Enter a title and content for your note, then click "Save" to add the note.
3. Form2: View, search, and delete existing notes as needed.

## Note:
- Ensure that the SQL Server instance, database, and table structure (including column names) match the configuration specified in the code.
- Handle any exceptions gracefully, especially when interacting with the database.

For further customization or troubleshooting, refer to the provided code and make necessary adjustments according to your requirements.
