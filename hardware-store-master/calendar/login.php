<?php
include_once 'include/myloader.php';
session_start();

if (isset($_SESSION['employeeId'])) {
    header('Location: index.php');
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>MB Accounting Login</title>
    <link rel="stylesheet" href="css/login.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet">
</head>

<body>
    <div id="panel">
        <div id="left-panel">
            <img src="img/logo-MBA.png" alt="MB Accounting logo" id="logo">
        </div>
        <div id="right-panel">
            <form action="/calendar/login-user.php" method="POST">
                <label for="email">Email:</label>
                <br>
                <input type="email" name="email" id="email" <?php if(isset($_GET['email'])) { echo 'value="'.$_GET['email'].'"'; } ?>>
                <br>
                <label for="password">Password:</label>
                <br>
                <input type="password" name="password" id="password">
                <br>
                <input type="submit" value="LOGIN" name="submit">
                <div id="cvsk-logo-wrapper">
                    <img src="img/logo-cvsk.png" alt="CVSK SOLUTIONS LOGO" id="cvsk-logo">
                </div>
                <?php
                if (isset($_GET['success'])) {
                    $success = $_GET['success'];
                    switch ($success) {
                        case 'invalidcredentials':
                            echo '<p class="error">Invalid credentials!</p>';
                            break;
                        case 'logout':
                            echo '<p class="success">Logged out successfully!</p>';
                            break;
                    }
                }
                ?>
            </form>
        </div>
    </div>
</body>

</html>