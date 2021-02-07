


$(document).ready(function () {

    $('#btnForm').click(function () {

        //var datapost = new Object();
        //datapost.title = $('#title').val();
        //datapost.body = $('#body').val();


        $.ajax({
            url: '/JSONExamples/NewPostsjson',
            type: 'POST',

            //contentType: 'application/json',
            data:  {
                title: $('#title').val(),
                body: $('#body').val()
            },


            success: function (data) {

                console.log(data)

            },
            error: function (error) {
                console.log(`Error ${error}`)
            }


        });


    });



    $.ajax({
        url: '/JsonExamples/PostsGetjson',
        type: 'GET',
        //var tbody = $('#myTable').children('tbody');

        success: function (data) {

            console.log(data);

            //$('#myTable').append('<tr><td>my data</td><td>more data</td></tr>');
            //console.log(`This is ${soMany} times easier!`);

           
            //$('a').click(function () {
            //    $('#myTable tbody').append('<tr class="child"><td>blahblah</td></tr>');
            //});



            $.each(data, function (i, value) {

                $('#myTable tbody').last().append(`<tr> <td>${value.userId}</td> <td>${value.id}</td> <td>${value.title}</td> <td>${value.body}</td> </tr>`);

                //$('#myTable tr:last').after(`<tr> <td>${value.userId}</td> <td>${value.id}</td> <td>${value.title}</td> <td>${value.body}</td> </tr>`);
                //$("#myTable").children("tbody").append(`< tr > <td>${value.userId}</td> <td>${value.id}</td> <td>${value.title}</td> <td>${value.body}</td> </tr >`);

              

             });



        },
        error: function (error) {
            console.log(`Error ${error}`)
        }






    });


 



});