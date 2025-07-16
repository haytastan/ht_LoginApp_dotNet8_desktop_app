# LoginApp - .NET 8.0 Authentication System

A modern, secure, and user-friendly authentication system built with .NET 8.0 and ASP.NET Core Identity.

## Features

- User registration with email confirmation
- Secure login with password hashing
- "Remember me" functionality
- Password reset via email
- Account management (change password, update profile)
- Multi-factor authentication support
- Role-based authorization
- CSRF protection and security headers

## Project Structure

- **Controllers**: 
  - `HomeController.cs`: Main application pages
  - `AccountController.cs`: Authentication and user management functionality

- **Models**: 
  - `ApplicationUser.cs`: Extended Identity user model
  - `ErrorViewModel.cs`: Error handling model

- **ViewModels**:
  - `AccountViewModels.cs`: View models for all account-related forms

- **Views**:
  - Account views for login, registration, password management
  - Home views for the landing page and general content

- **Services**:
  - `EmailSender.cs`: Email service for verification and notifications

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8.0 SDK
- PostgreSQL 16

### Setup

1. Clone or download this repository
2. Open the solution in Visual Studio 2022
3. Update the connection string in `appsettings.json` if needed
4. Run the following commands in Package Manager Console:
   ```
   Update-Database
   ```
5. Run the application

## Configuration

- Email settings can be configured in the `EmailSender.cs` service
- Password requirements can be adjusted in `Program.cs`
- Authentication cookies and security settings are in `Program.cs`

## Design Elements

- Clean, minimalist interface with subtle animations
- Cohesive color system with primary blue (#0078D4)
- Responsive design for all devices
- Apple-inspired form elements
- High contrast for accessibility
- Consistent 8px spacing system

## License

This project is licensed under the MIT License - see the LICENSE file for details.
