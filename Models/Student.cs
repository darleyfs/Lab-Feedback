﻿using Lab_Feedback.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Feedback.Models
{
    internal class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string IdNumber { get; }

        public string? Folder { get; }

        public string FullName => LastName + ", " + FirstName;

        public Student(string firstName, string lastName, string idNumber, string? folder)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
            Folder = folder;
        }

        public Student(string path, string? studentFolder)
        {
            var cleanPath = FileHandler.GetSubfolderFromPath(path, studentFolder);

            var splitName = cleanPath?.Split('_');

            LastName = splitName[0];
            FirstName = splitName[1].Split('-')[0];
            IdNumber = splitName[1].Split('-')[1];
            Folder = studentFolder;
        }

        public static List<Student> GetStudentsFromFolders(string path)
        {
            List<Student> folders = new();

            try
            {
                if (Directory.Exists(path))
                {
                    string?[] subFolders = Directory.GetDirectories(path);


                    foreach (var subFolder in subFolders)
                    {
                        var student = new Student(path, subFolder);

                        folders.Add(student);
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return folders;
        }
    }
}
