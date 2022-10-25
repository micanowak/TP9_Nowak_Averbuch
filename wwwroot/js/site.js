
function MostrarHotel(IdHotel) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleActoresAjax',
        data: { IdHotel: IdH },
        success: function(response) {
            $("#NombreHotel").html(response.nombre);
            $("#StatusHabitacion").html("1. Habitación: " + response.statusNivel);
            $("#StatusHabitacion").html("2. Habitación: " + response.statusNivel);
            $("#StatusHabitacion").html("3. Habitación: " + response.statusNivel);

        },
        error: function(xhr, status) {
            alert('Disculpe, existe un problema')
        },
        complete: function(xhr, status) {
            console.log('Petición realizada');
        }
    });
