<?php
include 'database.php';
// Start session
session_start();

// If employee is not logged in, return to login page
if (!isset($_SESSION['employeeId'])) {
    header('Location: login.php');
}

// If employee is logged in, set global variable employeeId
global $employeeId;
$employeeId = $_SESSION['employeeId'];

// $date corresponds to chosen date
global $date;
if (isset($_GET['date'])) {
    $date = new DateTime($_GET['date']);
} else {
    // If date is not provided, we set it to today
    $date = new DateTime();
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>My Schedule</title>
    <link rel="stylesheet" href="css/schedule.css">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet">
</head>

<body>

    <!-- Navigation -->
    <nav>

        <!-- Top left logo -->
        <div class="nav-element">
            <img src="img/logo-accouting.png" alt="MB Accouting">
        </div>

        <!-- Today button -->
        <div class="nav-element">
            <?php
            echo '<a href="/calendar/regular.php?date=' . (new DateTime())->format('Y-m-d') . '"><span id="today" class="hover bold">
                Today
                </span>
                </a>';
            ?>
        </div>

        <!-- Previous week button -->
        <div class="nav-element">
            <div class="week-change bold hover">
                <?php
                $firstDayOfPreviousWeek = (clone $date)->modify('this week -7 days');
                echo '<a href="/calendar/regular.php?date=' . $firstDayOfPreviousWeek->format('Y-m-d') . '">
                    <span>
                    &#60;
                    </span>
                    </a>';
                ?>
            </div>
        </div>

        <!-- Next week button -->
        <div class="nav-element">
            <div class="week-change bold hover">
                <?php
                $firstDayOfNextWeek = (clone $date)->modify('this week +7 days');
                echo '<a href="/calendar/regular.php?date=' . $firstDayOfNextWeek->format('Y-m-d') . '">
                    <span>
                    &#62;
                    </span>
                    </a>';
                ?>
            </div>
        </div>

        <!-- Show chosen month -->
        <div class="nav-element">
            <span class="bold" id="current-month">
                <?php
                echo $date->format('F Y');
                ?>
            </span>
        </div>

        <!-- Logout button -->
        <div class="nav-element logout hover">
            <a href="/calendar/logout-user.php" id="logout-anchor">
                <img src="img/icon-logout.png" alt="Logout" id="logout">
            </a>
        </div>

    </nav>

    <!-- Main content -->
    <main>

        <!-- Left calendar -->
        <div id="left-tab">
            <div id="calendar">
                <div id="calendar-header">
                    <div id="calendar-month" class="bold">
                        <?php
                        echo $date->format('F Y');
                        ?>
                    </div>
                    <div class="week-change bold hover calendar-change">
                        <span>
                            <?php
                            $firstDayOfLastMonth = (clone $date)->modify('first day of last month');
                            echo '<a href="/calendar/regular.php?date=' . $firstDayOfLastMonth->format('Y-m-d') . '">
                                &#60;
                                </a>';
                            ?>
                        </span>
                    </div>
                    <div class="week-change bold hover calendar-change">
                        <span>
                            <?php
                            $firstDayOfNextMonth = (clone $date)->modify('first day of next month');
                            echo '<a href="/calendar/regular.php?date=' . $firstDayOfNextMonth->format('Y-m-d') . '">
                                &#62;
                                </a>';
                            ?>
                        </span>
                    </div>
                </div>
                <div id="calendar-days">

                    <!-- MTWTFSS -->
                    <div id="days-of-week">
                        <span>M</span>
                        <span>T</span>
                        <span>W</span>
                        <span>T</span>
                        <span>F</span>
                        <span>S</span>
                        <span>S</span>
                    </div>

                    <!-- Calendar itself -->
                    <div id="day-dates">
                        <?php

                        $firstDayOfCalendarMonth = (clone $date)->modify('first day of this month')->modify('monday this week');
                        $lastDayOfCalendarMonth = (clone $date)->modify('last day of this month')->modify('sunday this week');

                        for ($row = 1; $row <= 6; $row++) {

                            echo '<div class="week-days">';

                            for ($column = 1; $column <= 7; $column++) {
                                if ($firstDayOfCalendarMonth->format('m') != $date->format('m')) {
                                    echo '<a class="hover" style="color: #b4b4b4;" href="/calendar/regular.php?date=' . $firstDayOfCalendarMonth->format('Y-m-d') . '"><span>' . $firstDayOfCalendarMonth->format('d') . '</span></a>';
                                } else if ($firstDayOfCalendarMonth->format('m-d') == (new DateTime())->format('m-d')) {
                                    echo '<a class="hover current-day" href="/calendar/regular.php?date=' . $firstDayOfCalendarMonth->format('Y-m-d') . '"><span>' . $firstDayOfCalendarMonth->format('d') . '</span></a>';
                                } else if ($firstDayOfCalendarMonth->format('m-d') == $date->format('m-d')) {
                                    echo '<a class="hover chosen-day" href="/calendar/regular.php?date=' . $firstDayOfCalendarMonth->format('Y-m-d') . '"><span>' . $firstDayOfCalendarMonth->format('d') . '</span></a>';
                                } else {
                                    echo '<a class="hover" href="/calendar/regular.php?date=' . $firstDayOfCalendarMonth->format('Y-m-d') . '"><span>' . $firstDayOfCalendarMonth->format('d') . '</span></a>';
                                }
                                $firstDayOfCalendarMonth->modify('+1 days');
                            }

                            echo '</div>';
                        }

                        ?>
                    </div>

                </div>
            </div>
            <div id="shift-info">
                <div class="regular">Regular (09:00-17:00)</div>
            </div>
        </div>


        <div id="right-tab">

            <!-- Calendar header -->
            <div id="week-days">
                <div class="week-day t">
                    <h2>T</h2>
                </div>
                <div class="week-day">
                    <?php
                    $mondayDate = (clone $date)->modify('this week');
                    echo '<h2>Monday - ' . $mondayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $tuesdayDate = (clone $date)->modify('this week +1 days');
                    echo '<h2>Tuesday - ' . $tuesdayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $wednesdayDate = (clone $date)->modify('this week +2 days');
                    echo '<h2>Wednesday - ' . $wednesdayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $thursdayDate = (clone $date)->modify('this week +3 days');
                    echo '<h2>Thursday - ' . $thursdayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $fridayDate = (clone $date)->modify('this week +4 days');
                    echo '<h2>Friday - ' . $fridayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $saturdayDate = (clone $date)->modify('this week +5 days');
                    echo '<h2>Saturday - ' . $saturdayDate->format('d') . '</h2>';
                    ?>
                </div>
                <div class="week-day">
                    <?php
                    $sundayDate = (clone $date)->modify('this week +6 days');
                    echo '<h2>Sunday - ' . $sundayDate->format('d') . '</h2>';
                    ?>
                </div>
            </div>

            <!-- Calendar content -->
            <div class="wrapper">
                <div id="time-of-day">
                    <!-- Regular -->
                    <div id="regular" class="time-of-day">
                        <div class="week-day time bold regular t">R</div>
                        <?php

                        $connection = connect();

                        $sql = "SELECT * 
                            FROM work_shift 
                            WHERE employee_id = ? 
                            AND (shift_date BETWEEN DATE(?) AND DATE(?)) 
                            AND (shift_time = 4 OR shift_time = 5)
                            ORDER BY shift_time ASC, is_shift DESC;";
                        $statement = $connection->prepare($sql);

                        $monday = (clone $date)->modify('this week');
                        $sunday = (clone $monday)->modify('+6 days');
                        $statement->execute([
                            $employeeId, $monday->format('Y-m-d'),
                            $sunday->format('Y-m-d')
                        ]);

                        // Work shifts from monday till sunday
                        $result = $statement->fetchAll();
                        $success = false;
                        // Iterate trough monday til sunday
                        for ($i = 1; $i <= 7; $i++) {
                            foreach ($result as $row) {
                                // If there is shift on current day
                                if ($row['shift_date'] == $monday->format('Y-m-d')) {
                                    $success = true;
                                    // If it is a shift
                                    if ($row['is_shift'] == "1") {
                                        if ($monday->format('Y-m-d') == $date->format('Y-m-d')) {
                                            echo '<div class="week-day time regular side-border top-border bottom-border">
                                                Shift
                                                </div>';
                                        } else {
                                            echo '<div class="week-day time regular">
                                                Shift
                                                </div>';
                                        }
                                        break;
                                    } else if ($row['shift_time'] == "5") {
                                        if ($monday->format('Y-m-d') == $date->format('Y-m-d')) {
                                            echo '<div class="week-day time vacation side-border top-border bottom-border">
                                                    Vacation
                                                    </div>';
                                        } else {
                                            echo '<div class="week-day time vacation">
                                                    Vacation
                                                    </div>';
                                        }
                                        break;
                                    } else {
                                        // Else the employee is just available
                                        if ($monday->format('Y-m-d') == $date->format('Y-m-d')) {
                                            echo '<div id=' . $row['shift_id'] . '
                                                class="week-day time regular side-border top-border bottom-border available"
                                                onmouseover="minusSymbol(this)" 
                                                onmouseout="availableSymbol(this)"
                                                onclick="removeAvailability(this)">
                                                <span>
                                                Available
                                                </span>
                                                </div>';
                                        } else {
                                            echo '<div id=' . $row['shift_id'] . '
                                                class="week-day time regular available"
                                                onmouseover="minusSymbol(this)" 
                                                onmouseout="availableSymbol(this)"
                                                onclick="removeAvailability(this)">
                                                <span>
                                                Available
                                                </span>
                                                </div>';
                                        }
                                        break;
                                    }
                                }
                            }

                            // Check if there is no shift today
                            if (!$success) {
                                $formatted = $monday->format('Y-m-d');
                                $availability = "'$formatted', 4, $employeeId";
                                if ($monday->format('Y-m-d') == $date->format('Y-m-d')) {
                                    if ($monday < new DateTime()) {
                                        echo '<div class="week-day time past top-border side-border">
                                        <span class="no-shift">
                                        x
                                        </span>
                                        </div>';
                                    } else {
                                        echo '<div class="week-day time side-border top-border"
                                        onmouseover="plusSymbol(this)" 
                                            onmouseout="xSymbol(this)" 
                                            onclick="insertAvailability(' . $availability . ')">
                                            <span class="no-shift">
                                            x
                                            </span>
                                            </div>';
                                    }
                                } else if ($monday < new DateTime()) {
                                    echo '<div class="week-day time past">
                                        <span class="no-shift">
                                        x
                                        </span>
                                        </div>';
                                } else {
                                    echo '<div class="week-day time" 
                                        onmouseover="plusSymbol(this)" 
                                        onmouseout="xSymbol(this)" 
                                        onclick="insertAvailability(' . $availability . ')">
                                        <span class="no-shift">
                                        x
                                        </span>
                                        </div>';
                                }
                            }

                            $success = false;
                            $monday->modify('+1 days');
                        }

                        $connection = null;

                        ?>
                    </div>
                </div>
            </div>

        </div>

    </main>

    <!-- Scripts -->
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
    <script src="js/script.js"></script>
</body>

</html>