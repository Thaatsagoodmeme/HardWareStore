<?php
include 'database.php';
if (isset($_POST['action'])) {
    $employeeId = $_POST['employeeId'];
    $date = $_POST['date'];
    $time = $_POST['time'];
    // Check if work shift exists or if employee wants availability before today
    if(checkIfShiftExists($employeeId, $date, $time) || 
    new DateTime($date) <= new DateTime()) {
       exit;
    }
    $connection = connect();

    $sql = "INSERT INTO `work_shift` 
            (`shift_id`, `employee_id`, `shift_date`, `shift_time`, `is_shift`) 
            VALUES (NULL, ?, ?, ?, '0');";
    $statement = $connection->prepare($sql);
    $statement->execute([$employeeId, $date, $time]);

    $connection = null;
}

function checkIfShiftExists($employeeId, $date, $time)
    {
        $connection = connect();

        $sql = "SELECT *
                FROM `work_shift` 
                WHERE employee_id = ?
                AND shift_date = ?
                AND shift_time = ?;";
        $statement = $connection->prepare($sql);
        $statement->execute([$employeeId, $date, $time]);
        $result = $statement->fetchAll();

        $conneciton = null;

        if (count($result) > 0) {
            return true;
        }
        return false;
    }