using System.Data.SqlClient;

namespace LoginApp;

public partial class LoginForm : Form
{
    private TextBox txtUsername = null!;
    private TextBox txtPassword = null!;
    private Button btnLogin = null!;
    private Button btnRegister = null!;
    private Label lblUsername = null!;
    private Label lblPassword = null!;

    public LoginForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnRegister = new Button();
        lblUsername = new Label();
        lblPassword = new Label();
        SuspendLayout();
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(150, 50);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(200, 23);
        txtUsername.TabIndex = 2;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(150, 100);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '•';
        txtPassword.Size = new Size(200, 23);
        txtPassword.TabIndex = 3;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(150, 150);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(94, 29);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Login";
        btnLogin.Click += btnLogin_Click;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(256, 150);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(94, 29);
        btnRegister.TabIndex = 5;
        btnRegister.Text = "Register";
        btnRegister.Click += btnRegister_Click;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(50, 50);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(63, 15);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Username:";
        lblUsername.Click += lblUsername_Click;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(50, 100);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(60, 15);
        lblPassword.TabIndex = 1;
        lblPassword.Text = "Password:";
        // 
        // LoginForm
        // 
        ClientSize = new Size(400, 250);
        Controls.Add(lblUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        Controls.Add(btnRegister);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MessageBox.Show("Please enter both username and password.", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (ValidateLogin(txtUsername.Text, txtPassword.Text))
        {
            MessageBox.Show("Login successful!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Open main form here
        }
        else
        {
            MessageBox.Show("Invalid username or password.", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm();
        registerForm.ShowDialog();
    }

    private bool ValidateLogin(string username, string password)
    {
        // TODO: Implement actual database validation
        return username == "admin" && password == "password";
    }

    private void lblUsername_Click(object sender, EventArgs e)
    {

    }
}