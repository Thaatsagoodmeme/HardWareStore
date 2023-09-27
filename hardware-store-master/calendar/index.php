<?php
include 'database.php';
// Start session
session_start();

// If employee is not logged in, return to login page
if (!isset($_SESSION['employeeId'])) {
    header('Location: login.php');
}

if($_SESSION['position'] == 'Salesman') {
    header('Location: salesman.php');
} else {
    header('Location: regular.php');
}