function plusSymbol(element) {
    element.children[0].textContent = "+";
}

function xSymbol(element) {
    element.children[0].textContent = "x";
}

function minusSymbol(element) {
    element.children[0].textContent = "-";
}

function availableSymbol(element) {
    element.children[0].textContent = "Available";
}

function insertAvailability(date, time, employeeId) {
    $.ajax({
        method: "POST",
        url: '/calendar/insertavailability.php',
        data: {
            'action': 'call_this',
            'date': date,
            'time': time,
            'employeeId': employeeId
        },
        success: (function () {
            // Refresh page
            location.reload();
        })
    });
}

function removeAvailability(element) {
    var shiftId = element.id;
    $.ajax({
        method: "POST",
        url: '/calendar/removeavailability.php',
        data: {
            'action': 'call_this',
            'shiftId': shiftId
        },
        success: (function () {
            // Refresh page
            location.reload();
        })
    });
}
