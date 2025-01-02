using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Program {
    class Program {
        static void Main(string[] args) {
            string download_path = @"~~";
            string main_directory = @"~~";
            string[] subdirectories = Directory.GetDirectories(main_directory);

            string[] files = Directory.GetFiles(download_path);
            if (files.Count() == 0) {
                Console.WriteLine("No files to organize.");
                return;
            } else {
                foreach (string file in files) {
                    //string type = file.Substring(file.LastIndexOf('.') + 1);
                    string type = Path.GetExtension(file).TrimStart('.').ToLower();
                    string type_directory = null;

                    foreach (string sub_dir in subdirectories) {
                        string potential_dir = Path.Combine(sub_dir, type);
                        if (Directory.Exists(potential_dir)) {
                            type_directory = potential_dir;
                        }
                    }

                    if (type_directory == null) {
                        type_directory = Path.Combine(main_directory,type);
                        Directory.CreateDirectory(type_directory);
                    }

                    string dest_path = Path.Combine(type_directory, Path.GetFileName(file));

                    try {
                        if (!File.Exists(dest_path)){
                            File.Move(file, dest_path);
                            Console.WriteLine($"File moved: {file} to {dest_path}");
                        }
                    } catch (Exception ex) {
                        Console.WriteLine($"Error moving file: {ex.Message}");
                    }
                }
            }
        }
    }
}
