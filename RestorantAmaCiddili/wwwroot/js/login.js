document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent form submission
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;

    // Check if username and password are correct
    if (username === 'admin' && password === 'admin') {
        // Successful login
        document.getElementById('username').style.transition = 'border-color 0.5s ease';
        document.getElementById('username').style.borderColor = '#15F5BA';
        document.getElementById('password').style.transition = 'border-color 0.5s ease';
        document.getElementById('password').style.borderColor = '#15F5BA';
        document.getElementById('login').style.transition = 'box-shadow 0.5s ease';
        document.getElementById('login').style.boxShadow = '0 0 30px #15F5BA';
        setTimeout(function(){
            window.location.href = '/Admin/Admin';
        }, 2000);
    } else {
        // Failed login
        document.getElementById('username').style.transition = 'border-color 0.5s ease';
        document.getElementById('username').style.borderColor = 'red';
        document.getElementById('password').style.transition = 'border-color 0.5s ease';
        document.getElementById('password').style.borderColor = 'red';
        document.getElementById('login').style.transition = 'box-shadow 0.5s ease';
        document.getElementById('login').style.boxShadow = '0 0 30px red';
    }
});
