﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.Collections;
namespace Aspose_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document(@"F:\Dropbox\Personal\Aspose Vs OpenXML\Files\Retrieve comments from word processing document.docx");
            ExtractComments(doc);

        }
        public static void ExtractComments(Document doc)
        {
            ArrayList collectedComments = new ArrayList();
            // Collect all comments in the document
            NodeCollection comments = doc.GetChildNodes(NodeType.Comment, true);
            // Look through all comments and gather information about them.
            foreach (Comment comment in comments)
            {
                collectedComments.Add(comment.Author + " " + comment.DateTime + " " + comment.ToString(SaveFormat.Text));
            }
            foreach (string collectedComment in collectedComments)
            {
                Console.WriteLine(collectedComment);
            }
           
        }
    }
}
