﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Reporting
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
