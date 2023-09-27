<?php
include_once 'database.php';

if (isset($_POST['action'])) {
    $shiftId = $_POST['shiftId'];

    $connection = connect();

    $sql = "DELETE FROM `work_shift` 
    WHERE shift_id = ?;";
    $statement = $connection->prepare($sql);
    $statement->execute([$shiftId]);
}