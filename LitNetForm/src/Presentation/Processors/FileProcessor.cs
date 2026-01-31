using Contracts.DTOs;

namespace LitPulse.Processors;

public class FileProcessor
{
    private const string DIALOG_FILE_FILTER = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
    private const int FILTER_INDEX = 1;
    private const bool RESTORE_DIRECTORY = true;

    public async Task<IReadOnlyList<AccountDto>> AccountsFileProcess(CancellationToken cancellationToken)
    {
        string[] fileRows = await TxtFileInAccountListAsync(cancellationToken);

        List<AccountDto> accountsDto = [];
        foreach (string line in fileRows)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            // Разделяем строку по двоеточию
            string[] parts = line.Split(':', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 2)
            {
                string login = parts[0].Trim();
                string password = parts[1].Trim();

                accountsDto.Add(new AccountDto(
                    login,
                    password,
                    false,
                    false));
            }
            else if (parts.Length > 2)
            {
                // Если в пароле есть двоеточие, обрабатываем особым образом
                string login = parts[0].Trim();
                string password = string.Join(":", parts.Skip(1)).Trim();

                accountsDto.Add(new AccountDto(
                    login,
                    password,
                    false,
                    false));
            }
            // Игнорируем строки с неверным форматом
        }

        return accountsDto;
    }

    private async Task<string[]> TxtFileInAccountListAsync(CancellationToken cancellationToken)
    {
        using var openFileDialog = new OpenFileDialog();

        openFileDialog.Title = "Выберите текстовый файл";
        openFileDialog.Filter = DIALOG_FILE_FILTER;
        openFileDialog.FilterIndex = FILTER_INDEX;
        openFileDialog.RestoreDirectory = RESTORE_DIRECTORY;

        // Если пользователь выбрал файл и нажал OK
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Читаем все строки из файла в массив
                string[] fileRows = await File.ReadAllLinesAsync(openFileDialog.FileName, cancellationToken);
                return fileRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return [];
            }
        }

        return [];
    }
}