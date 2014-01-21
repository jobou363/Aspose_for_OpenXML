﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXML_SDK
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"F:\Dropbox\Personal\Aspose Vs OpenXML\Files\Retrieve comments from word processing document.docx";
            GetCommentsFromDocument(fileName);
        }
        public static void GetCommentsFromDocument(string fileName)
        {
            using (WordprocessingDocument wordDoc =
                WordprocessingDocument.Open(fileName, false))
            {
                WordprocessingCommentsPart commentsPart =
                    wordDoc.MainDocumentPart.WordprocessingCommentsPart;

                if (commentsPart != null && commentsPart.Comments != null)
                {
                    foreach (Comment comment in commentsPart.Comments.Elements<Comment>())
                    {
                        Console.WriteLine(comment.InnerText);
                    }
                }
            }
        }
    }
}