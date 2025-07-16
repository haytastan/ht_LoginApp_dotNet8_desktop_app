// JavaScript for LoginApp

// Wait for the DOM to be fully loaded
document.addEventListener('DOMContentLoaded', function () {
    
    // Add form animation effects
    const forms = document.querySelectorAll('form');
    forms.forEach(form => {
        // Add transition effects to inputs when focused
        const inputs = form.querySelectorAll('input');
        inputs.forEach(input => {
            input.addEventListener('focus', function() {
                this.parentElement.classList.add('focused');
            });
            
            input.addEventListener('blur', function() {
                this.parentElement.classList.remove('focused');
            });
        });
    });
    
    // Add alert dismissal functionality
    const alerts = document.querySelectorAll('.alert');
    alerts.forEach(alert => {
        // Automatically dismiss alerts after 5 seconds
        setTimeout(() => {
            const bsAlert = new bootstrap.Alert(alert);
            bsAlert.close();
        }, 5000);
    });
    
    // Password strength indicator for registration and password change
    const passwordInputs = document.querySelectorAll('input[type="password"]');
    passwordInputs.forEach(input => {
        if (input.id === 'Password' || input.id === 'NewPassword') {
            // Create password strength indicator element
            const strengthMeter = document.createElement('div');
            strengthMeter.className = 'password-strength mt-1 mb-3';
            strengthMeter.innerHTML = `
                <div class="progress" style="height: 5px;">
                    <div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
                <small class="strength-text text-muted"></small>
            `;
            
            // Insert after the input's parent (form-floating div)
            input.parentElement.after(strengthMeter);
            
            // Check password strength on input
            input.addEventListener('input', function() {
                const password = this.value;
                let strength = 0;
                let strengthText = '';
                
                if (password.length > 0) {
                    // Length check
                    if (password.length >= 8) strength += 20;
                    
                    // Character variety checks
                    if (/[A-Z]/.test(password)) strength += 20; // Uppercase
                    if (/[a-z]/.test(password)) strength += 20; // Lowercase
                    if (/[0-9]/.test(password)) strength += 20; // Numbers
                    if (/[^A-Za-z0-9]/.test(password)) strength += 20; // Special chars
                    
                    // Set text based on strength
                    if (strength < 40) {
                        strengthText = 'Weak';
                        strengthMeter.querySelector('.progress-bar').classList.remove('bg-warning', 'bg-success');
                        strengthMeter.querySelector('.progress-bar').classList.add('bg-danger');
                    } else if (strength < 80) {
                        strengthText = 'Medium';
                        strengthMeter.querySelector('.progress-bar').classList.remove('bg-danger', 'bg-success');
                        strengthMeter.querySelector('.progress-bar').classList.add('bg-warning');
                    } else {
                        strengthText = 'Strong';
                        strengthMeter.querySelector('.progress-bar').classList.remove('bg-danger', 'bg-warning');
                        strengthMeter.querySelector('.progress-bar').classList.add('bg-success');
                    }
                } else {
                    strengthText = '';
                }
                
                // Update UI
                strengthMeter.querySelector('.progress-bar').style.width = strength + '%';
                strengthMeter.querySelector('.progress-bar').setAttribute('aria-valuenow', strength);
                strengthMeter.querySelector('.strength-text').textContent = strengthText;
            });
        }
    });
    
    // Profile image preview update
    const profileImageUrl = document.getElementById('ProfilePictureUrl');
    if (profileImageUrl) {
        profileImageUrl.addEventListener('input', function() {
            const imageUrl = this.value;
            const profileImageElement = document.querySelector('.profile-image');
            
            if (imageUrl && profileImageElement) {
                profileImageElement.src = imageUrl;
                profileImageElement.onerror = function() {
                    this.src = 'https://via.placeholder.com/120';
                };
            }
        });
    }
});