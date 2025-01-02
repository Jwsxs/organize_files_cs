# organize_files_cs
## ⚠️ PLEASE CHANGE "main_directory" AND "download_path" TO THE FOLDERS ⚠️
main_directory is the main organized directory you want to move the files to
download_path is where you previously downloaded your stuff
i've made it for myself, so just change it on any text editor and you're fine

for example:
download_path == "C:\\Users\\{your_username}\\Downloads"
main_directory == "C:\\Users\\{your_username}\\Documents\\organized_files"

# how it works
checks every file on the download_path, then gets the extension of each one and, on the main_directory, if it alreay has a folder with the **same** name as the file extension, it moves the file there, if not, then creates a new folder and moves it there
the limit of checking the organized directory is two subdirectories to the organized dir,
in any case, just manually check it for any confusion
