using Contracts.DTOs;
using Core.Abstracts;
using Core.Entities;
using Core.Enums;

namespace Core.Services;

public sealed class AccountHistoryService
{
    private readonly IAccountHistoryRepository _accountHistoryRepository;
    private readonly ReportService _reportService;
    
    public AccountHistoryService(
        IAccountHistoryRepository accountHistoryRepository, 
        ReportService reportService)
    {
        _accountHistoryRepository = accountHistoryRepository;
        _reportService = reportService;
    }
    
    public async Task SaveActionLikeTheBookAsync(ActionDto actionDto, CancellationToken cancellationToken)
    {
        // Пишем данные в отчет на форме
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = actionDto.SessionId,
            User = actionDto.UserContext.Login,
            IpAddress = "localhost",
            Operation = AccountActionType.LikeBook.ToDisplayString(),
            Book = actionDto.BookUrl,
            Status = OperationStatuses.Success.ToDisplayString()
        };
        _reportService.AddReportItem(reportDataDto);
        
        // Сохраняем данные в БД
        AccountActionHistory actionHistory = new AccountActionHistory(
            actionDto.UserContext.AccountId,
            actionDto.SessionId,
            AccountActionType.LikeBook,
            actionDto.BookUrl,
            string.Empty);
        
        await _accountHistoryRepository.AddActionAsync(actionHistory, cancellationToken);
    }
    
    public async Task SaveActionSubscribeToTheAuthorAsync(ActionDto actionDto, CancellationToken cancellationToken)
    {
        // Пишем данные в отчет на форме
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = actionDto.SessionId,
            User = actionDto.UserContext.Login,
            IpAddress = "localhost",
            Operation = AccountActionType.SubscribeToTheAuthor.ToDisplayString(),
            Book = actionDto.BookUrl,
            Status = OperationStatuses.Success.ToDisplayString()
        };
        _reportService.AddReportItem(reportDataDto);
        
        // Сохраняем данные в БД
        AccountActionHistory actionHistory = new AccountActionHistory(
            actionDto.UserContext.AccountId,
            actionDto.SessionId,
            AccountActionType.SubscribeToTheAuthor,
            actionDto.BookUrl,
            string.Empty);
        
        await _accountHistoryRepository.AddActionAsync(actionHistory, cancellationToken);
    }
    
    public async Task SaveActionToLibraryAsync(ActionDto actionDto, CancellationToken cancellationToken)
    {
        // Пишем данные в отчет на форме
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = actionDto.SessionId,
            User = actionDto.UserContext.Login,
            IpAddress = "localhost",
            Operation = AccountActionType.AddToLibrary.ToDisplayString(),
            Book = actionDto.BookUrl,
            Status = OperationStatuses.Success.ToDisplayString()
        };
        _reportService.AddReportItem(reportDataDto);
        
        // Сохраняем данные в БД
        AccountActionHistory actionHistory = new AccountActionHistory(
            actionDto.UserContext.AccountId,
            actionDto.SessionId,
            AccountActionType.AddToLibrary,
            actionDto.BookUrl,
            string.Empty);
        
        await _accountHistoryRepository.AddActionAsync(actionHistory, cancellationToken);
    }
    
    public async Task SaveActionToFavoriteAsync(ActionDto actionDto, CancellationToken cancellationToken)
    {
        // Пишем данные в отчет на форме
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = actionDto.SessionId,
            User = actionDto.UserContext.Login,
            IpAddress = "localhost",
            Operation = AccountActionType.AddToFavorites.ToDisplayString(),
            Book = actionDto.BookUrl,
            Status = OperationStatuses.Success.ToDisplayString()
        };
        _reportService.AddReportItem(reportDataDto);
        
        // Сохраняем данные в БД
        AccountActionHistory actionHistory = new AccountActionHistory(
            actionDto.UserContext.AccountId,
            actionDto.SessionId,
            AccountActionType.AddToFavorites,
            actionDto.BookUrl,
            string.Empty);
        
        await _accountHistoryRepository.AddActionAsync(actionHistory, cancellationToken);
    }

    public async Task SaveActionReadBookAsync(ReadActionDto readActionDto)
    {
        // Используем CancellationToken.None
        // Запись о прочитанных страницах, должна попасть в БД и в отчёт в любом случае
        CancellationToken cancellationToken = CancellationToken.None;

        // Пишем данные в отчет на форме
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = readActionDto.SessionId,
            User = readActionDto.UserContext.Login,
            IpAddress = "localhost",
            Operation = AccountActionType.ReadBook.ToDisplayString(),
            Book = readActionDto.BookUrl,
            SheetsCount = readActionDto.SheetsCount,
            Status = OperationStatuses.Success.ToDisplayString()
        };
        _reportService.AddReportItem(reportDataDto);
        
        // Сохраняем данные в БД
        AccountActionHistory actionHistory = new AccountActionHistory(
            readActionDto.UserContext.AccountId,
            readActionDto.SessionId,
            AccountActionType.ReadBook,
            readActionDto.BookUrl,
            readActionDto.SheetsCount.ToString());
        
        await _accountHistoryRepository.AddActionAsync(actionHistory, cancellationToken);
    }
}