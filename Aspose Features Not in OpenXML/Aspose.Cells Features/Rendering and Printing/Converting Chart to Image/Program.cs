﻿using Aspose.Cells;
using Aspose.Cells.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Chart_to_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertingChartToEMF();
            ConvertingChartToBMP();
            ConvertingCharttoJPEG();
            ConvertingCharttoPNG();
            ConvertingChartTOTIFF();
        }
        public static void ConvertingChartToEMF()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to EMF Image.Emf", System.Drawing.Imaging.ImageFormat.Emf);
        }
        public static void ConvertingCharttoJPEG()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to JPEG Image.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        public static void ConvertingCharttoPNG()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to PNG Image.Png", System.Drawing.Imaging.ImageFormat.Png);
        }
        public static void ConvertingChartTOTIFF()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to Tiff Image.Tiff", System.Drawing.Imaging.ImageFormat.Tiff);
        }
        public static void ConvertinfChartTOMultiPageTIFF()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);

            ImageOrPrintOptions options = new ImageOrPrintOptions();
            options.HorizontalResolution = 300;
            options.VerticalResolution = 300;
            options.TiffCompression = TiffCompression.CompressionLZW;
            options.IsCellAutoFit = false;
            options.ImageFormat = System.Drawing.Imaging.ImageFormat.Tiff;
            options.OnePagePerSheet = true;
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to Tiff Image.tiff",options);            
        }
        public static void ConvertingChartToBMP()
        {
            string MyDir = "";
            //Instantiating a Workbook object
            Workbook workbook = new Workbook();
            //Adding a new worksheet to the Excel object
            int sheetIndex = workbook.Worksheets.Add();
            //Obtaining the reference of the newly added worksheet by
            //passing its sheet index
            Worksheet worksheet = workbook.Worksheets[sheetIndex];
            //Adding a sample value to "A1" cell
            worksheet.Cells["A1"].PutValue(50);
            //Adding a sample value to "A2" cell
            worksheet.Cells["A2"].PutValue(100);
            //Adding a sample value to "A3" cell
            worksheet.Cells["A3"].PutValue(150);
            //Adding a sample value to "B1" cell
            worksheet.Cells["B1"].PutValue(4);
            //Adding a sample value to "B2" cell
            worksheet.Cells["B2"].PutValue(20);
            //Adding a sample value to "B3" cell
            worksheet.Cells["B3"].PutValue(50);

            //Adding a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 5, 0, 15, 5);
            //Accessing the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];
            //Adding Series Collection (chart data source) to the chart ranging from "A1" cell to "B3"
            chart.NSeries.Add("A1:B3", true);
            //Converting chart to image.
            chart.ToImage(MyDir + "Chart to BMP Image.Bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

    }
}
