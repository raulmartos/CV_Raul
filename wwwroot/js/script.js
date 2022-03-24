$('.checkbox').click(function () {
    if ($('input.checkbox').is(':checked')) {
        $('.theme').attr('href', 'css/styleDark.css');
    } else {
        $('.theme').attr('href', 'css/style.css');
    }
});