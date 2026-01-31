using Contracts.DTOs;

namespace LitPulse.Forms;

public partial class AddAccountForm : Form
{
    public AddAccountForm()
    {
        InitializeComponent();
    }

    private void buttonAddAccount_Click(object sender, EventArgs e)
    {
        if (textBoxLogin.Text != string.Empty && 
            textBoxPassword.Text != string.Empty)
        {
            DialogResult = DialogResult.OK;
        }
    }

    public AccountDto GetDataForNewAccount()
    {
        AccountDto accountDto = new AccountDto(
            textBoxLogin.Text,
            textBoxPassword.Text,
            checkBoxLitNet.Checked,
            checkBoxLitMarket.Checked);
        
        return accountDto;
    }
}