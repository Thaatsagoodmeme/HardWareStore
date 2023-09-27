<?php
if (isset($_POST['submit'])) {
    include_once 'database.php';
    $email = $_POST['email'];
    $password = $_POST['password'];
    $connection = connect();
    $sql = "SELECT * FROM employees WHERE Email = ?;";
    $stmt = $connection->prepare($sql);
    $stmt->execute([$email]);
    $result = $stmt->fetchAll();

    if (count($result) == 0 || $password != $result[0]['PasswordHash']) {
        header('Location: login.php?success=invalidcredentials&email='.$email);
        exit();
    }
    
    session_start();
    $_SESSION['employeeId'] = $result[0]['Id'];
    $_SESSION['position'] = $result[0]['Position'];
    if($_SESSION['position'] == 'Salesman') {
        header('Location: salesman.php');
    }
    header('Location: index.php');

} else {
    header('Location: login.php?success=invalidcredentials');
}
