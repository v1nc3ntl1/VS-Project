function Click() {
    $.post('../ShoppingCart/GetFullText', function(data) {
        alert(data);
    });
}