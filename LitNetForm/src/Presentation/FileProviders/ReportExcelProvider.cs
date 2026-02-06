using ClosedXML.Excel;
using Contracts.DTOs;

namespace LitPulse.FileProviders;

public sealed class ReportExcelProvider
{
    private const string DIALOG_FILE_FILTER = "Excel (*.xlsx)|*.xlsx";
    private const int EXCEL_COLUMN_WIDTH = 20;
    private const int EXCEL_COLUMN_USER_WIDTH = 30;
    private const int EXCEL_COLUMN_SESSION_ID_WIDTH = 40;
    private const int EXCEL_COLUMN_BOOK_WIDTH = 160;

    private readonly Dictionary<string, int> _columns = new()
    {
        ["SessionId"] = 1,
        ["User"] = 2,
        ["UserIpAddress"] = 3,
        ["Operation"] = 4,
        ["Book"] = 5,
        ["SheetsCount"] = 6,
        ["Status"] = 7,
        ["SessionDateTime"] = 8
    };

    public async Task SaveFileAsync(
        IReadOnlyList<ReportDataDto> reportData,
        CancellationToken cancellationToken)
    {
        using var memoryStream = new MemoryStream();

        CreateReportAsExcelFile(memoryStream, reportData);

        using var dialogFile = new SaveFileDialog();
        dialogFile.Filter = DIALOG_FILE_FILTER;

        if (dialogFile.ShowDialog() == DialogResult.OK)
        {
            await File.WriteAllBytesAsync(dialogFile.FileName, memoryStream.ToArray(), cancellationToken);
        }
    }

    private void CreateReportAsExcelFile(
        MemoryStream stream,
        IReadOnlyList<ReportDataDto> reportData)
    {
        using var workBook = new XLWorkbook();

        var workSheet = workBook.AddWorksheet();
        workSheet.ColumnWidth = EXCEL_COLUMN_WIDTH;

        workSheet.FirstCell().InsertTable(reportData);
        
        workSheet.Cell(1, _columns.GetValueOrDefault("SessionId")).Value = "ID сессии";
        workSheet.Cell(1, _columns.GetValueOrDefault("User")).Value = "Пользователь";
        workSheet.Cell(1, _columns.GetValueOrDefault("UserIpAddress")).Value = "IP адрес";
        workSheet.Cell(1, _columns.GetValueOrDefault("Operation")).Value = "Операция";
        workSheet.Cell(1, _columns.GetValueOrDefault("Book")).Value = "Книга";
        workSheet.Cell(1, _columns.GetValueOrDefault("SheetsCount")).Value = "Кол-во страниц";
        workSheet.Cell(1, _columns.GetValueOrDefault("Status")).Value = "Статус";
        workSheet.Cell(1, _columns.GetValueOrDefault("SessionDateTime")).Value = "Время";

        workSheet.Column(_columns.GetValueOrDefault("SessionId")).Width = EXCEL_COLUMN_SESSION_ID_WIDTH;
        workSheet.Column(_columns.GetValueOrDefault("User")).Width = EXCEL_COLUMN_USER_WIDTH;
        workSheet.Column(_columns.GetValueOrDefault("Book")).Width = EXCEL_COLUMN_BOOK_WIDTH;

        workBook.SaveAs(stream);
    }
}