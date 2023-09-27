<?php
function connect()
{
    $host = 'studmysql01.fhict.local';
    $dbName = 'dbi449915';
    $dbUsername = 'dbi449915';
    $dbPassword = 'dbiCSVK'; 

    /*$host = 'localhost';
    $dbName = 'test';
    $dbUsername = 'root';
    $dbPassword = '123456'; */

    $dsn = 'mysql:host=' . $host . ';dbname=' . $dbName;
    $conn = new PDO($dsn, $dbUsername, $dbPassword);
    $conn->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_ASSOC);

    return $conn;
}
