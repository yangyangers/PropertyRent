// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Custom JavaScript for the property rental website

// Format currency input as PHP peso
function formatCurrency(input) {
    // Remove non-numeric characters
    let value = input.value.replace(/[^0-9]/g, '');

    // Format the number with thousands separator
    if (value !== '') {
        value = parseInt(value, 10).toLocaleString('en-PH');
    }

    // Add the peso symbol
    input.value = value;
}

// Toggle property availability
function toggleAvailability(id) {
    document.getElementById('togglePropertyId').value = id;
    document.getElementById('toggleAvailabilityForm').submit();
}

// Initialize Bootstrap tooltips
document.addEventListener('DOMContentLoaded', function () {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
});

// Initialize Bootstrap popovers
document.addEventListener('DOMContentLoaded', function () {
    var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
    var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
        return new bootstrap.Popover(popoverTriggerEl);
    });
});

// Validate form inputs
function validatePropertyForm(formId) {
    const form = document.getElementById(formId);

    if (!form) return true;

    // Basic validation example
    const title = form.querySelector('#Title').value;
    const price = form.querySelector('#RentalPrice').value;

    if (!title || title.trim() === '') {
        alert('Please enter a property title');
        return false;
    }

    if (!price || isNaN(parseFloat(price)) || parseFloat(price) < 1000) {
        alert('Please enter a valid rental price (minimum ₱1,000)');
        return false;
    }

    return true;
}

// Image preview functionality
function previewImage(event, previewId) {
    const reader = new FileReader();
    reader.onload = function () {
        const output = document.getElementById(previewId);
        output.src = reader.result;
    }

    reader.readAsDataURL(event.target.files[0]);
}