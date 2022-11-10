
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
}

function BuscarReserva() {
    var Reserva = $("#Numero").val();
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/BuscarReservaAjax',
        data: { IdReserva: Reserva },
        success: function(response) {
            var formu = '<form method="post" action="/Home/GuardarModificacionReserva" enctype="multipart/form-data" class="formReserva" name="formReservar">';
            formu += '<p> Fecha de Ingreso <br/>';
            formu += '<input type="date" name="fechaIN" value="'+response.fechaIN.substring(0,10) + '"/>';
            formu += '<input type="hidden" name="IdReserva" value="'+response.idReserva + '"/>';
            formu += '<br/><br/>Fecha de Salida <br/>';
            formu += '<input type="date" name="fechaOUT" value="'+response.fechaOUT.substring(0,10) + '"/><br/><br/>';
            formu += '<label for="fkHotel">¿Qué Hotel buscas?</label><br/><select name="fkHotel" id="fkHotel">';
            if (response.fkHotel==1)
            {
                formu += '<option value="1" selected>Hotel 1</option><option value="2">Hotel 2</option><option value="3">Hotel 3</option></select><br/><br/>';
            }
            if (response.fkHotel==2)
            {
                formu += '<option value="1" >Hotel 1</option><option value="2" selected>Hotel 2</option><option value="3">Hotel 3</option></select><br/><br/>';
            }
            if (response.fkHotel==3)
            {
                formu += '<option value="1">Hotel 1</option><option value="2">Hotel 2</option><option value="3" selected>Hotel 3</option></select><br/><br/>';
            }
            formu += '<label for="fkHabitacion">¿Qué Habitación quieres?</label><br/><select name="fkHabitacion" id="fkHabitacion">';
            if (response.fkHabitacion==1)
            {
                formu += '<option value="1" selected>Habi 1</option><option value="2">Habi 2</option><option value="3">Habi 3</option></select></br><br/>';
            }
            if (response.fkHabitacion==2)
            {
                formu += '<option value="1">Habi 1</option><option value="2" selected>Habi 2</option><option value="3">Habi 3</option></select></br><br/>';
            }
            if (response.fkHabitacion==3)
            {
                formu += '<option value="1">Habi 1</option><option value="2">Habi 2</option><option value="3" selected>Habi 3</option></select></br><br/>';
            }
            formu += 'Nombre Completo <br/><input type="text" name="Nombre" value="'+response.nombre + '"/><br/><br/>';
            formu += 'DNI <br/><input type="number" name="DNI" value="'+response.dni + '"/><br/><br/><input type="submit" value="Guardar"></p>';
            formu += '</form>';

            $("#DatosReserva").html(formu);
        },
        error: function(xhr, status) {
            alert('Disculpe, existe un problema')
        },
        complete: function(xhr, status) {
            console.log('Petición realizada');
        }
    });

}
