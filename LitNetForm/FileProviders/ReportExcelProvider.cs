using ClosedXML.Excel;
using LitPulse.Shared;

namespace LitPulse.FileProviders;

public class ReportExcelProvider : IFileProvider
{
    private const string DIALOG_FILE_FILTER = "Excel (*.xlsx)|*.xlsx";
    private const int EXCEL_COLUMN_WIDTH = 20;
    private const int EXCEL_COLUMN_USER_WIDTH = 30;
    private const int EXCEL_COLUMN_BOOK_WIDTH = 160;

    private readonly IReadOnlyList<ReportDataDto> _reportsData;

    private readonly string[] _columnNames =
        ["User", "UserIpAddress", "Operation", "Book", "SheetsCount", "Status", "SessionDateTime"];

    public ReportExcelProvider(IEnumerable<ReportDataDto> reportsData)
    {
        _reportsData = reportsData.ToList();
    }

    public async Task SaveFileAsync(CancellationToken cancellationToken)
    {
        using var memoryStream = new MemoryStream();

        CreateReportAsExcelFile(memoryStream, _reportsData, _columnNames);

        using var dialogFile = new SaveFileDialog();
        dialogFile.Filter = DIALOG_FILE_FILTER;

        if (dialogFile.ShowDialog() == DialogResult.OK)
        {
            await File.WriteAllBytesAsync(dialogFile.FileName, memoryStream.ToArray(), cancellationToken);
        }
    }

    private static void CreateReportAsExcelFile(
        MemoryStream stream,
        IReadOnlyList<ReportDataDto> reportData,
        string[] columnNames)
    {
        using var workBook = new XLWorkbook();

        var workSheet = workBook.AddWorksheet();
        workSheet.ColumnWidth = EXCEL_COLUMN_WIDTH;

        workSheet.FirstCell().InsertTable(reportData);

        workSheet.Cell(1, Array.IndexOf(columnNames, "User") + 1).Value = "Пользователь";
        workSheet.Cell(1, Array.IndexOf(columnNames, "UserIpAddress") + 1).Value = "IP адрес";
        workSheet.Cell(1, Array.IndexOf(columnNames, "Operation") + 1).Value = "Операция";
        workSheet.Cell(1, Array.IndexOf(columnNames, "Book") + 1).Value = "Книга";
        workSheet.Cell(1, Array.IndexOf(columnNames, "SheetsCount") + 1).Value = "Кол-во страниц";
        workSheet.Cell(1, Array.IndexOf(columnNames, "Status") + 1).Value = "Статус";
        workSheet.Cell(1, Array.IndexOf(columnNames, "SessionDateTime") + 1).Value = "Время";

        workSheet.Column(Array.IndexOf(columnNames, "User") + 1).Width = EXCEL_COLUMN_USER_WIDTH;
        workSheet.Column(Array.IndexOf(columnNames, "Book") + 1).Width = EXCEL_COLUMN_BOOK_WIDTH;

        workBook.SaveAs(stream);
    }
}