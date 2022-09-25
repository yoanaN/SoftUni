﻿using System;
using System.Linq;

namespace Article
{
    internal class Articles
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            int n = int.Parse(Console.ReadLine());
            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }

                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }

                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }
        public class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string newContent)
            {
                this.Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}