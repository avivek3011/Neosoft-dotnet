function checkNullOrEmpty(element) {
    var tbVal=$(element).val()
    if (tbVal == "" || tbVal == null) {
        $(element).css({
            "border": "1px solid red",
            "background": "#FFCECE"
        });
    }
}