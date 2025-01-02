# organize_files_cs
before running
## ⚠️ PLEASE CHANGE "main_directory" AND "download_path" TO THE FOLDERS ⚠️
main_directory is the main organized directory you want to move the files to;<br>
download_path is where you previously downloaded your stuff;<br>
i've made it for myself, so just change it on any text editor and you're fine<br><br>

for example:<br>
download_path == "C:\\Users\\{your_username}\\Downloads"<br>
main_directory == "C:\\Users\\{your_username}\\Documents\\organized_files"

# how it works
check you changed the paths i told you then
```cmd
dotnet run
```
the c# wizard checks every file on the download_path, then gets the extension of each one and, on the main_directory, if it alreay has a folder with the **same** name as the file extension, it moves the file there, if not, then creates a new folder and moves it there<br>
the limit of checking the organized directory is two subdirectories to the organized dir,<br>
in any case, just manually check it for any confusion
