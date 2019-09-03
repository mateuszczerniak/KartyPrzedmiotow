$(document).ready(function () {
    var i = 1;
    $("#add_row").click(function () {
        $('#addr' + i).html("<td>MP" + (i + 1) + "</td><td><select class='form-control' "  + i + "><option>Jan Kowalski</option><option>Adam Nowak</option></select></td>");

        $('#tab_logic').append('<tr id="addr' +(i + 1) + '"></tr>');
        i++;
    });
    $("#delete_row").click(function () {
        if (i > 1) {
            $("#addr" +(i - 1)).html('');
            i--;
        }
    });



    var j = 1;
    $("#add_row2").click(function () {
        $('#add' + j).html("<td>MC" + (j + 1) + "</td><td><select class='form-control' " + j + "><option>Jan Kowalski</option><option>Adam Nowak</option></select></td>");

        $('#tab_logic2').append('<tr id="add' + (j + 1) + '"></tr>');
        j++;
    });
    $("#delete_row2").click(function () {
        if (j > 1) {
            $("#add" + (j - 1)).html('');
            j--;
        }
    });


    var k = 1;
    $("#add_row3").click(function () {
        $('#ad' + k).html("<td>MS" + (k + 1) + "</td><td><select class='form-control' " + k + "><option>Jan Kowalski</option><option>Adam Nowak</option></select></td>");

        $('#tab_logic3').append('<tr id="ad' + (k + 1) + '"></tr>');
        k++;
    });
    $("#delete_row3").click(function () {
        if (k > 1) {
            $("#ad" + (k - 1)).html('');
            k--;
        }
    });


    var l = 1;
    $("#add_row4").click(function () {
        $('#a' + l).html("<td>ME" + (l + 1) + "</td><td><select class='form-control' " + l + "><option>Jan Kowalski</option><option>Adam Nowak</option></select></td>");

        $('#tab_logic4').append('<tr id="a' + (l + 1) + '"></tr>');
        l++;
    });
    $("#delete_row4").click(function () {
        if (l > 1) {
            $("#a" + (l - 1)).html('');
            l--;
        }
    });


    var m = 1;
    $("#add_row5").click(function () {
        $('#b' + m).html("<td>MO" + (m + 1) + "</td><td><select class='form-control' " + m + "><option>Jan Kowalski</option><option>Adam Nowak</option></select></td>");

        $('#tab_logic5').append('<tr id="b' + (m + 1) + '"></tr>');
        m++;
    });
    $("#delete_row5").click(function () {
        if (m > 1) {
            $("#b" + (m - 1)).html('');
            m--;
        }
    });

    var n = 1;
    $("#add_row6").click(function () {
        $('#bb' + n).html("<td>" + (n + 1) + "</td><td><input name='name" + n + "' type='text' class='form-control input-md'  /> </td>");

        $('#tab_logic6').append('<tr id="bb' + (n + 1) + '"></tr>');
        n++;
    });
    $("#delete_row6").click(function () {
        if (n > 1) {
            $("#bb" + (n - 1)).html('');
            n--;
        }
    });

});