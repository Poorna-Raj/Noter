# Noter – A Simple Markdown Editor (WinForms)

Noter is a lightweight Markdown editor built with C# and WinForms. It allows you to manage, create, edit, and preview Markdown files with a clean dark-themed interface.

## Features

- Open Folder & File Browser – Select a folder and view all Markdown (.md) files in a sidebar.
- Create New Markdown Files – Prompt for a file name and create a new .md file in the selected folder.
- Edit Markdown – RichTextBox editor with dark theme and syntax-style formatting.
- Save / Save As – Save changes to the current file or create a new file with a custom name.
- Markdown Preview – Real-time HTML preview using WebView2 with dark-mode styling.
- Dark Theme UI – Editor and preview styled for comfortable dark-mode reading.
- Sidebar Navigation – Easily switch between files by clicking items in the sidebar.

## Screenshot
![image](https://github.com/Poorna-Raj/Noter/blob/master/Noter/images/screenshot.PNG)

# Getting Started
## Requirements
- Windows 10 / 11
- .NET Framework 4.7.2 or higher (or .NET 6/7 if using WinForms Core)
- WebView2 Runtime

## Build & Run

1. Clone the repository:
```bash
git clone https://github.com/yourusername/noter.git
```
2. Open the solution in Visual Studio.
3. Restore NuGet packages (for WebView2 if needed).
4. Build and run the project.

# How to Use
- Select a Folder – Click the folder button and choose a folder containing .md files.
- Browse Files – The sidebar will populate with all Markdown files in the folder.
- Open a File – Click a file in the sidebar to load it into the editor.
- Edit Content – Modify the text in the RichTextBox editor.
- Save Changes – Click the Save button to overwrite the file, or Save As to create a new file.
- Preview Markdown – The WebView2 preview automatically displays the rendered HTML.
- Create New File – Click New File, enter a file name, and start editing immediately.

# Notes
- The sidebar dynamically updates when new files are created or saved.
- Markdown preview supports dark-themed styling, including code blocks, headings, links, and scrollbars.

# Future Improvements
- Add syntax highlighting in the editor.
- Implement drag-and-drop file support.
- Add custom themes for editor and preview.
