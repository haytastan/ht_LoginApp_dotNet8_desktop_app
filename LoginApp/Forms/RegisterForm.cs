namespace LoginApp;

public partial class RegisterForm : Form
{
    private TextBox txtUsername = null!;
    private TextBox txtPassword = null!;
    private TextBox txtConfirmPassword = null!;
    private TextBox txtEmail = null!;
    private Button btnRegister = null!;
    private Button btnCancel = null!;
    private Label lblUsername = null!;
    private Label lblPassword = null!;
    private Label lblConfirmPassword = null!;
    private Label lblEmail = null!;

    public RegisterForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.txtUsername = new TextBox();
        this.txtPassword = new TextBox();
        this.txtConfirmPassword = new TextBox();
        this.txtEmail = new TextBox();
        this.btnRegister = new Button();
        this.btnCancel = new Button();
        this.lblUsername = new Label();
        this.lblPassword = new Label();
        this.lblConfirmPassword = new Label();
        this.lblEmail = new Label();

        // Username
        this.lblUsername.AutoSize = true;
        this.lblUsername.Location = new Point(50, 50);
        this.lblUsername.Size = new Size(70, 20);
        this.lblUsername.Text = "Username:";

        this.txtUsername.Location = new Point(180, 50);
        this.txtUsername.Size = new Size(200, 25);

        // Email
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new Point(50, 90);
        this.lblEmail.Size = new Size(70, 20);
        this.lblEmail.Text = "Email:";

        this.txtEmail.Location = new Point(180, 90);
        this.txtEmail.Size = new Size(200, 25);

        // Password
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new Point(50, 130);
        this.lblPassword.Size = new Size(70, 20);
        this.lblPassword.Text = "Password:";

        this.txtPassword.Location = new Point(180, 130);
        this.txtPassword.Size = new Size(200, 25);
        this.txtPassword.PasswordChar = '•';

        // Confirm Password
        this.lblConfirmPassword.AutoSize = true;
        this.lblConfirmPassword.Location = new Point(50, 170);
        this.lblConfirmPassword.Size = new Size(120, 20);
        this.lblConfirmPassword.Text = "Confirm Password:";

        this.txtConfirmPassword.Location = new Point(180, 170);
        this.txtConfirmPassword.Size = new Size(200, 25);
        this.txtConfirmPassword.PasswordChar = '•';

        // Register Button
        this.btnRegister.Location = new Point(180, 220);
        this.btnRegister.Size = new Size(94, 29);
        this.btnRegister.Text = "Register";
        this.btnRegister.Click += new EventHandler(btnRegister_Click);

        // Cancel Button
        this.btnCancel.Location = new Point(286, 220);
        this.btnCancel.Size = new Size(94, 29);
        this.btnCancel.Text = "Cancel";
        this.btnCancel.Click += new EventHandler(btnCancel_Click);

        // RegisterForm
        this.ClientSize = new Size(450, 300);
        this.Controls.Add(this.lblUsername);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblPassword);
        this.Controls.Add(this.lblConfirmPassword);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.txtConfirmPassword);
        this.Controls.Add(this.btnRegister);
        this.Controls.Add(this.btnCancel);
        this.Name = "RegisterForm";
        this.Text = "Register";
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            if (RegisterUser())
            {
                MessageBox.Show("Registration successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text) ||
            string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
        {
            MessageBox.Show("Please fill in all fields.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!IsValidEmail(txtEmail.Text))
        {
            MessageBox.Show("Please enter a valid email address.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            MessageBox.Show("Passwords do not match.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    private bool RegisterUser()
    {
        // TODO: Implement actual database registration
        return true;
    }
}