
$(document).ready(function(){
    $('.mainCategory li').on('hover',function () {
        var categoryId = $(this).attr('id');
        console.log("Hovered Category Id: " + categoryId);
        alert(123)
        // Perform any other actions with categoryId here
    });
});
