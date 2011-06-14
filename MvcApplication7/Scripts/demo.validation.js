var demoValidation = demoValidation || {};

demoValidation.checkcoolfactor = function (value, metals) {
    if (value.split(' ').length != 2)
        return false;
    var valueMetal = value.split(' ')[0];
    var isValid = false;
    $.each(metals.split(','), function (index, item) {
        if (valueMetal == item)
            isValid = true;
    });

    return isValid;
}

$.validator.addMethod("checkcoolfactor", function (value, element, metals) {
    return demoValidation.checkcoolfactor(value, metals);
});
$.validator.unobtrusive.adapters.addSingleVal('checkcoolfactor', 'metals', 'checkcoolfactor');
