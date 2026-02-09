namespace Core.Enums;

public static class EnumsExtension
{
    public static string ToDisplayString(this AccountActionType accountActionType)
    {
        string text = accountActionType switch
        {
            AccountActionType.ReadBook => "Чтение книги",
            AccountActionType.LikeBook => "Поставил лайк книге",
            AccountActionType.AddToLibrary => "Добавил книгу в библиотеку",
            AccountActionType.AddToFavorites => "Добавил книгу в избранное",
            AccountActionType.SubscribeToTheAuthor => "Подписался на автора",
            AccountActionType.StartSession => "Начало сессии",
            AccountActionType.StopSession => "Конец сессии",
            _ => "Неизвестное действие"
        };
        return text;
    }

    public static string ToDisplayString(this OperationStatuses operationStatuses)
    {
        string text = operationStatuses switch
        {
            OperationStatuses.Success => "Успешно",
            OperationStatuses.Failure => "Неудачно",
            _ => "Неизвестная операция"
        };
        return text;
    }

    public static string ToDisplayString(this ReadProfile readProfile)
    {
        string text = readProfile switch
        {
            ReadProfile.DeepReader => "Глубокое чтение",
            ReadProfile.SpeedReader => "Быстрое чтение",
            ReadProfile.TiredReader => "Уставшее чтение",
            _ => "Неизвестная операция"
        };
        return text;
    }

    public static ReadProfile ToReadProfile(this string value)
    {
        ReadProfile readProfile = value switch
        {
            "Глубокое чтение" => ReadProfile.DeepReader,
            "Быстрое чтение" => ReadProfile.SpeedReader,
            "Уставшее чтение" => ReadProfile.TiredReader,
            _ => ReadProfile.DeepReader
        };
        return readProfile;
    }
}