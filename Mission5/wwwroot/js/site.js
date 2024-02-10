// Wait for the document to be fully loaded before executing any jQuery code
$(document).ready(function () {
    // Attach a click event handler to the element with the id 'calculateBtn'
    $('#calculateBtn').click(function () {
        // Retrieve the value entered by the user for the number of hours and parse it as a float
        var hours = parseFloat($('#hours').val());
        // Retrieve the value entered by the user for the hourly rate, remove the dollar sign, and parse it as a float
        var hourlyRate = parseFloat($('#hourlyRate').val().replace('$', ''));

        // Check if the entered value for hours is not a number or is less than or equal to zero
        if (isNaN(hours) || hours <= 0) {
            // If the condition is met, display an alert message and exit the function
            alert('Please enter a positive number of hours.');
            return;
        }

        // Calculate the total by multiplying the number of hours by the hourly rate
        var total = hours * hourlyRate;
        // Update the text content of the element with the id 'total' to display the total amount
        $('#total').text('Total: $' + total.toFixed(2));
    });
});


