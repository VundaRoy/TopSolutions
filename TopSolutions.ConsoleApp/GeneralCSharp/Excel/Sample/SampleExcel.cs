using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Excel.Sample
{
    public class SampleExcel
    {
        public static void Main(string[] args)
        {
            try
            {
                #region Data
                //In Real-Time you will get the data from the database,
                //but here we have hard-coded the data
                List<Employee> empList = new List<Employee>();
                for (int i = 0; i < 100; i++)
                {
                    Employee emp = new Employee()
                    {
                        ID = 100 + i,
                        Name = "Name-" + i,
                        Address = "Some Address",
                        Email = "SameEmail@dotnettutorials.net",
                        IsPermanent = true,
                        Mobile = "0123456789",
                        RegdNo = 12345 + i + 6789,
                        Salary = 10000 + i,
                        ProfileURL = "100" + i
                    };
                    empList.Add(emp);
                }
                #endregion
                #region Creating Excel Sheet
                //The following Pieces of Code will Create the Excel File, 
                //Excel Sheet and font object which will be used later
                HSSFWorkbook workbook = new HSSFWorkbook();
                //The sheet name is going to be Dot Net Tutorials
                HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Dot Net Tutorials");
                HSSFFont font = (HSSFFont)workbook.CreateFont();
                #endregion
                #region Creating Different Cell Styles
                //Now, we going to create different cell styles for different data
                #region Company Cell Styles
                //We will use the following cell style with the Company Name
                var Company = workbook.CreateCellStyle();
                Company.Alignment = HorizontalAlignment.Left;
                var CompanyFont = workbook.CreateFont();
                CompanyFont.FontName = "Arial";
                CompanyFont.Color = HSSFColor.Blue.Index;
                CompanyFont.Boldweight = (short)FontBoldWeight.Bold;
                CompanyFont.FontHeightInPoints = ((short)16);
                Company.SetFont(CompanyFont);
                #endregion
                #region Address Cell Style
                //We will use the following cell style with the Company Address
                var Address = workbook.CreateCellStyle();
                Address.Alignment = HorizontalAlignment.Left;
                var AddressFont = workbook.CreateFont();
                AddressFont.FontName = "Arial";
                AddressFont.Boldweight = (short)FontBoldWeight.Bold;
                AddressFont.FontHeightInPoints = ((short)10);
                Address.SetFont(AddressFont);
                #endregion
                #region Header Cell Style
                //We will use the following cell style with the Header
                var Header = workbook.CreateCellStyle();
                Header.Alignment = HorizontalAlignment.Center;
                Header.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
                Header.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
                Header.FillPattern = FillPattern.SolidForeground;
                var HeaderFont = workbook.CreateFont();
                HeaderFont.FontName = "Arial";
                HeaderFont.Boldweight = (short)FontBoldWeight.Bold;
                HeaderFont.Color = HSSFColor.White.Index;
                HeaderFont.FontHeightInPoints = ((short)10);
                Header.SetFont(HeaderFont);
                Header.BorderLeft = BorderStyle.Thin;
                Header.BorderTop = BorderStyle.Thin;
                Header.BorderRight = BorderStyle.Thin;
                Header.BorderBottom = BorderStyle.Thin;
                #endregion
                #region Number Data Cell Style
                //We will use the following cell style with Data which is Numeric
                var NumData = workbook.CreateCellStyle();
                var formatId = HSSFDataFormat.GetBuiltinFormat("##0.00");
                if (formatId == -1)
                {
                    var newDataFormat = workbook.CreateDataFormat();
                    NumData.DataFormat = newDataFormat.GetFormat("##0.00");
                }
                else
                    NumData.DataFormat = formatId;
                #endregion
                #region Data Cell Style
                //We will use the following cell style with Data that is NOT Numeric
                var Data = workbook.CreateCellStyle();
                Data.Alignment = HorizontalAlignment.Center;
                var DataFont = workbook.CreateFont();
                DataFont.FontName = "Arial";
                DataFont.FontHeightInPoints = ((short)9);
                Data.SetFont(DataFont);
                Data.BorderLeft = BorderStyle.Thin;
                Data.BorderTop = BorderStyle.Thin;
                Data.BorderRight = BorderStyle.Thin;
                Data.BorderBottom = BorderStyle.Thin;
                #endregion
                #region Link Data Cell Style
                //We will use the following cell style with Hyperlink Data
                var linkData = workbook.CreateCellStyle();
                linkData.Alignment = HorizontalAlignment.Center;
                var linkDataFont = workbook.CreateFont();
                linkDataFont.FontName = "Arial";
                linkDataFont.Color = HSSFColor.Blue.Index;
                linkDataFont.FontHeightInPoints = ((short)9);
                linkDataFont.Underline = FontUnderlineType.Single;
                linkDataFont.Color = HSSFColor.Blue.Index;
                linkData.SetFont(linkDataFont);
                linkData.BorderLeft = BorderStyle.Thin;
                linkData.BorderTop = BorderStyle.Thin;
                linkData.BorderRight = BorderStyle.Thin;
                linkData.BorderBottom = BorderStyle.Thin;
                #endregion
                #endregion
                #region Creating Company and Address of the Excel Sheet
                //Creating the Company Name from 2nd Row by applying Company Cell Style
                // rowIndex is going to hold the Row Number. Inex means 0 - Based Index
                int rowIndex = 2; //rowIndex 2 means 3rd Row
                var row = sheet.CreateRow(rowIndex);
                var cell = row.CreateCell(4);
                cell.SetCellValue("Dot Net Tutorials Online Training");
                cell.CellStyle = Company;
                sheet.AddMergedRegion(new CellRangeAddress(4, 4, 4, 14));
                //Creating the Company Address from 3rd Row by applying Address Cell Style
                rowIndex = rowIndex + 1;
                var row1 = sheet.CreateRow(rowIndex);
                var cell1 = row1.CreateCell(4);
                cell1.SetCellValue("1988/2019, 5th floor, Tower B, Bajrang Vihar, Patia, Bhubaneswar-400051, India");
                cell1.CellStyle = Address;
                sheet.AddMergedRegion(new CellRangeAddress(5, 5, 4, 14));
                #endregion
                // Set Row index for Header 
                rowIndex = 7; //rowIndex 7 means 8th Row which is going to be our Header in Excel Sheet
                var SR_NO = 0; //We want a unique Serial Number for Each Row in the Excel Sheet
                #region Excel Data Headers
                var cellheaderindex = 0;
                var excelheaderrow = sheet.CreateRow(rowIndex);
                var excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("SR NO");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("ID");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("Name");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("Address");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("Email");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("IsPermanent");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("Mobile");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("RegdNo");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("Salary");
                excelheadercell.CellStyle = Header;
                cellheaderindex = cellheaderindex + 1;
                excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
                excelheadercell.SetCellValue("ProfileURL");
                excelheadercell.CellStyle = Header;
                #endregion
                #region Excel Data
                foreach (Employee data in empList)
                {
                    //Increase the rowIndex and SR_NO by 1 for each record in the empList
                    rowIndex = rowIndex + 1; //This will be the row number in the Excel Sheet
                    SR_NO = SR_NO + 1; //Unique Serial Number
                    var cellindex = 0; //Cell Number starting from 0
                    //Create the New Row
                    var gridrow = sheet.CreateRow(rowIndex);
                    //Create the first Cell in the new Row
                    var gridcell = gridrow.CreateCell(cellindex);
                    //Add value to the Cell 
                    gridcell.SetCellValue(SR_NO);
                    //Apply appropriate CSS Styles
                    gridcell.CellStyle = Data;
                    //Increse the Cell Index by 1 to create the next cell in the Row
                    cellindex = cellindex + 1;
                    //Create the new cell
                    gridcell = gridrow.CreateCell(cellindex);
                    //Add value to the Cell
                    gridcell.SetCellValue(data.ID);
                    //Apply appropriate CSS Styles
                    gridcell.CellStyle = Data;
                    //The Process will continue till the last cell in the Row
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.Name);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.Address);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.Email);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.IsPermanent);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.Mobile);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.RegdNo);
                    gridcell.CellStyle = Data;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(Convert.ToDouble(data.Salary));
                    gridcell.CellStyle = NumData;
                    cellindex = cellindex + 1;
                    gridcell = gridrow.CreateCell(cellindex);
                    gridcell.SetCellValue(data.ProfileURL);
                    //Setting the Cell value as Hyper link
                    HSSFHyperlink link = new HSSFHyperlink(HyperlinkType.Url)
                    {
                        //On click on the Hyperlink, it will open the following URL in the browser
                        Address = "http://www.dotnettutorials.net/" + data.ProfileURL
                    };
                    gridcell.Hyperlink = (link);
                    gridcell.CellStyle = linkData;
                }
                #endregion
                #region Freezing Point
                //Setting the Freezing Point- Column 0 and Row Number 8
                sheet.CreateFreezePane(0, 8, 0, 8);
                for (int i = 0; i <= cellheaderindex; i++)
                {
                    sheet.SetColumnWidth(i, 5000);
                }
                #endregion
                #region TOTAL & FORMALA SECTION
                //We need to calculate the sum of the salary column
                var startrow = 9; //Data Rows started from Row Number 9
                var lastdatarow = rowIndex + 1; //Last Row
                rowIndex = rowIndex + 2; //Creating a New Rows to display the Total
                var Formularow = sheet.CreateRow(rowIndex);
                var Formulacell = Formularow.CreateCell(0);
                Formulacell.SetCellValue("TOTAL");
                Formulacell.CellStyle = Header;
                //Creating a Cell to display the Total
                Formulacell = Formularow.CreateCell(8);
                //Formula to calculate the Total
                Formulacell.CellStyle = Header;
                String strFormula = "SUBTOTAL(9,I" + Convert.ToString(startrow) + ":I" + Convert.ToString(lastdatarow) + ")";
                Formulacell.SetCellType(CellType.Formula);
                Formulacell.SetCellFormula(strFormula);
                HSSFFormulaEvaluator.EvaluateAllFormulaCells(workbook);
                #endregion
                #region LOGO
                //Displaying the Logo on the TOP Left Corner of the Excel Sheet
                HSSFPatriarch patriarch = (HSSFPatriarch)sheet.CreateDrawingPatriarch();
                HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 0, 255, 1, 2, 2, 5)
                {
                    AnchorType = (int)NPOI.SS.UserModel.AnchorType.MoveAndResize
                };
                //Here, you need to replace the Image Path and Name as per your directory structure and Image Name
                HSSFPicture picture = (HSSFPicture)patriarch.CreatePicture(anchor, LoadImage(@"C:\dev\Text\Excel\DotNetTutorials.png", workbook));
                picture.Resize();
                picture.LineStyle = (LineStyle)HSSFPicture.LINESTYLE_NONE;
                #endregion

                //Finally, Create the Excel File and Save it on a specified Location
                string FileName = "MyExcel_" + DateTime.Now.ToString("yyyy-dd-MM--HH-mm-ss") + ".xls";
                //Here, you need to replace the Path as per your directory structure where you want to save the image
                using (FileStream file = new FileStream(@"C:\dev\Text\Excel\" + FileName, FileMode.Create))
                {
                    workbook.Write(file);
                    file.Close();
                    Console.WriteLine("File Created Successfully...");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        //The following code is used to load the Image, Create the Image and return that image
        public static int LoadImage(string path, HSSFWorkbook wb)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[file.Length];
            file.Read(buffer, 0, (int)file.Length);
            return wb.AddPicture(buffer, PictureType.JPEG);
        }
    }
}
