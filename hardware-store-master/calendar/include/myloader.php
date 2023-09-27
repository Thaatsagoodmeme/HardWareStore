<?php
spl_autoload_register('myLoader');

function myLoader($className)
{
    $path = '';
    $extension = '.class.php';
    $fileName = $path . $className . $extension;

    if (!file_exists($fileName)) {
        return false;
    }

    include_once($fileName);
}