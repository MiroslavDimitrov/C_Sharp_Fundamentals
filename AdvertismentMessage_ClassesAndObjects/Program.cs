using System;
using System.Linq;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int number = int.Parse(Console.ReadLine());

            Article article = new Article();
            article.title = input[0];
            article.content = input[1];
            article.author = input[2];

            string command = "";
            string newContent = "";

            for (int i = 0; i < number; i++)
            {
                string[] newInput = Console.ReadLine().Split(": ").ToArray();
                command = newInput[0];
                newContent = newInput[1];
                if (command == "Edit")
                {
                    article.EditContent(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newContent);
                }
                else if (command == "Rename")
                {
                    article.ChangeTitle(newContent);
                }
            }

            Console.WriteLine($"{article.title} - {article.content}: {article.author}");
        }

        class Article
        {
            private string Title;
            private string Content;
            private string Author;

            public string title
            {
                get
                {
                    return this.Title;
                }
                set
                {
                    this.Title = value;
                }
            }

            public string content
            {
                get
                {
                    return this.Content;
                }
                set
                {
                    this.Content = value;
                }
            }

            public string author
            {
                get
                {
                    return this.Author;
                }
                set
                {
                   this.Author = value;
                }
            }

            public void EditContent(string str)
            {
                Content = str;
            }

            public void ChangeAuthor(string str)
            {
                Author = str;
            }

            public void ChangeTitle(string str) 
            {
                Title = str;
            }
        }
    }
}