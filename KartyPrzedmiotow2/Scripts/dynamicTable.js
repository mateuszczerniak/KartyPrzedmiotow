$(document).ready(function () {

    function fixIds(table)
    {
        var name = table.find('.table-name');
        var inputs = table.find('input');
        for (var i = 0; i < inputs.length; i++) {
            $(inputs[i]).attr('name', name.attr('name') + '[' + i + '].Nazwa');
            $(inputs[i]).attr('id', name.attr('id') + '_' + i + '__Nazwa');
        }
    }

    $(".add_row").click(function () {
        var table = $(this).parent();
        var rows = table.find('.list-rows');
        rows.append("<tr><td><input name='name' type='text' class='form-control input-md full-width' /> </td></tr>");
        fixIds(table);
    });
    $(".delete_row").click(function () {
        var table = $(this).parent();
        var rows = table.find('.list-rows');
        var trs = rows.find('tr');
        if (trs.length > 1) {
            var tr = trs[trs.length - 1];
            $(tr).parent()[0].removeChild(tr);
        }
    });
    $(".add_dropdown_row").click(function () {
        var table = $(this).parent();
        var rows = table.find('.list-rows');
        var trs = rows.find('tr');
        var dropdown1 = table.find(".dropdown").clone();
        dropdown1.removeClass("hide");
        var tr = document.createElement("tr");

        var shortcut = table.find('.shortcut');
        var td1 = document.createElement("td");
        td1.innerHTML = shortcut.html() + (trs.length + 1);
        tr.appendChild(td1)
        var td2 = document.createElement("td");

        var name = table.find('.table-name');
        dropdown1.attr('name', name.attr('name') + '[' + trs.length + ']');
        dropdown1.attr('id', name.attr('id') + '_' + trs.length + '_');

        td2.appendChild(dropdown1[0]);
        tr.appendChild(td2)
        rows.append(tr);
        fixIds(table);
    });
    $(".add_shortcut_row").click(function () {
        var table = $(this).parent();
        var rows = table.find('.list-rows');
        var trs = rows.find('tr');
        var input = $($.parseHTML("<input name='name' type='text' class='form-control input-md full-width' />"));
        
        var tr = document.createElement("tr");

        var shortcut = table.find('.shortcut');
        var td1 = document.createElement("td");
        td1.innerHTML = shortcut.html() + (trs.length + 1);
        tr.appendChild(td1)
        var td2 = document.createElement("td");

        var name = table.find('.table-name');
        input.attr('name', name.attr('name') + '[' + trs.length + '].Nazwa');
        input.attr('id', name.attr('id') + '_' + trs.length + '__Nazwa');

        td2.appendChild(input[0]);
        tr.appendChild(td2)
        rows.append(tr);
        fixIds(table);
    });
    $(".delete_dropdown_row").click(function () {
        var table = $(this).parent();
        var rows = table.find('.list-rows');
        var trs = rows.find('tr');
        var tr = trs[trs.length - 1];
        $(tr).parent()[0].removeChild(tr);
    });
});